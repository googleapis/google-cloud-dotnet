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

using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using System;
using Xunit;
using static Google.Apis.Bigquery.v2.DatasetsResource;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class CreateDatasetOptionsTest
    {
        [Fact]
        public void ModifyRequest()
        {
            var options = new CreateDatasetOptions
            {
                DefaultTableExpiration = TimeSpan.FromSeconds(10),
                Description = "A description",
                FriendlyName = "A friendly name",
                Location = "EU"
            };
            Dataset dataset = new Dataset();
            InsertRequest request = new InsertRequest(new BigqueryService(), dataset, "project");
            options.ModifyRequest(dataset, request);
            Assert.Equal(10 * 1000, dataset.DefaultTableExpirationMs);
            Assert.Equal("A description", dataset.Description);
            Assert.Equal("A friendly name", dataset.FriendlyName);
            Assert.Equal("EU", dataset.Location);
        }
    }
}
