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

using Google.Api.Gax.ResourceNames;
using Google.Cloud.Iam.V1;
using Google.Cloud.ResourceManager.V3;
using Grpc.Core;

namespace Google.Cloud.Tools.Snippets;

public class OccForIamSnippets
{
    private readonly SnippetFixture _fixture;

    public CallSettingsSnippets(SnippetFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void OccForIam()
    {
        string projectId = _ficxture.ProjectId;
        string role = "roles/cloudkms.cryptoKeyEncrypterDecrypter";
        string member = "user:betterbrent@google.com";

        // Sample: OccForIam
        ProjectsClient client = await ProjectsClient.CreateAsync();
        ProjectName resourceName = ProjectName.FromProject(projectId);

        try
        {
            // READ: Get the current policy (includes Etag)
            Console.WriteLine($"Reading policy for {resourceName}...");
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
            Console.WriteLine("Writing modified policy...");
            Policy updatedPolicy = await client.SetIamPolicyAsync(resourceName, policy);

            // SUCCESS
            Console.WriteLine("Successfully updated IAM policy.");
        }
        catch (RpcException ex) when (
            ex.StatusCode == StatusCode.Aborted ||
            ex.StatusCode == StatusCode.FailedPrecondition)
        {
            // A concurrency conflict can manifest as either Aborted or FailedPrecondition,
            // depending on the specifics of the API and the race condition.
            // To ensure the retry mechanism is robust, we catch both.
            Console.WriteLine($"Concurrency conflict (Etag mismatch).");

            // Handle the etag mismatch. For example, retry the change or prompt the user to
            // submit their changes again.
        }
        // End sample
    }
}
