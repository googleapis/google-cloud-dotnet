// Copyright 2022 Google LLC
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

using Google.Api.Gax;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using MsLogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace Google.Cloud.Spanner.V1.Internal.Logging;

/// <summary>
/// Implementation of Logger that adapts a Microsoft.Extensions.Logging.ILogger.
/// This allows users to unify their logs without a very disruptive change, before
/// we eventually remove Spanner internal logging entirely.
/// </summary>
internal sealed class MsLogger : Logger
{
    private readonly ILogger _logger;

    internal MsLogger(ILogger logger) =>
        _logger = GaxPreconditions.CheckNotNull(logger, nameof(logger));

    protected override void LogPerformanceEntries(IEnumerable<string> entries)
    {
        foreach (var entry in entries)
        {
            _logger.Log(MsLogLevel.Trace, entry);
        }
    }

    protected override void LogImpl(LogLevel level, string message, Exception exception)
    {
        var msLogLevel = level switch
        {
            LogLevel.None => MsLogLevel.None,
            LogLevel.Debug => MsLogLevel.Debug,
            LogLevel.Info => MsLogLevel.Information,
            LogLevel.Error => MsLogLevel.Error,
            LogLevel.Warn => MsLogLevel.Warning,
            _ => MsLogLevel.Debug
        };
        _logger.Log(msLogLevel, exception, message);
    }
}
