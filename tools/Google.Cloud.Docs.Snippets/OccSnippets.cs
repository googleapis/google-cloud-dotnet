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

using Google.Cloud.Iam.V1;
using Google.Cloud.PubSub.V1;
using Grpc.Core;
using System.Linq;
using Xunit;

namespace Google.Cloud.Tools.Snippets;

[Collection(nameof(SnippetFixture))]
public class OccSnippets
{
    private readonly SnippetFixture _fixture;

    public OccSnippets(SnippetFixture fixture) => _fixture = fixture;

    [Fact]
    public void OccForIam()
    {
        string role = "roles/pubsub.viewer";
        string member = "domain:google.com";

        var topicName = _fixture.CreateTopic();

        // Sample: OccForIam
        PublisherServiceApiClient client = PublisherServiceApiClient.Create();

        try
        {
            // Get the current IAM Policy with the current Etag.
            Policy policy = client.IAMPolicyClient.GetIamPolicy(new GetIamPolicyRequest
            {
                Resource = topicName,
            });

            // Modify the local IAM Policy object.
            Binding binding = policy.Bindings.FirstOrDefault(b => b.Role == role);

            if (binding is null)
            {
                binding = new Binding { Role = role };
                policy.Bindings.Add(binding);
            }

            if (!binding.Members.Contains(member))
            {
                binding.Members.Add(member);
            }

            // Attempt to set the modified policy, it contains the Etag value from when it was read.
            client.IAMPolicyClient.SetIamPolicy(new SetIamPolicyRequest
            {
                Resource = topicName,
                Policy = policy
            });

            // The policy was modified successfully.
        }
        catch (RpcException ex) when ( ex.StatusCode == StatusCode.Aborted )
        {
            // A concurrency conflict usually manifests as Aborted but depending on the API
            // other error codes may be used, like FailedPrecondition.
            // To ensure the OCC mechanism is robust, check the documentation for the API
            // you are implementing OCC for.

            // Handle the etag mismatch. For example, retry the change or prompt the user to
            // submit their changes again.
        }
        // End sample
    }
}
