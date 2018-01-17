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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Utilities;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class TransactionSpannerTest : TransactionTestBase<SpannerTestStore, TransactionSpannerFixture>
    {
        public TransactionSpannerTest(TransactionSpannerFixture fixture)
            : base(fixture)
        {
        }

        protected override bool SnapshotSupported => false;

        protected override bool DirtyReadsOccur => false;

        [InlineData(true)]
        [InlineData(false)]
        [Theory(Skip = "unknown")]
        public override Task QueryAsync_uses_explicit_transaction(bool autoTransaction) => base
            .QueryAsync_uses_explicit_transaction(autoTransaction);

        [InlineData(true)]
        [InlineData(false)]
        [Theory(Skip = "unknown")]
        public override void Query_uses_explicit_transaction(bool autoTransaction)
        {
            base.Query_uses_explicit_transaction(autoTransaction);
        }

        [InlineData(true)]
        [InlineData(false)]
        [Theory(Skip = "unknown")]
        public override void
            SaveChanges_uses_explicit_transaction_and_does_not_rollback_on_failure(bool autoTransaction)
        {
            base.SaveChanges_uses_explicit_transaction_and_does_not_rollback_on_failure(autoTransaction);
        }

        [InlineData(true)]
        [InlineData(false)]
        [Theory(Skip = "unknown")]
        public override Task
            SaveChangesAsync_uses_explicit_transaction_and_does_not_rollback_on_failure(bool autoTransaction) => base
            .SaveChangesAsync_uses_explicit_transaction_and_does_not_rollback_on_failure(autoTransaction);

        [Fact(Skip = "unknown")]
        public override void SaveChanges_can_be_used_with_no_transaction()
        {
            base.SaveChanges_can_be_used_with_no_transaction();
        }

        [Fact(Skip = "unknown")]
        public override void SaveChanges_implicitly_starts_transaction()
        {
            base.SaveChanges_implicitly_starts_transaction();
        }

        [Fact(Skip = "unknown")]
        public override Task SaveChangesAsync_can_be_used_with_no_transaction() => base
            .SaveChangesAsync_can_be_used_with_no_transaction();

        [Fact(Skip = "unknown")]
        public override Task SaveChangesAsync_implicitly_starts_transaction() => base
            .SaveChangesAsync_implicitly_starts_transaction();
    }
}