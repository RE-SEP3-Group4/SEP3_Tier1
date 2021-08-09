using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Text.Json;
using SEP3_Tier1.Models;
using SEP3_Tier1.Data;
namespace SEP3_Tier1.Authentication
{
    public class CustomAuthentication : AuthenticationStateProvider
    {
        private static readonly IJSRuntime jSRuntime;
        private JsonSerializerOptions options =
        new JsonSerializerOptions
        {
            DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
            IgnoreNullValues = true,
            IgnoreReadOnlyProperties = true,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            ReadCommentHandling = JsonCommentHandling.Skip,
            WriteIndented = false
        };
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            ClaimsIdentity identity = new ClaimsIdentity();
            var serialisedData = await jSRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
            if(serialisedData != null)
            {
                User user = UserService.getInstance().GetUser();
                user = JsonSerializer.Deserialize<User>(serialisedData, options);
                if(user != null)
                {
                    identity = SetupClaimsForUser(user);
                }
            }
            
            ClaimsPrincipal cashedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cashedClaimsPrincipal));
        }
        public static async Task ValidateLogin(User user)
        {
            ClaimsIdentity identity = new ClaimsIdentity();
            identity = SetupClaimsForUser(user);
            string serializedData = JsonSerializer.Serialize(user);
            await jSRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serializedData);
            UserService.getInstance().SetUser(user);
           
        }

        public void LogOut()
        {
            UserService.getInstance().SetUser(null);
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            jSRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
        private static ClaimsIdentity SetupClaimsForUser(User user)
        {
            List<Claim> claims = new List<Claim>();
            ClaimsIdentity identity;
            user = UserService.getInstance().GetUser();
            if(user != null)
            {
                claims.Add(new Claim(ClaimTypes.Name , user.username));
                claims.Add(new Claim("http://example.org/claims/securityLevel", "securityLevel", user.securityLevel.ToString()));
                
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
