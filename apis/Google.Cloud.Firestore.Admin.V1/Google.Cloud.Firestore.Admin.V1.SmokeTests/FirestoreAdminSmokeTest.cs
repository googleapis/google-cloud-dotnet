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

using System;

namespace Google.Cloud.Firestore.Admin.V1.SmokeTests
{
    public sealed class FirestoreAdminSmokeTest
    {
        private const string ProjectEnvironmentVariable = "FIRESTORE_TEST_PROJECT";

        public static int Main(string[] args)
        {
            string projectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(projectId))
            {
                Console.WriteLine($"Environment variable {ProjectEnvironmentVariable} must be set.");
                return 1;
            }

            // Create client
            FirestoreAdminClient client = FirestoreAdminClient.Create();

            // Initialize request argument
            ParentName parentName = new ParentName(projectId, "(default)", "collection");

            // Call API method
            var indexes = client.ListIndexes(parentName);

            // Show the result
            foreach (var index in indexes)
            {
                Console.WriteLine(index);
            }

            // Success
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
