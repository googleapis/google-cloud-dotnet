// Copyright 2025 Google LLC
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

namespace Google.Cloud.PubSub.V1;

public abstract partial class SubscriberClient
{
    /// <summary>
    /// Modes available for subscriber shutdown.
    /// </summary>
    public enum ShutdownMode
    {
        /// <summary>
        /// Stops receiving new messages and continues processing all received messages.
        /// </summary>
        WaitForProcessing = 0,

        /// <summary>
        /// Stops receiving new messages and immediately Nacks all unhandled messages, releasing them for redelivery.
        /// </summary>
        NackImmediately = 1,
    }

    /// <summary>
    /// Settings available for subscriber shutdown.
    /// </summary>
    public sealed class ShutdownOptions
    {
        /// <summary>
        /// The <see cref="ShutdownMode"/> to use for shutdown. Defaults to <see cref="ShutdownMode.WaitForProcessing"/>.
        /// </summary>
        public ShutdownMode Mode { get; set; } = ShutdownMode.WaitForProcessing;

        /// <summary>
        /// The timeout for the shutdown process. If null, a default timeout based on the maximum extension duration is used.
        /// </summary>
        public TimeSpan? Timeout { get; set; }
    }
}
