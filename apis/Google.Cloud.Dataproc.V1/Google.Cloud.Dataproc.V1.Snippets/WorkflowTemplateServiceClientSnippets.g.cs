// Copyright 2020 Google LLC
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
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedWorkflowTemplateServiceClientSnippets
    {
        /// <summary>Snippet for CreateWorkflowTemplate</summary>
        public void CreateWorkflowTemplate_RequestObject()
        {
            // Snippet: CreateWorkflowTemplate(CreateWorkflowTemplateRequest, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsWorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Template = new WorkflowTemplate(),
            };
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.CreateWorkflowTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowTemplateAsync</summary>
        public async Task CreateWorkflowTemplateAsync_RequestObject()
        {
            // Snippet: CreateWorkflowTemplateAsync(CreateWorkflowTemplateRequest, CallSettings)
            // Additional: CreateWorkflowTemplateAsync(CreateWorkflowTemplateRequest, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkflowTemplateRequest request = new CreateWorkflowTemplateRequest
            {
                ParentAsWorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Template = new WorkflowTemplate(),
            };
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.CreateWorkflowTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowTemplate</summary>
        public void CreateWorkflowTemplate()
        {
            // Snippet: CreateWorkflowTemplate(string, WorkflowTemplate, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.CreateWorkflowTemplate(parent, template);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowTemplateAsync</summary>
        public async Task CreateWorkflowTemplateAsync()
        {
            // Snippet: CreateWorkflowTemplateAsync(string, WorkflowTemplate, CallSettings)
            // Additional: CreateWorkflowTemplateAsync(string, WorkflowTemplate, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.CreateWorkflowTemplateAsync(parent, template);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowTemplate</summary>
        public void CreateWorkflowTemplate_ResourceNames()
        {
            // Snippet: CreateWorkflowTemplate(WorkflowTemplateName, WorkflowTemplate, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            WorkflowTemplateName parent = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.CreateWorkflowTemplate(parent, template);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowTemplateAsync</summary>
        public async Task CreateWorkflowTemplateAsync_ResourceNames()
        {
            // Snippet: CreateWorkflowTemplateAsync(WorkflowTemplateName, WorkflowTemplate, CallSettings)
            // Additional: CreateWorkflowTemplateAsync(WorkflowTemplateName, WorkflowTemplate, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowTemplateName parent = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.CreateWorkflowTemplateAsync(parent, template);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowTemplate</summary>
        public void GetWorkflowTemplate_RequestObject()
        {
            // Snippet: GetWorkflowTemplate(GetWorkflowTemplateRequest, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 0,
            };
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.GetWorkflowTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowTemplateAsync</summary>
        public async Task GetWorkflowTemplateAsync_RequestObject()
        {
            // Snippet: GetWorkflowTemplateAsync(GetWorkflowTemplateRequest, CallSettings)
            // Additional: GetWorkflowTemplateAsync(GetWorkflowTemplateRequest, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkflowTemplateRequest request = new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 0,
            };
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.GetWorkflowTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowTemplate</summary>
        public void GetWorkflowTemplate()
        {
            // Snippet: GetWorkflowTemplate(string, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.GetWorkflowTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowTemplateAsync</summary>
        public async Task GetWorkflowTemplateAsync()
        {
            // Snippet: GetWorkflowTemplateAsync(string, CallSettings)
            // Additional: GetWorkflowTemplateAsync(string, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.GetWorkflowTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowTemplate</summary>
        public void GetWorkflowTemplate_ResourceNames()
        {
            // Snippet: GetWorkflowTemplate(WorkflowTemplateName, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            WorkflowTemplateName name = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.GetWorkflowTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowTemplateAsync</summary>
        public async Task GetWorkflowTemplateAsync_ResourceNames()
        {
            // Snippet: GetWorkflowTemplateAsync(WorkflowTemplateName, CallSettings)
            // Additional: GetWorkflowTemplateAsync(WorkflowTemplateName, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowTemplateName name = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.GetWorkflowTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplate</summary>
        public void InstantiateWorkflowTemplate_RequestObject()
        {
            // Snippet: InstantiateWorkflowTemplate(InstantiateWorkflowTemplateRequest, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            InstantiateWorkflowTemplateRequest request = new InstantiateWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 0,
                RequestId = "",
                Parameters = { { "", "" }, },
            };
            // Make the request
            Operation<Empty, WorkflowMetadata> response = workflowTemplateServiceClient.InstantiateWorkflowTemplate(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplateAsync</summary>
        public async Task InstantiateWorkflowTemplateAsync_RequestObject()
        {
            // Snippet: InstantiateWorkflowTemplateAsync(InstantiateWorkflowTemplateRequest, CallSettings)
            // Additional: InstantiateWorkflowTemplateAsync(InstantiateWorkflowTemplateRequest, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstantiateWorkflowTemplateRequest request = new InstantiateWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 0,
                RequestId = "",
                Parameters = { { "", "" }, },
            };
            // Make the request
            Operation<Empty, WorkflowMetadata> response = await workflowTemplateServiceClient.InstantiateWorkflowTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = await workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplate</summary>
        public void InstantiateWorkflowTemplate1()
        {
            // Snippet: InstantiateWorkflowTemplate(string, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            // Make the request
            Operation<Empty, WorkflowMetadata> response = workflowTemplateServiceClient.InstantiateWorkflowTemplate(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplateAsync</summary>
        public async Task InstantiateWorkflowTemplate1Async()
        {
            // Snippet: InstantiateWorkflowTemplateAsync(string, CallSettings)
            // Additional: InstantiateWorkflowTemplateAsync(string, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            // Make the request
            Operation<Empty, WorkflowMetadata> response = await workflowTemplateServiceClient.InstantiateWorkflowTemplateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = await workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplate</summary>
        public void InstantiateWorkflowTemplate1_ResourceNames()
        {
            // Snippet: InstantiateWorkflowTemplate(WorkflowTemplateName, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            WorkflowTemplateName name = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            // Make the request
            Operation<Empty, WorkflowMetadata> response = workflowTemplateServiceClient.InstantiateWorkflowTemplate(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplateAsync</summary>
        public async Task InstantiateWorkflowTemplate1Async_ResourceNames()
        {
            // Snippet: InstantiateWorkflowTemplateAsync(WorkflowTemplateName, CallSettings)
            // Additional: InstantiateWorkflowTemplateAsync(WorkflowTemplateName, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowTemplateName name = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            // Make the request
            Operation<Empty, WorkflowMetadata> response = await workflowTemplateServiceClient.InstantiateWorkflowTemplateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = await workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplate</summary>
        public void InstantiateWorkflowTemplate2()
        {
            // Snippet: InstantiateWorkflowTemplate(string, IDictionary<string,string>, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            IDictionary<string, string> parameters = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            Operation<Empty, WorkflowMetadata> response = workflowTemplateServiceClient.InstantiateWorkflowTemplate(name, parameters);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplateAsync</summary>
        public async Task InstantiateWorkflowTemplate2Async()
        {
            // Snippet: InstantiateWorkflowTemplateAsync(string, IDictionary<string,string>, CallSettings)
            // Additional: InstantiateWorkflowTemplateAsync(string, IDictionary<string,string>, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            IDictionary<string, string> parameters = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            Operation<Empty, WorkflowMetadata> response = await workflowTemplateServiceClient.InstantiateWorkflowTemplateAsync(name, parameters);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = await workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplate</summary>
        public void InstantiateWorkflowTemplate2_ResourceNames()
        {
            // Snippet: InstantiateWorkflowTemplate(WorkflowTemplateName, IDictionary<string,string>, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            WorkflowTemplateName name = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            IDictionary<string, string> parameters = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            Operation<Empty, WorkflowMetadata> response = workflowTemplateServiceClient.InstantiateWorkflowTemplate(name, parameters);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateWorkflowTemplateAsync</summary>
        public async Task InstantiateWorkflowTemplate2Async_ResourceNames()
        {
            // Snippet: InstantiateWorkflowTemplateAsync(WorkflowTemplateName, IDictionary<string,string>, CallSettings)
            // Additional: InstantiateWorkflowTemplateAsync(WorkflowTemplateName, IDictionary<string,string>, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowTemplateName name = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            IDictionary<string, string> parameters = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            Operation<Empty, WorkflowMetadata> response = await workflowTemplateServiceClient.InstantiateWorkflowTemplateAsync(name, parameters);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = await workflowTemplateServiceClient.PollOnceInstantiateWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateInlineWorkflowTemplate</summary>
        public void InstantiateInlineWorkflowTemplate_RequestObject()
        {
            // Snippet: InstantiateInlineWorkflowTemplate(InstantiateInlineWorkflowTemplateRequest, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            InstantiateInlineWorkflowTemplateRequest request = new InstantiateInlineWorkflowTemplateRequest
            {
                ParentAsWorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Template = new WorkflowTemplate(),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, WorkflowMetadata> response = workflowTemplateServiceClient.InstantiateInlineWorkflowTemplate(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = workflowTemplateServiceClient.PollOnceInstantiateInlineWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateInlineWorkflowTemplateAsync</summary>
        public async Task InstantiateInlineWorkflowTemplateAsync_RequestObject()
        {
            // Snippet: InstantiateInlineWorkflowTemplateAsync(InstantiateInlineWorkflowTemplateRequest, CallSettings)
            // Additional: InstantiateInlineWorkflowTemplateAsync(InstantiateInlineWorkflowTemplateRequest, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstantiateInlineWorkflowTemplateRequest request = new InstantiateInlineWorkflowTemplateRequest
            {
                ParentAsWorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Template = new WorkflowTemplate(),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, WorkflowMetadata> response = await workflowTemplateServiceClient.InstantiateInlineWorkflowTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = await workflowTemplateServiceClient.PollOnceInstantiateInlineWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateInlineWorkflowTemplate</summary>
        public void InstantiateInlineWorkflowTemplate()
        {
            // Snippet: InstantiateInlineWorkflowTemplate(string, WorkflowTemplate, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            Operation<Empty, WorkflowMetadata> response = workflowTemplateServiceClient.InstantiateInlineWorkflowTemplate(parent, template);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = workflowTemplateServiceClient.PollOnceInstantiateInlineWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateInlineWorkflowTemplateAsync</summary>
        public async Task InstantiateInlineWorkflowTemplateAsync()
        {
            // Snippet: InstantiateInlineWorkflowTemplateAsync(string, WorkflowTemplate, CallSettings)
            // Additional: InstantiateInlineWorkflowTemplateAsync(string, WorkflowTemplate, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            Operation<Empty, WorkflowMetadata> response = await workflowTemplateServiceClient.InstantiateInlineWorkflowTemplateAsync(parent, template);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = await workflowTemplateServiceClient.PollOnceInstantiateInlineWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateInlineWorkflowTemplate</summary>
        public void InstantiateInlineWorkflowTemplate_ResourceNames()
        {
            // Snippet: InstantiateInlineWorkflowTemplate(WorkflowTemplateName, WorkflowTemplate, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            WorkflowTemplateName parent = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            Operation<Empty, WorkflowMetadata> response = workflowTemplateServiceClient.InstantiateInlineWorkflowTemplate(parent, template);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = workflowTemplateServiceClient.PollOnceInstantiateInlineWorkflowTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InstantiateInlineWorkflowTemplateAsync</summary>
        public async Task InstantiateInlineWorkflowTemplateAsync_ResourceNames()
        {
            // Snippet: InstantiateInlineWorkflowTemplateAsync(WorkflowTemplateName, WorkflowTemplate, CallSettings)
            // Additional: InstantiateInlineWorkflowTemplateAsync(WorkflowTemplateName, WorkflowTemplate, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowTemplateName parent = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            Operation<Empty, WorkflowMetadata> response = await workflowTemplateServiceClient.InstantiateInlineWorkflowTemplateAsync(parent, template);

            // Poll until the returned long-running operation is complete
            Operation<Empty, WorkflowMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, WorkflowMetadata> retrievedResponse = await workflowTemplateServiceClient.PollOnceInstantiateInlineWorkflowTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflowTemplate</summary>
        public void UpdateWorkflowTemplate_RequestObject()
        {
            // Snippet: UpdateWorkflowTemplate(UpdateWorkflowTemplateRequest, CallSettings)
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

        /// <summary>Snippet for UpdateWorkflowTemplateAsync</summary>
        public async Task UpdateWorkflowTemplateAsync_RequestObject()
        {
            // Snippet: UpdateWorkflowTemplateAsync(UpdateWorkflowTemplateRequest, CallSettings)
            // Additional: UpdateWorkflowTemplateAsync(UpdateWorkflowTemplateRequest, CancellationToken)
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
        public void UpdateWorkflowTemplate()
        {
            // Snippet: UpdateWorkflowTemplate(WorkflowTemplate, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            WorkflowTemplate response = workflowTemplateServiceClient.UpdateWorkflowTemplate(template);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflowTemplateAsync</summary>
        public async Task UpdateWorkflowTemplateAsync()
        {
            // Snippet: UpdateWorkflowTemplateAsync(WorkflowTemplate, CallSettings)
            // Additional: UpdateWorkflowTemplateAsync(WorkflowTemplate, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowTemplate template = new WorkflowTemplate();
            // Make the request
            WorkflowTemplate response = await workflowTemplateServiceClient.UpdateWorkflowTemplateAsync(template);
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowTemplates</summary>
        public void ListWorkflowTemplates_RequestObject()
        {
            // Snippet: ListWorkflowTemplates(ListWorkflowTemplatesRequest, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            ListWorkflowTemplatesRequest request = new ListWorkflowTemplatesRequest
            {
                ParentAsWorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            // Make the request
            PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> response = workflowTemplateServiceClient.ListWorkflowTemplates(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowTemplates</summary>
        public async Task ListWorkflowTemplatesAsync_RequestObject()
        {
            // Snippet: ListWorkflowTemplatesAsync(ListWorkflowTemplatesRequest, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkflowTemplatesRequest request = new ListWorkflowTemplatesRequest
            {
                ParentAsWorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> response = workflowTemplateServiceClient.ListWorkflowTemplatesAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowTemplates</summary>
        public void ListWorkflowTemplates()
        {
            // Snippet: ListWorkflowTemplates(string, string, int?, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            // Make the request
            PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> response = workflowTemplateServiceClient.ListWorkflowTemplates(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowTemplates</summary>
        public async Task ListWorkflowTemplatesAsync()
        {
            // Snippet: ListWorkflowTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            // Make the request
            PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> response = workflowTemplateServiceClient.ListWorkflowTemplatesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowTemplates</summary>
        public void ListWorkflowTemplates_ResourceNames()
        {
            // Snippet: ListWorkflowTemplates(WorkflowTemplateName, string, int?, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            WorkflowTemplateName parent = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            // Make the request
            PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> response = workflowTemplateServiceClient.ListWorkflowTemplates(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowTemplates</summary>
        public async Task ListWorkflowTemplatesAsync_ResourceNames()
        {
            // Snippet: ListWorkflowTemplatesAsync(WorkflowTemplateName, string, int?, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowTemplateName parent = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            // Make the request
            PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> response = workflowTemplateServiceClient.ListWorkflowTemplatesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowTemplate</summary>
        public void DeleteWorkflowTemplate_RequestObject()
        {
            // Snippet: DeleteWorkflowTemplate(DeleteWorkflowTemplateRequest, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 0,
            };
            // Make the request
            workflowTemplateServiceClient.DeleteWorkflowTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowTemplateAsync</summary>
        public async Task DeleteWorkflowTemplateAsync_RequestObject()
        {
            // Snippet: DeleteWorkflowTemplateAsync(DeleteWorkflowTemplateRequest, CallSettings)
            // Additional: DeleteWorkflowTemplateAsync(DeleteWorkflowTemplateRequest, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkflowTemplateRequest request = new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]"),
                Version = 0,
            };
            // Make the request
            await workflowTemplateServiceClient.DeleteWorkflowTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowTemplate</summary>
        public void DeleteWorkflowTemplate()
        {
            // Snippet: DeleteWorkflowTemplate(string, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            // Make the request
            workflowTemplateServiceClient.DeleteWorkflowTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowTemplateAsync</summary>
        public async Task DeleteWorkflowTemplateAsync()
        {
            // Snippet: DeleteWorkflowTemplateAsync(string, CallSettings)
            // Additional: DeleteWorkflowTemplateAsync(string, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regions/[REGION]/workflowTemplates/[WORKFLOW_TEMPLATE]";
            // Make the request
            await workflowTemplateServiceClient.DeleteWorkflowTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowTemplate</summary>
        public void DeleteWorkflowTemplate_ResourceNames()
        {
            // Snippet: DeleteWorkflowTemplate(WorkflowTemplateName, CallSettings)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = WorkflowTemplateServiceClient.Create();
            // Initialize request argument(s)
            WorkflowTemplateName name = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            // Make the request
            workflowTemplateServiceClient.DeleteWorkflowTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowTemplateAsync</summary>
        public async Task DeleteWorkflowTemplateAsync_ResourceNames()
        {
            // Snippet: DeleteWorkflowTemplateAsync(WorkflowTemplateName, CallSettings)
            // Additional: DeleteWorkflowTemplateAsync(WorkflowTemplateName, CancellationToken)
            // Create client
            WorkflowTemplateServiceClient workflowTemplateServiceClient = await WorkflowTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowTemplateName name = WorkflowTemplateName.FromProjectRegionWorkflowTemplate("[PROJECT]", "[REGION]", "[WORKFLOW_TEMPLATE]");
            // Make the request
            await workflowTemplateServiceClient.DeleteWorkflowTemplateAsync(name);
            // End snippet
        }
    }
}
