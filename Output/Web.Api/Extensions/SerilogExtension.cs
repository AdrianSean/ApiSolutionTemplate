﻿using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;

namespace $safeprojectname$
{
    public static class SerilogExtension
    {
        public static IServiceCollection AddSerilogServices(this IServiceCollection services, LoggerConfiguration configuration)
        {
            Log.Logger = configuration.CreateLogger();
            AppDomain.CurrentDomain.ProcessExit += (s, e) => Log.CloseAndFlush();
            return services.AddSingleton(Log.Logger);
        }

        
        /// <summary>
        /// Register the Serilog service for console logging only.
        /// </summary>
        public static IServiceCollection AddSerilogServices(this IServiceCollection services)
        {
            return services.AddSerilogServices(
                new LoggerConfiguration()
                    .MinimumLevel.Verbose()
                    .WriteTo.Console());
        }


        /// <summary>
        /// Register the Serilog service for SQL Service and console logging.
        /// </summary>
        public static IServiceCollection AddSerilogServices(this IServiceCollection services, string sqlConnectionString)
        {
            return services.AddSerilogServices(
                new LoggerConfiguration()
                    .MinimumLevel.Verbose()
                    .WriteTo.Console()
                    .WriteTo.MSSqlServer(sqlConnectionString, "ApiEventLog"));
        }
    }
}
