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

using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerDbTypeTests
    {
        public static IEnumerable<object[]> GetSpannerDbTypes()
        {
            yield return new object[]
                {SpannerDbType.ArrayOf(SpannerDbType.String), SpannerDbType.ArrayOf(SpannerDbType.String)};
            yield return new object[]
                {SpannerDbType.ArrayOf(SpannerDbType.Bytes), SpannerDbType.ArrayOf(SpannerDbType.Bytes)};
            yield return new object[]
            {
                SpannerDbType.StructOf(
                    new Dictionary<string, SpannerDbType>
                    {
                        {"StringValue", SpannerDbType.String},
                        {"StringValue2", SpannerDbType.String},
                        {"FloatValue", SpannerDbType.Float64},
                        {"BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool)},
                    }),
                SpannerDbType.StructOf(
                    new Dictionary<string, SpannerDbType>
                    {
                        {"StringValue", SpannerDbType.String},
                        {"StringValue2", SpannerDbType.String},
                        {"FloatValue", SpannerDbType.Float64},
                        {"BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool)},
                    })
            };
        }

        [Theory]
        [MemberData(nameof(GetSpannerDbTypes))]
        public void EqualsTest(SpannerDbType spannerType1, SpannerDbType spannerType2)
        {
            Assert.Equal(spannerType1.GetHashCode(), spannerType2.GetHashCode());
            Assert.True(spannerType1.Equals(spannerType2));
        }
    }
}
