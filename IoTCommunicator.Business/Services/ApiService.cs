using IoTCommunicator.Business.Dto;
using IoTCommunicator.Business.Interfaces;
using IoTCommunicator.Business.Models;
using IoTCommunicator.Data.DataContext.Repositories.Abstract;
using System.Net.NetworkInformation;

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
        public async Task<List<DiStatusModel>> GetDiStatusAsync()
        {
            var slotData = await _apiRepository.GetDiDataAsync();
            return slotData.Io.Di.Select(d => new DiStatusModel { DiStatus = d.DiStatus }).ToList();
        }

        public bool PingDevice(string ipAddress)
        {
            using (var ping = new Ping())
            {
                try
                {
                    var reply = ping.Send(ipAddress, 1000); // 1 saniye timeout
                    return reply.Status == IPStatus.Success;
                }
                catch (PingException)
                {
                    return false;
                }
            }
        }
    }
}
