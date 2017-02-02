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

using Google.Api.Gax;
using Google.Cloud.ErrorReporting.V1Beta1;
using System.Diagnostics;

namespace Google.Cloud.Diagnostics.Common
{
    internal static class ReportedErrorEventConsumerFactory
    {
        /// <summary>
        /// Gets a <see cref="IConsumer{ReportedErrorEvent}"/> with the given options.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID. Cannot be null.</param>
        /// <param name="options">Error Reporting options for the buffered consumer. Cannot be null.</param>
        public static IConsumer<ReportedErrorEvent> Create(string projectId, ErrorReportingOptions options)
        {
            GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId));
            GaxPreconditions.CheckNotNull(options, nameof(options));

            var reportTo = options.ReportEventsTo;
            IConsumer<ReportedErrorEvent> consumer;

            switch (reportTo.ReportEventsToLocation)
            {
                case ReportEventsToLocation.Logging:
                    consumer = new ErrorEventToLogEntryConsumer(reportTo.LogName, reportTo.LogTo,
                        new GrpcLogConsumer(reportTo.LoggingClient), reportTo.MonitoredResource);
                    break;
                case ReportEventsToLocation.ErrorReporting:
                    consumer = new GrpcErrorEventConsumer(
                        reportTo.ErrorReportingClient, projectId);
                    break;
                default:
                    Debug.Assert(false, $"Unsupported location {reportTo.ReportEventsToLocation}");
                    return null;
            }

            return ConsumerFactory<ReportedErrorEvent>.GetConsumer(
                consumer, ReportedErrorEventSizer.Instance, options.BufferOptions);
        }
    }
}
