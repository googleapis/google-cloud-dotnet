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
using System.Data;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerParameterTests
    {
        public static IEnumerable<object[]> GetDbTypeConversions()
        {
            yield return new object[] { SpannerDbType.Bytes, DbType.Binary };
            yield return new object[] { SpannerDbType.Bool, DbType.Boolean };
            yield return new object[] { SpannerDbType.Date, DbType.Date };
            yield return new object[] { SpannerDbType.Timestamp, DbType.DateTime };
            yield return new object[] { SpannerDbType.Float64, DbType.Double };
            yield return new object[] { SpannerDbType.Int64, DbType.Int64 };
            yield return new object[] { SpannerDbType.Unspecified, DbType.Object };
            yield return new object[] { SpannerDbType.String, DbType.String };
        }

        [Theory]
        [MemberData(nameof(GetDbTypeConversions))]
        public void DbTypeMappgings(SpannerDbType spannerType, DbType adoType)
        {
            var parameter = new SpannerParameter { SpannerDbType = spannerType };
            Assert.Equal(adoType, parameter.DbType);

            parameter.ResetDbType();

            parameter.DbType = adoType;
            Assert.Equal(spannerType, parameter.SpannerDbType);
        }

        public static IEnumerable<object[]> GetDbTypeSizes()
        {
            yield return new object[] { SpannerDbType.Bytes, 0 };
            yield return new object[] { SpannerDbType.Bytes, 10 };
            yield return new object[] { SpannerDbType.Bytes, int.MaxValue };
            yield return new object[] { SpannerDbType.String, 0 };
            yield return new object[] { SpannerDbType.String, 10 };
            yield return new object[] { SpannerDbType.String, int.MaxValue };
        }

        [Theory]
        [MemberData(nameof(GetDbTypeSizes))]
        public void SizeTest(SpannerDbType spannerType, int size)
        {
            var parameter = new SpannerParameter { SpannerDbType = spannerType.WithSize(size) };
            Assert.Equal(parameter.Size, size);
            Assert.Equal(parameter.SpannerDbType.TypeCode, spannerType.TypeCode);

            parameter = new SpannerParameter
            {
                SpannerDbType = spannerType,
                Size = size
            };
            Assert.Equal(parameter.Size, size);
            Assert.Equal(parameter.SpannerDbType.TypeCode, spannerType.TypeCode);
        }

        public static IEnumerable<object[]> GetDbTypeSizesFailures()
        {
            yield return new object[] { SpannerDbType.Bytes, -1 };
            yield return new object[] { SpannerDbType.String, -1 };
            yield return new object[] { SpannerDbType.Bool, 0 };
            yield return new object[] { SpannerDbType.Date, 0 };
            yield return new object[] { SpannerDbType.Float64, 0 };
            yield return new object[] { SpannerDbType.Int64, 0 };
            yield return new object[] { SpannerDbType.Timestamp, 0 };
        }

        [Theory]
        [MemberData(nameof(GetDbTypeSizesFailures))]
        public void InvalidSizeTest(SpannerDbType spannerType, int size)
        {
            if (size == -1)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => new SpannerParameter {SpannerDbType = spannerType.WithSize(size)});
            }
            else
            {
                Assert.Throws<InvalidOperationException>(
                    () => new SpannerParameter { SpannerDbType = spannerType.WithSize(size) });
            }
        }
    }
}
