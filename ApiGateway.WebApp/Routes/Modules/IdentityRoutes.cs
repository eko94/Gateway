using ApiGateway.WebApp.Permissions.Modules;
using Nur.Store2025.Access.Catalog.Permissions;
using Nur.Store2025.Access.Contracts;
using System.Collections.ObjectModel;

namespace ApiGateway.WebApp.Routes.Modules
{
    public class IdentityRoutes
    {
        public static readonly IEnumerable<ScopeAccessRule> Routes = new ReadOnlyCollection<ScopeAccessRule>(new List<ScopeAccessRule>
        {
            new ScopeAccessRule
            {
                RouteTemplate = "/identity:8080/health",
                HttpMethod = "GET",
                AllowAnonymous = true
            },
            new ScopeAccessRule
            {
                RouteTemplate = "/api/identity/security/login",
                HttpMethod = "POST",
                AllowAnonymous = true
            },
            new ScopeAccessRule
            {
                RouteTemplate = "/api/identity/security/register-user",
                HttpMethod = "POST",
                AllowAnonymous = true
            }
        });
    }
}
