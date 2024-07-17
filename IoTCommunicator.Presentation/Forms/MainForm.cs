using IoTCommunicator.Business.Interfaces;

namespace IoTCommunicator.Presentation.Forms
{
    public partial class MainForm : Form
    {
        private readonly IApiService _apiService;
        public MainForm(IApiService apiService)
        {
            _apiService = apiService;
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            timerStatus.Start();
            InitializePictureBoxes();
        }

        private void InitializePictureBoxes()
        {
            pictureBox_DoorOn.Visible = false;
            pictureBox_DoorOff.Visible = false;
            pictureBox_SwitchOn.Visible = false;
            pictureBox_SwitchOff.Visible = false;
        }

        private async void btnFetchAiData_Click(object sender, EventArgs e)
        {
            try
            {
                var values = await _apiService.GetAiValueScaledAsync();

                if (values == null || !values.Any())
                {
                    MessageBox.Show("No data received", "Error");
                    return;
                }

                listInputValues.Items.Clear();
                for (int i = 0; i < values.Count; i++)
                {
                    listInputValues.Items.Add($"Ai{i}: {values[i].AiValueScaled}");
                }
            }
            catch (Exception ex)
            {
                listInputValues.Items.Clear();
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private async void getDiData_Click(object sender, EventArgs e)
        {
            try
            {
                var values = await _apiService.GetDiStatusAsync();

                if (values == null || !values.Any())
                {
                    MessageBox.Show("No DI data received", "Error");
                    return;
                }

                listInputValues.Items.Clear();
                for (int i = 0; i < values.Count; i++)
                {
                    listInputValues.Items.Add($"Di{i}: {values[i].DiStatus}");
                }
            }
            catch (Exception ex)
            {
                listInputValues.Items.Clear();
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private async void timerStatus_Tick(object sender, EventArgs e)
        {
            try
            {
                var diStatuses = await _apiService.GetDiStatusAsync();

                if (diStatuses == null || !diStatuses.Any())
                {
                    lbl_DoorStatusText.Text = "No DI data received";
                    return;
                }

                UpdateDoorStatus(diStatuses[0].DiStatus);
                UpdateSwitchStatus(diStatuses[1].DiStatus);

            }
            catch (Exception ex)
            {
                lbl_DoorStatusText.Text = $"Error: {ex.Message}";
            }
        }

        private void UpdateDoorStatus(int doorStatus)
        {
            SetPictureBoxVisibility(pictureBox_DoorOn, pictureBox_DoorOff, doorStatus == 1);
        }


        private void UpdateSwitchStatus(int switchStatus)
        {
            SetPictureBoxVisibility(pictureBox_SwitchOn, pictureBox_SwitchOff, switchStatus == 1);
        }

        private void SetPictureBoxVisibility(PictureBox onPictureBox, PictureBox offPictureBox, bool isOn)
        {
            onPictureBox.Visible = isOn;
            offPictureBox.Visible = !isOn;
        }
    }
}
