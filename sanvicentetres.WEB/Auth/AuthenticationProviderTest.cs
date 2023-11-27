using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace sanvicentetres.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //await Task.Delay(3000);
            var anonimous = new ClaimsIdentity();
            var edwinVicente = new ClaimsIdentity(new List<Claim>
            {
                new Claim("FirstName","Edwin"),
                new Claim("LastName","Vicente"),
                new Claim(ClaimTypes.Name, "edwin@yopmail.com"),
                new Claim(ClaimTypes.Role, "Admin")
            }, authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(edwinVicente)));
        }
    }

}
