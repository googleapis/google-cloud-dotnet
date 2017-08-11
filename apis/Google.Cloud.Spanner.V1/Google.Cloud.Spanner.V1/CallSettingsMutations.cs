// Copyright 2017 Google Inc. All Rights Reserved.
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

using System;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Extension methods for <see cref="CallSettings"/> which return new immutable instances
    /// based off an original and the modified setting.
    /// TODO(benwu): consider moving this to Gax as a set of extra immutable operations on other types.
    /// </summary>
    internal static class CallSettingsMutations
    {
        /// <summary>
        /// Sets the Timing of a new <see cref="CallSettings"/>, copying all other members from this instance.
        /// </summary>
        /// <param name="callSettings"></param>
        /// <param name="newTimeout"></param>
        /// <returns></returns>
        public static CallSettings WithCallExpiration(this CallSettings callSettings, Expiration newTimeout) =>
            callSettings.WithCallTiming(callSettings.Timing.WithExpiration(newTimeout));
    }

    /// <summary>
    /// Extension methods for <see cref="CallTiming"/> which return new immutable instances
    /// based off an original and the modified setting
    /// </summary>
    internal static class CallTimingMutations
    {
        /// <summary>
        /// Sets the total expiration of a new <see cref="CallTiming"/>, copying all other members from this instance.
        /// </summary>
        /// <param name="callTiming"></param>
        /// <param name="expiration"></param>
        /// <returns></returns>
        public static CallTiming WithExpiration(this CallTiming callTiming, Expiration expiration)
        {
            switch (callTiming.Type)
            {
                case CallTimingType.Retry:
                    return CallTiming.FromRetry(callTiming.Retry.WithTotalExpiration(expiration));
                case CallTimingType.Expiration:
                    return CallTiming.FromExpiration(expiration);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    /// <summary>
    /// Extension methods for <see cref="RetrySettings"/> which return new immutable instances
    /// based off an original and the modified setting
    /// </summary>
    internal static class RetrySettingMutations
    {
        /// <summary>
        /// Sets the total expiration of a new <see cref="RetrySettings"/>, copying all other members from this instance.
        /// </summary>
        /// <param name="retrySettings"></param>
        /// <param name="expiration"></param>
        /// <returns></returns>
        public static RetrySettings WithTotalExpiration(this RetrySettings retrySettings, Expiration expiration) =>
            new RetrySettings(
                retrySettings.RetryBackoff, retrySettings.TimeoutBackoff, expiration, retrySettings.RetryFilter,
                retrySettings.DelayJitter);
    }
}
