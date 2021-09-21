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
using Google.Protobuf.WellKnownTypes;
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
        private readonly LoggingOptions _loggerOptions;

        /// <summary>Where to log to.</summary>
        private readonly LogTarget _logTarget;

        /// <summary>Service context to associate to log entries, if any.</summary>
        private readonly Struct _serviceContext;

        /// <summary>The service provider to resolve additional services from.</summary>
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// <see cref="ILoggerProvider"/> for Google Cloud Logging.
        /// </summary>
        /// <param name="consumer">The consumer to push logs to. Must not be null.</param>
        /// <param name="logTarget">Where to log to. Must not be null.</param>
        /// <param name="serviceContext">The service context to associate to log entries. May be null.</param>
        /// <param name="loggerOptions">The logger options. Must not be null.</param>
        /// <param name="serviceProvider">The service provider to resolve additional services from.</param>
        internal GoogleLoggerProvider(IConsumer<LogEntry> consumer, LogTarget logTarget, Struct serviceContext, LoggingOptions loggerOptions,  IServiceProvider serviceProvider)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _logTarget = GaxPreconditions.CheckNotNull(logTarget, nameof(logTarget));
            _loggerOptions = GaxPreconditions.CheckNotNull(loggerOptions, nameof(loggerOptions));
            _serviceContext = serviceContext;
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Create an <see cref="ILoggerProvider"/> for Google Cloud Logging.
        /// </summary>
        public static GoogleLoggerProvider Create(IServiceProvider serviceProvider, LoggingServiceOptions options = null)
        {
            options = options ?? new LoggingServiceOptions();
            var loggingOptions = options.Options ?? LoggingOptions.Create();

            var logTarget = options.LogTarget ?? LogTarget.ForProject(Project.GetAndCheckProjectId(null, loggingOptions.MonitoredResource));
            var serviceContext = ServiceContextUtils.CreateServiceContext(
                Project.GetServiceName(options.ServiceName, loggingOptions.MonitoredResource),
                Project.GetServiceName(options.Version, loggingOptions.MonitoredResource));
            var client = options.Client ?? LoggingServiceV2Client.Create();
            IConsumer<LogEntry> consumer = LogConsumer.Create(client, loggingOptions.BufferOptions, loggingOptions.RetryOptions);

            var provider = new GoogleLoggerProvider(consumer, logTarget, serviceContext, loggingOptions, serviceProvider);

            var writer = options.LoggerDiagnosticsOutput;
            if (writer != null)
            {
                // The log name is the ASP.NET Core log name, not the "/projects/xyz/logs/abc" log name in the resource.
                // We don't currently use this in the diagnostics, but if we ever start to do so, SampleLogName seems
                // like a reasonably clear example.
                ((GoogleLogger)provider.CreateLogger("SampleLogName")).WriteDiagnostics(writer);
            }

            return provider;
        }

        /// <summary>
        /// Creates a <see cref="GoogleLogger"/> with the given log name.
        /// </summary>
        [Obsolete("Added for backward compatibility only when moving GoogleLogger to Common.")]
        public GoogleLogger CreateLogger(
            string logName, Action<IServiceProvider, Dictionary<string, string>> obsoleteLabelsGetter, Action<IServiceProvider, LogEntry, TraceTarget> obsoleteTraceContextGetter) =>
            new GoogleLogger(_consumer, _logTarget, _serviceContext, _loggerOptions, logName, obsoleteLabelsGetter, obsoleteTraceContextGetter, serviceProvider: _serviceProvider);

        /// <summary>
        /// Creates a <see cref="GoogleLogger"/> with the given log name.
        /// </summary>
        /// <param name="logName">The name of the log.  This will be combined with the log location
        ///     (<see cref="LogTarget"/>) to generate the resource name for the log.</param>
        public ILogger CreateLogger(string logName) => new GoogleLogger(_consumer, _logTarget, _serviceContext, _loggerOptions, logName, serviceProvider: _serviceProvider);

        /// <inheritdoc />
        public void Dispose() => _consumer.Dispose();
    }
}
