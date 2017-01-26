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
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Cloud.Logging.V2;

namespace Google.Cloud.Diagnostics.Common
{
    public enum ReportEventsToLocation
    {
        ErrorReporting,
        Logging
    }

    public sealed class ReportEventsTo
    {
        internal const string LogNameDefault = "err-log";

        /// <summary>The global resource.</summary>
        internal static readonly MonitoredResource GlobalResource = new MonitoredResource { Type = "global" };

        public ReportEventsToLocation ReportEventsToLocation { get; private set; }

        public ReportErrorsServiceClient ErrorReportingClient { get; private set; }

        public LoggingServiceV2Client LoggingClient { get; private set; }

        public LogToLocation LogToLocation { get; private set; }

        public string LogName { get; private set; }

        public MonitoredResource MonitoredResource { get; private set; }

        public static ReportEventsTo Logging(
            string logName = LogNameDefault, LogToLocation logToLocation = LogToLocation.Project,
            LoggingServiceV2Client loggingClient = null, MonitoredResource monitoredResource = null)
        {
            return new ReportEventsTo
            {
                ReportEventsToLocation = ReportEventsToLocation.Logging,
                LoggingClient = loggingClient ?? LoggingServiceV2Client.Create(),
                LogToLocation = GaxPreconditions.CheckEnumValue(logToLocation, nameof(logToLocation)),
                LogName = GaxPreconditions.CheckNotNull(logName, nameof(logName)),
                MonitoredResource = monitoredResource ?? GlobalResource,
            };
        }

        public static ReportEventsTo ErrorReporting(ReportErrorsServiceClient errorReportingClient = null)
        {
            return new ReportEventsTo
            {
                ReportEventsToLocation = ReportEventsToLocation.Logging,
                ErrorReportingClient = errorReportingClient ?? ReportErrorsServiceClient.Create(),
            };
        }
           
    }
}
