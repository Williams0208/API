using Newtonsoft.Json;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Service
{
    public static class ApiService
    {
        public static async Task<bool> Register(string name, string userName,string password)
        {
            var httpClient = new HttpClient();
            var content = new MultipartFormDataContent
            {
                {new StringContent(name),"Name" },
                {new StringContent(userName),"UserName" },
                {new StringContent(password),"Password" },
            };
            var ApiResponse = await httpClient.PostAsync(AppSettings.ApiUrl + "api/users/Register2",content);
            if (!ApiResponse.IsSuccessStatusCode) return false;
            return true;
        }
        public static async Task<bool>Login(string user,string password)
        {
            var login = new User()
            {
                UserName = user,
                Password = password
            };
            var httpClient = new HttpClient();
            var jsonRegister = JsonConvert.SerializeObject(login);
            var content = new StringContent(jsonRegister, Encoding.UTF8, "application/json");
            var ApiResponse = await httpClient.PostAsync(AppSettings.ApiUrl + "api/users/login2", content);
            if (!ApiResponse.IsSuccessStatusCode) return false;
            return true;
            
        }

    }
}
