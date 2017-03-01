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

using Google.Api;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Diagnostics.Common;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// Options for a <see cref="GoogleLogger"/>.
    /// </summary>
    public sealed class LoggerOptions
    {
        /// <summary>The minimum log level.</summary>
        public LogLevel LogLevel { get; }

        /// <summary>The monitored resource. See: https://cloud.google.com/logging/docs/api/v2/resource-list </summary>
        public MonitoredResource MonitoredResource { get; }

        /// <summary>The buffer options for the logger.</summary>
        public BufferOptions BufferOptions { get; }

        /// <summary>Custom labels for log entires.</summary>
        public Dictionary<string, string> Labels { get; }

        private LoggerOptions(
            LogLevel logLevel, Dictionary<string, string> labels,
            MonitoredResource monitoredResource, BufferOptions bufferOptions)
        {
            LogLevel = GaxPreconditions.CheckEnumValue(logLevel, nameof(logLevel));
            Labels = labels;
            MonitoredResource = monitoredResource;
            BufferOptions = bufferOptions;
        }

        /// <summary>
        /// Create a new instance of <see cref="LoggerOptions"/>.
        /// </summary>
        /// <param name="logLevel">Optional, the minimum log level.  Defaults to <see cref="LogLevel.Information"/></param>
        /// <param name="labels">Optional, custom labels to be added to log entries.</param>
        /// <param name="monitoredResource">Optional, the monitored resource.  The monitored resource will
        ///     be automatically detected if it is not set and will default to the global resource if the detection fails.
        ///     See: https://cloud.google.com/logging/docs/api/v2/resource-list </param>
        /// <param name="bufferOptions">Optional, the buffer options.  Defaults to a <see cref="BufferType.Timed"/></param>
        public static LoggerOptions Create(LogLevel logLevel = LogLevel.Information,
            Dictionary<string, string> labels = null,
            MonitoredResource monitoredResource = null, BufferOptions bufferOptions = null)
        {
            labels = labels ?? new Dictionary<string, string>();
            monitoredResource = monitoredResource ?? MonitoredResourceBuilder.FromPlatform();
            bufferOptions = bufferOptions ?? BufferOptions.TimedBuffer();
            return new LoggerOptions(logLevel, labels, monitoredResource, bufferOptions);
        }
    }
}
