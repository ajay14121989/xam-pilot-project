using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using MyPilotProject.Models;

namespace MyPilotProject.RestAPIClient
{
    public class RestClient
    {
        private const string MainWebServiceUrl = "https://api.mocki.io/v1/";
        private const string LoginWebServiceUrl = "https://reqres.in/";

        internal static async Task<LoginResponseModel> checkLogin(string email_value, string password_value)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(LoginWebServiceUrl);
           
            string json = JsonConvert.SerializeObject(new { email = email_value, password = password_value });
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("api/login",content);
             var data = await response.Content.ReadAsStringAsync();
            var userresult = JsonConvert.DeserializeObject<LoginResponseModel>(data);
            return new LoginResponseModel { token= userresult.token };
        }

       

        internal static async Task<SalesListResponse> getSalesData()
        {
            var httpClient = new HttpClient();


            var response = await httpClient.GetAsync("https://api.mocki.io/v1/935cd971");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var data = await response.Content.ReadAsStringAsync();


                var list = JsonConvert.DeserializeObject<SalesListResponse>(data);
                return list;
            }
            else
            {
                return null;
            }



        }
    }
}
