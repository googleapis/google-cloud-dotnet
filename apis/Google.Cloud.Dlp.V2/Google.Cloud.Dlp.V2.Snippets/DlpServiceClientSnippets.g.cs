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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Dlp.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Dlp.V2;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedDlpServiceClientSnippets
    {
        /// <summary>Snippet for InspectContentAsync</summary>
        public async Task InspectContentAsync_RequestObject()
        {
            // Snippet: InspectContentAsync(InspectContentRequest,CallSettings)
            // Additional: InspectContentAsync(InspectContentRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectContentRequest request = new InspectContentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            InspectContentResponse response = await dlpServiceClient.InspectContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for InspectContent</summary>
        public void InspectContent_RequestObject()
        {
            // Snippet: InspectContent(InspectContentRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectContentRequest request = new InspectContentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            InspectContentResponse response = dlpServiceClient.InspectContent(request);
            // End snippet
        }

        /// <summary>Snippet for RedactImageAsync</summary>
        public async Task RedactImageAsync_RequestObject()
        {
            // Snippet: RedactImageAsync(RedactImageRequest,CallSettings)
            // Additional: RedactImageAsync(RedactImageRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            RedactImageRequest request = new RedactImageRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            RedactImageResponse response = await dlpServiceClient.RedactImageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RedactImage</summary>
        public void RedactImage_RequestObject()
        {
            // Snippet: RedactImage(RedactImageRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            RedactImageRequest request = new RedactImageRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            RedactImageResponse response = dlpServiceClient.RedactImage(request);
            // End snippet
        }

        /// <summary>Snippet for DeidentifyContentAsync</summary>
        public async Task DeidentifyContentAsync_RequestObject()
        {
            // Snippet: DeidentifyContentAsync(DeidentifyContentRequest,CallSettings)
            // Additional: DeidentifyContentAsync(DeidentifyContentRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            DeidentifyContentResponse response = await dlpServiceClient.DeidentifyContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeidentifyContent</summary>
        public void DeidentifyContent_RequestObject()
        {
            // Snippet: DeidentifyContent(DeidentifyContentRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            DeidentifyContentResponse response = dlpServiceClient.DeidentifyContent(request);
            // End snippet
        }

        /// <summary>Snippet for ReidentifyContentAsync</summary>
        public async Task ReidentifyContentAsync_RequestObject()
        {
            // Snippet: ReidentifyContentAsync(ReidentifyContentRequest,CallSettings)
            // Additional: ReidentifyContentAsync(ReidentifyContentRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReidentifyContentRequest request = new ReidentifyContentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            ReidentifyContentResponse response = await dlpServiceClient.ReidentifyContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReidentifyContent</summary>
        public void ReidentifyContent_RequestObject()
        {
            // Snippet: ReidentifyContent(ReidentifyContentRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ReidentifyContentRequest request = new ReidentifyContentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            ReidentifyContentResponse response = dlpServiceClient.ReidentifyContent(request);
            // End snippet
        }

        /// <summary>Snippet for ListInfoTypesAsync</summary>
        public async Task ListInfoTypesAsync_RequestObject()
        {
            // Snippet: ListInfoTypesAsync(ListInfoTypesRequest,CallSettings)
            // Additional: ListInfoTypesAsync(ListInfoTypesRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInfoTypesRequest request = new ListInfoTypesRequest();
            // Make the request
            ListInfoTypesResponse response = await dlpServiceClient.ListInfoTypesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListInfoTypes</summary>
        public void ListInfoTypes_RequestObject()
        {
            // Snippet: ListInfoTypes(ListInfoTypesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListInfoTypesRequest request = new ListInfoTypesRequest();
            // Make the request
            ListInfoTypesResponse response = dlpServiceClient.ListInfoTypes(request);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplateAsync</summary>
        public async Task CreateInspectTemplateAsync_RequestObject()
        {
            // Snippet: CreateInspectTemplateAsync(CreateInspectTemplateRequest,CallSettings)
            // Additional: CreateInspectTemplateAsync(CreateInspectTemplateRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            // Make the request
            InspectTemplate response = await dlpServiceClient.CreateInspectTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplate</summary>
        public void CreateInspectTemplate_RequestObject()
        {
            // Snippet: CreateInspectTemplate(CreateInspectTemplateRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            // Make the request
            InspectTemplate response = dlpServiceClient.CreateInspectTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateInspectTemplateAsync</summary>
        public async Task UpdateInspectTemplateAsync_RequestObject()
        {
            // Snippet: UpdateInspectTemplateAsync(UpdateInspectTemplateRequest,CallSettings)
            // Additional: UpdateInspectTemplateAsync(UpdateInspectTemplateRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateNameOneof = InspectTemplateNameOneof.From(new OrganizationInspectTemplateName("[ORGANIZATION]", "[INSPECT_TEMPLATE]")),
            };
            // Make the request
            InspectTemplate response = await dlpServiceClient.UpdateInspectTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateInspectTemplate</summary>
        public void UpdateInspectTemplate_RequestObject()
        {
            // Snippet: UpdateInspectTemplate(UpdateInspectTemplateRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateNameOneof = InspectTemplateNameOneof.From(new OrganizationInspectTemplateName("[ORGANIZATION]", "[INSPECT_TEMPLATE]")),
            };
            // Make the request
            InspectTemplate response = dlpServiceClient.UpdateInspectTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetInspectTemplateAsync</summary>
        public async Task GetInspectTemplateAsync_RequestObject()
        {
            // Snippet: GetInspectTemplateAsync(GetInspectTemplateRequest,CallSettings)
            // Additional: GetInspectTemplateAsync(GetInspectTemplateRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetInspectTemplateRequest request = new GetInspectTemplateRequest();
            // Make the request
            InspectTemplate response = await dlpServiceClient.GetInspectTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInspectTemplate</summary>
        public void GetInspectTemplate_RequestObject()
        {
            // Snippet: GetInspectTemplate(GetInspectTemplateRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetInspectTemplateRequest request = new GetInspectTemplateRequest();
            // Make the request
            InspectTemplate response = dlpServiceClient.GetInspectTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplatesAsync</summary>
        public async Task ListInspectTemplatesAsync_RequestObject()
        {
            // Snippet: ListInspectTemplatesAsync(ListInspectTemplatesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> response =
                dlpServiceClient.ListInspectTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InspectTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInspectTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InspectTemplate item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InspectTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InspectTemplate item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplates</summary>
        public void ListInspectTemplates_RequestObject()
        {
            // Snippet: ListInspectTemplates(ListInspectTemplatesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> response =
                dlpServiceClient.ListInspectTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InspectTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInspectTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InspectTemplate item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InspectTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InspectTemplate item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteInspectTemplateAsync</summary>
        public async Task DeleteInspectTemplateAsync_RequestObject()
        {
            // Snippet: DeleteInspectTemplateAsync(DeleteInspectTemplateRequest,CallSettings)
            // Additional: DeleteInspectTemplateAsync(DeleteInspectTemplateRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateNameOneof = InspectTemplateNameOneof.From(new OrganizationInspectTemplateName("[ORGANIZATION]", "[INSPECT_TEMPLATE]")),
            };
            // Make the request
            await dlpServiceClient.DeleteInspectTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInspectTemplate</summary>
        public void DeleteInspectTemplate_RequestObject()
        {
            // Snippet: DeleteInspectTemplate(DeleteInspectTemplateRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateNameOneof = InspectTemplateNameOneof.From(new OrganizationInspectTemplateName("[ORGANIZATION]", "[INSPECT_TEMPLATE]")),
            };
            // Make the request
            dlpServiceClient.DeleteInspectTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplateAsync</summary>
        public async Task CreateDeidentifyTemplateAsync_RequestObject()
        {
            // Snippet: CreateDeidentifyTemplateAsync(CreateDeidentifyTemplateRequest,CallSettings)
            // Additional: CreateDeidentifyTemplateAsync(CreateDeidentifyTemplateRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.CreateDeidentifyTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplate</summary>
        public void CreateDeidentifyTemplate_RequestObject()
        {
            // Snippet: CreateDeidentifyTemplate(CreateDeidentifyTemplateRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.CreateDeidentifyTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeidentifyTemplateAsync</summary>
        public async Task UpdateDeidentifyTemplateAsync_RequestObject()
        {
            // Snippet: UpdateDeidentifyTemplateAsync(UpdateDeidentifyTemplateRequest,CallSettings)
            // Additional: UpdateDeidentifyTemplateAsync(UpdateDeidentifyTemplateRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new OrganizationDeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.UpdateDeidentifyTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeidentifyTemplate</summary>
        public void UpdateDeidentifyTemplate_RequestObject()
        {
            // Snippet: UpdateDeidentifyTemplate(UpdateDeidentifyTemplateRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new OrganizationDeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.UpdateDeidentifyTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeidentifyTemplateAsync</summary>
        public async Task GetDeidentifyTemplateAsync_RequestObject()
        {
            // Snippet: GetDeidentifyTemplateAsync(GetDeidentifyTemplateRequest,CallSettings)
            // Additional: GetDeidentifyTemplateAsync(GetDeidentifyTemplateRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new OrganizationDeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.GetDeidentifyTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeidentifyTemplate</summary>
        public void GetDeidentifyTemplate_RequestObject()
        {
            // Snippet: GetDeidentifyTemplate(GetDeidentifyTemplateRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new OrganizationDeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.GetDeidentifyTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplatesAsync</summary>
        public async Task ListDeidentifyTemplatesAsync_RequestObject()
        {
            // Snippet: ListDeidentifyTemplatesAsync(ListDeidentifyTemplatesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response =
                dlpServiceClient.ListDeidentifyTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeidentifyTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeidentifyTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeidentifyTemplate item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeidentifyTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeidentifyTemplate item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplates</summary>
        public void ListDeidentifyTemplates_RequestObject()
        {
            // Snippet: ListDeidentifyTemplates(ListDeidentifyTemplatesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response =
                dlpServiceClient.ListDeidentifyTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeidentifyTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeidentifyTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeidentifyTemplate item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeidentifyTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeidentifyTemplate item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteDeidentifyTemplateAsync</summary>
        public async Task DeleteDeidentifyTemplateAsync_RequestObject()
        {
            // Snippet: DeleteDeidentifyTemplateAsync(DeleteDeidentifyTemplateRequest,CallSettings)
            // Additional: DeleteDeidentifyTemplateAsync(DeleteDeidentifyTemplateRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new OrganizationDeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            // Make the request
            await dlpServiceClient.DeleteDeidentifyTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeidentifyTemplate</summary>
        public void DeleteDeidentifyTemplate_RequestObject()
        {
            // Snippet: DeleteDeidentifyTemplate(DeleteDeidentifyTemplateRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new OrganizationDeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            // Make the request
            dlpServiceClient.DeleteDeidentifyTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJobAsync</summary>
        public async Task CreateDlpJobAsync_RequestObject()
        {
            // Snippet: CreateDlpJobAsync(CreateDlpJobRequest,CallSettings)
            // Additional: CreateDlpJobAsync(CreateDlpJobRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            DlpJob response = await dlpServiceClient.CreateDlpJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJob</summary>
        public void CreateDlpJob_RequestObject()
        {
            // Snippet: CreateDlpJob(CreateDlpJobRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            DlpJob response = dlpServiceClient.CreateDlpJob(request);
            // End snippet
        }

        /// <summary>Snippet for ListDlpJobsAsync</summary>
        public async Task ListDlpJobsAsync_RequestObject()
        {
            // Snippet: ListDlpJobsAsync(ListDlpJobsRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDlpJobsRequest request = new ListDlpJobsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> response =
                dlpServiceClient.ListDlpJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DlpJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDlpJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DlpJob item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DlpJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DlpJob item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDlpJobs</summary>
        public void ListDlpJobs_RequestObject()
        {
            // Snippet: ListDlpJobs(ListDlpJobsRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListDlpJobsRequest request = new ListDlpJobsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListDlpJobsResponse, DlpJob> response =
                dlpServiceClient.ListDlpJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DlpJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDlpJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DlpJob item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DlpJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DlpJob item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDlpJobAsync</summary>
        public async Task GetDlpJobAsync_RequestObject()
        {
            // Snippet: GetDlpJobAsync(GetDlpJobRequest,CallSettings)
            // Additional: GetDlpJobAsync(GetDlpJobRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDlpJobRequest request = new GetDlpJobRequest
            {
                DlpJobName = new DlpJobName("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            DlpJob response = await dlpServiceClient.GetDlpJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDlpJob</summary>
        public void GetDlpJob_RequestObject()
        {
            // Snippet: GetDlpJob(GetDlpJobRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetDlpJobRequest request = new GetDlpJobRequest
            {
                DlpJobName = new DlpJobName("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            DlpJob response = dlpServiceClient.GetDlpJob(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDlpJobAsync</summary>
        public async Task DeleteDlpJobAsync_RequestObject()
        {
            // Snippet: DeleteDlpJobAsync(DeleteDlpJobRequest,CallSettings)
            // Additional: DeleteDlpJobAsync(DeleteDlpJobRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDlpJobRequest request = new DeleteDlpJobRequest
            {
                DlpJobName = new DlpJobName("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            await dlpServiceClient.DeleteDlpJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDlpJob</summary>
        public void DeleteDlpJob_RequestObject()
        {
            // Snippet: DeleteDlpJob(DeleteDlpJobRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteDlpJobRequest request = new DeleteDlpJobRequest
            {
                DlpJobName = new DlpJobName("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            dlpServiceClient.DeleteDlpJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelDlpJobAsync</summary>
        public async Task CancelDlpJobAsync_RequestObject()
        {
            // Snippet: CancelDlpJobAsync(CancelDlpJobRequest,CallSettings)
            // Additional: CancelDlpJobAsync(CancelDlpJobRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelDlpJobRequest request = new CancelDlpJobRequest
            {
                DlpJobName = new DlpJobName("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            await dlpServiceClient.CancelDlpJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelDlpJob</summary>
        public void CancelDlpJob_RequestObject()
        {
            // Snippet: CancelDlpJob(CancelDlpJobRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CancelDlpJobRequest request = new CancelDlpJobRequest
            {
                DlpJobName = new DlpJobName("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            dlpServiceClient.CancelDlpJob(request);
            // End snippet
        }

        /// <summary>Snippet for ListJobTriggersAsync</summary>
        public async Task ListJobTriggersAsync_RequestObject()
        {
            // Snippet: ListJobTriggersAsync(ListJobTriggersRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListJobTriggersRequest request = new ListJobTriggersRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> response =
                dlpServiceClient.ListJobTriggersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((JobTrigger item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobTriggersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobTrigger item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobTrigger> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobTrigger item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTriggers</summary>
        public void ListJobTriggers_RequestObject()
        {
            // Snippet: ListJobTriggers(ListJobTriggersRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListJobTriggersRequest request = new ListJobTriggersRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListJobTriggersResponse, JobTrigger> response =
                dlpServiceClient.ListJobTriggers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (JobTrigger item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListJobTriggersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobTrigger item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobTrigger> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobTrigger item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetJobTriggerAsync</summary>
        public async Task GetJobTriggerAsync_RequestObject()
        {
            // Snippet: GetJobTriggerAsync(GetJobTriggerRequest,CallSettings)
            // Additional: GetJobTriggerAsync(GetJobTriggerRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetJobTriggerRequest request = new GetJobTriggerRequest
            {
                ProjectJobTriggerName = new ProjectJobTriggerName("[PROJECT]", "[JOB_TRIGGER]"),
            };
            // Make the request
            JobTrigger response = await dlpServiceClient.GetJobTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobTrigger</summary>
        public void GetJobTrigger_RequestObject()
        {
            // Snippet: GetJobTrigger(GetJobTriggerRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetJobTriggerRequest request = new GetJobTriggerRequest
            {
                ProjectJobTriggerName = new ProjectJobTriggerName("[PROJECT]", "[JOB_TRIGGER]"),
            };
            // Make the request
            JobTrigger response = dlpServiceClient.GetJobTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTriggerAsync</summary>
        public async Task DeleteJobTriggerAsync_RequestObject()
        {
            // Snippet: DeleteJobTriggerAsync(DeleteJobTriggerRequest,CallSettings)
            // Additional: DeleteJobTriggerAsync(DeleteJobTriggerRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteJobTriggerRequest request = new DeleteJobTriggerRequest
            {
                ProjectJobTriggerName = new ProjectJobTriggerName("[PROJECT]", "[JOB_TRIGGER]"),
            };
            // Make the request
            await dlpServiceClient.DeleteJobTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTrigger</summary>
        public void DeleteJobTrigger_RequestObject()
        {
            // Snippet: DeleteJobTrigger(DeleteJobTriggerRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteJobTriggerRequest request = new DeleteJobTriggerRequest
            {
                ProjectJobTriggerName = new ProjectJobTriggerName("[PROJECT]", "[JOB_TRIGGER]"),
            };
            // Make the request
            dlpServiceClient.DeleteJobTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobTriggerAsync</summary>
        public async Task UpdateJobTriggerAsync_RequestObject()
        {
            // Snippet: UpdateJobTriggerAsync(UpdateJobTriggerRequest,CallSettings)
            // Additional: UpdateJobTriggerAsync(UpdateJobTriggerRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                ProjectJobTriggerName = new ProjectJobTriggerName("[PROJECT]", "[JOB_TRIGGER]"),
            };
            // Make the request
            JobTrigger response = await dlpServiceClient.UpdateJobTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobTrigger</summary>
        public void UpdateJobTrigger_RequestObject()
        {
            // Snippet: UpdateJobTrigger(UpdateJobTriggerRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                ProjectJobTriggerName = new ProjectJobTriggerName("[PROJECT]", "[JOB_TRIGGER]"),
            };
            // Make the request
            JobTrigger response = dlpServiceClient.UpdateJobTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTriggerAsync</summary>
        public async Task CreateJobTriggerAsync_RequestObject()
        {
            // Snippet: CreateJobTriggerAsync(CreateJobTriggerRequest,CallSettings)
            // Additional: CreateJobTriggerAsync(CreateJobTriggerRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            JobTrigger response = await dlpServiceClient.CreateJobTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTrigger</summary>
        public void CreateJobTrigger_RequestObject()
        {
            // Snippet: CreateJobTrigger(CreateJobTriggerRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            JobTrigger response = dlpServiceClient.CreateJobTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoTypeAsync</summary>
        public async Task CreateStoredInfoTypeAsync_RequestObject()
        {
            // Snippet: CreateStoredInfoTypeAsync(CreateStoredInfoTypeRequest,CallSettings)
            // Additional: CreateStoredInfoTypeAsync(CreateStoredInfoTypeRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            // Make the request
            StoredInfoType response = await dlpServiceClient.CreateStoredInfoTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoType</summary>
        public void CreateStoredInfoType_RequestObject()
        {
            // Snippet: CreateStoredInfoType(CreateStoredInfoTypeRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            // Make the request
            StoredInfoType response = dlpServiceClient.CreateStoredInfoType(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateStoredInfoTypeAsync</summary>
        public async Task UpdateStoredInfoTypeAsync_RequestObject()
        {
            // Snippet: UpdateStoredInfoTypeAsync(UpdateStoredInfoTypeRequest,CallSettings)
            // Additional: UpdateStoredInfoTypeAsync(UpdateStoredInfoTypeRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateStoredInfoTypeRequest request = new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeNameOneof = StoredInfoTypeNameOneof.From(new OrganizationStoredInfoTypeName("[ORGANIZATION]", "[STORED_INFO_TYPE]")),
            };
            // Make the request
            StoredInfoType response = await dlpServiceClient.UpdateStoredInfoTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateStoredInfoType</summary>
        public void UpdateStoredInfoType_RequestObject()
        {
            // Snippet: UpdateStoredInfoType(UpdateStoredInfoTypeRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            UpdateStoredInfoTypeRequest request = new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeNameOneof = StoredInfoTypeNameOneof.From(new OrganizationStoredInfoTypeName("[ORGANIZATION]", "[STORED_INFO_TYPE]")),
            };
            // Make the request
            StoredInfoType response = dlpServiceClient.UpdateStoredInfoType(request);
            // End snippet
        }

        /// <summary>Snippet for GetStoredInfoTypeAsync</summary>
        public async Task GetStoredInfoTypeAsync_RequestObject()
        {
            // Snippet: GetStoredInfoTypeAsync(GetStoredInfoTypeRequest,CallSettings)
            // Additional: GetStoredInfoTypeAsync(GetStoredInfoTypeRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetStoredInfoTypeRequest request = new GetStoredInfoTypeRequest
            {
                StoredInfoTypeNameOneof = StoredInfoTypeNameOneof.From(new OrganizationStoredInfoTypeName("[ORGANIZATION]", "[STORED_INFO_TYPE]")),
            };
            // Make the request
            StoredInfoType response = await dlpServiceClient.GetStoredInfoTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStoredInfoType</summary>
        public void GetStoredInfoType_RequestObject()
        {
            // Snippet: GetStoredInfoType(GetStoredInfoTypeRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetStoredInfoTypeRequest request = new GetStoredInfoTypeRequest
            {
                StoredInfoTypeNameOneof = StoredInfoTypeNameOneof.From(new OrganizationStoredInfoTypeName("[ORGANIZATION]", "[STORED_INFO_TYPE]")),
            };
            // Make the request
            StoredInfoType response = dlpServiceClient.GetStoredInfoType(request);
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypesAsync</summary>
        public async Task ListStoredInfoTypesAsync_RequestObject()
        {
            // Snippet: ListStoredInfoTypesAsync(ListStoredInfoTypesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response =
                dlpServiceClient.ListStoredInfoTypesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StoredInfoType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStoredInfoTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoredInfoType item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoredInfoType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoredInfoType item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypes</summary>
        public void ListStoredInfoTypes_RequestObject()
        {
            // Snippet: ListStoredInfoTypes(ListStoredInfoTypesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response =
                dlpServiceClient.ListStoredInfoTypes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StoredInfoType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStoredInfoTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoredInfoType item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoredInfoType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoredInfoType item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteStoredInfoTypeAsync</summary>
        public async Task DeleteStoredInfoTypeAsync_RequestObject()
        {
            // Snippet: DeleteStoredInfoTypeAsync(DeleteStoredInfoTypeRequest,CallSettings)
            // Additional: DeleteStoredInfoTypeAsync(DeleteStoredInfoTypeRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteStoredInfoTypeRequest request = new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeNameOneof = StoredInfoTypeNameOneof.From(new OrganizationStoredInfoTypeName("[ORGANIZATION]", "[STORED_INFO_TYPE]")),
            };
            // Make the request
            await dlpServiceClient.DeleteStoredInfoTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteStoredInfoType</summary>
        public void DeleteStoredInfoType_RequestObject()
        {
            // Snippet: DeleteStoredInfoType(DeleteStoredInfoTypeRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteStoredInfoTypeRequest request = new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeNameOneof = StoredInfoTypeNameOneof.From(new OrganizationStoredInfoTypeName("[ORGANIZATION]", "[STORED_INFO_TYPE]")),
            };
            // Make the request
            dlpServiceClient.DeleteStoredInfoType(request);
            // End snippet
        }

    }
}
