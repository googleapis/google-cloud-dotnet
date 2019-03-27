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

using Google.Api.Gax;
using Google.Api.Gax.ResourceNames;
using System;

namespace Google.Cloud.Talent.V4Beta1.SmokeTests
{
    /// <summary>
    /// This is a hand-written smoke test which just lists companies in a project,
    /// as a way of checking that the API is up and enabled for the project.
    /// </summary>
    public class CompanyServiceClientSmokeTest
    {
        public static int Main(string[] args)
        {
            // Read projectId from args
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: Project ID must be passed as first argument.");
                Console.WriteLine();
                return 1;
            }
            string projectId = args[0];

            // Create client
            CompanyServiceClient client = CompanyServiceClient.Create();

            // Initialize request argument(s)
            ProjectName projectName = new ProjectName(projectId);
            TenantOrProjectNameOneof parent = TenantOrProjectNameOneof.From(projectName);

            // Call API method
            PagedEnumerable<ListCompaniesResponse, Company> pagedResponse = client.ListCompanies(parent);
            // Show the result
            foreach (var item in pagedResponse)
            {
                Console.WriteLine(item);
            }

            // Success
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
