using ApiGateway.WebApp.Permissions.Modules;
using Nur.Store2025.Access.Catalog.Permissions;
using Nur.Store2025.Access.Contracts;
using System.Collections.ObjectModel;

namespace ApiGateway.WebApp.Routes.Modules
{
    public class LogisticaRoutes
    {
        public static readonly IEnumerable<ScopeAccessRule> Routes = new ReadOnlyCollection<ScopeAccessRule>(new List<ScopeAccessRule>
        {
            new ScopeAccessRule { RouteTemplate = "/logistica:8080/health", HttpMethod = "GET", AllowAnonymous = true },
            new ScopeAccessRule { RouteTemplate = "/api/logistica/Clientes", HttpMethod = "POST", RequiredScope = LogisticaPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/logistica/Clientes/{id}", HttpMethod = "GET", RequiredScope = LogisticaPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/logistica/Clientes", HttpMethod = "GET", RequiredScope = LogisticaPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/logistica/Entregas", HttpMethod = "POST", RequiredScope = LogisticaPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/logistica/Entregas/{id}", HttpMethod = "GET", RequiredScope = LogisticaPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/logistica/Entregas", HttpMethod = "GET", RequiredScope = LogisticaPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/logistica/OrdenesTrabajoFinalizado", HttpMethod = "POST", RequiredScope = LogisticaPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/logistica/OrdenesTrabajoFinalizado/{id}", HttpMethod = "GET", RequiredScope = LogisticaPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/logistica/OrdenesTrabajoFinalizado", HttpMethod = "GET", RequiredScope = LogisticaPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/logistica/Programacion", HttpMethod = "POST", RequiredScope = LogisticaPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/logistica/Programacion/{id}", HttpMethod = "GET", RequiredScope = LogisticaPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/logistica/Programacion", HttpMethod = "GET", RequiredScope = LogisticaPermissions.All }
        });
    }
}
