﻿
using Domain;
using Microsoft.AspNetCore.Identity;
using Persitense;

namespace API.Extensions;

public  static class IdentityServiceExtensions
{
    public static IServiceCollection AddIdentityServices(this IServiceCollection services,
        ConfigurationManager builderConfiguration)
    {
        // services.AddIdentity<Book,IdentityRole>().
        //     AddDefaultTokenProviders().
        //     AddEntityFrameworkStores<DataContext>();
        
       
        return services;
    }
}