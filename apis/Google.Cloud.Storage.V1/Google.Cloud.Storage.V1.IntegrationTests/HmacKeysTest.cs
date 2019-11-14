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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Storage.v1.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class HmacKeysTest
    {
        private readonly StorageFixture _fixture;

        public HmacKeysTest(StorageFixture fixture) => _fixture = fixture;

        [Fact]
        public void Lifecycle()
        {
            var client = _fixture.Client;
            var projectId = _fixture.ProjectId;
            var serviceAccountEmail = GetServiceAccountEmail();
            // This is generally a valid service account for a project.
            string alternativeServiceAccountEmail = $"{projectId}@appspot.gserviceaccount.com";

            // If we find this fails in CI, we'll need to work out an alternative plan.
            Assert.NotEqual(serviceAccountEmail, alternativeServiceAccountEmail);

            Assert.Empty(client.ListHmacKeys(projectId));
            var key = client.CreateHmacKey(projectId, serviceAccountEmail);
            string accessId = key.Metadata.AccessId;

            // We should always get a 40 character secret, which is valid base64.
            Assert.Equal(40, key.Secret.Length);
            Convert.FromBase64String(key.Secret);

            // We should now be able to find the key when listing it, either with no filter or filtering by the right email address.
            var listed = Assert.Single(client.ListHmacKeys(projectId));
            Assert.Equal(accessId, listed.AccessId);
            listed = Assert.Single(client.ListHmacKeys(projectId, serviceAccountEmail));
            Assert.Equal(accessId, listed.AccessId);

            // But not when filtering with the wrong email address.
            Assert.Empty(client.ListHmacKeys(projectId, alternativeServiceAccountEmail));

            // We should be able to update the key to disable it.
            // Note: We shouldn't need to create this ourselves...
            var fixme = new HmacKeyMetadata
            {
                ProjectId = projectId,
                AccessId = accessId,
                State = HmacKeyStates.Inactive
            };
            var updated = client.UpdateHmacKey(fixme);
            Assert.Equal(fixme.State, updated.State);

            // We should be able to fetch the key and see that it's been updated
            var fetched = client.GetHmacKey(projectId, accessId);
            Assert.Equal(fixme.State, fetched.State);

            // We should be able to delete the key
            client.DeleteHmacKey(projectId, accessId);

            var deleted = client.GetHmacKey(projectId, accessId);
            Assert.Equal(HmacKeyStates.Deleted, deleted.State);

            // The deleted key should not show normally in list operations, but should show if we ask for deleted ones
            Assert.Empty(client.ListHmacKeys(projectId));
            Assert.Single(client.ListHmacKeys(projectId, options: new ListHmacKeysOptions { ShowDeletedKeys = true }),
                k => k.AccessId == accessId);
        }

        [Fact]
        public async Task LifecycleAsync()
        {
            var client = _fixture.Client;
            var projectId = _fixture.ProjectId;
            var serviceAccountEmail = GetServiceAccountEmail();
            string alternativeServiceAccountEmail = $"{projectId}@appspot.gserviceaccount.com";

            // If we find this fails in CI, we'll need to work out an alternative plan.
            Assert.NotEqual(serviceAccountEmail, alternativeServiceAccountEmail);

            Assert.Empty(await client.ListHmacKeysAsync(projectId).ToListAsync());
            var key = await client.CreateHmacKeyAsync(projectId, serviceAccountEmail);
            string accessId = key.Metadata.AccessId;

            // We should always get a 40 character secret, which is valid base64.
            Assert.Equal(40, key.Secret.Length);
            Convert.FromBase64String(key.Secret);

            // We should now be able to find the key when listing it, either with no filter or filtering by the right email address.
            var listed = Assert.Single(await client.ListHmacKeysAsync(projectId).ToListAsync());
            Assert.Equal(accessId, listed.AccessId);
            listed = Assert.Single(await client.ListHmacKeysAsync(projectId, serviceAccountEmail).ToListAsync());
            Assert.Equal(accessId, listed.AccessId);
            // But not when filtering with the wrong email address
            Assert.Empty(await client.ListHmacKeysAsync(projectId, alternativeServiceAccountEmail).ToListAsync());

            // We should be able to update the key to disable it.
            // Note: We shouldn't need to create this ourselves...
            var fixme = new HmacKeyMetadata
            {
                ProjectId = projectId,
                AccessId = accessId,
                State = HmacKeyStates.Inactive
            };
            var updated = await client.UpdateHmacKeyAsync(fixme);
            Assert.Equal(fixme.State, updated.State);

            // We should be able to fetch the key and see that it's been updated
            var fetched = await client.GetHmacKeyAsync(projectId, accessId);
            Assert.Equal(fixme.State, fetched.State);

            // We should be able to delete the key
            await client.DeleteHmacKeyAsync(projectId, accessId);
            var deleted = await client.GetHmacKeyAsync(projectId, accessId);
            Assert.Equal(HmacKeyStates.Deleted, deleted.State);

            // The deleted key should not show normally in list operations, but should show if we ask for deleted ones
            Assert.Empty(await client.ListHmacKeysAsync(projectId).ToListAsync());
            Assert.Single(await client.ListHmacKeysAsync(projectId, options: new ListHmacKeysOptions { ShowDeletedKeys = true }).ToListAsync(),
                k => k.AccessId == accessId);
        }

        private static string GetServiceAccountEmail()
        {
            var cred = GoogleCredential.GetApplicationDefault().UnderlyingCredential;
            switch (cred)
            {
                case ServiceAccountCredential sac:
                    return sac.Id;
                // TODO: We may well need to handle ComputeCredential for Kokoro.
                default:
                    throw new InvalidOperationException($"Unable to retrieve service account email address for credential type {cred.GetType()}");
            }
        }
    }
}
