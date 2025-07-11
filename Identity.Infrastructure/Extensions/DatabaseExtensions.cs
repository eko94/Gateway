﻿using Identity.Infrastructure.Persistence;
using Identity.Infrastructure.Persistence.StoredModel;
using Joseco.DDD.Core.Abstractions;
using Joseco.Outbox.EFCore.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Identity.Infrastructure.Extensions;

public static class DatabaseExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var databaseSettings = services.BuildServiceProvider().GetRequiredService<DataBaseSettings>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<SecurityDbContext>(ctx => ctx.UseSqlServer(connectionString));

        services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
        {
            options.Password.RequiredLength = 8;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
            options.Lockout.MaxFailedAccessAttempts = 5;
        }).AddEntityFrameworkStores<SecurityDbContext>()
            .AddDefaultTokenProviders();

        services.AddScoped<IDatabase, SecurityDbContext>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IOutboxDatabase<DomainEvent>, UnitOfWork>();

        return services;
    }
}
