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

namespace Google.Cloud.Metastore.V1.Snippets
{
    // [START metastore_v1_generated_DataprocMetastore_GetService_sync]
    using Google.Cloud.Metastore.V1;

    public sealed partial class GeneratedDataprocMetastoreClientSnippets
    {
        /// <summary>Snippet for GetService</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetServiceRequestObject()
        {
            // Create client
            DataprocMetastoreClient dataprocMetastoreClient = DataprocMetastoreClient.Create();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            // Make the request
            Service response = dataprocMetastoreClient.GetService(request);
        }
    }
    // [END metastore_v1_generated_DataprocMetastore_GetService_sync]
}
