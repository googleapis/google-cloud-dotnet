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

using Google.Apis.Bigquery.v2.Data;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class CreateCopyJobOptionsTest
    {
        [Fact]
        public void ModifyRequest()
        {
            var options = new CreateCopyJobOptions
            {
                CreateDisposition = CreateDisposition.CreateIfNeeded,
                WriteDisposition = WriteDisposition.WriteIfEmpty,
                DestinationEncryptionConfiguration = new EncryptionConfiguration { KmsKeyName = "projects/1/locations/us/keyRings/1/cryptoKeys/1" },
                OperationType = CopyOperationType.Clone,
                ConfigurationModifier = options => options.ETag = "test",
                Reservation = "Reservation"
            };
            JobConfigurationTableCopy request = new JobConfigurationTableCopy();
            options.ModifyRequest(request);
            Assert.Equal("CREATE_IF_NEEDED", request.CreateDisposition);
            Assert.Equal("WRITE_EMPTY", request.WriteDisposition);
            Assert.Equal("CLONE", request.OperationType);
            Assert.Equal("test", request.ETag);
            Assert.Equal("projects/1/locations/us/keyRings/1/cryptoKeys/1", request.DestinationEncryptionConfiguration.KmsKeyName);
        }
    }
}
