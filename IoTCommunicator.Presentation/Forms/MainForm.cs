using IoTCommunicator.Business.Interfaces;
using IoTCommunicator.Presentation.CustomComponents;

namespace IoTCommunicator.Presentation.Forms
{
    public partial class MainForm : Form
    {
        private readonly IApiService _apiService;
        private bool _sideBarExpand;
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
        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (_sideBarExpand)
            {
                sideBarContainer.Width -= 10;
                if (sideBarContainer.Width == sideBarContainer.MinimumSize.Width)
                {
                    _sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBarContainer.Width += 10;
                if (sideBarContainer.Width == sideBarContainer.MaximumSize.Width)
                {
                    _sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void ShowToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }
        private void InitializePictureBoxes()
        {
            pictureBox_DoorOn.Visible = false;
            pictureBox_DoorOff.Visible = false;
            pictureBox_SwitchOn.Visible = false;
            pictureBox_SwitchOff.Visible = false;
            pictureBox_TakoLine.Visible = false;
            pictureBox_TakoPeak.Visible = false;
        }

        private async void getAiData_Click(object sender, EventArgs e)
        {
            await FetchDataAsync(
                async () => await _apiService.GetAiValueScaledAsync(),
                (values) => listInputValues.Items.Add($"Ai{values.Index}: {values.Item.AiValueScaled}")
            );
        }

        private async void getDiData_Click(object sender, EventArgs e)
        {
            await FetchDataAsync(async () => await _apiService.GetDiStatusAsync(),
                (values) => listInputValues.Items.Add($"Di{values.Index}: {values.Item.DiStatus}")
            );
        }

        private async Task FetchDataAsync<T>(Func<Task<List<T>>> fetchDataFunc, Action<(int Index, T Item)> addItemAction)
        {
            try
            {
                var values = await fetchDataFunc();

                if (values == null || !values.Any())
                {
                    MessageBox.Show("No data received", "Error");
                    return;
                }

                listInputValues.Items.Clear();
                for (int i = 0; i < values.Count; i++)
                {
                    addItemAction((i, values[i]));
                }
            }
            catch (Exception ex)
            {
                listInputValues.Items.Clear();
                ShowToast("ERROR",ex.Message);
            }
        }

        private async void timerStatus_Tick(object sender, EventArgs e)
        {
            try
            {
                var diStatuses = await _apiService.GetDiStatusAsync();
                var aiValues = await _apiService.GetAiValueScaledAsync();

                if (diStatuses == null || !diStatuses.Any())
                {
                    lbl_DoorStatusText.Text = "No DI data received";
                    return;
                }

                UpdateDoorStatus(diStatuses[0].DiStatus);
                UpdateSwitchStatus(diStatuses[1].DiStatus);
                UpdateTakoStatus(diStatuses[0].DiStatus);
                UpdateTakoValue(aiValues[0].AiValueScaled);
            }
            catch (Exception ex)
            {
                lbl_DoorStatusText.Text = $"Error: {ex.Message}";
            }
        }

        private void UpdateTakoStatus(int takoStatus)
        {
            SetPictureBoxVisibility(pictureBox_TakoPeak, pictureBox_TakoLine, takoStatus == 1);
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

        private void UpdateTakoValue(double aiValueScaled)
        {
            textBox_TakoValue.Text = aiValueScaled.ToString();
        }
    }
}
