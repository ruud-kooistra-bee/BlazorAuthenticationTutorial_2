using BlazorAuthenticationTutorial_2.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAuthenticationTutorial_2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<string>> Login(UserLoginDto request)
        {
            string token = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiQWFyb24gU3dhcnR6IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiTWFzdGVyIEhhY2tlciIsImV4cCI6MTY0Njk5MTA4MX0.yNvdCnbntwFppT-jQxay413hnds3-AD6LmEeeR-Iavs-gcv9uIdy3WuVMy-8cgAPs5WgNvNJPWCsNRn-IuX9xw";
            return token;
        }
    }
}
