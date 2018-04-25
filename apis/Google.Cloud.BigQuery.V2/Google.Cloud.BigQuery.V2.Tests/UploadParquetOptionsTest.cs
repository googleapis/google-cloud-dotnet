// Copyright 2018 Google LLC
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
    public class UploadParquetOptionsTest
    {
        [Fact]
        public void ModifyRequest()
        {
            var options = new UploadParquetOptions
            {
                AllowUnknownFields = true,
                CreateDisposition = CreateDisposition.CreateIfNeeded,
                MaxBadRecords = 10,
                TimePartitioning = TimePartition.CreateDailyPartitioning(expiration: null),
                WriteDisposition = WriteDisposition.WriteAppend,
                DestinationEncryptionConfiguration = new EncryptionConfiguration { KmsKeyName = "projects/1/locations/us/keyRings/1/cryptoKeys/1" },
            };

            JobConfigurationLoad config = new JobConfigurationLoad();
            options.ModifyConfiguration(config);
            Assert.Equal(true, config.IgnoreUnknownValues);
            Assert.Equal("CREATE_IF_NEEDED", config.CreateDisposition);
            Assert.Equal(10, config.MaxBadRecords);
            Assert.Equal("DAY", config.TimePartitioning.Type);
            Assert.Null(config.TimePartitioning.ExpirationMs);
            Assert.Equal("WRITE_APPEND", config.WriteDisposition);
            Assert.Equal("projects/1/locations/us/keyRings/1/cryptoKeys/1", config.DestinationEncryptionConfiguration.KmsKeyName);
        }
    }
}
