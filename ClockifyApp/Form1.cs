using Clockify.Net;
using Clockify.Net.Models.Projects;
using Clockify.Net.Models.TimeEntries;
using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace ClockifyApp
{
	public partial class Form1 : Form
	{
		private readonly ClockifyClient _clockifyClient;
		private bool _running = false;
		private DateTimeOffset _startTime = DateTimeOffset.MinValue;
		private readonly string _workspaceId = "";
		private string _userId = string.Empty;
		private TaskbarManager TaskbarProcess = TaskbarManager.Instance;
		private List<Project> projects = new();
		private static readonly HttpClient client = new HttpClient();

		public Form1()
		{
			InitializeComponent();
			_clockifyClient = new ClockifyClient(Properties.Resources.ApiKey);
			_workspaceId = Properties.Resources.WorkspaceId;
			client.BaseAddress = new Uri("https://app.runn.io/api");
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			var projects = _clockifyClient.FindAllProjectsOnWorkspaceAsync(_workspaceId).Result.Data;
			var user = await _clockifyClient.GetCurrentUserAsync();
			_userId = user.Data.Id;
			projectComboBox.DisplayMember = "Name";
			projectComboBox.DataSource = projects;

			TaskbarProcess.SetProgressState(TaskbarProgressBarState.Normal);

			// get values from Runn
			RunnProject runnProject = null;
			HttpResponseMessage response = await client.GetAsync("/projects");
			if (response.IsSuccessStatusCode)
			{
				//runnProject = await response.Content.ReadAsAsync<RunnProject>();
			}

			// set max value of projects

			// build dashboard with counters
			for (int i = 0; i < 5; i++)
			{
				var label = new Label();
				label.Text = $"label {i}";
				label.Location = new System.Drawing.Point(17, 130 + (i * 30));
				var progress = new ProgressBar();
				progress.Location = new System.Drawing.Point(17 + label.Width, 130 + (i*30));
				Controls.Add(label);
				Controls.Add(progress);
			}
		}

		private async void startBtn_Click(object sender, EventArgs e)
		{
			if (!_running)
			{
				_running = true;
				_startTime = DateTimeOffset.Now;
				runTmr.Tick += RunningTimerTick;
				runTmr.Start();
				startBtn.Text = "Stop";
			}
			else
			{
				_running = false;
				runTmr.Stop();

				var timeEntryRequest = new TimeEntryRequest
				{
					Start = _startTime,
					End = DateTimeOffset.Now,
					ProjectId = (projectComboBox.SelectedItem as ProjectDtoImpl).Id,
					UserId = _userId
				};
				var res = await _clockifyClient.CreateTimeEntryAsync(_workspaceId, timeEntryRequest);
				startBtn.Text = "Start";
			}
		}

		private void RunningTimerTick(object sender, EventArgs e)
		{
			var timeSinceStartTime = DateTimeOffset.Now - _startTime;
			timeText.Text = timeSinceStartTime.ToString("c");
			TaskbarProcess.SetProgressValue(timeSinceStartTime.Seconds, 100);
		}
	}
}
