// Copyright 2019 Google LLC
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

using Google.Apis.Storage.v1.Data;
using Google.Cloud.ClientTesting;
using System;
using System.IO;
using System.Net;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class BucketPolicyOnlyTest
    {
        private readonly StorageFixture _fixture;

        public BucketPolicyOnlyTest(StorageFixture fixture) => _fixture = fixture;

        [Fact]
        public void EnableDisableOnExistingBucket()
        {
            string bucketName = _fixture.GenerateBucketName();
            var client = _fixture.Client;
            CreateBucket();
            EnableBpo();
            UploadObjectSucceeds_DownloadObjectFails();
            DisableBpo();

            // Individual steps of the test as local methods

            void CreateBucket()
            {
                Bucket bucket = _fixture.CreateBucket(bucketName, false);
                Assert.False(bucket.IamConfiguration.BucketPolicyOnly.Enabled);
            }

            void EnableBpo()
            {
                client.PatchBucket(CreateBucketRepresentation(bucketName, true));

                var fetched = client.GetBucket(bucketName);
                Assert.True(fetched.IamConfiguration.BucketPolicyOnly.Enabled);
                var lockedTime = fetched.IamConfiguration.BucketPolicyOnly.LockedTime;
                Assert.NotNull(lockedTime);

                var expectedLockedTime = DateTime.UtcNow.AddDays(90);
                Assert.InRange(lockedTime.Value.ToUniversalTime(), expectedLockedTime.AddMinutes(-10), expectedLockedTime.AddMinutes(10));
            }

            void UploadObjectSucceeds_DownloadObjectFails()
            {
                string objectName = IdGenerator.FromGuid();
                var objectData = TestHelpers.GenerateData(512);
                client.UploadObject(bucketName, objectName, "", objectData);
                Assert.Throws<GoogleApiException>(() => client.DownloadObject(bucketName, objectName, new MemoryStream()));
            }

            void DisableBpo()
            {
                client.PatchBucket(CreateBucketRepresentation(bucketName, false));
                var fetched = client.GetBucket(bucketName);
                Assert.False(fetched.IamConfiguration.BucketPolicyOnly.Enabled);
            }
        }        

        [Fact]
        public void GeneralSmokeTest()
        {
            var client = _fixture.Client;
            string bucketName = _fixture.GenerateBucketName();
            string objectName = IdGenerator.FromGuid();

            CreateBucket();
            UploadDownloadObject();
            AclApisDisabled();

            void CreateBucket()
            {
                StorageFixture.SleepAfterBucketCreateDelete();
                Bucket created = client.CreateBucket(_fixture.ProjectId, CreateBucketRepresentation(bucketName, true));
                _fixture.RegisterBucketToDelete(bucketName);
                StorageFixture.SleepAfterBucketCreateDelete();
                Assert.True(created.IamConfiguration.BucketPolicyOnly.Enabled);
            }

            void UploadDownloadObject()
            {
                var objectData = TestHelpers.GenerateData(512);
                client.UploadObject(bucketName, objectName, "", objectData);
                // Unlike the "create then enable" case, we can still download the object afterwards
                TestHelpers.ValidateData(bucketName, objectName, objectData);
            }

            void AclApisDisabled()
            {
                // We don't have wrapper methods for the BucketAccessControls or ObjectAccessControls APIs, so use the service directly.
                var exception = Assert.Throws<GoogleApiException>(() => client.Service.BucketAccessControls.List(bucketName).Execute());
                Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
                exception = Assert.Throws<GoogleApiException>(() => client.Service.ObjectAccessControls.List(bucketName, objectName).Execute());
                Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
            }
        }        

        private static Bucket CreateBucketRepresentation(string bucketName, bool enabled) =>
            new Bucket
            {
                Name = bucketName,
                IamConfiguration = new Bucket.IamConfigurationData
                {
                    BucketPolicyOnly = new Bucket.IamConfigurationData.BucketPolicyOnlyData
                    {
                        Enabled = enabled
                    }
                }
            };
    }
}
