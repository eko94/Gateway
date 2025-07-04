using ApiGateway.WebApp.Permissions.Modules;
using Nur.Store2025.Access.Catalog.Permissions;
using Nur.Store2025.Access.Contracts;
using System.Collections.ObjectModel;

namespace ApiGateway.WebApp.Routes.Modules
{
    public class NutricionRoutes
    {
        public static readonly IEnumerable<ScopeAccessRule> Routes = new ReadOnlyCollection<ScopeAccessRule>(new List<ScopeAccessRule>
        {
            new ScopeAccessRule { RouteTemplate = "/nutricion:8080/health", HttpMethod = "GET", AllowAnonymous = true },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Personas", HttpMethod = "POST", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Personas/{id}", HttpMethod = "GET", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Personas", HttpMethod = "GET", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Nutricionistas", HttpMethod = "POST", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Nutricionistas/{id}", HttpMethod = "GET", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Nutricionistas", HttpMethod = "GET", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Pacientes", HttpMethod = "POST", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Pacientes/{id}", HttpMethod = "GET", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Pacientes", HttpMethod = "GET", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Consultas", HttpMethod = "POST", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Consultas/{id}", HttpMethod = "GET", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Consultas", HttpMethod = "GET", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Planes/Crear-Plan", HttpMethod = "POST", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Planes/{id}", HttpMethod = "GET", RequiredScope = NutricionPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/nutricion/Planes", HttpMethod = "GET", RequiredScope = NutricionPermissions.All }
        });
    }
}
