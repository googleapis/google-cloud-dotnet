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
using Google.Cloud.Spanner.V1.Internal.Logging;

namespace Microsoft.EntityFrameworkCore.Diagnostics
{
    /// <summary>
    /// This is internal functionality and not intended for public use.
    /// </summary>
    public class SpannerLogBridge<TLoggerCategory> : Logger
        where TLoggerCategory : LoggerCategory<TLoggerCategory>, new()
    {
        //Note: This class is used to forward logging messages from within the ADO.NET layer
        // into the logging framework provided by EFCore.  Therefore, someone looking at EFCore logs
        // will see logs written by Google.Cloud.Spanner.Data.dll
        private readonly IDiagnosticsLogger<TLoggerCategory> _efLogger;

        /// <summary>
        /// This is internal functionality and not intended for public use.
        /// </summary>
        public SpannerLogBridge(IDiagnosticsLogger<TLoggerCategory> efLogger) => _efLogger = efLogger;

        /// <summary>
        /// This is internal functionality and not intended for public use.
        /// </summary>
        public override bool EnableSensitiveDataLogging
        {
            get => _efLogger.ShouldLogSensitiveData();
            // ReSharper disable once ValueParameterNotUsed
            set => _efLogger.Logger.Log(Microsoft.Extensions.Logging.LogLevel.Error,
                SpannerEventId.SpannerDiagnosticLog,
                "EnableSensitiveDataLogging should only be configured from DbContextOptionsBuilder.EnableSensitiveDataLogging",
                null, (x, e) => x);
        }

        /// <summary>
        /// This is internal functionality and not intended for public use.
        /// </summary>
        public override void Debug(Func<string> messageFunc)
        {
            _efLogger.Logger.Log(Microsoft.Extensions.Logging.LogLevel.Debug,
                SpannerEventId.SpannerDiagnosticLog, messageFunc, null, (x, e) => x());
        }

        /// <summary>
        /// This is internal functionality and not intended for public use.
        /// </summary>
        public override void Error(Func<string> messageFunc, Exception exception = null)
        {
            _efLogger.Logger.Log(Microsoft.Extensions.Logging.LogLevel.Error,
                SpannerEventId.SpannerDiagnosticLog, messageFunc, exception, (x, e) => $"{x()}, detail:{e}");
        }

        /// <summary>
        /// This is internal functionality and not intended for public use.
        /// </summary>
        public override void Info(Func<string> messageFunc)
        {
            _efLogger.Logger.Log(Microsoft.Extensions.Logging.LogLevel.Information,
                SpannerEventId.SpannerDiagnosticLog, messageFunc, null, (x, e) => x());
        }

        /// <summary>
        /// This is internal functionality and not intended for public use.
        /// </summary>
        public override void Warn(Func<string> messageFunc, Exception exception = null)
        {
            _efLogger.Logger.Log(Microsoft.Extensions.Logging.LogLevel.Warning,
                SpannerEventId.SpannerDiagnosticLog, messageFunc, null, (x, e) => x());
        }

        /// <inheritdoc />
        public override void Debug(string message) => Debug(() => message);

        /// <inheritdoc />
        public override void Info(string message) => Info(() => message);

        /// <inheritdoc />
        public override void Warn(string message, Exception exception = null) => Warn(() => message, exception);

        /// <inheritdoc />
        public override void Error(string message, Exception exception = null) => Error(() => message, exception);

        /// <summary>
        /// This is internal functionality and not intended for public use.
        /// </summary>
        public override void LogPerformanceEntries(IEnumerable<string> entries)
        {
            string message = $"Performance entries{Environment.NewLine}{string.Join(Environment.NewLine, entries)}";
            _efLogger.Logger.Log(Microsoft.Extensions.Logging.LogLevel.Information,
                SpannerEventId.SpannerDiagnosticLog, message, null, (x, e) => x);
        }

        /// <inheritdoc />
        protected override void WriteLine(LogLevel level, string message)
        {
            throw new NotImplementedException();
        }
    }
}