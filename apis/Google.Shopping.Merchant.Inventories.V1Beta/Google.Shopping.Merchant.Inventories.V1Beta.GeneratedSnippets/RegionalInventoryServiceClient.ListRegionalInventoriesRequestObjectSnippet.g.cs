// Copyright 2023 Google LLC
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
    // [START merchantapi_v1beta_generated_RegionalInventoryService_ListRegionalInventories_sync]
    using Google.Api.Gax;
    using Google.Shopping.Merchant.Inventories.V1Beta;
    using System;

    public sealed partial class GeneratedRegionalInventoryServiceClientSnippets
    {
        /// <summary>Snippet for ListRegionalInventories</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void ListRegionalInventoriesRequestObject()
        {
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = RegionalInventoryServiceClient.Create();
            // Initialize request argument(s)
            ListRegionalInventoriesRequest request = new ListRegionalInventoriesRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListRegionalInventoriesResponse, RegionalInventory> response = regionalInventoryServiceClient.ListRegionalInventories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RegionalInventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegionalInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegionalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegionalInventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegionalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END merchantapi_v1beta_generated_RegionalInventoryService_ListRegionalInventories_sync]
}