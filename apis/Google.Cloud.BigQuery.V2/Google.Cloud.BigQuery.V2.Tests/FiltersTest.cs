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
using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class FiltersTest
    {
        [Fact]
        public void FromLabels()
        {
            Dictionary<string, string> labels = new Dictionary<string, string>
            {
                ["x"] = "",
                ["y"] = "yvalue"
            };

            // Due to ordering, this could have one of two results
            string option1 = "labels.x labels.y:yvalue";
            string option2 = "labels.y:yvalue labels.x";
            string actual = Filters.FromLabels(labels);
            // I can't see a cleaner way 
            Assert.Subset(new HashSet<string> { option1, option2 }, new HashSet<string> { actual });
        }

        [Theory]
        [InlineData("value", "labels.x:value")]
        [InlineData("", "labels.x")]
        [InlineData(null, "labels.x")]
        public void FromLabel(string value, string expectedFilter)
        {
            Assert.Equal(expectedFilter, Filters.FromLabel("x", value));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void InvalidName(string name) => Assert.ThrowsAny<ArgumentException>(() => Filters.FromLabel(name, "value"));
    }
}
