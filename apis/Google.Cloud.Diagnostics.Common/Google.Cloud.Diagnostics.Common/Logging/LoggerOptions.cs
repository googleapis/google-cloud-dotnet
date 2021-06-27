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

using Google.Api;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.IO;
using static Google.Cloud.Diagnostics.Common.ServiceContextUtils;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Options for a <see cref="GoogleLogger"/>".
    /// </summary>
    public sealed class LoggerOptions
    {
        /// <summary>The base log name for all logs.</summary>
        // We keep this as aspnetcore for backwards compatibility.
        // It might be a little awkward for someone writing a console application
        // to see their logs end up in something named "aspnetcore" but this is
        // just a name, and if they are really interested, they can specify their own.
        private const string _baseLogName = "aspnetcore";

        /// <summary>The minimum log level.</summary>
        public LogLevel LogLevel { get; }

        /// <summary>The name for the logs.</summary>
        public string LogName { get; }

        /// <summary>The monitored resource. See: https://cloud.google.com/logging/docs/api/v2/resource-list </summary>
        public MonitoredResource MonitoredResource { get; }

        /// <summary>The buffer options for the logger.</summary>
        public BufferOptions BufferOptions { get; }

        /// <summary>The retry options for the logger.</summary>
        public RetryOptions RetryOptions { get; }

        /// <summary>Custom labels for log entries.</summary>
        /// <remarks>Keys and values added to <see cref="Labels"/> should not be null.
        /// If they are, an exception will be throw when attempting to log an entry.
        /// The entry won't be logged and the exception will be propagated depending
        /// on the value of <see cref="RetryOptions.ExceptionHandling"/>.</remarks>
        public Dictionary<string, string> Labels { get; }

        /// <summary>
        /// A <see cref="TextWriter"/> to write diagnostics info about loggers created
        /// with these <see cref="LoggerOptions"/>.
        /// Currently the only diagnostics info we provide is the URL where the logs written
        /// with these options can be found.
        /// </summary>
        public TextWriter LoggerDiagnosticsOutput { get; }

        /// <summary>
        /// An identifier of the service, such as the name of the executable or job. May be null.
        /// When set, it will be included in the <code>serviceContext</code> field of the log entry JSON payload.
        /// </summary>
        public string ServiceName =>
            ServiceContext == null || !ServiceContext.Fields.TryGetValue(ServiceContextServiceKey, out Value v) ? null : v.StringValue;

        /// <summary>
        /// A string that represents the version of the service or the source code that logs are written for.
        /// When set, it will be included in the <code>serviceContext</code> field of the log entry JSON payload.
        /// </summary>
        public string Version =>
            ServiceContext == null || !ServiceContext.Fields.TryGetValue(ServiceContextVersionKey, out Value v) ? null : v.StringValue;

        /// <summary>
        /// The service context to associate to the Logger.
        /// </summary>
        internal Struct ServiceContext { get; }

        private LoggerOptions(
            LogLevel logLevel,
            string logName,
            Dictionary<string, string> labels,
            MonitoredResource monitoredResource,
            BufferOptions bufferOptions,
            RetryOptions retryOptions,
            TextWriter loggerDiagnosticsOutput,
            string serviceName,
            string version)
        {
            LogName = logName;
            LogLevel = GaxPreconditions.CheckEnumValue(logLevel, nameof(logLevel));
            Labels = labels;
            MonitoredResource = monitoredResource;
            BufferOptions = bufferOptions;
            RetryOptions = retryOptions;
            LoggerDiagnosticsOutput = loggerDiagnosticsOutput;

            // Create the service context here, this class is inmutable.
            ServiceContext = CreateServiceContext(serviceName, version);
        }

        /// <summary>
        /// Create a new instance of <see cref="LoggerOptions"/>.
        /// </summary>
        /// <param name="logLevel">Optional, the minimum log level.  Defaults to <see cref="LogLevel.Information"/></param>
        /// <param name="logName">Optional, the name of the log.  Defaults to 'aspnetcore'.</param>
        /// <param name="labels">Optional, custom labels to be added to log entries.
        /// Keys and values added to <paramref name="labels"/> should not be null.
        /// If they are, an exception will be throw when attempting to log an entry.
        /// The entry won't be logged and the exception will be propagated depending
        /// on the value of <see cref="RetryOptions.ExceptionHandling"/>.</param>
        /// <param name="monitoredResource">Optional, the monitored resource.  The monitored resource will
        /// be automatically detected if it is not set and will default to the global resource if the detection fails.
        /// See: https://cloud.google.com/logging/docs/api/v2/resource-list </param>
        /// <param name="bufferOptions">Optional, the buffer options.  Defaults to a <see cref="BufferType.Timed"/></param>
        /// <param name="retryOptions">Optional, the retry options.  Defaults to a <see cref="RetryType.None"/></param>
        /// <param name="loggerDiagnosticsOutput">Optional. If set some logger diagnostics info will be written
        /// to the given <see cref="TextWriter"/>. Currently the only diagnostics info we provide is the URL where
        /// the logs written with these options can be found.</param>
        public static LoggerOptions Create(
            LogLevel logLevel = LogLevel.Information,
            string logName = null,
            Dictionary<string, string> labels = null,
            MonitoredResource monitoredResource = null,
            BufferOptions bufferOptions = null,
            RetryOptions retryOptions = null,
            TextWriter loggerDiagnosticsOutput = null) =>
            CreateWithServiceContext(logLevel, logName, labels, monitoredResource, bufferOptions, retryOptions, loggerDiagnosticsOutput);

        /// <summary>
        /// Create a new instance of <see cref="LoggerOptions"/> with default service context.
        /// If <paramref name="monitoredResource"/> is provided, the service context will be obtained from it.
        /// Else, if running on GAE, the service context will be obtained from the platform.
        /// </summary>
        /// <param name="logLevel">Optional, the minimum log level.  Defaults to <see cref="LogLevel.Information"/></param>
        /// <param name="logName">Optional, the name of the log.  Defaults to 'aspnetcore'.</param>
        /// <param name="labels">Optional, custom labels to be added to log entries.
        /// Keys and values added to <paramref name="labels"/> should not be null.
        /// If they are, an exception will be throw when attempting to log an entry.
        /// The entry won't be logged and the exception will be propagated depending
        /// on the value of <see cref="RetryOptions.ExceptionHandling"/>.</param>
        /// <param name="monitoredResource">Optional, the monitored resource.  The monitored resource will
        /// be automatically detected if it is not set and will default to the global resource if the detection fails.
        /// See: https://cloud.google.com/logging/docs/api/v2/resource-list </param>
        /// <param name="bufferOptions">Optional, the buffer options.  Defaults to a <see cref="BufferType.Timed"/></param>
        /// <param name="retryOptions">Optional, the retry options.  Defaults to a <see cref="RetryType.None"/></param>
        /// <param name="loggerDiagnosticsOutput">Optional. If set some logger diagnostics info will be written
        /// to the given <see cref="TextWriter"/>. Currently the only diagnostics info we provide is the URL where
        /// the logs written with these options can be found.</param>
        public static LoggerOptions CreateWithDetectedServiceContext(
            LogLevel logLevel = LogLevel.Information,
            string logName = null,
            Dictionary<string, string> labels = null,
            MonitoredResource monitoredResource = null,
            BufferOptions bufferOptions = null,
            RetryOptions retryOptions = null,
            TextWriter loggerDiagnosticsOutput = null) =>
            CreateWithServiceContext(
                logLevel,
                logName,
                labels,
                monitoredResource,
                bufferOptions,
                retryOptions,
                loggerDiagnosticsOutput,
                Project.GetServiceName(null, monitoredResource),
                Project.GetServiceVersion(null, monitoredResource));

        /// <summary>
        /// Create a new instance of <see cref="LoggerOptions"/>.
        /// </summary>
        /// <param name="logLevel">Optional, the minimum log level.  Defaults to <see cref="LogLevel.Information"/></param>
        /// <param name="logName">Optional, the name of the log.  Defaults to 'aspnetcore'.</param>
        /// <param name="labels">Optional, custom labels to be added to log entries.
        /// Keys and values added to <paramref name="labels"/> should not be null.
        /// If they are, an exception will be throw when attempting to log an entry.
        /// The entry won't be logged and the exception will be propagated depending
        /// on the value of <see cref="RetryOptions.ExceptionHandling"/>.</param>
        /// <param name="monitoredResource">Optional, the monitored resource.  The monitored resource will
        /// be automatically detected if it is not set and will default to the global resource if the detection fails.
        /// See: https://cloud.google.com/logging/docs/api/v2/resource-list </param>
        /// <param name="bufferOptions">Optional, the buffer options.  Defaults to a <see cref="BufferType.Timed"/></param>
        /// <param name="retryOptions">Optional, the retry options.  Defaults to a <see cref="RetryType.None"/></param>
        /// <param name="loggerDiagnosticsOutput">Optional. If set some logger diagnostics info will be written
        /// to the given <see cref="TextWriter"/>. Currently the only diagnostics info we provide is the URL where
        /// the logs written with these options can be found.</param>
        /// <param name="serviceName">A string that represents the version of the service or the source code that logs are written for.
        /// When set, it will be included in the <code>serviceContext</code> field of the log entry JSON payload.</param>
        /// <param name="version">A string that represents the version of the service or the source code that logs are written for.
        /// When set, it will be included in the <code>serviceContext</code> field of the log entry JSON payload.</param>
        public static LoggerOptions CreateWithServiceContext(
            LogLevel logLevel = LogLevel.Information,
            string logName = null,
            Dictionary<string, string> labels = null,
            MonitoredResource monitoredResource = null,
            BufferOptions bufferOptions = null,
            RetryOptions retryOptions = null,
            TextWriter loggerDiagnosticsOutput = null,
            string serviceName = null,
            string version = null)
        {
            logName ??= _baseLogName;
            labels ??= new Dictionary<string, string>();
            monitoredResource ??= MonitoredResourceBuilder.FromPlatform();
            bufferOptions ??= BufferOptions.TimedBuffer();
            retryOptions ??= RetryOptions.NoRetry();
            return new LoggerOptions(logLevel, logName, labels, monitoredResource, bufferOptions, retryOptions, loggerDiagnosticsOutput, serviceName, version);
        }
    }
}
