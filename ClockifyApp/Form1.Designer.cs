
namespace ClockifyApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.projectComboBox = new System.Windows.Forms.ComboBox();
			this.startBtn = new System.Windows.Forms.Button();
			this.runTmr = new System.Windows.Forms.Timer(this.components);
			this.timeText = new System.Windows.Forms.MaskedTextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// projectComboBox
			// 
			this.projectComboBox.FormattingEnabled = true;
			this.projectComboBox.Location = new System.Drawing.Point(12, 12);
			this.projectComboBox.Name = "projectComboBox";
			this.projectComboBox.Size = new System.Drawing.Size(382, 23);
			this.projectComboBox.TabIndex = 0;
			// 
			// startBtn
			// 
			this.startBtn.Location = new System.Drawing.Point(17, 100);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(75, 24);
			this.startBtn.TabIndex = 1;
			this.startBtn.Text = "Start";
			this.startBtn.UseVisualStyleBackColor = true;
			this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
			// 
			// runTmr
			// 
			this.runTmr.Interval = 1000;
			// 
			// timeText
			// 
			this.timeText.Location = new System.Drawing.Point(98, 101);
			this.timeText.Mask = "90:00:00";
			this.timeText.Name = "timeText";
			this.timeText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.timeText.Size = new System.Drawing.Size(100, 23);
			this.timeText.TabIndex = 3;
			this.timeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.timeText.ValidatingType = typeof(System.DateTime);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(98, 70);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(100, 23);
			this.progressBar1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Daily Total";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(213, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Weekly Total";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Monthly Total";
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(98, 41);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(100, 23);
			this.progressBar2.TabIndex = 8;
			// 
			// progressBar3
			// 
			this.progressBar3.Location = new System.Drawing.Point(292, 41);
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(100, 23);
			this.progressBar3.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(204, 101);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(188, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Make the weekly suffering end";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 151);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.progressBar3);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.timeText);
			this.Controls.Add(this.startBtn);
			this.Controls.Add(this.projectComboBox);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Fuckin Clockify";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox projectComboBox;
		private System.Windows.Forms.Button startBtn;
		private System.Windows.Forms.Timer runTmr;
		private System.Windows.Forms.MaskedTextBox timeText;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.ProgressBar progressBar3;
		private System.Windows.Forms.Button button1;
	}
}

