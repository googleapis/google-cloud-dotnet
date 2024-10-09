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
    using Google.Cloud.Retail.V2;
    using Google.Protobuf.WellKnownTypes;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGenerativeQuestionServiceClientSnippets
    {
        /// <summary>Snippet for UpdateGenerativeQuestionsFeatureConfig</summary>
        public void UpdateGenerativeQuestionsFeatureConfigRequestObject()
        {
            // Snippet: UpdateGenerativeQuestionsFeatureConfig(UpdateGenerativeQuestionsFeatureConfigRequest, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            UpdateGenerativeQuestionsFeatureConfigRequest request = new UpdateGenerativeQuestionsFeatureConfigRequest
            {
                GenerativeQuestionsFeatureConfig = new GenerativeQuestionsFeatureConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GenerativeQuestionsFeatureConfig response = generativeQuestionServiceClient.UpdateGenerativeQuestionsFeatureConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerativeQuestionsFeatureConfigAsync</summary>
        public async Task UpdateGenerativeQuestionsFeatureConfigRequestObjectAsync()
        {
            // Snippet: UpdateGenerativeQuestionsFeatureConfigAsync(UpdateGenerativeQuestionsFeatureConfigRequest, CallSettings)
            // Additional: UpdateGenerativeQuestionsFeatureConfigAsync(UpdateGenerativeQuestionsFeatureConfigRequest, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGenerativeQuestionsFeatureConfigRequest request = new UpdateGenerativeQuestionsFeatureConfigRequest
            {
                GenerativeQuestionsFeatureConfig = new GenerativeQuestionsFeatureConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GenerativeQuestionsFeatureConfig response = await generativeQuestionServiceClient.UpdateGenerativeQuestionsFeatureConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerativeQuestionsFeatureConfig</summary>
        public void UpdateGenerativeQuestionsFeatureConfig()
        {
            // Snippet: UpdateGenerativeQuestionsFeatureConfig(GenerativeQuestionsFeatureConfig, FieldMask, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            GenerativeQuestionsFeatureConfig generativeQuestionsFeatureConfig = new GenerativeQuestionsFeatureConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GenerativeQuestionsFeatureConfig response = generativeQuestionServiceClient.UpdateGenerativeQuestionsFeatureConfig(generativeQuestionsFeatureConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerativeQuestionsFeatureConfigAsync</summary>
        public async Task UpdateGenerativeQuestionsFeatureConfigAsync()
        {
            // Snippet: UpdateGenerativeQuestionsFeatureConfigAsync(GenerativeQuestionsFeatureConfig, FieldMask, CallSettings)
            // Additional: UpdateGenerativeQuestionsFeatureConfigAsync(GenerativeQuestionsFeatureConfig, FieldMask, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerativeQuestionsFeatureConfig generativeQuestionsFeatureConfig = new GenerativeQuestionsFeatureConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GenerativeQuestionsFeatureConfig response = await generativeQuestionServiceClient.UpdateGenerativeQuestionsFeatureConfigAsync(generativeQuestionsFeatureConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetGenerativeQuestionsFeatureConfig</summary>
        public void GetGenerativeQuestionsFeatureConfigRequestObject()
        {
            // Snippet: GetGenerativeQuestionsFeatureConfig(GetGenerativeQuestionsFeatureConfigRequest, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            GetGenerativeQuestionsFeatureConfigRequest request = new GetGenerativeQuestionsFeatureConfigRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            // Make the request
            GenerativeQuestionsFeatureConfig response = generativeQuestionServiceClient.GetGenerativeQuestionsFeatureConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetGenerativeQuestionsFeatureConfigAsync</summary>
        public async Task GetGenerativeQuestionsFeatureConfigRequestObjectAsync()
        {
            // Snippet: GetGenerativeQuestionsFeatureConfigAsync(GetGenerativeQuestionsFeatureConfigRequest, CallSettings)
            // Additional: GetGenerativeQuestionsFeatureConfigAsync(GetGenerativeQuestionsFeatureConfigRequest, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGenerativeQuestionsFeatureConfigRequest request = new GetGenerativeQuestionsFeatureConfigRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            // Make the request
            GenerativeQuestionsFeatureConfig response = await generativeQuestionServiceClient.GetGenerativeQuestionsFeatureConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGenerativeQuestionsFeatureConfig</summary>
        public void GetGenerativeQuestionsFeatureConfig()
        {
            // Snippet: GetGenerativeQuestionsFeatureConfig(string, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            string catalog = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            // Make the request
            GenerativeQuestionsFeatureConfig response = generativeQuestionServiceClient.GetGenerativeQuestionsFeatureConfig(catalog);
            // End snippet
        }

        /// <summary>Snippet for GetGenerativeQuestionsFeatureConfigAsync</summary>
        public async Task GetGenerativeQuestionsFeatureConfigAsync()
        {
            // Snippet: GetGenerativeQuestionsFeatureConfigAsync(string, CallSettings)
            // Additional: GetGenerativeQuestionsFeatureConfigAsync(string, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string catalog = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            // Make the request
            GenerativeQuestionsFeatureConfig response = await generativeQuestionServiceClient.GetGenerativeQuestionsFeatureConfigAsync(catalog);
            // End snippet
        }

        /// <summary>Snippet for GetGenerativeQuestionsFeatureConfig</summary>
        public void GetGenerativeQuestionsFeatureConfigResourceNames()
        {
            // Snippet: GetGenerativeQuestionsFeatureConfig(CatalogName, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            CatalogName catalog = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            // Make the request
            GenerativeQuestionsFeatureConfig response = generativeQuestionServiceClient.GetGenerativeQuestionsFeatureConfig(catalog);
            // End snippet
        }

        /// <summary>Snippet for GetGenerativeQuestionsFeatureConfigAsync</summary>
        public async Task GetGenerativeQuestionsFeatureConfigResourceNamesAsync()
        {
            // Snippet: GetGenerativeQuestionsFeatureConfigAsync(CatalogName, CallSettings)
            // Additional: GetGenerativeQuestionsFeatureConfigAsync(CatalogName, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName catalog = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            // Make the request
            GenerativeQuestionsFeatureConfig response = await generativeQuestionServiceClient.GetGenerativeQuestionsFeatureConfigAsync(catalog);
            // End snippet
        }

        /// <summary>Snippet for ListGenerativeQuestionConfigs</summary>
        public void ListGenerativeQuestionConfigsRequestObject()
        {
            // Snippet: ListGenerativeQuestionConfigs(ListGenerativeQuestionConfigsRequest, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            ListGenerativeQuestionConfigsRequest request = new ListGenerativeQuestionConfigsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            // Make the request
            ListGenerativeQuestionConfigsResponse response = generativeQuestionServiceClient.ListGenerativeQuestionConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for ListGenerativeQuestionConfigsAsync</summary>
        public async Task ListGenerativeQuestionConfigsRequestObjectAsync()
        {
            // Snippet: ListGenerativeQuestionConfigsAsync(ListGenerativeQuestionConfigsRequest, CallSettings)
            // Additional: ListGenerativeQuestionConfigsAsync(ListGenerativeQuestionConfigsRequest, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGenerativeQuestionConfigsRequest request = new ListGenerativeQuestionConfigsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            // Make the request
            ListGenerativeQuestionConfigsResponse response = await generativeQuestionServiceClient.ListGenerativeQuestionConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListGenerativeQuestionConfigs</summary>
        public void ListGenerativeQuestionConfigs()
        {
            // Snippet: ListGenerativeQuestionConfigs(string, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            // Make the request
            ListGenerativeQuestionConfigsResponse response = generativeQuestionServiceClient.ListGenerativeQuestionConfigs(parent);
            // End snippet
        }

        /// <summary>Snippet for ListGenerativeQuestionConfigsAsync</summary>
        public async Task ListGenerativeQuestionConfigsAsync()
        {
            // Snippet: ListGenerativeQuestionConfigsAsync(string, CallSettings)
            // Additional: ListGenerativeQuestionConfigsAsync(string, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            // Make the request
            ListGenerativeQuestionConfigsResponse response = await generativeQuestionServiceClient.ListGenerativeQuestionConfigsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListGenerativeQuestionConfigs</summary>
        public void ListGenerativeQuestionConfigsResourceNames()
        {
            // Snippet: ListGenerativeQuestionConfigs(CatalogName, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            // Make the request
            ListGenerativeQuestionConfigsResponse response = generativeQuestionServiceClient.ListGenerativeQuestionConfigs(parent);
            // End snippet
        }

        /// <summary>Snippet for ListGenerativeQuestionConfigsAsync</summary>
        public async Task ListGenerativeQuestionConfigsResourceNamesAsync()
        {
            // Snippet: ListGenerativeQuestionConfigsAsync(CatalogName, CallSettings)
            // Additional: ListGenerativeQuestionConfigsAsync(CatalogName, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            // Make the request
            ListGenerativeQuestionConfigsResponse response = await generativeQuestionServiceClient.ListGenerativeQuestionConfigsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerativeQuestionConfig</summary>
        public void UpdateGenerativeQuestionConfigRequestObject()
        {
            // Snippet: UpdateGenerativeQuestionConfig(UpdateGenerativeQuestionConfigRequest, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            UpdateGenerativeQuestionConfigRequest request = new UpdateGenerativeQuestionConfigRequest
            {
                GenerativeQuestionConfig = new GenerativeQuestionConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GenerativeQuestionConfig response = generativeQuestionServiceClient.UpdateGenerativeQuestionConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerativeQuestionConfigAsync</summary>
        public async Task UpdateGenerativeQuestionConfigRequestObjectAsync()
        {
            // Snippet: UpdateGenerativeQuestionConfigAsync(UpdateGenerativeQuestionConfigRequest, CallSettings)
            // Additional: UpdateGenerativeQuestionConfigAsync(UpdateGenerativeQuestionConfigRequest, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGenerativeQuestionConfigRequest request = new UpdateGenerativeQuestionConfigRequest
            {
                GenerativeQuestionConfig = new GenerativeQuestionConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GenerativeQuestionConfig response = await generativeQuestionServiceClient.UpdateGenerativeQuestionConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerativeQuestionConfig</summary>
        public void UpdateGenerativeQuestionConfig()
        {
            // Snippet: UpdateGenerativeQuestionConfig(GenerativeQuestionConfig, FieldMask, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            GenerativeQuestionConfig generativeQuestionConfig = new GenerativeQuestionConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GenerativeQuestionConfig response = generativeQuestionServiceClient.UpdateGenerativeQuestionConfig(generativeQuestionConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateGenerativeQuestionConfigAsync</summary>
        public async Task UpdateGenerativeQuestionConfigAsync()
        {
            // Snippet: UpdateGenerativeQuestionConfigAsync(GenerativeQuestionConfig, FieldMask, CallSettings)
            // Additional: UpdateGenerativeQuestionConfigAsync(GenerativeQuestionConfig, FieldMask, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerativeQuestionConfig generativeQuestionConfig = new GenerativeQuestionConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GenerativeQuestionConfig response = await generativeQuestionServiceClient.UpdateGenerativeQuestionConfigAsync(generativeQuestionConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateGenerativeQuestionConfigs</summary>
        public void BatchUpdateGenerativeQuestionConfigsRequestObject()
        {
            // Snippet: BatchUpdateGenerativeQuestionConfigs(BatchUpdateGenerativeQuestionConfigsRequest, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateGenerativeQuestionConfigsRequest request = new BatchUpdateGenerativeQuestionConfigsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Requests =
                {
                    new UpdateGenerativeQuestionConfigRequest(),
                },
            };
            // Make the request
            BatchUpdateGenerativeQuestionConfigsResponse response = generativeQuestionServiceClient.BatchUpdateGenerativeQuestionConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateGenerativeQuestionConfigsAsync</summary>
        public async Task BatchUpdateGenerativeQuestionConfigsRequestObjectAsync()
        {
            // Snippet: BatchUpdateGenerativeQuestionConfigsAsync(BatchUpdateGenerativeQuestionConfigsRequest, CallSettings)
            // Additional: BatchUpdateGenerativeQuestionConfigsAsync(BatchUpdateGenerativeQuestionConfigsRequest, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateGenerativeQuestionConfigsRequest request = new BatchUpdateGenerativeQuestionConfigsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Requests =
                {
                    new UpdateGenerativeQuestionConfigRequest(),
                },
            };
            // Make the request
            BatchUpdateGenerativeQuestionConfigsResponse response = await generativeQuestionServiceClient.BatchUpdateGenerativeQuestionConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateGenerativeQuestionConfigs</summary>
        public void BatchUpdateGenerativeQuestionConfigs()
        {
            // Snippet: BatchUpdateGenerativeQuestionConfigs(string, IEnumerable<UpdateGenerativeQuestionConfigRequest>, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            IEnumerable<UpdateGenerativeQuestionConfigRequest> requests = new UpdateGenerativeQuestionConfigRequest[]
            {
                new UpdateGenerativeQuestionConfigRequest(),
            };
            // Make the request
            BatchUpdateGenerativeQuestionConfigsResponse response = generativeQuestionServiceClient.BatchUpdateGenerativeQuestionConfigs(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateGenerativeQuestionConfigsAsync</summary>
        public async Task BatchUpdateGenerativeQuestionConfigsAsync()
        {
            // Snippet: BatchUpdateGenerativeQuestionConfigsAsync(string, IEnumerable<UpdateGenerativeQuestionConfigRequest>, CallSettings)
            // Additional: BatchUpdateGenerativeQuestionConfigsAsync(string, IEnumerable<UpdateGenerativeQuestionConfigRequest>, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            IEnumerable<UpdateGenerativeQuestionConfigRequest> requests = new UpdateGenerativeQuestionConfigRequest[]
            {
                new UpdateGenerativeQuestionConfigRequest(),
            };
            // Make the request
            BatchUpdateGenerativeQuestionConfigsResponse response = await generativeQuestionServiceClient.BatchUpdateGenerativeQuestionConfigsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateGenerativeQuestionConfigs</summary>
        public void BatchUpdateGenerativeQuestionConfigsResourceNames()
        {
            // Snippet: BatchUpdateGenerativeQuestionConfigs(CatalogName, IEnumerable<UpdateGenerativeQuestionConfigRequest>, CallSettings)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = GenerativeQuestionServiceClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            IEnumerable<UpdateGenerativeQuestionConfigRequest> requests = new UpdateGenerativeQuestionConfigRequest[]
            {
                new UpdateGenerativeQuestionConfigRequest(),
            };
            // Make the request
            BatchUpdateGenerativeQuestionConfigsResponse response = generativeQuestionServiceClient.BatchUpdateGenerativeQuestionConfigs(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateGenerativeQuestionConfigsAsync</summary>
        public async Task BatchUpdateGenerativeQuestionConfigsResourceNamesAsync()
        {
            // Snippet: BatchUpdateGenerativeQuestionConfigsAsync(CatalogName, IEnumerable<UpdateGenerativeQuestionConfigRequest>, CallSettings)
            // Additional: BatchUpdateGenerativeQuestionConfigsAsync(CatalogName, IEnumerable<UpdateGenerativeQuestionConfigRequest>, CancellationToken)
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            IEnumerable<UpdateGenerativeQuestionConfigRequest> requests = new UpdateGenerativeQuestionConfigRequest[]
            {
                new UpdateGenerativeQuestionConfigRequest(),
            };
            // Make the request
            BatchUpdateGenerativeQuestionConfigsResponse response = await generativeQuestionServiceClient.BatchUpdateGenerativeQuestionConfigsAsync(parent, requests);
            // End snippet
        }
    }
}
