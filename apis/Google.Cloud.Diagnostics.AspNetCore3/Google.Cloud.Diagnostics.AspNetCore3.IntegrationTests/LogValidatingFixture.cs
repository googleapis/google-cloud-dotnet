// Copyright 2019 Google LLC
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

using Google.Api.Gax.Grpc;
using Google.Cloud.ClientTesting;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;


namespace Google.Cloud.Diagnostics.AspNetCore3.IntegrationTests
{
    /// <summary>
    /// A fixture that allows logging validation to be deferred until disposal.
    /// </summary>
    public class LogValidatingFixture : IDisposable
    {
        private static readonly TimeSpan s_canaryMessageTimeout = TimeSpan.FromMinutes(7);
        private static readonly TimeSpan s_delayBetweenCanaryAttempts = TimeSpan.FromSeconds(10);
        private static readonly TimeSpan s_totalValidationTimeout = TimeSpan.FromMinutes(20);
        private static readonly TimeSpan s_delayBetweenValidationAttempts = TimeSpan.FromSeconds(30);
        private static readonly TimeSpan s_delayBetweenPages = TimeSpan.FromSeconds(3);

        private readonly List<TestValidator> _validators = new List<TestValidator>();
        private readonly DateTime _fixtureStart = DateTime.UtcNow;

        /// <summary>Project id to run the test on.</summary>
        private readonly string _projectId = TestEnvironment.GetTestProjectId();

        /// <summary>Client to use to send RPCs.</summary>
        private readonly LoggingServiceV2Client _client = LoggingServiceV2Client.Create();

        /// <summary>
        /// Adds a validator to be executed when the fixture is disposed.
        /// </summary>
        /// <param name="testId">The test ID, which is used to filter the logs passed to the validator delegate.</param>
        /// <param name="validator">A validator delegate to execute on disposal.
        /// This is passed all the log entries containing <paramref name="testId"/> in the message field of the JSON payload.</param>
        /// <param name="testMethod">The method being tested, which defaults to the caller member name.</param>
        public void AddValidator(string testId, Action<IReadOnlyList<LogEntry>> validator, [CallerMemberName] string testMethod = null) =>
            _validators.Add(new TestValidator(testId, testMethod, validator));

        public void Dispose()
        {
            FileLogger.Log("Disposing of log validating fixture");
            DateTime startTime = DateTime.UtcNow;
            var endTime = startTime + s_totalValidationTimeout;
            LogCanaryMessageAndWait();

            List<Exception> exceptions = null;
            DateTime iterationStart = DateTime.UtcNow;
            while (iterationStart < endTime)
            {
                exceptions = new List<Exception>();
                var logEntries = ListAllLogEntries();
                FileLogger.Log($"Read {logEntries.Count} entries");
                exceptions = _validators.Select(v => v.Validate(logEntries)).Where(e => e != null).ToList();
                if (exceptions.Count == 0)
                {
                    return;
                }
                FileLogger.Log($"Failing validators: {exceptions.Count}");
                var delay = (iterationStart + s_delayBetweenValidationAttempts) - DateTime.UtcNow;
                FileLogger.Log($"Delaying for {(int) delay.TotalSeconds}s");
                if (delay > TimeSpan.Zero)
                {
                    Thread.Sleep(delay);
                }
                iterationStart = DateTime.UtcNow;
            }
            throw new AggregateException("Logging validation failed", exceptions);
        }

        private List<LogEntry> ListAllLogEntries()
        {
            var request = BuildRequest(_fixtureStart);
            FileLogger.Log("Starting fetch");
            var rawResponses = _client.ListLogEntries(request).AsRawResponses();
            var logEntries = new List<LogEntry>();
            using (var iterator = rawResponses.GetEnumerator())
            {
                FileLogger.Log("Calling MoveNext");
                while (iterator.MoveNext())
                {
                    Thread.Sleep(s_delayBetweenPages);
                    logEntries.AddRange(iterator.Current.Entries);
                }
            }
            FileLogger.Log("Finished fetch");
            return logEntries;
        }

        /// <summary>
        /// Writes a single "canary" log entry and waits for it to be visible. This is written
        /// after all the entries from tests, so by the time this is visible, it's "reasonably likely"
        /// that all the test log messages are also visible.
        /// </summary>
        private void LogCanaryMessageAndWait()
        {
            DateTime startTime = DateTime.UtcNow;
            string id = IdGenerator.FromGuid();
            LogEntry entry = new LogEntry
            {
                Resource = MonitoredResourceBuilder.FromPlatform(),
                LogName = $"projects/{_projectId}/logs/aspnetcore",
                Severity = Logging.Type.LogSeverity.Info,
                Timestamp = Timestamp.FromDateTime(DateTime.UtcNow),
                JsonPayload = new Struct { Fields = { ["message"] = Value.ForString(id) } }
            };

            _client.WriteLogEntries((LogName) null, null, null, new[] { entry });

            var request = BuildRequest(startTime);
            request.Filter += $" AND jsonPayload.message:\"{id}\"";

            // Wait for the canary log entry to be visible.
            var endTime = startTime + s_canaryMessageTimeout;

            while (DateTime.UtcNow < endTime)
            {
                FileLogger.Log("Listing log entries to find the canary");
                if (_client.ListLogEntries(request).Any())
                {
                    return;
                }
                Thread.Sleep(s_delayBetweenCanaryAttempts);
            }
            throw new Exception("Canary message never seen.");
        }

        private class TestValidator
        {
            public string TestId { get; }
            public string TestMethod { get; }
            public Action<IReadOnlyList<LogEntry>> Validator { get; }

            public TestValidator(string testId, string testMethod, Action<IReadOnlyList<LogEntry>> validator)
            {
                TestId = testId;
                TestMethod = testMethod;
                Validator = validator;
            }

            public Exception Validate(IReadOnlyList<LogEntry> allEntries)
            {
                var filteredEntries = allEntries.Where(entry => entry.JsonPayload.Fields["message"].StringValue.Contains(TestId)).ToList();
                try
                {
                    Validator.Invoke(filteredEntries);
                    return null;
                }
                catch (Exception e)
                {
                    return new Exception($"Error in test {TestMethod} with testId {TestId}", e);
                }
            }
        }

        private ListLogEntriesRequest BuildRequest(DateTime startTime)
        {
            // Convert the time to RFC3339 UTC format.
            string time = XmlConvert.ToString(startTime, XmlDateTimeSerializationMode.Utc);

            return new ListLogEntriesRequest
            {
                ResourceNames = { $"projects/{_projectId}" },
                Filter = $"timestamp >= \"{time}\" AND logName=\"projects/{_projectId}/logs/aspnetcore\"",
                PageSize = 1000
            };
        }
    }
}
