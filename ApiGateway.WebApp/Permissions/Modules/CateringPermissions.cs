using System.Collections.ObjectModel;

namespace ApiGateway.WebApp.Permissions.Modules
{
    public static class CateringPermissions
    {
        public static class OrdenTrabajo
        {
            private const string BasePermission = "catering.orden-trabajo:";
            public const string All = BasePermission + "all";
        }

        public static class Usuario
        {
            private const string BasePermission = "catering.usuario:";
            public const string All = BasePermission + "all";
        }

        public static readonly IEnumerable<string> PermissionsList = new List<string>{ OrdenTrabajo.All, Usuario.All };
    }
}
