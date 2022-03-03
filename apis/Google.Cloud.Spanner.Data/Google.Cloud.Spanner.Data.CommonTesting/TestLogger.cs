// Copyright 2018 Google Inc. All Rights Reserved.
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

using Google.Cloud.ClientTesting;
using Microsoft.Extensions.Logging;
using System;

namespace Google.Cloud.Spanner.Data.CommonTesting
{
    /// <summary>
    /// ILogger implementation that delegates to <see cref="FileLogger"/>.
    /// </summary>
    public class TestLogger : ILogger
    {
        public static TestLogger Instance { get; } = new TestLogger();
        
        private TestLogger()
        {
        }

        private void WriteLine(string line)
        {
            try
            {
                FileLogger.Log(line);
            }
            catch (Exception)
            {
                // Eat the exception.  This can happen if we try to output a log
                // after a test has completed (some action occurred asynchronously).
            }
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter) =>
            WriteLine(formatter(state, exception));

        public bool IsEnabled(LogLevel logLevel) => logLevel >= LogLevel.Debug;

        public IDisposable BeginScope<TState>(TState state) =>
            throw new NotImplementedException();
    }
}
