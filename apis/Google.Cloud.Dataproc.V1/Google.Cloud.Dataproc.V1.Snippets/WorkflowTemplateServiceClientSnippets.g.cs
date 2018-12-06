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

namespace Google.Cloud.Dataproc.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Dataproc.V1;
    using Google.LongRunning;
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
    public class GeneratedWorkflowTemplateServiceClientSnippets
    {
        /// <summary>Snippet for CreateWorkflowTemplateAsync</summary>
        public async Task CreateWorkflowTemplateAsync()
        {
            // Snippet: CreateWorkflowTemplateAsync(string,WorkflowTemplate,CallSettings)
            // Additional: CreateWorkflowTemplateAsync(string,WorkflowTemplate,CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new RegionName("[PROJECT]", "[REGION]").ToString();
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.CreateWorkflowTemplateAsync(formattedParent, template);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowTemplate</summary>
        public void CreateWorkflowTemplate()
        {
            // Snippet: CreateWorkflowTemplate(string,WorkflowTemplate,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new RegionName("[PROJECT]", "[REGION]").ToString();
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.CreateWorkflowTemplate(formattedParent, template);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowTemplateAsync</summary>
        public async Task CreateWorkflowTemplateAsync_RequestObject()
        {
            // Snippet: CreateWorkflowTemplateAsync(CreateWorkflowTemplateRequest,CallSettings)
            // Additional: CreateWorkflowTemplateAsync(CreateWorkflowTemplateRequest,CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                Parent = new RegionName("[PROJECT]", "[REGION]").ToString(),
                Template = new WorkflowTemplate(),
            };
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.CreateWorkflowTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowTemplate</summary>
        public void CreateWorkflowTemplate_RequestObject()
        {
            // Snippet: CreateWorkflowTemplate(CreateWorkflowTemplateRequest,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                Parent = new RegionName("[PROJECT]", "[REGION]").ToString(),
                Template = new WorkflowTemplate(),
            };
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.CreateWorkflowTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowTemplateAsync</summary>
        public async Task GetWorkflowTemplateAsync()
        {
            // Snippet: GetWorkflowTemplateAsync(string,CallSettings)
            // Additional: GetWorkflowTemplateAsync(string,CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString();
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.GetWorkflowTemplateAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowTemplate</summary>
        public void GetWorkflowTemplate()
        {
            // Snippet: GetWorkflowTemplate(string,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString();
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.GetWorkflowTemplate(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowTemplateAsync</summary>
        public async Task GetWorkflowTemplateAsync_RequestObject()
        {
            // Snippet: GetWorkflowTemplateAsync(GetWorkflowTemplateRequest,CallSettings)
            // Additional: GetWorkflowTemplateAsync(GetWorkflowTemplateRequest,CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                Name = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString(),
            };
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.GetWorkflowTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowTemplate</summary>
        public void GetWorkflowTemplate_RequestObject()
        {
            // Snippet: GetWorkflowTemplate(GetWorkflowTemplateRequest,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                Name = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString(),
            };
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.GetWorkflowTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplateAsync</summary>
        public async Task InstantiateWorkflowTemplateAsync1()
        {
            // Snippet: InstantiateWorkflowTemplateAsync(string,CallSettings)
            // Additional: InstantiateWorkflowTemplateAsync(string,CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString();
            // Make the request
            Operation<Empty, WorkflowMetadata> response =
                await workflowTemplateServiceClient.InstantiateWorkflowTemplateAsync(formattedName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse =
                await workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplate</summary>
        public void InstantiateWorkflowTemplate1()
        {
            // Snippet: InstantiateWorkflowTemplate(string,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString();
            // Make the request
            Operation<Empty, WorkflowMetadata> response =
                workflowTemplateServiceClient.InstantiateWorkflowTemplate(formattedName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse =
                workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplateAsync</summary>
        public async Task InstantiateWorkflowTemplateAsync2()
        {
            // Snippet: InstantiateWorkflowTemplateAsync(string,IDictionary<string, string>,CallSettings)
            // Additional: InstantiateWorkflowTemplateAsync(string,IDictionary<string, string>,CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString();
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            // Make the request
            Operation<Empty, WorkflowMetadata> response =
                await workflowTemplateServiceClient.InstantiateWorkflowTemplateAsync(formattedName, parameters);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse =
                await workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplate</summary>
        public void InstantiateWorkflowTemplate2()
        {
            // Snippet: InstantiateWorkflowTemplate(string,IDictionary<string, string>,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString();
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            // Make the request
            Operation<Empty, WorkflowMetadata> response =
                workflowTemplateServiceClient.InstantiateWorkflowTemplate(formattedName, parameters);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse =
                workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplateAsync</summary>
        public async Task InstantiateWorkflowTemplateAsync_RequestObject()
        {
            // Snippet: InstantiateWorkflowTemplateAsync(InstantiateWorkflowTemplateRequest,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstantiateWorkflowTemplateRequest request = new InstantiateWorkflowTemplateRequest
            {
                Name = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString(),
            };
            // Make the request
            Operation<Empty, WorkflowMetadata> response =
                await workflowTemplateServiceClient.InstantiateWorkflowTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse =
                await workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplate</summary>
        public void InstantiateWorkflowTemplate_RequestObject()
        {
            // Snippet: InstantiateWorkflowTemplate(InstantiateWorkflowTemplateRequest,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            InstantiateWorkflowTemplateRequest request = new InstantiateWorkflowTemplateRequest
            {
                Name = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString(),
            };
            // Make the request
            Operation<Empty, WorkflowMetadata> response =
                workflowTemplateServiceClient.InstantiateWorkflowTemplate(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse =
                workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateInlineWorkflowTemplateAsync</summary>
        public async Task InstantiateInlineWorkflowTemplateAsync()
        {
            // Snippet: InstantiateInlineWorkflowTemplateAsync(string,WorkflowTemplate,CallSettings)
            // Additional: InstantiateInlineWorkflowTemplateAsync(string,WorkflowTemplate,CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new RegionName("[PROJECT]", "[REGION]").ToString();
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            Operation<Empty, WorkflowMetadata> response =
                await workflowTemplateServiceClient.InstantiateInlineWorkflowTemplateAsync(formattedParent, template);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse =
                await workflowTemplateServiceClient.PollOnceInstantiateInlineWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateInlineWorkflowTemplate</summary>
        public void InstantiateInlineWorkflowTemplate()
        {
            // Snippet: InstantiateInlineWorkflowTemplate(string,WorkflowTemplate,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new RegionName("[PROJECT]", "[REGION]").ToString();
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            Operation<Empty, WorkflowMetadata> response =
                workflowTemplateServiceClient.InstantiateInlineWorkflowTemplate(formattedParent, template);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse =
                workflowTemplateServiceClient.PollOnceInstantiateInlineWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateInlineWorkflowTemplateAsync</summary>
        public async Task InstantiateInlineWorkflowTemplateAsync_RequestObject()
        {
            // Snippet: InstantiateInlineWorkflowTemplateAsync(InstantiateInlineWorkflowTemplateRequest,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstantiateInlineWorkflowTemplateRequest request = new InstantiateInlineWorkflowTemplateRequest
            {
                Parent = new RegionName("[PROJECT]", "[REGION]").ToString(),
                Template = new WorkflowTemplate(),
            };
            // Make the request
            Operation<Empty, WorkflowMetadata> response =
                await workflowTemplateServiceClient.InstantiateInlineWorkflowTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse =
                await workflowTemplateServiceClient.PollOnceInstantiateInlineWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateInlineWorkflowTemplate</summary>
        public void InstantiateInlineWorkflowTemplate_RequestObject()
        {
            // Snippet: InstantiateInlineWorkflowTemplate(InstantiateInlineWorkflowTemplateRequest,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            InstantiateInlineWorkflowTemplateRequest request = new InstantiateInlineWorkflowTemplateRequest
            {
                Parent = new RegionName("[PROJECT]", "[REGION]").ToString(),
                Template = new WorkflowTemplate(),
            };
            // Make the request
            Operation<Empty, WorkflowMetadata> response =
                workflowTemplateServiceClient.InstantiateInlineWorkflowTemplate(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse =
                workflowTemplateServiceClient.PollOnceInstantiateInlineWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflowTemplateAsync</summary>
        public async Task UpdateWorkflowTemplateAsync()
        {
            // Snippet: UpdateWorkflowTemplateAsync(WorkflowTemplate,CallSettings)
            // Additional: UpdateWorkflowTemplateAsync(WorkflowTemplate,CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.UpdateWorkflowTemplateAsync(template);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflowTemplate</summary>
        public void UpdateWorkflowTemplate()
        {
            // Snippet: UpdateWorkflowTemplate(WorkflowTemplate,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.UpdateWorkflowTemplate(template);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflowTemplateAsync</summary>
        public async Task UpdateWorkflowTemplateAsync_RequestObject()
        {
            // Snippet: UpdateWorkflowTemplateAsync(UpdateWorkflowTemplateRequest,CallSettings)
            // Additional: UpdateWorkflowTemplateAsync(UpdateWorkflowTemplateRequest,CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWorkflowTemplateRequest request = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate(),
            };
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.UpdateWorkflowTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflowTemplate</summary>
        public void UpdateWorkflowTemplate_RequestObject()
        {
            // Snippet: UpdateWorkflowTemplate(UpdateWorkflowTemplateRequest,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            UpdateWorkflowTemplateRequest request = new UpdateWorkflowTemplateRequest
            {
                Template = new WorkflowTemplate(),
            };
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.UpdateWorkflowTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowTemplatesAsync</summary>
        public async Task ListWorkflowTemplatesAsync()
        {
            // Snippet: ListWorkflowTemplatesAsync(string,string,int?,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new RegionName("[PROJECT]", "[REGION]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> response =
                workflowTemplateServiceClient.ListWorkflowTemplatesAsync(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkflowTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkflowTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkflowTemplate item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkflowTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkflowTemplate item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowTemplates</summary>
        public void ListWorkflowTemplates()
        {
            // Snippet: ListWorkflowTemplates(string,string,int?,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new RegionName("[PROJECT]", "[REGION]").ToString();
            // Make the request
            PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> response =
                workflowTemplateServiceClient.ListWorkflowTemplates(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkflowTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkflowTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkflowTemplate item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkflowTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkflowTemplate item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowTemplatesAsync</summary>
        public async Task ListWorkflowTemplatesAsync_RequestObject()
        {
            // Snippet: ListWorkflowTemplatesAsync(ListWorkflowTemplatesRequest,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkflowTemplatesRequest request = new ListWorkflowTemplatesRequest
            {
                Parent = new RegionName("[PROJECT]", "[REGION]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> response =
                workflowTemplateServiceClient.ListWorkflowTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkflowTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkflowTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkflowTemplate item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkflowTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkflowTemplate item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowTemplates</summary>
        public void ListWorkflowTemplates_RequestObject()
        {
            // Snippet: ListWorkflowTemplates(ListWorkflowTemplatesRequest,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            ListWorkflowTemplatesRequest request = new ListWorkflowTemplatesRequest
            {
                Parent = new RegionName("[PROJECT]", "[REGION]").ToString(),
            };
            // Make the request
            PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> response =
                workflowTemplateServiceClient.ListWorkflowTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkflowTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkflowTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkflowTemplate item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkflowTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkflowTemplate item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowTemplateAsync</summary>
        public async Task DeleteWorkflowTemplateAsync()
        {
            // Snippet: DeleteWorkflowTemplateAsync(string,CallSettings)
            // Additional: DeleteWorkflowTemplateAsync(string,CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString();
            // Make the request
            await workflowTemplateServiceClient.DeleteWorkflowTemplateAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowTemplate</summary>
        public void DeleteWorkflowTemplate()
        {
            // Snippet: DeleteWorkflowTemplate(string,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString();
            // Make the request
            workflowTemplateServiceClient.DeleteWorkflowTemplate(formattedName);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowTemplateAsync</summary>
        public async Task DeleteWorkflowTemplateAsync_RequestObject()
        {
            // Snippet: DeleteWorkflowTemplateAsync(DeleteWorkflowTemplateRequest,CallSettings)
            // Additional: DeleteWorkflowTemplateAsync(DeleteWorkflowTemplateRequest,CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                Name = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString(),
            };
            // Make the request
            await workflowTemplateServiceClient.DeleteWorkflowTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowTemplate</summary>
        public void DeleteWorkflowTemplate_RequestObject()
        {
            // Snippet: DeleteWorkflowTemplate(DeleteWorkflowTemplateRequest,CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                Name = new WorkflowTemplateName("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]").ToString(),
            };
            // Make the request
            workflowTemplateServiceClient.DeleteWorkflowTemplate(request);
            // End snippet
        }

    }
}
