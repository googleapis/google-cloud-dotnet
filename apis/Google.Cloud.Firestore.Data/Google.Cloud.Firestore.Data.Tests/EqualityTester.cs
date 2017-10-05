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
using Xunit;

namespace Google.Cloud.Firestore.Data.Tests
{
    internal static class EqualityTester
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
    }
}
