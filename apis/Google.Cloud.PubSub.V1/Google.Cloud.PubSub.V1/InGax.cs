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
    /// Additions to GaxPreconditions. Move to Gax.
    /// </summary>
    public static class GaxPreconditions2
    {
        /// <summary>
        /// Checks that the given argument value is valid.
        /// </summary>
        /// <remarks>
        /// Note that the upper bound (<paramref name="maxInclusive"/>) is inclusive,
        /// not exclusive. This is deliberate, to allow the specification of ranges which include
        /// <see cref="Int64.MaxValue"/>.
        /// </remarks>
        /// <param name="argument">The value of the argument passed to the calling method.</param>
        /// <param name="paramName">The name of the parameter in the calling method.</param>
        /// <param name="minInclusive">The smallest valid value.</param>
        /// <param name="maxInclusive">The largest valid value.</param>
        /// <returns><paramref name="argument"/> if it was in range</returns>
        /// <exception cref="ArgumentOutOfRangeException">The argument was outside the specified range.</exception>
        public static long CheckArgumentRange(long argument, string paramName, long minInclusive, long maxInclusive)
        {
            if (argument < minInclusive || argument > maxInclusive)
            {
                throw new ArgumentOutOfRangeException(
                    paramName,
                    $"Value {argument} should be in range [{minInclusive}, {maxInclusive}]");
            }
            return argument;
        }
    }

    /// <summary>
    /// Batching settings used to specify the conditions under which a batch of data
    /// will be further processed.
    /// </summary>
    public sealed class BatchingSettings
    {
        /// <summary>
        /// Creates a new instance.
        /// </summary>
        public BatchingSettings() { }

        internal BatchingSettings(BatchingSettings other)
        {
            ElementCountThreshold = other.ElementCountThreshold;
            RequestByteThreshold = other.RequestByteThreshold;
            DelayThreshold = other.DelayThreshold;
        }

        /// <summary>
        /// The element count above which further processing of a batch will occur.
        /// </summary>
        public long? ElementCountThreshold { get; set; }

        /// <summary>
        /// The byte count above which further processing of a batch will occur.
        /// </summary>
        public long? RequestByteThreshold { get; set; }

        /// <summary>
        /// The batch lifetime above which further processing of a batch will occur.
        /// </summary>
        public TimeSpan? DelayThreshold { get; set; }

        /// <summary>
        /// Return a clone of this object.
        /// </summary>
        /// <returns>A clone of this object.</returns>
        public BatchingSettings Clone() => new BatchingSettings(this);
    }
}
