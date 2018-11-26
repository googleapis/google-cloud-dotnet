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

using Google.Cloud.Firestore.Converters;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;
using Xunit;
using BclType = System.Type;

namespace Google.Cloud.Firestore.Tests
{
    public class ConverterCacheTest
    {
        [Theory]
        [InlineData(typeof(Dictionary<string, int>), typeof(int))]
        [InlineData(typeof(IDictionary<string, int>), typeof(int))]
        [InlineData(typeof(Dictionary<string, string>), typeof(string))]
        [InlineData(typeof(ConcurrentDictionary<string, string>), typeof(string))]
        [InlineData(typeof(ExpandoObject), typeof(object))]
        [InlineData(typeof(Dictionary<object, int>), null)]
        [InlineData(typeof(Dictionary<,>), null)]
        [InlineData(typeof(IDictionary<,>), null)]
        [InlineData(typeof(int), null)]
        [InlineData(typeof(string), null)]
        [InlineData(typeof(List<string>), null)]
        public void TryGetStringDictionaryValueType(BclType input, BclType expectedElementType)
        {
            var actual = ConverterCache.TryGetStringDictionaryValueType(input, out var actualElementType);
            Assert.Equal(expectedElementType != null, actual);
            Assert.Equal(expectedElementType, actualElementType);
        }
    }
}
