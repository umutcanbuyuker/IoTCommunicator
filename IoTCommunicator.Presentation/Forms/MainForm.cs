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

                listAiValues.Items.Clear();
                for (int i = 0; i < values.Count; i++)
                {
                    listAiValues.Items.Add($"Ai{i}: {values[i].AiValueScaled}");
                }
            }
            catch (Exception ex)
            {
                listAiValues.Items.Clear();
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

                listDiValues.Items.Clear();
                for (int i = 0; i < values.Count; i++)
                {
                    listDiValues.Items.Add($"Di{i}: {values[i].DiStatus}");
                }
            }
            catch (Exception ex)
            {
                listAiValues.Items.Clear();
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private async void timerDoorStatus_Tick(object sender, EventArgs e)
        {
            try
            {
                var values = await _apiService.GetDiStatusAsync();

                if (values == null || !values.Any())
                {
                    lbl_DoorStatus.Text = "No DI data received";
                    panel_DoorStatus.BackColor = Color.Gray;
                    return;
                }

                var doorStatus = values.FirstOrDefault(d => d.DiStatus == 0)?.DiStatus ?? 0;

                if (doorStatus == 1)
                {
                    lbl_DoorStatus.Text = "Kapı Durumu: Açık";
                    panel_DoorStatus.BackColor = Color.Green;
                }
                else
                {
                    lbl_DoorStatus.Text = "Kapı Durumu: Kapalı";
                    panel_DoorStatus.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lbl_DoorStatus.Text = $"Error: {ex.Message}";
                panel_DoorStatus.BackColor = Color.Gray;
            }
        }
    }
}
