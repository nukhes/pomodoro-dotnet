namespace pomodoro_dotnet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartPomodoro_Click(object sender, EventArgs e)
        {
            try
            {
                goToTimer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void goToTimer()
        {
            int sessionDuration = Convert.ToInt32(txtDuration.Text);
            string alert = "The duration of a session should be between 10 and 55 minutes";

            if (sessionDuration <= 55 && sessionDuration >= 10)
            {
                Form timerForm = new Timer(sessionDuration);
                timerForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(alert, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
