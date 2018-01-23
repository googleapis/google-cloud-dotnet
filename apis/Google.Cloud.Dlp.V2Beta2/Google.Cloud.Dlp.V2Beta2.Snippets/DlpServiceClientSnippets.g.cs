// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Dlp.V2Beta2;
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

namespace Google.Cloud.Dlp.V2Beta2.Snippets
{
    /// <summary>Generated snippets</summary>
    public class GeneratedDlpServiceClientSnippets
    {
        /// <summary>Snippet for InspectContentAsync</summary>
        public async Task InspectContentAsync_RequestObject()
        {
            // Snippet: InspectContentAsync(InspectContentRequest,CallSettings)
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

        /// <summary>Snippet for InspectDataSourceAsync</summary>
        public async Task InspectDataSourceAsync_RequestObject()
        {
            // Snippet: InspectDataSourceAsync(InspectDataSourceRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectDataSourceRequest request = new InspectDataSourceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            DlpJob response = await dlpServiceClient.InspectDataSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for InspectDataSource</summary>
        public void InspectDataSource_RequestObject()
        {
            // Snippet: InspectDataSource(InspectDataSourceRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectDataSourceRequest request = new InspectDataSourceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            DlpJob response = dlpServiceClient.InspectDataSource(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeDataSourceRiskAsync</summary>
        public async Task AnalyzeDataSourceRiskAsync_RequestObject()
        {
            // Snippet: AnalyzeDataSourceRiskAsync(AnalyzeDataSourceRiskRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeDataSourceRiskRequest request = new AnalyzeDataSourceRiskRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            DlpJob response = await dlpServiceClient.AnalyzeDataSourceRiskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeDataSourceRisk</summary>
        public void AnalyzeDataSourceRisk_RequestObject()
        {
            // Snippet: AnalyzeDataSourceRisk(AnalyzeDataSourceRiskRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeDataSourceRiskRequest request = new AnalyzeDataSourceRiskRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            DlpJob response = dlpServiceClient.AnalyzeDataSourceRisk(request);
            // End snippet
        }

        /// <summary>Snippet for ListInfoTypesAsync</summary>
        public async Task ListInfoTypesAsync_RequestObject()
        {
            // Snippet: ListInfoTypesAsync(ListInfoTypesRequest,CallSettings)
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
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateNameOneof = InspectTemplateNameOneof.From(new InspectTemplateName("[ORGANIZATION]", "[INSPECT_TEMPLATE]")),
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
                InspectTemplateNameOneof = InspectTemplateNameOneof.From(new InspectTemplateName("[ORGANIZATION]", "[INSPECT_TEMPLATE]")),
            };
            // Make the request
            InspectTemplate response = dlpServiceClient.UpdateInspectTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetInspectTemplateAsync</summary>
        public async Task GetInspectTemplateAsync_RequestObject()
        {
            // Snippet: GetInspectTemplateAsync(GetInspectTemplateRequest,CallSettings)
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
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateNameOneof = InspectTemplateNameOneof.From(new InspectTemplateName("[ORGANIZATION]", "[INSPECT_TEMPLATE]")),
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
                InspectTemplateNameOneof = InspectTemplateNameOneof.From(new InspectTemplateName("[ORGANIZATION]", "[INSPECT_TEMPLATE]")),
            };
            // Make the request
            dlpServiceClient.DeleteInspectTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplateAsync</summary>
        public async Task CreateDeidentifyTemplateAsync_RequestObject()
        {
            // Snippet: CreateDeidentifyTemplateAsync(CreateDeidentifyTemplateRequest,CallSettings)
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
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new DeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
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
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new DeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.UpdateDeidentifyTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeidentifyTemplateAsync</summary>
        public async Task GetDeidentifyTemplateAsync_RequestObject()
        {
            // Snippet: GetDeidentifyTemplateAsync(GetDeidentifyTemplateRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new DeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
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
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new DeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
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
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new DeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
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
                DeidentifyTemplateNameOneof = DeidentifyTemplateNameOneof.From(new DeidentifyTemplateName("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]")),
            };
            // Make the request
            dlpServiceClient.DeleteDeidentifyTemplate(request);
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

    }
}
