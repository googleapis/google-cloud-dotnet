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

namespace Google.Cloud.SecretManager.V1Beta1.SmokeTests
{
    using Google.Api.Gax.ResourceNames;
    using System;

    public class CloudTasksClientSmokeTest
    {
        public static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Error: please specify a project ID");
                return 1;
            }
            string projectId = args[0];

            // Create client
            SecretManagerServiceClient client = SecretManagerServiceClient.Create();
            var secrets = client.ListSecrets(new ProjectName(projectId));
            foreach (var secret in secrets)
            {
                Console.WriteLine(secret.Name);
            }
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
