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
            SuspendLayout();
            // 
            // lblFeed
            // 
            lblFeed.AutoSize = true;
            lblFeed.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeed.ForeColor = Color.DimGray;
            lblFeed.Location = new Point(20, 46);
            lblFeed.Name = "lblFeed";
            lblFeed.Size = new Size(60, 25);
            lblFeed.TabIndex = 0;
            lblFeed.Text = "break";
            lblFeed.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Consolas", 32.25F, FontStyle.Bold);
            lblTimer.ForeColor = Color.FromArgb(64, 64, 64);
            lblTimer.Location = new Point(13, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(142, 51);
            lblTimer.TabIndex = 1;
            lblTimer.Text = "00:00";
            lblTimer.TextAlign = ContentAlignment.TopCenter;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 15;
            timerClock.Tick += timerClock_Tick;
            // 
            // chkOnTop
            // 
            chkOnTop.AutoSize = true;
            chkOnTop.Location = new Point(5, 101);
            chkOnTop.Name = "chkOnTop";
            chkOnTop.Size = new Size(99, 19);
            chkOnTop.TabIndex = 2;
            chkOnTop.Text = "always on top";
            chkOnTop.UseVisualStyleBackColor = true;
            chkOnTop.CheckedChanged += chkOnTop_CheckedChanged;
            // 
            // Timer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(164, 121);
            Controls.Add(chkOnTop);
            Controls.Add(lblTimer);
            Controls.Add(lblFeed);
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
    }
}