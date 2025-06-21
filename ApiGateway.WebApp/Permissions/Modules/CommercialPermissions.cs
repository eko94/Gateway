using System.Collections.ObjectModel;

namespace ApiGateway.WebApp.Permissions.Modules
{
    public static class CommercialPermissions
    {
        public const string All = "commercial:all";

        public static readonly IEnumerable<string> PermissionsList = new List<string> { All };
    }
}
