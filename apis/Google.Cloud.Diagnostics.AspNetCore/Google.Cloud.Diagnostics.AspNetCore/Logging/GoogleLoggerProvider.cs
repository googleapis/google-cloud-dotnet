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
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Logging.V2;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public class GoogleLoggerProvider : ILoggerProvider
    {
        private readonly IConsumer<LogEntry> _consumer;
        private readonly LogLevel _logLevel;
        private readonly string _projectId;

        internal GoogleLoggerProvider(IConsumer<LogEntry> consumer, string projectId, LogLevel logLevel)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _projectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            _logLevel = logLevel;
        }

        public ILogger CreateLogger(string logName)
        {
            return new GoogleLogger(_consumer, _logLevel, _projectId, logName);
        }

        public void Dispose() {}
    }
}
