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

using Google.Apis.Bigquery.v2.Data;
using Moq;
using Xunit;

namespace Google.Bigquery.V2.Tests
{
    public class BigqueryTableTest
    {
        [Fact]
        public void StringConversions()
        {
            var table = CreateTable("project", "dataset", "table");
            var legacy = "[project:dataset.table]";
            var standard = "`project.dataset.table`";
            Assert.Equal(standard, table.ToString());
            Assert.Equal(legacy, table.ToLegacySqlFormat());
            Assert.Equal(standard, table.ToString(null, null));
            Assert.Equal(standard, table.ToString("not legacy", null));
            Assert.Equal(legacy, table.ToString("legacy", null));
        }

        /// <summary>
        /// Creates a BigqueryTable with just the ID populated.
        /// </summary>
        private static BigqueryTable CreateTable(string projectId, string datasetId, string tableId)
        {
            var table = new Table
            {
                TableReference = new TableReference { ProjectId = projectId, DatasetId = datasetId, TableId = tableId }
            };
            return new BigqueryTable(new Mock<BigqueryClient>().Object, table);
        }
    }
}
