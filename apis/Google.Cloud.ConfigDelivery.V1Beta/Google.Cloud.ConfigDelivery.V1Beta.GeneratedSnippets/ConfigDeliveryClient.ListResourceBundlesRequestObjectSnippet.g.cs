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
    // [START configdelivery_v1beta_generated_ConfigDelivery_ListResourceBundles_sync]
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ConfigDelivery.V1Beta;
    using System;

    public sealed partial class GeneratedConfigDeliveryClientSnippets
    {
        /// <summary>Snippet for ListResourceBundles</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void ListResourceBundlesRequestObject()
        {
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            ListResourceBundlesRequest request = new ListResourceBundlesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListResourceBundlesResponse, ResourceBundle> response = configDeliveryClient.ListResourceBundles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceBundle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceBundlesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceBundle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceBundle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END configdelivery_v1beta_generated_ConfigDelivery_ListResourceBundles_sync]
}
