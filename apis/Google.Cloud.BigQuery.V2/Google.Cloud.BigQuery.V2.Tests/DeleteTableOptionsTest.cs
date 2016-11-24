// Copyright 2016 Google Inc. All Rights Reserved.
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

using Xunit;
using static Google.Apis.Bigquery.v2.TablesResource;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class DeleteTableOptionsTest
    {
        // The test doesn't do anything yet... but neither does the code.
        [Fact]
        public void ModifyRequest_NoOp()
        {
            var request = new DeleteRequest(null, "project", "dataset", "table");
            var options = new DeleteTableOptions();
            options.ModifyRequest(request);
        }
    }
}
