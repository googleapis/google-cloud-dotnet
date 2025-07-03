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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ModelArmor.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedModelArmorClientSnippets
    {
        /// <summary>Snippet for ListTemplates</summary>
        public void ListTemplatesRequestObject()
        {
            // Snippet: ListTemplates(ListTemplatesRequest, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            ListTemplatesRequest request = new ListTemplatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListTemplatesResponse, Template> response = modelArmorClient.ListTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Template item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Template item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Template> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Template item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplatesAsync</summary>
        public async Task ListTemplatesRequestObjectAsync()
        {
            // Snippet: ListTemplatesAsync(ListTemplatesRequest, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            ListTemplatesRequest request = new ListTemplatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTemplatesResponse, Template> response = modelArmorClient.ListTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Template item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Template item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Template> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Template item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplates</summary>
        public void ListTemplates()
        {
            // Snippet: ListTemplates(string, string, int?, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTemplatesResponse, Template> response = modelArmorClient.ListTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Template item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Template item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Template> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Template item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplatesAsync</summary>
        public async Task ListTemplatesAsync()
        {
            // Snippet: ListTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTemplatesResponse, Template> response = modelArmorClient.ListTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Template item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Template item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Template> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Template item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplates</summary>
        public void ListTemplatesResourceNames()
        {
            // Snippet: ListTemplates(LocationName, string, int?, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTemplatesResponse, Template> response = modelArmorClient.ListTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Template item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Template item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Template> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Template item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplatesAsync</summary>
        public async Task ListTemplatesResourceNamesAsync()
        {
            // Snippet: ListTemplatesAsync(LocationName, string, int?, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTemplatesResponse, Template> response = modelArmorClient.ListTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Template item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Template item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Template> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Template item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTemplate</summary>
        public void GetTemplateRequestObject()
        {
            // Snippet: GetTemplate(GetTemplateRequest, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            GetTemplateRequest request = new GetTemplateRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
            };
            // Make the request
            Template response = modelArmorClient.GetTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetTemplateAsync</summary>
        public async Task GetTemplateRequestObjectAsync()
        {
            // Snippet: GetTemplateAsync(GetTemplateRequest, CallSettings)
            // Additional: GetTemplateAsync(GetTemplateRequest, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            GetTemplateRequest request = new GetTemplateRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
            };
            // Make the request
            Template response = await modelArmorClient.GetTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTemplate</summary>
        public void GetTemplate()
        {
            // Snippet: GetTemplate(string, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]";
            // Make the request
            Template response = modelArmorClient.GetTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetTemplateAsync</summary>
        public async Task GetTemplateAsync()
        {
            // Snippet: GetTemplateAsync(string, CallSettings)
            // Additional: GetTemplateAsync(string, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]";
            // Make the request
            Template response = await modelArmorClient.GetTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTemplate</summary>
        public void GetTemplateResourceNames()
        {
            // Snippet: GetTemplate(TemplateName, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            TemplateName name = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            Template response = modelArmorClient.GetTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetTemplateAsync</summary>
        public async Task GetTemplateResourceNamesAsync()
        {
            // Snippet: GetTemplateAsync(TemplateName, CallSettings)
            // Additional: GetTemplateAsync(TemplateName, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            TemplateName name = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            Template response = await modelArmorClient.GetTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplate</summary>
        public void CreateTemplateRequestObject()
        {
            // Snippet: CreateTemplate(CreateTemplateRequest, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            CreateTemplateRequest request = new CreateTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TemplateId = "",
                Template = new Template(),
                RequestId = "",
            };
            // Make the request
            Template response = modelArmorClient.CreateTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplateAsync</summary>
        public async Task CreateTemplateRequestObjectAsync()
        {
            // Snippet: CreateTemplateAsync(CreateTemplateRequest, CallSettings)
            // Additional: CreateTemplateAsync(CreateTemplateRequest, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            CreateTemplateRequest request = new CreateTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TemplateId = "",
                Template = new Template(),
                RequestId = "",
            };
            // Make the request
            Template response = await modelArmorClient.CreateTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplate</summary>
        public void CreateTemplate()
        {
            // Snippet: CreateTemplate(string, Template, string, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Template template = new Template();
            string templateId = "";
            // Make the request
            Template response = modelArmorClient.CreateTemplate(parent, template, templateId);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplateAsync</summary>
        public async Task CreateTemplateAsync()
        {
            // Snippet: CreateTemplateAsync(string, Template, string, CallSettings)
            // Additional: CreateTemplateAsync(string, Template, string, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Template template = new Template();
            string templateId = "";
            // Make the request
            Template response = await modelArmorClient.CreateTemplateAsync(parent, template, templateId);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplate</summary>
        public void CreateTemplateResourceNames()
        {
            // Snippet: CreateTemplate(LocationName, Template, string, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Template template = new Template();
            string templateId = "";
            // Make the request
            Template response = modelArmorClient.CreateTemplate(parent, template, templateId);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplateAsync</summary>
        public async Task CreateTemplateResourceNamesAsync()
        {
            // Snippet: CreateTemplateAsync(LocationName, Template, string, CallSettings)
            // Additional: CreateTemplateAsync(LocationName, Template, string, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Template template = new Template();
            string templateId = "";
            // Make the request
            Template response = await modelArmorClient.CreateTemplateAsync(parent, template, templateId);
            // End snippet
        }

        /// <summary>Snippet for UpdateTemplate</summary>
        public void UpdateTemplateRequestObject()
        {
            // Snippet: UpdateTemplate(UpdateTemplateRequest, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            UpdateTemplateRequest request = new UpdateTemplateRequest
            {
                UpdateMask = new FieldMask(),
                Template = new Template(),
                RequestId = "",
            };
            // Make the request
            Template response = modelArmorClient.UpdateTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTemplateAsync</summary>
        public async Task UpdateTemplateRequestObjectAsync()
        {
            // Snippet: UpdateTemplateAsync(UpdateTemplateRequest, CallSettings)
            // Additional: UpdateTemplateAsync(UpdateTemplateRequest, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTemplateRequest request = new UpdateTemplateRequest
            {
                UpdateMask = new FieldMask(),
                Template = new Template(),
                RequestId = "",
            };
            // Make the request
            Template response = await modelArmorClient.UpdateTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTemplate</summary>
        public void UpdateTemplate()
        {
            // Snippet: UpdateTemplate(Template, FieldMask, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            Template template = new Template();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Template response = modelArmorClient.UpdateTemplate(template, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTemplateAsync</summary>
        public async Task UpdateTemplateAsync()
        {
            // Snippet: UpdateTemplateAsync(Template, FieldMask, CallSettings)
            // Additional: UpdateTemplateAsync(Template, FieldMask, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            Template template = new Template();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Template response = await modelArmorClient.UpdateTemplateAsync(template, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplate</summary>
        public void DeleteTemplateRequestObject()
        {
            // Snippet: DeleteTemplate(DeleteTemplateRequest, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            DeleteTemplateRequest request = new DeleteTemplateRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                RequestId = "",
            };
            // Make the request
            modelArmorClient.DeleteTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplateAsync</summary>
        public async Task DeleteTemplateRequestObjectAsync()
        {
            // Snippet: DeleteTemplateAsync(DeleteTemplateRequest, CallSettings)
            // Additional: DeleteTemplateAsync(DeleteTemplateRequest, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTemplateRequest request = new DeleteTemplateRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                RequestId = "",
            };
            // Make the request
            await modelArmorClient.DeleteTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplate</summary>
        public void DeleteTemplate()
        {
            // Snippet: DeleteTemplate(string, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]";
            // Make the request
            modelArmorClient.DeleteTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplateAsync</summary>
        public async Task DeleteTemplateAsync()
        {
            // Snippet: DeleteTemplateAsync(string, CallSettings)
            // Additional: DeleteTemplateAsync(string, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]";
            // Make the request
            await modelArmorClient.DeleteTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplate</summary>
        public void DeleteTemplateResourceNames()
        {
            // Snippet: DeleteTemplate(TemplateName, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            TemplateName name = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            modelArmorClient.DeleteTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplateAsync</summary>
        public async Task DeleteTemplateResourceNamesAsync()
        {
            // Snippet: DeleteTemplateAsync(TemplateName, CallSettings)
            // Additional: DeleteTemplateAsync(TemplateName, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            TemplateName name = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            await modelArmorClient.DeleteTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFloorSetting</summary>
        public void GetFloorSettingRequestObject()
        {
            // Snippet: GetFloorSetting(GetFloorSettingRequest, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            GetFloorSettingRequest request = new GetFloorSettingRequest
            {
                FloorSettingName = FloorSettingName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            FloorSetting response = modelArmorClient.GetFloorSetting(request);
            // End snippet
        }

        /// <summary>Snippet for GetFloorSettingAsync</summary>
        public async Task GetFloorSettingRequestObjectAsync()
        {
            // Snippet: GetFloorSettingAsync(GetFloorSettingRequest, CallSettings)
            // Additional: GetFloorSettingAsync(GetFloorSettingRequest, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            GetFloorSettingRequest request = new GetFloorSettingRequest
            {
                FloorSettingName = FloorSettingName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            FloorSetting response = await modelArmorClient.GetFloorSettingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFloorSetting</summary>
        public void GetFloorSetting()
        {
            // Snippet: GetFloorSetting(string, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/floorSetting";
            // Make the request
            FloorSetting response = modelArmorClient.GetFloorSetting(name);
            // End snippet
        }

        /// <summary>Snippet for GetFloorSettingAsync</summary>
        public async Task GetFloorSettingAsync()
        {
            // Snippet: GetFloorSettingAsync(string, CallSettings)
            // Additional: GetFloorSettingAsync(string, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/floorSetting";
            // Make the request
            FloorSetting response = await modelArmorClient.GetFloorSettingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFloorSetting</summary>
        public void GetFloorSettingResourceNames()
        {
            // Snippet: GetFloorSetting(FloorSettingName, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            FloorSettingName name = FloorSettingName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            FloorSetting response = modelArmorClient.GetFloorSetting(name);
            // End snippet
        }

        /// <summary>Snippet for GetFloorSettingAsync</summary>
        public async Task GetFloorSettingResourceNamesAsync()
        {
            // Snippet: GetFloorSettingAsync(FloorSettingName, CallSettings)
            // Additional: GetFloorSettingAsync(FloorSettingName, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            FloorSettingName name = FloorSettingName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            FloorSetting response = await modelArmorClient.GetFloorSettingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateFloorSetting</summary>
        public void UpdateFloorSettingRequestObject()
        {
            // Snippet: UpdateFloorSetting(UpdateFloorSettingRequest, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            UpdateFloorSettingRequest request = new UpdateFloorSettingRequest
            {
                FloorSetting = new FloorSetting(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            FloorSetting response = modelArmorClient.UpdateFloorSetting(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFloorSettingAsync</summary>
        public async Task UpdateFloorSettingRequestObjectAsync()
        {
            // Snippet: UpdateFloorSettingAsync(UpdateFloorSettingRequest, CallSettings)
            // Additional: UpdateFloorSettingAsync(UpdateFloorSettingRequest, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFloorSettingRequest request = new UpdateFloorSettingRequest
            {
                FloorSetting = new FloorSetting(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            FloorSetting response = await modelArmorClient.UpdateFloorSettingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFloorSetting</summary>
        public void UpdateFloorSetting()
        {
            // Snippet: UpdateFloorSetting(FloorSetting, FieldMask, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            FloorSetting floorSetting = new FloorSetting();
            FieldMask updateMask = new FieldMask();
            // Make the request
            FloorSetting response = modelArmorClient.UpdateFloorSetting(floorSetting, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFloorSettingAsync</summary>
        public async Task UpdateFloorSettingAsync()
        {
            // Snippet: UpdateFloorSettingAsync(FloorSetting, FieldMask, CallSettings)
            // Additional: UpdateFloorSettingAsync(FloorSetting, FieldMask, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            FloorSetting floorSetting = new FloorSetting();
            FieldMask updateMask = new FieldMask();
            // Make the request
            FloorSetting response = await modelArmorClient.UpdateFloorSettingAsync(floorSetting, updateMask);
            // End snippet
        }

        /// <summary>Snippet for SanitizeUserPrompt</summary>
        public void SanitizeUserPromptRequestObject()
        {
            // Snippet: SanitizeUserPrompt(SanitizeUserPromptRequest, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            SanitizeUserPromptRequest request = new SanitizeUserPromptRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                UserPromptData = new DataItem(),
                MultiLanguageDetectionMetadata = new MultiLanguageDetectionMetadata(),
            };
            // Make the request
            SanitizeUserPromptResponse response = modelArmorClient.SanitizeUserPrompt(request);
            // End snippet
        }

        /// <summary>Snippet for SanitizeUserPromptAsync</summary>
        public async Task SanitizeUserPromptRequestObjectAsync()
        {
            // Snippet: SanitizeUserPromptAsync(SanitizeUserPromptRequest, CallSettings)
            // Additional: SanitizeUserPromptAsync(SanitizeUserPromptRequest, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            SanitizeUserPromptRequest request = new SanitizeUserPromptRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                UserPromptData = new DataItem(),
                MultiLanguageDetectionMetadata = new MultiLanguageDetectionMetadata(),
            };
            // Make the request
            SanitizeUserPromptResponse response = await modelArmorClient.SanitizeUserPromptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SanitizeModelResponse</summary>
        public void SanitizeModelResponseRequestObject()
        {
            // Snippet: SanitizeModelResponse(SanitizeModelResponseRequest, CallSettings)
            // Create client
            ModelArmorClient modelArmorClient = ModelArmorClient.Create();
            // Initialize request argument(s)
            SanitizeModelResponseRequest request = new SanitizeModelResponseRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                ModelResponseData = new DataItem(),
                UserPrompt = "",
                MultiLanguageDetectionMetadata = new MultiLanguageDetectionMetadata(),
            };
            // Make the request
            SanitizeModelResponseResponse response = modelArmorClient.SanitizeModelResponse(request);
            // End snippet
        }

        /// <summary>Snippet for SanitizeModelResponseAsync</summary>
        public async Task SanitizeModelResponseRequestObjectAsync()
        {
            // Snippet: SanitizeModelResponseAsync(SanitizeModelResponseRequest, CallSettings)
            // Additional: SanitizeModelResponseAsync(SanitizeModelResponseRequest, CancellationToken)
            // Create client
            ModelArmorClient modelArmorClient = await ModelArmorClient.CreateAsync();
            // Initialize request argument(s)
            SanitizeModelResponseRequest request = new SanitizeModelResponseRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                ModelResponseData = new DataItem(),
                UserPrompt = "",
                MultiLanguageDetectionMetadata = new MultiLanguageDetectionMetadata(),
            };
            // Make the request
            SanitizeModelResponseResponse response = await modelArmorClient.SanitizeModelResponseAsync(request);
            // End snippet
        }
    }
}
