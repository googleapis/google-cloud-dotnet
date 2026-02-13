// Copyright 2026 Google LLC
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
    using Google.Cloud.Ces.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedToolServiceClientSnippets
    {
        /// <summary>Snippet for ExecuteTool</summary>
        public void ExecuteToolRequestObject()
        {
            // Snippet: ExecuteTool(ExecuteToolRequest, CallSettings)
            // Create client
            ToolServiceClient toolServiceClient = ToolServiceClient.Create();
            // Initialize request argument(s)
            ExecuteToolRequest request = new ExecuteToolRequest
            {
                ToolAsToolName = ToolName.FromProjectLocationAppTool("[PROJECT]", "[LOCATION]", "[APP]", "[TOOL]"),
                Args = new Struct(),
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
            };
            // Make the request
            ExecuteToolResponse response = toolServiceClient.ExecuteTool(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteToolAsync</summary>
        public async Task ExecuteToolRequestObjectAsync()
        {
            // Snippet: ExecuteToolAsync(ExecuteToolRequest, CallSettings)
            // Additional: ExecuteToolAsync(ExecuteToolRequest, CancellationToken)
            // Create client
            ToolServiceClient toolServiceClient = await ToolServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecuteToolRequest request = new ExecuteToolRequest
            {
                ToolAsToolName = ToolName.FromProjectLocationAppTool("[PROJECT]", "[LOCATION]", "[APP]", "[TOOL]"),
                Args = new Struct(),
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
            };
            // Make the request
            ExecuteToolResponse response = await toolServiceClient.ExecuteToolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveToolSchema</summary>
        public void RetrieveToolSchemaRequestObject()
        {
            // Snippet: RetrieveToolSchema(RetrieveToolSchemaRequest, CallSettings)
            // Create client
            ToolServiceClient toolServiceClient = ToolServiceClient.Create();
            // Initialize request argument(s)
            RetrieveToolSchemaRequest request = new RetrieveToolSchemaRequest
            {
                ToolAsToolName = ToolName.FromProjectLocationAppTool("[PROJECT]", "[LOCATION]", "[APP]", "[TOOL]"),
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
            };
            // Make the request
            RetrieveToolSchemaResponse response = toolServiceClient.RetrieveToolSchema(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveToolSchemaAsync</summary>
        public async Task RetrieveToolSchemaRequestObjectAsync()
        {
            // Snippet: RetrieveToolSchemaAsync(RetrieveToolSchemaRequest, CallSettings)
            // Additional: RetrieveToolSchemaAsync(RetrieveToolSchemaRequest, CancellationToken)
            // Create client
            ToolServiceClient toolServiceClient = await ToolServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveToolSchemaRequest request = new RetrieveToolSchemaRequest
            {
                ToolAsToolName = ToolName.FromProjectLocationAppTool("[PROJECT]", "[LOCATION]", "[APP]", "[TOOL]"),
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
            };
            // Make the request
            RetrieveToolSchemaResponse response = await toolServiceClient.RetrieveToolSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveTools</summary>
        public void RetrieveToolsRequestObject()
        {
            // Snippet: RetrieveTools(RetrieveToolsRequest, CallSettings)
            // Create client
            ToolServiceClient toolServiceClient = ToolServiceClient.Create();
            // Initialize request argument(s)
            RetrieveToolsRequest request = new RetrieveToolsRequest
            {
                ToolsetAsToolsetName = ToolsetName.FromProjectLocationAppToolset("[PROJECT]", "[LOCATION]", "[APP]", "[TOOLSET]"),
                ToolIds = { "", },
            };
            // Make the request
            RetrieveToolsResponse response = toolServiceClient.RetrieveTools(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveToolsAsync</summary>
        public async Task RetrieveToolsRequestObjectAsync()
        {
            // Snippet: RetrieveToolsAsync(RetrieveToolsRequest, CallSettings)
            // Additional: RetrieveToolsAsync(RetrieveToolsRequest, CancellationToken)
            // Create client
            ToolServiceClient toolServiceClient = await ToolServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveToolsRequest request = new RetrieveToolsRequest
            {
                ToolsetAsToolsetName = ToolsetName.FromProjectLocationAppToolset("[PROJECT]", "[LOCATION]", "[APP]", "[TOOLSET]"),
                ToolIds = { "", },
            };
            // Make the request
            RetrieveToolsResponse response = await toolServiceClient.RetrieveToolsAsync(request);
            // End snippet
        }
    }
}
