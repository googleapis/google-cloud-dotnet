// Copyright 2017, Google Inc. All rights reserved.
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

using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    internal static class ComparisonTester
    {
        internal static void AssertEqual<T>(T control, T[] equal, T[] unequal) where T : IEquatable<T>
        {
            foreach (var candidate in new[] { control }.Concat(equal)) // Check that control equals itself too
            {
                Assert.True(control.Equals(candidate));
                Assert.True(candidate.Equals(control));
                Assert.True(control.Equals((object) candidate));
                Assert.True(candidate.Equals((object) control));
                Assert.Equal(control.GetHashCode(), candidate.GetHashCode());
            }

            foreach (var candidate in unequal)
            {
                Assert.False(control.Equals(candidate));
                Assert.False(candidate.Equals(control));
                Assert.False(control.Equals((object) candidate));
                Assert.False(candidate.Equals((object) control));
                // While this isn't actually required, if it fails it would usually be due to a bug.
                Assert.NotEqual(control.GetHashCode(), candidate.GetHashCode());
            }

            Assert.False(control.Equals(null));

            if (default(T) == null)
            {
                Assert.False(control.Equals(default(T)));
            }
        }

        internal static void AssertEqualityOperators<T>(T control, T[] equal, T[] unequal)
        {
            var typeInfo = typeof(T).GetTypeInfo();
            var equalityMethodInfo = typeInfo.GetMethod("op_Equality", new[] { typeof(T), typeof(T) });
            var inequalityMethodInfo = typeInfo.GetMethod("op_Inequality", new[] { typeof(T), typeof(T) });

            Func<T, T, bool> equality = (lhs, rhs) => (bool) equalityMethodInfo.Invoke(null, new object[] { lhs, rhs });
            Func<T, T, bool> inequality = (lhs, rhs) => (bool) inequalityMethodInfo.Invoke(null, new object[] { lhs, rhs });

            foreach (var candidate in new[] { control }.Concat(equal)) // Check that control equals itself too
            {
                Assert.True(equality(control, candidate));
                Assert.True(equality(candidate, control));
                Assert.False(inequality(control, candidate));
                Assert.False(inequality(candidate, control));
            }

            foreach (var candidate in unequal)
            {
                Assert.False(equality(control, candidate));
                Assert.False(equality(candidate, control));
                Assert.True(inequality(control, candidate));
                Assert.True(inequality(candidate, control));
            }
        }

        internal static void AssertCompare<T>(
            T control, T[] less, T[] equal, T[] greater) where T : IComparable, IComparable<T>
        {
            foreach (var candidate in new[] { control }.Concat(equal)) // Check that control equals itself too
            {
                Assert.Equal(0, control.CompareTo(candidate));
                Assert.Equal(0, candidate.CompareTo(control));
                Assert.Equal(0, control.CompareTo((object) candidate));
                Assert.Equal(0, candidate.CompareTo((object) control));
            }

            foreach (var candidate in less)
            {
                Assert.True(control.CompareTo(candidate) > 0);
                Assert.True(candidate.CompareTo(control) < 0);
                Assert.True(control.CompareTo((object)candidate) > 0);
                Assert.True(candidate.CompareTo((object)control) < 0);
            }

            foreach (var candidate in greater)
            {
                Assert.True(control.CompareTo(candidate) < 0);
                Assert.True(candidate.CompareTo(control) > 0);
                Assert.True(control.CompareTo((object)candidate) < 0);
                Assert.True(candidate.CompareTo((object)control) > 0);
            }

            Assert.Throws<ArgumentException>(() => control.CompareTo(null));
        }

        internal static void AssertCompareOperators<T>(
            T control, T[] less, T[] equal, T[] greater)
        {
            var typeInfo = typeof(T).GetTypeInfo();
            var lessThanMethodInfo = typeInfo.GetMethod("op_LessThan", new[] { typeof(T), typeof(T) });
            var lessThanOrEqualMethodInfo = typeInfo.GetMethod("op_LessThanOrEqual", new[] { typeof(T), typeof(T) });
            var equalityMethodInfo = typeInfo.GetMethod("op_Equality", new[] { typeof(T), typeof(T) });
            var inequalityMethodInfo = typeInfo.GetMethod("op_Inequality", new[] { typeof(T), typeof(T) });
            var greaterThanOrEqualMethodInfo = typeInfo.GetMethod("op_GreaterThanOrEqual", new[] { typeof(T), typeof(T) });
            var greaterThanMethodInfo = typeInfo.GetMethod("op_GreaterThan", new[] { typeof(T), typeof(T) });

            Func<T, T, bool> lessThan = (lhs, rhs) => (bool)lessThanMethodInfo.Invoke(null, new object[] { lhs, rhs });
            Func<T, T, bool> lessThanOrEqual = (lhs, rhs) => (bool)lessThanOrEqualMethodInfo.Invoke(null, new object[] { lhs, rhs });
            Func<T, T, bool> equality = (lhs, rhs) => (bool) equalityMethodInfo.Invoke(null, new object[] { lhs, rhs });
            Func<T, T, bool> inequality = (lhs, rhs) => (bool) inequalityMethodInfo.Invoke(null, new object[] { lhs, rhs });
            Func<T, T, bool> greaterThanOrEqual = (lhs, rhs) => (bool)greaterThanOrEqualMethodInfo.Invoke(null, new object[] { lhs, rhs });
            Func<T, T, bool> greaterThan = (lhs, rhs) => (bool)greaterThanMethodInfo.Invoke(null, new object[] { lhs, rhs });

            foreach (var candidate in less)
            {
                Assert.False(lessThan(control, candidate));
                Assert.True(lessThan(candidate, control));
                Assert.False(lessThanOrEqual(control, candidate));
                Assert.True(lessThanOrEqual(candidate, control));
                Assert.False(equality(control, candidate));
                Assert.False(equality(candidate, control));
                Assert.True(inequality(control, candidate));
                Assert.True(inequality(candidate, control));
                Assert.True(greaterThanOrEqual(control, candidate));
                Assert.False(greaterThanOrEqual(candidate, control));
                Assert.True(greaterThan(control, candidate));
                Assert.False(greaterThan(candidate, control));
            }

            foreach (var candidate in new[] { control }.Concat(equal)) // Check that control equals itself too
            {
                Assert.False(lessThan(control, candidate));
                Assert.False(lessThan(candidate, control));
                Assert.True(lessThanOrEqual(control, candidate));
                Assert.True(lessThanOrEqual(candidate, control));
                Assert.True(equality(control, candidate));
                Assert.True(equality(candidate, control));
                Assert.False(inequality(control, candidate));
                Assert.False(inequality(candidate, control));
                Assert.True(greaterThanOrEqual(control, candidate));
                Assert.True(greaterThanOrEqual(candidate, control));
                Assert.False(greaterThan(control, candidate));
                Assert.False(greaterThan(candidate, control));
            }

            foreach (var candidate in greater)
            {
                Assert.True(lessThan(control, candidate));
                Assert.False(lessThan(candidate, control));
                Assert.True(lessThanOrEqual(control, candidate));
                Assert.False(lessThanOrEqual(candidate, control));
                Assert.False(equality(control, candidate));
                Assert.False(equality(candidate, control));
                Assert.True(inequality(control, candidate));
                Assert.True(inequality(candidate, control));
                Assert.False(greaterThanOrEqual(control, candidate));
                Assert.True(greaterThanOrEqual(candidate, control));
                Assert.False(greaterThan(control, candidate));
                Assert.True(greaterThan(candidate, control));
            }
        }
    }
}
