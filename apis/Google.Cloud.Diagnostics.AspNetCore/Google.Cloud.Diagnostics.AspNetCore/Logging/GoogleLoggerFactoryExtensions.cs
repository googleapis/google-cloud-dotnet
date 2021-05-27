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

using System;
using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Logging.V2;
using Microsoft.Extensions.Logging;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// Extensions to add <see cref="GoogleLoggerProvider"/>s to an <see cref="ILoggerFactory"/>.
    /// </summary>
    /// 
    /// <example>
    /// <code>
    /// public void Configure(ILoggerFactory loggerFactory)
    /// {
    ///     string projectId = "[Google Cloud Platform project ID]";
    ///     loggerFactory.AddGoogle(projectId);
    ///     ...
    /// }
    /// </code>
    /// </example>
    /// 
    /// <remarks>
    /// Logs to Google Cloud Logging.
    /// Docs: https://cloud.google.com/logging/docs/
    /// </remarks>
    /// <seealso cref="GoogleLogger"/>
    public static class GoogleLoggerFactoryExtensions
    {
        /// <summary>
        /// Adds a <see cref="GoogleLoggerProvider"/> for <see cref="GoogleLogger"/>s.
        /// </summary>
        /// <param name="factory">The logger factory. Must not be null.</param>
        /// <param name="serviceProvider">The service provider to resolve additional services from.</param>
        /// <param name="projectId">Optional if running on Google App Engine or Google Compute Engine.
        ///     The Google Cloud Platform project ID. If unspecified and running on GAE or GCE the project ID will be
        ///     detected from the platform.</param>
        /// <param name="options">Optional, options for the logger.</param>
        /// <param name="client">Optional, logging client.</param>
        public static ILoggerFactory AddGoogle(this ILoggerFactory factory, IServiceProvider serviceProvider, string projectId = null,
            LoggerOptions options = null, LoggingServiceV2Client client = null)
        {
            GaxPreconditions.CheckNotNull(factory, nameof(factory));
            options = options ?? LoggerOptions.Create();
            projectId = Project.GetAndCheckProjectId(projectId, options.MonitoredResource);
            return factory.AddGoogle(LogTarget.ForProject(projectId), serviceProvider, options, client);
        }

        /// <summary>
        /// Adds a <see cref="GoogleLoggerProvider"/> for <see cref="GoogleLogger"/>s.
        /// </summary>
        /// <param name="factory">The logger factory. Must not be null.</param>
        /// <param name="logTarget">Where to log to. Must not be null.</param>
        /// <param name="serviceProvider">The service provider to resolve additional services from.</param>
        /// <param name="options">Optional, options for the logger.</param>
        /// <param name="client">Optional, logging client.</param>
        public static ILoggerFactory AddGoogle(this ILoggerFactory factory, LogTarget logTarget, IServiceProvider serviceProvider,
            LoggerOptions options = null, LoggingServiceV2Client client = null)
        {
            GaxPreconditions.CheckNotNull(factory, nameof(factory));
            GaxPreconditions.CheckNotNull(logTarget, nameof(logTarget));
            factory.AddProvider(GoogleLoggerProvider.Create(logTarget, serviceProvider, options, client));
            return factory;
        }
    }
}
