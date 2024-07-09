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
    using Google.Cloud.AIPlatform.V1;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFeaturestoreOnlineServingServiceClientSnippets
    {
        /// <summary>Snippet for ReadFeatureValues</summary>
        public void ReadFeatureValuesRequestObject()
        {
            // Snippet: ReadFeatureValues(ReadFeatureValuesRequest, CallSettings)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = FeaturestoreOnlineServingServiceClient.Create();
            // Initialize request argument(s)
            ReadFeatureValuesRequest request = new ReadFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                EntityId = "",
                FeatureSelector = new FeatureSelector(),
            };
            // Make the request
            ReadFeatureValuesResponse response = featurestoreOnlineServingServiceClient.ReadFeatureValues(request);
            // End snippet
        }

        /// <summary>Snippet for ReadFeatureValuesAsync</summary>
        public async Task ReadFeatureValuesRequestObjectAsync()
        {
            // Snippet: ReadFeatureValuesAsync(ReadFeatureValuesRequest, CallSettings)
            // Additional: ReadFeatureValuesAsync(ReadFeatureValuesRequest, CancellationToken)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = await FeaturestoreOnlineServingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReadFeatureValuesRequest request = new ReadFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                EntityId = "",
                FeatureSelector = new FeatureSelector(),
            };
            // Make the request
            ReadFeatureValuesResponse response = await featurestoreOnlineServingServiceClient.ReadFeatureValuesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReadFeatureValues</summary>
        public void ReadFeatureValues()
        {
            // Snippet: ReadFeatureValues(string, CallSettings)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = FeaturestoreOnlineServingServiceClient.Create();
            // Initialize request argument(s)
            string entityType = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            ReadFeatureValuesResponse response = featurestoreOnlineServingServiceClient.ReadFeatureValues(entityType);
            // End snippet
        }

        /// <summary>Snippet for ReadFeatureValuesAsync</summary>
        public async Task ReadFeatureValuesAsync()
        {
            // Snippet: ReadFeatureValuesAsync(string, CallSettings)
            // Additional: ReadFeatureValuesAsync(string, CancellationToken)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = await FeaturestoreOnlineServingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string entityType = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            ReadFeatureValuesResponse response = await featurestoreOnlineServingServiceClient.ReadFeatureValuesAsync(entityType);
            // End snippet
        }

        /// <summary>Snippet for ReadFeatureValues</summary>
        public void ReadFeatureValuesResourceNames()
        {
            // Snippet: ReadFeatureValues(EntityTypeName, CallSettings)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = FeaturestoreOnlineServingServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName entityType = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            ReadFeatureValuesResponse response = featurestoreOnlineServingServiceClient.ReadFeatureValues(entityType);
            // End snippet
        }

        /// <summary>Snippet for ReadFeatureValuesAsync</summary>
        public async Task ReadFeatureValuesResourceNamesAsync()
        {
            // Snippet: ReadFeatureValuesAsync(EntityTypeName, CallSettings)
            // Additional: ReadFeatureValuesAsync(EntityTypeName, CancellationToken)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = await FeaturestoreOnlineServingServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName entityType = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request
            ReadFeatureValuesResponse response = await featurestoreOnlineServingServiceClient.ReadFeatureValuesAsync(entityType);
            // End snippet
        }

        /// <summary>Snippet for StreamingReadFeatureValues</summary>
        public async Task StreamingReadFeatureValuesRequestObject()
        {
            // Snippet: StreamingReadFeatureValues(StreamingReadFeatureValuesRequest, CallSettings)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = FeaturestoreOnlineServingServiceClient.Create();
            // Initialize request argument(s)
            StreamingReadFeatureValuesRequest request = new StreamingReadFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                EntityIds = { "", },
                FeatureSelector = new FeatureSelector(),
            };
            // Make the request, returning a streaming response
            using FeaturestoreOnlineServingServiceClient.StreamingReadFeatureValuesStream response = featurestoreOnlineServingServiceClient.StreamingReadFeatureValues(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadFeatureValuesResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadFeatureValuesResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for StreamingReadFeatureValues</summary>
        public async Task StreamingReadFeatureValues()
        {
            // Snippet: StreamingReadFeatureValues(string, CallSettings)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = FeaturestoreOnlineServingServiceClient.Create();
            // Initialize request argument(s)
            string entityType = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            // Make the request, returning a streaming response
            using FeaturestoreOnlineServingServiceClient.StreamingReadFeatureValuesStream response = featurestoreOnlineServingServiceClient.StreamingReadFeatureValues(entityType);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadFeatureValuesResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadFeatureValuesResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for StreamingReadFeatureValues</summary>
        public async Task StreamingReadFeatureValuesResourceNames()
        {
            // Snippet: StreamingReadFeatureValues(EntityTypeName, CallSettings)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = FeaturestoreOnlineServingServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName entityType = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request, returning a streaming response
            using FeaturestoreOnlineServingServiceClient.StreamingReadFeatureValuesStream response = featurestoreOnlineServingServiceClient.StreamingReadFeatureValues(entityType);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadFeatureValuesResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadFeatureValuesResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for WriteFeatureValues</summary>
        public void WriteFeatureValuesRequestObject()
        {
            // Snippet: WriteFeatureValues(WriteFeatureValuesRequest, CallSettings)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = FeaturestoreOnlineServingServiceClient.Create();
            // Initialize request argument(s)
            WriteFeatureValuesRequest request = new WriteFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Payloads =
                {
                    new WriteFeatureValuesPayload(),
                },
            };
            // Make the request
            WriteFeatureValuesResponse response = featurestoreOnlineServingServiceClient.WriteFeatureValues(request);
            // End snippet
        }

        /// <summary>Snippet for WriteFeatureValuesAsync</summary>
        public async Task WriteFeatureValuesRequestObjectAsync()
        {
            // Snippet: WriteFeatureValuesAsync(WriteFeatureValuesRequest, CallSettings)
            // Additional: WriteFeatureValuesAsync(WriteFeatureValuesRequest, CancellationToken)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = await FeaturestoreOnlineServingServiceClient.CreateAsync();
            // Initialize request argument(s)
            WriteFeatureValuesRequest request = new WriteFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                Payloads =
                {
                    new WriteFeatureValuesPayload(),
                },
            };
            // Make the request
            WriteFeatureValuesResponse response = await featurestoreOnlineServingServiceClient.WriteFeatureValuesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for WriteFeatureValues</summary>
        public void WriteFeatureValues()
        {
            // Snippet: WriteFeatureValues(string, IEnumerable<WriteFeatureValuesPayload>, CallSettings)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = FeaturestoreOnlineServingServiceClient.Create();
            // Initialize request argument(s)
            string entityType = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            IEnumerable<WriteFeatureValuesPayload> payloads = new WriteFeatureValuesPayload[]
            {
                new WriteFeatureValuesPayload(),
            };
            // Make the request
            WriteFeatureValuesResponse response = featurestoreOnlineServingServiceClient.WriteFeatureValues(entityType, payloads);
            // End snippet
        }

        /// <summary>Snippet for WriteFeatureValuesAsync</summary>
        public async Task WriteFeatureValuesAsync()
        {
            // Snippet: WriteFeatureValuesAsync(string, IEnumerable<WriteFeatureValuesPayload>, CallSettings)
            // Additional: WriteFeatureValuesAsync(string, IEnumerable<WriteFeatureValuesPayload>, CancellationToken)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = await FeaturestoreOnlineServingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string entityType = "projects/[PROJECT]/locations/[LOCATION]/featurestores/[FEATURESTORE]/entityTypes/[ENTITY_TYPE]";
            IEnumerable<WriteFeatureValuesPayload> payloads = new WriteFeatureValuesPayload[]
            {
                new WriteFeatureValuesPayload(),
            };
            // Make the request
            WriteFeatureValuesResponse response = await featurestoreOnlineServingServiceClient.WriteFeatureValuesAsync(entityType, payloads);
            // End snippet
        }

        /// <summary>Snippet for WriteFeatureValues</summary>
        public void WriteFeatureValuesResourceNames()
        {
            // Snippet: WriteFeatureValues(EntityTypeName, IEnumerable<WriteFeatureValuesPayload>, CallSettings)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = FeaturestoreOnlineServingServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName entityType = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            IEnumerable<WriteFeatureValuesPayload> payloads = new WriteFeatureValuesPayload[]
            {
                new WriteFeatureValuesPayload(),
            };
            // Make the request
            WriteFeatureValuesResponse response = featurestoreOnlineServingServiceClient.WriteFeatureValues(entityType, payloads);
            // End snippet
        }

        /// <summary>Snippet for WriteFeatureValuesAsync</summary>
        public async Task WriteFeatureValuesResourceNamesAsync()
        {
            // Snippet: WriteFeatureValuesAsync(EntityTypeName, IEnumerable<WriteFeatureValuesPayload>, CallSettings)
            // Additional: WriteFeatureValuesAsync(EntityTypeName, IEnumerable<WriteFeatureValuesPayload>, CancellationToken)
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = await FeaturestoreOnlineServingServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityTypeName entityType = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            IEnumerable<WriteFeatureValuesPayload> payloads = new WriteFeatureValuesPayload[]
            {
                new WriteFeatureValuesPayload(),
            };
            // Make the request
            WriteFeatureValuesResponse response = await featurestoreOnlineServingServiceClient.WriteFeatureValuesAsync(entityType, payloads);
            // End snippet
        }
    }
}
