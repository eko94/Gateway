using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiGateway.WebApp.Controllers
{
    [Authorize]
    [Route("api/{controller}")]
    public class SecurityController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<string> Login()
        {
            return await generateJwtToken(new User { Id = 1, UserName = "test", Password = "test" });
        }
        //https://medium.com/@codewithankitsahu/authentication-and-authorization-in-net-8-web-api-94dda49516ee
        private async Task<string> generateJwtToken(User user)
        {
            //Generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = await Task.Run(() =>
            {

                var key = Encoding.ASCII.GetBytes("HL#6j=4;5H{5qZ#M=6J!1[W<YvWdbzEif|M]:ZB<6<{ap^K!@Tg{];OD0E");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)                    
                };
                return tokenHandler.CreateToken(tokenDescriptor);
            });

            return tokenHandler.WriteToken(token);
        }

        public class User
        {
            public int Id { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
