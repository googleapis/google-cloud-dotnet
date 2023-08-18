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

using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore3.Tests
{
    public class GoogleExceptionLoggerTest
    {
        private static readonly Exception _exception = new Exception("opps..");

        [Fact]
        public void Log()
        {
            var contextAccessor = new HttpContextAccessor();
            var contextLogger = new FakeContextExceptionLogger();
            var logger = new GoogleExceptionLogger(contextLogger, contextAccessor);

            logger.Log(_exception, new DefaultHttpContext());
            Assert.Single(contextLogger.Entries);
        }

        [Fact]
        public void Log_NoContext()
        {
            var contextAccessor = new HttpContextAccessor { HttpContext = new DefaultHttpContext() };
            var contextLogger = new FakeContextExceptionLogger();
            var logger = new GoogleExceptionLogger(contextLogger, contextAccessor);

            logger.Log(_exception);

            var entry = Assert.Single(contextLogger.Entries);
            Assert.Same(_exception, entry.Item1);
        }

        [Fact]
        public void Log_NoContext_NoAccessorContext()
        {
            var contextAccessor = new HttpContextAccessor();
            var contextLogger = new FakeContextExceptionLogger();
            var logger = new GoogleExceptionLogger(contextLogger, contextAccessor);

            logger.Log(_exception);

            var entry = Assert.Single(contextLogger.Entries);
            Assert.Same(_exception, entry.Item1);
        }

        [Fact]
        public async Task LogAsync()
        {
            var contextAccessor = new HttpContextAccessor();
            var contextLogger = new FakeContextExceptionLogger();
            var logger = new GoogleExceptionLogger(contextLogger, contextAccessor);

            await logger.LogAsync(_exception, new DefaultHttpContext());

            var entry = Assert.Single(contextLogger.Entries);
            Assert.Same(_exception, entry.Item1);
        }

        [Fact]
        public async Task LogAsync_NoContext()
        {
            var contextAccessor = new HttpContextAccessor { HttpContext = new DefaultHttpContext() };
            var contextLogger = new FakeContextExceptionLogger();
            var logger = new GoogleExceptionLogger(contextLogger, contextAccessor);

            await logger.LogAsync(_exception);

            var entry = Assert.Single(contextLogger.Entries);
            Assert.Same(_exception, entry.Item1);
        }

        private class FakeContextExceptionLogger : IContextExceptionLogger
        {
            public List<(Exception, IContextWrapper)> Entries { get; } = new();

            public FakeContextExceptionLogger()
            {
            }

            public void Log(Exception exception, IContextWrapper context) =>
                Entries.Add((exception, context));

            public Task LogAsync(Exception exception, IContextWrapper context, CancellationToken cancellationToken = default)
            {
                Log(exception, context);
                return Task.CompletedTask;
            }                

            public void Dispose()
            {
            }
        }
    }
}
