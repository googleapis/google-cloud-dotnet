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
namespace Google.Cloud.Bigtable.Admin.V2
{
    public partial class BigtableTableAdminSettings
    {
        /// <summary>
        /// Method returning the legacy "Default" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// This method is no longer used for RPCs; see the individual RPC comments for which retry settings are now used.
        /// </summary>
        /// <returns>
        /// Legacy "Default" retry backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        [Obsolete("No longer used by RPC methods by default. See individual RPC comments to find out which method is currently used.")]
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(5),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 2.0
        );

        /// <summary>
        /// Method returning the legacy "Default" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// This method is no longer used for RPCs; see the individual RPC comments for which retry settings are now used.
        /// </summary>
        /// <returns>
        /// Legacy "Default" timeout backoff for <see cref="BigtableTableAdminClient"/> RPC methods.
        /// </returns>
        [Obsolete("No longer used by RPC methods by default. See individual RPC comments to find out which method is currently used.")]
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(60000),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );
    }

    public partial class BigtableInstanceAdminSettings
    {
        /// <summary>
        /// Method returning the legacy "Default" retry backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// This method is no longer used for RPCs; see the individual RPC comments for which retry settings are now used.
        /// </summary>
        /// <returns>
        /// Legacy "Default" retry backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </returns>
        [Obsolete("No longer used by RPC methods by default. See individual RPC comments to find out which method is currently used.")]
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(5),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 2.0
        );

        /// <summary>
        /// Method returning the legacy "Default" timeout backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// This method is no longer used for RPCs; see the individual RPC comments for which retry settings are now used.
        /// </summary>
        /// <returns>
        /// Legacy "Default" timeout backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </returns>
        [Obsolete("No longer used by RPC methods by default. See individual RPC comments to find out which method is currently used.")]
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(60000),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );
    }
}
