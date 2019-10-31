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

using System;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using sys = System;

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    // This is a partial class introduced for backward compatibility with earlier versions.
    public partial class InstanceAdminSettings
    {
        /// <summary>
        /// In previous releases, this property returned a filter used by default for "Idempotent" RPC methods.
        /// It is now unused, and may not represent the current default behavior.
        /// </summary>
        [Obsolete("This member is no longer called by other code in this library. Please use the individual CallSettings properties.")]
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// In previous releases, this property returned a filter used by default for "NonIdempotent" RPC methods.
        /// It is now unused, and may not represent the current default behavior.
        /// </summary>
        [Obsolete("This member is no longer called by other code in this library. Please use the individual CallSettings properties.")]
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// In previous releases, this method returned the backoff used by default for "Idempotent" RPC methods.
        /// It is now unused, and may not represent the current default behavior.
        /// </summary>
        [Obsolete("This member is no longer called by other code in this library. Please use the individual CallSettings properties.")]
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(1000),
            maxDelay: sys::TimeSpan.FromMilliseconds(32000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// In previous releases, this method returned the backoff used by default for "NonIdempotent" RPC methods.
        /// It is now unused, and may not represent the current default behavior.
        /// </summary>
        [Obsolete("This member is no longer called by other code in this library. Please use the individual CallSettings properties.")]
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(60000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );
    }
}