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

using Google.Api.Gax.ResourceNames;
using Google.Cloud.Iam.V1;
using Google.Cloud.ResourceManager.V3;
using Grpc.Core;

namespace Google.Cloud.Tools.Snippets
{
    public class OccForIamSnippets
    {
        public async Task<int> OccForIam()
        {
            string projectId = "your-project-id";
            string role = "roles/cloudkms.cryptoKeyEncrypterDecrypter";
            string member = "user:betterbrent@google.com";
            int maxRetries = 5;

            // Sample: OccForIam
            // Required using directives:
            // using Google.Api.Gax.ResourceNames;
            // using Google.Cloud.Iam.V1;
            // using Google.Cloud.ResourceManager.V3;
            // using Grpc.Core;

            // Setup Client
            ProjectsClient client = await ProjectsClient.CreateAsync();
            ProjectName resourceName = ProjectName.FromProject(projectId);

            int retries = 0;

            // --- START OCC LOOP ---
            while (retries < maxRetries)
            {
                try
                {
                    // READ: Get the current policy (includes Etag)
                    Console.WriteLine($"Attempt {retries + 1}: Reading policy for {resourceName}...");
                    Policy policy = await client.GetIamPolicyAsync(resourceName);

                    // MODIFY: Apply changes to the local Policy object
                    Binding binding = policy.Bindings.FirstOrDefault(b => b.Role == role);

                    if (binding != null)
                    {
                        if (!binding.Members.Contains(member))
                        {
                            binding.Members.Add(member);
                        }
                    }
                    else
                    {
                        policy.Bindings.Add(new Binding
                        {
                            Role = role,
                            Members = { member }
                        });
                    }

                    // WRITE: Attempt to set the modified policy
                    // The 'policy' object contains the original 'Etag' from Step 1.
                    Console.WriteLine($"Attempt {retries + 1}: Writing modified policy...");
                    Policy updatedPolicy = await client.SetIamPolicyAsync(resourceName, policy);

                    // SUCCESS
                    Console.WriteLine("Successfully updated IAM policy.");
                    return 0;
                }
                catch (RpcException ex) when (
                    ex.StatusCode == StatusCode.Aborted ||
                    ex.StatusCode == StatusCode.FailedPrecondition)
                {
                    // RETRY LOGIC
                    retries++;
                    Console.WriteLine($"Concurrency conflict (Etag mismatch). Retrying... ({retries}/{maxRetries})");

                    if (retries >= maxRetries)
                    {
                        Console.WriteLine("Failed to update policy after max retries.");
                        throw;
                    }

                    // Simple backoff
                    await Task.Delay(100 * retries);
                }
            }
            // --- END OCC LOOP ---

            return 1; // non-zero, failed
            // End sample
        }
    }
}
