// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Api;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using System;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Optional configuration to be used when initializing
    /// Google Cloud Error Reporting.
    /// </summary>
    public sealed class ErrorReportingOptions
    {
        /// <summary>The default log name, this is the log that error events will be written to.</summary>
        internal const string LogNameDefault = "stackdriver-error-reporting";

        /// <summary>The name of the log.</summary>
        public string LogName { get; }

        /// <summary>The monitored resource. See: https://cloud.google.com/logging/docs/api/v2/resource-list </summary>
        public MonitoredResource MonitoredResource { get; }

        /// <summary>
        /// Where the error events should be sent.
        /// </summary>
        [Obsolete("Please use Google.Cloud.Diagnostics.Common.ErrorReportingServiceOptions.EventTarget instead.")]
        public EventTarget EventTarget { get; }

        /// <summary>The buffer options for the error reporter.</summary>
        public BufferOptions BufferOptions { get; }

        /// <summary>The retry options for the error reporter.</summary>
        public RetryOptions RetryOptions { get; }

        [Obsolete("EventTarget has moved to ErrorReportingServiceOptions now.")]
        private ErrorReportingOptions(EventTarget eventTarget, BufferOptions bufferOptions, RetryOptions retryOptions)
            : this(GaxPreconditions.CheckNotNull(eventTarget, nameof(eventTarget)).LogName ?? LogNameDefault,
                 eventTarget.MonitoredResource ?? MonitoredResourceBuilder.FromPlatform(),
                 bufferOptions,
                 retryOptions) =>
            EventTarget = eventTarget;

        private ErrorReportingOptions(string logName, MonitoredResource resource, BufferOptions bufferOptions, RetryOptions retryOptions)
        {
            LogName = GaxPreconditions.CheckNotNullOrEmpty(logName, nameof(logName));
            MonitoredResource = GaxPreconditions.CheckNotNull(resource, nameof(resource));
            BufferOptions = GaxPreconditions.CheckNotNull(bufferOptions, nameof(bufferOptions));
            RetryOptions = GaxPreconditions.CheckNotNull(retryOptions, nameof(retryOptions));
        }

        /// <summary>
        /// Creates an <see cref="ErrorReportingOptions"/>.
        /// </summary>
        /// <remarks>
        /// The naming of this method <see cref="CreateInstance(string, MonitoredResource, BufferOptions, RetryOptions)"/>
        /// is not consistent with the naming of similar methods in other options classes to avoid taking
        /// a breaking change. The semantics of this method is the same as all other Create methods in option classes like
        /// <see cref="LoggingOptions.Create(Microsoft.Extensions.Logging.LogLevel, string, System.Collections.Generic.Dictionary{string, string}, MonitoredResource, BufferOptions, RetryOptions)"/>
        /// or even the Obsolete <see cref="Create(string, BufferOptions, RetryOptions)"/>.
        /// </remarks>
        /// <param name="logName">The log name to log to. May be null, in which case, a default name will be used.</param>
        /// <param name="resource">The monitored resource. May be null, in which case an attempt will be made to 
        /// automatically detected it. If it is not detected, it will default to the global resource.
        /// See: https://cloud.google.com/logging/docs/api/v2/resource-list </param>
        /// <param name="bufferOptions">The buffer options for the error reporter. Defaults to no buffer.</param>
        /// <param name="retryOptions">The retry options for the error reporter. Defaults to no retry.</param>
        /// <returns>A new <see cref="ErrorReportingOptions"/> instance with the specified parameters or defaults.</returns>
        public static ErrorReportingOptions CreateInstance(
            string logName = null, MonitoredResource resource = null, BufferOptions bufferOptions = null, RetryOptions retryOptions = null) =>
            new ErrorReportingOptions(
                logName ?? LogNameDefault,
                resource ?? MonitoredResourceBuilder.FromPlatform(),
                bufferOptions ?? BufferOptions.NoBuffer(),
                retryOptions ?? RetryOptions.NoRetry());

        /// <summary>
        /// Creates an <see cref="ErrorReportingOptions"/>.
        /// </summary>
        /// <param name="eventTarget">Where the error events should be sent. Must not be null.</param>
        /// <param name="bufferOptions">The buffer options for the error reporter. Defaults to no buffer.</param>
        /// <param name="retryOptions">The retry options for the error reporter. Defaults to no retry.</param>
        [Obsolete("Please use CreateInstance(string, MonitoredResource, BufferOptions, RetryOptions) instead.")]
        public static ErrorReportingOptions Create(
            EventTarget eventTarget, BufferOptions bufferOptions = null, RetryOptions retryOptions = null) =>
            new ErrorReportingOptions(eventTarget, bufferOptions ?? BufferOptions.NoBuffer(), retryOptions ?? RetryOptions.NoRetry());

        /// <summary>
        /// Creates an <see cref="ErrorReportingOptions"/> that will send error events to the
        /// Google Cloud Logging API.
        /// </summary>
        /// <param name="projectId">Optional if running on Google App Engine or Google Compute Engine.
        ///     The Google Cloud Platform project ID. If running on GAE or GCE the project ID will be
        ///     detected from the platform.</param>
        /// <param name="bufferOptions">The buffer options for the error reporter. Defaults to no buffer.</param>
        /// <param name="retryOptions">The retry options for the error reporter. Defaults to no retry.</param>
        [Obsolete("Please use CreateInstance(string, MonitoredResource, BufferOptions, RetryOptions) instead.")]
        public static ErrorReportingOptions Create(
            string projectId = null, BufferOptions bufferOptions = null, RetryOptions retryOptions = null) =>
                Create(EventTarget.ForLogging(projectId), bufferOptions, retryOptions);
    }
}