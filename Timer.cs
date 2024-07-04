using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Collections.Specialized.BitVector32;

namespace pomodoro_dotnet
{
    public partial class Timer : Form
    {
        int sessionDuration;
        int breakDuration = 5;
        int[] timerValues = { 0, 0 };
        bool exitConfirmed = false;
        bool isOnSession = true;
        

        public Timer(int session)
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(Timer_FormClosing);

            sessionDuration = session;
            timerValues[0] = sessionDuration;
            timerValues[1] = 0;

            SetTimer();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            SetTimer();

            if (isOnSession)
            {
                if (timerValues[1] > 0)
                {
                    timerValues[1]--;
                }
                else
                {
                    timerValues[0]--;
                    timerValues[1] = 59;
                }
                if (timerValues[0] == 0 && timerValues[1] == 0)
                {
                    isOnSession = false;
                    SessionChanged();
                    timerValues[0] = 5;
                    timerValues[1] = 0;
                }
            }
            else
            {
                if (timerValues[1] > 0)
                {
                    timerValues[1]--;
                }
                else
                {
                    timerValues[0]--;
                    timerValues[1] = 59;
                }

                if (timerValues[0] == 0 && timerValues[1] == 0)
                {
                    isOnSession = true;
                    SessionChanged();
                    timerValues[0] = sessionDuration;
                    timerValues[1] = 0;
                }
            }
        }

        private void SetTimer()
        {
            int min = timerValues[0];
            int sec = timerValues[1];

            if (min < 10)
            {
                lblTimer.Text = $"0{min}:";
            }
            else
            {
                lblTimer.Text = $"{min}:";
            }

            if (sec < 10)
            {
                lblTimer.Text += $"0{sec}";
            }
            else
            {
                lblTimer.Text += sec;
            }

            if (isOnSession)
            {
                lblTimer.ForeColor = Color.FromArgb(255, 238, 83, 75);
                lblFeed.Text = "just do it";
            }
            else
            {
                lblTimer.ForeColor = Color.FromArgb(156, 220, 254);
                lblFeed.Text = "break";
            }
        }

        private void chkOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnTop.Checked) { this.TopMost = true; } else { this.TopMost = false; }
        }

        private void Timer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exitConfirmed) { return; }

            DialogResult result = MessageBox.Show("Really?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                exitConfirmed = true;
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void SessionChanged()
        {
            SystemSounds.Beep.Play();
            this.Activate();
        }
    }
}
