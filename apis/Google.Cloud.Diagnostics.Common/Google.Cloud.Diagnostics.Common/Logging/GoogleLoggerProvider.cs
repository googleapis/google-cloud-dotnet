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

using Google.Api.Gax;
using Google.Cloud.Logging.V2;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// <see cref="ILoggerProvider"/> for Google Cloud Logging.
    /// </summary>
    public sealed class GoogleLoggerProvider : ILoggerProvider
    {
        /// <summary>The consumer to push logs to.</summary>
        private readonly IConsumer<LogEntry> _consumer;

        /// <summary>The logger options.</summary>
        private readonly LoggerOptions _loggerOptions;

        /// <summary>Where to log to.</summary>
        private readonly LogTarget _logTarget;

        /// <summary>The service provider to resolve additional services from.</summary>
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// <see cref="ILoggerProvider"/> for Google Cloud Logging.
        /// </summary>
        /// <param name="consumer">The consumer to push logs to. Must not be null.</param>
        /// <param name="logTarget">Where to log to. Must not be null.</param>
        /// <param name="loggerOptions">The logger options. Must not be null.</param>
        /// <param name="serviceProvider">The service provider to resolve additional services from.</param>
        internal GoogleLoggerProvider(IConsumer<LogEntry> consumer, LogTarget logTarget, LoggerOptions loggerOptions,  IServiceProvider serviceProvider)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _logTarget = GaxPreconditions.CheckNotNull(logTarget, nameof(logTarget));
            _loggerOptions = GaxPreconditions.CheckNotNull(loggerOptions, nameof(loggerOptions));
            _serviceProvider = serviceProvider;

            var writer = loggerOptions.LoggerDiagnosticsOutput;
            if (writer != null)
            {
                // The log name is the ASP.NET Core log name, not the "/projects/xyz/logs/abc" log name in the resource.
                // We don't currently use this in the diagnostics, but if we ever start to do so, SampleLogName seems
                // like a reasonably clear example.
                ((GoogleLogger) CreateLogger("SampleLogName")).WriteDiagnostics(writer);
            }
        }

        /// <summary>
        /// Create an <see cref="ILoggerProvider"/> for Google Cloud Logging.
        /// </summary>
        /// <param name="serviceProvider">The service provider to resolve additional services from.
        /// May be null, in which case additional services (such as custom labels) will not be used.</param>
        /// <param name="projectId">Optional if running on Google App Engine or Google Compute Engine.
        /// The Google Cloud Platform project ID. If unspecified and running on GAE or GCE the project ID will be
        /// detected from the platform.</param>
        /// <param name="options">Optional, options for the logger.</param>
        /// <param name="client">Optional, logging client.</param>
        public static GoogleLoggerProvider Create(IServiceProvider serviceProvider, string projectId = null,
            LoggerOptions options = null, LoggingServiceV2Client client = null)
        {
            options = options ?? LoggerOptions.Create();
            projectId = Project.GetAndCheckProjectId(projectId, options.MonitoredResource);
            return Create(LogTarget.ForProject(projectId), serviceProvider, options, client);
        }

        /// <summary>
        /// Create an <see cref="ILoggerProvider"/> for Google Cloud Logging.
        /// </summary>
        /// <param name="logTarget">Where to log to. Must not be null.</param>
        /// <param name="serviceProvider">Optional, the service provider to resolve additional services from. May be null,
        /// in which case additional services (such as custom labels) will not be used.</param>
        /// <param name="options">Optional, options for the logger.</param>
        /// <param name="client">Optional, logging client.</param>
        public static GoogleLoggerProvider Create(LogTarget logTarget, IServiceProvider serviceProvider,
            LoggerOptions options = null, LoggingServiceV2Client client = null)
        {
            // Check params and set defaults if unset.
            GaxPreconditions.CheckNotNull(logTarget, nameof(logTarget));
            client = client ?? LoggingServiceV2Client.Create();
            options = options ?? LoggerOptions.Create();

            // Get the proper consumer from the options and add a logger provider.
            IConsumer<LogEntry> consumer = LogConsumer.Create(client, options.BufferOptions, options.RetryOptions);
            return new GoogleLoggerProvider(consumer, logTarget, options, serviceProvider);
        }

        /// <summary>
        /// Creates a <see cref="GoogleLogger"/> with the given log name.
        /// </summary>
        [Obsolete("Added for backward compatibility only when moving GoogleLogger to Common.")]
        public GoogleLogger CreateLogger(
            string logName, Action<IServiceProvider, Dictionary<string, string>> obsoleteLabelsGetter, Action<IServiceProvider, LogEntry, TraceTarget> obsoleteTraceContextGetter) =>
            new GoogleLogger(_consumer, _logTarget, _loggerOptions, logName, obsoleteLabelsGetter, obsoleteTraceContextGetter, serviceProvider: _serviceProvider);

        /// <summary>
        /// Creates a <see cref="GoogleLogger"/> with the given log name.
        /// </summary>
        /// <param name="logName">The name of the log.  This will be combined with the log location
        ///     (<see cref="LogTarget"/>) to generate the resource name for the log.</param>
        public ILogger CreateLogger(string logName) => new GoogleLogger(_consumer, _logTarget, _loggerOptions, logName, serviceProvider: _serviceProvider);

        /// <inheritdoc />
        public void Dispose() => _consumer.Dispose();
    }
}
