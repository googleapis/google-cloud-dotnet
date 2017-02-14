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
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Cloud.Logging.V2;
using Moq;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ReportEventsToTest
    {
        private const string _projectId = "pid";
        private const string _organizationId = "oid";
        private static readonly LoggingServiceV2Client _loggingClient = new Mock<LoggingServiceV2Client>().Object;
        private static readonly ReportErrorsServiceClient _errorClient = new Mock<ReportErrorsServiceClient>().Object;

        [Fact]
        public void Logging_ProjectId()
        {
            var logName = "another-log";
            var reportEventsTo = ReportEventsTo.Logging(_projectId, logName, _loggingClient);

            Assert.Equal(ReportEventsToLocation.Logging, reportEventsTo.ReportEventsToLocation);
            Assert.Null(reportEventsTo.ErrorReportingClient);
            Assert.Equal(_loggingClient, reportEventsTo.LoggingClient);
            Assert.NotNull(reportEventsTo.LogTo);
            Assert.Equal(LogToLocation.Project, reportEventsTo.LogTo.Location);
            Assert.Equal(_projectId, reportEventsTo.LogTo.ProjectId);
            Assert.Equal(logName, reportEventsTo.LogName);
            Assert.Equal(MonitoredResourceUtils.GlobalResource, reportEventsTo.MonitoredResource);
        }

        [Fact]
        public void Logging_LogTo()
        {
            var logTo = LogTo.Organization(_organizationId);
            var logName = "another-log";
            var monitoredResource = new MonitoredResource { Type = "not_global" };
            var reportEventsTo = ReportEventsTo.Logging(logTo, logName, _loggingClient, monitoredResource);

            Assert.Equal(ReportEventsToLocation.Logging, reportEventsTo.ReportEventsToLocation);
            Assert.Null(reportEventsTo.ErrorReportingClient);
            Assert.Equal(_loggingClient, reportEventsTo.LoggingClient);
            Assert.Equal(logTo, reportEventsTo.LogTo);
            Assert.Equal(logName, reportEventsTo.LogName);
            Assert.Equal(monitoredResource, reportEventsTo.MonitoredResource);
        }

        [Fact]
        public void ErrorReporting()
        {
            var reportEventsTo = ReportEventsTo.ErrorReporting(_errorClient);

            Assert.Equal(ReportEventsToLocation.ErrorReporting, reportEventsTo.ReportEventsToLocation);
            Assert.Equal(_errorClient, reportEventsTo.ErrorReportingClient);
            Assert.Null(reportEventsTo.LoggingClient);
            Assert.Null(reportEventsTo.LogTo);
            Assert.Null(reportEventsTo.LogName);
            Assert.Null(reportEventsTo.MonitoredResource);
        }
    }
}
