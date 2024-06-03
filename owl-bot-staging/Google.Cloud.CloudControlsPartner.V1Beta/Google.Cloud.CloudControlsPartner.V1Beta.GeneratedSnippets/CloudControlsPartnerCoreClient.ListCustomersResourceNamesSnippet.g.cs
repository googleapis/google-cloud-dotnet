// Copyright 2024 Google LLC
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
    // [START cloudcontrolspartner_v1beta_generated_CloudControlsPartnerCore_ListCustomers_sync_flattened_resourceNames]
    using Google.Api.Gax;
    using Google.Cloud.CloudControlsPartner.V1Beta;
    using System;

    public sealed partial class GeneratedCloudControlsPartnerCoreClientSnippets
    {
        /// <summary>Snippet for ListCustomers</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void ListCustomersResourceNames()
        {
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCustomersResponse, Customer> response = cloudControlsPartnerCoreClient.ListCustomers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Customer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Customer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Customer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Customer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END cloudcontrolspartner_v1beta_generated_CloudControlsPartnerCore_ListCustomers_sync_flattened_resourceNames]
}
