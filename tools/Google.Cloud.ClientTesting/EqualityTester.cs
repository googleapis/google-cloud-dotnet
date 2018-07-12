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

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Helpers for testing types that implement equality methods/operators.
    /// </summary>
    public static class EqualityTester
    {
        public static void AssertEqual<T>(T control, T[] equal, T[] unequal) where T : IEquatable<T>
        {
            for (int i = -1; i < equal.Length; i++)
            {
                var candidate = i == -1 ? control : equal[i];
                string message = i == -1 ? "Control not equal to itself" : $"Equal item {i} unexpected unequal";
                Assert.True(control.Equals(candidate), message);
                Assert.True(candidate.Equals(control), message);
                Assert.True(control.Equals((object) candidate), message);
                Assert.True(candidate.Equals((object) control), message);
                Assert.Equal(control.GetHashCode(), candidate.GetHashCode());
            }

            for (int i = 0; i < unequal.Length; i++)
            {
                var candidate = unequal[i];
                string message = $"Unequal item {i} unexpected equal";
                Assert.False(control.Equals(candidate), message);
                Assert.False(candidate.Equals(control), message);
                Assert.False(control.Equals((object) candidate), message);
                Assert.False(candidate.Equals((object) control), message);
                // While this isn't actually required, if it fails it would usually be due to a bug.
                Assert.NotEqual(control.GetHashCode(), candidate.GetHashCode());
            }

            Assert.False(control.Equals(null));

            if (default(T) == null)
            {
                Assert.False(control.Equals(default(T)));
            }
        }

        public static void AssertEqualityOperators<T>(T control, T[] equal, T[] unequal)
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
    }
}
