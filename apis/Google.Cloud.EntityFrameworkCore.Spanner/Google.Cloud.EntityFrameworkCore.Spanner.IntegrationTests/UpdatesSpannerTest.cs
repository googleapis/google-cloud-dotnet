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
using Microsoft.EntityFrameworkCore.Utilities;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class UpdatesSpannerTest : UpdatesRelationalTestBase<UpdatesSpannerFixture, SpannerTestStore>
    {
        public UpdatesSpannerTest(UpdatesSpannerFixture fixture)
            : base(fixture)
        {
        }

        [Fact(Skip = "unknown")]
        public override void Remove_partial_on_missing_record_throws()
        {
            base.Remove_partial_on_missing_record_throws();
        }

        [Fact(Skip = "unknown")]
        public override void Save_partial_update()
        {
            base.Save_partial_update();
        }

        [Fact(Skip = "unknown")]
        public override void Save_partial_update_on_missing_record_throws()
        {
            base.Save_partial_update_on_missing_record_throws();
        }
    }
}