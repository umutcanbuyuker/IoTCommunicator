using IoTCommunicator.Business.Dto;
using IoTCommunicator.Business.Models;

namespace IoTCommunicator.Business.Interfaces
{
    public interface IApiService
    {
        Task<List<AiValueModel>> GetAiValueScaledAsync();
        Task<List<DiStatusModel>> GetDiStatusAsync();
        bool PingDevice(string ipAddress);
    }
}
