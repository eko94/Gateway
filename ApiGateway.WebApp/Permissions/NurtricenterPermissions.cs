using ApiGateway.WebApp.Permissions.Modules;
using System.Collections.ObjectModel;

namespace ApiGateway.WebApp.Permissions
{
    public class NurtricenterPermissions
    {
        public static readonly IEnumerable<string> PermissionsList;

        static NurtricenterPermissions()
        {
            List<string> list =
            [
                .. CateringPermissions.PermissionsList,
                .. CommercialPermissions.PermissionsList,
                .. NutricionPermissions.PermissionsList,
                .. LogisticaPermissions.PermissionsList,
            ];
            PermissionsList = new ReadOnlyCollection<string>(list);
        }
    }
}
