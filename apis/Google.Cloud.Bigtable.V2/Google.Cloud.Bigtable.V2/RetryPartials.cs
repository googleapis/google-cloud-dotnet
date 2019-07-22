// Copyright 2019 Google LLC
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

using Google.Api.Gax.Grpc;
using System;

// Partial classes for retry settings that have been renamed over time.
namespace Google.Cloud.Bigtable.V2
{
    public partial class BigtableServiceApiSettings
    {
        /// <summary>
        /// Method returning the legacy "Default" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// This method is no longer used for RPCs; see the individual RPC comments for which retry settings are now used.
        /// </summary>
        /// <returns>
        /// Legacy "Default" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        [Obsolete("No longer used by RPC methods by default. See individual RPC comments to find out which method is currently used.")]
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// Method returning the legacy "Default" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// This method is no longer used for RPCs; see the individual RPC comments for which retry settings are now used.
        /// </summary>
        /// <returns>
        /// Legacy "Default" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        [Obsolete("No longer used by RPC methods by default. See individual RPC comments to find out which method is currently used.")]
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// Method returning the legacy "Streaming" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// This method is no longer used for RPCs; see the individual RPC comments for which retry settings are now used.
        /// </summary>
        /// <returns>
        /// Legacy "Streaming" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        [Obsolete("No longer used by RPC methods by default. See individual RPC comments to find out which method is currently used.")]
        public static BackoffSettings GetStreamingRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// Method returning the legacy "Streaming" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// This method is no longer used for RPCs; see the individual RPC comments for which retry settings are now used.
        /// </summary>
        /// <returns>
        /// Legacy "Streaming" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        [Obsolete("No longer used by RPC methods by default. See individual RPC comments to find out which method is currently used.")]
        public static BackoffSettings GetStreamingTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );
    }
}
