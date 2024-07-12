using IoTCommunicator.Data.DataContext.Entities;
using IoTCommunicator.Data.DataContext.Repositories.Abstract;
using System.Text.Json;
using RestSharp;

namespace IoTCommunicator.Data.DataContext.Repositories.Concrete
{
    public class ApiRepository : IApiRepository
    {
        private readonly RestClient _restClient;
        public ApiRepository(RestClient client)
        {
            _restClient = client;
        }
        public async Task<SlotData> GetAiDataAsync()
        {
            var request = new RestRequest("/api/slot/0/io/ai", Method.Get);
            request.AddHeader("Accept", "vdn.dac.v1");
            var response = await _restClient.ExecuteAsync(request);

            if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
            {
                try
                {
                    var slotData = JsonSerializer.Deserialize<SlotData>(response.Content);
                    if (slotData == null)
                    {
                        throw new Exception("Deserialization returned null");
                    }
                    return slotData;
                }
                catch (JsonException jsonEx)
                {
                    throw new Exception("Error deserializing JSON response", jsonEx);
                }
            }
            else
            {
                throw new Exception("Error retrieving data from API");
            }
    }

        public Task<string> GetAiDataAsync2()
        {
            throw new NotImplementedException();
        }
    }
}
