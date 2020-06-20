﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalCurrencyWallet.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DigitalCurrencyWallet.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class UserProfileController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        public UserProfileController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        //GET : /api/UserProfile
        public async Task<Object> GetUserProfile()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);
            return new
            {
                user.Email
            };
        }
    }
}