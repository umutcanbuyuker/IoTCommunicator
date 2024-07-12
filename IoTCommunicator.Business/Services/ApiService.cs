using IoTCommunicator.Business.Interfaces;
using IoTCommunicator.Business.Models;
using IoTCommunicator.Data.DataContext.Repositories.Abstract;

namespace IoTCommunicator.Business.Services
{
    public class ApiService : IApiService
    {
        private readonly IApiRepository _apiRepository;
        public ApiService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }
        public async Task<List<AiValueModel>> GetAiValueScaledAsync()
        {
            var slotData = await _apiRepository.GetAiDataAsync();
            return slotData.Io.Ai.Select(a => new AiValueModel { AiValueScaled = a.AiValueScaled }).ToList();
        }

        public async Task<string> GetAiValueScaledAsync2()
        {
            var slotdata = await _apiRepository.GetAiDataAsync2();
            return slotdata;
        }
    }
}
