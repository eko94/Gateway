using ApiGateway.WebApp.Permissions.Modules;
using Consul;
using Microsoft.Extensions.Hosting;
using Nur.Store2025.Access;
using Nur.Store2025.Access.Contracts;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Threading.Channels;

namespace ApiGateway.WebApp.Routes.Modules
{
    public class CommercialRoutes
    {
        public static readonly IEnumerable<ScopeAccessRule> Routes = new ReadOnlyCollection<ScopeAccessRule>(new List<ScopeAccessRule>
        {
            #region Health
            new ScopeAccessRule { RouteTemplate = "/commercial:8080/health", HttpMethod = "GET", AllowAnonymous = true },
            #endregion
            #region Catalogs
            new ScopeAccessRule { RouteTemplate = "/api/commercial/catalogs", HttpMethod = "GET", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/catalogs", HttpMethod = "POST", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/catalogs/{id}", HttpMethod = "GET", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/catalogs/{id}", HttpMethod = "PUT", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/catalogs/{id}", HttpMethod = "DELETE", RequiredScope = CommercialPermissions.All },
            #endregion
            #region Contracts
            new ScopeAccessRule { RouteTemplate = "/api/commercial/contracts", HttpMethod = "POST", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/contracts", HttpMethod = "GET", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/contracts/by-paciente/{pacienteId}", HttpMethod = "GET", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/contracts/{id}", HttpMethod = "GET", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/contracts/{id}/activate", HttpMethod = "POST", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/contracts/{id}/cancel", HttpMethod = "POST", RequiredScope = CommercialPermissions.All },
            #endregion
            #region Patients
            new ScopeAccessRule { RouteTemplate = "/api/commercial/patients", HttpMethod = "POST", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/patients", HttpMethod = "GET", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/patients/{id}", HttpMethod = "GET", RequiredScope = CommercialPermissions.All },
            #endregion
            #region Services
            new ScopeAccessRule { RouteTemplate = "/api/commercial/services", HttpMethod = "GET", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/services", HttpMethod = "POST", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/services/{id}", HttpMethod = "GET", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/services/{id}", HttpMethod = "PUT", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/services/{id}/costs", HttpMethod = "POST", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/services/{id}/costs/history", HttpMethod = "GET", RequiredScope = CommercialPermissions.All },
            new ScopeAccessRule { RouteTemplate = "/api/commercial/services/{id}/status", HttpMethod = "PUT", RequiredScope = CommercialPermissions.All },
            #endregion
        });
    }
}
