// Copyright 2018 Google Inc. All rights reserved.
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
using Grpc.Core;
using System;
using System.Diagnostics;

namespace Google.Cloud.Bigtable.V2
{
    public partial class BigtableSettings
    {
        partial void OnConstruction()
        {
            var originalMutateRowsSettings = MutateRowsSettings;
            Debug.Assert(
                originalMutateRowsSettings.CancellationToken == null &&
                originalMutateRowsSettings.Credentials == null &&
                originalMutateRowsSettings.HeaderMutation == null &&
                originalMutateRowsSettings.PropagationToken == null &&
                originalMutateRowsSettings.WriteOptions == null &&
                originalMutateRowsSettings.Timing != null &&
                originalMutateRowsSettings.Timing.Type == CallTimingType.Expiration);
            MutateRowsSettings =
                CallSettings.FromCallTiming(
                    CallTiming.FromRetry(new RetrySettings(
                        retryBackoff: GetDefaultRetryBackoff(),
                        timeoutBackoff: GetDefaultTimeoutBackoff(),
                        totalExpiration: Expiration.FromTimeout(
                            originalMutateRowsSettings.Timing?.Expiration?.Timeout ?? TimeSpan.FromMilliseconds(600000)),
                        retryFilter: IdempotentRetryFilter
                    )));
        }

        partial void OnCopy(BigtableSettings existing)
        {
            IdempotentMutateRowSettings = existing.IdempotentMutateRowSettings;
        }

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableClient.MutateRow</c> and <c>BigtableClient.MutateRowAsync</c>
        /// when the request is known to be idempotent.
        /// </summary>
        /// <remarks>
        /// Note that additional settings from <see cref="MutateRowSettings"/> will be used if they
        /// are not specified on <see cref="IdempotentMutateRowSettings"/>.
        /// The default <c>BigtableClient.MutateRow</c> and
        /// <c>BigtableClient.MutateRowAsync</c> <see cref="RetrySettings"/> for idempotent requests are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        /// <seealso cref="MutateRowSettings"/>
        public CallSettings IdempotentMutateRowSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));
    }
}
