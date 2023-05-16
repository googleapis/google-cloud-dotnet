// Copyright 2023 Google LLC
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

using Google.Api.Gax;
using System;

namespace Google.Cloud.PubSub.V1;

public abstract partial class SubscriberClient
{
    /// <summary>
    /// Settings for <see cref="SubscriberClient"/>.
    /// Defaults will be used for <c>null</c> properties.
    /// </summary>
    public sealed class Settings
    {
        /// <summary>
        /// Flow control settings.
        /// If <c>null</c>, uses flow control settings from <see cref="DefaultFlowControlSettings"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Flow control uses these settings for two purposes: fetching messages to process, and processing them.
        /// </para>
        /// <para>
        /// In terms of fetching messages, a single <see cref="SubscriberClient"/> creates multiple instances of
        /// <see cref="SubscriberServiceApiClient"/>, and each will observe the flow control settings independently.
        /// This means there may be more outstanding messages (or bytes) than expected; there is currently no way
        /// of limiting the total number or size of outstanding messages fetched across all data streams for a single
        /// <see cref="SubscriberClient"/>.
        /// </para>
        /// <para>
        /// Separately, the number of messages being processed concurrently is limited by these settings, at
        /// the level of the whole <see cref="SubscriberClient"/>.
        /// </para>
        /// <para>
        /// For example, if <see cref="FlowControlSettings.MaxOutstandingElementCount"/> is set to 10, then a single
        /// <see cref="SubscriberClient"/> using 4 instances of <see cref="SubscriberServiceApiClient"/> will have up
        /// to 40 outstanding messages to process, but will only process at most 10 of them concurrently.
        /// </para>
        /// </remarks>
        public FlowControlSettings FlowControlSettings { get; set; }

        /// <summary>
        /// If set to true, disables enforcing flow control settings at the Cloud PubSub server
        /// and uses the less accurate method of only enforcing flow control at the client side.
        /// </summary>
        public bool UseLegacyFlowControl { get; set; } = false;

        /// <summary>
        /// The lease time before which a message must either be ACKed
        /// or have its lease extended. This is truncated to the nearest second.
        /// If <c>null</c>, uses the default of <see cref="DefaultAckDeadline"/>.
        /// </summary>
        public TimeSpan? AckDeadline { get; set; }

        /// <summary>
        /// Duration before <see cref="AckDeadline"/> at which the message ACK deadline
        /// is automatically extended.
        /// If <c>null</c>, uses the default of <see cref="DefaultAckExtensionWindow"/>.
        /// </summary>
        public TimeSpan? AckExtensionWindow { get; set; }

        /// <summary>
        /// Maximum duration for which a message ACK deadline will be extended.
        /// If <c>null</c>, uses the default of <see cref="DefaultMaxTotalAckExtension"/>.
        /// </summary>
        public TimeSpan? MaxTotalAckExtension { get; set; }

        /// <summary>
        /// The <see cref="IScheduler"/> used to schedule delays.
        /// If <c>null</c>, the default <see cref="SystemScheduler"/> is used.
        /// This is usually only used for testing.
        /// </summary>
        public IScheduler Scheduler { get; set; }

        /// <summary>
        /// The <see cref="IClock"/> used for timeouts and retries.
        /// If <c>null</c>, the default <see cref="SystemClock"/> is used.
        /// This is usually only used for testing.
        /// </summary>
        /// <remarks>
        /// This is used only in exactly once delivery flow as we need to retry temporary failures.
        /// </remarks>
        public IClock Clock { get; set; }

        /// <summary>
        /// Represents a time interval to wait for the <see cref="SubscriberClient"/> to acknowledge the handled messages
        /// after the <see cref="DisposeAsync"/> method has been called. If this time interval expires, the clean stop
        /// process will be aborted, and some handled messages may remain un-acknowledged.
        /// If <c>null</c>, defaults to <see cref="DefaultDisposeTimeout"/>.
        /// </summary>
        public TimeSpan? DisposeTimeout { get; set; }

        /// <summary>
        /// Create a new instance.
        /// </summary>
        public Settings() { }

        internal Settings(Settings other)
        {
            FlowControlSettings = other.FlowControlSettings;
            UseLegacyFlowControl = other.UseLegacyFlowControl;
            AckDeadline = other.AckDeadline;
            AckExtensionWindow = other.AckExtensionWindow;
            Scheduler = other.Scheduler;
            Clock = other.Clock;
            MaxTotalAckExtension = other.MaxTotalAckExtension;
            DisposeTimeout = other.DisposeTimeout;
        }

        internal void Validate()
        {
            GaxPreconditions.CheckArgumentRange(AckDeadline, nameof(AckDeadline), MinimumAckDeadline, MaximumAckDeadline);
            var maxAckExtension = TimeSpan.FromTicks((AckDeadline ?? DefaultAckDeadline).Ticks / 2);
            GaxPreconditions.CheckArgumentRange(AckExtensionWindow, nameof(AckExtensionWindow), MinimumAckExtensionWindow, maxAckExtension);
            if (MaxTotalAckExtension is TimeSpan maxTotalAckExtension)
            {
                GaxPreconditions.CheckNonNegativeDelay(maxTotalAckExtension, nameof(MaxTotalAckExtension));
            }
        }

        /// <summary>
        /// Create a clone of this object.
        /// </summary>
        /// <returns>A clone of this object.</returns>
        public Settings Clone() => new Settings(this);
    }
}
