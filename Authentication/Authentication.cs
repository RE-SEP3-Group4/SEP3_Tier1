using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Text.Json;
using SEP3_Tier1.Models;

namespace SEP3_Tier1.Data.Login
{
    public class Authentication : AuthenticationStateProvider
    {
        private readonly IJSRuntime jSRuntime;

        public Authentication(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            ClaimsIdentity identity = new ClaimsIdentity();
            identity = SetupClaimsForUser(UserService.GetUser());
            ClaimsPrincipal cashedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cashedClaimsPrincipal));
        }
        public async Task ValidateLogin(User user)
        {
            ClaimsIdentity identity = new ClaimsIdentity();
            identity = SetupClaimsForUser(user);
            string serializedData = JsonSerializer.Serialize(user);
            await jSRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serializedData);
            UserService.SetUser(user);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        }

        public void LogOut()
        {
            UserService.SetUser(null);
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            jSRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
        private ClaimsIdentity SetupClaimsForUser(User user)
        {
            List<Claim> claims = new List<Claim>();
            ClaimsIdentity identity;

            if(user != null)
            {
                claims.Add(new Claim(ClaimTypes.Name, user.username));
                //claims.Add(new Claim("securityLevel", user.securityLevel));
                identity = new ClaimsIdentity(claims, "apiauth_type");
                return identity;
            }
            claims.Add(new Claim(ClaimTypes.Name, "Not logged"));
            claims.Add(new Claim("securityLevel", "0"));
            identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }
    }
}
