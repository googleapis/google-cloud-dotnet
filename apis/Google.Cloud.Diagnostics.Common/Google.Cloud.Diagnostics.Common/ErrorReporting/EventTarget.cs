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
using Google.Cloud.Logging.V2;
using System;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// The type of location error events will be sent to.
    /// </summary>
    public enum EventTargetKind
    {
        /// <summary>Google Cloud Error Logging API.</summary>
        Logging
    }

    /// <summary>
    /// Represents the location error events will be sent.
    /// </summary>
    public sealed class EventTarget
    {
        private EventTarget(LogTarget target)
        {
            GaxPreconditions.CheckNotNull(target, nameof(target));
            Kind = EventTargetKind.Logging;
            LogTarget = target;
        }

        /// <summary>
        /// Default constructor. Which does nothing and has never do.
        /// Obsolete.
        /// </summary>
        [Obsolete("Do not use as the instance built by this constructor is not valid and never has been.")]
        public EventTarget() 
        { }

        /// <summary>The type of location to send error events to.</summary>
        public EventTargetKind Kind { get; }

        /// <summary>The logging client.</summary>
        [Obsolete("Please use Google.Cloud.Diagnostics.Common.ErrorReportingServiceOptions.Client instead.")]
        public LoggingServiceV2Client LoggingClient { get; private set; }

        /// <summary>
        /// If this even target type is <see cref="EventTargetKind.Logging"/>, this is
        /// the target log to send error reports to. It will be null otherwise.
        /// Note that currently, only <see cref="EventTargetKind.Logging"/> is supported
        /// then, in practice, this will never be null.
        /// </summary>
        public LogTarget LogTarget { get; }

        /// <summary>The name of the log.</summary>
        [Obsolete("Please use Google.Cloud.Diagnostics.Common.ErrorReportingOptions.LogName instead.")]
        public string LogName { get; private set; }

        /// <summary>
        /// If <see cref="LogTarget"/> is of <see cref="LogTargetKind.Project"/>
        /// this is <see cref="LogTarget.ProjectId"/>. Null otherwise.
        /// </summary>
        public string ProjectId { get => LogTarget?.ProjectId; }

        /// <summary>The resource being monitored.</summary>
        [Obsolete("Please use Google.Cloud.Diagnostics.Common.ErrorReportingOptions.MonitoredResource instead.")]
        public MonitoredResource MonitoredResource { get; private set; }

        /// <summary>
        /// Creates a new <see cref="EventTarget"/> instance that will report to the Google Cloud Logging API.
        /// The events are then automatically propagated to the Google Cloud Error Logging API from the 
        /// Google Cloud Logging API.
        /// </summary>
        /// <remarks>
        /// For more information see "Formatting Log Error Messages"
        /// (https://cloud.google.com/error-reporting/docs/formatting-error-messages).
        /// </remarks>
        /// <param name="projectId">
        /// The project ID to create the underlying <see cref="LogTarget"/> from.
        /// Must not be null.
        /// </param>
        public static EventTarget ForProject(string projectId) =>
            new EventTarget(LogTarget.ForProject(projectId));

        /// <summary>
        /// Creates a new <see cref="EventTarget"/> instance that will report to the Google Cloud Logging API.
        /// The events are then automatically propagated to the Google Cloud Error Logging API from the 
        /// Google Cloud Logging API.
        /// </summary>
        /// <remarks>
        /// For more information see "Formatting Log Error Messages"
        /// (https://cloud.google.com/error-reporting/docs/formatting-error-messages).
        /// </remarks>
        /// <param name="target">
        /// The <see cref="LogTarget"/> to create the <see cref="EventTarget"/> from.
        /// Must not be null.
        /// </param>
        public static EventTarget ForLogTarget(LogTarget target) =>
            new EventTarget(target);

        /// <summary>
        /// Creates a new <see cref="EventTarget"/> instance that will report to the Google Cloud Logging API.
        /// The events are then automatically propagated to the Google Cloud Error Logging API from the 
        /// Google Cloud Logging API.
        /// </summary>
        /// <remarks>
        /// For more information see "Formatting Log Error Messages"
        /// (https://cloud.google.com/error-reporting/docs/formatting-error-messages).
        /// </remarks>
        /// <param name="projectId">Optional if running on Google App Engine or Google Compute Engine.
        ///     The Google Cloud Platform project ID. If running on GAE or GCE the project ID will be
        ///     detected from the platform.</param>
        /// <param name="logName">The log name.  Must not be null.</param>
        /// <param name="loggingClient">The logging client.</param>
        /// <param name="monitoredResource">Optional, the monitored resource.  The monitored resource will
        ///     be automatically detected if it is not set and will default to the global resource if the detection fails.
        ///     See: https://cloud.google.com/logging/docs/api/v2/resource-list </param>
        [Obsolete("Please use Google.Cloud.Diagnostics.Common.EventTarget.FromProject instead.")]
        public static EventTarget ForLogging(string projectId = null, string logName = ErrorReportingOptions.LogNameDefault,
            LoggingServiceV2Client loggingClient = null, MonitoredResource monitoredResource = null)
        {
            projectId = Project.GetAndCheckProjectId(projectId, monitoredResource);
            var logTarget = LogTarget.ForProject(projectId);
            return ForLogging(logTarget, logName, loggingClient, monitoredResource);
        }

        /// <summary>
        /// Creates a new <see cref="EventTarget"/> instance that will report to the Google Cloud Logging API.
        /// The events are then automatically propagated to the Google Cloud Error Logging API from the 
        /// Google Cloud Logging API.
        /// </summary>
        /// <remarks>
        /// For more information see "Formatting Log Error Messages"
        /// (https://cloud.google.com/error-reporting/docs/formatting-error-messages).
        /// </remarks>
        /// <param name="logTarget">Where to log to, such as a project or organization. Must not be null.</param>
        /// <param name="logName">The log name.  Must not be null.</param>
        /// <param name="loggingClient">The logging client.</param>
        /// <param name="monitoredResource">Optional, the monitored resource.  The monitored resource will
        ///     be automatically detected if it is not set and will default to the global resource if the detection fails.
        ///     See: https://cloud.google.com/logging/docs/api/v2/resource-list </param>
        [Obsolete("Please use Google.Cloud.Diagnostics.Common.EventTarget.FromLogTarget instead.")]
        public static EventTarget ForLogging(LogTarget logTarget, string logName = ErrorReportingOptions.LogNameDefault,
            LoggingServiceV2Client loggingClient = null, MonitoredResource monitoredResource = null)
        {
            return new EventTarget (logTarget)
            {
                LoggingClient = loggingClient ?? LoggingServiceV2Client.Create(),
                LogName = GaxPreconditions.CheckNotNullOrEmpty(logName, nameof(logName)),
                MonitoredResource = monitoredResource ?? MonitoredResourceBuilder.FromPlatform(),
            };
        }
    }
}
