using ApiGateway.WebApp.Access;
using ApiGateway.WebApp.Permissions;
using ApiGateway.WebApp.Routes;
using Nur.Store2025.Security;
using Nur.Store2025.Security.Config;

namespace ApiGateway.WebApp.Extensions;

public static class SecurityExtensions
{
    public static IServiceCollection AddSecurityAccessRules(this IServiceCollection services, IConfiguration configuration)
    {
        JwtOptions jwtOptions = services.BuildServiceProvider()
            .GetRequiredService<JwtOptions>();
        services.AddSecurity(jwtOptions, NurtricenterPermissions.PermissionsList);
        services.AddSingleton(new ScopeRouteMatcher(NurtricenterRoutes.RouteList));
        return services;
    }
}
