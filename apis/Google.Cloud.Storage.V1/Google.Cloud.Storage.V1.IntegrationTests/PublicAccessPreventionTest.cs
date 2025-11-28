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

using Google.Apis.Storage.v1.Data;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class PublicAccessPreventionTest
    {
        private const string EnforcedValue = "enforced";
        private const string InheritedValue = "inherited";
        private static readonly Policy.BindingsData AllUsersViewer = new Policy.BindingsData
        {
            Members = new[] { "domain:google.com" },
            Role = "roles/storage.objectViewer"
        };

        private readonly StorageFixture _fixture;

        public PublicAccessPreventionTest(StorageFixture fixture) => _fixture = fixture;

        [Fact]
        public void PreventAccessOnExistingBucket()
        {
            var client = _fixture.Client;
            string bucketName = _fixture.GenerateBucketName();
            Bucket bucket = _fixture.CreateBucket(bucketName, false);
            Assert.True(bucket.IamConfiguration.PublicAccessPrevention == null
                || bucket.IamConfiguration.PublicAccessPrevention == InheritedValue);

            // Enforce PAP
            client.PatchBucket(CreateBucketRepresentation(bucketName, EnforcedValue));

            // We shouldn't be able to allow all users to view objects.
            var policy = client.GetBucketIamPolicy(bucketName);
            policy.Bindings.Add(AllUsersViewer);

            Assert.Throws<GoogleApiException>(() => client.SetBucketIamPolicy(bucketName, policy));
        }

        [Fact]
        public void PreventAccessOnNewBucket()
        {
            var client = _fixture.Client;
            string bucketName = _fixture.GenerateBucketName();
            StorageFixture.SleepAfterBucketCreateDelete();
            Bucket created = client.CreateBucket(_fixture.ProjectId, CreateBucketRepresentation(bucketName, EnforcedValue));
            _fixture.RegisterBucketToDelete(bucketName);
            StorageFixture.SleepAfterBucketCreateDelete();

            Assert.Equal(EnforcedValue, created.IamConfiguration.PublicAccessPrevention);

            // We shouldn't be able to allow all users to view objects.
            var policy = client.GetBucketIamPolicy(bucketName);
            policy.Bindings.Add(AllUsersViewer);

            Assert.Throws<GoogleApiException>(() => client.SetBucketIamPolicy(bucketName, policy));
        }

        [Fact]
        public void RestoreAccess()
        {
            var client = _fixture.Client;
            string bucketName = _fixture.GenerateBucketName();
            Bucket bucket = _fixture.CreateBucket(bucketName, false);
            Assert.True(bucket.IamConfiguration.PublicAccessPrevention == null
                || bucket.IamConfiguration.PublicAccessPrevention == InheritedValue);

            // Enforce PAP, then unenforce it
            client.PatchBucket(CreateBucketRepresentation(bucketName, EnforcedValue));
            client.PatchBucket(CreateBucketRepresentation(bucketName, InheritedValue));

            // Now we should be able to allow all users to view objects.
            var policy = client.GetBucketIamPolicy(bucketName);
            policy.Bindings.Add(AllUsersViewer);

            client.SetBucketIamPolicy(bucketName, policy);
        }

        private static Bucket CreateBucketRepresentation(string bucketName, string papValue) =>
            new Bucket
            {
                Name = bucketName,
                IamConfiguration = new Bucket.IamConfigurationData { PublicAccessPrevention = papValue }
            };
    }
}
