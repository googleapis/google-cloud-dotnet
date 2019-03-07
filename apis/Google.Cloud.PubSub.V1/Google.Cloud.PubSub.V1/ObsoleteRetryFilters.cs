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
using Grpc.Core;
using System;

namespace Google.Cloud.PubSub.V1
{
    // This file contains retry filters which have been removed from the GAPIC configuration,
    // but still need to be present for backward compatibility purposes.

    public partial class PublisherServiceApiSettings
    {
        /// <summary>
        /// Legacy property for a retry filter for status codes of Aborted,
        /// Cancelled, DeadlineExceeded, Internal, ResourceExhausted, Unavailable and Unknown.
        /// This property is no longer used in any default settings, and is only present
        /// for backward compatibility purposes.
        /// </summary>
        [Obsolete("This property is no longer used in any settings")]
        public static Predicate<RpcException> OnePlusDeliveryRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.Aborted, StatusCode.Cancelled, StatusCode.DeadlineExceeded, StatusCode.Internal, StatusCode.ResourceExhausted, StatusCode.Unavailable, StatusCode.Unknown);
    }

    public partial class SubscriberServiceApiSettings
    {
        /// <summary>
        /// Legacy property for a retry filter for status codes of
        /// DeadlineExceeded, Internal, ResourceExhausted and Unavailable.
        /// This property is no longer used in any default settings, and is only present
        /// for backward compatibility purposes.
        /// </summary>
        [Obsolete("This property is no longer used in any settings")]
        public static Predicate<RpcException> PullRetryFilter { get; } = 
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Internal, StatusCode.ResourceExhausted, StatusCode.Unavailable);        
    }
}
