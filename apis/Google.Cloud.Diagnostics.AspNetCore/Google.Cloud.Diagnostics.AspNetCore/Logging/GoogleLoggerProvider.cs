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
    /// <summary>
    /// <see cref="ILoggerProvider"/> for Google Stackdriver Logging.
    /// </summary>
    public sealed class GoogleLoggerProvider : ILoggerProvider
    {
        /// <summary>The consumer to push logs to.</summary>
        private readonly IConsumer<LogEntry> _consumer;

        /// <summary>The logger options.</summary>
        private readonly LoggerOptions _loggerOptions;

        /// <summary>Where to log to.</summary>
        private readonly LogTarget _logTarget;

        /// <summary>
        /// <see cref="ILoggerProvider"/> for Google Stackdriver Logging.
        /// </summary>
        /// <param name="consumer">The consumer to push logs to. Cannot be null.</param>
        /// <param name="logTarget">Where to log to. Cannot be null.</param>
        /// <param name="loggerOptions">The logger options. Cannot be null.</param>
        internal GoogleLoggerProvider(IConsumer<LogEntry> consumer, LogTarget logTarget, LoggerOptions loggerOptions)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _logTarget = GaxPreconditions.CheckNotNull(logTarget, nameof(logTarget));
            _loggerOptions = GaxPreconditions.CheckNotNull(loggerOptions, nameof(loggerOptions));
        }

        /// <summary>
        /// Creates a <see cref="GoogleLogger"/> with the given log name.
        /// </summary>
        /// <param name="logName">The name of the log.  This will be combined with the log location
        ///     (<see cref="LogTarget"/>) to generate the resource name for the log.</param>
        public ILogger CreateLogger(string logName) => new GoogleLogger(_consumer, _logTarget, _loggerOptions, logName);

        /// <inheritdoc />
        public void Dispose() => _consumer.Dispose();
    }
}
