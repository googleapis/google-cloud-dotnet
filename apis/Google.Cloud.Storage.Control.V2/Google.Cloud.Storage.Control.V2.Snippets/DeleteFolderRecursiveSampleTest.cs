// Copyright 2026 Google LLC
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
using Google.Cloud.Storage.Control.V2;
using System;
using Xunit;

namespace Google.Cloud.Storage.Control.V2.Snippets
{
    [SnippetOutputCollector]
    public class DeleteFolderRecursiveSampleTest
    {
        [SkippableFact]
        public void TestDeleteFolderRecursive()
        {
            string projectId = Environment.GetEnvironmentVariable("TEST_PROJECT");
            Skip.If(string.IsNullOrEmpty(projectId), "No TEST_PROJECT environment variable set.");

            // Setup: Create HN bucket, add folder.
            var storageClient = StorageClient.Create();
            string bucketName = IdGenerator.FromGuid(prefix: "test-hn-bucket-");
            string folderName = "test-folder";

            var bucket = new Google.Apis.Storage.v1.Data.Bucket
            {
                Name = bucketName,
                HierarchicalNamespace = new Google.Apis.Storage.v1.Data.Bucket.HierarchicalNamespaceData { Enabled = true },
                IamConfiguration = new Google.Apis.Storage.v1.Data.Bucket.IamConfigurationData
                {
                    UniformBucketLevelAccess = new Google.Apis.Storage.v1.Data.Bucket.IamConfigurationData.UniformBucketLevelAccessData { Enabled = true }
                }
            };

            storageClient.CreateBucket(projectId, bucket);

            try
            {
                var storageControlClient = StorageControlClient.Create();
                
                var folder = new Folder { Name = $"projects/_/buckets/{bucketName}/folders/{folderName}" };
                storageControlClient.CreateFolder(new CreateFolderRequest
                {
                    ParentAsBucketName = BucketName.FromProjectBucket("_", bucketName),
                    FolderId = folderName,
                    Folder = folder
                });

                // Execution: Call sample method.
                var sample = new DeleteFolderRecursiveSample();
                sample.DeleteFolderRecursive(bucketName, folderName);

                // Verification: Assert successful deletion by trying to get the folder.
                var ex = Assert.Throws<Grpc.Core.RpcException>(() => 
                    storageControlClient.GetFolder(new GetFolderRequest { Name = folder.Name }));
                Assert.Equal(Grpc.Core.StatusCode.NotFound, ex.StatusCode);
            }
            finally
            {
                // Cleanup: Standard Dispose.
                storageClient.DeleteBucket(bucketName);
            }
        }
    }
}
