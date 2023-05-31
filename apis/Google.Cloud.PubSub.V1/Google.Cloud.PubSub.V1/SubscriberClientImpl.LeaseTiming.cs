// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using System;

namespace Google.Cloud.PubSub.V1;

public partial class SubscriberClientImpl
{
    /// <summary>
    /// Helper class to keep track of lease timing values. Each <see cref="SingleChannel"/>
    /// has references to two instances of this: one for exactly-once delivery, and once for
    /// normal delivery.
    /// </summary>
    private sealed class LeaseTiming
    {
        /// <summary>
        /// Delay between message lease auto-extends.
        /// </summary>
        internal TimeSpan AutoExtendDelay { get; }

        /// <summary>
        /// Value to use as new deadline when lease auto-extends.
        /// </summary>
        internal int AckDeadlineSeconds { get; }

        /// <summary>
        /// Throttle pull if items in the extend queue are older than this.
        /// </summary>
        internal TimeSpan ExtendQueueThrottleInterval { get; }

        internal LeaseTiming(TimeSpan ackDeadline, TimeSpan ackExtensionWindow)
        {
            // Truncate the ack deadline to a whole number of seconds, just for simplicity with later calculations.
            AckDeadlineSeconds = (int) ackDeadline.TotalSeconds;
            ackDeadline = TimeSpan.FromSeconds(AckDeadlineSeconds);

            // The delay is calculated as AckDeadline - AckWindow, but with a hard-coded minimum.
            var delay = ackDeadline - ackExtensionWindow;
            // Clamp the delay to the MinimumLeaseExtensionDelay value if delay is less than that.
            AutoExtendDelay = TimeSpan.FromTicks(Math.Max(delay.Ticks, MinimumLeaseExtensionDelay.Ticks));

            // The throttle is normally half the ack extension window, but is expressed in terms of the computed
            // AutoExtendDelay to take account of any clamping to MinimumLeaseExtensionDelay.
            // Annoyingly, the TimeSpan division operator isn't available in .NET Framework.
            ExtendQueueThrottleInterval = TimeSpan.FromTicks((ackDeadline - AutoExtendDelay).Ticks / 2);
        }
    }
}
