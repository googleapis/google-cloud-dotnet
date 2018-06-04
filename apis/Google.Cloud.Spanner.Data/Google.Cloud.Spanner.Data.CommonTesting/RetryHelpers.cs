// Copyright 2018 Google LLC
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

using System;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data.CommonTesting
{
    /// <summary>
    /// Helper methods to provide *very* simplistic retry behavior:
    /// - No backoff
    /// - A single retry
    /// - Only if the error code is "aborted"
    /// 
    /// This is enough to make the snippet/integration tests significantly more stable.
    /// </summary>
    public static class RetryHelpers
    {
        /// <summary>
        /// Executes a single command, retrying once if the first attempt is aborted.
        /// Only for use in "one-shot" commands (not in a transaction).
        public static Task<int> ExecuteNonQueryAsyncWithRetry(this SpannerCommand command) =>
            ExecuteWithRetryAsync(() => command.ExecuteNonQueryAsync());

        /// <summary>
        /// Executes the given action, retrying once if the first attempt is aborted.
        /// </summary>
        public static void RetryOnce(Action action) => ExecuteWithRetry(() => { action(); return 0; });

        /// <summary>
        /// Executes the given asynchronous action, retrying once if the first attempt is aborted.
        /// </summary>
        public static Task RetryOnceAsync(Func<Task> action) => ExecuteWithRetryAsync(async () => { await action(); return 0; });

        private static T ExecuteWithRetry<T>(Func<T> func)
        {
            try
            {
                return func();
            }
            catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
            {
                // Try it once more...
                return func();
            }
        }

        private static async Task<T> ExecuteWithRetryAsync<T>(Func<Task<T>> func)
        {
            try
            {
                return await func();
            }
            catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
            {
                // Try it once more...
                return await func();
            }
        }
    }
}
