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

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    /// <summary>
    /// 
    /// </summary>
    public class TestTableContext : DbContext
    {
        private readonly TestDatabaseFixture _fixture;
        private readonly Predicate<string> _logFilter;
        private readonly StringBuilder _log = new StringBuilder();

        public TestTableContext(TestDatabaseFixture fixture, Predicate<string> logFilter)
        {
            _fixture = fixture;
            _logFilter = logFilter;
        }

        public virtual DbSet<StringEntry> StringTable { get; set; }

        public string GetCurrentLog()
        {
            lock (_log)
            {
                return _log.ToString().Trim();
            }
        }

        public void ClearLog()
        {
            lock (_log)
            {
                _log.Clear();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSpanner(_fixture.ConnectionString)
            .EnableSensitiveDataLogging()
            .UseLoggerFactory(new LoggerFactory(this));
        }

        class LoggerFactory : ILoggerFactory
        {
            private readonly TestTableContext _testTableContext;

            public LoggerFactory(TestTableContext testTableContext)
            {
                _testTableContext = testTableContext;
            }

            public void Dispose()
            {
            }
            public ILogger CreateLogger(string categoryName) => new RecordedLogger(_testTableContext);
            public void AddProvider(ILoggerProvider provider)
            {}
        }

        class RecordedLogger : ILogger
        {
            private readonly TestTableContext _testTableContext;
            public RecordedLogger(TestTableContext testTableContext)
            {
                _testTableContext = testTableContext;
            }

            public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                string message = formatter(state, exception).Replace("\r\n", " ").Trim();
                if (logLevel >= LogLevel.Error || _testTableContext._logFilter(message))
                {
                    lock (_testTableContext._log)
                    {
                        _testTableContext._log.AppendLine(
                            $"message:{message}");
                    }
                }
            }

            public bool IsEnabled(LogLevel logLevel) => true;

            public IDisposable BeginScope<TState>(TState state)
            {
                return null;
            }
        }
    }

    public class StringEntry
    {
        [Key]
        public string Key { get; set; }
        public string StringValue { get; set; }
    }

}