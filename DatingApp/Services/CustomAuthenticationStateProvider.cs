using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
namespace DatingAppFSDProject.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CustomAuthenticationStateProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = _httpContextAccessor.HttpContext.User;
            var identity = user.Identity;

            if (identity.IsAuthenticated)
            {
                // User is authenticated, return the state with the user's claims
                var authenticatedUser = new ClaimsPrincipal(identity);
                return Task.FromResult(new AuthenticationState(authenticatedUser));
            }

            // Return an unauthenticated state if the user is not authenticated
            var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());
            return Task.FromResult(new AuthenticationState(anonymousUser));
        }

        // You can trigger a state change manually if needed
        public void MarkUserAsAuthenticated(string userName)
        {
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(new[]
            {
            new Claim(ClaimTypes.Name, userName)
        }, "apiauth"));
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(authenticatedUser)));
        }

        public void MarkUserAsLoggedOut()
        {
            var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(anonymousUser)));
        }
    }
}
