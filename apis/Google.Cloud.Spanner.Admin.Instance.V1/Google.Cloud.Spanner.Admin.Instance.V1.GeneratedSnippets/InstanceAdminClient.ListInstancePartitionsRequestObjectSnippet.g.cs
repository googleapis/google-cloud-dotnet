// Copyright 2025 Google LLC
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

namespace GoogleCSharpSnippets
{
    // [START spanner_v1_generated_InstanceAdmin_ListInstancePartitions_sync]
    using Google.Api.Gax;
    using Google.Cloud.Spanner.Admin.Instance.V1;
    using Google.Cloud.Spanner.Common.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;

    public sealed partial class GeneratedInstanceAdminClientSnippets
    {
        /// <summary>Snippet for ListInstancePartitions</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void ListInstancePartitionsRequestObject()
        {
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            ListInstancePartitionsRequest request = new ListInstancePartitionsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                InstancePartitionDeadline = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<ListInstancePartitionsResponse, InstancePartition> response = instanceAdminClient.ListInstancePartitions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstancePartition item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancePartitionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstancePartition item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstancePartition> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstancePartition item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END spanner_v1_generated_InstanceAdmin_ListInstancePartitions_sync]
}
