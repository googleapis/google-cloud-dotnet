// Copyright 2018, Google LLC
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

using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.Firestore.Tests
{
    internal static class ComparisonTester
    {
        internal static void AssertComparison<T>(T smaller, T larger, IComparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            Assert.True(comparer.Compare(smaller, larger) < 0,
                $"Compare({smaller}, {larger}) should be < 0");
            Assert.True(comparer.Compare(larger, smaller) > 0,
                $"Compare({larger}, {smaller}) should be > 0.");
            Assert.Equal(0, comparer.Compare(smaller, smaller));
            Assert.Equal(0, comparer.Compare(larger, larger));
        }
    }
}
