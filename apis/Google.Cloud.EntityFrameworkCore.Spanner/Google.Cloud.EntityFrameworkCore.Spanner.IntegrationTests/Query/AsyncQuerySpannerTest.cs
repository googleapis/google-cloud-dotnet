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

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class AsyncQuerySpannerTest : AsyncQueryTestBase<NorthwindQuerySpannerFixture>
    {
        public AsyncQuerySpannerTest(NorthwindQuerySpannerFixture fixture)
            : base(fixture)
        {
        }

        [Fact(Skip = "Precision Issue")]
        public override Task Average_with_arg() => null;

        [Fact(Skip = "Precision Issue")]
        public override Task Average_with_arg_expression() => null;

        [Fact(Skip = "Precision Issue")]
        public override Task Average_with_binary_expression() => null;

        [Fact(Skip = "Precision Issue")]
        public override Task Average_with_no_arg() => null;

        [Fact(Skip = "Uknown ")]
        public override Task Contains_with_local_collection_sql_injection() => null;

        [Fact(Skip = "Test skipped in EFCore (verify for Spanner)")]
        public override Task Projection_when_arithmetic_expressions() => null;

        [Fact(Skip = "Test skipped in EFCore (verify for Spanner)")]
        public override Task Projection_when_arithmetic_mixed() => null;

        [Fact(Skip = "Test skipped in EFCore (verify for Spanner)")]
        public override Task Projection_when_arithmetic_mixed_subqueries() => null;

        [Fact(Skip = "Uknown ")]
        public override Task Where_subquery_on_collection() => null;
    }
}