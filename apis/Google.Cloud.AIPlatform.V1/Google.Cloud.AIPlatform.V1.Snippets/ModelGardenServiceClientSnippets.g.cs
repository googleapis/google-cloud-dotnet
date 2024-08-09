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
    using Google.Cloud.AIPlatform.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedModelGardenServiceClientSnippets
    {
        /// <summary>Snippet for GetPublisherModel</summary>
        public void GetPublisherModelRequestObject()
        {
            // Snippet: GetPublisherModel(GetPublisherModelRequest, CallSettings)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = ModelGardenServiceClient.Create();
            // Initialize request argument(s)
            GetPublisherModelRequest request = new GetPublisherModelRequest
            {
                PublisherModelName = PublisherModelName.FromPublisherModel("[PUBLISHER]", "[MODEL]"),
                LanguageCode = "",
                View = PublisherModelView.Unspecified,
                IsHuggingFaceModel = false,
                HuggingFaceToken = "",
            };
            // Make the request
            PublisherModel response = modelGardenServiceClient.GetPublisherModel(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherModelAsync</summary>
        public async Task GetPublisherModelRequestObjectAsync()
        {
            // Snippet: GetPublisherModelAsync(GetPublisherModelRequest, CallSettings)
            // Additional: GetPublisherModelAsync(GetPublisherModelRequest, CancellationToken)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = await ModelGardenServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPublisherModelRequest request = new GetPublisherModelRequest
            {
                PublisherModelName = PublisherModelName.FromPublisherModel("[PUBLISHER]", "[MODEL]"),
                LanguageCode = "",
                View = PublisherModelView.Unspecified,
                IsHuggingFaceModel = false,
                HuggingFaceToken = "",
            };
            // Make the request
            PublisherModel response = await modelGardenServiceClient.GetPublisherModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherModel</summary>
        public void GetPublisherModel()
        {
            // Snippet: GetPublisherModel(string, CallSettings)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = ModelGardenServiceClient.Create();
            // Initialize request argument(s)
            string name = "publishers/[PUBLISHER]/models/[MODEL]";
            // Make the request
            PublisherModel response = modelGardenServiceClient.GetPublisherModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherModelAsync</summary>
        public async Task GetPublisherModelAsync()
        {
            // Snippet: GetPublisherModelAsync(string, CallSettings)
            // Additional: GetPublisherModelAsync(string, CancellationToken)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = await ModelGardenServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "publishers/[PUBLISHER]/models/[MODEL]";
            // Make the request
            PublisherModel response = await modelGardenServiceClient.GetPublisherModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherModel</summary>
        public void GetPublisherModelResourceNames()
        {
            // Snippet: GetPublisherModel(PublisherModelName, CallSettings)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = ModelGardenServiceClient.Create();
            // Initialize request argument(s)
            PublisherModelName name = PublisherModelName.FromPublisherModel("[PUBLISHER]", "[MODEL]");
            // Make the request
            PublisherModel response = modelGardenServiceClient.GetPublisherModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherModelAsync</summary>
        public async Task GetPublisherModelResourceNamesAsync()
        {
            // Snippet: GetPublisherModelAsync(PublisherModelName, CallSettings)
            // Additional: GetPublisherModelAsync(PublisherModelName, CancellationToken)
            // Create client
            ModelGardenServiceClient modelGardenServiceClient = await ModelGardenServiceClient.CreateAsync();
            // Initialize request argument(s)
            PublisherModelName name = PublisherModelName.FromPublisherModel("[PUBLISHER]", "[MODEL]");
            // Make the request
            PublisherModel response = await modelGardenServiceClient.GetPublisherModelAsync(name);
            // End snippet
        }
    }
}
