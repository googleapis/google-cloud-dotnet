// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

// Note that this code file may be included directly in other projects
// either using the DNX build system with a dependency with "type": "build",
// or by copying and pasting. For the latter approach, developers should regularly
// review the original code at
// http://github.com/GoogleCloudPlatform/gcloud-dotnet/tree/master/Google.Common/src/Preconditions.cs
// for changes.

using System;

namespace Google.Common
{
    /// <summary>
    /// Preconditions for checking method arguments, state etc.
    /// </summary>
    internal static class Preconditions
    {
        // Possible future directions:
        // - Debug-only preconditions, as used extensively in Noda Time (for checking and self-documenting internal assumptions)
        // - Methods that return null or "something that will throw an exception" to be chained with string interpolation
        // - Methods accepting a string format and one or two arguments (to avoid any arrays being created at execution time,
        //   but still allow for string formatting)
        // - Conditional public/internal access, so that we can create a Google.Common assembly exposing all of this publicly, without
        //   duplication.

        /// <summary>
        /// Checks that the given argument (to the calling method) is non-null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="argument"></param>
        /// <param name="paramName">The name of the parameter in the calling method.</param>
        /// <exception cref="ArgumentNullException"><paramref name="argument"/> is null</exception>
        /// <returns><paramref name="argument"/> if it is not null</returns>
        internal static T CheckNotNull<T>(this T argument, string paramName) where T : class
        {
            if (argument == null)
            {
                throw new ArgumentNullException(paramName);
            }
            return argument;
        }

        /// <summary>
        /// Checks that the given argument value is valid.
        /// </summary>
        /// <remarks>
        /// Note that the upper bound (<paramref name="maxExclusive"/>) is inclusive,
        /// not exclusive. This is deliberate, to allow the specification of ranges which include
        /// <see cref="Int32.MaxValue"/>.
        /// </remarks>
        /// <param name="argument">The value of the argument passed to the calling method.</param>
        /// <param name="paramName">The name of the parameter in the calling method.</param>
        /// <param name="minInclusive">The smallest valid value.</param>
        /// <param name="maxInclusive">The largest valid value.</param>
        /// <exception cref="ArgumentOutOfRangeException">The argument was outside the specified range.</exception>
        internal static void CheckArgumentRange(int argument, string paramName, int minInclusive, int maxInclusive)
        {
            if (argument < minInclusive || argument > maxInclusive)
            {
                throw new ArgumentOutOfRangeException(paramName, $"Value {argument} should be in range [{minInclusive}, {maxInclusive}]");
            }
        }

        /// <summary>
        /// Checks that given condition is met, throwing an <see cref="InvalidOperationException"/> otherwise.
        /// </summary>
        /// <param name="condition">The condition to test.</param>
        /// <param name="message">The message to include in the exception, if generated. This should not
        /// use interpolation, as the interpolation would be performed regardless of whether or not an exception is thrown.</param>
        internal static void CheckState(bool condition, string message)
        {
            if (!condition)
            {
                throw new InvalidOperationException(message);
            }
        }

        /// <summary>
        /// Checks that given condition is met, throwing an <see cref="InvalidOperationException"/> otherwise.
        /// </summary>
        /// <param name="condition">The condition to test.</param>
        /// <param name="format">The format string to use to create the exception message if the
        /// condition is not met.</param>
        /// <param name="arg0">The argument to the format string.</param>
        internal static void CheckState<T>(bool condition, string format, T arg0)
        {
            if (!condition)
            {
                throw new InvalidOperationException(string.Format(format, arg0));
            }
        }

        /// <summary>
        /// Checks that given condition is met, throwing an <see cref="InvalidOperationException"/> otherwise.
        /// </summary>
        /// <param name="condition">The condition to test.</param>
        /// <param name="format">The format string to use to create the exception message if the
        /// condition is not met.</param>
        /// <param name="arg0">The first argument to the format string.</param>
        /// <param name="arg1">The second argument to the format string.</param>
        internal static void CheckState<T1, T2>(bool condition, string format, T1 arg0, T2 arg1)
        {
            if (!condition)
            {
                throw new InvalidOperationException(string.Format(format, arg0, arg1));
            }
        }
    }
}
