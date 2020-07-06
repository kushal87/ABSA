using System;
using System.Net.Http;
using System.Threading.Tasks;
using ABSA.UserDetails.Model;
using Newtonsoft.Json;

namespace ABSA.UserDetails.Data
{
    public class RestService
    {
        HttpClient client;

        public RestService()    
        {
            client = new HttpClient();
        }

        public async Task<PeopleResponse> GetPeopleResponse()
        {
            var response = await client.GetStringAsync(Constant.peopleUrl);
            var peopleResponse = JsonConvert.DeserializeObject<PeopleResponse>(response);            
            return peopleResponse;
        }
    
    }
}
