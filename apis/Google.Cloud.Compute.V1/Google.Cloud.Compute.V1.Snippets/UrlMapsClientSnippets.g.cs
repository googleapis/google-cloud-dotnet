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
    public sealed class GeneratedUrlMapsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListUrlMapsRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            AggregatedListUrlMapsRequest request = new AggregatedListUrlMapsRequest
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
            UrlMapsAggregatedList response = urlMapsClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListUrlMapsRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListUrlMapsRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListUrlMapsRequest request = new AggregatedListUrlMapsRequest
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
            UrlMapsAggregatedList response = await urlMapsClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            UrlMapsAggregatedList response = urlMapsClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            UrlMapsAggregatedList response = await urlMapsClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            DeleteUrlMapRequest request = new DeleteUrlMapRequest
            {
                RequestId = "",
                UrlMap = "",
                Project = "",
            };
            // Make the request
            Operation response = urlMapsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteUrlMapRequest, CallSettings)
            // Additional: DeleteAsync(DeleteUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUrlMapRequest request = new DeleteUrlMapRequest
            {
                RequestId = "",
                UrlMap = "",
                Project = "",
            };
            // Make the request
            Operation response = await urlMapsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            // Make the request
            Operation response = urlMapsClient.Delete(project, urlMap);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            // Make the request
            Operation response = await urlMapsClient.DeleteAsync(project, urlMap);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            GetUrlMapRequest request = new GetUrlMapRequest
            {
                UrlMap = "",
                Project = "",
            };
            // Make the request
            UrlMap response = urlMapsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetUrlMapRequest, CallSettings)
            // Additional: GetAsync(GetUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            GetUrlMapRequest request = new GetUrlMapRequest
            {
                UrlMap = "",
                Project = "",
            };
            // Make the request
            UrlMap response = await urlMapsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            // Make the request
            UrlMap response = urlMapsClient.Get(project, urlMap);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            // Make the request
            UrlMap response = await urlMapsClient.GetAsync(project, urlMap);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            InsertUrlMapRequest request = new InsertUrlMapRequest
            {
                RequestId = "",
                UrlMapResource = new UrlMap(),
                Project = "",
            };
            // Make the request
            Operation response = urlMapsClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertUrlMapRequest, CallSettings)
            // Additional: InsertAsync(InsertUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            InsertUrlMapRequest request = new InsertUrlMapRequest
            {
                RequestId = "",
                UrlMapResource = new UrlMap(),
                Project = "",
            };
            // Make the request
            Operation response = await urlMapsClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, UrlMap, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            Operation response = urlMapsClient.Insert(project, urlMapResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, UrlMap, CallSettings)
            // Additional: InsertAsync(string, UrlMap, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            Operation response = await urlMapsClient.InsertAsync(project, urlMapResource);
            // End snippet
        }

        /// <summary>Snippet for InvalidateCache</summary>
        public void InvalidateCacheRequestObject()
        {
            // Snippet: InvalidateCache(InvalidateCacheUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            InvalidateCacheUrlMapRequest request = new InvalidateCacheUrlMapRequest
            {
                RequestId = "",
                CacheInvalidationRuleResource = new CacheInvalidationRule(),
                UrlMap = "",
                Project = "",
            };
            // Make the request
            Operation response = urlMapsClient.InvalidateCache(request);
            // End snippet
        }

        /// <summary>Snippet for InvalidateCacheAsync</summary>
        public async Task InvalidateCacheRequestObjectAsync()
        {
            // Snippet: InvalidateCacheAsync(InvalidateCacheUrlMapRequest, CallSettings)
            // Additional: InvalidateCacheAsync(InvalidateCacheUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            InvalidateCacheUrlMapRequest request = new InvalidateCacheUrlMapRequest
            {
                RequestId = "",
                CacheInvalidationRuleResource = new CacheInvalidationRule(),
                UrlMap = "",
                Project = "",
            };
            // Make the request
            Operation response = await urlMapsClient.InvalidateCacheAsync(request);
            // End snippet
        }

        /// <summary>Snippet for InvalidateCache</summary>
        public void InvalidateCache()
        {
            // Snippet: InvalidateCache(string, string, CacheInvalidationRule, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            CacheInvalidationRule cacheInvalidationRuleResource = new CacheInvalidationRule();
            // Make the request
            Operation response = urlMapsClient.InvalidateCache(project, urlMap, cacheInvalidationRuleResource);
            // End snippet
        }

        /// <summary>Snippet for InvalidateCacheAsync</summary>
        public async Task InvalidateCacheAsync()
        {
            // Snippet: InvalidateCacheAsync(string, string, CacheInvalidationRule, CallSettings)
            // Additional: InvalidateCacheAsync(string, string, CacheInvalidationRule, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            CacheInvalidationRule cacheInvalidationRuleResource = new CacheInvalidationRule();
            // Make the request
            Operation response = await urlMapsClient.InvalidateCacheAsync(project, urlMap, cacheInvalidationRuleResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListUrlMapsRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            ListUrlMapsRequest request = new ListUrlMapsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            UrlMapList response = urlMapsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListUrlMapsRequest, CallSettings)
            // Additional: ListAsync(ListUrlMapsRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            ListUrlMapsRequest request = new ListUrlMapsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            UrlMapList response = await urlMapsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            UrlMapList response = urlMapsClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            UrlMapList response = await urlMapsClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            PatchUrlMapRequest request = new PatchUrlMapRequest
            {
                RequestId = "",
                UrlMap = "",
                UrlMapResource = new UrlMap(),
                Project = "",
            };
            // Make the request
            Operation response = urlMapsClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchUrlMapRequest, CallSettings)
            // Additional: PatchAsync(PatchUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            PatchUrlMapRequest request = new PatchUrlMapRequest
            {
                RequestId = "",
                UrlMap = "",
                UrlMapResource = new UrlMap(),
                Project = "",
            };
            // Make the request
            Operation response = await urlMapsClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, UrlMap, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            Operation response = urlMapsClient.Patch(project, urlMap, urlMapResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, UrlMap, CallSettings)
            // Additional: PatchAsync(string, string, UrlMap, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            Operation response = await urlMapsClient.PatchAsync(project, urlMap, urlMapResource);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            UpdateUrlMapRequest request = new UpdateUrlMapRequest
            {
                RequestId = "",
                UrlMap = "",
                UrlMapResource = new UrlMap(),
                Project = "",
            };
            // Make the request
            Operation response = urlMapsClient.Update(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(UpdateUrlMapRequest, CallSettings)
            // Additional: UpdateAsync(UpdateUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUrlMapRequest request = new UpdateUrlMapRequest
            {
                RequestId = "",
                UrlMap = "",
                UrlMapResource = new UrlMap(),
                Project = "",
            };
            // Make the request
            Operation response = await urlMapsClient.UpdateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void Update()
        {
            // Snippet: Update(string, string, UrlMap, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            Operation response = urlMapsClient.Update(project, urlMap, urlMapResource);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateAsync()
        {
            // Snippet: UpdateAsync(string, string, UrlMap, CallSettings)
            // Additional: UpdateAsync(string, string, UrlMap, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            Operation response = await urlMapsClient.UpdateAsync(project, urlMap, urlMapResource);
            // End snippet
        }

        /// <summary>Snippet for Validate</summary>
        public void ValidateRequestObject()
        {
            // Snippet: Validate(ValidateUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                UrlMap = "",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest(),
                Project = "",
            };
            // Make the request
            UrlMapsValidateResponse response = urlMapsClient.Validate(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateAsync</summary>
        public async Task ValidateRequestObjectAsync()
        {
            // Snippet: ValidateAsync(ValidateUrlMapRequest, CallSettings)
            // Additional: ValidateAsync(ValidateUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                UrlMap = "",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest(),
                Project = "",
            };
            // Make the request
            UrlMapsValidateResponse response = await urlMapsClient.ValidateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Validate</summary>
        public void Validate()
        {
            // Snippet: Validate(string, string, UrlMapsValidateRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            UrlMapsValidateRequest urlMapsValidateRequestResource = new UrlMapsValidateRequest();
            // Make the request
            UrlMapsValidateResponse response = urlMapsClient.Validate(project, urlMap, urlMapsValidateRequestResource);
            // End snippet
        }

        /// <summary>Snippet for ValidateAsync</summary>
        public async Task ValidateAsync()
        {
            // Snippet: ValidateAsync(string, string, UrlMapsValidateRequest, CallSettings)
            // Additional: ValidateAsync(string, string, UrlMapsValidateRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            UrlMapsValidateRequest urlMapsValidateRequestResource = new UrlMapsValidateRequest();
            // Make the request
            UrlMapsValidateResponse response = await urlMapsClient.ValidateAsync(project, urlMap, urlMapsValidateRequestResource);
            // End snippet
        }
    }
}
