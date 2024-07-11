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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Dlp.V2;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDlpServiceClientSnippets
    {
        /// <summary>Snippet for InspectContent</summary>
        public void InspectContentRequestObject()
        {
            // Snippet: InspectContent(InspectContentRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectContentRequest request = new InspectContentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                InspectConfig = new InspectConfig(),
                Item = new ContentItem(),
                InspectTemplateName = "",
                LocationId = "",
            };
            // Make the request
            InspectContentResponse response = dlpServiceClient.InspectContent(request);
            // End snippet
        }

        /// <summary>Snippet for InspectContentAsync</summary>
        public async Task InspectContentRequestObjectAsync()
        {
            // Snippet: InspectContentAsync(InspectContentRequest, CallSettings)
            // Additional: InspectContentAsync(InspectContentRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectContentRequest request = new InspectContentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                InspectConfig = new InspectConfig(),
                Item = new ContentItem(),
                InspectTemplateName = "",
                LocationId = "",
            };
            // Make the request
            InspectContentResponse response = await dlpServiceClient.InspectContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RedactImage</summary>
        public void RedactImageRequestObject()
        {
            // Snippet: RedactImage(RedactImageRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            RedactImageRequest request = new RedactImageRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                InspectConfig = new InspectConfig(),
                ImageRedactionConfigs =
                {
                    new RedactImageRequest.Types.ImageRedactionConfig(),
                },
                IncludeFindings = false,
                ByteItem = new ByteContentItem(),
                LocationId = "",
            };
            // Make the request
            RedactImageResponse response = dlpServiceClient.RedactImage(request);
            // End snippet
        }

        /// <summary>Snippet for RedactImageAsync</summary>
        public async Task RedactImageRequestObjectAsync()
        {
            // Snippet: RedactImageAsync(RedactImageRequest, CallSettings)
            // Additional: RedactImageAsync(RedactImageRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            RedactImageRequest request = new RedactImageRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                InspectConfig = new InspectConfig(),
                ImageRedactionConfigs =
                {
                    new RedactImageRequest.Types.ImageRedactionConfig(),
                },
                IncludeFindings = false,
                ByteItem = new ByteContentItem(),
                LocationId = "",
            };
            // Make the request
            RedactImageResponse response = await dlpServiceClient.RedactImageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeidentifyContent</summary>
        public void DeidentifyContentRequestObject()
        {
            // Snippet: DeidentifyContent(DeidentifyContentRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DeidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Item = new ContentItem(),
                InspectTemplateName = "",
                DeidentifyTemplateName = "",
                LocationId = "",
            };
            // Make the request
            DeidentifyContentResponse response = dlpServiceClient.DeidentifyContent(request);
            // End snippet
        }

        /// <summary>Snippet for DeidentifyContentAsync</summary>
        public async Task DeidentifyContentRequestObjectAsync()
        {
            // Snippet: DeidentifyContentAsync(DeidentifyContentRequest, CallSettings)
            // Additional: DeidentifyContentAsync(DeidentifyContentRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DeidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Item = new ContentItem(),
                InspectTemplateName = "",
                DeidentifyTemplateName = "",
                LocationId = "",
            };
            // Make the request
            DeidentifyContentResponse response = await dlpServiceClient.DeidentifyContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReidentifyContent</summary>
        public void ReidentifyContentRequestObject()
        {
            // Snippet: ReidentifyContent(ReidentifyContentRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ReidentifyContentRequest request = new ReidentifyContentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ReidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Item = new ContentItem(),
                InspectTemplateName = "",
                ReidentifyTemplateName = "",
                LocationId = "",
            };
            // Make the request
            ReidentifyContentResponse response = dlpServiceClient.ReidentifyContent(request);
            // End snippet
        }

        /// <summary>Snippet for ReidentifyContentAsync</summary>
        public async Task ReidentifyContentRequestObjectAsync()
        {
            // Snippet: ReidentifyContentAsync(ReidentifyContentRequest, CallSettings)
            // Additional: ReidentifyContentAsync(ReidentifyContentRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReidentifyContentRequest request = new ReidentifyContentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ReidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Item = new ContentItem(),
                InspectTemplateName = "",
                ReidentifyTemplateName = "",
                LocationId = "",
            };
            // Make the request
            ReidentifyContentResponse response = await dlpServiceClient.ReidentifyContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListInfoTypes</summary>
        public void ListInfoTypesRequestObject()
        {
            // Snippet: ListInfoTypes(ListInfoTypesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListInfoTypesRequest request = new ListInfoTypesRequest
            {
                LanguageCode = "",
                Filter = "",
                LocationId = "",
                Parent = "",
            };
            // Make the request
            ListInfoTypesResponse response = dlpServiceClient.ListInfoTypes(request);
            // End snippet
        }

        /// <summary>Snippet for ListInfoTypesAsync</summary>
        public async Task ListInfoTypesRequestObjectAsync()
        {
            // Snippet: ListInfoTypesAsync(ListInfoTypesRequest, CallSettings)
            // Additional: ListInfoTypesAsync(ListInfoTypesRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInfoTypesRequest request = new ListInfoTypesRequest
            {
                LanguageCode = "",
                Filter = "",
                LocationId = "",
                Parent = "",
            };
            // Make the request
            ListInfoTypesResponse response = await dlpServiceClient.ListInfoTypesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListInfoTypes</summary>
        public void ListInfoTypes()
        {
            // Snippet: ListInfoTypes(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            ListInfoTypesResponse response = dlpServiceClient.ListInfoTypes(parent);
            // End snippet
        }

        /// <summary>Snippet for ListInfoTypesAsync</summary>
        public async Task ListInfoTypesAsync()
        {
            // Snippet: ListInfoTypesAsync(string, CallSettings)
            // Additional: ListInfoTypesAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            ListInfoTypesResponse response = await dlpServiceClient.ListInfoTypesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplate</summary>
        public void CreateInspectTemplateRequestObject()
        {
            // Snippet: CreateInspectTemplate(CreateInspectTemplateRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
                TemplateId = "",
                LocationId = "",
            };
            // Make the request
            InspectTemplate response = dlpServiceClient.CreateInspectTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplateAsync</summary>
        public async Task CreateInspectTemplateRequestObjectAsync()
        {
            // Snippet: CreateInspectTemplateAsync(CreateInspectTemplateRequest, CallSettings)
            // Additional: CreateInspectTemplateAsync(CreateInspectTemplateRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateInspectTemplateRequest request = new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                InspectTemplate = new InspectTemplate(),
                TemplateId = "",
                LocationId = "",
            };
            // Make the request
            InspectTemplate response = await dlpServiceClient.CreateInspectTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplate</summary>
        public void CreateInspectTemplate()
        {
            // Snippet: CreateInspectTemplate(string, InspectTemplate, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            InspectTemplate inspectTemplate = new InspectTemplate();
            // Make the request
            InspectTemplate response = dlpServiceClient.CreateInspectTemplate(parent, inspectTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplateAsync</summary>
        public async Task CreateInspectTemplateAsync()
        {
            // Snippet: CreateInspectTemplateAsync(string, InspectTemplate, CallSettings)
            // Additional: CreateInspectTemplateAsync(string, InspectTemplate, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            InspectTemplate inspectTemplate = new InspectTemplate();
            // Make the request
            InspectTemplate response = await dlpServiceClient.CreateInspectTemplateAsync(parent, inspectTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplate</summary>
        public void CreateInspectTemplateResourceNames1()
        {
            // Snippet: CreateInspectTemplate(OrganizationName, InspectTemplate, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            InspectTemplate inspectTemplate = new InspectTemplate();
            // Make the request
            InspectTemplate response = dlpServiceClient.CreateInspectTemplate(parent, inspectTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplateAsync</summary>
        public async Task CreateInspectTemplateResourceNames1Async()
        {
            // Snippet: CreateInspectTemplateAsync(OrganizationName, InspectTemplate, CallSettings)
            // Additional: CreateInspectTemplateAsync(OrganizationName, InspectTemplate, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            InspectTemplate inspectTemplate = new InspectTemplate();
            // Make the request
            InspectTemplate response = await dlpServiceClient.CreateInspectTemplateAsync(parent, inspectTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplate</summary>
        public void CreateInspectTemplateResourceNames2()
        {
            // Snippet: CreateInspectTemplate(ProjectName, InspectTemplate, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            InspectTemplate inspectTemplate = new InspectTemplate();
            // Make the request
            InspectTemplate response = dlpServiceClient.CreateInspectTemplate(parent, inspectTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplateAsync</summary>
        public async Task CreateInspectTemplateResourceNames2Async()
        {
            // Snippet: CreateInspectTemplateAsync(ProjectName, InspectTemplate, CallSettings)
            // Additional: CreateInspectTemplateAsync(ProjectName, InspectTemplate, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            InspectTemplate inspectTemplate = new InspectTemplate();
            // Make the request
            InspectTemplate response = await dlpServiceClient.CreateInspectTemplateAsync(parent, inspectTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplate</summary>
        public void CreateInspectTemplateResourceNames3()
        {
            // Snippet: CreateInspectTemplate(OrganizationLocationName, InspectTemplate, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            InspectTemplate inspectTemplate = new InspectTemplate();
            // Make the request
            InspectTemplate response = dlpServiceClient.CreateInspectTemplate(parent, inspectTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplateAsync</summary>
        public async Task CreateInspectTemplateResourceNames3Async()
        {
            // Snippet: CreateInspectTemplateAsync(OrganizationLocationName, InspectTemplate, CallSettings)
            // Additional: CreateInspectTemplateAsync(OrganizationLocationName, InspectTemplate, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            InspectTemplate inspectTemplate = new InspectTemplate();
            // Make the request
            InspectTemplate response = await dlpServiceClient.CreateInspectTemplateAsync(parent, inspectTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplate</summary>
        public void CreateInspectTemplateResourceNames4()
        {
            // Snippet: CreateInspectTemplate(LocationName, InspectTemplate, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InspectTemplate inspectTemplate = new InspectTemplate();
            // Make the request
            InspectTemplate response = dlpServiceClient.CreateInspectTemplate(parent, inspectTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateInspectTemplateAsync</summary>
        public async Task CreateInspectTemplateResourceNames4Async()
        {
            // Snippet: CreateInspectTemplateAsync(LocationName, InspectTemplate, CallSettings)
            // Additional: CreateInspectTemplateAsync(LocationName, InspectTemplate, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InspectTemplate inspectTemplate = new InspectTemplate();
            // Make the request
            InspectTemplate response = await dlpServiceClient.CreateInspectTemplateAsync(parent, inspectTemplate);
            // End snippet
        }

        /// <summary>Snippet for UpdateInspectTemplate</summary>
        public void UpdateInspectTemplateRequestObject()
        {
            // Snippet: UpdateInspectTemplate(UpdateInspectTemplateRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                InspectTemplate = new InspectTemplate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            InspectTemplate response = dlpServiceClient.UpdateInspectTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateInspectTemplateAsync</summary>
        public async Task UpdateInspectTemplateRequestObjectAsync()
        {
            // Snippet: UpdateInspectTemplateAsync(UpdateInspectTemplateRequest, CallSettings)
            // Additional: UpdateInspectTemplateAsync(UpdateInspectTemplateRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInspectTemplateRequest request = new UpdateInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
                InspectTemplate = new InspectTemplate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            InspectTemplate response = await dlpServiceClient.UpdateInspectTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateInspectTemplate</summary>
        public void UpdateInspectTemplate()
        {
            // Snippet: UpdateInspectTemplate(string, InspectTemplate, FieldMask, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/inspectTemplates/[INSPECT_TEMPLATE]";
            InspectTemplate inspectTemplate = new InspectTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            InspectTemplate response = dlpServiceClient.UpdateInspectTemplate(name, inspectTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateInspectTemplateAsync</summary>
        public async Task UpdateInspectTemplateAsync()
        {
            // Snippet: UpdateInspectTemplateAsync(string, InspectTemplate, FieldMask, CallSettings)
            // Additional: UpdateInspectTemplateAsync(string, InspectTemplate, FieldMask, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/inspectTemplates/[INSPECT_TEMPLATE]";
            InspectTemplate inspectTemplate = new InspectTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            InspectTemplate response = await dlpServiceClient.UpdateInspectTemplateAsync(name, inspectTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateInspectTemplate</summary>
        public void UpdateInspectTemplateResourceNames()
        {
            // Snippet: UpdateInspectTemplate(InspectTemplateName, InspectTemplate, FieldMask, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectTemplateName name = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]");
            InspectTemplate inspectTemplate = new InspectTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            InspectTemplate response = dlpServiceClient.UpdateInspectTemplate(name, inspectTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateInspectTemplateAsync</summary>
        public async Task UpdateInspectTemplateResourceNamesAsync()
        {
            // Snippet: UpdateInspectTemplateAsync(InspectTemplateName, InspectTemplate, FieldMask, CallSettings)
            // Additional: UpdateInspectTemplateAsync(InspectTemplateName, InspectTemplate, FieldMask, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectTemplateName name = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]");
            InspectTemplate inspectTemplate = new InspectTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            InspectTemplate response = await dlpServiceClient.UpdateInspectTemplateAsync(name, inspectTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetInspectTemplate</summary>
        public void GetInspectTemplateRequestObject()
        {
            // Snippet: GetInspectTemplate(GetInspectTemplateRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetInspectTemplateRequest request = new GetInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            // Make the request
            InspectTemplate response = dlpServiceClient.GetInspectTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetInspectTemplateAsync</summary>
        public async Task GetInspectTemplateRequestObjectAsync()
        {
            // Snippet: GetInspectTemplateAsync(GetInspectTemplateRequest, CallSettings)
            // Additional: GetInspectTemplateAsync(GetInspectTemplateRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetInspectTemplateRequest request = new GetInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            // Make the request
            InspectTemplate response = await dlpServiceClient.GetInspectTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInspectTemplate</summary>
        public void GetInspectTemplate()
        {
            // Snippet: GetInspectTemplate(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/inspectTemplates/[INSPECT_TEMPLATE]";
            // Make the request
            InspectTemplate response = dlpServiceClient.GetInspectTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetInspectTemplateAsync</summary>
        public async Task GetInspectTemplateAsync()
        {
            // Snippet: GetInspectTemplateAsync(string, CallSettings)
            // Additional: GetInspectTemplateAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/inspectTemplates/[INSPECT_TEMPLATE]";
            // Make the request
            InspectTemplate response = await dlpServiceClient.GetInspectTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInspectTemplate</summary>
        public void GetInspectTemplateResourceNames()
        {
            // Snippet: GetInspectTemplate(InspectTemplateName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectTemplateName name = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]");
            // Make the request
            InspectTemplate response = dlpServiceClient.GetInspectTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetInspectTemplateAsync</summary>
        public async Task GetInspectTemplateResourceNamesAsync()
        {
            // Snippet: GetInspectTemplateAsync(InspectTemplateName, CallSettings)
            // Additional: GetInspectTemplateAsync(InspectTemplateName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectTemplateName name = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]");
            // Make the request
            InspectTemplate response = await dlpServiceClient.GetInspectTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplates</summary>
        public void ListInspectTemplatesRequestObject()
        {
            // Snippet: ListInspectTemplates(ListInspectTemplatesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                OrderBy = "",
                LocationId = "",
            };
            // Make the request
            PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> response = dlpServiceClient.ListInspectTemplates(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplatesAsync</summary>
        public async Task ListInspectTemplatesRequestObjectAsync()
        {
            // Snippet: ListInspectTemplatesAsync(ListInspectTemplatesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                OrderBy = "",
                LocationId = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> response = dlpServiceClient.ListInspectTemplatesAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplates</summary>
        public void ListInspectTemplates()
        {
            // Snippet: ListInspectTemplates(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> response = dlpServiceClient.ListInspectTemplates(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplatesAsync</summary>
        public async Task ListInspectTemplatesAsync()
        {
            // Snippet: ListInspectTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> response = dlpServiceClient.ListInspectTemplatesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplates</summary>
        public void ListInspectTemplatesResourceNames1()
        {
            // Snippet: ListInspectTemplates(OrganizationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> response = dlpServiceClient.ListInspectTemplates(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplatesAsync</summary>
        public async Task ListInspectTemplatesResourceNames1Async()
        {
            // Snippet: ListInspectTemplatesAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> response = dlpServiceClient.ListInspectTemplatesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplates</summary>
        public void ListInspectTemplatesResourceNames2()
        {
            // Snippet: ListInspectTemplates(ProjectName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> response = dlpServiceClient.ListInspectTemplates(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplatesAsync</summary>
        public async Task ListInspectTemplatesResourceNames2Async()
        {
            // Snippet: ListInspectTemplatesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> response = dlpServiceClient.ListInspectTemplatesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplates</summary>
        public void ListInspectTemplatesResourceNames3()
        {
            // Snippet: ListInspectTemplates(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> response = dlpServiceClient.ListInspectTemplates(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplatesAsync</summary>
        public async Task ListInspectTemplatesResourceNames3Async()
        {
            // Snippet: ListInspectTemplatesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> response = dlpServiceClient.ListInspectTemplatesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplates</summary>
        public void ListInspectTemplatesResourceNames4()
        {
            // Snippet: ListInspectTemplates(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> response = dlpServiceClient.ListInspectTemplates(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInspectTemplatesAsync</summary>
        public async Task ListInspectTemplatesResourceNames4Async()
        {
            // Snippet: ListInspectTemplatesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> response = dlpServiceClient.ListInspectTemplatesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteInspectTemplate</summary>
        public void DeleteInspectTemplateRequestObject()
        {
            // Snippet: DeleteInspectTemplate(DeleteInspectTemplateRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            // Make the request
            dlpServiceClient.DeleteInspectTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInspectTemplateAsync</summary>
        public async Task DeleteInspectTemplateRequestObjectAsync()
        {
            // Snippet: DeleteInspectTemplateAsync(DeleteInspectTemplateRequest, CallSettings)
            // Additional: DeleteInspectTemplateAsync(DeleteInspectTemplateRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInspectTemplateRequest request = new DeleteInspectTemplateRequest
            {
                InspectTemplateName = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]"),
            };
            // Make the request
            await dlpServiceClient.DeleteInspectTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInspectTemplate</summary>
        public void DeleteInspectTemplate()
        {
            // Snippet: DeleteInspectTemplate(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/inspectTemplates/[INSPECT_TEMPLATE]";
            // Make the request
            dlpServiceClient.DeleteInspectTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInspectTemplateAsync</summary>
        public async Task DeleteInspectTemplateAsync()
        {
            // Snippet: DeleteInspectTemplateAsync(string, CallSettings)
            // Additional: DeleteInspectTemplateAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/inspectTemplates/[INSPECT_TEMPLATE]";
            // Make the request
            await dlpServiceClient.DeleteInspectTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInspectTemplate</summary>
        public void DeleteInspectTemplateResourceNames()
        {
            // Snippet: DeleteInspectTemplate(InspectTemplateName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectTemplateName name = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]");
            // Make the request
            dlpServiceClient.DeleteInspectTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInspectTemplateAsync</summary>
        public async Task DeleteInspectTemplateResourceNamesAsync()
        {
            // Snippet: DeleteInspectTemplateAsync(InspectTemplateName, CallSettings)
            // Additional: DeleteInspectTemplateAsync(InspectTemplateName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectTemplateName name = InspectTemplateName.FromOrganizationInspectTemplate("[ORGANIZATION]", "[INSPECT_TEMPLATE]");
            // Make the request
            await dlpServiceClient.DeleteInspectTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplate</summary>
        public void CreateDeidentifyTemplateRequestObject()
        {
            // Snippet: CreateDeidentifyTemplate(CreateDeidentifyTemplateRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
                TemplateId = "",
                LocationId = "",
            };
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.CreateDeidentifyTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplateAsync</summary>
        public async Task CreateDeidentifyTemplateRequestObjectAsync()
        {
            // Snippet: CreateDeidentifyTemplateAsync(CreateDeidentifyTemplateRequest, CallSettings)
            // Additional: CreateDeidentifyTemplateAsync(CreateDeidentifyTemplateRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeidentifyTemplateRequest request = new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
                TemplateId = "",
                LocationId = "",
            };
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.CreateDeidentifyTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplate</summary>
        public void CreateDeidentifyTemplate()
        {
            // Snippet: CreateDeidentifyTemplate(string, DeidentifyTemplate, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.CreateDeidentifyTemplate(parent, deidentifyTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplateAsync</summary>
        public async Task CreateDeidentifyTemplateAsync()
        {
            // Snippet: CreateDeidentifyTemplateAsync(string, DeidentifyTemplate, CallSettings)
            // Additional: CreateDeidentifyTemplateAsync(string, DeidentifyTemplate, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.CreateDeidentifyTemplateAsync(parent, deidentifyTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplate</summary>
        public void CreateDeidentifyTemplateResourceNames1()
        {
            // Snippet: CreateDeidentifyTemplate(OrganizationName, DeidentifyTemplate, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.CreateDeidentifyTemplate(parent, deidentifyTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplateAsync</summary>
        public async Task CreateDeidentifyTemplateResourceNames1Async()
        {
            // Snippet: CreateDeidentifyTemplateAsync(OrganizationName, DeidentifyTemplate, CallSettings)
            // Additional: CreateDeidentifyTemplateAsync(OrganizationName, DeidentifyTemplate, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.CreateDeidentifyTemplateAsync(parent, deidentifyTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplate</summary>
        public void CreateDeidentifyTemplateResourceNames2()
        {
            // Snippet: CreateDeidentifyTemplate(ProjectName, DeidentifyTemplate, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.CreateDeidentifyTemplate(parent, deidentifyTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplateAsync</summary>
        public async Task CreateDeidentifyTemplateResourceNames2Async()
        {
            // Snippet: CreateDeidentifyTemplateAsync(ProjectName, DeidentifyTemplate, CallSettings)
            // Additional: CreateDeidentifyTemplateAsync(ProjectName, DeidentifyTemplate, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.CreateDeidentifyTemplateAsync(parent, deidentifyTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplate</summary>
        public void CreateDeidentifyTemplateResourceNames3()
        {
            // Snippet: CreateDeidentifyTemplate(OrganizationLocationName, DeidentifyTemplate, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.CreateDeidentifyTemplate(parent, deidentifyTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplateAsync</summary>
        public async Task CreateDeidentifyTemplateResourceNames3Async()
        {
            // Snippet: CreateDeidentifyTemplateAsync(OrganizationLocationName, DeidentifyTemplate, CallSettings)
            // Additional: CreateDeidentifyTemplateAsync(OrganizationLocationName, DeidentifyTemplate, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.CreateDeidentifyTemplateAsync(parent, deidentifyTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplate</summary>
        public void CreateDeidentifyTemplateResourceNames4()
        {
            // Snippet: CreateDeidentifyTemplate(LocationName, DeidentifyTemplate, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.CreateDeidentifyTemplate(parent, deidentifyTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateDeidentifyTemplateAsync</summary>
        public async Task CreateDeidentifyTemplateResourceNames4Async()
        {
            // Snippet: CreateDeidentifyTemplateAsync(LocationName, DeidentifyTemplate, CallSettings)
            // Additional: CreateDeidentifyTemplateAsync(LocationName, DeidentifyTemplate, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.CreateDeidentifyTemplateAsync(parent, deidentifyTemplate);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeidentifyTemplate</summary>
        public void UpdateDeidentifyTemplateRequestObject()
        {
            // Snippet: UpdateDeidentifyTemplate(UpdateDeidentifyTemplateRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.UpdateDeidentifyTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeidentifyTemplateAsync</summary>
        public async Task UpdateDeidentifyTemplateRequestObjectAsync()
        {
            // Snippet: UpdateDeidentifyTemplateAsync(UpdateDeidentifyTemplateRequest, CallSettings)
            // Additional: UpdateDeidentifyTemplateAsync(UpdateDeidentifyTemplateRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeidentifyTemplateRequest request = new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
                DeidentifyTemplate = new DeidentifyTemplate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.UpdateDeidentifyTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeidentifyTemplate</summary>
        public void UpdateDeidentifyTemplate()
        {
            // Snippet: UpdateDeidentifyTemplate(string, DeidentifyTemplate, FieldMask, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/deidentifyTemplates/[DEIDENTIFY_TEMPLATE]";
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.UpdateDeidentifyTemplate(name, deidentifyTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeidentifyTemplateAsync</summary>
        public async Task UpdateDeidentifyTemplateAsync()
        {
            // Snippet: UpdateDeidentifyTemplateAsync(string, DeidentifyTemplate, FieldMask, CallSettings)
            // Additional: UpdateDeidentifyTemplateAsync(string, DeidentifyTemplate, FieldMask, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/deidentifyTemplates/[DEIDENTIFY_TEMPLATE]";
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.UpdateDeidentifyTemplateAsync(name, deidentifyTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeidentifyTemplate</summary>
        public void UpdateDeidentifyTemplateResourceNames()
        {
            // Snippet: UpdateDeidentifyTemplate(DeidentifyTemplateName, DeidentifyTemplate, FieldMask, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeidentifyTemplateName name = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]");
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.UpdateDeidentifyTemplate(name, deidentifyTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeidentifyTemplateAsync</summary>
        public async Task UpdateDeidentifyTemplateResourceNamesAsync()
        {
            // Snippet: UpdateDeidentifyTemplateAsync(DeidentifyTemplateName, DeidentifyTemplate, FieldMask, CallSettings)
            // Additional: UpdateDeidentifyTemplateAsync(DeidentifyTemplateName, DeidentifyTemplate, FieldMask, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeidentifyTemplateName name = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]");
            DeidentifyTemplate deidentifyTemplate = new DeidentifyTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.UpdateDeidentifyTemplateAsync(name, deidentifyTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetDeidentifyTemplate</summary>
        public void GetDeidentifyTemplateRequestObject()
        {
            // Snippet: GetDeidentifyTemplate(GetDeidentifyTemplateRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.GetDeidentifyTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeidentifyTemplateAsync</summary>
        public async Task GetDeidentifyTemplateRequestObjectAsync()
        {
            // Snippet: GetDeidentifyTemplateAsync(GetDeidentifyTemplateRequest, CallSettings)
            // Additional: GetDeidentifyTemplateAsync(GetDeidentifyTemplateRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDeidentifyTemplateRequest request = new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.GetDeidentifyTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeidentifyTemplate</summary>
        public void GetDeidentifyTemplate()
        {
            // Snippet: GetDeidentifyTemplate(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/deidentifyTemplates/[DEIDENTIFY_TEMPLATE]";
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.GetDeidentifyTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeidentifyTemplateAsync</summary>
        public async Task GetDeidentifyTemplateAsync()
        {
            // Snippet: GetDeidentifyTemplateAsync(string, CallSettings)
            // Additional: GetDeidentifyTemplateAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/deidentifyTemplates/[DEIDENTIFY_TEMPLATE]";
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.GetDeidentifyTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeidentifyTemplate</summary>
        public void GetDeidentifyTemplateResourceNames()
        {
            // Snippet: GetDeidentifyTemplate(DeidentifyTemplateName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeidentifyTemplateName name = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]");
            // Make the request
            DeidentifyTemplate response = dlpServiceClient.GetDeidentifyTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeidentifyTemplateAsync</summary>
        public async Task GetDeidentifyTemplateResourceNamesAsync()
        {
            // Snippet: GetDeidentifyTemplateAsync(DeidentifyTemplateName, CallSettings)
            // Additional: GetDeidentifyTemplateAsync(DeidentifyTemplateName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeidentifyTemplateName name = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]");
            // Make the request
            DeidentifyTemplate response = await dlpServiceClient.GetDeidentifyTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplates</summary>
        public void ListDeidentifyTemplatesRequestObject()
        {
            // Snippet: ListDeidentifyTemplates(ListDeidentifyTemplatesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                OrderBy = "",
                LocationId = "",
            };
            // Make the request
            PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response = dlpServiceClient.ListDeidentifyTemplates(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplatesAsync</summary>
        public async Task ListDeidentifyTemplatesRequestObjectAsync()
        {
            // Snippet: ListDeidentifyTemplatesAsync(ListDeidentifyTemplatesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                OrderBy = "",
                LocationId = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response = dlpServiceClient.ListDeidentifyTemplatesAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplates</summary>
        public void ListDeidentifyTemplates()
        {
            // Snippet: ListDeidentifyTemplates(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response = dlpServiceClient.ListDeidentifyTemplates(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplatesAsync</summary>
        public async Task ListDeidentifyTemplatesAsync()
        {
            // Snippet: ListDeidentifyTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response = dlpServiceClient.ListDeidentifyTemplatesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplates</summary>
        public void ListDeidentifyTemplatesResourceNames1()
        {
            // Snippet: ListDeidentifyTemplates(OrganizationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response = dlpServiceClient.ListDeidentifyTemplates(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplatesAsync</summary>
        public async Task ListDeidentifyTemplatesResourceNames1Async()
        {
            // Snippet: ListDeidentifyTemplatesAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response = dlpServiceClient.ListDeidentifyTemplatesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplates</summary>
        public void ListDeidentifyTemplatesResourceNames2()
        {
            // Snippet: ListDeidentifyTemplates(ProjectName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response = dlpServiceClient.ListDeidentifyTemplates(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplatesAsync</summary>
        public async Task ListDeidentifyTemplatesResourceNames2Async()
        {
            // Snippet: ListDeidentifyTemplatesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response = dlpServiceClient.ListDeidentifyTemplatesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplates</summary>
        public void ListDeidentifyTemplatesResourceNames3()
        {
            // Snippet: ListDeidentifyTemplates(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response = dlpServiceClient.ListDeidentifyTemplates(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplatesAsync</summary>
        public async Task ListDeidentifyTemplatesResourceNames3Async()
        {
            // Snippet: ListDeidentifyTemplatesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response = dlpServiceClient.ListDeidentifyTemplatesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplates</summary>
        public void ListDeidentifyTemplatesResourceNames4()
        {
            // Snippet: ListDeidentifyTemplates(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response = dlpServiceClient.ListDeidentifyTemplates(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeidentifyTemplatesAsync</summary>
        public async Task ListDeidentifyTemplatesResourceNames4Async()
        {
            // Snippet: ListDeidentifyTemplatesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> response = dlpServiceClient.ListDeidentifyTemplatesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteDeidentifyTemplate</summary>
        public void DeleteDeidentifyTemplateRequestObject()
        {
            // Snippet: DeleteDeidentifyTemplate(DeleteDeidentifyTemplateRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            // Make the request
            dlpServiceClient.DeleteDeidentifyTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeidentifyTemplateAsync</summary>
        public async Task DeleteDeidentifyTemplateRequestObjectAsync()
        {
            // Snippet: DeleteDeidentifyTemplateAsync(DeleteDeidentifyTemplateRequest, CallSettings)
            // Additional: DeleteDeidentifyTemplateAsync(DeleteDeidentifyTemplateRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDeidentifyTemplateRequest request = new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]"),
            };
            // Make the request
            await dlpServiceClient.DeleteDeidentifyTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeidentifyTemplate</summary>
        public void DeleteDeidentifyTemplate()
        {
            // Snippet: DeleteDeidentifyTemplate(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/deidentifyTemplates/[DEIDENTIFY_TEMPLATE]";
            // Make the request
            dlpServiceClient.DeleteDeidentifyTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeidentifyTemplateAsync</summary>
        public async Task DeleteDeidentifyTemplateAsync()
        {
            // Snippet: DeleteDeidentifyTemplateAsync(string, CallSettings)
            // Additional: DeleteDeidentifyTemplateAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/deidentifyTemplates/[DEIDENTIFY_TEMPLATE]";
            // Make the request
            await dlpServiceClient.DeleteDeidentifyTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeidentifyTemplate</summary>
        public void DeleteDeidentifyTemplateResourceNames()
        {
            // Snippet: DeleteDeidentifyTemplate(DeidentifyTemplateName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeidentifyTemplateName name = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]");
            // Make the request
            dlpServiceClient.DeleteDeidentifyTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDeidentifyTemplateAsync</summary>
        public async Task DeleteDeidentifyTemplateResourceNamesAsync()
        {
            // Snippet: DeleteDeidentifyTemplateAsync(DeidentifyTemplateName, CallSettings)
            // Additional: DeleteDeidentifyTemplateAsync(DeidentifyTemplateName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeidentifyTemplateName name = DeidentifyTemplateName.FromOrganizationDeidentifyTemplate("[ORGANIZATION]", "[DEIDENTIFY_TEMPLATE]");
            // Make the request
            await dlpServiceClient.DeleteDeidentifyTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTrigger</summary>
        public void CreateJobTriggerRequestObject()
        {
            // Snippet: CreateJobTrigger(CreateJobTriggerRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                JobTrigger = new JobTrigger(),
                TriggerId = "",
                LocationId = "",
            };
            // Make the request
            JobTrigger response = dlpServiceClient.CreateJobTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTriggerAsync</summary>
        public async Task CreateJobTriggerRequestObjectAsync()
        {
            // Snippet: CreateJobTriggerAsync(CreateJobTriggerRequest, CallSettings)
            // Additional: CreateJobTriggerAsync(CreateJobTriggerRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateJobTriggerRequest request = new CreateJobTriggerRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                JobTrigger = new JobTrigger(),
                TriggerId = "",
                LocationId = "",
            };
            // Make the request
            JobTrigger response = await dlpServiceClient.CreateJobTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTrigger</summary>
        public void CreateJobTrigger()
        {
            // Snippet: CreateJobTrigger(string, JobTrigger, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            JobTrigger jobTrigger = new JobTrigger();
            // Make the request
            JobTrigger response = dlpServiceClient.CreateJobTrigger(parent, jobTrigger);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTriggerAsync</summary>
        public async Task CreateJobTriggerAsync()
        {
            // Snippet: CreateJobTriggerAsync(string, JobTrigger, CallSettings)
            // Additional: CreateJobTriggerAsync(string, JobTrigger, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            JobTrigger jobTrigger = new JobTrigger();
            // Make the request
            JobTrigger response = await dlpServiceClient.CreateJobTriggerAsync(parent, jobTrigger);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTrigger</summary>
        public void CreateJobTriggerResourceNames1()
        {
            // Snippet: CreateJobTrigger(ProjectName, JobTrigger, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            JobTrigger jobTrigger = new JobTrigger();
            // Make the request
            JobTrigger response = dlpServiceClient.CreateJobTrigger(parent, jobTrigger);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTriggerAsync</summary>
        public async Task CreateJobTriggerResourceNames1Async()
        {
            // Snippet: CreateJobTriggerAsync(ProjectName, JobTrigger, CallSettings)
            // Additional: CreateJobTriggerAsync(ProjectName, JobTrigger, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            JobTrigger jobTrigger = new JobTrigger();
            // Make the request
            JobTrigger response = await dlpServiceClient.CreateJobTriggerAsync(parent, jobTrigger);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTrigger</summary>
        public void CreateJobTriggerResourceNames2()
        {
            // Snippet: CreateJobTrigger(LocationName, JobTrigger, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            JobTrigger jobTrigger = new JobTrigger();
            // Make the request
            JobTrigger response = dlpServiceClient.CreateJobTrigger(parent, jobTrigger);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTriggerAsync</summary>
        public async Task CreateJobTriggerResourceNames2Async()
        {
            // Snippet: CreateJobTriggerAsync(LocationName, JobTrigger, CallSettings)
            // Additional: CreateJobTriggerAsync(LocationName, JobTrigger, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            JobTrigger jobTrigger = new JobTrigger();
            // Make the request
            JobTrigger response = await dlpServiceClient.CreateJobTriggerAsync(parent, jobTrigger);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobTrigger</summary>
        public void UpdateJobTriggerRequestObject()
        {
            // Snippet: UpdateJobTrigger(UpdateJobTriggerRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                JobTrigger = new JobTrigger(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            JobTrigger response = dlpServiceClient.UpdateJobTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobTriggerAsync</summary>
        public async Task UpdateJobTriggerRequestObjectAsync()
        {
            // Snippet: UpdateJobTriggerAsync(UpdateJobTriggerRequest, CallSettings)
            // Additional: UpdateJobTriggerAsync(UpdateJobTriggerRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateJobTriggerRequest request = new UpdateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                JobTrigger = new JobTrigger(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            JobTrigger response = await dlpServiceClient.UpdateJobTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobTrigger</summary>
        public void UpdateJobTrigger()
        {
            // Snippet: UpdateJobTrigger(string, JobTrigger, FieldMask, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/jobTriggers/[JOB_TRIGGER]";
            JobTrigger jobTrigger = new JobTrigger();
            FieldMask updateMask = new FieldMask();
            // Make the request
            JobTrigger response = dlpServiceClient.UpdateJobTrigger(name, jobTrigger, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobTriggerAsync</summary>
        public async Task UpdateJobTriggerAsync()
        {
            // Snippet: UpdateJobTriggerAsync(string, JobTrigger, FieldMask, CallSettings)
            // Additional: UpdateJobTriggerAsync(string, JobTrigger, FieldMask, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/jobTriggers/[JOB_TRIGGER]";
            JobTrigger jobTrigger = new JobTrigger();
            FieldMask updateMask = new FieldMask();
            // Make the request
            JobTrigger response = await dlpServiceClient.UpdateJobTriggerAsync(name, jobTrigger, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobTrigger</summary>
        public void UpdateJobTriggerResourceNames()
        {
            // Snippet: UpdateJobTrigger(JobTriggerName, JobTrigger, FieldMask, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            JobTriggerName name = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]");
            JobTrigger jobTrigger = new JobTrigger();
            FieldMask updateMask = new FieldMask();
            // Make the request
            JobTrigger response = dlpServiceClient.UpdateJobTrigger(name, jobTrigger, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobTriggerAsync</summary>
        public async Task UpdateJobTriggerResourceNamesAsync()
        {
            // Snippet: UpdateJobTriggerAsync(JobTriggerName, JobTrigger, FieldMask, CallSettings)
            // Additional: UpdateJobTriggerAsync(JobTriggerName, JobTrigger, FieldMask, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobTriggerName name = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]");
            JobTrigger jobTrigger = new JobTrigger();
            FieldMask updateMask = new FieldMask();
            // Make the request
            JobTrigger response = await dlpServiceClient.UpdateJobTriggerAsync(name, jobTrigger, updateMask);
            // End snippet
        }

        /// <summary>Snippet for HybridInspectJobTrigger</summary>
        public void HybridInspectJobTriggerRequestObject()
        {
            // Snippet: HybridInspectJobTrigger(HybridInspectJobTriggerRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            HybridInspectJobTriggerRequest request = new HybridInspectJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                HybridItem = new HybridContentItem(),
            };
            // Make the request
            HybridInspectResponse response = dlpServiceClient.HybridInspectJobTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for HybridInspectJobTriggerAsync</summary>
        public async Task HybridInspectJobTriggerRequestObjectAsync()
        {
            // Snippet: HybridInspectJobTriggerAsync(HybridInspectJobTriggerRequest, CallSettings)
            // Additional: HybridInspectJobTriggerAsync(HybridInspectJobTriggerRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            HybridInspectJobTriggerRequest request = new HybridInspectJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
                HybridItem = new HybridContentItem(),
            };
            // Make the request
            HybridInspectResponse response = await dlpServiceClient.HybridInspectJobTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for HybridInspectJobTrigger</summary>
        public void HybridInspectJobTrigger()
        {
            // Snippet: HybridInspectJobTrigger(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/jobTriggers/[JOB_TRIGGER]";
            // Make the request
            HybridInspectResponse response = dlpServiceClient.HybridInspectJobTrigger(name);
            // End snippet
        }

        /// <summary>Snippet for HybridInspectJobTriggerAsync</summary>
        public async Task HybridInspectJobTriggerAsync()
        {
            // Snippet: HybridInspectJobTriggerAsync(string, CallSettings)
            // Additional: HybridInspectJobTriggerAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/jobTriggers/[JOB_TRIGGER]";
            // Make the request
            HybridInspectResponse response = await dlpServiceClient.HybridInspectJobTriggerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for HybridInspectJobTrigger</summary>
        public void HybridInspectJobTriggerResourceNames()
        {
            // Snippet: HybridInspectJobTrigger(JobTriggerName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            JobTriggerName name = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]");
            // Make the request
            HybridInspectResponse response = dlpServiceClient.HybridInspectJobTrigger(name);
            // End snippet
        }

        /// <summary>Snippet for HybridInspectJobTriggerAsync</summary>
        public async Task HybridInspectJobTriggerResourceNamesAsync()
        {
            // Snippet: HybridInspectJobTriggerAsync(JobTriggerName, CallSettings)
            // Additional: HybridInspectJobTriggerAsync(JobTriggerName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobTriggerName name = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]");
            // Make the request
            HybridInspectResponse response = await dlpServiceClient.HybridInspectJobTriggerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobTrigger</summary>
        public void GetJobTriggerRequestObject()
        {
            // Snippet: GetJobTrigger(GetJobTriggerRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetJobTriggerRequest request = new GetJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            // Make the request
            JobTrigger response = dlpServiceClient.GetJobTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobTriggerAsync</summary>
        public async Task GetJobTriggerRequestObjectAsync()
        {
            // Snippet: GetJobTriggerAsync(GetJobTriggerRequest, CallSettings)
            // Additional: GetJobTriggerAsync(GetJobTriggerRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetJobTriggerRequest request = new GetJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            // Make the request
            JobTrigger response = await dlpServiceClient.GetJobTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobTrigger</summary>
        public void GetJobTrigger()
        {
            // Snippet: GetJobTrigger(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/jobTriggers/[JOB_TRIGGER]";
            // Make the request
            JobTrigger response = dlpServiceClient.GetJobTrigger(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobTriggerAsync</summary>
        public async Task GetJobTriggerAsync()
        {
            // Snippet: GetJobTriggerAsync(string, CallSettings)
            // Additional: GetJobTriggerAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/jobTriggers/[JOB_TRIGGER]";
            // Make the request
            JobTrigger response = await dlpServiceClient.GetJobTriggerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobTrigger</summary>
        public void GetJobTriggerResourceNames()
        {
            // Snippet: GetJobTrigger(JobTriggerName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            JobTriggerName name = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]");
            // Make the request
            JobTrigger response = dlpServiceClient.GetJobTrigger(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobTriggerAsync</summary>
        public async Task GetJobTriggerResourceNamesAsync()
        {
            // Snippet: GetJobTriggerAsync(JobTriggerName, CallSettings)
            // Additional: GetJobTriggerAsync(JobTriggerName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobTriggerName name = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]");
            // Make the request
            JobTrigger response = await dlpServiceClient.GetJobTriggerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListJobTriggers</summary>
        public void ListJobTriggersRequestObject()
        {
            // Snippet: ListJobTriggers(ListJobTriggersRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListJobTriggersRequest request = new ListJobTriggersRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                OrderBy = "",
                Filter = "",
                Type = DlpJobType.Unspecified,
                LocationId = "",
            };
            // Make the request
            PagedEnumerable<ListJobTriggersResponse, JobTrigger> response = dlpServiceClient.ListJobTriggers(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTriggersAsync</summary>
        public async Task ListJobTriggersRequestObjectAsync()
        {
            // Snippet: ListJobTriggersAsync(ListJobTriggersRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListJobTriggersRequest request = new ListJobTriggersRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                OrderBy = "",
                Filter = "",
                Type = DlpJobType.Unspecified,
                LocationId = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> response = dlpServiceClient.ListJobTriggersAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTriggers</summary>
        public void ListJobTriggers()
        {
            // Snippet: ListJobTriggers(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListJobTriggersResponse, JobTrigger> response = dlpServiceClient.ListJobTriggers(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTriggersAsync</summary>
        public async Task ListJobTriggersAsync()
        {
            // Snippet: ListJobTriggersAsync(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> response = dlpServiceClient.ListJobTriggersAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTriggers</summary>
        public void ListJobTriggersResourceNames1()
        {
            // Snippet: ListJobTriggers(ProjectName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListJobTriggersResponse, JobTrigger> response = dlpServiceClient.ListJobTriggers(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTriggersAsync</summary>
        public async Task ListJobTriggersResourceNames1Async()
        {
            // Snippet: ListJobTriggersAsync(ProjectName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> response = dlpServiceClient.ListJobTriggersAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTriggers</summary>
        public void ListJobTriggersResourceNames2()
        {
            // Snippet: ListJobTriggers(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListJobTriggersResponse, JobTrigger> response = dlpServiceClient.ListJobTriggers(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTriggersAsync</summary>
        public async Task ListJobTriggersResourceNames2Async()
        {
            // Snippet: ListJobTriggersAsync(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> response = dlpServiceClient.ListJobTriggersAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTrigger</summary>
        public void DeleteJobTriggerRequestObject()
        {
            // Snippet: DeleteJobTrigger(DeleteJobTriggerRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteJobTriggerRequest request = new DeleteJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            // Make the request
            dlpServiceClient.DeleteJobTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTriggerAsync</summary>
        public async Task DeleteJobTriggerRequestObjectAsync()
        {
            // Snippet: DeleteJobTriggerAsync(DeleteJobTriggerRequest, CallSettings)
            // Additional: DeleteJobTriggerAsync(DeleteJobTriggerRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteJobTriggerRequest request = new DeleteJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            // Make the request
            await dlpServiceClient.DeleteJobTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTrigger</summary>
        public void DeleteJobTrigger()
        {
            // Snippet: DeleteJobTrigger(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/jobTriggers/[JOB_TRIGGER]";
            // Make the request
            dlpServiceClient.DeleteJobTrigger(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTriggerAsync</summary>
        public async Task DeleteJobTriggerAsync()
        {
            // Snippet: DeleteJobTriggerAsync(string, CallSettings)
            // Additional: DeleteJobTriggerAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/jobTriggers/[JOB_TRIGGER]";
            // Make the request
            await dlpServiceClient.DeleteJobTriggerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTrigger</summary>
        public void DeleteJobTriggerResourceNames()
        {
            // Snippet: DeleteJobTrigger(JobTriggerName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            JobTriggerName name = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]");
            // Make the request
            dlpServiceClient.DeleteJobTrigger(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTriggerAsync</summary>
        public async Task DeleteJobTriggerResourceNamesAsync()
        {
            // Snippet: DeleteJobTriggerAsync(JobTriggerName, CallSettings)
            // Additional: DeleteJobTriggerAsync(JobTriggerName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobTriggerName name = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]");
            // Make the request
            await dlpServiceClient.DeleteJobTriggerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ActivateJobTrigger</summary>
        public void ActivateJobTriggerRequestObject()
        {
            // Snippet: ActivateJobTrigger(ActivateJobTriggerRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ActivateJobTriggerRequest request = new ActivateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            // Make the request
            DlpJob response = dlpServiceClient.ActivateJobTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for ActivateJobTriggerAsync</summary>
        public async Task ActivateJobTriggerRequestObjectAsync()
        {
            // Snippet: ActivateJobTriggerAsync(ActivateJobTriggerRequest, CallSettings)
            // Additional: ActivateJobTriggerAsync(ActivateJobTriggerRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ActivateJobTriggerRequest request = new ActivateJobTriggerRequest
            {
                JobTriggerName = JobTriggerName.FromProjectJobTrigger("[PROJECT]", "[JOB_TRIGGER]"),
            };
            // Make the request
            DlpJob response = await dlpServiceClient.ActivateJobTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDiscoveryConfig</summary>
        public void CreateDiscoveryConfigRequestObject()
        {
            // Snippet: CreateDiscoveryConfig(CreateDiscoveryConfigRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateDiscoveryConfigRequest request = new CreateDiscoveryConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DiscoveryConfig = new DiscoveryConfig(),
                ConfigId = "",
            };
            // Make the request
            DiscoveryConfig response = dlpServiceClient.CreateDiscoveryConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDiscoveryConfigAsync</summary>
        public async Task CreateDiscoveryConfigRequestObjectAsync()
        {
            // Snippet: CreateDiscoveryConfigAsync(CreateDiscoveryConfigRequest, CallSettings)
            // Additional: CreateDiscoveryConfigAsync(CreateDiscoveryConfigRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDiscoveryConfigRequest request = new CreateDiscoveryConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DiscoveryConfig = new DiscoveryConfig(),
                ConfigId = "",
            };
            // Make the request
            DiscoveryConfig response = await dlpServiceClient.CreateDiscoveryConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDiscoveryConfig</summary>
        public void CreateDiscoveryConfig()
        {
            // Snippet: CreateDiscoveryConfig(string, DiscoveryConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DiscoveryConfig discoveryConfig = new DiscoveryConfig();
            // Make the request
            DiscoveryConfig response = dlpServiceClient.CreateDiscoveryConfig(parent, discoveryConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateDiscoveryConfigAsync</summary>
        public async Task CreateDiscoveryConfigAsync()
        {
            // Snippet: CreateDiscoveryConfigAsync(string, DiscoveryConfig, CallSettings)
            // Additional: CreateDiscoveryConfigAsync(string, DiscoveryConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DiscoveryConfig discoveryConfig = new DiscoveryConfig();
            // Make the request
            DiscoveryConfig response = await dlpServiceClient.CreateDiscoveryConfigAsync(parent, discoveryConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateDiscoveryConfig</summary>
        public void CreateDiscoveryConfigResourceNames()
        {
            // Snippet: CreateDiscoveryConfig(LocationName, DiscoveryConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DiscoveryConfig discoveryConfig = new DiscoveryConfig();
            // Make the request
            DiscoveryConfig response = dlpServiceClient.CreateDiscoveryConfig(parent, discoveryConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateDiscoveryConfigAsync</summary>
        public async Task CreateDiscoveryConfigResourceNamesAsync()
        {
            // Snippet: CreateDiscoveryConfigAsync(LocationName, DiscoveryConfig, CallSettings)
            // Additional: CreateDiscoveryConfigAsync(LocationName, DiscoveryConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DiscoveryConfig discoveryConfig = new DiscoveryConfig();
            // Make the request
            DiscoveryConfig response = await dlpServiceClient.CreateDiscoveryConfigAsync(parent, discoveryConfig);
            // End snippet
        }

        /// <summary>Snippet for UpdateDiscoveryConfig</summary>
        public void UpdateDiscoveryConfigRequestObject()
        {
            // Snippet: UpdateDiscoveryConfig(UpdateDiscoveryConfigRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            UpdateDiscoveryConfigRequest request = new UpdateDiscoveryConfigRequest
            {
                DiscoveryConfigName = DiscoveryConfigName.FromProjectLocationDiscoveryConfig("[PROJECT]", "[LOCATION]", "[DISCOVERY_CONFIG]"),
                DiscoveryConfig = new DiscoveryConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DiscoveryConfig response = dlpServiceClient.UpdateDiscoveryConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDiscoveryConfigAsync</summary>
        public async Task UpdateDiscoveryConfigRequestObjectAsync()
        {
            // Snippet: UpdateDiscoveryConfigAsync(UpdateDiscoveryConfigRequest, CallSettings)
            // Additional: UpdateDiscoveryConfigAsync(UpdateDiscoveryConfigRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDiscoveryConfigRequest request = new UpdateDiscoveryConfigRequest
            {
                DiscoveryConfigName = DiscoveryConfigName.FromProjectLocationDiscoveryConfig("[PROJECT]", "[LOCATION]", "[DISCOVERY_CONFIG]"),
                DiscoveryConfig = new DiscoveryConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DiscoveryConfig response = await dlpServiceClient.UpdateDiscoveryConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDiscoveryConfig</summary>
        public void UpdateDiscoveryConfig()
        {
            // Snippet: UpdateDiscoveryConfig(string, DiscoveryConfig, FieldMask, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveryConfigs/[DISCOVERY_CONFIG]";
            DiscoveryConfig discoveryConfig = new DiscoveryConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DiscoveryConfig response = dlpServiceClient.UpdateDiscoveryConfig(name, discoveryConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDiscoveryConfigAsync</summary>
        public async Task UpdateDiscoveryConfigAsync()
        {
            // Snippet: UpdateDiscoveryConfigAsync(string, DiscoveryConfig, FieldMask, CallSettings)
            // Additional: UpdateDiscoveryConfigAsync(string, DiscoveryConfig, FieldMask, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveryConfigs/[DISCOVERY_CONFIG]";
            DiscoveryConfig discoveryConfig = new DiscoveryConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DiscoveryConfig response = await dlpServiceClient.UpdateDiscoveryConfigAsync(name, discoveryConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDiscoveryConfig</summary>
        public void UpdateDiscoveryConfigResourceNames()
        {
            // Snippet: UpdateDiscoveryConfig(DiscoveryConfigName, DiscoveryConfig, FieldMask, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DiscoveryConfigName name = DiscoveryConfigName.FromProjectLocationDiscoveryConfig("[PROJECT]", "[LOCATION]", "[DISCOVERY_CONFIG]");
            DiscoveryConfig discoveryConfig = new DiscoveryConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DiscoveryConfig response = dlpServiceClient.UpdateDiscoveryConfig(name, discoveryConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDiscoveryConfigAsync</summary>
        public async Task UpdateDiscoveryConfigResourceNamesAsync()
        {
            // Snippet: UpdateDiscoveryConfigAsync(DiscoveryConfigName, DiscoveryConfig, FieldMask, CallSettings)
            // Additional: UpdateDiscoveryConfigAsync(DiscoveryConfigName, DiscoveryConfig, FieldMask, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DiscoveryConfigName name = DiscoveryConfigName.FromProjectLocationDiscoveryConfig("[PROJECT]", "[LOCATION]", "[DISCOVERY_CONFIG]");
            DiscoveryConfig discoveryConfig = new DiscoveryConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DiscoveryConfig response = await dlpServiceClient.UpdateDiscoveryConfigAsync(name, discoveryConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveryConfig</summary>
        public void GetDiscoveryConfigRequestObject()
        {
            // Snippet: GetDiscoveryConfig(GetDiscoveryConfigRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetDiscoveryConfigRequest request = new GetDiscoveryConfigRequest
            {
                DiscoveryConfigName = DiscoveryConfigName.FromProjectLocationDiscoveryConfig("[PROJECT]", "[LOCATION]", "[DISCOVERY_CONFIG]"),
            };
            // Make the request
            DiscoveryConfig response = dlpServiceClient.GetDiscoveryConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveryConfigAsync</summary>
        public async Task GetDiscoveryConfigRequestObjectAsync()
        {
            // Snippet: GetDiscoveryConfigAsync(GetDiscoveryConfigRequest, CallSettings)
            // Additional: GetDiscoveryConfigAsync(GetDiscoveryConfigRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDiscoveryConfigRequest request = new GetDiscoveryConfigRequest
            {
                DiscoveryConfigName = DiscoveryConfigName.FromProjectLocationDiscoveryConfig("[PROJECT]", "[LOCATION]", "[DISCOVERY_CONFIG]"),
            };
            // Make the request
            DiscoveryConfig response = await dlpServiceClient.GetDiscoveryConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveryConfig</summary>
        public void GetDiscoveryConfig()
        {
            // Snippet: GetDiscoveryConfig(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveryConfigs/[DISCOVERY_CONFIG]";
            // Make the request
            DiscoveryConfig response = dlpServiceClient.GetDiscoveryConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveryConfigAsync</summary>
        public async Task GetDiscoveryConfigAsync()
        {
            // Snippet: GetDiscoveryConfigAsync(string, CallSettings)
            // Additional: GetDiscoveryConfigAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveryConfigs/[DISCOVERY_CONFIG]";
            // Make the request
            DiscoveryConfig response = await dlpServiceClient.GetDiscoveryConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveryConfig</summary>
        public void GetDiscoveryConfigResourceNames()
        {
            // Snippet: GetDiscoveryConfig(DiscoveryConfigName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DiscoveryConfigName name = DiscoveryConfigName.FromProjectLocationDiscoveryConfig("[PROJECT]", "[LOCATION]", "[DISCOVERY_CONFIG]");
            // Make the request
            DiscoveryConfig response = dlpServiceClient.GetDiscoveryConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveryConfigAsync</summary>
        public async Task GetDiscoveryConfigResourceNamesAsync()
        {
            // Snippet: GetDiscoveryConfigAsync(DiscoveryConfigName, CallSettings)
            // Additional: GetDiscoveryConfigAsync(DiscoveryConfigName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DiscoveryConfigName name = DiscoveryConfigName.FromProjectLocationDiscoveryConfig("[PROJECT]", "[LOCATION]", "[DISCOVERY_CONFIG]");
            // Make the request
            DiscoveryConfig response = await dlpServiceClient.GetDiscoveryConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveryConfigs</summary>
        public void ListDiscoveryConfigsRequestObject()
        {
            // Snippet: ListDiscoveryConfigs(ListDiscoveryConfigsRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListDiscoveryConfigsRequest request = new ListDiscoveryConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> response = dlpServiceClient.ListDiscoveryConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveryConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveryConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveryConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveryConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveryConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveryConfigsAsync</summary>
        public async Task ListDiscoveryConfigsRequestObjectAsync()
        {
            // Snippet: ListDiscoveryConfigsAsync(ListDiscoveryConfigsRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDiscoveryConfigsRequest request = new ListDiscoveryConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> response = dlpServiceClient.ListDiscoveryConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveryConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveryConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveryConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveryConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveryConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveryConfigs</summary>
        public void ListDiscoveryConfigs()
        {
            // Snippet: ListDiscoveryConfigs(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> response = dlpServiceClient.ListDiscoveryConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveryConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveryConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveryConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveryConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveryConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveryConfigsAsync</summary>
        public async Task ListDiscoveryConfigsAsync()
        {
            // Snippet: ListDiscoveryConfigsAsync(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> response = dlpServiceClient.ListDiscoveryConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveryConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveryConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveryConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveryConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveryConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveryConfigs</summary>
        public void ListDiscoveryConfigsResourceNames()
        {
            // Snippet: ListDiscoveryConfigs(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> response = dlpServiceClient.ListDiscoveryConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveryConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveryConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveryConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveryConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveryConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveryConfigsAsync</summary>
        public async Task ListDiscoveryConfigsResourceNamesAsync()
        {
            // Snippet: ListDiscoveryConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> response = dlpServiceClient.ListDiscoveryConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveryConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveryConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveryConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveryConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveryConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteDiscoveryConfig</summary>
        public void DeleteDiscoveryConfigRequestObject()
        {
            // Snippet: DeleteDiscoveryConfig(DeleteDiscoveryConfigRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteDiscoveryConfigRequest request = new DeleteDiscoveryConfigRequest
            {
                DiscoveryConfigName = DiscoveryConfigName.FromProjectLocationDiscoveryConfig("[PROJECT]", "[LOCATION]", "[DISCOVERY_CONFIG]"),
            };
            // Make the request
            dlpServiceClient.DeleteDiscoveryConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDiscoveryConfigAsync</summary>
        public async Task DeleteDiscoveryConfigRequestObjectAsync()
        {
            // Snippet: DeleteDiscoveryConfigAsync(DeleteDiscoveryConfigRequest, CallSettings)
            // Additional: DeleteDiscoveryConfigAsync(DeleteDiscoveryConfigRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDiscoveryConfigRequest request = new DeleteDiscoveryConfigRequest
            {
                DiscoveryConfigName = DiscoveryConfigName.FromProjectLocationDiscoveryConfig("[PROJECT]", "[LOCATION]", "[DISCOVERY_CONFIG]"),
            };
            // Make the request
            await dlpServiceClient.DeleteDiscoveryConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDiscoveryConfig</summary>
        public void DeleteDiscoveryConfig()
        {
            // Snippet: DeleteDiscoveryConfig(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveryConfigs/[DISCOVERY_CONFIG]";
            // Make the request
            dlpServiceClient.DeleteDiscoveryConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDiscoveryConfigAsync</summary>
        public async Task DeleteDiscoveryConfigAsync()
        {
            // Snippet: DeleteDiscoveryConfigAsync(string, CallSettings)
            // Additional: DeleteDiscoveryConfigAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveryConfigs/[DISCOVERY_CONFIG]";
            // Make the request
            await dlpServiceClient.DeleteDiscoveryConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDiscoveryConfig</summary>
        public void DeleteDiscoveryConfigResourceNames()
        {
            // Snippet: DeleteDiscoveryConfig(DiscoveryConfigName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DiscoveryConfigName name = DiscoveryConfigName.FromProjectLocationDiscoveryConfig("[PROJECT]", "[LOCATION]", "[DISCOVERY_CONFIG]");
            // Make the request
            dlpServiceClient.DeleteDiscoveryConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDiscoveryConfigAsync</summary>
        public async Task DeleteDiscoveryConfigResourceNamesAsync()
        {
            // Snippet: DeleteDiscoveryConfigAsync(DiscoveryConfigName, CallSettings)
            // Additional: DeleteDiscoveryConfigAsync(DiscoveryConfigName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DiscoveryConfigName name = DiscoveryConfigName.FromProjectLocationDiscoveryConfig("[PROJECT]", "[LOCATION]", "[DISCOVERY_CONFIG]");
            // Make the request
            await dlpServiceClient.DeleteDiscoveryConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJob</summary>
        public void CreateDlpJobRequestObject()
        {
            // Snippet: CreateDlpJob(CreateDlpJobRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                InspectJob = new InspectJobConfig(),
                JobId = "",
                LocationId = "",
            };
            // Make the request
            DlpJob response = dlpServiceClient.CreateDlpJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJobAsync</summary>
        public async Task CreateDlpJobRequestObjectAsync()
        {
            // Snippet: CreateDlpJobAsync(CreateDlpJobRequest, CallSettings)
            // Additional: CreateDlpJobAsync(CreateDlpJobRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDlpJobRequest request = new CreateDlpJobRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                InspectJob = new InspectJobConfig(),
                JobId = "",
                LocationId = "",
            };
            // Make the request
            DlpJob response = await dlpServiceClient.CreateDlpJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJob</summary>
        public void CreateDlpJob1()
        {
            // Snippet: CreateDlpJob(string, InspectJobConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            InspectJobConfig inspectJob = new InspectJobConfig();
            // Make the request
            DlpJob response = dlpServiceClient.CreateDlpJob(parent, inspectJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJobAsync</summary>
        public async Task CreateDlpJob1Async()
        {
            // Snippet: CreateDlpJobAsync(string, InspectJobConfig, CallSettings)
            // Additional: CreateDlpJobAsync(string, InspectJobConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            InspectJobConfig inspectJob = new InspectJobConfig();
            // Make the request
            DlpJob response = await dlpServiceClient.CreateDlpJobAsync(parent, inspectJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJob</summary>
        public void CreateDlpJob1ResourceNames1()
        {
            // Snippet: CreateDlpJob(ProjectName, InspectJobConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            InspectJobConfig inspectJob = new InspectJobConfig();
            // Make the request
            DlpJob response = dlpServiceClient.CreateDlpJob(parent, inspectJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJobAsync</summary>
        public async Task CreateDlpJob1ResourceNames1Async()
        {
            // Snippet: CreateDlpJobAsync(ProjectName, InspectJobConfig, CallSettings)
            // Additional: CreateDlpJobAsync(ProjectName, InspectJobConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            InspectJobConfig inspectJob = new InspectJobConfig();
            // Make the request
            DlpJob response = await dlpServiceClient.CreateDlpJobAsync(parent, inspectJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJob</summary>
        public void CreateDlpJob1ResourceNames2()
        {
            // Snippet: CreateDlpJob(LocationName, InspectJobConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InspectJobConfig inspectJob = new InspectJobConfig();
            // Make the request
            DlpJob response = dlpServiceClient.CreateDlpJob(parent, inspectJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJobAsync</summary>
        public async Task CreateDlpJob1ResourceNames2Async()
        {
            // Snippet: CreateDlpJobAsync(LocationName, InspectJobConfig, CallSettings)
            // Additional: CreateDlpJobAsync(LocationName, InspectJobConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InspectJobConfig inspectJob = new InspectJobConfig();
            // Make the request
            DlpJob response = await dlpServiceClient.CreateDlpJobAsync(parent, inspectJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJob</summary>
        public void CreateDlpJob2()
        {
            // Snippet: CreateDlpJob(string, RiskAnalysisJobConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            RiskAnalysisJobConfig riskJob = new RiskAnalysisJobConfig();
            // Make the request
            DlpJob response = dlpServiceClient.CreateDlpJob(parent, riskJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJobAsync</summary>
        public async Task CreateDlpJob2Async()
        {
            // Snippet: CreateDlpJobAsync(string, RiskAnalysisJobConfig, CallSettings)
            // Additional: CreateDlpJobAsync(string, RiskAnalysisJobConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            RiskAnalysisJobConfig riskJob = new RiskAnalysisJobConfig();
            // Make the request
            DlpJob response = await dlpServiceClient.CreateDlpJobAsync(parent, riskJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJob</summary>
        public void CreateDlpJob2ResourceNames1()
        {
            // Snippet: CreateDlpJob(ProjectName, RiskAnalysisJobConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            RiskAnalysisJobConfig riskJob = new RiskAnalysisJobConfig();
            // Make the request
            DlpJob response = dlpServiceClient.CreateDlpJob(parent, riskJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJobAsync</summary>
        public async Task CreateDlpJob2ResourceNames1Async()
        {
            // Snippet: CreateDlpJobAsync(ProjectName, RiskAnalysisJobConfig, CallSettings)
            // Additional: CreateDlpJobAsync(ProjectName, RiskAnalysisJobConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            RiskAnalysisJobConfig riskJob = new RiskAnalysisJobConfig();
            // Make the request
            DlpJob response = await dlpServiceClient.CreateDlpJobAsync(parent, riskJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJob</summary>
        public void CreateDlpJob2ResourceNames2()
        {
            // Snippet: CreateDlpJob(LocationName, RiskAnalysisJobConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RiskAnalysisJobConfig riskJob = new RiskAnalysisJobConfig();
            // Make the request
            DlpJob response = dlpServiceClient.CreateDlpJob(parent, riskJob);
            // End snippet
        }

        /// <summary>Snippet for CreateDlpJobAsync</summary>
        public async Task CreateDlpJob2ResourceNames2Async()
        {
            // Snippet: CreateDlpJobAsync(LocationName, RiskAnalysisJobConfig, CallSettings)
            // Additional: CreateDlpJobAsync(LocationName, RiskAnalysisJobConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            RiskAnalysisJobConfig riskJob = new RiskAnalysisJobConfig();
            // Make the request
            DlpJob response = await dlpServiceClient.CreateDlpJobAsync(parent, riskJob);
            // End snippet
        }

        /// <summary>Snippet for ListDlpJobs</summary>
        public void ListDlpJobsRequestObject()
        {
            // Snippet: ListDlpJobs(ListDlpJobsRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListDlpJobsRequest request = new ListDlpJobsRequest
            {
                Filter = "",
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Type = DlpJobType.Unspecified,
                OrderBy = "",
                LocationId = "",
            };
            // Make the request
            PagedEnumerable<ListDlpJobsResponse, DlpJob> response = dlpServiceClient.ListDlpJobs(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDlpJobsAsync</summary>
        public async Task ListDlpJobsRequestObjectAsync()
        {
            // Snippet: ListDlpJobsAsync(ListDlpJobsRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDlpJobsRequest request = new ListDlpJobsRequest
            {
                Filter = "",
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Type = DlpJobType.Unspecified,
                OrderBy = "",
                LocationId = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> response = dlpServiceClient.ListDlpJobsAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDlpJobs</summary>
        public void ListDlpJobs()
        {
            // Snippet: ListDlpJobs(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListDlpJobsResponse, DlpJob> response = dlpServiceClient.ListDlpJobs(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDlpJobsAsync</summary>
        public async Task ListDlpJobsAsync()
        {
            // Snippet: ListDlpJobsAsync(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> response = dlpServiceClient.ListDlpJobsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDlpJobs</summary>
        public void ListDlpJobsResourceNames1()
        {
            // Snippet: ListDlpJobs(ProjectName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListDlpJobsResponse, DlpJob> response = dlpServiceClient.ListDlpJobs(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDlpJobsAsync</summary>
        public async Task ListDlpJobsResourceNames1Async()
        {
            // Snippet: ListDlpJobsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> response = dlpServiceClient.ListDlpJobsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDlpJobs</summary>
        public void ListDlpJobsResourceNames2()
        {
            // Snippet: ListDlpJobs(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDlpJobsResponse, DlpJob> response = dlpServiceClient.ListDlpJobs(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDlpJobsAsync</summary>
        public async Task ListDlpJobsResourceNames2Async()
        {
            // Snippet: ListDlpJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> response = dlpServiceClient.ListDlpJobsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDlpJob</summary>
        public void GetDlpJobRequestObject()
        {
            // Snippet: GetDlpJob(GetDlpJobRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetDlpJobRequest request = new GetDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            DlpJob response = dlpServiceClient.GetDlpJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetDlpJobAsync</summary>
        public async Task GetDlpJobRequestObjectAsync()
        {
            // Snippet: GetDlpJobAsync(GetDlpJobRequest, CallSettings)
            // Additional: GetDlpJobAsync(GetDlpJobRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDlpJobRequest request = new GetDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            DlpJob response = await dlpServiceClient.GetDlpJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDlpJob</summary>
        public void GetDlpJob()
        {
            // Snippet: GetDlpJob(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/dlpJobs/[DLP_JOB]";
            // Make the request
            DlpJob response = dlpServiceClient.GetDlpJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetDlpJobAsync</summary>
        public async Task GetDlpJobAsync()
        {
            // Snippet: GetDlpJobAsync(string, CallSettings)
            // Additional: GetDlpJobAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/dlpJobs/[DLP_JOB]";
            // Make the request
            DlpJob response = await dlpServiceClient.GetDlpJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDlpJob</summary>
        public void GetDlpJobResourceNames()
        {
            // Snippet: GetDlpJob(DlpJobName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DlpJobName name = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]");
            // Make the request
            DlpJob response = dlpServiceClient.GetDlpJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetDlpJobAsync</summary>
        public async Task GetDlpJobResourceNamesAsync()
        {
            // Snippet: GetDlpJobAsync(DlpJobName, CallSettings)
            // Additional: GetDlpJobAsync(DlpJobName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DlpJobName name = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]");
            // Make the request
            DlpJob response = await dlpServiceClient.GetDlpJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDlpJob</summary>
        public void DeleteDlpJobRequestObject()
        {
            // Snippet: DeleteDlpJob(DeleteDlpJobRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteDlpJobRequest request = new DeleteDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            dlpServiceClient.DeleteDlpJob(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDlpJobAsync</summary>
        public async Task DeleteDlpJobRequestObjectAsync()
        {
            // Snippet: DeleteDlpJobAsync(DeleteDlpJobRequest, CallSettings)
            // Additional: DeleteDlpJobAsync(DeleteDlpJobRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDlpJobRequest request = new DeleteDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            await dlpServiceClient.DeleteDlpJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDlpJob</summary>
        public void DeleteDlpJob()
        {
            // Snippet: DeleteDlpJob(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/dlpJobs/[DLP_JOB]";
            // Make the request
            dlpServiceClient.DeleteDlpJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDlpJobAsync</summary>
        public async Task DeleteDlpJobAsync()
        {
            // Snippet: DeleteDlpJobAsync(string, CallSettings)
            // Additional: DeleteDlpJobAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/dlpJobs/[DLP_JOB]";
            // Make the request
            await dlpServiceClient.DeleteDlpJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDlpJob</summary>
        public void DeleteDlpJobResourceNames()
        {
            // Snippet: DeleteDlpJob(DlpJobName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DlpJobName name = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]");
            // Make the request
            dlpServiceClient.DeleteDlpJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDlpJobAsync</summary>
        public async Task DeleteDlpJobResourceNamesAsync()
        {
            // Snippet: DeleteDlpJobAsync(DlpJobName, CallSettings)
            // Additional: DeleteDlpJobAsync(DlpJobName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DlpJobName name = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]");
            // Make the request
            await dlpServiceClient.DeleteDlpJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelDlpJob</summary>
        public void CancelDlpJobRequestObject()
        {
            // Snippet: CancelDlpJob(CancelDlpJobRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CancelDlpJobRequest request = new CancelDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            dlpServiceClient.CancelDlpJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelDlpJobAsync</summary>
        public async Task CancelDlpJobRequestObjectAsync()
        {
            // Snippet: CancelDlpJobAsync(CancelDlpJobRequest, CallSettings)
            // Additional: CancelDlpJobAsync(CancelDlpJobRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelDlpJobRequest request = new CancelDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            await dlpServiceClient.CancelDlpJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoType</summary>
        public void CreateStoredInfoTypeRequestObject()
        {
            // Snippet: CreateStoredInfoType(CreateStoredInfoTypeRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
                StoredInfoTypeId = "",
                LocationId = "",
            };
            // Make the request
            StoredInfoType response = dlpServiceClient.CreateStoredInfoType(request);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoTypeAsync</summary>
        public async Task CreateStoredInfoTypeRequestObjectAsync()
        {
            // Snippet: CreateStoredInfoTypeAsync(CreateStoredInfoTypeRequest, CallSettings)
            // Additional: CreateStoredInfoTypeAsync(CreateStoredInfoTypeRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateStoredInfoTypeRequest request = new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Config = new StoredInfoTypeConfig(),
                StoredInfoTypeId = "",
                LocationId = "",
            };
            // Make the request
            StoredInfoType response = await dlpServiceClient.CreateStoredInfoTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoType</summary>
        public void CreateStoredInfoType()
        {
            // Snippet: CreateStoredInfoType(string, StoredInfoTypeConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            // Make the request
            StoredInfoType response = dlpServiceClient.CreateStoredInfoType(parent, config);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoTypeAsync</summary>
        public async Task CreateStoredInfoTypeAsync()
        {
            // Snippet: CreateStoredInfoTypeAsync(string, StoredInfoTypeConfig, CallSettings)
            // Additional: CreateStoredInfoTypeAsync(string, StoredInfoTypeConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            // Make the request
            StoredInfoType response = await dlpServiceClient.CreateStoredInfoTypeAsync(parent, config);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoType</summary>
        public void CreateStoredInfoTypeResourceNames1()
        {
            // Snippet: CreateStoredInfoType(OrganizationName, StoredInfoTypeConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            // Make the request
            StoredInfoType response = dlpServiceClient.CreateStoredInfoType(parent, config);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoTypeAsync</summary>
        public async Task CreateStoredInfoTypeResourceNames1Async()
        {
            // Snippet: CreateStoredInfoTypeAsync(OrganizationName, StoredInfoTypeConfig, CallSettings)
            // Additional: CreateStoredInfoTypeAsync(OrganizationName, StoredInfoTypeConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            // Make the request
            StoredInfoType response = await dlpServiceClient.CreateStoredInfoTypeAsync(parent, config);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoType</summary>
        public void CreateStoredInfoTypeResourceNames2()
        {
            // Snippet: CreateStoredInfoType(ProjectName, StoredInfoTypeConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            // Make the request
            StoredInfoType response = dlpServiceClient.CreateStoredInfoType(parent, config);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoTypeAsync</summary>
        public async Task CreateStoredInfoTypeResourceNames2Async()
        {
            // Snippet: CreateStoredInfoTypeAsync(ProjectName, StoredInfoTypeConfig, CallSettings)
            // Additional: CreateStoredInfoTypeAsync(ProjectName, StoredInfoTypeConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            // Make the request
            StoredInfoType response = await dlpServiceClient.CreateStoredInfoTypeAsync(parent, config);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoType</summary>
        public void CreateStoredInfoTypeResourceNames3()
        {
            // Snippet: CreateStoredInfoType(OrganizationLocationName, StoredInfoTypeConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            // Make the request
            StoredInfoType response = dlpServiceClient.CreateStoredInfoType(parent, config);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoTypeAsync</summary>
        public async Task CreateStoredInfoTypeResourceNames3Async()
        {
            // Snippet: CreateStoredInfoTypeAsync(OrganizationLocationName, StoredInfoTypeConfig, CallSettings)
            // Additional: CreateStoredInfoTypeAsync(OrganizationLocationName, StoredInfoTypeConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            // Make the request
            StoredInfoType response = await dlpServiceClient.CreateStoredInfoTypeAsync(parent, config);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoType</summary>
        public void CreateStoredInfoTypeResourceNames4()
        {
            // Snippet: CreateStoredInfoType(LocationName, StoredInfoTypeConfig, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            // Make the request
            StoredInfoType response = dlpServiceClient.CreateStoredInfoType(parent, config);
            // End snippet
        }

        /// <summary>Snippet for CreateStoredInfoTypeAsync</summary>
        public async Task CreateStoredInfoTypeResourceNames4Async()
        {
            // Snippet: CreateStoredInfoTypeAsync(LocationName, StoredInfoTypeConfig, CallSettings)
            // Additional: CreateStoredInfoTypeAsync(LocationName, StoredInfoTypeConfig, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            // Make the request
            StoredInfoType response = await dlpServiceClient.CreateStoredInfoTypeAsync(parent, config);
            // End snippet
        }

        /// <summary>Snippet for UpdateStoredInfoType</summary>
        public void UpdateStoredInfoTypeRequestObject()
        {
            // Snippet: UpdateStoredInfoType(UpdateStoredInfoTypeRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            UpdateStoredInfoTypeRequest request = new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                Config = new StoredInfoTypeConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            StoredInfoType response = dlpServiceClient.UpdateStoredInfoType(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateStoredInfoTypeAsync</summary>
        public async Task UpdateStoredInfoTypeRequestObjectAsync()
        {
            // Snippet: UpdateStoredInfoTypeAsync(UpdateStoredInfoTypeRequest, CallSettings)
            // Additional: UpdateStoredInfoTypeAsync(UpdateStoredInfoTypeRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateStoredInfoTypeRequest request = new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
                Config = new StoredInfoTypeConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            StoredInfoType response = await dlpServiceClient.UpdateStoredInfoTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateStoredInfoType</summary>
        public void UpdateStoredInfoType()
        {
            // Snippet: UpdateStoredInfoType(string, StoredInfoTypeConfig, FieldMask, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/storedInfoTypes/[STORED_INFO_TYPE]";
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            StoredInfoType response = dlpServiceClient.UpdateStoredInfoType(name, config, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateStoredInfoTypeAsync</summary>
        public async Task UpdateStoredInfoTypeAsync()
        {
            // Snippet: UpdateStoredInfoTypeAsync(string, StoredInfoTypeConfig, FieldMask, CallSettings)
            // Additional: UpdateStoredInfoTypeAsync(string, StoredInfoTypeConfig, FieldMask, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/storedInfoTypes/[STORED_INFO_TYPE]";
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            StoredInfoType response = await dlpServiceClient.UpdateStoredInfoTypeAsync(name, config, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateStoredInfoType</summary>
        public void UpdateStoredInfoTypeResourceNames()
        {
            // Snippet: UpdateStoredInfoType(StoredInfoTypeName, StoredInfoTypeConfig, FieldMask, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            StoredInfoTypeName name = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]");
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            StoredInfoType response = dlpServiceClient.UpdateStoredInfoType(name, config, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateStoredInfoTypeAsync</summary>
        public async Task UpdateStoredInfoTypeResourceNamesAsync()
        {
            // Snippet: UpdateStoredInfoTypeAsync(StoredInfoTypeName, StoredInfoTypeConfig, FieldMask, CallSettings)
            // Additional: UpdateStoredInfoTypeAsync(StoredInfoTypeName, StoredInfoTypeConfig, FieldMask, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            StoredInfoTypeName name = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]");
            StoredInfoTypeConfig config = new StoredInfoTypeConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            StoredInfoType response = await dlpServiceClient.UpdateStoredInfoTypeAsync(name, config, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetStoredInfoType</summary>
        public void GetStoredInfoTypeRequestObject()
        {
            // Snippet: GetStoredInfoType(GetStoredInfoTypeRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetStoredInfoTypeRequest request = new GetStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            // Make the request
            StoredInfoType response = dlpServiceClient.GetStoredInfoType(request);
            // End snippet
        }

        /// <summary>Snippet for GetStoredInfoTypeAsync</summary>
        public async Task GetStoredInfoTypeRequestObjectAsync()
        {
            // Snippet: GetStoredInfoTypeAsync(GetStoredInfoTypeRequest, CallSettings)
            // Additional: GetStoredInfoTypeAsync(GetStoredInfoTypeRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetStoredInfoTypeRequest request = new GetStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            // Make the request
            StoredInfoType response = await dlpServiceClient.GetStoredInfoTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStoredInfoType</summary>
        public void GetStoredInfoType()
        {
            // Snippet: GetStoredInfoType(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/storedInfoTypes/[STORED_INFO_TYPE]";
            // Make the request
            StoredInfoType response = dlpServiceClient.GetStoredInfoType(name);
            // End snippet
        }

        /// <summary>Snippet for GetStoredInfoTypeAsync</summary>
        public async Task GetStoredInfoTypeAsync()
        {
            // Snippet: GetStoredInfoTypeAsync(string, CallSettings)
            // Additional: GetStoredInfoTypeAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/storedInfoTypes/[STORED_INFO_TYPE]";
            // Make the request
            StoredInfoType response = await dlpServiceClient.GetStoredInfoTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetStoredInfoType</summary>
        public void GetStoredInfoTypeResourceNames()
        {
            // Snippet: GetStoredInfoType(StoredInfoTypeName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            StoredInfoTypeName name = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]");
            // Make the request
            StoredInfoType response = dlpServiceClient.GetStoredInfoType(name);
            // End snippet
        }

        /// <summary>Snippet for GetStoredInfoTypeAsync</summary>
        public async Task GetStoredInfoTypeResourceNamesAsync()
        {
            // Snippet: GetStoredInfoTypeAsync(StoredInfoTypeName, CallSettings)
            // Additional: GetStoredInfoTypeAsync(StoredInfoTypeName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            StoredInfoTypeName name = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]");
            // Make the request
            StoredInfoType response = await dlpServiceClient.GetStoredInfoTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypes</summary>
        public void ListStoredInfoTypesRequestObject()
        {
            // Snippet: ListStoredInfoTypes(ListStoredInfoTypesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                OrderBy = "",
                LocationId = "",
            };
            // Make the request
            PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response = dlpServiceClient.ListStoredInfoTypes(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypesAsync</summary>
        public async Task ListStoredInfoTypesRequestObjectAsync()
        {
            // Snippet: ListStoredInfoTypesAsync(ListStoredInfoTypesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                OrderBy = "",
                LocationId = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response = dlpServiceClient.ListStoredInfoTypesAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypes</summary>
        public void ListStoredInfoTypes()
        {
            // Snippet: ListStoredInfoTypes(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response = dlpServiceClient.ListStoredInfoTypes(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypesAsync</summary>
        public async Task ListStoredInfoTypesAsync()
        {
            // Snippet: ListStoredInfoTypesAsync(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response = dlpServiceClient.ListStoredInfoTypesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypes</summary>
        public void ListStoredInfoTypesResourceNames1()
        {
            // Snippet: ListStoredInfoTypes(OrganizationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response = dlpServiceClient.ListStoredInfoTypes(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypesAsync</summary>
        public async Task ListStoredInfoTypesResourceNames1Async()
        {
            // Snippet: ListStoredInfoTypesAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response = dlpServiceClient.ListStoredInfoTypesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypes</summary>
        public void ListStoredInfoTypesResourceNames2()
        {
            // Snippet: ListStoredInfoTypes(ProjectName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response = dlpServiceClient.ListStoredInfoTypes(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypesAsync</summary>
        public async Task ListStoredInfoTypesResourceNames2Async()
        {
            // Snippet: ListStoredInfoTypesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response = dlpServiceClient.ListStoredInfoTypesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypes</summary>
        public void ListStoredInfoTypesResourceNames3()
        {
            // Snippet: ListStoredInfoTypes(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response = dlpServiceClient.ListStoredInfoTypes(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypesAsync</summary>
        public async Task ListStoredInfoTypesResourceNames3Async()
        {
            // Snippet: ListStoredInfoTypesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response = dlpServiceClient.ListStoredInfoTypesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypes</summary>
        public void ListStoredInfoTypesResourceNames4()
        {
            // Snippet: ListStoredInfoTypes(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response = dlpServiceClient.ListStoredInfoTypes(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoredInfoTypesAsync</summary>
        public async Task ListStoredInfoTypesResourceNames4Async()
        {
            // Snippet: ListStoredInfoTypesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> response = dlpServiceClient.ListStoredInfoTypesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteStoredInfoType</summary>
        public void DeleteStoredInfoTypeRequestObject()
        {
            // Snippet: DeleteStoredInfoType(DeleteStoredInfoTypeRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteStoredInfoTypeRequest request = new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            // Make the request
            dlpServiceClient.DeleteStoredInfoType(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteStoredInfoTypeAsync</summary>
        public async Task DeleteStoredInfoTypeRequestObjectAsync()
        {
            // Snippet: DeleteStoredInfoTypeAsync(DeleteStoredInfoTypeRequest, CallSettings)
            // Additional: DeleteStoredInfoTypeAsync(DeleteStoredInfoTypeRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteStoredInfoTypeRequest request = new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeName = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]"),
            };
            // Make the request
            await dlpServiceClient.DeleteStoredInfoTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteStoredInfoType</summary>
        public void DeleteStoredInfoType()
        {
            // Snippet: DeleteStoredInfoType(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/storedInfoTypes/[STORED_INFO_TYPE]";
            // Make the request
            dlpServiceClient.DeleteStoredInfoType(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteStoredInfoTypeAsync</summary>
        public async Task DeleteStoredInfoTypeAsync()
        {
            // Snippet: DeleteStoredInfoTypeAsync(string, CallSettings)
            // Additional: DeleteStoredInfoTypeAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/storedInfoTypes/[STORED_INFO_TYPE]";
            // Make the request
            await dlpServiceClient.DeleteStoredInfoTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteStoredInfoType</summary>
        public void DeleteStoredInfoTypeResourceNames()
        {
            // Snippet: DeleteStoredInfoType(StoredInfoTypeName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            StoredInfoTypeName name = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]");
            // Make the request
            dlpServiceClient.DeleteStoredInfoType(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteStoredInfoTypeAsync</summary>
        public async Task DeleteStoredInfoTypeResourceNamesAsync()
        {
            // Snippet: DeleteStoredInfoTypeAsync(StoredInfoTypeName, CallSettings)
            // Additional: DeleteStoredInfoTypeAsync(StoredInfoTypeName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            StoredInfoTypeName name = StoredInfoTypeName.FromOrganizationStoredInfoType("[ORGANIZATION]", "[STORED_INFO_TYPE]");
            // Make the request
            await dlpServiceClient.DeleteStoredInfoTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProjectDataProfiles</summary>
        public void ListProjectDataProfilesRequestObject()
        {
            // Snippet: ListProjectDataProfiles(ListProjectDataProfilesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListProjectDataProfilesRequest request = new ListProjectDataProfilesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> response = dlpServiceClient.ListProjectDataProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProjectDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProjectDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectDataProfilesAsync</summary>
        public async Task ListProjectDataProfilesRequestObjectAsync()
        {
            // Snippet: ListProjectDataProfilesAsync(ListProjectDataProfilesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProjectDataProfilesRequest request = new ListProjectDataProfilesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> response = dlpServiceClient.ListProjectDataProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProjectDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProjectDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectDataProfiles</summary>
        public void ListProjectDataProfiles()
        {
            // Snippet: ListProjectDataProfiles(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> response = dlpServiceClient.ListProjectDataProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProjectDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProjectDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectDataProfilesAsync</summary>
        public async Task ListProjectDataProfilesAsync()
        {
            // Snippet: ListProjectDataProfilesAsync(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> response = dlpServiceClient.ListProjectDataProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProjectDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProjectDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectDataProfiles</summary>
        public void ListProjectDataProfilesResourceNames1()
        {
            // Snippet: ListProjectDataProfiles(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> response = dlpServiceClient.ListProjectDataProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProjectDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProjectDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectDataProfilesAsync</summary>
        public async Task ListProjectDataProfilesResourceNames1Async()
        {
            // Snippet: ListProjectDataProfilesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> response = dlpServiceClient.ListProjectDataProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProjectDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProjectDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectDataProfiles</summary>
        public void ListProjectDataProfilesResourceNames2()
        {
            // Snippet: ListProjectDataProfiles(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> response = dlpServiceClient.ListProjectDataProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProjectDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProjectDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectDataProfilesAsync</summary>
        public async Task ListProjectDataProfilesResourceNames2Async()
        {
            // Snippet: ListProjectDataProfilesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> response = dlpServiceClient.ListProjectDataProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProjectDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProjectDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTableDataProfiles</summary>
        public void ListTableDataProfilesRequestObject()
        {
            // Snippet: ListTableDataProfiles(ListTableDataProfilesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListTableDataProfilesRequest request = new ListTableDataProfilesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListTableDataProfilesResponse, TableDataProfile> response = dlpServiceClient.ListTableDataProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TableDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTableDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TableDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TableDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TableDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTableDataProfilesAsync</summary>
        public async Task ListTableDataProfilesRequestObjectAsync()
        {
            // Snippet: ListTableDataProfilesAsync(ListTableDataProfilesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTableDataProfilesRequest request = new ListTableDataProfilesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTableDataProfilesResponse, TableDataProfile> response = dlpServiceClient.ListTableDataProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TableDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTableDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TableDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TableDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TableDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTableDataProfiles</summary>
        public void ListTableDataProfiles()
        {
            // Snippet: ListTableDataProfiles(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTableDataProfilesResponse, TableDataProfile> response = dlpServiceClient.ListTableDataProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TableDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTableDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TableDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TableDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TableDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTableDataProfilesAsync</summary>
        public async Task ListTableDataProfilesAsync()
        {
            // Snippet: ListTableDataProfilesAsync(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTableDataProfilesResponse, TableDataProfile> response = dlpServiceClient.ListTableDataProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TableDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTableDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TableDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TableDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TableDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTableDataProfiles</summary>
        public void ListTableDataProfilesResourceNames1()
        {
            // Snippet: ListTableDataProfiles(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTableDataProfilesResponse, TableDataProfile> response = dlpServiceClient.ListTableDataProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TableDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTableDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TableDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TableDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TableDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTableDataProfilesAsync</summary>
        public async Task ListTableDataProfilesResourceNames1Async()
        {
            // Snippet: ListTableDataProfilesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTableDataProfilesResponse, TableDataProfile> response = dlpServiceClient.ListTableDataProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TableDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTableDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TableDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TableDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TableDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTableDataProfiles</summary>
        public void ListTableDataProfilesResourceNames2()
        {
            // Snippet: ListTableDataProfiles(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTableDataProfilesResponse, TableDataProfile> response = dlpServiceClient.ListTableDataProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TableDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTableDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TableDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TableDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TableDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTableDataProfilesAsync</summary>
        public async Task ListTableDataProfilesResourceNames2Async()
        {
            // Snippet: ListTableDataProfilesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTableDataProfilesResponse, TableDataProfile> response = dlpServiceClient.ListTableDataProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TableDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTableDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TableDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TableDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TableDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListColumnDataProfiles</summary>
        public void ListColumnDataProfilesRequestObject()
        {
            // Snippet: ListColumnDataProfiles(ListColumnDataProfilesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListColumnDataProfilesRequest request = new ListColumnDataProfilesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> response = dlpServiceClient.ListColumnDataProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ColumnDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListColumnDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ColumnDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ColumnDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ColumnDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListColumnDataProfilesAsync</summary>
        public async Task ListColumnDataProfilesRequestObjectAsync()
        {
            // Snippet: ListColumnDataProfilesAsync(ListColumnDataProfilesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListColumnDataProfilesRequest request = new ListColumnDataProfilesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> response = dlpServiceClient.ListColumnDataProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ColumnDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListColumnDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ColumnDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ColumnDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ColumnDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListColumnDataProfiles</summary>
        public void ListColumnDataProfiles()
        {
            // Snippet: ListColumnDataProfiles(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> response = dlpServiceClient.ListColumnDataProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ColumnDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListColumnDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ColumnDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ColumnDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ColumnDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListColumnDataProfilesAsync</summary>
        public async Task ListColumnDataProfilesAsync()
        {
            // Snippet: ListColumnDataProfilesAsync(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> response = dlpServiceClient.ListColumnDataProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ColumnDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListColumnDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ColumnDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ColumnDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ColumnDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListColumnDataProfiles</summary>
        public void ListColumnDataProfilesResourceNames1()
        {
            // Snippet: ListColumnDataProfiles(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> response = dlpServiceClient.ListColumnDataProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ColumnDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListColumnDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ColumnDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ColumnDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ColumnDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListColumnDataProfilesAsync</summary>
        public async Task ListColumnDataProfilesResourceNames1Async()
        {
            // Snippet: ListColumnDataProfilesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> response = dlpServiceClient.ListColumnDataProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ColumnDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListColumnDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ColumnDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ColumnDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ColumnDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListColumnDataProfiles</summary>
        public void ListColumnDataProfilesResourceNames2()
        {
            // Snippet: ListColumnDataProfiles(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> response = dlpServiceClient.ListColumnDataProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ColumnDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListColumnDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ColumnDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ColumnDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ColumnDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListColumnDataProfilesAsync</summary>
        public async Task ListColumnDataProfilesResourceNames2Async()
        {
            // Snippet: ListColumnDataProfilesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> response = dlpServiceClient.ListColumnDataProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ColumnDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListColumnDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ColumnDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ColumnDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ColumnDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetProjectDataProfile</summary>
        public void GetProjectDataProfileRequestObject()
        {
            // Snippet: GetProjectDataProfile(GetProjectDataProfileRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetProjectDataProfileRequest request = new GetProjectDataProfileRequest
            {
                ProjectDataProfileName = ProjectDataProfileName.FromOrganizationLocationProjectDataProfile("[ORGANIZATION]", "[LOCATION]", "[PROJECT_DATA_PROFILE]"),
            };
            // Make the request
            ProjectDataProfile response = dlpServiceClient.GetProjectDataProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectDataProfileAsync</summary>
        public async Task GetProjectDataProfileRequestObjectAsync()
        {
            // Snippet: GetProjectDataProfileAsync(GetProjectDataProfileRequest, CallSettings)
            // Additional: GetProjectDataProfileAsync(GetProjectDataProfileRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProjectDataProfileRequest request = new GetProjectDataProfileRequest
            {
                ProjectDataProfileName = ProjectDataProfileName.FromOrganizationLocationProjectDataProfile("[ORGANIZATION]", "[LOCATION]", "[PROJECT_DATA_PROFILE]"),
            };
            // Make the request
            ProjectDataProfile response = await dlpServiceClient.GetProjectDataProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectDataProfile</summary>
        public void GetProjectDataProfile()
        {
            // Snippet: GetProjectDataProfile(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/projectDataProfiles/[PROJECT_DATA_PROFILE]";
            // Make the request
            ProjectDataProfile response = dlpServiceClient.GetProjectDataProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectDataProfileAsync</summary>
        public async Task GetProjectDataProfileAsync()
        {
            // Snippet: GetProjectDataProfileAsync(string, CallSettings)
            // Additional: GetProjectDataProfileAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/projectDataProfiles/[PROJECT_DATA_PROFILE]";
            // Make the request
            ProjectDataProfile response = await dlpServiceClient.GetProjectDataProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectDataProfile</summary>
        public void GetProjectDataProfileResourceNames()
        {
            // Snippet: GetProjectDataProfile(ProjectDataProfileName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectDataProfileName name = ProjectDataProfileName.FromOrganizationLocationProjectDataProfile("[ORGANIZATION]", "[LOCATION]", "[PROJECT_DATA_PROFILE]");
            // Make the request
            ProjectDataProfile response = dlpServiceClient.GetProjectDataProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectDataProfileAsync</summary>
        public async Task GetProjectDataProfileResourceNamesAsync()
        {
            // Snippet: GetProjectDataProfileAsync(ProjectDataProfileName, CallSettings)
            // Additional: GetProjectDataProfileAsync(ProjectDataProfileName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectDataProfileName name = ProjectDataProfileName.FromOrganizationLocationProjectDataProfile("[ORGANIZATION]", "[LOCATION]", "[PROJECT_DATA_PROFILE]");
            // Make the request
            ProjectDataProfile response = await dlpServiceClient.GetProjectDataProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFileStoreDataProfiles</summary>
        public void ListFileStoreDataProfilesRequestObject()
        {
            // Snippet: ListFileStoreDataProfiles(ListFileStoreDataProfilesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListFileStoreDataProfilesRequest request = new ListFileStoreDataProfilesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> response = dlpServiceClient.ListFileStoreDataProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FileStoreDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFileStoreDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileStoreDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileStoreDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileStoreDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFileStoreDataProfilesAsync</summary>
        public async Task ListFileStoreDataProfilesRequestObjectAsync()
        {
            // Snippet: ListFileStoreDataProfilesAsync(ListFileStoreDataProfilesRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFileStoreDataProfilesRequest request = new ListFileStoreDataProfilesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> response = dlpServiceClient.ListFileStoreDataProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FileStoreDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFileStoreDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileStoreDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileStoreDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileStoreDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFileStoreDataProfiles</summary>
        public void ListFileStoreDataProfiles()
        {
            // Snippet: ListFileStoreDataProfiles(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> response = dlpServiceClient.ListFileStoreDataProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FileStoreDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFileStoreDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileStoreDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileStoreDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileStoreDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFileStoreDataProfilesAsync</summary>
        public async Task ListFileStoreDataProfilesAsync()
        {
            // Snippet: ListFileStoreDataProfilesAsync(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> response = dlpServiceClient.ListFileStoreDataProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FileStoreDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFileStoreDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileStoreDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileStoreDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileStoreDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFileStoreDataProfiles</summary>
        public void ListFileStoreDataProfilesResourceNames1()
        {
            // Snippet: ListFileStoreDataProfiles(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> response = dlpServiceClient.ListFileStoreDataProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FileStoreDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFileStoreDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileStoreDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileStoreDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileStoreDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFileStoreDataProfilesAsync</summary>
        public async Task ListFileStoreDataProfilesResourceNames1Async()
        {
            // Snippet: ListFileStoreDataProfilesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> response = dlpServiceClient.ListFileStoreDataProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FileStoreDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFileStoreDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileStoreDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileStoreDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileStoreDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFileStoreDataProfiles</summary>
        public void ListFileStoreDataProfilesResourceNames2()
        {
            // Snippet: ListFileStoreDataProfiles(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> response = dlpServiceClient.ListFileStoreDataProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FileStoreDataProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFileStoreDataProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileStoreDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileStoreDataProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileStoreDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFileStoreDataProfilesAsync</summary>
        public async Task ListFileStoreDataProfilesResourceNames2Async()
        {
            // Snippet: ListFileStoreDataProfilesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> response = dlpServiceClient.ListFileStoreDataProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FileStoreDataProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFileStoreDataProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileStoreDataProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileStoreDataProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileStoreDataProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFileStoreDataProfile</summary>
        public void GetFileStoreDataProfileRequestObject()
        {
            // Snippet: GetFileStoreDataProfile(GetFileStoreDataProfileRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetFileStoreDataProfileRequest request = new GetFileStoreDataProfileRequest
            {
                ProjectDataProfileName = ProjectDataProfileName.FromOrganizationLocationProjectDataProfile("[ORGANIZATION]", "[LOCATION]", "[PROJECT_DATA_PROFILE]"),
            };
            // Make the request
            FileStoreDataProfile response = dlpServiceClient.GetFileStoreDataProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetFileStoreDataProfileAsync</summary>
        public async Task GetFileStoreDataProfileRequestObjectAsync()
        {
            // Snippet: GetFileStoreDataProfileAsync(GetFileStoreDataProfileRequest, CallSettings)
            // Additional: GetFileStoreDataProfileAsync(GetFileStoreDataProfileRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFileStoreDataProfileRequest request = new GetFileStoreDataProfileRequest
            {
                ProjectDataProfileName = ProjectDataProfileName.FromOrganizationLocationProjectDataProfile("[ORGANIZATION]", "[LOCATION]", "[PROJECT_DATA_PROFILE]"),
            };
            // Make the request
            FileStoreDataProfile response = await dlpServiceClient.GetFileStoreDataProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFileStoreDataProfile</summary>
        public void GetFileStoreDataProfile()
        {
            // Snippet: GetFileStoreDataProfile(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/projectDataProfiles/[PROJECT_DATA_PROFILE]";
            // Make the request
            FileStoreDataProfile response = dlpServiceClient.GetFileStoreDataProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetFileStoreDataProfileAsync</summary>
        public async Task GetFileStoreDataProfileAsync()
        {
            // Snippet: GetFileStoreDataProfileAsync(string, CallSettings)
            // Additional: GetFileStoreDataProfileAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/projectDataProfiles/[PROJECT_DATA_PROFILE]";
            // Make the request
            FileStoreDataProfile response = await dlpServiceClient.GetFileStoreDataProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFileStoreDataProfile</summary>
        public void GetFileStoreDataProfileResourceNames()
        {
            // Snippet: GetFileStoreDataProfile(ProjectDataProfileName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ProjectDataProfileName name = ProjectDataProfileName.FromOrganizationLocationProjectDataProfile("[ORGANIZATION]", "[LOCATION]", "[PROJECT_DATA_PROFILE]");
            // Make the request
            FileStoreDataProfile response = dlpServiceClient.GetFileStoreDataProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetFileStoreDataProfileAsync</summary>
        public async Task GetFileStoreDataProfileResourceNamesAsync()
        {
            // Snippet: GetFileStoreDataProfileAsync(ProjectDataProfileName, CallSettings)
            // Additional: GetFileStoreDataProfileAsync(ProjectDataProfileName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectDataProfileName name = ProjectDataProfileName.FromOrganizationLocationProjectDataProfile("[ORGANIZATION]", "[LOCATION]", "[PROJECT_DATA_PROFILE]");
            // Make the request
            FileStoreDataProfile response = await dlpServiceClient.GetFileStoreDataProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFileStoreDataProfile</summary>
        public void DeleteFileStoreDataProfileRequestObject()
        {
            // Snippet: DeleteFileStoreDataProfile(DeleteFileStoreDataProfileRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteFileStoreDataProfileRequest request = new DeleteFileStoreDataProfileRequest
            {
                FileStoreDataProfileName = FileStoreDataProfileName.FromOrganizationLocationFileStoreDataProfile("[ORGANIZATION]", "[LOCATION]", "[FILE_STORE_DATA_PROFILE]"),
            };
            // Make the request
            dlpServiceClient.DeleteFileStoreDataProfile(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFileStoreDataProfileAsync</summary>
        public async Task DeleteFileStoreDataProfileRequestObjectAsync()
        {
            // Snippet: DeleteFileStoreDataProfileAsync(DeleteFileStoreDataProfileRequest, CallSettings)
            // Additional: DeleteFileStoreDataProfileAsync(DeleteFileStoreDataProfileRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFileStoreDataProfileRequest request = new DeleteFileStoreDataProfileRequest
            {
                FileStoreDataProfileName = FileStoreDataProfileName.FromOrganizationLocationFileStoreDataProfile("[ORGANIZATION]", "[LOCATION]", "[FILE_STORE_DATA_PROFILE]"),
            };
            // Make the request
            await dlpServiceClient.DeleteFileStoreDataProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFileStoreDataProfile</summary>
        public void DeleteFileStoreDataProfile()
        {
            // Snippet: DeleteFileStoreDataProfile(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/fileStoreDataProfiles/[FILE_STORE_DATA_PROFILE]";
            // Make the request
            dlpServiceClient.DeleteFileStoreDataProfile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFileStoreDataProfileAsync</summary>
        public async Task DeleteFileStoreDataProfileAsync()
        {
            // Snippet: DeleteFileStoreDataProfileAsync(string, CallSettings)
            // Additional: DeleteFileStoreDataProfileAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/fileStoreDataProfiles/[FILE_STORE_DATA_PROFILE]";
            // Make the request
            await dlpServiceClient.DeleteFileStoreDataProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFileStoreDataProfile</summary>
        public void DeleteFileStoreDataProfileResourceNames()
        {
            // Snippet: DeleteFileStoreDataProfile(FileStoreDataProfileName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            FileStoreDataProfileName name = FileStoreDataProfileName.FromOrganizationLocationFileStoreDataProfile("[ORGANIZATION]", "[LOCATION]", "[FILE_STORE_DATA_PROFILE]");
            // Make the request
            dlpServiceClient.DeleteFileStoreDataProfile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFileStoreDataProfileAsync</summary>
        public async Task DeleteFileStoreDataProfileResourceNamesAsync()
        {
            // Snippet: DeleteFileStoreDataProfileAsync(FileStoreDataProfileName, CallSettings)
            // Additional: DeleteFileStoreDataProfileAsync(FileStoreDataProfileName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            FileStoreDataProfileName name = FileStoreDataProfileName.FromOrganizationLocationFileStoreDataProfile("[ORGANIZATION]", "[LOCATION]", "[FILE_STORE_DATA_PROFILE]");
            // Make the request
            await dlpServiceClient.DeleteFileStoreDataProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTableDataProfile</summary>
        public void GetTableDataProfileRequestObject()
        {
            // Snippet: GetTableDataProfile(GetTableDataProfileRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetTableDataProfileRequest request = new GetTableDataProfileRequest
            {
                TableDataProfileName = TableDataProfileName.FromOrganizationLocationTableDataProfile("[ORGANIZATION]", "[LOCATION]", "[TABLE_DATA_PROFILE]"),
            };
            // Make the request
            TableDataProfile response = dlpServiceClient.GetTableDataProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetTableDataProfileAsync</summary>
        public async Task GetTableDataProfileRequestObjectAsync()
        {
            // Snippet: GetTableDataProfileAsync(GetTableDataProfileRequest, CallSettings)
            // Additional: GetTableDataProfileAsync(GetTableDataProfileRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTableDataProfileRequest request = new GetTableDataProfileRequest
            {
                TableDataProfileName = TableDataProfileName.FromOrganizationLocationTableDataProfile("[ORGANIZATION]", "[LOCATION]", "[TABLE_DATA_PROFILE]"),
            };
            // Make the request
            TableDataProfile response = await dlpServiceClient.GetTableDataProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTableDataProfile</summary>
        public void GetTableDataProfile()
        {
            // Snippet: GetTableDataProfile(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/tableDataProfiles/[TABLE_DATA_PROFILE]";
            // Make the request
            TableDataProfile response = dlpServiceClient.GetTableDataProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetTableDataProfileAsync</summary>
        public async Task GetTableDataProfileAsync()
        {
            // Snippet: GetTableDataProfileAsync(string, CallSettings)
            // Additional: GetTableDataProfileAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/tableDataProfiles/[TABLE_DATA_PROFILE]";
            // Make the request
            TableDataProfile response = await dlpServiceClient.GetTableDataProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTableDataProfile</summary>
        public void GetTableDataProfileResourceNames()
        {
            // Snippet: GetTableDataProfile(TableDataProfileName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            TableDataProfileName name = TableDataProfileName.FromOrganizationLocationTableDataProfile("[ORGANIZATION]", "[LOCATION]", "[TABLE_DATA_PROFILE]");
            // Make the request
            TableDataProfile response = dlpServiceClient.GetTableDataProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetTableDataProfileAsync</summary>
        public async Task GetTableDataProfileResourceNamesAsync()
        {
            // Snippet: GetTableDataProfileAsync(TableDataProfileName, CallSettings)
            // Additional: GetTableDataProfileAsync(TableDataProfileName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            TableDataProfileName name = TableDataProfileName.FromOrganizationLocationTableDataProfile("[ORGANIZATION]", "[LOCATION]", "[TABLE_DATA_PROFILE]");
            // Make the request
            TableDataProfile response = await dlpServiceClient.GetTableDataProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetColumnDataProfile</summary>
        public void GetColumnDataProfileRequestObject()
        {
            // Snippet: GetColumnDataProfile(GetColumnDataProfileRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetColumnDataProfileRequest request = new GetColumnDataProfileRequest
            {
                ColumnDataProfileName = ColumnDataProfileName.FromOrganizationLocationColumnDataProfile("[ORGANIZATION]", "[LOCATION]", "[COLUMN_DATA_PROFILE]"),
            };
            // Make the request
            ColumnDataProfile response = dlpServiceClient.GetColumnDataProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetColumnDataProfileAsync</summary>
        public async Task GetColumnDataProfileRequestObjectAsync()
        {
            // Snippet: GetColumnDataProfileAsync(GetColumnDataProfileRequest, CallSettings)
            // Additional: GetColumnDataProfileAsync(GetColumnDataProfileRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetColumnDataProfileRequest request = new GetColumnDataProfileRequest
            {
                ColumnDataProfileName = ColumnDataProfileName.FromOrganizationLocationColumnDataProfile("[ORGANIZATION]", "[LOCATION]", "[COLUMN_DATA_PROFILE]"),
            };
            // Make the request
            ColumnDataProfile response = await dlpServiceClient.GetColumnDataProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetColumnDataProfile</summary>
        public void GetColumnDataProfile()
        {
            // Snippet: GetColumnDataProfile(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/columnDataProfiles/[COLUMN_DATA_PROFILE]";
            // Make the request
            ColumnDataProfile response = dlpServiceClient.GetColumnDataProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetColumnDataProfileAsync</summary>
        public async Task GetColumnDataProfileAsync()
        {
            // Snippet: GetColumnDataProfileAsync(string, CallSettings)
            // Additional: GetColumnDataProfileAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/columnDataProfiles/[COLUMN_DATA_PROFILE]";
            // Make the request
            ColumnDataProfile response = await dlpServiceClient.GetColumnDataProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetColumnDataProfile</summary>
        public void GetColumnDataProfileResourceNames()
        {
            // Snippet: GetColumnDataProfile(ColumnDataProfileName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ColumnDataProfileName name = ColumnDataProfileName.FromOrganizationLocationColumnDataProfile("[ORGANIZATION]", "[LOCATION]", "[COLUMN_DATA_PROFILE]");
            // Make the request
            ColumnDataProfile response = dlpServiceClient.GetColumnDataProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetColumnDataProfileAsync</summary>
        public async Task GetColumnDataProfileResourceNamesAsync()
        {
            // Snippet: GetColumnDataProfileAsync(ColumnDataProfileName, CallSettings)
            // Additional: GetColumnDataProfileAsync(ColumnDataProfileName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ColumnDataProfileName name = ColumnDataProfileName.FromOrganizationLocationColumnDataProfile("[ORGANIZATION]", "[LOCATION]", "[COLUMN_DATA_PROFILE]");
            // Make the request
            ColumnDataProfile response = await dlpServiceClient.GetColumnDataProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTableDataProfile</summary>
        public void DeleteTableDataProfileRequestObject()
        {
            // Snippet: DeleteTableDataProfile(DeleteTableDataProfileRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteTableDataProfileRequest request = new DeleteTableDataProfileRequest
            {
                TableDataProfileName = TableDataProfileName.FromOrganizationLocationTableDataProfile("[ORGANIZATION]", "[LOCATION]", "[TABLE_DATA_PROFILE]"),
            };
            // Make the request
            dlpServiceClient.DeleteTableDataProfile(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTableDataProfileAsync</summary>
        public async Task DeleteTableDataProfileRequestObjectAsync()
        {
            // Snippet: DeleteTableDataProfileAsync(DeleteTableDataProfileRequest, CallSettings)
            // Additional: DeleteTableDataProfileAsync(DeleteTableDataProfileRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTableDataProfileRequest request = new DeleteTableDataProfileRequest
            {
                TableDataProfileName = TableDataProfileName.FromOrganizationLocationTableDataProfile("[ORGANIZATION]", "[LOCATION]", "[TABLE_DATA_PROFILE]"),
            };
            // Make the request
            await dlpServiceClient.DeleteTableDataProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTableDataProfile</summary>
        public void DeleteTableDataProfile()
        {
            // Snippet: DeleteTableDataProfile(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/tableDataProfiles/[TABLE_DATA_PROFILE]";
            // Make the request
            dlpServiceClient.DeleteTableDataProfile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTableDataProfileAsync</summary>
        public async Task DeleteTableDataProfileAsync()
        {
            // Snippet: DeleteTableDataProfileAsync(string, CallSettings)
            // Additional: DeleteTableDataProfileAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/tableDataProfiles/[TABLE_DATA_PROFILE]";
            // Make the request
            await dlpServiceClient.DeleteTableDataProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTableDataProfile</summary>
        public void DeleteTableDataProfileResourceNames()
        {
            // Snippet: DeleteTableDataProfile(TableDataProfileName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            TableDataProfileName name = TableDataProfileName.FromOrganizationLocationTableDataProfile("[ORGANIZATION]", "[LOCATION]", "[TABLE_DATA_PROFILE]");
            // Make the request
            dlpServiceClient.DeleteTableDataProfile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTableDataProfileAsync</summary>
        public async Task DeleteTableDataProfileResourceNamesAsync()
        {
            // Snippet: DeleteTableDataProfileAsync(TableDataProfileName, CallSettings)
            // Additional: DeleteTableDataProfileAsync(TableDataProfileName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            TableDataProfileName name = TableDataProfileName.FromOrganizationLocationTableDataProfile("[ORGANIZATION]", "[LOCATION]", "[TABLE_DATA_PROFILE]");
            // Make the request
            await dlpServiceClient.DeleteTableDataProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for HybridInspectDlpJob</summary>
        public void HybridInspectDlpJobRequestObject()
        {
            // Snippet: HybridInspectDlpJob(HybridInspectDlpJobRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            HybridInspectDlpJobRequest request = new HybridInspectDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                HybridItem = new HybridContentItem(),
            };
            // Make the request
            HybridInspectResponse response = dlpServiceClient.HybridInspectDlpJob(request);
            // End snippet
        }

        /// <summary>Snippet for HybridInspectDlpJobAsync</summary>
        public async Task HybridInspectDlpJobRequestObjectAsync()
        {
            // Snippet: HybridInspectDlpJobAsync(HybridInspectDlpJobRequest, CallSettings)
            // Additional: HybridInspectDlpJobAsync(HybridInspectDlpJobRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            HybridInspectDlpJobRequest request = new HybridInspectDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
                HybridItem = new HybridContentItem(),
            };
            // Make the request
            HybridInspectResponse response = await dlpServiceClient.HybridInspectDlpJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for HybridInspectDlpJob</summary>
        public void HybridInspectDlpJob()
        {
            // Snippet: HybridInspectDlpJob(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/dlpJobs/[DLP_JOB]";
            // Make the request
            HybridInspectResponse response = dlpServiceClient.HybridInspectDlpJob(name);
            // End snippet
        }

        /// <summary>Snippet for HybridInspectDlpJobAsync</summary>
        public async Task HybridInspectDlpJobAsync()
        {
            // Snippet: HybridInspectDlpJobAsync(string, CallSettings)
            // Additional: HybridInspectDlpJobAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/dlpJobs/[DLP_JOB]";
            // Make the request
            HybridInspectResponse response = await dlpServiceClient.HybridInspectDlpJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for HybridInspectDlpJob</summary>
        public void HybridInspectDlpJobResourceNames()
        {
            // Snippet: HybridInspectDlpJob(DlpJobName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DlpJobName name = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]");
            // Make the request
            HybridInspectResponse response = dlpServiceClient.HybridInspectDlpJob(name);
            // End snippet
        }

        /// <summary>Snippet for HybridInspectDlpJobAsync</summary>
        public async Task HybridInspectDlpJobResourceNamesAsync()
        {
            // Snippet: HybridInspectDlpJobAsync(DlpJobName, CallSettings)
            // Additional: HybridInspectDlpJobAsync(DlpJobName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DlpJobName name = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]");
            // Make the request
            HybridInspectResponse response = await dlpServiceClient.HybridInspectDlpJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FinishDlpJob</summary>
        public void FinishDlpJobRequestObject()
        {
            // Snippet: FinishDlpJob(FinishDlpJobRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            FinishDlpJobRequest request = new FinishDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            dlpServiceClient.FinishDlpJob(request);
            // End snippet
        }

        /// <summary>Snippet for FinishDlpJobAsync</summary>
        public async Task FinishDlpJobRequestObjectAsync()
        {
            // Snippet: FinishDlpJobAsync(FinishDlpJobRequest, CallSettings)
            // Additional: FinishDlpJobAsync(FinishDlpJobRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            FinishDlpJobRequest request = new FinishDlpJobRequest
            {
                DlpJobName = DlpJobName.FromProjectDlpJob("[PROJECT]", "[DLP_JOB]"),
            };
            // Make the request
            await dlpServiceClient.FinishDlpJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnectionRequestObject()
        {
            // Snippet: CreateConnection(CreateConnectionRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Connection = new Connection(),
            };
            // Make the request
            Connection response = dlpServiceClient.CreateConnection(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionAsync</summary>
        public async Task CreateConnectionRequestObjectAsync()
        {
            // Snippet: CreateConnectionAsync(CreateConnectionRequest, CallSettings)
            // Additional: CreateConnectionAsync(CreateConnectionRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Connection = new Connection(),
            };
            // Make the request
            Connection response = await dlpServiceClient.CreateConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnection()
        {
            // Snippet: CreateConnection(string, Connection, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Connection connection = new Connection();
            // Make the request
            Connection response = dlpServiceClient.CreateConnection(parent, connection);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionAsync</summary>
        public async Task CreateConnectionAsync()
        {
            // Snippet: CreateConnectionAsync(string, Connection, CallSettings)
            // Additional: CreateConnectionAsync(string, Connection, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Connection connection = new Connection();
            // Make the request
            Connection response = await dlpServiceClient.CreateConnectionAsync(parent, connection);
            // End snippet
        }

        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnectionResourceNames()
        {
            // Snippet: CreateConnection(LocationName, Connection, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Connection connection = new Connection();
            // Make the request
            Connection response = dlpServiceClient.CreateConnection(parent, connection);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionAsync</summary>
        public async Task CreateConnectionResourceNamesAsync()
        {
            // Snippet: CreateConnectionAsync(LocationName, Connection, CallSettings)
            // Additional: CreateConnectionAsync(LocationName, Connection, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Connection connection = new Connection();
            // Make the request
            Connection response = await dlpServiceClient.CreateConnectionAsync(parent, connection);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnectionRequestObject()
        {
            // Snippet: GetConnection(GetConnectionRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            Connection response = dlpServiceClient.GetConnection(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionRequestObjectAsync()
        {
            // Snippet: GetConnectionAsync(GetConnectionRequest, CallSettings)
            // Additional: GetConnectionAsync(GetConnectionRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            Connection response = await dlpServiceClient.GetConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnection()
        {
            // Snippet: GetConnection(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Connection response = dlpServiceClient.GetConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionAsync()
        {
            // Snippet: GetConnectionAsync(string, CallSettings)
            // Additional: GetConnectionAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Connection response = await dlpServiceClient.GetConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnectionResourceNames()
        {
            // Snippet: GetConnection(ConnectionName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Connection response = dlpServiceClient.GetConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionResourceNamesAsync()
        {
            // Snippet: GetConnectionAsync(ConnectionName, CallSettings)
            // Additional: GetConnectionAsync(ConnectionName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Connection response = await dlpServiceClient.GetConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConnections</summary>
        public void ListConnectionsRequestObject()
        {
            // Snippet: ListConnections(ListConnectionsRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = dlpServiceClient.ListConnections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionsAsync</summary>
        public async Task ListConnectionsRequestObjectAsync()
        {
            // Snippet: ListConnectionsAsync(ListConnectionsRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = dlpServiceClient.ListConnectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnections</summary>
        public void ListConnections()
        {
            // Snippet: ListConnections(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = dlpServiceClient.ListConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionsAsync</summary>
        public async Task ListConnectionsAsync()
        {
            // Snippet: ListConnectionsAsync(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = dlpServiceClient.ListConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnections</summary>
        public void ListConnectionsResourceNames()
        {
            // Snippet: ListConnections(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = dlpServiceClient.ListConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionsAsync</summary>
        public async Task ListConnectionsResourceNamesAsync()
        {
            // Snippet: ListConnectionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = dlpServiceClient.ListConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchConnections</summary>
        public void SearchConnectionsRequestObject()
        {
            // Snippet: SearchConnections(SearchConnectionsRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            SearchConnectionsRequest request = new SearchConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<SearchConnectionsResponse, Connection> response = dlpServiceClient.SearchConnections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchConnectionsAsync</summary>
        public async Task SearchConnectionsRequestObjectAsync()
        {
            // Snippet: SearchConnectionsAsync(SearchConnectionsRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchConnectionsRequest request = new SearchConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchConnectionsResponse, Connection> response = dlpServiceClient.SearchConnectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchConnections</summary>
        public void SearchConnections()
        {
            // Snippet: SearchConnections(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<SearchConnectionsResponse, Connection> response = dlpServiceClient.SearchConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchConnectionsAsync</summary>
        public async Task SearchConnectionsAsync()
        {
            // Snippet: SearchConnectionsAsync(string, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<SearchConnectionsResponse, Connection> response = dlpServiceClient.SearchConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchConnections</summary>
        public void SearchConnectionsResourceNames()
        {
            // Snippet: SearchConnections(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<SearchConnectionsResponse, Connection> response = dlpServiceClient.SearchConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchConnectionsAsync</summary>
        public async Task SearchConnectionsResourceNamesAsync()
        {
            // Snippet: SearchConnectionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<SearchConnectionsResponse, Connection> response = dlpServiceClient.SearchConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteConnection</summary>
        public void DeleteConnectionRequestObject()
        {
            // Snippet: DeleteConnection(DeleteConnectionRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            dlpServiceClient.DeleteConnection(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionAsync</summary>
        public async Task DeleteConnectionRequestObjectAsync()
        {
            // Snippet: DeleteConnectionAsync(DeleteConnectionRequest, CallSettings)
            // Additional: DeleteConnectionAsync(DeleteConnectionRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            await dlpServiceClient.DeleteConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnection</summary>
        public void DeleteConnection()
        {
            // Snippet: DeleteConnection(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            dlpServiceClient.DeleteConnection(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionAsync</summary>
        public async Task DeleteConnectionAsync()
        {
            // Snippet: DeleteConnectionAsync(string, CallSettings)
            // Additional: DeleteConnectionAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            await dlpServiceClient.DeleteConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnection</summary>
        public void DeleteConnectionResourceNames()
        {
            // Snippet: DeleteConnection(ConnectionName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            dlpServiceClient.DeleteConnection(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionAsync</summary>
        public async Task DeleteConnectionResourceNamesAsync()
        {
            // Snippet: DeleteConnectionAsync(ConnectionName, CallSettings)
            // Additional: DeleteConnectionAsync(ConnectionName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            await dlpServiceClient.DeleteConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnection</summary>
        public void UpdateConnectionRequestObject()
        {
            // Snippet: UpdateConnection(UpdateConnectionRequest, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Connection = new Connection(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Connection response = dlpServiceClient.UpdateConnection(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionAsync</summary>
        public async Task UpdateConnectionRequestObjectAsync()
        {
            // Snippet: UpdateConnectionAsync(UpdateConnectionRequest, CallSettings)
            // Additional: UpdateConnectionAsync(UpdateConnectionRequest, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Connection = new Connection(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Connection response = await dlpServiceClient.UpdateConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnection</summary>
        public void UpdateConnection()
        {
            // Snippet: UpdateConnection(string, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Connection response = dlpServiceClient.UpdateConnection(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionAsync</summary>
        public async Task UpdateConnectionAsync()
        {
            // Snippet: UpdateConnectionAsync(string, CallSettings)
            // Additional: UpdateConnectionAsync(string, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Connection response = await dlpServiceClient.UpdateConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnection</summary>
        public void UpdateConnectionResourceNames()
        {
            // Snippet: UpdateConnection(ConnectionName, CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Connection response = dlpServiceClient.UpdateConnection(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionAsync</summary>
        public async Task UpdateConnectionResourceNamesAsync()
        {
            // Snippet: UpdateConnectionAsync(ConnectionName, CallSettings)
            // Additional: UpdateConnectionAsync(ConnectionName, CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Connection response = await dlpServiceClient.UpdateConnectionAsync(name);
            // End snippet
        }
    }
}
