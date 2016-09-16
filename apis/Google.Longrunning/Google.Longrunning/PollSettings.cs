// Copyright 2016 Google Inc. All Rights Reserved.
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
using System;

namespace Google.Longrunning
{
    // TODO: Should this actually be in GAX? Could be useful for other situations,
    // although potentially those situations *should* use LRO...

    // TODO: Rename to RepeatedPollSettings or something similar?

    /// <summary>
    /// Settings controlling repeated polling until an operation completes.
    /// </summary>
    public class PollSettings
    {
        /// <summary>
        /// Convenience property returning a <see cref="PollSettings"/> with no expiration, no call settings override, and
        /// a 10 second delay between RPCs.
        /// </summary>
        public static PollSettings Default { get; } = new PollSettings(Expiration.None, TimeSpan.FromSeconds(10));

        /// <summary>
        /// Settings to override the <see cref="OperationsClient"/> call settings
        /// when polling, if any.
        /// </summary>
        public CallSettings CallSettings { get; }

        /// <summary>
        /// How long to wait before giving up. This is never null, but may be <see cref="Expiration.None"/>
        /// to indicate that the call should never give up unless the RPCs fail.
        /// </summary>
        public Expiration Expiration { get; }

        /// <summary>
        /// The delay between RPC calls when fetching the operation status. This is never negative. There is no exponential
        /// backoff between calls; the same delay is used for each call.
        /// </summary>
        /// <remarks>
        /// This is the delay between the a successful RPC response being received
        /// and the next RPC request being sent.
        /// </remarks>
        public TimeSpan Delay { get; }

        /// <summary>
        /// Creates poll settings from the given expiration, delay and call settings.
        /// </summary>
        /// <param name="expiration">The expiration to use in order to know when to stop polling. Must not be null.</param>
        /// <param name="delay">The delay between RPC calls. Must be non-negative.</param>
        /// <param name="callSettings">The call settings to override the defaults for the call.
        /// May be null, in which case no settings are overridden.</param>
        public PollSettings(Expiration expiration, TimeSpan delay, CallSettings callSettings = null)
        {
            Expiration = expiration;
            Delay = delay;
            CallSettings = callSettings;
        }

        // TODO: remove this method and make ExpirationExtensions.CalculateDeadline public in GAX.
        internal DateTime? CalculateDeadline(IClock clock)
        {
            if (Expiration == null)
            {
                return null;
            }
            switch (Expiration.Type)
            {
                case ExpirationType.None:
                    return null;
                case ExpirationType.Timeout:
                    return clock.GetCurrentDateTimeUtc() + Expiration.Timeout.Value;
                case ExpirationType.Deadline:
                    return Expiration.Deadline.Value;
                default:
                    throw new InvalidOperationException("Invalid expiration");
            }
        }
    }
}
