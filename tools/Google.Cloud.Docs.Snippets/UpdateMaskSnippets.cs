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

using Google.Cloud.SecretManager.V1;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace Google.Cloud.Tools.Snippets
{
    public class UpdateMaskSnippets
    {
        public async Task UpdateMasks()
        {
            string projectId = "your-project-id";
            string secretId = "test-secret";

            // Sample: UpdateMasks
            // Required using directives:
            // using Google.Cloud.SecretManager.V1;
            // using Google.Protobuf.WellKnownTypes;
            // using Grpc.Core;

            // Setup Client
            SecretManagerServiceClient client = await SecretManagerServiceClient.CreateAsync();

            // Prepare the resource with NEW values
            Secret secret = new Secret
            {
                // Set the full resource name
                SecretName = SecretName.FromProjectSecret(projectId, secretId),

                // Populate ONLY the fields we intend to change
                Labels = { { "env", "production" } }
            };

            // Create the FieldMask
            FieldMask updateMask = new FieldMask();

            // Add the Protobuf field name in snake_case
            // Note: The C# property is 'Labels', but the proto field name is 'labels'.
            updateMask.Paths.Add("labels");

            // Prepare the Request object
            UpdateSecretRequest request = new UpdateSecretRequest
            {
                Secret = secret,
                UpdateMask = updateMask
            };

            // Call the API
            try
            {
                Secret updatedSecret = await client.UpdateSecretAsync(request);
                Console.WriteLine($"Secret labels updated successfully. New Etag: {updatedSecret.Etag}");
            }
            catch (RpcException ex)
            {
                Console.WriteLine($"Update failed: {ex.Status.Detail}");
            }

            // End sample
        }
    }
}
