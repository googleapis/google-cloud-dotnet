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

using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using sys = System;

namespace Google.Cloud.PubSub.V1
{
    public partial class SubscriberServiceApiSettings
    {
        /// <summary>
        /// In previous releases, this property returned a filter used by default for "None" RPC methods.
        /// It is now unused, and may not represent the current default behavior.
        /// </summary>
        [sys::Obsolete("This member is no longer called by other code in this library.")]
        public static sys::Predicate<grpccore::RpcException> NoneRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();
    }
}
