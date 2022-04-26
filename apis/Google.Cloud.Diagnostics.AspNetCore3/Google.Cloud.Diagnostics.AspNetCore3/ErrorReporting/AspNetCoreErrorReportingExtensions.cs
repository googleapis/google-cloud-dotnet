// Copyright 2021 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// Extensions for configuring Google Cloud Error Reporting in ASP.NET Core applications.
    /// </summary>
    public static class AspNetCoreErrorReportingExtensions
    {
        /// <summary>
        /// Configures Google Cloud Error Reporting for ASP .NET Core applications./>.
        /// </summary>
        public static IServiceCollection AddGoogleErrorReportingForAspNetCore(
            this IServiceCollection services, Common.ErrorReportingServiceOptions options = null) =>
#pragma warning disable CS0618 // Type or member is obsolete
            services.AddGoogleErrorReportingForAspNetCore(true, options);
#pragma warning restore CS0618 // Type or member is obsolete

        [Obsolete("Added for avoiding code duplication while we made old methods obsolete and included substitutes")]
        internal static IServiceCollection AddGoogleErrorReportingForAspNetCore(
            this IServiceCollection services, bool registerMiddleware, Common.ErrorReportingServiceOptions options)
        {
            services.AddGoogleErrorReporting(options);
            services.AddHttpContextAccessor();
            services.AddSingleton<IExceptionLogger>(sp => new GoogleExceptionLogger(
                sp.GetRequiredService<IContextExceptionLogger>(),
                sp.GetRequiredService<IHttpContextAccessor>()));

            if (registerMiddleware)
            {
                // This registers the trace middleware so users don't have to.
                services.AddSingleton<IStartupFilter, AspNetCoreErrorReportingStartupFilter>();
            }

            return services;
        }
    }
}
