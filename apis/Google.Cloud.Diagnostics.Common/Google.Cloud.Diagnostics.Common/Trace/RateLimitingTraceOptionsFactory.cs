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

using Google.Api.Gax;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A factory to generate trace options based on a rate limiter.
    /// </summary>
    internal sealed class RateLimitingTraceOptionsFactory : ITraceOptionsFactory
    {
        private readonly RateLimiter _rateLimiter;

        private RateLimitingTraceOptionsFactory(TraceOptions options)
        {
            GaxPreconditions.CheckNotNull(options, nameof(options));
            _rateLimiter = RateLimiter.GetInstance(options.QpsSampleRate);
        }

        internal RateLimitingTraceOptionsFactory(RateLimiter rateLimiter)
        {
            _rateLimiter = GaxPreconditions.CheckNotNull(rateLimiter, nameof(rateLimiter));
        }

        /// <summary>
        /// Create a new <see cref="RateLimitingTraceOptionsFactory"/>.
        /// </summary>
        /// <param name="options">Optional trace options, if unset the default will be used.</param>
        public static RateLimitingTraceOptionsFactory Create(TraceOptions options = null)
        {
            return new RateLimitingTraceOptionsFactory(options ?? TraceOptions.Create());
        }

        /// <inheritdoc />
        public InternalTraceOptions CreateOptions()
        {
            return InternalTraceOptions.Create(_rateLimiter.CanTrace());
        }
    }
}