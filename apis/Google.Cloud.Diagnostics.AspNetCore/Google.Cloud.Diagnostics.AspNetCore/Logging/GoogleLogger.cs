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

using Google.Cloud.Logging.V2;
using Google.Cloud.Diagnostics.Common;
using Google.Protobuf.WellKnownTypes;
using Google.Api.Gax;
using Microsoft.Extensions.Logging;
using System;
using Google.Api;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    internal class GoogleLogger : ILogger
    {
        private readonly IConsumer<LogEntry> _consumer;
        private readonly LogLevel _logLevel;
        private readonly string _logName;
        private readonly MonitoredResource _resource;

        public GoogleLogger(IConsumer<LogEntry> consumer, LogLevel logLevel, string projectId, string logName)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            GaxPreconditions.CheckNotNull(logName, nameof(logName));
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _logLevel = logLevel;
            _logName = LogUtils.GetLogName(projectId, logName);

            _resource = new MonitoredResource {
                Type = "global"
            };
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel >= _logLevel;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            GaxPreconditions.CheckNotNull(formatter, nameof(formatter));

            if (!IsEnabled(logLevel))
            {
                return;
            }

            string message = formatter(state, exception);
            if (string.IsNullOrEmpty(message))
            {
                return;
            }

            LogEntry entry = new LogEntry
            {   
                Resource = _resource,
                LogName = _logName,
                Severity = LogUtils.Convert(logLevel),
                Timestamp = Timestamp.FromDateTime(DateTime.UtcNow),
                TextPayload = message,
            };

            _consumer.Receive(new LogEntry[] { entry });
        }
    }
}
