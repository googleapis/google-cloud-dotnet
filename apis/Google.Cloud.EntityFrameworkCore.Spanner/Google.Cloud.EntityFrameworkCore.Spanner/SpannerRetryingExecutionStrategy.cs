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

namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    /// Defines how to retry operations for EF Spanner.
    /// </summary>
    public class SpannerRetryingExecutionStrategy : ExecutionStrategy
    {
        /// <summary>
        /// Creates a new instance of <see cref="SpannerRetryingExecutionStrategy" />.
        /// </summary>
        /// <param name="context"> The context on which the operations will be invoked. </param>
        /// <remarks>
        /// The default retry limit is 6, which means that the total amount of time spent before failing is about a minute.
        /// </remarks>
        public SpannerRetryingExecutionStrategy(
            DbContext context)
            : this(context, DefaultMaxRetryCount)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="SpannerRetryingExecutionStrategy" />.
        /// </summary>
        /// <param name="dependencies"> Parameter object containing service dependencies. </param>
        public SpannerRetryingExecutionStrategy(
            ExecutionStrategyDependencies dependencies)
            : this(dependencies, DefaultMaxRetryCount)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="SpannerRetryingExecutionStrategy" />.
        /// </summary>
        /// <param name="context"> The context on which the operations will be invoked. </param>
        /// <param name="maxRetryCount"> The maximum number of retry attempts. </param>
        public SpannerRetryingExecutionStrategy(
            DbContext context,
            int maxRetryCount)
            : this(context, maxRetryCount, DefaultMaxDelay)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="SpannerRetryingExecutionStrategy" />.
        /// </summary>
        /// <param name="dependencies"> Parameter object containing service dependencies. </param>
        /// <param name="maxRetryCount"> The maximum number of retry attempts. </param>
        public SpannerRetryingExecutionStrategy(
            ExecutionStrategyDependencies dependencies,
            int maxRetryCount)
            : this(dependencies, maxRetryCount, DefaultMaxDelay)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="SpannerRetryingExecutionStrategy" />.
        /// </summary>
        /// <param name="context"> The context on which the operations will be invoked. </param>
        /// <param name="maxRetryCount"> The maximum number of retry attempts. </param>
        /// <param name="maxRetryDelay"> The maximum delay between retries. </param>
        public SpannerRetryingExecutionStrategy(
            DbContext context,
            int maxRetryCount,
            TimeSpan maxRetryDelay)
            : base(context,
                maxRetryCount,
                maxRetryDelay)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="SpannerRetryingExecutionStrategy" />.
        /// </summary>
        /// <param name="dependencies"> Parameter object containing service dependencies. </param>
        /// <param name="maxRetryCount"> The maximum number of retry attempts. </param>
        /// <param name="maxRetryDelay"> The maximum delay between retries. </param>
        public SpannerRetryingExecutionStrategy(
            ExecutionStrategyDependencies dependencies,
            int maxRetryCount,
            TimeSpan maxRetryDelay)
            : base(dependencies, maxRetryCount, maxRetryDelay)
        {
        }

        /// <inheritdoc />
        protected override bool ShouldRetryOn(Exception exception) => exception.IsTransientSpannerFault();
    }
}