/*
 * Copyright 2017 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */
 
 using System;

namespace Google.Api.Gax
{
    /// <summary>
    /// Batching settings used to specify the conditions under which a batch of data
    /// will be further processed.
    /// </summary>
    public sealed class BatchingSettings
    {
        /// <summary>
        /// Creates a new instance with the specified settings.
        /// </summary>
        /// <param name="elementCountThreshold">The element count above which further processing of a batch will occur.</param>
        /// <param name="byteCountThreshold">The byte count above which further processing of a batch will occur.</param>
        /// <param name="delayThreshold">The batch lifetime above which further processing of a batch will occur.</param>
        public BatchingSettings(long? elementCountThreshold, long? byteCountThreshold, TimeSpan? delayThreshold)
        {
            ElementCountThreshold = GaxPreconditions.CheckNonNegative(elementCountThreshold, nameof(elementCountThreshold));
            this.ByteCountThreshold = GaxPreconditions.CheckNonNegative(byteCountThreshold, nameof(byteCountThreshold));
            GaxPreconditions.CheckNonNegative(delayThreshold?.TotalSeconds, nameof(delayThreshold));
            DelayThreshold = delayThreshold;
        }

        /// <summary>
        /// The element count above which further processing of a batch will occur.
        /// </summary>
        public long? ElementCountThreshold { get; }

        /// <summary>
        /// The byte count above which further processing of a batch will occur.
        /// </summary>
        public long? ByteCountThreshold { get; }

        /// <summary>
        /// The batch lifetime above which further processing of a batch will occur.
        /// </summary>
        public TimeSpan? DelayThreshold { get; }
    }

    /// <summary>
    /// Settings used to control data flow.
    /// </summary>
    public sealed class FlowControlSettings
    {
        /// <summary>
        /// Creates a new instance with the specified settings.
        /// </summary>
        /// <param name="maxOutstandingElementCount">The maximum number of elements that can be outstanding before data flow is restricted, or
        /// null if there is no specified limit.</param>
        /// <param name="maxOutstandingByteCount">The maximum number of bytes that can be outstanding before data flow is restricted, or
        /// null if there is no specified limit.</param>
        public FlowControlSettings(long? maxOutstandingElementCount, long? maxOutstandingByteCount)
        {
            MaxOutstandingElementCount = GaxPreconditions.CheckNonNegative(maxOutstandingElementCount, nameof(maxOutstandingElementCount));
            MaxOutstandingByteCount = GaxPreconditions.CheckNonNegative(maxOutstandingByteCount, nameof(maxOutstandingByteCount));
        }

        /// <summary>
        /// The maximum number of elements that can be outstanding before data flow is restricted, or
        /// null if there is no specified limit.
        /// </summary>
        public long? MaxOutstandingElementCount { get; }

        /// <summary>
        /// The maximum number of bytes that can be outstanding before data flow is restricted, or
        /// null if there is no specified limit.
        /// </summary>
        public long? MaxOutstandingByteCount { get; }
    }
}
