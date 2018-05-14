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
        public static TransactionOptions Default { get; } = new TransactionOptions(5);

        /// <summary>
        /// The number of times the transaction will be attempted before failing.
        /// </summary>
        public int MaxAttempts { get; }

        private TransactionOptions(int maxAttempts)
        {
            MaxAttempts = maxAttempts;
        }

        /// <summary>
        /// Creates an instance with the given maximum number of attempts.
        /// </summary>
        /// <param name="maxAttempts">The number of times a transaction will be attempted before failing. Must be positive.</param>
        /// <returns>A new options object.</returns>
        public static TransactionOptions ForMaxAttempts(int maxAttempts)
        {
            GaxPreconditions.CheckArgumentRange(maxAttempts, nameof(maxAttempts), 1, int.MaxValue);
            return new TransactionOptions(maxAttempts);
        }
    }
}
