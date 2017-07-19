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
using Google.Api.Gax.Grpc;
using Google.Cloud.Logging.V2;
using Moq;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class EventTargetTest
    {
        private const string _projectId = "pid";
        private const string _organizationId = "oid";
        private static readonly LoggingServiceV2Client _loggingClient = new Mock<LoggingServiceV2Client>().Object;

        [Fact]
        public void Logging_ProjectId()
        {
            var logName = "another-log";
            var eventTarget = EventTarget.ForLogging(
                _projectId, logName, _loggingClient, MonitoredResourceBuilder.GlobalResource);

            Assert.Equal(EventTargetKind.Logging, eventTarget.Kind);
            Assert.Equal(_projectId, eventTarget.ProjectId);
            Assert.Equal(_loggingClient, eventTarget.LoggingClient);
            Assert.NotNull(eventTarget.LogTarget);
            Assert.Equal(LogTargetKind.Project, eventTarget.LogTarget.Kind);
            Assert.Equal(_projectId, eventTarget.LogTarget.ProjectId);
            Assert.Equal(logName, eventTarget.LogName);
            Assert.Equal(MonitoredResourceBuilder.GlobalResource, eventTarget.MonitoredResource);
        }

        [Fact]
        public void Logging_LogTarget()
        {
            var logTarget = LogTarget.ForOrganization(_organizationId);
            var logName = "another-log";
            var monitoredResource = new MonitoredResource { Type = "not_global" };
            var eventTarget = EventTarget.ForLogging(logTarget, logName, _loggingClient, monitoredResource);

            Assert.Equal(EventTargetKind.Logging, eventTarget.Kind);
            Assert.Equal(_loggingClient, eventTarget.LoggingClient);
            Assert.Equal(logTarget, eventTarget.LogTarget);
            Assert.Equal(logName, eventTarget.LogName);
            Assert.Equal(monitoredResource, eventTarget.MonitoredResource);
        }
    }
}
