namespace IoTCommunicator.Presentation.CustomComponents
{
    public partial class ToastForm : Form
    {
        int toastX, toastY;
        public ToastForm(string type, string message)
        {
            InitializeComponent();
            label_ToastType.Text = type;
            label_ToastMessage.Text = message;
            switch (type) {
                case "SUCCESS":
                    panel_ToastColor.BackColor = Color.FromArgb(57, 155, 53);
                    break;
                case "ERROR":
                    panel_ToastColor.BackColor = Color.FromArgb(227, 50, 45);
                    pictureBox_Toast.Image = Properties.Resources.icon_alert_error;
                    break;
                case "INFO":
                    panel_ToastColor.BackColor = Color.FromArgb(18, 136, 191);
                    break;
                case "WARNING":
                    panel_ToastColor.BackColor = Color.FromArgb(245, 171, 35);
                    break;
            }
        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 200;
            toastY = ScreenHeight - this.Height - 200;

            this.Location = new Point(toastX, toastY);
        }

        private void timer_Toast_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 760)
            {
                timer_Toast.Stop();
                timer_ToastHide.Start();
            }
        }
        int hideY = 350;
        private void timer_ToastHide_Tick(object sender, EventArgs e)
        {
            hideY--;
            if (hideY <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY > 800)
                {
                    timer_ToastHide.Stop();
                    hideY = 100;
                    this.Close();
                }
            }
        }
    }
}
