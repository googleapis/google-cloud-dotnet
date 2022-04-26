// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Google.Cloud.Diagnostics.AspNetCore3
{
    /// <summary>
    ///  Uses the Google Cloud Error Reporting Exception Logger Middleware.
    ///  To ensure all unhandled exceptions are reported, this should be
    ///  the first piece of middleware used.
    /// </summary>
    [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore3.AspNetCoreErrorReportingExtensions instead.")]
    public static class ErrorReportingExceptionLoggerExtension
    {
        /// <summary>
        /// Uses middleware that will report all uncaught exceptions to the Google Cloud
        /// Error Reporting API.
        /// </summary>
        /// <param name="app">The application builder. Must not be null.</param>
        [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore3.AspNetCoreErrorReportingExtensions.AddGoogleErrorReportingForAspNetCore " +
            "for configuring Google Cloud Error Reporting in ASP.NET Core applications. There's no need to explicitly register the middleware.")]
        public static IApplicationBuilder UseGoogleExceptionLogging(this IApplicationBuilder app)
        {
            GaxPreconditions.CheckNotNull(app, nameof(app));
            return app.UseMiddleware<ErrorReportingExceptionLoggerMiddleware>();
        }

        /// <summary>
        /// Adds services for middleware that will report all uncaught exceptions to the
        /// Google Cloud Error Reporting API.
        /// <para>
        /// Can be used when running on Google App Engine or Google Compute Engine.
        /// The Google Cloud Platform project to report errors to will detected from the
        /// current platform.
        /// </para>
        /// </summary>
        /// <param name="services">The service collection. Must not be null.</param>
        /// <param name="setupAction">Action to set up options. Must not be null.</param>
        /// <remarks>
        /// If <see cref="RetryOptions.ExceptionHandling"/> is set to <see cref="ExceptionHandling.Propagate"/>
        /// and the <see cref="RequestDelegate"/> executed by this middleware throws an exception and this
        /// diagnostics library also throws an exception trying to report it an <see cref="AggregateException"/>
        /// with both exceptions will be thrown.  Otherwise only the exception from the <see cref="RequestDelegate"/>
        /// will be thrown.
        /// </remarks>
        [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore3.AspNetCoreErrorReportingExtensions.AddGoogleErrorReportingForAspNetCore instead.")]
        public static IServiceCollection AddGoogleExceptionLogging(
            this IServiceCollection services, Action<ErrorReportingServiceOptions> setupAction)
        {
            GaxPreconditions.CheckNotNull(services, nameof(services));
            GaxPreconditions.CheckNotNull(setupAction, nameof(setupAction));

            var serviceOptions = new ErrorReportingServiceOptions();
            setupAction(serviceOptions);

            return services.AddGoogleErrorReportingForAspNetCore(registerMiddleware: false, new Common.ErrorReportingServiceOptions
            {
                ProjectId = serviceOptions.ProjectId,
                ServiceName = serviceOptions.ServiceName,
                Version = serviceOptions.Version,
                Options = serviceOptions.Options
            });
        }
    }
}
