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
using Google.Cloud.Logging.Type;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using Moq;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ErrorEventToLogEntryConsumerTest
    {
        private const string _logName = "some-log-name";
        private static readonly MonitoredResource s_monitoredResource = new MonitoredResource { Type = "global" };
        private static readonly LogTarget s_logTarget = LogTarget.ForProject("pid");

        private ErrorEventToLogEntryConsumer CreateErrorConsumer(IConsumer<LogEntry> logConsumer) =>
            new ErrorEventToLogEntryConsumer(_logName, s_logTarget, logConsumer, s_monitoredResource);

        [Fact]
        public void Receive()
        {
            var mockLogConsumer = new Mock<IConsumer<LogEntry>>();
            var errorConsumer = CreateErrorConsumer(mockLogConsumer.Object);
            var errorEvents = new[] { new ReportedErrorEvent(), new ReportedErrorEvent() };
            var logEntries = errorConsumer.ConvertErrorEvents(errorEvents);

            mockLogConsumer.Setup(c => c.Receive(logEntries));
            errorConsumer.Receive(errorEvents);
            mockLogConsumer.VerifyAll();
        }

        [Fact]
        public async Task ReceiveAsync()
        {
            var mockLogConsumer = new Mock<IConsumer<LogEntry>>();
            var errorConsumer = CreateErrorConsumer(mockLogConsumer.Object);
            var errorEvents = new[] { new ReportedErrorEvent(), new ReportedErrorEvent() };
            var logEntries = errorConsumer.ConvertErrorEvents(errorEvents);

            mockLogConsumer.Setup(c => c.ReceiveAsync(logEntries, default(CancellationToken)))
                .Returns(CommonUtils.CompletedTask);
            await errorConsumer.ReceiveAsync(errorEvents);
            mockLogConsumer.VerifyAll();
        }

        [Fact]
        public void ConvertErrorEvents()
        {
            var startTime = DateTime.UtcNow;
            var eventOne = new ReportedErrorEvent
            {
                Message = "Event one!",
                EventTime = Timestamp.FromDateTime(startTime),
                Context = new ErrorContext
                {
                    HttpRequest = new HttpRequestContext() { Method = "GET" }
                }
            };

            var eventTwo = new ReportedErrorEvent
            {
                Message = "Event two!",
                EventTime = Timestamp.FromDateTime(startTime.AddSeconds(2)),
                Context = new ErrorContext
                {
                    ReportLocation = new SourceLocation() { LineNumber = 10 }
                }
            };

            var eventThree = new ReportedErrorEvent
            {
                Message = "Event three!",
                EventTime = Timestamp.FromDateTime(startTime.AddSeconds(4))
            };

            var errorConsumer = CreateErrorConsumer(new Mock<IConsumer<LogEntry>>().Object);
            var logEntries = errorConsumer.ConvertErrorEvents(new [] { eventOne, eventTwo, eventThree });

            Assert.Equal(3, logEntries.Count());
            foreach (var entry in logEntries)
            {
                Assert.Equal(s_monitoredResource, entry.Resource);
                Assert.Contains(_logName, entry.LogName);
                Assert.Equal(LogSeverity.Error, entry.Severity);
                if (entry.Timestamp.Equals(eventOne.EventTime))
                {
                    Assert.Equal(entry.JsonPayload, eventOne.ToStruct());
                }
                else if (entry.Timestamp.Equals(eventTwo.EventTime))
                {
                    Assert.Equal(entry.JsonPayload, eventTwo.ToStruct());
                }
                else if (entry.Timestamp.Equals(eventThree.EventTime))
                {
                    Assert.Equal(entry.JsonPayload, eventThree.ToStruct());
                }
            }
        }
    }
}
