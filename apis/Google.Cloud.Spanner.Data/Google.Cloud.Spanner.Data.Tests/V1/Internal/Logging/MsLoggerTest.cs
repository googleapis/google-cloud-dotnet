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

using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.Spanner.V1.Internal.Logging.Tests;

public class MsLoggerTest
{
    [Fact]
    public void LogLevelMapping()
    {
        var fake = new FakeLogger();
        var logger = Logger.ForILogger(fake);
        logger.LogLevel = LogLevel.Debug;
        logger.Log(LogLevel.Debug, "Debug message", null);
        logger.Log(LogLevel.Info, "Info message", null);
        logger.Log(LogLevel.Warn, "Warn message", null);
        logger.Log(LogLevel.Error, "Error message", null);

        var expected = new List<string>
        {
            "Debug: Debug message",
            "Information: Info message",
            "Warning: Warn message",
            "Error: Error message"
        };
        Assert.Equal(expected, fake.Entries);
    }

    [Fact]
    public void WithException()
    {
        var fake = new FakeLogger();
        var logger = Logger.ForILogger(fake);
        logger.LogLevel = LogLevel.Debug;
        logger.Log(LogLevel.Error, "Error message", new Exception("Bang"));
        var entry = Assert.Single(fake.Entries);
        Assert.Contains("Error message", entry);
        Assert.Contains("Exception: Bang", entry);
    }

    [Fact]
    public void Performance()
    {
        var fake = new FakeLogger();
        var logger = Logger.ForILogger(fake);
        logger.LogPerformanceTraces = true;
        logger.LogPerformanceCounter("counter", 10.0);
        logger.LogPerformanceData();
        var entry = Assert.Single(fake.Entries);
        Assert.StartsWith("Trace", entry);
        Assert.Contains("counter", entry);
        Assert.Contains("last=10", entry);
    }

    private class FakeLogger : ILogger
    {
        public List<string> Entries { get; } = new List<string>();

        public IDisposable BeginScope<TState>(TState state) =>
            throw new NotImplementedException();

        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel) =>
            throw new NotImplementedException();

        public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter) =>
            Entries.Add(exception is null ? $"{logLevel}: {formatter(state, exception)}": $"{logLevel}: Exception: {exception.Message}, {formatter(state, exception)}");
    }
}
