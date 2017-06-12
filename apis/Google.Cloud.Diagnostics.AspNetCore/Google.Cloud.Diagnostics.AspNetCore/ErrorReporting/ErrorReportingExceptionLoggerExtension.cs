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

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    ///  Uses the Google Cloud Error Reporting Exception Logger Middleware.
    ///  To ensure all unhandled exceptions are reported, this should be
    ///  the first piece of middleware used.
    /// </summary>
    /// 
    /// <example>
    /// <code>
    /// public void ConfigureServices(IServiceCollection services)
    /// {
    ///     string projectId = "[Google Cloud Platform project ID]";
    ///     string serviceName = "[Name of service]";
    ///     string version = "[Version of service]";
    ///     services.AddGoogleExceptionLogging(projectId, serviceName, version);
    ///     ...
    /// }
    /// </code>
    /// </example>
    /// 
    /// <example>
    /// <code>
    /// public void Configure(IApplicationBuilder app)
    /// {
    ///     // Use before handling any requests to ensure all unhandled exceptions are reported.
    ///     app.UseGoogleExceptionLogging();
    ///     ...
    /// }
    /// </code>
    /// </example>
    /// 
    /// <remarks>
    /// Reports unhandled exceptions to Google Cloud Error Reporting.
    /// Docs: https://cloud.google.com/error-reporting/docs/
    /// </remarks>
    public static class ErrorReportingExceptionLoggerExtension
    {
        /// <summary>
        /// Uses middleware that will report all uncaught exceptions to the Stackdriver
        /// Error Reporting API.
        /// </summary>
        /// <param name="app">The application builder. Cannot be null.</param>   
        public static void UseGoogleExceptionLogging(this IApplicationBuilder app)
        {
            GaxPreconditions.CheckNotNull(app, nameof(app));
            app.UseMiddleware<ErrorReportingExceptionLoggerMiddleware>();
        }

        /// <summary>
        /// Adds services for middleware that will report all uncaught exceptions to the
        /// Stackdriver Error Reporting API.
        /// <para>
        /// Can be used when running on Google App Engine or Google Compute Engine.
        /// The Google Cloud Platform project to report errors to will detected from the
        /// current platform.
        /// </para>
        /// </summary>
        /// <param name="services">The service collection. Cannot be null.</param>
        /// <param name="setupAction">Action to set up options. Cannot be null.</param>
        public static void AddGoogleExceptionLogging(
            this IServiceCollection services, Action<ErrorReportingServiceOptions> setupAction)
        {
            GaxPreconditions.CheckNotNull(services, nameof(services));
            GaxPreconditions.CheckNotNull(setupAction, nameof(setupAction));

            var serviceOptions = new ErrorReportingServiceOptions();
            setupAction(serviceOptions);
            var serviceName = GaxPreconditions.CheckNotNull(serviceOptions.ServiceName, nameof(serviceOptions.ServiceName));
            var version = GaxPreconditions.CheckNotNull(serviceOptions.Version, nameof(serviceOptions.Version));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton(ErrorReportingContextExceptionLogger.Create(
                serviceOptions.ProjectId, serviceName, version, serviceOptions.Options));
            services.AddSingleton(CreateExceptionLogger);
        }


        /// <summary>
        /// Creates an <see cref="IExceptionLogger"/>.
        /// </summary>
        private static IExceptionLogger CreateExceptionLogger(IServiceProvider provider)
        {
            var accessor = provider.GetServiceCheckNotNull<IHttpContextAccessor>();
            var contextLogger = provider.GetServiceCheckNotNull<IContextExceptionLogger>();
            return new GoogleExceptionLogger(contextLogger, accessor);
        }
    }
}