// Copyright 2017, Google Inc. All rights reserved.
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
using Google.Api.Gax.Grpc;
using System;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Immutable class representing options for executing transactions.
    /// </summary>
    public sealed class TransactionOptions
    {
        /// <summary>
        /// The transaction options that are used if nothing is specified by the caller.
        /// </summary>
        public static TransactionOptions Default { get; } = ForMaxAttempts(5);

        /// <summary>
        /// The number of times the transaction will be attempted before failing.
        /// This is equivalent to <see cref="RetrySettings.MaxAttempts"/>.
        /// </summary>
        public int MaxAttempts => RetrySettings.MaxAttempts;

        /// <summary>
        /// The settings to control the timing of retries within the transaction.
        /// The <see cref="RetrySettings.RetryFilter"/> property is ignored. This property is never null.
        /// </summary>
        public RetrySettings RetrySettings { get; }

        private TransactionOptions(RetrySettings retrySettings)
        {
            RetrySettings = retrySettings;
        }

        /// <summary>
        /// Creates an instance with the given maximum number of attempts. The default retry
        /// timing will be used.
        /// </summary>
        /// <param name="maxAttempts">The number of times a transaction will be attempted before failing. Must be positive.</param>
        /// <returns>A new options object.</returns>
        public static TransactionOptions ForMaxAttempts(int maxAttempts) =>
            new TransactionOptions(RetrySettings.FromExponentialBackoff(
                maxAttempts: maxAttempts,
                initialBackoff: TimeSpan.FromMilliseconds(100),
                maxBackoff: TimeSpan.FromMinutes(1),
                backoffMultiplier: 1.3,
                retryFilter: x => true)); // Ignored

        /// <summary>
        /// Creates an instance with the given retry settings, including maximum number of attempts.
        /// The <see cref="RetrySettings.RetryFilter"/> property is not used.
        /// </summary>
        /// <param name="retrySettings">The retry settings to use. Must not be null.</param>
        /// <returns>A new options object.</returns>
        public static TransactionOptions ForRetrySettings(RetrySettings retrySettings) =>
            new TransactionOptions(GaxPreconditions.CheckNotNull(retrySettings, nameof(retrySettings)));
    }
}
