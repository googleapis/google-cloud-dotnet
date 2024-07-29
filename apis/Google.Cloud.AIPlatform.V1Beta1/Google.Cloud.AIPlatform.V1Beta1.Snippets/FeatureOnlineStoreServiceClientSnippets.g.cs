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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.AIPlatform.V1Beta1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFeatureOnlineStoreServiceClientSnippets
    {
        /// <summary>Snippet for FetchFeatureValues</summary>
        public void FetchFeatureValuesRequestObject()
        {
            // Snippet: FetchFeatureValues(FetchFeatureValuesRequest, CallSettings)
            // Create client
            FeatureOnlineStoreServiceClient featureOnlineStoreServiceClient = FeatureOnlineStoreServiceClient.Create();
            // Initialize request argument(s)
            FetchFeatureValuesRequest request = new FetchFeatureValuesRequest
            {
                FeatureViewAsFeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
                DataKey = new FeatureViewDataKey(),
                DataFormat = FeatureViewDataFormat.Unspecified,
            };
            // Make the request
            FetchFeatureValuesResponse response = featureOnlineStoreServiceClient.FetchFeatureValues(request);
            // End snippet
        }

        /// <summary>Snippet for FetchFeatureValuesAsync</summary>
        public async Task FetchFeatureValuesRequestObjectAsync()
        {
            // Snippet: FetchFeatureValuesAsync(FetchFeatureValuesRequest, CallSettings)
            // Additional: FetchFeatureValuesAsync(FetchFeatureValuesRequest, CancellationToken)
            // Create client
            FeatureOnlineStoreServiceClient featureOnlineStoreServiceClient = await FeatureOnlineStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchFeatureValuesRequest request = new FetchFeatureValuesRequest
            {
                FeatureViewAsFeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
                DataKey = new FeatureViewDataKey(),
                DataFormat = FeatureViewDataFormat.Unspecified,
            };
            // Make the request
            FetchFeatureValuesResponse response = await featureOnlineStoreServiceClient.FetchFeatureValuesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchFeatureValues</summary>
        public void FetchFeatureValues()
        {
            // Snippet: FetchFeatureValues(string, FeatureViewDataKey, CallSettings)
            // Create client
            FeatureOnlineStoreServiceClient featureOnlineStoreServiceClient = FeatureOnlineStoreServiceClient.Create();
            // Initialize request argument(s)
            string featureView = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]/featureViews/[FEATURE_VIEW]";
            FeatureViewDataKey dataKey = new FeatureViewDataKey();
            // Make the request
            FetchFeatureValuesResponse response = featureOnlineStoreServiceClient.FetchFeatureValues(featureView, dataKey);
            // End snippet
        }

        /// <summary>Snippet for FetchFeatureValuesAsync</summary>
        public async Task FetchFeatureValuesAsync()
        {
            // Snippet: FetchFeatureValuesAsync(string, FeatureViewDataKey, CallSettings)
            // Additional: FetchFeatureValuesAsync(string, FeatureViewDataKey, CancellationToken)
            // Create client
            FeatureOnlineStoreServiceClient featureOnlineStoreServiceClient = await FeatureOnlineStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string featureView = "projects/[PROJECT]/locations/[LOCATION]/featureOnlineStores/[FEATURE_ONLINE_STORE]/featureViews/[FEATURE_VIEW]";
            FeatureViewDataKey dataKey = new FeatureViewDataKey();
            // Make the request
            FetchFeatureValuesResponse response = await featureOnlineStoreServiceClient.FetchFeatureValuesAsync(featureView, dataKey);
            // End snippet
        }

        /// <summary>Snippet for FetchFeatureValues</summary>
        public void FetchFeatureValuesResourceNames()
        {
            // Snippet: FetchFeatureValues(FeatureViewName, FeatureViewDataKey, CallSettings)
            // Create client
            FeatureOnlineStoreServiceClient featureOnlineStoreServiceClient = FeatureOnlineStoreServiceClient.Create();
            // Initialize request argument(s)
            FeatureViewName featureView = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]");
            FeatureViewDataKey dataKey = new FeatureViewDataKey();
            // Make the request
            FetchFeatureValuesResponse response = featureOnlineStoreServiceClient.FetchFeatureValues(featureView, dataKey);
            // End snippet
        }

        /// <summary>Snippet for FetchFeatureValuesAsync</summary>
        public async Task FetchFeatureValuesResourceNamesAsync()
        {
            // Snippet: FetchFeatureValuesAsync(FeatureViewName, FeatureViewDataKey, CallSettings)
            // Additional: FetchFeatureValuesAsync(FeatureViewName, FeatureViewDataKey, CancellationToken)
            // Create client
            FeatureOnlineStoreServiceClient featureOnlineStoreServiceClient = await FeatureOnlineStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeatureViewName featureView = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]");
            FeatureViewDataKey dataKey = new FeatureViewDataKey();
            // Make the request
            FetchFeatureValuesResponse response = await featureOnlineStoreServiceClient.FetchFeatureValuesAsync(featureView, dataKey);
            // End snippet
        }

        /// <summary>Snippet for StreamingFetchFeatureValues</summary>
        public async Task StreamingFetchFeatureValues()
        {
            // Snippet: StreamingFetchFeatureValues(CallSettings, BidirectionalStreamingSettings)
            // Create client
            FeatureOnlineStoreServiceClient featureOnlineStoreServiceClient = FeatureOnlineStoreServiceClient.Create();
            // Initialize streaming call, retrieving the stream object
            using FeatureOnlineStoreServiceClient.StreamingFetchFeatureValuesStream response = featureOnlineStoreServiceClient.StreamingFetchFeatureValues();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamingFetchFeatureValuesResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamingFetchFeatureValuesResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamingFetchFeatureValuesRequest request = new StreamingFetchFeatureValuesRequest
                {
                    FeatureViewAsFeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
                    DataKeys =
                    {
                        new FeatureViewDataKey(),
                    },
                    DataFormat = FeatureViewDataFormat.Unspecified,
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for SearchNearestEntities</summary>
        public void SearchNearestEntitiesRequestObject()
        {
            // Snippet: SearchNearestEntities(SearchNearestEntitiesRequest, CallSettings)
            // Create client
            FeatureOnlineStoreServiceClient featureOnlineStoreServiceClient = FeatureOnlineStoreServiceClient.Create();
            // Initialize request argument(s)
            SearchNearestEntitiesRequest request = new SearchNearestEntitiesRequest
            {
                FeatureViewAsFeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
                Query = new NearestNeighborQuery(),
                ReturnFullEntity = false,
            };
            // Make the request
            SearchNearestEntitiesResponse response = featureOnlineStoreServiceClient.SearchNearestEntities(request);
            // End snippet
        }

        /// <summary>Snippet for SearchNearestEntitiesAsync</summary>
        public async Task SearchNearestEntitiesRequestObjectAsync()
        {
            // Snippet: SearchNearestEntitiesAsync(SearchNearestEntitiesRequest, CallSettings)
            // Additional: SearchNearestEntitiesAsync(SearchNearestEntitiesRequest, CancellationToken)
            // Create client
            FeatureOnlineStoreServiceClient featureOnlineStoreServiceClient = await FeatureOnlineStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchNearestEntitiesRequest request = new SearchNearestEntitiesRequest
            {
                FeatureViewAsFeatureViewName = FeatureViewName.FromProjectLocationFeatureOnlineStoreFeatureView("[PROJECT]", "[LOCATION]", "[FEATURE_ONLINE_STORE]", "[FEATURE_VIEW]"),
                Query = new NearestNeighborQuery(),
                ReturnFullEntity = false,
            };
            // Make the request
            SearchNearestEntitiesResponse response = await featureOnlineStoreServiceClient.SearchNearestEntitiesAsync(request);
            // End snippet
        }
    }
}
