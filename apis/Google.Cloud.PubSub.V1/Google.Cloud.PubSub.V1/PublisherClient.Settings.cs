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

public abstract partial class PublisherClient
{
    /// <summary>
    /// Settings for the <see cref="PublisherClient"/>.
    /// </summary>
    public sealed class Settings
    {
        /// <summary>
        /// <see cref="BatchingSettings"/> that control how messages are batched when sending.
        /// If <c>null</c>, defaults to <see cref="DefaultBatchingSettings"/>.
        /// </summary>
        public BatchingSettings BatchingSettings { get; set; }

        /// <summary>
        /// The <see cref="IScheduler"/> to use.
        /// If <c>null</c>, defaults to <see cref="SystemScheduler"/>. Usually only useful for testing.
        /// </summary>
        public IScheduler Scheduler { get; set; }

        /// <summary>
        /// Enable message ordering. It is invalid to set <see cref="PubsubMessage.OrderingKey"/> in a message
        /// if this has not been set to <c>true</c>.
        /// </summary>
        public bool EnableMessageOrdering { get; set; }

        /// <summary>
        /// Represents a time interval to wait for the <see cref="PublisherClient"/> to send any pending messages
        /// after the <see cref="DisposeAsync"/> method has been called. If this time interval expires, the
        /// clean shutdown process will be aborted, and there may be locally queued messages that remain unsent.
        /// If <c>null</c>, defaults to <see cref="DefaultDisposeTimeout"/>.
        /// </summary>
        public TimeSpan? DisposeTimeout { get; set; }

        /// <summary>
        /// Enables publish message compression. If set to <c>true</c>, messages will be compressed before being sent to the server
        /// by the <see cref="PublisherClient"/>.
        /// </summary>
        public bool EnableCompression { get; set; }

        /// <summary>
        /// Specifies the threshold for the number of bytes in a message batch before compression is applied.
        /// This property comes into play only when <see cref="EnableCompression"/> is set to <c>true</c>.
        /// If the number of bytes in a batch is less than this value, compression will not be applied even
        /// if <see cref="EnableCompression"/> is <c>true</c>.
        /// If <c>null</c>, defaults to <see cref="DefaultCompressionBytesThreshold"/>.
        /// </summary>
        public long? CompressionBytesThreshold { get; set; }

        /// <summary>
        /// Create a new instance.
        /// </summary>
        public Settings() { }

        internal Settings(Settings other)
        {
            BatchingSettings = other.BatchingSettings;
            Scheduler = other.Scheduler;
            EnableMessageOrdering = other.EnableMessageOrdering;
            DisposeTimeout = other.DisposeTimeout;
            EnableCompression = other.EnableCompression;
            CompressionBytesThreshold = other.CompressionBytesThreshold;
        }

        internal void Validate()
        {
            if (BatchingSettings != null)
            {
                GaxPreconditions.CheckArgumentRange(BatchingSettings.ElementCountThreshold,
                    $"{nameof(BatchingSettings)}.{nameof(BatchingSettings.ElementCountThreshold)}", 1, ApiMaxBatchingSettings.ElementCountThreshold.Value);
                GaxPreconditions.CheckArgumentRange(BatchingSettings.ByteCountThreshold,
                    $"{nameof(BatchingSettings)}.{nameof(BatchingSettings.ByteCountThreshold)}", 1, ApiMaxBatchingSettings.ByteCountThreshold.Value);
                GaxPreconditions.CheckArgument((BatchingSettings.DelayThreshold ?? TimeSpan.FromSeconds(1)) > TimeSpan.Zero,
                    $"{nameof(BatchingSettings)}.{nameof(BatchingSettings.DelayThreshold)}", "Must be positive");
            }
        }

        /// <summary>
        /// Create a clone of this object.
        /// </summary>
        /// <returns>A clone of this object.</returns>
        public Settings Clone() => new Settings(this);
    }
}
