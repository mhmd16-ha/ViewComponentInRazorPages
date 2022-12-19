using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class UserService : IUserService
    {
        public async Task<List<User>> Get_Users_Async()
        {
            using(var Client = new HttpClient())
            {
                var EndPoint = "https://jsonplaceholder.typicode.com/users";
                var jsonResult =await Client.GetStringAsync(EndPoint);
                return JsonConvert.DeserializeObject<List<User>>(jsonResult);

            }
        }

        public async Task<User> Get_User_Async(int id)
        {
            using (var Client = new HttpClient())
            {
                var EndPoint = $"https://jsonplaceholder.typicode.com/users/{id}";
                var jsonResult = await Client.GetStringAsync(EndPoint);
                return JsonConvert.DeserializeObject<User>(jsonResult);

            }
        }
    }
}
