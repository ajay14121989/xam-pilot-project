using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using MyPilotProject.RestAPIClient;
using MyPilotProject.Models;

namespace MyPilotProject.ServicesHandler
{
    class LoginService
    {

        public async Task<LoginResponseModel> CheckLoginIfExists(string username, string password)
        {
            LoginResponseModel check = await RestAPIClient.RestClient.checkLogin(username, password);

            return check;
        }
    }
}
