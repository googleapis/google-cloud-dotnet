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

using Google.Cloud.ClientTesting;
using Google.Cloud.Storage.V1;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    public abstract class BigQueryFixtureBase : CloudProjectFixtureBase
    {
        /// <summary>
        /// A GCS bucket created for this fixture.
        /// </summary>
        public string StorageBucketName { get; }
        public StorageClient StorageClient { get; }

        public BigQueryFixtureBase(string bucketPrefix)
        {
            StorageClient = StorageClient.Create();

            StorageBucketName = IdGenerator.FromDateTime(prefix: bucketPrefix);
            StorageClient.CreateBucket(ProjectId, StorageBucketName);
        }

        internal string GenerateStorageObjectName() => IdGenerator.FromGuid(prefix: "file-");
        internal string GenerateStoragePrefixName() => IdGenerator.FromGuid(prefix: "folder-");
    }
}
