// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.ResourceManager.V3.Snippets
{
    using Google.Api.Gax;
    using Google.Cloud.Iam.V1;
    using Google.Cloud.ResourceManager.V3;
    using System.Collections.Generic;

    public sealed partial class GeneratedTagKeysClientStandaloneSnippets
    {
        /// <summary>Snippet for TestIamPermissions</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void TestIamPermissionsResourceNames()
        {
            // Create client
            TagKeysClient tagKeysClient = TagKeysClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = tagKeysClient.TestIamPermissions(resource, permissions);
        }
    }
}
