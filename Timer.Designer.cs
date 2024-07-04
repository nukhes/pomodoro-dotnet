namespace pomodoro_dotnet
{
    partial class Timer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblFeed = new Label();
            lblTimer = new Label();
            timerClock = new System.Windows.Forms.Timer(components);
            chkOnTop = new CheckBox();
            lblSessionCount = new Label();
            SuspendLayout();
            // 
            // lblFeed
            // 
            lblFeed.AutoSize = true;
            lblFeed.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblFeed.ForeColor = Color.DimGray;
            lblFeed.Location = new Point(20, 62);
            lblFeed.Name = "lblFeed";
            lblFeed.Size = new Size(48, 20);
            lblFeed.TabIndex = 0;
            lblFeed.Text = "break";
            lblFeed.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Consolas", 32.25F, FontStyle.Bold);
            lblTimer.ForeColor = Color.FromArgb(64, 64, 64);
            lblTimer.Location = new Point(13, 22);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(142, 51);
            lblTimer.TabIndex = 1;
            lblTimer.Text = "00:00";
            lblTimer.TextAlign = ContentAlignment.TopCenter;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // chkOnTop
            // 
            chkOnTop.AutoSize = true;
            chkOnTop.ForeColor = SystemColors.ControlDarkDark;
            chkOnTop.Location = new Point(6, 100);
            chkOnTop.Name = "chkOnTop";
            chkOnTop.Size = new Size(99, 19);
            chkOnTop.TabIndex = 2;
            chkOnTop.Text = "always on top";
            chkOnTop.UseVisualStyleBackColor = true;
            chkOnTop.CheckedChanged += chkOnTop_CheckedChanged;
            // 
            // lblSessionCount
            // 
            lblSessionCount.AutoSize = true;
            lblSessionCount.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            lblSessionCount.ForeColor = Color.DimGray;
            lblSessionCount.Location = new Point(0, -3);
            lblSessionCount.Name = "lblSessionCount";
            lblSessionCount.Size = new Size(75, 19);
            lblSessionCount.TabIndex = 3;
            lblSessionCount.Text = "1st session";
            lblSessionCount.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Timer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(164, 121);
            Controls.Add(lblFeed);
            Controls.Add(lblSessionCount);
            Controls.Add(chkOnTop);
            Controls.Add(lblTimer);
            MaximizeBox = false;
            MaximumSize = new Size(180, 160);
            MinimizeBox = false;
            MinimumSize = new Size(180, 160);
            Name = "Timer";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFeed;
        private Label lblTimer;
        private System.Windows.Forms.Timer timerClock;
        private CheckBox chkOnTop;
        private Label lblSessionCount;
    }
}