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

using Xunit;

namespace Google.Cloud.Firestore.Tests
{
    public class PathComparerTest
    {
        [Theory]
        [InlineData("", "x")]
        [InlineData("a/b", "a/c")]
        [InlineData("a/b", "a/bx")]
        [InlineData("a/b", "b/a")]
        [InlineData("a/b", "a+/a")] // Prevents simple ordinal comparison: + comes before /
        [InlineData("a/b", "a/b/c")]
        public void CompareTo(string smaller, string larger) =>
            ComparisonTester.AssertComparison(smaller, larger, PathComparer.Instance);
    }
}
