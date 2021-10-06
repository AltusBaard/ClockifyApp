using Clockify.Net;
using Clockify.Net.Models.Projects;
using Clockify.Net.Models.TimeEntries;
using Microsoft.WindowsAPICodePack.Taskbar;
using System;
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

		public Form1()
		{
			InitializeComponent();
			_clockifyClient = new ClockifyClient(Properties.Resources.ApiKey);
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			var projects = _clockifyClient.FindAllProjectsOnWorkspaceAsync(_workspaceId).Result.Data;
			var user = await _clockifyClient.GetCurrentUserAsync();
			_userId = user.Data.Id;
			projectComboBox.DisplayMember = "Name";
			projectComboBox.DataSource = projects;

			TaskbarProcess.SetProgressState(TaskbarProgressBarState.Normal);
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
