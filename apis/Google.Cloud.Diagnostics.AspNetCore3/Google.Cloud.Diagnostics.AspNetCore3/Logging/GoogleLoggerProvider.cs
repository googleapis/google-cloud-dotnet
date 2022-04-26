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
using Google.Cloud.Logging.V2;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// <see cref="ILoggerProvider"/> for Google Cloud Logging.
    /// </summary>
    [Obsolete("Use Google.Cloud.Diagnostics.Common.GoogleLoggerProvider instead.")]
    public sealed class GoogleLoggerProvider : ILoggerProvider
    {
        private readonly Common.GoogleLoggerProvider _loggerProvider;

        /// <summary>
        /// <see cref="ILoggerProvider"/> for Google Cloud Logging.
        /// </summary>
        internal GoogleLoggerProvider(Common.GoogleLoggerProvider loggerProvider) =>
            _loggerProvider = GaxPreconditions.CheckNotNull(loggerProvider, nameof(loggerProvider));

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
        public static GoogleLoggerProvider Create(
            IServiceProvider serviceProvider, string projectId = null, LoggerOptions options = null, LoggingServiceV2Client client = null)
        {
            options = options ?? LoggerOptions.Create();
            options.CommonLoggerOptions.Client = client;
            options.CommonLoggerOptions.ProjectId = projectId;
            return new GoogleLoggerProvider(Common.GoogleLoggerProvider.Create(serviceProvider, options.CommonLoggerOptions));
        }

        /// <summary>
        /// Create an <see cref="ILoggerProvider"/> for Google Cloud Logging.
        /// </summary>
        /// <param name="logTarget">Where to log to. Must not be null.</param>
        /// <param name="serviceProvider">Optional, the service provider to resolve additional services from. May be null,
        /// in which case additional services (such as custom labels) will not be used.</param>
        /// <param name="options">Optional, options for the logger.</param>
        /// <param name="client">Optional, logging client.</param>
        public static GoogleLoggerProvider Create(
            LogTarget logTarget, IServiceProvider serviceProvider, LoggerOptions options = null, LoggingServiceV2Client client = null)
        {
            options = options ?? LoggerOptions.Create();
            options.CommonLoggerOptions.Client = client;
            options.CommonLoggerOptions.LogTarget = logTarget;
            return new GoogleLoggerProvider(Common.GoogleLoggerProvider.Create(serviceProvider, options.CommonLoggerOptions));
        }


        // Adapter function to be used to get labels set with the obsolete AspNetCore*.ILogEntryLabelProvider.
        // Will be used to pass these labels from AspNetCore*.GoogleLogger to Common.GoogleLogger because
        // Common.GoogleLogger cannot have a dependecy on the obsolote interface.
        [Obsolete("Has been added temporarily until we remove Google.Cloud.Diagnostics.AspNetCore.ILogEntryLabelProvider.")]
        internal static Action<IServiceProvider, Dictionary<string, string>> ObsoleteLabelsGetter =>
            (serviceProvider, labels) =>
            {
                if (serviceProvider?.GetService<IEnumerable<ILogEntryLabelProvider>>() is IEnumerable<ILogEntryLabelProvider> providers)
                {
                    foreach (var provider in providers)
                    {
                        provider.Invoke(labels);
                    }
                }
            };

        // Adapter function to be used to get trace context from the obsolete AspNetCore*.IExternalTraceProvider.
        // Will be used to "pass" this context from AspNetCore*.GoogleLogger to Common.GoogleLogger because
        // Common.GoogleLogger cannot have a dependecy on the obsolote interface.
        [Obsolete("Has been added temporarily until we remove Google.Cloud.Diagnostics.AspNetCore.ILogEntryLabelProvider.")]
        internal static Action<IServiceProvider, LogEntry, TraceTarget> ObsoleteTraceContextGetter =>
            (serviceProvider, logEntry, traceTarget) =>
            {
                if (TraceContextForLogEntry.FromExternalTrace(serviceProvider) is TraceContextForLogEntry trace
                    && !(trace.TraceId is null))
                {
                    logEntry.Trace = traceTarget.GetFullTraceName(trace.TraceId);
                    logEntry.TraceSampled = true;
                    logEntry.SpanId = trace.SpanId;
                }
            };

        /// <summary>
        /// Creates a <see cref="GoogleLogger"/> with the given log name.
        /// </summary>
        /// <param name="logName">The name of the log.  This will be combined with the log location
        ///     (<see cref="LogTarget"/>) to generate the resource name for the log.</param>
        public ILogger CreateLogger(string logName) =>
            new GoogleLogger(_loggerProvider.CreateLogger(logName, ObsoleteLabelsGetter, ObsoleteTraceContextGetter));

        /// <inheritdoc />
        public void Dispose() => _loggerProvider.Dispose();
    }
}
