// Copyright 2018 Google LLC
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

using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerStructTests
    {
        [Fact]
        public void NullNameCoalescing()
        {
            var value = new SpannerStruct
            {
                { null, SpannerDbType.String, "foo" },
                new SpannerStruct.Field(null, SpannerDbType.String, "bar")
            };
            Assert.Equal("", value[0].Name);
            Assert.Equal("", value[1].Name);
        }

        [Fact]
        public void NullProtection()
        {
            Assert.Throws<ArgumentNullException>(() => new SpannerStruct.Field("name", null, "value"));
            var value = new SpannerStruct();
            Assert.Throws<ArgumentNullException>(() => value.Add("name", null, "value"));
            Assert.Throws<ArgumentNullException>(() => value.Add(null));
        }

        [Fact]
        public void InterfaceAccess()
        {
            var value = new SpannerStruct
            {
                { "f", SpannerDbType.String, null },
                { "g", SpannerDbType.Int64, 100L },
            };
            var fields = value.ToList();
            Assert.Same(fields[0], value[0]);
            Assert.Same(fields[1], value[1]);
            Assert.Equal(2, fields.Count);
            Assert.Throws<ArgumentOutOfRangeException>(() => fields[2]);
        }

        [Fact]
        public void SimpleProperties()
        {
            var value = new SpannerStruct
            {
                { "f", SpannerDbType.String, "value" }
            };
            var field = value[0];
            Assert.Equal("f", field.Name);
            Assert.Equal(SpannerDbType.String, field.Type);
            Assert.Equal("value", field.Value);
        }
    }
}
