using ApiGateway.WebApp.Permissions.Modules;
using Nur.Store2025.Access.Catalog.Permissions;
using Nur.Store2025.Access.Contracts;
using System.Collections.ObjectModel;

namespace ApiGateway.WebApp.Routes.Modules
{
    public class CateringRoutes
    {
        public static readonly IEnumerable<ScopeAccessRule> Routes = new ReadOnlyCollection<ScopeAccessRule>(new List<ScopeAccessRule>
        {
            #region Health
            new ScopeAccessRule
            {
                RouteTemplate = "/catering:8080/health",
                HttpMethod = "GET",
                AllowAnonymous = true
            },
            #endregion
            #region OrdenTrabajo
            new ScopeAccessRule
            {
                RouteTemplate = "/api/catering/ordentrabajo",
                HttpMethod = "POST",
                RequiredScope = CateringPermissions.OrdenTrabajo.All
            },
            new ScopeAccessRule
            {
                RouteTemplate = "/api/catering/ordentrabajo/preparar-receta",
                HttpMethod = "POST",
                RequiredScope = CateringPermissions.OrdenTrabajo.All
            },
            new ScopeAccessRule
            {
                RouteTemplate = "/api/catering/ordentrabajo/empaquetar-comidas",
                HttpMethod = "POST",
                RequiredScope = CateringPermissions.OrdenTrabajo.All
            },
            new ScopeAccessRule
            {
                RouteTemplate = "/api/catering/ordentrabajo/etiquetar-comidas",
                HttpMethod = "POST",
                RequiredScope = CateringPermissions.OrdenTrabajo.All
            },
            new ScopeAccessRule
            {
                RouteTemplate = "/api/catering/ordentrabajo/cancelar-orden",
                HttpMethod = "PUT",
                RequiredScope = CateringPermissions.OrdenTrabajo.All
            },
            new ScopeAccessRule
            {
                RouteTemplate = "/api/catering/ordentrabajo/{id}",
                HttpMethod = "GET",
                RequiredScope = CateringPermissions.OrdenTrabajo.All
            },
            new ScopeAccessRule
            {
                RouteTemplate = "/api/catering/ordentrabajo/obtener-por-usuario-estado",
                HttpMethod = "GET",
                RequiredScope = CateringPermissions.OrdenTrabajo.All
            },
            #endregion OrdenTrabajo
            #region Usuario
            new ScopeAccessRule
            {
                RouteTemplate = "/api/catering/usuario/obtener-usuarios",
                HttpMethod = "GET",
                RequiredScope = CateringPermissions.Usuario.All
            }
            #endregion
        });
    }
}
