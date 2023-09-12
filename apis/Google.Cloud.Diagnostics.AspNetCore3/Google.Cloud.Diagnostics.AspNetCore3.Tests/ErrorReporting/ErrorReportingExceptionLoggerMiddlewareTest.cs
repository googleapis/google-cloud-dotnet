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

using Google.Cloud.Diagnostics.Common.Tests;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore3.Tests
{
    public class ErrorReportingExceptionLoggerMiddlewareTest
    {
        [Fact]
        public async Task Invoke_NoLogs()
        {
            var logger = new FakeExceptionLogger(0);
            RequestDelegate requestDelegate = context => Task.CompletedTask;
            var middleware = new ErrorReportingExceptionLoggerMiddleware(requestDelegate, logger);

            await middleware.Invoke(new DefaultHttpContext());
            Assert.Empty(logger.Exceptions);
        }

        [Fact]
        public async Task Invoke_LogsAndThrows()
        {
            var logger = new FakeExceptionLogger(0);
            RequestDelegate requestDelegate = context => { throw new DivideByZeroException(); };
            var middleware = new ErrorReportingExceptionLoggerMiddleware(requestDelegate, logger);

            await Assert.ThrowsAsync<DivideByZeroException>(() => middleware.Invoke(new DefaultHttpContext()));
            var loggedException = Assert.Single(logger.Exceptions);
            Assert.IsType<DivideByZeroException>(loggedException);
        }

        [Fact]
        public async Task Invoke_LogThrowsAndThrows()
        {
            var logger = new FakeExceptionLogger(1);
            RequestDelegate requestDelegate = context => { throw new DivideByZeroException(); };
            var middleware = new ErrorReportingExceptionLoggerMiddleware(requestDelegate, logger);

            await Assert.ThrowsAsync<AggregateException>(() => middleware.Invoke(new DefaultHttpContext()));
            Assert.Empty(logger.Exceptions);
            Assert.Equal(1, logger.FailedCalls);
        }

        private class FakeExceptionLogger : IExceptionLogger
        {
            private readonly ThrowingConsumer<Exception> _consumer;

            public List<Exception> Exceptions => _consumer.Items;
            public int FailedCalls => _consumer.FailedCalls;

            public FakeExceptionLogger(int failures)
            {
                _consumer = new ThrowingConsumer<Exception>(failures);
            }

            public void Log(Exception exception, HttpContext context = null) =>
                _consumer.Receive(new[] { exception });

            public Task LogAsync(Exception exception, HttpContext context = null, CancellationToken cancellationToken = default) =>
                _consumer.ReceiveAsync(new[] { exception }, cancellationToken);
        }
    }
}
