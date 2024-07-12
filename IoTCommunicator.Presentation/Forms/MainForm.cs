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


        private async void button1_Click_1(object sender, EventArgs e)
        {
            var values = await _apiService.GetAiValueScaledAsync();
        }
    }
}
