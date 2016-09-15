// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Protobuf.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.Vision.V1.Tests
{
    public class RepeatedFieldWrapperTest
    {
        [Fact]
        public void MembersPassThrough()
        {
            var field = new RepeatedField<int> { 1, 2, 3 };
            IReadOnlyList<int> list = new RepeatedFieldWrapper<int>(field);
            Assert.Equal(3, list.Count);
            Assert.Equal(2, list[1]);
            Assert.Equal(new[] { 1, 2, 3 }, list.ToArray()); // Use IEnumerable<T>.GetEnumerator
            Assert.Equal(new[] { 1, 2, 3 }, list.Cast<int>().ToArray()); // Use IEnumerable.GetEnumerator
        }
    }
}
