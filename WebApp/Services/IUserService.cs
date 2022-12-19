using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    interface IUserService
    {
         Task<List<User>> Get_Users_Async();
         Task<User> Get_User_Async(int id);


    }
}
