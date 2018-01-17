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

using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    //TODO: validate generated DDL statements.
    public class SpannerMigrationSqlGeneratorTest : MigrationSqlGeneratorTestBase
    {
        public SpannerMigrationSqlGeneratorTest()
            : base(SpannerTestHelpers.Instance)
        {
        }

        [Fact(Skip = "NYI")]
        public override void AlterColumnOperation()
        {
            base.AlterColumnOperation();
        }

        [Fact(Skip = "NYI")]
        public override void AlterColumnOperation_without_column_type()
        {
            base.AlterColumnOperation_without_column_type();
        }

        [Fact(Skip = "NYI")]
        public override void DropIndexOperation()
        {
            base.DropIndexOperation();
        }

        [Fact(Skip = "NYI")]
        public override void RenameTableOperation_within_schema()
        {
            base.RenameTableOperation_within_schema();
        }
    }
}