using System.Collections.ObjectModel;

namespace ApiGateway.WebApp.Permissions.Modules
{
    public static class LogisticaPermissions
    {
        public const string All = "logistica:all";

        public static readonly IEnumerable<string> PermissionsList = new List<string> { All };
    }
}
