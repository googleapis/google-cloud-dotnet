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
using System;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class EventTargetTest
    {
        private const string _projectId = "pid";
        private const string _organizationId = "oid";
        private static readonly LoggingServiceV2Client _loggingClient = new Mock<LoggingServiceV2Client>().Object;

        [Fact]
        public void ForProject()
        {
            var eventTarget = EventTarget.ForProject(_projectId);

            Assert.Equal(EventTargetKind.Logging, eventTarget.Kind);
            Assert.Equal(_projectId, eventTarget.ProjectId);
            Assert.NotNull(eventTarget.LogTarget);
            Assert.Equal(LogTargetKind.Project, eventTarget.LogTarget.Kind);
            Assert.Equal(_projectId, eventTarget.LogTarget.ProjectId);
        }

        [Fact]
        public void ForLogTarget()
        {
            var logTarget = LogTarget.ForOrganization(_organizationId);
            var eventTarget = EventTarget.ForLogTarget(logTarget);

            Assert.Equal(EventTargetKind.Logging, eventTarget.Kind);
            Assert.Same(logTarget, eventTarget.LogTarget);
        }
    }
}
