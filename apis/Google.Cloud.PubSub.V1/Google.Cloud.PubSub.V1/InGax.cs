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

        /// <summary>
        /// Checks that the given argument value is valid, if not <c>null</c>.
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
        /// <returns><paramref name="argument"/> if it was in range, or <c>null</c>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The argument was outside the specified range.</exception>
        public static long? CheckArgumentRange(long? argument, string paramName, long minInclusive, long maxInclusive) =>
            argument.HasValue ? CheckArgumentRange(argument.Value, paramName, minInclusive, maxInclusive) : argument;

        /// <summary>
        /// Check that the given argument is non-negative.
        /// </summary>
        /// <param name="argument">The value of the argument passed to the calling method.</param>
        /// <param name="paramName">The name of the parameter in the calling method.</param>
        /// <returns><paramref name="argument"/> if it was non-negative.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The argument was negative.</exception>
        public static long CheckNonNegative(long argument, string paramName)
        {
            if (argument < 0)
            {
                throw new ArgumentOutOfRangeException(paramName, $"Value {argument} should be non-negative");
            }
            return argument;
        }

        /// <summary>
        /// Check that the given argument is non-negative, if not <c>null</c>.
        /// </summary>
        /// <param name="argument">The value of the argument passed to the calling method.</param>
        /// <param name="paramName">The name of the parameter in the calling method.</param>
        /// <returns><paramref name="argument"/> if it was non-negative, or <c>null</c>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The argument was negative.</exception>
        public static long? CheckNonNegative(long? argument, string paramName) =>
            argument.HasValue ? CheckNonNegative(argument.Value, paramName) : argument;

        /// <summary>
        /// Check that the given argument is non-negative.
        /// </summary>
        /// <param name="argument">The value of the argument passed to the calling method.</param>
        /// <param name="paramName">The name of the parameter in the calling method.</param>
        /// <returns><paramref name="argument"/> if it was non-negative.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The argument was negative.</exception>
        public static double CheckNonNegative(double argument, string paramName)
        {
            if (argument < 0)
            {
                throw new ArgumentOutOfRangeException(paramName, $"Value {argument} should be non-negative");
            }
            return argument;
        }

        /// <summary>
        /// Check that the given argument is non-negative, if not <c>null</c>.
        /// </summary>
        /// <param name="argument">The value of the argument passed to the calling method.</param>
        /// <param name="paramName">The name of the parameter in the calling method.</param>
        /// <returns><paramref name="argument"/> if it was non-negative, or <c>null</c>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The argument was negative.</exception>
        public static double? CheckNonNegative(double? argument, string paramName) =>
            argument.HasValue ? CheckNonNegative(argument.Value, paramName) : argument;
    }

    /// <summary>
    /// Batching settings used to specify the conditions under which a batch of data
    /// will be further processed.
    /// </summary>
    public sealed class BatchingSettings
    {
        /// <summary>
        /// Create a new instance with the specified settings.
        /// </summary>
        /// <param name="elementCountThreshold">The element count above which further processing of a batch will occur.</param>
        /// <param name="requestByteThreshold">The byte count above which further processing of a batch will occur.</param>
        /// <param name="delayThreshold">The batch lifetime above which further processing of a batch will occur.</param>
        public BatchingSettings(long? elementCountThreshold, long? requestByteThreshold, TimeSpan? delayThreshold)
        {
            ElementCountThreshold = GaxPreconditions2.CheckNonNegative(elementCountThreshold, nameof(elementCountThreshold));
            RequestByteThreshold = GaxPreconditions2.CheckNonNegative(requestByteThreshold, nameof(requestByteThreshold));
            GaxPreconditions2.CheckNonNegative(delayThreshold?.TotalSeconds, nameof(delayThreshold));
            DelayThreshold = delayThreshold;
        }

        /// <summary>
        /// The element count above which further processing of a batch will occur.
        /// </summary>
        public long? ElementCountThreshold { get; }

        /// <summary>
        /// The byte count above which further processing of a batch will occur.
        /// </summary>
        public long? RequestByteThreshold { get; }

        /// <summary>
        /// The batch lifetime above which further processing of a batch will occur.
        /// </summary>
        public TimeSpan? DelayThreshold { get; }
    }
}
