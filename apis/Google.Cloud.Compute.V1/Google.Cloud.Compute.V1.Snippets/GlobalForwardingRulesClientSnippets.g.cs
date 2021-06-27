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
    public sealed class GeneratedGlobalForwardingRulesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteGlobalForwardingRuleRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            DeleteGlobalForwardingRuleRequest request = new DeleteGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            Operation response = globalForwardingRulesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteGlobalForwardingRuleRequest, CallSettings)
            // Additional: DeleteAsync(DeleteGlobalForwardingRuleRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlobalForwardingRuleRequest request = new DeleteGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            Operation response = await globalForwardingRulesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            // Make the request
            Operation response = globalForwardingRulesClient.Delete(project, forwardingRule);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            // Make the request
            Operation response = await globalForwardingRulesClient.DeleteAsync(project, forwardingRule);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetGlobalForwardingRuleRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            GetGlobalForwardingRuleRequest request = new GetGlobalForwardingRuleRequest
            {
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            ForwardingRule response = globalForwardingRulesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalForwardingRuleRequest, CallSettings)
            // Additional: GetAsync(GetGlobalForwardingRuleRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalForwardingRuleRequest request = new GetGlobalForwardingRuleRequest
            {
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            ForwardingRule response = await globalForwardingRulesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            // Make the request
            ForwardingRule response = globalForwardingRulesClient.Get(project, forwardingRule);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            // Make the request
            ForwardingRule response = await globalForwardingRulesClient.GetAsync(project, forwardingRule);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertGlobalForwardingRuleRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            InsertGlobalForwardingRuleRequest request = new InsertGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            Operation response = globalForwardingRulesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertGlobalForwardingRuleRequest, CallSettings)
            // Additional: InsertAsync(InsertGlobalForwardingRuleRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            InsertGlobalForwardingRuleRequest request = new InsertGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            Operation response = await globalForwardingRulesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, ForwardingRule, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            Operation response = globalForwardingRulesClient.Insert(project, forwardingRuleResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, ForwardingRule, CallSettings)
            // Additional: InsertAsync(string, ForwardingRule, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            Operation response = await globalForwardingRulesClient.InsertAsync(project, forwardingRuleResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListGlobalForwardingRulesRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            ListGlobalForwardingRulesRequest request = new ListGlobalForwardingRulesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ForwardingRuleList response = globalForwardingRulesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListGlobalForwardingRulesRequest, CallSettings)
            // Additional: ListAsync(ListGlobalForwardingRulesRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalForwardingRulesRequest request = new ListGlobalForwardingRulesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ForwardingRuleList response = await globalForwardingRulesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            ForwardingRuleList response = globalForwardingRulesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            ForwardingRuleList response = await globalForwardingRulesClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchGlobalForwardingRuleRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            PatchGlobalForwardingRuleRequest request = new PatchGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRule = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            Operation response = globalForwardingRulesClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchGlobalForwardingRuleRequest, CallSettings)
            // Additional: PatchAsync(PatchGlobalForwardingRuleRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            PatchGlobalForwardingRuleRequest request = new PatchGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRule = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            Operation response = await globalForwardingRulesClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, ForwardingRule, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            Operation response = globalForwardingRulesClient.Patch(project, forwardingRule, forwardingRuleResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, ForwardingRule, CallSettings)
            // Additional: PatchAsync(string, string, ForwardingRule, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            Operation response = await globalForwardingRulesClient.PatchAsync(project, forwardingRule, forwardingRuleResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsGlobalForwardingRuleRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            SetLabelsGlobalForwardingRuleRequest request = new SetLabelsGlobalForwardingRuleRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            Operation response = globalForwardingRulesClient.SetLabels(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsGlobalForwardingRuleRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsGlobalForwardingRuleRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsGlobalForwardingRuleRequest request = new SetLabelsGlobalForwardingRuleRequest
            {
                Resource = "",
                Project = "",
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
            };
            // Make the request
            Operation response = await globalForwardingRulesClient.SetLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, GlobalSetLabelsRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            Operation response = globalForwardingRulesClient.SetLabels(project, resource, globalSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            Operation response = await globalForwardingRulesClient.SetLabelsAsync(project, resource, globalSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetTarget</summary>
        public void SetTargetRequestObject()
        {
            // Snippet: SetTarget(SetTargetGlobalForwardingRuleRequest, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            SetTargetGlobalForwardingRuleRequest request = new SetTargetGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRule = "",
                TargetReferenceResource = new TargetReference(),
            };
            // Make the request
            Operation response = globalForwardingRulesClient.SetTarget(request);
            // End snippet
        }

        /// <summary>Snippet for SetTargetAsync</summary>
        public async Task SetTargetRequestObjectAsync()
        {
            // Snippet: SetTargetAsync(SetTargetGlobalForwardingRuleRequest, CallSettings)
            // Additional: SetTargetAsync(SetTargetGlobalForwardingRuleRequest, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            SetTargetGlobalForwardingRuleRequest request = new SetTargetGlobalForwardingRuleRequest
            {
                RequestId = "",
                Project = "",
                ForwardingRule = "",
                TargetReferenceResource = new TargetReference(),
            };
            // Make the request
            Operation response = await globalForwardingRulesClient.SetTargetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetTarget</summary>
        public void SetTarget()
        {
            // Snippet: SetTarget(string, string, TargetReference, CallSettings)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = GlobalForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            TargetReference targetReferenceResource = new TargetReference();
            // Make the request
            Operation response = globalForwardingRulesClient.SetTarget(project, forwardingRule, targetReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for SetTargetAsync</summary>
        public async Task SetTargetAsync()
        {
            // Snippet: SetTargetAsync(string, string, TargetReference, CallSettings)
            // Additional: SetTargetAsync(string, string, TargetReference, CancellationToken)
            // Create client
            GlobalForwardingRulesClient globalForwardingRulesClient = await GlobalForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string forwardingRule = "";
            TargetReference targetReferenceResource = new TargetReference();
            // Make the request
            Operation response = await globalForwardingRulesClient.SetTargetAsync(project, forwardingRule, targetReferenceResource);
            // End snippet
        }
    }
}
