using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Services;

namespace WebApp.ViewComponents
{
    public class UserViewComponent:ViewComponent
    {
        private IUserService _userService;
        public UserViewComponent(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var user = await _userService.Get_User_Async(id);
            return View(user);
        }
    }
}
