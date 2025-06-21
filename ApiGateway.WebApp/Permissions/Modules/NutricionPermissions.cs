using System.Collections.ObjectModel;

namespace ApiGateway.WebApp.Permissions.Modules
{
    public static class NutricionPermissions
    {
        public const string All = "nutricion:all";

        public static readonly IEnumerable<string> PermissionsList = new List<string> { All };
    }
}
