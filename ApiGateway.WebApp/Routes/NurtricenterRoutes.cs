using ApiGateway.WebApp.Routes.Modules;
using Nur.Store2025.Access.Contracts;
using System.Collections.ObjectModel;

namespace ApiGateway.WebApp.Routes
{
    public class NurtricenterRoutes
    {
        public static readonly IEnumerable<ScopeAccessRule> RouteList;

        static NurtricenterRoutes()
        {
            List<ScopeAccessRule> list = 
            [
                .. IdentityRoutes.Routes,
                .. CateringRoutes.Routes,
                .. CommercialRoutes.Routes,
                .. NutricionRoutes.Routes,
                .. LogisticaRoutes.Routes
            ];
            RouteList = new ReadOnlyCollection<ScopeAccessRule>(list);
        }
    }
}
