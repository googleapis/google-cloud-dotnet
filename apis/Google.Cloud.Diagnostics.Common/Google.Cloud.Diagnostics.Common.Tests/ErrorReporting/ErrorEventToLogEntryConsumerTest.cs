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
    public class ErrorEventToLogEntryConsumerTest
    {

        // TODO(talarico): TESTS

        private const string _logName = "some-log-name";
        private static readonly MonitoredResource s_monitoredResource = new MonitoredResource { Type = "global" };
        private static readonly LogTo s_logTo = LogTo.Project("pid");

        private IConsumer<ReportedErrorEvent> CreateErrorConsumer(IConsumer<LogEntry> logConsumer) =>
            new ErrorEventToLogEntryConsumer(_logName, s_logTo, logConsumer, s_monitoredResource);

        [Fact]
        public void Receive()
        {
            var mockLogConsumer = new Mock<IConsumer<LogEntry>>();
            var errorConsumer = CreateErrorConsumer(mockLogConsumer.Object);


        }

        [Fact]
        public void ReceiveAsync()
        {
        }

        [Fact]
        public void ConvertErrorEvents()
        {
        }
    }
}
