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

using Google.Cloud.ErrorReporting.V1Beta1;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ReportedErrorEventConsumerFactoryTest
    {
        private const string _porjectId = "pid";

        [Fact]
        public void ErrorConsumer()
        {
            var reportTo = ReportEventsTo.ErrorReporting();
            var options = ErrorReportingOptions.Create(reportTo);
            var consumer = ReportedErrorEventConsumerFactory.Create(_porjectId, options);
            Assert.IsType<GrpcErrorEventConsumer>(consumer);
        }

        [Fact]
        public void ErrorToLogsConsumer()
        {
            var reportTo = ReportEventsTo.Logging(_porjectId);
            var options = ErrorReportingOptions.Create(reportTo);
            var consumer = ReportedErrorEventConsumerFactory.Create(_porjectId, options);
            Assert.IsType<ErrorEventToLogEntryConsumer>(consumer);
        }

        [Fact]
        public void BufferdConsumer()
        {
            var bufferOptions = BufferOptions.SizedBuffer();
            var reportTo = ReportEventsTo.Logging(_porjectId);
            var options = ErrorReportingOptions.Create(reportTo, bufferOptions);
            var consumer = ReportedErrorEventConsumerFactory.Create(_porjectId, options);
            Assert.IsType<SizedBufferingConsumer<ReportedErrorEvent>>(consumer);
        }
    }
}
