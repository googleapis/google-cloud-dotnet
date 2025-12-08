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
using Google.Api.Gax.Grpc;
using Google.Api.Gax;
using Grpc.Core;

namespace Google.Cloud.Tools.Snippets
{
    public class RetriesSnippets
    {
        public async Task ServiceSettingsRetries()
        {
            // Sample: ServiceSettingsRetries
            // Required using directives:
            // using Google.Cloud.SecretManager.V1;
            // using Google.Api.Gax.Grpc;
            // using Google.Api.Gax;
            // using Grpc.Core;

            // Define custom retry settings
            var retrySettings = RetrySettings.FromExponentialBackoff(
                maxAttempts: 3,                                 // Maximum number of attempts
                initialBackoff: TimeSpan.FromMilliseconds(500), // Wait 0.5s before the first retry
                maxBackoff: TimeSpan.FromSeconds(5),            // Cap the wait at 5s
                backoffMultiplier: 2.0,                         // Double the wait time on each failure
                retryFilter: RetrySettings.FilterForStatusCodes(StatusCode.Unavailable, StatusCode.DeadlineExceeded)
            );

            // Apply your custom retry settings to the specific method
            var settings = new SecretManagerServiceSettings();
            settings.ListSecretsSettings = settings.ListSecretsSettings.WithRetry(retrySettings);

            // Create a new client with the custom configuration
            var builder = new SecretManagerServiceClientBuilder
            {
                Settings = settings
            };

            var client = await builder.BuildAsync();

            Console.WriteLine("Client created with custom retry settings.");
            // End sample
        }
        public async Task CallSettingsRetries()
        {
            string projectId = "your-project-id";

            // Sample: CallSettingsRetries
            // Required using directives:
            // using Google.Cloud.SecretManager.V1;
            // using Google.Api.Gax;
            // using Google.Protobuf.WellKnownTypes;
            // using Google.Api.Gax.ResourceNames;

            // Define custom retry settings
            var retrySettings = RetrySettings.FromExponentialBackoff(
                maxAttempts: 3,
                initialBackoff: TimeSpan.FromSeconds(0.5),
                maxBackoff: TimeSpan.FromSeconds(5),
                backoffMultiplier: 2.0,
                retryFilter: RetrySettings.FilterForStatusCodes(StatusCode.Unavailable, StatusCode.DeadlineExceeded)
            );

            // Create CallSettings
            var callSettings = CallSettings.FromRetry(retrySettings);

            // Prepare the request
            ProjectName parent = ProjectName.FromProject(projectId);
            ListSecretsRequest request = new ListSecretsRequest { ParentAsProjectName = parent };

            // Call the method, passing the CallSettings
            var client = await SecretManagerServiceClient.CreateAsync();
            var response = client.ListSecrets(request, callSettings);

            Console.WriteLine("RPC called with custom retry settings.");
            // End sample
        }
    }
}
