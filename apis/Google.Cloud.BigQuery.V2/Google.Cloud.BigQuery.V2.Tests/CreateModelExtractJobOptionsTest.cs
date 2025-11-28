// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Bigquery.v2.Data;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class CreateModelExtractJobOptionsTest
    {
        [Fact]
        public void ModifyRequest()
        {
            var options = new CreateModelExtractJobOptions
            {
                DestinationFormat = ModelFormat.XGBoostBooster,
                ConfigurationModifier = job => job.UseAvroLogicalTypes = true
            };
            JobConfigurationExtract extract = new JobConfigurationExtract();
            options.ModifyRequest(extract);
            Assert.Equal("ML_XGBOOST_BOOSTER", extract.DestinationFormat);
            Assert.True(extract.UseAvroLogicalTypes);
        }
    }
}