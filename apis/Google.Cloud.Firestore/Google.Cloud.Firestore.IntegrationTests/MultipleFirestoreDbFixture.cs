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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Http;
using Google.Cloud.ClientTesting;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.IntegrationTests;

[CollectionDefinition(nameof(MultipleFirestoreDbFixture))]
public class MultipleFirestoreDbFixture : CloudProjectFixtureBase, ICollectionFixture<MultipleFirestoreDbFixture>
{
    private const string RestApiUrlBase = "https://firestore.googleapis.com/v1";
    private const string ProjectEnvironmentVariable = "FIRESTORE_TEST_PROJECT";
    private readonly HttpClient _httpClient;

    public MultipleFirestoreDbFixture() : base(ProjectEnvironmentVariable)
    { 
        // Scope used for the REST API to create databases.
        string scope = "https://www.googleapis.com/auth/datastore";
        string credentialsPath = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");

        // Initalize gcloud credentials to be used with REST API calls. 
        GoogleCredential googleCredential = GoogleCredential.FromFile(credentialsPath).CreateScoped(scope);
        _httpClient = new HttpClientFactory()
            .CreateHttpClient(new CreateHttpClientArgs { Initializers = { googleCredential } });
    }

    // TODO: Use Google.Cloud.Firestore.Admin.V1 when that supports this operation.

    /// <summary>
    /// Creates a new Firestore database using the REST API.
    /// </summary>
    public async Task CreateDatabaseAsync(string databaseId, string locationId, string databaseType)
    {
        var createDatabaseEndpoint = new Uri($"{RestApiUrlBase}/projects/{ProjectId}/databases?database_id={databaseId}");
        var data = new { locationId = locationId, type = databaseType };
        var httpData = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(createDatabaseEndpoint, httpData);
        response.EnsureSuccessStatusCode();
    }
}
