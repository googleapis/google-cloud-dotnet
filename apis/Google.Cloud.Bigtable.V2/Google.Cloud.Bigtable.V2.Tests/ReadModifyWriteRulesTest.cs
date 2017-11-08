// Copyright 2017 Google Inc. All rights reserved.
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
using System.Text;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class ReadModifyWriteRulesTest
    {
        public static IEnumerable<object[]> InvalidFamilyNames { get; } = new List<object[]>
        {
            new [] { default(string) },
            new [] { "" },
            new [] { "abc*" },
            new [] { "abc " },
            new [] { "a=b" }
        };

        [Fact]
        public void AppendRule()
        {
            var rule = ReadModifyWriteRules.Append("cf", "c1", "abc");
            Assert.Equal("cf", rule.FamilyName);
            Assert.Equal("c1", rule.ColumnQualifier.ToStringUtf8());
            Assert.Equal("abc", rule.AppendValue.ToStringUtf8());
        }

        [Theory]
        [MemberData(nameof(InvalidFamilyNames))]
        public void AppendRule_Validations(string familyName)
        {
            Assert.Throws<ArgumentException>(
                () => ReadModifyWriteRules.Append(familyName, "c1", "abc"));
        }

        [Fact]
        public void IncrementRule()
        {
            var rule = ReadModifyWriteRules.Increment("cf", "c1", 123);
            Assert.Equal("cf", rule.FamilyName);
            Assert.Equal("c1", rule.ColumnQualifier.ToStringUtf8());
            Assert.Equal(123, rule.IncrementAmount);
        }

        [Theory]
        [MemberData(nameof(InvalidFamilyNames))]
        public void IncrementRule_Validations(string familyName)
        {
            Assert.Throws<ArgumentException>(
                () => ReadModifyWriteRules.Increment(familyName, "c1", 123));
        }
    }
}
