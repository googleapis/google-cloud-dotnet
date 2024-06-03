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
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSiteSearchEngineServiceClientSnippets
    {
        /// <summary>Snippet for GetSiteSearchEngine</summary>
        public void GetSiteSearchEngineRequestObject()
        {
            // Snippet: GetSiteSearchEngine(GetSiteSearchEngineRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            GetSiteSearchEngineRequest request = new GetSiteSearchEngineRequest
            {
                SiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            SiteSearchEngine response = siteSearchEngineServiceClient.GetSiteSearchEngine(request);
            // End snippet
        }

        /// <summary>Snippet for GetSiteSearchEngineAsync</summary>
        public async Task GetSiteSearchEngineRequestObjectAsync()
        {
            // Snippet: GetSiteSearchEngineAsync(GetSiteSearchEngineRequest, CallSettings)
            // Additional: GetSiteSearchEngineAsync(GetSiteSearchEngineRequest, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSiteSearchEngineRequest request = new GetSiteSearchEngineRequest
            {
                SiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            SiteSearchEngine response = await siteSearchEngineServiceClient.GetSiteSearchEngineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSiteSearchEngine</summary>
        public void GetSiteSearchEngine()
        {
            // Snippet: GetSiteSearchEngine(string, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/siteSearchEngine";
            // Make the request
            SiteSearchEngine response = siteSearchEngineServiceClient.GetSiteSearchEngine(name);
            // End snippet
        }

        /// <summary>Snippet for GetSiteSearchEngineAsync</summary>
        public async Task GetSiteSearchEngineAsync()
        {
            // Snippet: GetSiteSearchEngineAsync(string, CallSettings)
            // Additional: GetSiteSearchEngineAsync(string, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/siteSearchEngine";
            // Make the request
            SiteSearchEngine response = await siteSearchEngineServiceClient.GetSiteSearchEngineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSiteSearchEngine</summary>
        public void GetSiteSearchEngineResourceNames()
        {
            // Snippet: GetSiteSearchEngine(SiteSearchEngineName, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            SiteSearchEngineName name = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            SiteSearchEngine response = siteSearchEngineServiceClient.GetSiteSearchEngine(name);
            // End snippet
        }

        /// <summary>Snippet for GetSiteSearchEngineAsync</summary>
        public async Task GetSiteSearchEngineResourceNamesAsync()
        {
            // Snippet: GetSiteSearchEngineAsync(SiteSearchEngineName, CallSettings)
            // Additional: GetSiteSearchEngineAsync(SiteSearchEngineName, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            SiteSearchEngineName name = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            SiteSearchEngine response = await siteSearchEngineServiceClient.GetSiteSearchEngineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTargetSite</summary>
        public void CreateTargetSiteRequestObject()
        {
            // Snippet: CreateTargetSite(CreateTargetSiteRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            CreateTargetSiteRequest request = new CreateTargetSiteRequest
            {
                ParentAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                TargetSite = new TargetSite(),
            };
            // Make the request
            Operation<TargetSite, CreateTargetSiteMetadata> response = siteSearchEngineServiceClient.CreateTargetSite(request);

            // Poll until the returned long-running operation is complete
            Operation<TargetSite, CreateTargetSiteMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TargetSite result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetSite, CreateTargetSiteMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceCreateTargetSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetSite retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetSiteAsync</summary>
        public async Task CreateTargetSiteRequestObjectAsync()
        {
            // Snippet: CreateTargetSiteAsync(CreateTargetSiteRequest, CallSettings)
            // Additional: CreateTargetSiteAsync(CreateTargetSiteRequest, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTargetSiteRequest request = new CreateTargetSiteRequest
            {
                ParentAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                TargetSite = new TargetSite(),
            };
            // Make the request
            Operation<TargetSite, CreateTargetSiteMetadata> response = await siteSearchEngineServiceClient.CreateTargetSiteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TargetSite, CreateTargetSiteMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TargetSite result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetSite, CreateTargetSiteMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceCreateTargetSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetSite retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetSite</summary>
        public void CreateTargetSite()
        {
            // Snippet: CreateTargetSite(string, TargetSite, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/siteSearchEngine";
            TargetSite targetSite = new TargetSite();
            // Make the request
            Operation<TargetSite, CreateTargetSiteMetadata> response = siteSearchEngineServiceClient.CreateTargetSite(parent, targetSite);

            // Poll until the returned long-running operation is complete
            Operation<TargetSite, CreateTargetSiteMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TargetSite result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetSite, CreateTargetSiteMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceCreateTargetSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetSite retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetSiteAsync</summary>
        public async Task CreateTargetSiteAsync()
        {
            // Snippet: CreateTargetSiteAsync(string, TargetSite, CallSettings)
            // Additional: CreateTargetSiteAsync(string, TargetSite, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/siteSearchEngine";
            TargetSite targetSite = new TargetSite();
            // Make the request
            Operation<TargetSite, CreateTargetSiteMetadata> response = await siteSearchEngineServiceClient.CreateTargetSiteAsync(parent, targetSite);

            // Poll until the returned long-running operation is complete
            Operation<TargetSite, CreateTargetSiteMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TargetSite result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetSite, CreateTargetSiteMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceCreateTargetSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetSite retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetSite</summary>
        public void CreateTargetSiteResourceNames()
        {
            // Snippet: CreateTargetSite(SiteSearchEngineName, TargetSite, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            SiteSearchEngineName parent = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            TargetSite targetSite = new TargetSite();
            // Make the request
            Operation<TargetSite, CreateTargetSiteMetadata> response = siteSearchEngineServiceClient.CreateTargetSite(parent, targetSite);

            // Poll until the returned long-running operation is complete
            Operation<TargetSite, CreateTargetSiteMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TargetSite result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetSite, CreateTargetSiteMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceCreateTargetSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetSite retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetSiteAsync</summary>
        public async Task CreateTargetSiteResourceNamesAsync()
        {
            // Snippet: CreateTargetSiteAsync(SiteSearchEngineName, TargetSite, CallSettings)
            // Additional: CreateTargetSiteAsync(SiteSearchEngineName, TargetSite, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            SiteSearchEngineName parent = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            TargetSite targetSite = new TargetSite();
            // Make the request
            Operation<TargetSite, CreateTargetSiteMetadata> response = await siteSearchEngineServiceClient.CreateTargetSiteAsync(parent, targetSite);

            // Poll until the returned long-running operation is complete
            Operation<TargetSite, CreateTargetSiteMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TargetSite result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetSite, CreateTargetSiteMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceCreateTargetSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetSite retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTargetSites</summary>
        public void BatchCreateTargetSitesRequestObject()
        {
            // Snippet: BatchCreateTargetSites(BatchCreateTargetSitesRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateTargetSitesRequest request = new BatchCreateTargetSitesRequest
            {
                ParentAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Requests =
                {
                    new CreateTargetSiteRequest(),
                },
            };
            // Make the request
            Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata> response = siteSearchEngineServiceClient.BatchCreateTargetSites(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateTargetSitesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceBatchCreateTargetSites(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateTargetSitesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTargetSitesAsync</summary>
        public async Task BatchCreateTargetSitesRequestObjectAsync()
        {
            // Snippet: BatchCreateTargetSitesAsync(BatchCreateTargetSitesRequest, CallSettings)
            // Additional: BatchCreateTargetSitesAsync(BatchCreateTargetSitesRequest, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateTargetSitesRequest request = new BatchCreateTargetSitesRequest
            {
                ParentAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Requests =
                {
                    new CreateTargetSiteRequest(),
                },
            };
            // Make the request
            Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata> response = await siteSearchEngineServiceClient.BatchCreateTargetSitesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateTargetSitesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceBatchCreateTargetSitesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateTargetSitesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetTargetSite</summary>
        public void GetTargetSiteRequestObject()
        {
            // Snippet: GetTargetSite(GetTargetSiteRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            GetTargetSiteRequest request = new GetTargetSiteRequest
            {
                TargetSiteName = TargetSiteName.FromProjectLocationDataStoreTargetSite("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[TARGET_SITE]"),
            };
            // Make the request
            TargetSite response = siteSearchEngineServiceClient.GetTargetSite(request);
            // End snippet
        }

        /// <summary>Snippet for GetTargetSiteAsync</summary>
        public async Task GetTargetSiteRequestObjectAsync()
        {
            // Snippet: GetTargetSiteAsync(GetTargetSiteRequest, CallSettings)
            // Additional: GetTargetSiteAsync(GetTargetSiteRequest, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetSiteRequest request = new GetTargetSiteRequest
            {
                TargetSiteName = TargetSiteName.FromProjectLocationDataStoreTargetSite("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[TARGET_SITE]"),
            };
            // Make the request
            TargetSite response = await siteSearchEngineServiceClient.GetTargetSiteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTargetSite</summary>
        public void GetTargetSite()
        {
            // Snippet: GetTargetSite(string, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/siteSearchEngine/targetSites/[TARGET_SITE]";
            // Make the request
            TargetSite response = siteSearchEngineServiceClient.GetTargetSite(name);
            // End snippet
        }

        /// <summary>Snippet for GetTargetSiteAsync</summary>
        public async Task GetTargetSiteAsync()
        {
            // Snippet: GetTargetSiteAsync(string, CallSettings)
            // Additional: GetTargetSiteAsync(string, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/siteSearchEngine/targetSites/[TARGET_SITE]";
            // Make the request
            TargetSite response = await siteSearchEngineServiceClient.GetTargetSiteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTargetSite</summary>
        public void GetTargetSiteResourceNames()
        {
            // Snippet: GetTargetSite(TargetSiteName, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            TargetSiteName name = TargetSiteName.FromProjectLocationDataStoreTargetSite("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[TARGET_SITE]");
            // Make the request
            TargetSite response = siteSearchEngineServiceClient.GetTargetSite(name);
            // End snippet
        }

        /// <summary>Snippet for GetTargetSiteAsync</summary>
        public async Task GetTargetSiteResourceNamesAsync()
        {
            // Snippet: GetTargetSiteAsync(TargetSiteName, CallSettings)
            // Additional: GetTargetSiteAsync(TargetSiteName, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            TargetSiteName name = TargetSiteName.FromProjectLocationDataStoreTargetSite("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[TARGET_SITE]");
            // Make the request
            TargetSite response = await siteSearchEngineServiceClient.GetTargetSiteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetSite</summary>
        public void UpdateTargetSiteRequestObject()
        {
            // Snippet: UpdateTargetSite(UpdateTargetSiteRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            UpdateTargetSiteRequest request = new UpdateTargetSiteRequest
            {
                TargetSite = new TargetSite(),
            };
            // Make the request
            Operation<TargetSite, UpdateTargetSiteMetadata> response = siteSearchEngineServiceClient.UpdateTargetSite(request);

            // Poll until the returned long-running operation is complete
            Operation<TargetSite, UpdateTargetSiteMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TargetSite result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetSite, UpdateTargetSiteMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceUpdateTargetSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetSite retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetSiteAsync</summary>
        public async Task UpdateTargetSiteRequestObjectAsync()
        {
            // Snippet: UpdateTargetSiteAsync(UpdateTargetSiteRequest, CallSettings)
            // Additional: UpdateTargetSiteAsync(UpdateTargetSiteRequest, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTargetSiteRequest request = new UpdateTargetSiteRequest
            {
                TargetSite = new TargetSite(),
            };
            // Make the request
            Operation<TargetSite, UpdateTargetSiteMetadata> response = await siteSearchEngineServiceClient.UpdateTargetSiteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TargetSite, UpdateTargetSiteMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TargetSite result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetSite, UpdateTargetSiteMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceUpdateTargetSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetSite retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetSite</summary>
        public void UpdateTargetSite()
        {
            // Snippet: UpdateTargetSite(TargetSite, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            TargetSite targetSite = new TargetSite();
            // Make the request
            Operation<TargetSite, UpdateTargetSiteMetadata> response = siteSearchEngineServiceClient.UpdateTargetSite(targetSite);

            // Poll until the returned long-running operation is complete
            Operation<TargetSite, UpdateTargetSiteMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TargetSite result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetSite, UpdateTargetSiteMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceUpdateTargetSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetSite retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetSiteAsync</summary>
        public async Task UpdateTargetSiteAsync()
        {
            // Snippet: UpdateTargetSiteAsync(TargetSite, CallSettings)
            // Additional: UpdateTargetSiteAsync(TargetSite, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            TargetSite targetSite = new TargetSite();
            // Make the request
            Operation<TargetSite, UpdateTargetSiteMetadata> response = await siteSearchEngineServiceClient.UpdateTargetSiteAsync(targetSite);

            // Poll until the returned long-running operation is complete
            Operation<TargetSite, UpdateTargetSiteMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TargetSite result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetSite, UpdateTargetSiteMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceUpdateTargetSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetSite retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetSite</summary>
        public void DeleteTargetSiteRequestObject()
        {
            // Snippet: DeleteTargetSite(DeleteTargetSiteRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            DeleteTargetSiteRequest request = new DeleteTargetSiteRequest
            {
                TargetSiteName = TargetSiteName.FromProjectLocationDataStoreTargetSite("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[TARGET_SITE]"),
            };
            // Make the request
            Operation<Empty, DeleteTargetSiteMetadata> response = siteSearchEngineServiceClient.DeleteTargetSite(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTargetSiteMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTargetSiteMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceDeleteTargetSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetSiteAsync</summary>
        public async Task DeleteTargetSiteRequestObjectAsync()
        {
            // Snippet: DeleteTargetSiteAsync(DeleteTargetSiteRequest, CallSettings)
            // Additional: DeleteTargetSiteAsync(DeleteTargetSiteRequest, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetSiteRequest request = new DeleteTargetSiteRequest
            {
                TargetSiteName = TargetSiteName.FromProjectLocationDataStoreTargetSite("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[TARGET_SITE]"),
            };
            // Make the request
            Operation<Empty, DeleteTargetSiteMetadata> response = await siteSearchEngineServiceClient.DeleteTargetSiteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTargetSiteMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTargetSiteMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceDeleteTargetSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetSite</summary>
        public void DeleteTargetSite()
        {
            // Snippet: DeleteTargetSite(string, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/siteSearchEngine/targetSites/[TARGET_SITE]";
            // Make the request
            Operation<Empty, DeleteTargetSiteMetadata> response = siteSearchEngineServiceClient.DeleteTargetSite(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTargetSiteMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTargetSiteMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceDeleteTargetSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetSiteAsync</summary>
        public async Task DeleteTargetSiteAsync()
        {
            // Snippet: DeleteTargetSiteAsync(string, CallSettings)
            // Additional: DeleteTargetSiteAsync(string, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/siteSearchEngine/targetSites/[TARGET_SITE]";
            // Make the request
            Operation<Empty, DeleteTargetSiteMetadata> response = await siteSearchEngineServiceClient.DeleteTargetSiteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTargetSiteMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTargetSiteMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceDeleteTargetSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetSite</summary>
        public void DeleteTargetSiteResourceNames()
        {
            // Snippet: DeleteTargetSite(TargetSiteName, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            TargetSiteName name = TargetSiteName.FromProjectLocationDataStoreTargetSite("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[TARGET_SITE]");
            // Make the request
            Operation<Empty, DeleteTargetSiteMetadata> response = siteSearchEngineServiceClient.DeleteTargetSite(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTargetSiteMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTargetSiteMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceDeleteTargetSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetSiteAsync</summary>
        public async Task DeleteTargetSiteResourceNamesAsync()
        {
            // Snippet: DeleteTargetSiteAsync(TargetSiteName, CallSettings)
            // Additional: DeleteTargetSiteAsync(TargetSiteName, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            TargetSiteName name = TargetSiteName.FromProjectLocationDataStoreTargetSite("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[TARGET_SITE]");
            // Make the request
            Operation<Empty, DeleteTargetSiteMetadata> response = await siteSearchEngineServiceClient.DeleteTargetSiteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteTargetSiteMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteTargetSiteMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceDeleteTargetSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTargetSites</summary>
        public void ListTargetSitesRequestObject()
        {
            // Snippet: ListTargetSites(ListTargetSitesRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            ListTargetSitesRequest request = new ListTargetSitesRequest
            {
                ParentAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            PagedEnumerable<ListTargetSitesResponse, TargetSite> response = siteSearchEngineServiceClient.ListTargetSites(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetSite item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTargetSitesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetSite item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetSite> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetSite item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetSitesAsync</summary>
        public async Task ListTargetSitesRequestObjectAsync()
        {
            // Snippet: ListTargetSitesAsync(ListTargetSitesRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetSitesRequest request = new ListTargetSitesRequest
            {
                ParentAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTargetSitesResponse, TargetSite> response = siteSearchEngineServiceClient.ListTargetSitesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetSite item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTargetSitesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetSite item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetSite> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetSite item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetSites</summary>
        public void ListTargetSites()
        {
            // Snippet: ListTargetSites(string, string, int?, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/siteSearchEngine";
            // Make the request
            PagedEnumerable<ListTargetSitesResponse, TargetSite> response = siteSearchEngineServiceClient.ListTargetSites(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetSite item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTargetSitesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetSite item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetSite> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetSite item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetSitesAsync</summary>
        public async Task ListTargetSitesAsync()
        {
            // Snippet: ListTargetSitesAsync(string, string, int?, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/siteSearchEngine";
            // Make the request
            PagedAsyncEnumerable<ListTargetSitesResponse, TargetSite> response = siteSearchEngineServiceClient.ListTargetSitesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetSite item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTargetSitesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetSite item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetSite> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetSite item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetSites</summary>
        public void ListTargetSitesResourceNames()
        {
            // Snippet: ListTargetSites(SiteSearchEngineName, string, int?, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            SiteSearchEngineName parent = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            PagedEnumerable<ListTargetSitesResponse, TargetSite> response = siteSearchEngineServiceClient.ListTargetSites(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetSite item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTargetSitesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetSite item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetSite> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetSite item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetSitesAsync</summary>
        public async Task ListTargetSitesResourceNamesAsync()
        {
            // Snippet: ListTargetSitesAsync(SiteSearchEngineName, string, int?, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            SiteSearchEngineName parent = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListTargetSitesResponse, TargetSite> response = siteSearchEngineServiceClient.ListTargetSitesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetSite item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTargetSitesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetSite item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetSite> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetSite item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for EnableAdvancedSiteSearch</summary>
        public void EnableAdvancedSiteSearchRequestObject()
        {
            // Snippet: EnableAdvancedSiteSearch(EnableAdvancedSiteSearchRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            EnableAdvancedSiteSearchRequest request = new EnableAdvancedSiteSearchRequest
            {
                SiteSearchEngineAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata> response = siteSearchEngineServiceClient.EnableAdvancedSiteSearch(request);

            // Poll until the returned long-running operation is complete
            Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EnableAdvancedSiteSearchResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceEnableAdvancedSiteSearch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnableAdvancedSiteSearchResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableAdvancedSiteSearchAsync</summary>
        public async Task EnableAdvancedSiteSearchRequestObjectAsync()
        {
            // Snippet: EnableAdvancedSiteSearchAsync(EnableAdvancedSiteSearchRequest, CallSettings)
            // Additional: EnableAdvancedSiteSearchAsync(EnableAdvancedSiteSearchRequest, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            EnableAdvancedSiteSearchRequest request = new EnableAdvancedSiteSearchRequest
            {
                SiteSearchEngineAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata> response = await siteSearchEngineServiceClient.EnableAdvancedSiteSearchAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EnableAdvancedSiteSearchResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceEnableAdvancedSiteSearchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnableAdvancedSiteSearchResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableAdvancedSiteSearch</summary>
        public void DisableAdvancedSiteSearchRequestObject()
        {
            // Snippet: DisableAdvancedSiteSearch(DisableAdvancedSiteSearchRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            DisableAdvancedSiteSearchRequest request = new DisableAdvancedSiteSearchRequest
            {
                SiteSearchEngineAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata> response = siteSearchEngineServiceClient.DisableAdvancedSiteSearch(request);

            // Poll until the returned long-running operation is complete
            Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DisableAdvancedSiteSearchResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceDisableAdvancedSiteSearch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisableAdvancedSiteSearchResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableAdvancedSiteSearchAsync</summary>
        public async Task DisableAdvancedSiteSearchRequestObjectAsync()
        {
            // Snippet: DisableAdvancedSiteSearchAsync(DisableAdvancedSiteSearchRequest, CallSettings)
            // Additional: DisableAdvancedSiteSearchAsync(DisableAdvancedSiteSearchRequest, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisableAdvancedSiteSearchRequest request = new DisableAdvancedSiteSearchRequest
            {
                SiteSearchEngineAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata> response = await siteSearchEngineServiceClient.DisableAdvancedSiteSearchAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DisableAdvancedSiteSearchResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceDisableAdvancedSiteSearchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisableAdvancedSiteSearchResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecrawlUris</summary>
        public void RecrawlUrisRequestObject()
        {
            // Snippet: RecrawlUris(RecrawlUrisRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            RecrawlUrisRequest request = new RecrawlUrisRequest
            {
                SiteSearchEngineAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Uris = { "", },
            };
            // Make the request
            Operation<RecrawlUrisResponse, RecrawlUrisMetadata> response = siteSearchEngineServiceClient.RecrawlUris(request);

            // Poll until the returned long-running operation is complete
            Operation<RecrawlUrisResponse, RecrawlUrisMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RecrawlUrisResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RecrawlUrisResponse, RecrawlUrisMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceRecrawlUris(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RecrawlUrisResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecrawlUrisAsync</summary>
        public async Task RecrawlUrisRequestObjectAsync()
        {
            // Snippet: RecrawlUrisAsync(RecrawlUrisRequest, CallSettings)
            // Additional: RecrawlUrisAsync(RecrawlUrisRequest, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            RecrawlUrisRequest request = new RecrawlUrisRequest
            {
                SiteSearchEngineAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Uris = { "", },
            };
            // Make the request
            Operation<RecrawlUrisResponse, RecrawlUrisMetadata> response = await siteSearchEngineServiceClient.RecrawlUrisAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RecrawlUrisResponse, RecrawlUrisMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RecrawlUrisResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RecrawlUrisResponse, RecrawlUrisMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceRecrawlUrisAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RecrawlUrisResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchVerifyTargetSites</summary>
        public void BatchVerifyTargetSitesRequestObject()
        {
            // Snippet: BatchVerifyTargetSites(BatchVerifyTargetSitesRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            BatchVerifyTargetSitesRequest request = new BatchVerifyTargetSitesRequest
            {
                ParentAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata> response = siteSearchEngineServiceClient.BatchVerifyTargetSites(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchVerifyTargetSitesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceBatchVerifyTargetSites(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchVerifyTargetSitesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchVerifyTargetSitesAsync</summary>
        public async Task BatchVerifyTargetSitesRequestObjectAsync()
        {
            // Snippet: BatchVerifyTargetSitesAsync(BatchVerifyTargetSitesRequest, CallSettings)
            // Additional: BatchVerifyTargetSitesAsync(BatchVerifyTargetSitesRequest, CancellationToken)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchVerifyTargetSitesRequest request = new BatchVerifyTargetSitesRequest
            {
                ParentAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata> response = await siteSearchEngineServiceClient.BatchVerifyTargetSitesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchVerifyTargetSitesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceBatchVerifyTargetSitesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchVerifyTargetSitesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchDomainVerificationStatus</summary>
        public void FetchDomainVerificationStatusRequestObject()
        {
            // Snippet: FetchDomainVerificationStatus(FetchDomainVerificationStatusRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            FetchDomainVerificationStatusRequest request = new FetchDomainVerificationStatusRequest
            {
                SiteSearchEngineAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            PagedEnumerable<FetchDomainVerificationStatusResponse, TargetSite> response = siteSearchEngineServiceClient.FetchDomainVerificationStatus(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetSite item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchDomainVerificationStatusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetSite item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetSite> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetSite item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchDomainVerificationStatusAsync</summary>
        public async Task FetchDomainVerificationStatusRequestObjectAsync()
        {
            // Snippet: FetchDomainVerificationStatusAsync(FetchDomainVerificationStatusRequest, CallSettings)
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchDomainVerificationStatusRequest request = new FetchDomainVerificationStatusRequest
            {
                SiteSearchEngineAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            PagedAsyncEnumerable<FetchDomainVerificationStatusResponse, TargetSite> response = siteSearchEngineServiceClient.FetchDomainVerificationStatusAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetSite item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchDomainVerificationStatusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetSite item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetSite> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetSite item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
