using System;
using ABSA.UserDetails.Model;
using System.Threading.Tasks;
using System.Net.Http;

namespace ABSA.UserDetails.ViewModel
{
    public class PeopleViewModel
    {       
        public async Task<PeopleResponse> callABSAWebService()
        {
           var response = await App.RestService.GetPeopleResponse();
            return response;
        }
    }
}
