using IoTCommunicator.Business.Models;

namespace IoTCommunicator.Business.Interfaces
{
    public interface IApiService
    {
        Task<List<AiValueModel>> GetAiValueScaledAsync();
        Task<String> GetAiValueScaledAsync2();
    }
}
