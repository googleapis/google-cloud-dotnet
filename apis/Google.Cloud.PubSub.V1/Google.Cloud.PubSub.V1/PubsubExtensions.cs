// Copyright 2020 Google LLC
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

using System.Globalization;

namespace Google.Cloud.PubSub.V1
{
    /// <summary>
    /// Extensions to pubsub messages.
    /// </summary>
    public static class PubsubExtensions
    {
        /// <summary>
        /// Get the delivery attempt of this message, if it comes from a subscription
        /// that has dead-letter queues enabled.
        /// </summary>
        /// <remarks>
        /// Delivery attempt counter is 1 + (the sum of number of NACKs and number of
        /// ack_deadline exceeds) for this message.
        /// </remarks>
        /// <param name="msg"></param>
        /// <returns>The delivery attempt; or <c>null</c> if the subscription does not
        /// have dead-letter queues enabled.</returns>
        public static int? GetDeliveryAttempt(this PubsubMessage msg) =>
            msg.Attributes.TryGetValue(SubscriberClientImpl.DeliveryAttemptAttrKey, out var valueStr) ?
                int.TryParse(valueStr, NumberStyles.Integer, CultureInfo.InvariantCulture, out var valueInt) ? (int?)valueInt : null : null;
    }
}
