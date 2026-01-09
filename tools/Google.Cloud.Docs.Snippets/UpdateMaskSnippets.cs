// Copyright 2025 Google Inc. All Rights Reserved.
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

using Google.Cloud.SecretManager.V1;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace Google.Cloud.Tools.Snippets;

public class UpdateMaskSnippets
{
    private readonly SnippetFixture _fixture;

    public CallSettingsSnippets(SnippetFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void UpdateMasks()
    {
        string projectId = _fixture.ProjectId;;
        string secretId = "test-secret";

        // Sample: UpdateMasks
        SecretManagerServiceClient client = await SecretManagerServiceClient.CreateAsync();

        // Prepare the resource with NEW values
        Secret secret = new Secret
        {
            // Set the full resource name
            SecretName = SecretName.FromProjectSecret(projectId, secretId),
            // Populate the fields we intend to change
            Labels = { { "env", "production" } }
        };

        // Create the FieldMask
        FieldMask updateMask = new FieldMask
        {
            // Add the original protobuf field name.
            // In this example, the C# property is 'Labels', but the protobuf field name is 'labels'.
            Paths = { "labels" }
        };

        // Prepare the Request object
        UpdateSecretRequest request = new UpdateSecretRequest
        {
            Secret = secret,
            UpdateMask = updateMask
        };

        // Call the API
        Secret updatedSecret = await client.UpdateSecretAsync(request);
        Console.WriteLine($"Secret labels updated successfully. New Etag: {updatedSecret.Etag}");
        // End sample
    }
}
