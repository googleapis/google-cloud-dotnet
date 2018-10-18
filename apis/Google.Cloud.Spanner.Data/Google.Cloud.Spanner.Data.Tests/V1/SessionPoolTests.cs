// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using Moq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Xunit;
using static Google.Cloud.Spanner.V1.TransactionOptions;

namespace Google.Cloud.Spanner.V1.PoolRewrite.Tests
{
    public partial class SessionPoolTests
    {
        private static readonly SessionName s_sampleSessionName = new SessionName("project", "instance", "database", "session");
        private static readonly ByteString s_sampleTransactionId = ByteString.CopyFromUtf8("transaction-id");

        [Fact]
        public void RecreateSession()
        {
            var logger = new InMemoryLogger();
            var mock = SpannerClientHelpers.CreateMockClient();
            var pool = new SessionPool(mock.Object, new SessionPoolOptions(), logger);

            var mode = ModeOneofCase.ReadOnly;
            var session = pool.RecreateSession(s_sampleSessionName, s_sampleTransactionId, mode);
            Assert.Equal(s_sampleSessionName, session.SessionName);
            Assert.Equal(s_sampleTransactionId, session.TransactionId);
            Assert.Equal(mode, session.TransactionMode);
            logger.AssertNoWarningsOrErrors();
        }

        // TODO: Would this be useful in CommonTesting?
        /// <summary>
        /// Logger which retains log entries, allowing us to detect warnings and errors.
        /// All log entries are also written to the test logger.
        /// </summary>
        private class InMemoryLogger : Logger
        {
            private readonly ConcurrentDictionary<LogLevel, List<string>> _logsByLevel = new ConcurrentDictionary<LogLevel, List<string>>();

            internal InMemoryLogger()
            {
                LogLevel = LogLevel.Debug;
            }

            public override void LogPerformanceMessage(string message)
            {
            }

            protected override void WriteLine(LogLevel level, string message)
            {
                // TODO: Make this cleaner. We don't currently have a Log(LogLevel, string message) public method in Logger.
                // We have a little way to go yet in terms of the Logger API...
                TestLogger.Instance.Debug($"({nameof(InMemoryLogger)}.{level}) {message}");
                var list = _logsByLevel.GetOrAdd(level, _ => new List<string>());
                lock (list)
                {
                    list.Add(message);
                }
            }

            internal void AssertNoWarningsOrErrors()
            {
                AssertNoEntries(LogLevel.Error);
                AssertNoEntries(LogLevel.Warn);
            }

            private void AssertNoEntries(LogLevel level)
            {
                var list = _logsByLevel.GetOrAdd(level, _ => new List<string>());
                lock (list)
                {
                    if (list.Count != 0)
                    {
                        Assert.True(false, $"Level {level}:{Environment.NewLine}{string.Join(Environment.NewLine, list)}");
                    }
                }
            }
        }
    }
}
