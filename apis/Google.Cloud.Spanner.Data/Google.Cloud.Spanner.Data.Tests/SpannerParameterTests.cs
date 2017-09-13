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
    }
}
