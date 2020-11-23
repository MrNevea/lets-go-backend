using LetsGo.Core.Models;
using LetsGo.Core.Resources.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsGo.Api.Controllers
{
    public class AuthController : Controller
    {
        private readonly IConfiguration configuration;

        public AuthController(IConfiguration configuration)
        {
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Login")]
        public IActionResult Login([FromBody] LoginUserResource user)
        {
            return Ok();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Register")]
        public IActionResult Register([FromBody] RegisterUserResource user)
        {
            return Ok();
        }
    }
}
