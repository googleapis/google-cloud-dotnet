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

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Cloud.Logging.V2;
using Google.Api.Gax;
using Google.Api;
using Google.Cloud.Logging.Type;
using System.Linq;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Converts and sends <see cref="ReportedErrorEvent"/>s to an <see cref="IConsumer{LogEntry}"/>.
    /// </summary>
    internal class ErrorEventToLogEntryConsumer : IConsumer<ReportedErrorEvent>
    {
        private readonly string _logName;
        private readonly IConsumer<LogEntry> _logConsumer;
        private readonly MonitoredResource _monitoredResource;

        /// <summary>
        /// Creates a new instance of the <see cref="ErrorEventToLogEntryConsumer"/>.
        /// </summary>
        /// <param name="logName">The name of the log.  Not the fully qualified name. Cannot be null.</param>
        /// <param name="logTarget">Where to log, such as a project or organization. Cannot be null.</param>
        /// <param name="logConsumer">The log consumer. Cannot be null.</param>
        /// <param name="monitoredResource">The resource that is being monitored. Cannot be null.</param>
        internal ErrorEventToLogEntryConsumer(string logName, LogTarget logTarget,
            IConsumer<LogEntry> logConsumer, MonitoredResource monitoredResource)
        {
            GaxPreconditions.CheckNotNullOrEmpty(logName, nameof(logName));
            _logName = GaxPreconditions.CheckNotNull(logTarget, nameof(logTarget)).GetFullLogName(logName);
            _logConsumer = GaxPreconditions.CheckNotNull(logConsumer, nameof(logConsumer));
            _monitoredResource = GaxPreconditions.CheckNotNull(monitoredResource, nameof(monitoredResource));
        }

        /// <inheritdoc />
        public void Receive(IEnumerable<ReportedErrorEvent> items) =>
            _logConsumer.Receive(ConvertErrorEvents(items));

        /// <inheritdoc />
        public Task ReceiveAsync(IEnumerable<ReportedErrorEvent> items,
            CancellationToken cancellationToken = default(CancellationToken)) => 
                _logConsumer.ReceiveAsync(ConvertErrorEvents(items), cancellationToken);

        /// <summary>
        /// Converts an <see cref="IEnumerable{ReportedErrorEvent}"/> to <see cref="IEnumerable{LogEntry}"/>.
        /// </summary>
        internal IEnumerable<LogEntry> ConvertErrorEvents(IEnumerable<ReportedErrorEvent> items) =>
            items.Select(errorEvent => new LogEntry
            {
                Resource = _monitoredResource,
                LogName = _logName,
                Severity = LogSeverity.Error,
                Timestamp = errorEvent.EventTime,
                JsonPayload = errorEvent.ToStruct()
            });
    }
}
