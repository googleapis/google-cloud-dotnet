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
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore.Storage;

namespace Microsoft.EntityFrameworkCore.Utilities
{
    public class TestSpannerRetryingExecutionStrategy : SpannerRetryingExecutionStrategy
    {
        public TestSpannerRetryingExecutionStrategy()
            : base(
                new DbContext(new DbContextOptionsBuilder().UseSpanner(TestEnvironment.DefaultConnection).Options),
                DefaultMaxRetryCount, DefaultMaxDelay)
        {
        }

        public TestSpannerRetryingExecutionStrategy(DbContext context)
            : base(context, DefaultMaxRetryCount, DefaultMaxDelay)
        {
        }

        public TestSpannerRetryingExecutionStrategy(DbContext context, TimeSpan maxDelay)
            : base(context, DefaultMaxRetryCount, maxDelay)
        {
        }

        public TestSpannerRetryingExecutionStrategy(ExecutionStrategyDependencies dependencies)
            : base(dependencies, DefaultMaxRetryCount, DefaultMaxDelay)
        {
        }

        protected override bool ShouldRetryOn(Exception exception)
        {
            if (base.ShouldRetryOn(exception))
            {
                return true;
            }

            if (exception is SpannerException spannerException)
            {
                var message = $"Didn't retry on {spannerException.Message}";
                throw new InvalidOperationException(message, exception);
            }

            return false;
        }

        protected override TimeSpan? GetNextDelay(Exception lastException)
        {
            ExceptionsEncountered.Add(lastException);
            return base.GetNextDelay(lastException);
        }
    }
}