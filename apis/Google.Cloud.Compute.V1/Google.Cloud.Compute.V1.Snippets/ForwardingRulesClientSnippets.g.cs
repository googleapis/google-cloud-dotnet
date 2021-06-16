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
    public sealed class GeneratedForwardingRulesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListForwardingRulesRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            AggregatedListForwardingRulesRequest request = new AggregatedListForwardingRulesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            ForwardingRuleAggregatedList response = forwardingRulesClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListForwardingRulesRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListForwardingRulesRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListForwardingRulesRequest request = new AggregatedListForwardingRulesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Project = "",
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            ForwardingRuleAggregatedList response = await forwardingRulesClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            ForwardingRuleAggregatedList response = forwardingRulesClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            ForwardingRuleAggregatedList response = await forwardingRulesClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteForwardingRuleRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            DeleteForwardingRuleRequest request = new DeleteForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            Operation response = forwardingRulesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteForwardingRuleRequest, CallSettings)
            // Additional: DeleteAsync(DeleteForwardingRuleRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteForwardingRuleRequest request = new DeleteForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            Operation response = await forwardingRulesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            // Make the request
            Operation response = forwardingRulesClient.Delete(project, region, forwardingRule);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            // Make the request
            Operation response = await forwardingRulesClient.DeleteAsync(project, region, forwardingRule);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetForwardingRuleRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            GetForwardingRuleRequest request = new GetForwardingRuleRequest
            {
                Region = "",
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            ForwardingRule response = forwardingRulesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetForwardingRuleRequest, CallSettings)
            // Additional: GetAsync(GetForwardingRuleRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            GetForwardingRuleRequest request = new GetForwardingRuleRequest
            {
                Region = "",
                Project = "",
                ForwardingRule = "",
            };
            // Make the request
            ForwardingRule response = await forwardingRulesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            // Make the request
            ForwardingRule response = forwardingRulesClient.Get(project, region, forwardingRule);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            // Make the request
            ForwardingRule response = await forwardingRulesClient.GetAsync(project, region, forwardingRule);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertForwardingRuleRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            InsertForwardingRuleRequest request = new InsertForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            Operation response = forwardingRulesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertForwardingRuleRequest, CallSettings)
            // Additional: InsertAsync(InsertForwardingRuleRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            InsertForwardingRuleRequest request = new InsertForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            Operation response = await forwardingRulesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, ForwardingRule, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            Operation response = forwardingRulesClient.Insert(project, region, forwardingRuleResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, ForwardingRule, CallSettings)
            // Additional: InsertAsync(string, string, ForwardingRule, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            Operation response = await forwardingRulesClient.InsertAsync(project, region, forwardingRuleResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListForwardingRulesRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            ListForwardingRulesRequest request = new ListForwardingRulesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ForwardingRuleList response = forwardingRulesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListForwardingRulesRequest, CallSettings)
            // Additional: ListAsync(ListForwardingRulesRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            ListForwardingRulesRequest request = new ListForwardingRulesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ForwardingRuleList response = await forwardingRulesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            ForwardingRuleList response = forwardingRulesClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            ForwardingRuleList response = await forwardingRulesClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchForwardingRuleRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            PatchForwardingRuleRequest request = new PatchForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRule = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            Operation response = forwardingRulesClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchForwardingRuleRequest, CallSettings)
            // Additional: PatchAsync(PatchForwardingRuleRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            PatchForwardingRuleRequest request = new PatchForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRule = "",
                ForwardingRuleResource = new ForwardingRule(),
            };
            // Make the request
            Operation response = await forwardingRulesClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, ForwardingRule, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            Operation response = forwardingRulesClient.Patch(project, region, forwardingRule, forwardingRuleResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, ForwardingRule, CallSettings)
            // Additional: PatchAsync(string, string, string, ForwardingRule, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            ForwardingRule forwardingRuleResource = new ForwardingRule();
            // Make the request
            Operation response = await forwardingRulesClient.PatchAsync(project, region, forwardingRule, forwardingRuleResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsForwardingRuleRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            SetLabelsForwardingRuleRequest request = new SetLabelsForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            Operation response = forwardingRulesClient.SetLabels(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsForwardingRuleRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsForwardingRuleRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsForwardingRuleRequest request = new SetLabelsForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            Operation response = await forwardingRulesClient.SetLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            Operation response = forwardingRulesClient.SetLabels(project, region, resource, regionSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            Operation response = await forwardingRulesClient.SetLabelsAsync(project, region, resource, regionSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetTarget</summary>
        public void SetTargetRequestObject()
        {
            // Snippet: SetTarget(SetTargetForwardingRuleRequest, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            SetTargetForwardingRuleRequest request = new SetTargetForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRule = "",
                TargetReferenceResource = new TargetReference(),
            };
            // Make the request
            Operation response = forwardingRulesClient.SetTarget(request);
            // End snippet
        }

        /// <summary>Snippet for SetTargetAsync</summary>
        public async Task SetTargetRequestObjectAsync()
        {
            // Snippet: SetTargetAsync(SetTargetForwardingRuleRequest, CallSettings)
            // Additional: SetTargetAsync(SetTargetForwardingRuleRequest, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            SetTargetForwardingRuleRequest request = new SetTargetForwardingRuleRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                ForwardingRule = "",
                TargetReferenceResource = new TargetReference(),
            };
            // Make the request
            Operation response = await forwardingRulesClient.SetTargetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetTarget</summary>
        public void SetTarget()
        {
            // Snippet: SetTarget(string, string, string, TargetReference, CallSettings)
            // Create client
            ForwardingRulesClient forwardingRulesClient = ForwardingRulesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            TargetReference targetReferenceResource = new TargetReference();
            // Make the request
            Operation response = forwardingRulesClient.SetTarget(project, region, forwardingRule, targetReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for SetTargetAsync</summary>
        public async Task SetTargetAsync()
        {
            // Snippet: SetTargetAsync(string, string, string, TargetReference, CallSettings)
            // Additional: SetTargetAsync(string, string, string, TargetReference, CancellationToken)
            // Create client
            ForwardingRulesClient forwardingRulesClient = await ForwardingRulesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string forwardingRule = "";
            TargetReference targetReferenceResource = new TargetReference();
            // Make the request
            Operation response = await forwardingRulesClient.SetTargetAsync(project, region, forwardingRule, targetReferenceResource);
            // End snippet
        }
    }
}
