// Copyright 2017 Google Inc. All Rights Reserved.
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
using Xunit;

namespace Google.Cloud.Storage.V1.Tests
{
    public class ModifyBucketLabelsOptionsTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(int.MaxValue)]
        [InlineData(null)]
        public void Retries_Valid(int? retries)
        {
            var options = new ModifyBucketLabelsOptions { Retries = retries };
            Assert.Equal(retries, options.Retries);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        public void Retries_Invalid(int? retries)
        {
            var options = new ModifyBucketLabelsOptions();
            Assert.Throws<ArgumentOutOfRangeException>(() => options.Retries = retries);
        }
    }
}
