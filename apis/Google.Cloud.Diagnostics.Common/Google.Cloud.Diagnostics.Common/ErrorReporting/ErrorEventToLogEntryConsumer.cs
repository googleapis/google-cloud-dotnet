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

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Cloud.Logging.V2;
using Google.Api.Gax;
using Google.Api;
using Google.Protobuf.WellKnownTypes;
using Google.Cloud.Logging.Type;

namespace Google.Cloud.Diagnostics.Common
{
    internal class ErrorEventToLogEntryConsumer : IConsumer<ReportedErrorEvent>
    {
        private readonly string _logName;
        private readonly IConsumer<LogEntry> _logConsumer;
        private readonly MonitoredResource _monitoredResource;

        public ErrorEventToLogEntryConsumer(string logName, LogTo logTo,
            IConsumer<LogEntry> logConsumer, MonitoredResource monitoredResource)
        {
            _logName = GaxPreconditions.CheckNotNull(logTo, nameof(logTo)).GetFullLogName(logName);
            _logConsumer = GaxPreconditions.CheckNotNull(logConsumer, nameof(logConsumer));
            _monitoredResource = GaxPreconditions.CheckNotNull(monitoredResource, nameof(monitoredResource));
        }

        public void Receive(IEnumerable<ReportedErrorEvent> items) =>
            _logConsumer.Receive(ConvertErrorEvents(items));

        public async Task ReceiveAsync(IEnumerable<ReportedErrorEvent> items,
            CancellationToken cancellationToken = default(CancellationToken)) => 
                await _logConsumer.ReceiveAsync(ConvertErrorEvents(items), cancellationToken);
    
        internal IEnumerable<LogEntry> ConvertErrorEvents(IEnumerable<ReportedErrorEvent> items)
        {
            List<LogEntry> logEntries = new List<LogEntry>();
            foreach (var errorEvent in items)
            {
                LogEntry logEntry = new LogEntry
                {
                    Resource = _monitoredResource,
                    LogName = _logName,
                    Severity = LogSeverity.Error,
                    Timestamp = Timestamp.FromDateTime(DateTime.UtcNow),
                    JsonPayload = errorEvent.ToStruct(),
                };
                logEntries.Add(logEntry);
            }
            return logEntries;
        }
    }
}
