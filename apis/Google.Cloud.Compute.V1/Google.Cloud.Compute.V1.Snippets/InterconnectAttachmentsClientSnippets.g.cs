// Copyright 2021 Google LLC
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

namespace Google.Cloud.Compute.V1.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedInterconnectAttachmentsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListInterconnectAttachmentsRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            AggregatedListInterconnectAttachmentsRequest request = new AggregatedListInterconnectAttachmentsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InterconnectAttachmentAggregatedList response = interconnectAttachmentsClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListInterconnectAttachmentsRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListInterconnectAttachmentsRequest, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListInterconnectAttachmentsRequest request = new AggregatedListInterconnectAttachmentsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InterconnectAttachmentAggregatedList response = await interconnectAttachmentsClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            InterconnectAttachmentAggregatedList response = interconnectAttachmentsClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            InterconnectAttachmentAggregatedList response = await interconnectAttachmentsClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteInterconnectAttachmentRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            DeleteInterconnectAttachmentRequest request = new DeleteInterconnectAttachmentRequest
            {
                RequestId = "",
                InterconnectAttachment = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = interconnectAttachmentsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteInterconnectAttachmentRequest, CallSettings)
            // Additional: DeleteAsync(DeleteInterconnectAttachmentRequest, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInterconnectAttachmentRequest request = new DeleteInterconnectAttachmentRequest
            {
                RequestId = "",
                InterconnectAttachment = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await interconnectAttachmentsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string interconnectAttachment = "";
            // Make the request
            Operation response = interconnectAttachmentsClient.Delete(project, region, interconnectAttachment);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string interconnectAttachment = "";
            // Make the request
            Operation response = await interconnectAttachmentsClient.DeleteAsync(project, region, interconnectAttachment);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetInterconnectAttachmentRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                InterconnectAttachment = "",
                Region = "",
                Project = "",
            };
            // Make the request
            InterconnectAttachment response = interconnectAttachmentsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInterconnectAttachmentRequest, CallSettings)
            // Additional: GetAsync(GetInterconnectAttachmentRequest, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                InterconnectAttachment = "",
                Region = "",
                Project = "",
            };
            // Make the request
            InterconnectAttachment response = await interconnectAttachmentsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string interconnectAttachment = "";
            // Make the request
            InterconnectAttachment response = interconnectAttachmentsClient.Get(project, region, interconnectAttachment);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string interconnectAttachment = "";
            // Make the request
            InterconnectAttachment response = await interconnectAttachmentsClient.GetAsync(project, region, interconnectAttachment);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertInterconnectAttachmentRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            InsertInterconnectAttachmentRequest request = new InsertInterconnectAttachmentRequest
            {
                RequestId = "",
                Region = "",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation response = interconnectAttachmentsClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertInterconnectAttachmentRequest, CallSettings)
            // Additional: InsertAsync(InsertInterconnectAttachmentRequest, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            InsertInterconnectAttachmentRequest request = new InsertInterconnectAttachmentRequest
            {
                RequestId = "",
                Region = "",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation response = await interconnectAttachmentsClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, InterconnectAttachment, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InterconnectAttachment interconnectAttachmentResource = new InterconnectAttachment();
            // Make the request
            Operation response = interconnectAttachmentsClient.Insert(project, region, interconnectAttachmentResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, InterconnectAttachment, CallSettings)
            // Additional: InsertAsync(string, string, InterconnectAttachment, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InterconnectAttachment interconnectAttachmentResource = new InterconnectAttachment();
            // Make the request
            Operation response = await interconnectAttachmentsClient.InsertAsync(project, region, interconnectAttachmentResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListInterconnectAttachmentsRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InterconnectAttachmentList response = interconnectAttachmentsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListInterconnectAttachmentsRequest, CallSettings)
            // Additional: ListAsync(ListInterconnectAttachmentsRequest, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InterconnectAttachmentList response = await interconnectAttachmentsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            InterconnectAttachmentList response = interconnectAttachmentsClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            InterconnectAttachmentList response = await interconnectAttachmentsClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchInterconnectAttachmentRequest, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            PatchInterconnectAttachmentRequest request = new PatchInterconnectAttachmentRequest
            {
                RequestId = "",
                InterconnectAttachment = "",
                Region = "",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "",
            };
            // Make the request
            Operation response = interconnectAttachmentsClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchInterconnectAttachmentRequest, CallSettings)
            // Additional: PatchAsync(PatchInterconnectAttachmentRequest, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            PatchInterconnectAttachmentRequest request = new PatchInterconnectAttachmentRequest
            {
                RequestId = "",
                InterconnectAttachment = "",
                Region = "",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "",
            };
            // Make the request
            Operation response = await interconnectAttachmentsClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, InterconnectAttachment, CallSettings)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = InterconnectAttachmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string interconnectAttachment = "";
            InterconnectAttachment interconnectAttachmentResource = new InterconnectAttachment();
            // Make the request
            Operation response = interconnectAttachmentsClient.Patch(project, region, interconnectAttachment, interconnectAttachmentResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, InterconnectAttachment, CallSettings)
            // Additional: PatchAsync(string, string, string, InterconnectAttachment, CancellationToken)
            // Create client
            InterconnectAttachmentsClient interconnectAttachmentsClient = await InterconnectAttachmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string interconnectAttachment = "";
            InterconnectAttachment interconnectAttachmentResource = new InterconnectAttachment();
            // Make the request
            Operation response = await interconnectAttachmentsClient.PatchAsync(project, region, interconnectAttachment, interconnectAttachmentResource);
            // End snippet
        }
    }
}
