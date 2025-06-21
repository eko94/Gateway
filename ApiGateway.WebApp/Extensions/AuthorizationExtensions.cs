using Consul;

namespace ApiGateway.WebApp.Extensions;

public static class AuthorizationExtensions
{
    public const string CateringAuthPolicy = "CateringAuthPolicy";
    public const string CommercialAuthPolicy = "CommercialAuthPolicy";
    public const string NutricionAuthPolicy = "NutricionAuthPolicy";
    public const string LogisticaAuthPolicy = "LogisticaAuthPolicy";

    public static IServiceCollection AddNurtricenterAuthorization(this IServiceCollection services)
    {
        services.AddAuthorization(options =>
        {
            options.AddPolicy("AdminAuthPolicy", policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim("scope", "admin");
            });
            options.AddPolicy("CateringAuthPolicy", policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim("scope", "catering");
            });
            options.AddPolicy("CommercialAuthPolicy", policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim("scope", "commercial");
            });
            options.AddPolicy("NutricionAuthPolicy", policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim("scope", "nutricion");
            });
            options.AddPolicy("LogisticaAuthPolicy", policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim("scope", "logistica");
            });
        });

        return services;
    }
}
