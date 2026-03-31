// Copyright (c) 2021 - 2024 DHGMS Solutions and Contributors. All rights reserved.
// DHGMS Solutions and Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Whipstaff.Aspire.Hosting;
using Whipstaff.Aspire.Hosting.HealthChecksUI;
using Whipstaff.Aspire.Hosting.ZedAttackProxy;

namespace VitaeCyclum.AspireAppHost
{
    /// <summary>
    /// Hosts the application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main entry point for the application.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            var builder = GetDistributedApplicationBuilder(args);

            var app = builder.Build();
            app.Run();
        }

        private static IDistributedApplicationBuilder GetDistributedApplicationBuilder(string[] args)
        {
            var builder = DistributedApplication.CreateBuilder(args);

            builder.AddProject<Projects.DPVreony_Website>("public-website");

            return builder;
        }
    }
}
