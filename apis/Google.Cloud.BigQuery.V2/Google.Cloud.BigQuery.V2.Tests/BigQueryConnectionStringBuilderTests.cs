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
using System;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryConnectionStringBuilderTests
    {
        [Fact]
        public void CanSetDataSourceParts()
        {
            BigQueryConnectionStringBuilder builder = new BigQueryConnectionStringBuilder();
            builder.Project = "abc";
            builder.BigQueryDataset = "123";

            BigQueryConnectionStringBuilder builder2 = new BigQueryConnectionStringBuilder();
            builder2.DataSource = $"projects/{builder.Project}/datasets/{builder.BigQueryDataset}";

            Assert.Equal(builder.Project, builder2.Project);
            Assert.Equal(builder.BigQueryDataset, builder2.BigQueryDataset);
        }

        [Fact]
        public void CanSetDataSourcePartsReversed()
        {
            BigQueryConnectionStringBuilder builder = new BigQueryConnectionStringBuilder();
            builder.BigQueryDataset = "123";
            builder.Project = "abc";

            BigQueryConnectionStringBuilder builder2 = new BigQueryConnectionStringBuilder();
            builder2.DataSource = $"projects/{builder.Project}/datasets/{builder.BigQueryDataset}";

            Assert.Equal(builder.Project, builder2.Project);
            Assert.Equal(builder.BigQueryDataset, builder2.BigQueryDataset);
        }
    }
}
