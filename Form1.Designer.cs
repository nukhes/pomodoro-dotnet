namespace pomodoro_dotnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtDuration = new TextBox();
            lblSession = new Label();
            btnStartPomodoro = new Button();
            SuspendLayout();
            // 
            // txtDuration
            // 
            txtDuration.BackColor = Color.White;
            txtDuration.Font = new Font("Segoe UI", 12F);
            txtDuration.Location = new Point(9, 31);
            txtDuration.MaxLength = 2;
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(174, 29);
            txtDuration.TabIndex = 0;
            txtDuration.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSession.ForeColor = Color.FromArgb(64, 64, 64);
            lblSession.Location = new Point(6, 10);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(162, 17);
            lblSession.TabIndex = 3;
            lblSession.Text = "Session duration (minutes)";
            // 
            // btnStartPomodoro
            // 
            btnStartPomodoro.Location = new Point(9, 66);
            btnStartPomodoro.Name = "btnStartPomodoro";
            btnStartPomodoro.Size = new Size(174, 36);
            btnStartPomodoro.TabIndex = 5;
            btnStartPomodoro.Text = "Start";
            btnStartPomodoro.UseVisualStyleBackColor = true;
            btnStartPomodoro.Click += btnStartPomodoro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(191, 114);
            Controls.Add(btnStartPomodoro);
            Controls.Add(lblSession);
            Controls.Add(txtDuration);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(207, 153);
            MinimizeBox = false;
            MinimumSize = new Size(207, 153);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDuration;
        private Label lblSession;
        private Button btnStartPomodoro;
    }
}
