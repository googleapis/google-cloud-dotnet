// Copyright 2016 Google Inc. All Rights Reserved.
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
using Google.Api.Gax.Testing;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests.Logging
{
    public class GoogleLoggerTest
    {
        private static readonly string _logMessage = "a log message";
        private static readonly string _logName = "log-name";
        private static readonly string _projectId = "pid";
        private static readonly DateTime _dateTime = DateTime.UtcNow;
        private static readonly Exception _exception = new Exception("some message");
        private static readonly IClock _clock = new FakeClock(_dateTime);

        /// <summary>
        /// Function to format a string and exception.  Used to test logging.
        /// </summary>
        private string Formatter(string message, Exception ex)
            => ex == null ? message : $"{message} - {ex.Message}";

        private GoogleLogger GetLogger(IConsumer<LogEntry> consumer, LogLevel logLevel = LogLevel.Information)
        {
            return new GoogleLogger(consumer, logLevel, _projectId, _logName, _clock);
        }

        [Fact]
        public void BeginScope()
        {
            var logger = GetLogger(new Mock<IConsumer<LogEntry>>().Object);
            // This will return null as the function is not implemented yet.
            Assert.Null(logger.BeginScope("state"));
        }

        [Fact]
        public void IsEnabled()
        {
            var logger = GetLogger(new Mock<IConsumer<LogEntry>>().Object, LogLevel.Warning);
            Assert.False(logger.IsEnabled(LogLevel.Trace));
            Assert.False(logger.IsEnabled(LogLevel.Debug));
            Assert.False(logger.IsEnabled(LogLevel.Information));
            Assert.True(logger.IsEnabled(LogLevel.Warning));
            Assert.True(logger.IsEnabled(LogLevel.Error));
            Assert.True(logger.IsEnabled(LogLevel.Critical));
            Assert.True(logger.IsEnabled(LogLevel.None));
        }

        [Fact]
        public void Log_NullFormatter()
        {
            var logger = GetLogger(new Mock<IConsumer<LogEntry>>().Object);
            Assert.Throws<ArgumentNullException>(
                () => logger.Log(LogLevel.Information, 0, _logMessage, _exception, null));
        }

        [Fact]
        public void Log_NotEnabled()
        {
            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            var logger = GetLogger(mockConsumer.Object, LogLevel.Information);
            logger.Log(LogLevel.Debug, 0, _logMessage, _exception, Formatter);
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<LogEntry>>()), Times.Never());
        }

        [Fact]
        public void Log_EmptyFormattedMessage()
        {
            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            var logger = GetLogger(mockConsumer.Object);
            logger.Log(LogLevel.Debug, 0, "", null, Formatter);
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<LogEntry>>()), Times.Never());
        }

        [Fact]
        public void Log()
        {
            Predicate<IEnumerable<LogEntry>> matcher = (l) =>
            {
                LogEntry entry = l.Single();
                return entry.LogName == new LogName(_projectId, _logName).ToString() &&
                    entry.Severity == LogLevel.Error.ToLogSeverity() &&
                    entry.Timestamp.Equals(Timestamp.FromDateTime(_dateTime)) &&
                    entry.TextPayload == Formatter(_logMessage, _exception) &&
                    entry.Resource == GoogleLogger._globalResource;
            };

            var mockConsumer = new Mock<IConsumer<LogEntry>>();
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));
            var logger = GetLogger(mockConsumer.Object);
            logger.Log(LogLevel.Error, 0, _logMessage, _exception, Formatter);
            mockConsumer.VerifyAll(); ;
        }
    }
}
