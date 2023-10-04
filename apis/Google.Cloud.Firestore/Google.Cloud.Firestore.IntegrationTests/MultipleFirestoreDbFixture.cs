// Copyright 2022, Google Inc. All rights reserved.
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

using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using Google.Cloud.Firestore.Admin.V1;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.Admin.V1.Database.Types;

namespace Google.Cloud.Firestore.IntegrationTests;

[CollectionDefinition(nameof(MultipleFirestoreDbFixture))]
public class MultipleFirestoreDbFixture : CloudProjectFixtureBase, ICollectionFixture<MultipleFirestoreDbFixture>, IAsyncLifetime
{
    private const string ProjectEnvironmentVariable = "FIRESTORE_TEST_PROJECT";
    private FirestoreAdminClient _adminClient;

    public MultipleFirestoreDbFixture() : base(ProjectEnvironmentVariable)
    { }

    public async Task InitializeAsync() => _adminClient = await FirestoreAdminClient.CreateAsync();

    /// <summary>
    /// Creates a new Firestore database using Firestore Admin API.
    /// </summary>
    public async Task CreateDatabaseAsync(string databaseId, string locationId, DatabaseType databaseType)
    {
        await _adminClient.CreateDatabaseAsync(ProjectName.FromProject(ProjectId),
        new Database
        {
            LocationId = locationId,
            Type = databaseType
        },
        databaseId);
    }

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }
    
}
