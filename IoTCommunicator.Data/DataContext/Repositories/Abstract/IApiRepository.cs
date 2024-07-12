using IoTCommunicator.Data.DataContext.Entities;

namespace IoTCommunicator.Data.DataContext.Repositories.Abstract
{
    public interface IApiRepository
    {
        Task<SlotData> GetAiDataAsync();
        Task<string> GetAiDataAsync2();
    }
}
