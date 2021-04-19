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
    public sealed class GeneratedRegionCommitmentsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListRegionCommitmentsRequest, CallSettings)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = RegionCommitmentsClient.Create();
            // Initialize request argument(s)
            AggregatedListRegionCommitmentsRequest request = new AggregatedListRegionCommitmentsRequest
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
            CommitmentAggregatedList response = regionCommitmentsClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListRegionCommitmentsRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListRegionCommitmentsRequest, CancellationToken)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = await RegionCommitmentsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListRegionCommitmentsRequest request = new AggregatedListRegionCommitmentsRequest
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
            CommitmentAggregatedList response = await regionCommitmentsClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = RegionCommitmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            CommitmentAggregatedList response = regionCommitmentsClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = await RegionCommitmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            CommitmentAggregatedList response = await regionCommitmentsClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionCommitmentRequest, CallSettings)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = RegionCommitmentsClient.Create();
            // Initialize request argument(s)
            GetRegionCommitmentRequest request = new GetRegionCommitmentRequest
            {
                Region = "",
                Commitment = "",
                Project = "",
            };
            // Make the request
            Commitment response = regionCommitmentsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionCommitmentRequest, CallSettings)
            // Additional: GetAsync(GetRegionCommitmentRequest, CancellationToken)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = await RegionCommitmentsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionCommitmentRequest request = new GetRegionCommitmentRequest
            {
                Region = "",
                Commitment = "",
                Project = "",
            };
            // Make the request
            Commitment response = await regionCommitmentsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = RegionCommitmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string commitment = "";
            // Make the request
            Commitment response = regionCommitmentsClient.Get(project, region, commitment);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = await RegionCommitmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string commitment = "";
            // Make the request
            Commitment response = await regionCommitmentsClient.GetAsync(project, region, commitment);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionCommitmentRequest, CallSettings)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = RegionCommitmentsClient.Create();
            // Initialize request argument(s)
            InsertRegionCommitmentRequest request = new InsertRegionCommitmentRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                CommitmentResource = new Commitment(),
            };
            // Make the request
            Operation response = regionCommitmentsClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertRegionCommitmentRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionCommitmentRequest, CancellationToken)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = await RegionCommitmentsClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionCommitmentRequest request = new InsertRegionCommitmentRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                CommitmentResource = new Commitment(),
            };
            // Make the request
            Operation response = await regionCommitmentsClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, Commitment, CallSettings)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = RegionCommitmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Commitment commitmentResource = new Commitment();
            // Make the request
            Operation response = regionCommitmentsClient.Insert(project, region, commitmentResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, Commitment, CallSettings)
            // Additional: InsertAsync(string, string, Commitment, CancellationToken)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = await RegionCommitmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Commitment commitmentResource = new Commitment();
            // Make the request
            Operation response = await regionCommitmentsClient.InsertAsync(project, region, commitmentResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionCommitmentsRequest, CallSettings)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = RegionCommitmentsClient.Create();
            // Initialize request argument(s)
            ListRegionCommitmentsRequest request = new ListRegionCommitmentsRequest
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
            CommitmentList response = regionCommitmentsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionCommitmentsRequest, CallSettings)
            // Additional: ListAsync(ListRegionCommitmentsRequest, CancellationToken)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = await RegionCommitmentsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionCommitmentsRequest request = new ListRegionCommitmentsRequest
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
            CommitmentList response = await regionCommitmentsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = RegionCommitmentsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            CommitmentList response = regionCommitmentsClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            RegionCommitmentsClient regionCommitmentsClient = await RegionCommitmentsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            CommitmentList response = await regionCommitmentsClient.ListAsync(project, region);
            // End snippet
        }
    }
}
