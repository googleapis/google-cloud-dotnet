// Copyright 2025 Google LLC
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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataTaxonomyServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataTaxonomy</summary>
        public void CreateDataTaxonomyRequestObject()
        {
            // Snippet: CreateDataTaxonomy(CreateDataTaxonomyRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateDataTaxonomyRequest request = new gcdv::CreateDataTaxonomyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataTaxonomyId = "",
                DataTaxonomy = new gcdv::DataTaxonomy(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.CreateDataTaxonomy(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataTaxonomy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceCreateDataTaxonomy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataTaxonomy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataTaxonomyAsync</summary>
        public async Task CreateDataTaxonomyRequestObjectAsync()
        {
            // Snippet: CreateDataTaxonomyAsync(CreateDataTaxonomyRequest, CallSettings)
            // Additional: CreateDataTaxonomyAsync(CreateDataTaxonomyRequest, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateDataTaxonomyRequest request = new gcdv::CreateDataTaxonomyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataTaxonomyId = "",
                DataTaxonomy = new gcdv::DataTaxonomy(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.CreateDataTaxonomyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataTaxonomy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceCreateDataTaxonomyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataTaxonomy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataTaxonomy</summary>
        public void CreateDataTaxonomy()
        {
            // Snippet: CreateDataTaxonomy(string, DataTaxonomy, string, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::DataTaxonomy dataTaxonomy = new gcdv::DataTaxonomy();
            string dataTaxonomyId = "";
            // Make the request
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.CreateDataTaxonomy(parent, dataTaxonomy, dataTaxonomyId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataTaxonomy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceCreateDataTaxonomy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataTaxonomy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataTaxonomyAsync</summary>
        public async Task CreateDataTaxonomyAsync()
        {
            // Snippet: CreateDataTaxonomyAsync(string, DataTaxonomy, string, CallSettings)
            // Additional: CreateDataTaxonomyAsync(string, DataTaxonomy, string, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::DataTaxonomy dataTaxonomy = new gcdv::DataTaxonomy();
            string dataTaxonomyId = "";
            // Make the request
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.CreateDataTaxonomyAsync(parent, dataTaxonomy, dataTaxonomyId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataTaxonomy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceCreateDataTaxonomyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataTaxonomy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataTaxonomy</summary>
        public void CreateDataTaxonomyResourceNames()
        {
            // Snippet: CreateDataTaxonomy(LocationName, DataTaxonomy, string, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::DataTaxonomy dataTaxonomy = new gcdv::DataTaxonomy();
            string dataTaxonomyId = "";
            // Make the request
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.CreateDataTaxonomy(parent, dataTaxonomy, dataTaxonomyId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataTaxonomy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceCreateDataTaxonomy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataTaxonomy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataTaxonomyAsync</summary>
        public async Task CreateDataTaxonomyResourceNamesAsync()
        {
            // Snippet: CreateDataTaxonomyAsync(LocationName, DataTaxonomy, string, CallSettings)
            // Additional: CreateDataTaxonomyAsync(LocationName, DataTaxonomy, string, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::DataTaxonomy dataTaxonomy = new gcdv::DataTaxonomy();
            string dataTaxonomyId = "";
            // Make the request
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.CreateDataTaxonomyAsync(parent, dataTaxonomy, dataTaxonomyId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataTaxonomy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceCreateDataTaxonomyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataTaxonomy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataTaxonomy</summary>
        public void UpdateDataTaxonomyRequestObject()
        {
            // Snippet: UpdateDataTaxonomy(UpdateDataTaxonomyRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateDataTaxonomyRequest request = new gcdv::UpdateDataTaxonomyRequest
            {
                UpdateMask = new FieldMask(),
                DataTaxonomy = new gcdv::DataTaxonomy(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.UpdateDataTaxonomy(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataTaxonomy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceUpdateDataTaxonomy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataTaxonomy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataTaxonomyAsync</summary>
        public async Task UpdateDataTaxonomyRequestObjectAsync()
        {
            // Snippet: UpdateDataTaxonomyAsync(UpdateDataTaxonomyRequest, CallSettings)
            // Additional: UpdateDataTaxonomyAsync(UpdateDataTaxonomyRequest, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateDataTaxonomyRequest request = new gcdv::UpdateDataTaxonomyRequest
            {
                UpdateMask = new FieldMask(),
                DataTaxonomy = new gcdv::DataTaxonomy(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.UpdateDataTaxonomyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataTaxonomy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceUpdateDataTaxonomyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataTaxonomy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataTaxonomy</summary>
        public void UpdateDataTaxonomy()
        {
            // Snippet: UpdateDataTaxonomy(DataTaxonomy, FieldMask, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataTaxonomy dataTaxonomy = new gcdv::DataTaxonomy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.UpdateDataTaxonomy(dataTaxonomy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataTaxonomy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceUpdateDataTaxonomy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataTaxonomy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataTaxonomyAsync</summary>
        public async Task UpdateDataTaxonomyAsync()
        {
            // Snippet: UpdateDataTaxonomyAsync(DataTaxonomy, FieldMask, CallSettings)
            // Additional: UpdateDataTaxonomyAsync(DataTaxonomy, FieldMask, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataTaxonomy dataTaxonomy = new gcdv::DataTaxonomy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.UpdateDataTaxonomyAsync(dataTaxonomy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataTaxonomy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataTaxonomy, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceUpdateDataTaxonomyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataTaxonomy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTaxonomy</summary>
        public void DeleteDataTaxonomyRequestObject()
        {
            // Snippet: DeleteDataTaxonomy(DeleteDataTaxonomyRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteDataTaxonomyRequest request = new gcdv::DeleteDataTaxonomyRequest
            {
                DataTaxonomyName = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.DeleteDataTaxonomy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceDeleteDataTaxonomy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTaxonomyAsync</summary>
        public async Task DeleteDataTaxonomyRequestObjectAsync()
        {
            // Snippet: DeleteDataTaxonomyAsync(DeleteDataTaxonomyRequest, CallSettings)
            // Additional: DeleteDataTaxonomyAsync(DeleteDataTaxonomyRequest, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteDataTaxonomyRequest request = new gcdv::DeleteDataTaxonomyRequest
            {
                DataTaxonomyName = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.DeleteDataTaxonomyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceDeleteDataTaxonomyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTaxonomy</summary>
        public void DeleteDataTaxonomy()
        {
            // Snippet: DeleteDataTaxonomy(string, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATA_TAXONOMY_ID]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.DeleteDataTaxonomy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceDeleteDataTaxonomy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTaxonomyAsync</summary>
        public async Task DeleteDataTaxonomyAsync()
        {
            // Snippet: DeleteDataTaxonomyAsync(string, CallSettings)
            // Additional: DeleteDataTaxonomyAsync(string, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATA_TAXONOMY_ID]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.DeleteDataTaxonomyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceDeleteDataTaxonomyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTaxonomy</summary>
        public void DeleteDataTaxonomyResourceNames()
        {
            // Snippet: DeleteDataTaxonomy(DataTaxonomyName, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataTaxonomyName name = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.DeleteDataTaxonomy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceDeleteDataTaxonomy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTaxonomyAsync</summary>
        public async Task DeleteDataTaxonomyResourceNamesAsync()
        {
            // Snippet: DeleteDataTaxonomyAsync(DataTaxonomyName, CallSettings)
            // Additional: DeleteDataTaxonomyAsync(DataTaxonomyName, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataTaxonomyName name = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.DeleteDataTaxonomyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceDeleteDataTaxonomyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDataTaxonomies</summary>
        public void ListDataTaxonomiesRequestObject()
        {
            // Snippet: ListDataTaxonomies(ListDataTaxonomiesRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListDataTaxonomiesRequest request = new gcdv::ListDataTaxonomiesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListDataTaxonomiesResponse, gcdv::DataTaxonomy> response = dataTaxonomyServiceClient.ListDataTaxonomies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataTaxonomy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataTaxonomiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataTaxonomy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataTaxonomy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataTaxonomy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTaxonomiesAsync</summary>
        public async Task ListDataTaxonomiesRequestObjectAsync()
        {
            // Snippet: ListDataTaxonomiesAsync(ListDataTaxonomiesRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListDataTaxonomiesRequest request = new gcdv::ListDataTaxonomiesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataTaxonomiesResponse, gcdv::DataTaxonomy> response = dataTaxonomyServiceClient.ListDataTaxonomiesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataTaxonomy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataTaxonomiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataTaxonomy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataTaxonomy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataTaxonomy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTaxonomies</summary>
        public void ListDataTaxonomies()
        {
            // Snippet: ListDataTaxonomies(string, string, int?, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListDataTaxonomiesResponse, gcdv::DataTaxonomy> response = dataTaxonomyServiceClient.ListDataTaxonomies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataTaxonomy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataTaxonomiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataTaxonomy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataTaxonomy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataTaxonomy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTaxonomiesAsync</summary>
        public async Task ListDataTaxonomiesAsync()
        {
            // Snippet: ListDataTaxonomiesAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataTaxonomiesResponse, gcdv::DataTaxonomy> response = dataTaxonomyServiceClient.ListDataTaxonomiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataTaxonomy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataTaxonomiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataTaxonomy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataTaxonomy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataTaxonomy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTaxonomies</summary>
        public void ListDataTaxonomiesResourceNames()
        {
            // Snippet: ListDataTaxonomies(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListDataTaxonomiesResponse, gcdv::DataTaxonomy> response = dataTaxonomyServiceClient.ListDataTaxonomies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataTaxonomy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataTaxonomiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataTaxonomy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataTaxonomy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataTaxonomy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTaxonomiesAsync</summary>
        public async Task ListDataTaxonomiesResourceNamesAsync()
        {
            // Snippet: ListDataTaxonomiesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataTaxonomiesResponse, gcdv::DataTaxonomy> response = dataTaxonomyServiceClient.ListDataTaxonomiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataTaxonomy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataTaxonomiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataTaxonomy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataTaxonomy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataTaxonomy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDataTaxonomy</summary>
        public void GetDataTaxonomyRequestObject()
        {
            // Snippet: GetDataTaxonomy(GetDataTaxonomyRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetDataTaxonomyRequest request = new gcdv::GetDataTaxonomyRequest
            {
                DataTaxonomyName = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]"),
            };
            // Make the request
            gcdv::DataTaxonomy response = dataTaxonomyServiceClient.GetDataTaxonomy(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataTaxonomyAsync</summary>
        public async Task GetDataTaxonomyRequestObjectAsync()
        {
            // Snippet: GetDataTaxonomyAsync(GetDataTaxonomyRequest, CallSettings)
            // Additional: GetDataTaxonomyAsync(GetDataTaxonomyRequest, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetDataTaxonomyRequest request = new gcdv::GetDataTaxonomyRequest
            {
                DataTaxonomyName = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]"),
            };
            // Make the request
            gcdv::DataTaxonomy response = await dataTaxonomyServiceClient.GetDataTaxonomyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataTaxonomy</summary>
        public void GetDataTaxonomy()
        {
            // Snippet: GetDataTaxonomy(string, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATA_TAXONOMY_ID]";
            // Make the request
            gcdv::DataTaxonomy response = dataTaxonomyServiceClient.GetDataTaxonomy(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataTaxonomyAsync</summary>
        public async Task GetDataTaxonomyAsync()
        {
            // Snippet: GetDataTaxonomyAsync(string, CallSettings)
            // Additional: GetDataTaxonomyAsync(string, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATA_TAXONOMY_ID]";
            // Make the request
            gcdv::DataTaxonomy response = await dataTaxonomyServiceClient.GetDataTaxonomyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataTaxonomy</summary>
        public void GetDataTaxonomyResourceNames()
        {
            // Snippet: GetDataTaxonomy(DataTaxonomyName, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataTaxonomyName name = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]");
            // Make the request
            gcdv::DataTaxonomy response = dataTaxonomyServiceClient.GetDataTaxonomy(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataTaxonomyAsync</summary>
        public async Task GetDataTaxonomyResourceNamesAsync()
        {
            // Snippet: GetDataTaxonomyAsync(DataTaxonomyName, CallSettings)
            // Additional: GetDataTaxonomyAsync(DataTaxonomyName, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataTaxonomyName name = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]");
            // Make the request
            gcdv::DataTaxonomy response = await dataTaxonomyServiceClient.GetDataTaxonomyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAttributeBinding</summary>
        public void CreateDataAttributeBindingRequestObject()
        {
            // Snippet: CreateDataAttributeBinding(CreateDataAttributeBindingRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateDataAttributeBindingRequest request = new gcdv::CreateDataAttributeBindingRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataAttributeBindingId = "",
                DataAttributeBinding = new gcdv::DataAttributeBinding(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.CreateDataAttributeBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAttributeBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceCreateDataAttributeBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttributeBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAttributeBindingAsync</summary>
        public async Task CreateDataAttributeBindingRequestObjectAsync()
        {
            // Snippet: CreateDataAttributeBindingAsync(CreateDataAttributeBindingRequest, CallSettings)
            // Additional: CreateDataAttributeBindingAsync(CreateDataAttributeBindingRequest, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateDataAttributeBindingRequest request = new gcdv::CreateDataAttributeBindingRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataAttributeBindingId = "",
                DataAttributeBinding = new gcdv::DataAttributeBinding(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.CreateDataAttributeBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAttributeBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceCreateDataAttributeBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttributeBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAttributeBinding</summary>
        public void CreateDataAttributeBinding()
        {
            // Snippet: CreateDataAttributeBinding(string, DataAttributeBinding, string, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::DataAttributeBinding dataAttributeBinding = new gcdv::DataAttributeBinding();
            string dataAttributeBindingId = "";
            // Make the request
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.CreateDataAttributeBinding(parent, dataAttributeBinding, dataAttributeBindingId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAttributeBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceCreateDataAttributeBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttributeBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAttributeBindingAsync</summary>
        public async Task CreateDataAttributeBindingAsync()
        {
            // Snippet: CreateDataAttributeBindingAsync(string, DataAttributeBinding, string, CallSettings)
            // Additional: CreateDataAttributeBindingAsync(string, DataAttributeBinding, string, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::DataAttributeBinding dataAttributeBinding = new gcdv::DataAttributeBinding();
            string dataAttributeBindingId = "";
            // Make the request
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.CreateDataAttributeBindingAsync(parent, dataAttributeBinding, dataAttributeBindingId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAttributeBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceCreateDataAttributeBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttributeBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAttributeBinding</summary>
        public void CreateDataAttributeBindingResourceNames()
        {
            // Snippet: CreateDataAttributeBinding(LocationName, DataAttributeBinding, string, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::DataAttributeBinding dataAttributeBinding = new gcdv::DataAttributeBinding();
            string dataAttributeBindingId = "";
            // Make the request
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.CreateDataAttributeBinding(parent, dataAttributeBinding, dataAttributeBindingId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAttributeBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceCreateDataAttributeBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttributeBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAttributeBindingAsync</summary>
        public async Task CreateDataAttributeBindingResourceNamesAsync()
        {
            // Snippet: CreateDataAttributeBindingAsync(LocationName, DataAttributeBinding, string, CallSettings)
            // Additional: CreateDataAttributeBindingAsync(LocationName, DataAttributeBinding, string, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::DataAttributeBinding dataAttributeBinding = new gcdv::DataAttributeBinding();
            string dataAttributeBindingId = "";
            // Make the request
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.CreateDataAttributeBindingAsync(parent, dataAttributeBinding, dataAttributeBindingId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAttributeBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceCreateDataAttributeBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttributeBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAttributeBinding</summary>
        public void UpdateDataAttributeBindingRequestObject()
        {
            // Snippet: UpdateDataAttributeBinding(UpdateDataAttributeBindingRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateDataAttributeBindingRequest request = new gcdv::UpdateDataAttributeBindingRequest
            {
                UpdateMask = new FieldMask(),
                DataAttributeBinding = new gcdv::DataAttributeBinding(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.UpdateDataAttributeBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAttributeBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceUpdateDataAttributeBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttributeBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAttributeBindingAsync</summary>
        public async Task UpdateDataAttributeBindingRequestObjectAsync()
        {
            // Snippet: UpdateDataAttributeBindingAsync(UpdateDataAttributeBindingRequest, CallSettings)
            // Additional: UpdateDataAttributeBindingAsync(UpdateDataAttributeBindingRequest, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateDataAttributeBindingRequest request = new gcdv::UpdateDataAttributeBindingRequest
            {
                UpdateMask = new FieldMask(),
                DataAttributeBinding = new gcdv::DataAttributeBinding(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.UpdateDataAttributeBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAttributeBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceUpdateDataAttributeBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttributeBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAttributeBinding</summary>
        public void UpdateDataAttributeBinding()
        {
            // Snippet: UpdateDataAttributeBinding(DataAttributeBinding, FieldMask, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataAttributeBinding dataAttributeBinding = new gcdv::DataAttributeBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.UpdateDataAttributeBinding(dataAttributeBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAttributeBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceUpdateDataAttributeBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttributeBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAttributeBindingAsync</summary>
        public async Task UpdateDataAttributeBindingAsync()
        {
            // Snippet: UpdateDataAttributeBindingAsync(DataAttributeBinding, FieldMask, CallSettings)
            // Additional: UpdateDataAttributeBindingAsync(DataAttributeBinding, FieldMask, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataAttributeBinding dataAttributeBinding = new gcdv::DataAttributeBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.UpdateDataAttributeBindingAsync(dataAttributeBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAttributeBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceUpdateDataAttributeBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttributeBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAttributeBinding</summary>
        public void DeleteDataAttributeBindingRequestObject()
        {
            // Snippet: DeleteDataAttributeBinding(DeleteDataAttributeBindingRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteDataAttributeBindingRequest request = new gcdv::DeleteDataAttributeBindingRequest
            {
                DataAttributeBindingName = gcdv::DataAttributeBindingName.FromProjectLocationDataAttributeBinding("[PROJECT]", "[LOCATION]", "[DATA_ATTRIBUTE_BINDING_ID]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.DeleteDataAttributeBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceDeleteDataAttributeBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAttributeBindingAsync</summary>
        public async Task DeleteDataAttributeBindingRequestObjectAsync()
        {
            // Snippet: DeleteDataAttributeBindingAsync(DeleteDataAttributeBindingRequest, CallSettings)
            // Additional: DeleteDataAttributeBindingAsync(DeleteDataAttributeBindingRequest, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteDataAttributeBindingRequest request = new gcdv::DeleteDataAttributeBindingRequest
            {
                DataAttributeBindingName = gcdv::DataAttributeBindingName.FromProjectLocationDataAttributeBinding("[PROJECT]", "[LOCATION]", "[DATA_ATTRIBUTE_BINDING_ID]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.DeleteDataAttributeBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceDeleteDataAttributeBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAttributeBinding</summary>
        public void DeleteDataAttributeBinding()
        {
            // Snippet: DeleteDataAttributeBinding(string, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataAttributeBindings/[DATA_ATTRIBUTE_BINDING_ID]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.DeleteDataAttributeBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceDeleteDataAttributeBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAttributeBindingAsync</summary>
        public async Task DeleteDataAttributeBindingAsync()
        {
            // Snippet: DeleteDataAttributeBindingAsync(string, CallSettings)
            // Additional: DeleteDataAttributeBindingAsync(string, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataAttributeBindings/[DATA_ATTRIBUTE_BINDING_ID]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.DeleteDataAttributeBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceDeleteDataAttributeBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAttributeBinding</summary>
        public void DeleteDataAttributeBindingResourceNames()
        {
            // Snippet: DeleteDataAttributeBinding(DataAttributeBindingName, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataAttributeBindingName name = gcdv::DataAttributeBindingName.FromProjectLocationDataAttributeBinding("[PROJECT]", "[LOCATION]", "[DATA_ATTRIBUTE_BINDING_ID]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.DeleteDataAttributeBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceDeleteDataAttributeBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAttributeBindingAsync</summary>
        public async Task DeleteDataAttributeBindingResourceNamesAsync()
        {
            // Snippet: DeleteDataAttributeBindingAsync(DataAttributeBindingName, CallSettings)
            // Additional: DeleteDataAttributeBindingAsync(DataAttributeBindingName, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataAttributeBindingName name = gcdv::DataAttributeBindingName.FromProjectLocationDataAttributeBinding("[PROJECT]", "[LOCATION]", "[DATA_ATTRIBUTE_BINDING_ID]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.DeleteDataAttributeBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceDeleteDataAttributeBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDataAttributeBindings</summary>
        public void ListDataAttributeBindingsRequestObject()
        {
            // Snippet: ListDataAttributeBindings(ListDataAttributeBindingsRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListDataAttributeBindingsRequest request = new gcdv::ListDataAttributeBindingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListDataAttributeBindingsResponse, gcdv::DataAttributeBinding> response = dataTaxonomyServiceClient.ListDataAttributeBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataAttributeBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataAttributeBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAttributeBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAttributeBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAttributeBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAttributeBindingsAsync</summary>
        public async Task ListDataAttributeBindingsRequestObjectAsync()
        {
            // Snippet: ListDataAttributeBindingsAsync(ListDataAttributeBindingsRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListDataAttributeBindingsRequest request = new gcdv::ListDataAttributeBindingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataAttributeBindingsResponse, gcdv::DataAttributeBinding> response = dataTaxonomyServiceClient.ListDataAttributeBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataAttributeBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataAttributeBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAttributeBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAttributeBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAttributeBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAttributeBindings</summary>
        public void ListDataAttributeBindings()
        {
            // Snippet: ListDataAttributeBindings(string, string, int?, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListDataAttributeBindingsResponse, gcdv::DataAttributeBinding> response = dataTaxonomyServiceClient.ListDataAttributeBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataAttributeBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataAttributeBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAttributeBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAttributeBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAttributeBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAttributeBindingsAsync</summary>
        public async Task ListDataAttributeBindingsAsync()
        {
            // Snippet: ListDataAttributeBindingsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataAttributeBindingsResponse, gcdv::DataAttributeBinding> response = dataTaxonomyServiceClient.ListDataAttributeBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataAttributeBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataAttributeBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAttributeBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAttributeBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAttributeBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAttributeBindings</summary>
        public void ListDataAttributeBindingsResourceNames()
        {
            // Snippet: ListDataAttributeBindings(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListDataAttributeBindingsResponse, gcdv::DataAttributeBinding> response = dataTaxonomyServiceClient.ListDataAttributeBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataAttributeBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataAttributeBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAttributeBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAttributeBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAttributeBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAttributeBindingsAsync</summary>
        public async Task ListDataAttributeBindingsResourceNamesAsync()
        {
            // Snippet: ListDataAttributeBindingsAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataAttributeBindingsResponse, gcdv::DataAttributeBinding> response = dataTaxonomyServiceClient.ListDataAttributeBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataAttributeBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataAttributeBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAttributeBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAttributeBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAttributeBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDataAttributeBinding</summary>
        public void GetDataAttributeBindingRequestObject()
        {
            // Snippet: GetDataAttributeBinding(GetDataAttributeBindingRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetDataAttributeBindingRequest request = new gcdv::GetDataAttributeBindingRequest
            {
                DataAttributeBindingName = gcdv::DataAttributeBindingName.FromProjectLocationDataAttributeBinding("[PROJECT]", "[LOCATION]", "[DATA_ATTRIBUTE_BINDING_ID]"),
            };
            // Make the request
            gcdv::DataAttributeBinding response = dataTaxonomyServiceClient.GetDataAttributeBinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataAttributeBindingAsync</summary>
        public async Task GetDataAttributeBindingRequestObjectAsync()
        {
            // Snippet: GetDataAttributeBindingAsync(GetDataAttributeBindingRequest, CallSettings)
            // Additional: GetDataAttributeBindingAsync(GetDataAttributeBindingRequest, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetDataAttributeBindingRequest request = new gcdv::GetDataAttributeBindingRequest
            {
                DataAttributeBindingName = gcdv::DataAttributeBindingName.FromProjectLocationDataAttributeBinding("[PROJECT]", "[LOCATION]", "[DATA_ATTRIBUTE_BINDING_ID]"),
            };
            // Make the request
            gcdv::DataAttributeBinding response = await dataTaxonomyServiceClient.GetDataAttributeBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataAttributeBinding</summary>
        public void GetDataAttributeBinding()
        {
            // Snippet: GetDataAttributeBinding(string, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataAttributeBindings/[DATA_ATTRIBUTE_BINDING_ID]";
            // Make the request
            gcdv::DataAttributeBinding response = dataTaxonomyServiceClient.GetDataAttributeBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAttributeBindingAsync</summary>
        public async Task GetDataAttributeBindingAsync()
        {
            // Snippet: GetDataAttributeBindingAsync(string, CallSettings)
            // Additional: GetDataAttributeBindingAsync(string, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataAttributeBindings/[DATA_ATTRIBUTE_BINDING_ID]";
            // Make the request
            gcdv::DataAttributeBinding response = await dataTaxonomyServiceClient.GetDataAttributeBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAttributeBinding</summary>
        public void GetDataAttributeBindingResourceNames()
        {
            // Snippet: GetDataAttributeBinding(DataAttributeBindingName, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataAttributeBindingName name = gcdv::DataAttributeBindingName.FromProjectLocationDataAttributeBinding("[PROJECT]", "[LOCATION]", "[DATA_ATTRIBUTE_BINDING_ID]");
            // Make the request
            gcdv::DataAttributeBinding response = dataTaxonomyServiceClient.GetDataAttributeBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAttributeBindingAsync</summary>
        public async Task GetDataAttributeBindingResourceNamesAsync()
        {
            // Snippet: GetDataAttributeBindingAsync(DataAttributeBindingName, CallSettings)
            // Additional: GetDataAttributeBindingAsync(DataAttributeBindingName, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataAttributeBindingName name = gcdv::DataAttributeBindingName.FromProjectLocationDataAttributeBinding("[PROJECT]", "[LOCATION]", "[DATA_ATTRIBUTE_BINDING_ID]");
            // Make the request
            gcdv::DataAttributeBinding response = await dataTaxonomyServiceClient.GetDataAttributeBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAttribute</summary>
        public void CreateDataAttributeRequestObject()
        {
            // Snippet: CreateDataAttribute(CreateDataAttributeRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateDataAttributeRequest request = new gcdv::CreateDataAttributeRequest
            {
                ParentAsDataTaxonomyName = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]"),
                DataAttributeId = "",
                DataAttribute = new gcdv::DataAttribute(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.CreateDataAttribute(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAttribute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceCreateDataAttribute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttribute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAttributeAsync</summary>
        public async Task CreateDataAttributeRequestObjectAsync()
        {
            // Snippet: CreateDataAttributeAsync(CreateDataAttributeRequest, CallSettings)
            // Additional: CreateDataAttributeAsync(CreateDataAttributeRequest, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateDataAttributeRequest request = new gcdv::CreateDataAttributeRequest
            {
                ParentAsDataTaxonomyName = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]"),
                DataAttributeId = "",
                DataAttribute = new gcdv::DataAttribute(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.CreateDataAttributeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAttribute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceCreateDataAttributeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttribute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAttribute</summary>
        public void CreateDataAttribute()
        {
            // Snippet: CreateDataAttribute(string, DataAttribute, string, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATA_TAXONOMY_ID]";
            gcdv::DataAttribute dataAttribute = new gcdv::DataAttribute();
            string dataAttributeId = "";
            // Make the request
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.CreateDataAttribute(parent, dataAttribute, dataAttributeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAttribute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceCreateDataAttribute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttribute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAttributeAsync</summary>
        public async Task CreateDataAttributeAsync()
        {
            // Snippet: CreateDataAttributeAsync(string, DataAttribute, string, CallSettings)
            // Additional: CreateDataAttributeAsync(string, DataAttribute, string, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATA_TAXONOMY_ID]";
            gcdv::DataAttribute dataAttribute = new gcdv::DataAttribute();
            string dataAttributeId = "";
            // Make the request
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.CreateDataAttributeAsync(parent, dataAttribute, dataAttributeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAttribute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceCreateDataAttributeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttribute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAttribute</summary>
        public void CreateDataAttributeResourceNames()
        {
            // Snippet: CreateDataAttribute(DataTaxonomyName, DataAttribute, string, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataTaxonomyName parent = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]");
            gcdv::DataAttribute dataAttribute = new gcdv::DataAttribute();
            string dataAttributeId = "";
            // Make the request
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.CreateDataAttribute(parent, dataAttribute, dataAttributeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAttribute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceCreateDataAttribute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttribute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAttributeAsync</summary>
        public async Task CreateDataAttributeResourceNamesAsync()
        {
            // Snippet: CreateDataAttributeAsync(DataTaxonomyName, DataAttribute, string, CallSettings)
            // Additional: CreateDataAttributeAsync(DataTaxonomyName, DataAttribute, string, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataTaxonomyName parent = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]");
            gcdv::DataAttribute dataAttribute = new gcdv::DataAttribute();
            string dataAttributeId = "";
            // Make the request
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.CreateDataAttributeAsync(parent, dataAttribute, dataAttributeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAttribute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceCreateDataAttributeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttribute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAttribute</summary>
        public void UpdateDataAttributeRequestObject()
        {
            // Snippet: UpdateDataAttribute(UpdateDataAttributeRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateDataAttributeRequest request = new gcdv::UpdateDataAttributeRequest
            {
                UpdateMask = new FieldMask(),
                DataAttribute = new gcdv::DataAttribute(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.UpdateDataAttribute(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAttribute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceUpdateDataAttribute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttribute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAttributeAsync</summary>
        public async Task UpdateDataAttributeRequestObjectAsync()
        {
            // Snippet: UpdateDataAttributeAsync(UpdateDataAttributeRequest, CallSettings)
            // Additional: UpdateDataAttributeAsync(UpdateDataAttributeRequest, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateDataAttributeRequest request = new gcdv::UpdateDataAttributeRequest
            {
                UpdateMask = new FieldMask(),
                DataAttribute = new gcdv::DataAttribute(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.UpdateDataAttributeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAttribute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceUpdateDataAttributeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttribute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAttribute</summary>
        public void UpdateDataAttribute()
        {
            // Snippet: UpdateDataAttribute(DataAttribute, FieldMask, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataAttribute dataAttribute = new gcdv::DataAttribute();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.UpdateDataAttribute(dataAttribute, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DataAttribute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceUpdateDataAttribute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttribute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAttributeAsync</summary>
        public async Task UpdateDataAttributeAsync()
        {
            // Snippet: UpdateDataAttributeAsync(DataAttribute, FieldMask, CallSettings)
            // Additional: UpdateDataAttributeAsync(DataAttribute, FieldMask, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataAttribute dataAttribute = new gcdv::DataAttribute();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.UpdateDataAttributeAsync(dataAttribute, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DataAttribute result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DataAttribute, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceUpdateDataAttributeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DataAttribute retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAttribute</summary>
        public void DeleteDataAttributeRequestObject()
        {
            // Snippet: DeleteDataAttribute(DeleteDataAttributeRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteDataAttributeRequest request = new gcdv::DeleteDataAttributeRequest
            {
                DataAttributeName = gcdv::DataAttributeName.FromProjectLocationDataTaxonomyDataAttribute("[PROJECT]", "[LOCATION]", "[DATATAXONOMY]", "[DATA_ATTRIBUTE_ID]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.DeleteDataAttribute(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceDeleteDataAttribute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAttributeAsync</summary>
        public async Task DeleteDataAttributeRequestObjectAsync()
        {
            // Snippet: DeleteDataAttributeAsync(DeleteDataAttributeRequest, CallSettings)
            // Additional: DeleteDataAttributeAsync(DeleteDataAttributeRequest, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteDataAttributeRequest request = new gcdv::DeleteDataAttributeRequest
            {
                DataAttributeName = gcdv::DataAttributeName.FromProjectLocationDataTaxonomyDataAttribute("[PROJECT]", "[LOCATION]", "[DATATAXONOMY]", "[DATA_ATTRIBUTE_ID]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.DeleteDataAttributeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceDeleteDataAttributeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAttribute</summary>
        public void DeleteDataAttribute()
        {
            // Snippet: DeleteDataAttribute(string, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATATAXONOMY]/attributes/[DATA_ATTRIBUTE_ID]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.DeleteDataAttribute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceDeleteDataAttribute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAttributeAsync</summary>
        public async Task DeleteDataAttributeAsync()
        {
            // Snippet: DeleteDataAttributeAsync(string, CallSettings)
            // Additional: DeleteDataAttributeAsync(string, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATATAXONOMY]/attributes/[DATA_ATTRIBUTE_ID]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.DeleteDataAttributeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceDeleteDataAttributeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAttribute</summary>
        public void DeleteDataAttributeResourceNames()
        {
            // Snippet: DeleteDataAttribute(DataAttributeName, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataAttributeName name = gcdv::DataAttributeName.FromProjectLocationDataTaxonomyDataAttribute("[PROJECT]", "[LOCATION]", "[DATATAXONOMY]", "[DATA_ATTRIBUTE_ID]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataTaxonomyServiceClient.DeleteDataAttribute(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceDeleteDataAttribute(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAttributeAsync</summary>
        public async Task DeleteDataAttributeResourceNamesAsync()
        {
            // Snippet: DeleteDataAttributeAsync(DataAttributeName, CallSettings)
            // Additional: DeleteDataAttributeAsync(DataAttributeName, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataAttributeName name = gcdv::DataAttributeName.FromProjectLocationDataTaxonomyDataAttribute("[PROJECT]", "[LOCATION]", "[DATATAXONOMY]", "[DATA_ATTRIBUTE_ID]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.DeleteDataAttributeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceDeleteDataAttributeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDataAttributes</summary>
        public void ListDataAttributesRequestObject()
        {
            // Snippet: ListDataAttributes(ListDataAttributesRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListDataAttributesRequest request = new gcdv::ListDataAttributesRequest
            {
                ParentAsDataTaxonomyName = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListDataAttributesResponse, gcdv::DataAttribute> response = dataTaxonomyServiceClient.ListDataAttributes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataAttribute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataAttributesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAttribute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAttribute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAttribute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAttributesAsync</summary>
        public async Task ListDataAttributesRequestObjectAsync()
        {
            // Snippet: ListDataAttributesAsync(ListDataAttributesRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListDataAttributesRequest request = new gcdv::ListDataAttributesRequest
            {
                ParentAsDataTaxonomyName = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataAttributesResponse, gcdv::DataAttribute> response = dataTaxonomyServiceClient.ListDataAttributesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataAttribute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataAttributesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAttribute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAttribute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAttribute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAttributes</summary>
        public void ListDataAttributes()
        {
            // Snippet: ListDataAttributes(string, string, int?, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATA_TAXONOMY_ID]";
            // Make the request
            PagedEnumerable<gcdv::ListDataAttributesResponse, gcdv::DataAttribute> response = dataTaxonomyServiceClient.ListDataAttributes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataAttribute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataAttributesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAttribute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAttribute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAttribute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAttributesAsync</summary>
        public async Task ListDataAttributesAsync()
        {
            // Snippet: ListDataAttributesAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATA_TAXONOMY_ID]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataAttributesResponse, gcdv::DataAttribute> response = dataTaxonomyServiceClient.ListDataAttributesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataAttribute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataAttributesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAttribute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAttribute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAttribute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAttributes</summary>
        public void ListDataAttributesResourceNames()
        {
            // Snippet: ListDataAttributes(DataTaxonomyName, string, int?, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataTaxonomyName parent = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]");
            // Make the request
            PagedEnumerable<gcdv::ListDataAttributesResponse, gcdv::DataAttribute> response = dataTaxonomyServiceClient.ListDataAttributes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::DataAttribute item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListDataAttributesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAttribute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAttribute> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAttribute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAttributesAsync</summary>
        public async Task ListDataAttributesResourceNamesAsync()
        {
            // Snippet: ListDataAttributesAsync(DataTaxonomyName, string, int?, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataTaxonomyName parent = gcdv::DataTaxonomyName.FromProjectLocationDataTaxonomy("[PROJECT]", "[LOCATION]", "[DATA_TAXONOMY_ID]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListDataAttributesResponse, gcdv::DataAttribute> response = dataTaxonomyServiceClient.ListDataAttributesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::DataAttribute item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListDataAttributesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::DataAttribute item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::DataAttribute> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::DataAttribute item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDataAttribute</summary>
        public void GetDataAttributeRequestObject()
        {
            // Snippet: GetDataAttribute(GetDataAttributeRequest, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetDataAttributeRequest request = new gcdv::GetDataAttributeRequest
            {
                DataAttributeName = gcdv::DataAttributeName.FromProjectLocationDataTaxonomyDataAttribute("[PROJECT]", "[LOCATION]", "[DATATAXONOMY]", "[DATA_ATTRIBUTE_ID]"),
            };
            // Make the request
            gcdv::DataAttribute response = dataTaxonomyServiceClient.GetDataAttribute(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataAttributeAsync</summary>
        public async Task GetDataAttributeRequestObjectAsync()
        {
            // Snippet: GetDataAttributeAsync(GetDataAttributeRequest, CallSettings)
            // Additional: GetDataAttributeAsync(GetDataAttributeRequest, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetDataAttributeRequest request = new gcdv::GetDataAttributeRequest
            {
                DataAttributeName = gcdv::DataAttributeName.FromProjectLocationDataTaxonomyDataAttribute("[PROJECT]", "[LOCATION]", "[DATATAXONOMY]", "[DATA_ATTRIBUTE_ID]"),
            };
            // Make the request
            gcdv::DataAttribute response = await dataTaxonomyServiceClient.GetDataAttributeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataAttribute</summary>
        public void GetDataAttribute()
        {
            // Snippet: GetDataAttribute(string, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATATAXONOMY]/attributes/[DATA_ATTRIBUTE_ID]";
            // Make the request
            gcdv::DataAttribute response = dataTaxonomyServiceClient.GetDataAttribute(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAttributeAsync</summary>
        public async Task GetDataAttributeAsync()
        {
            // Snippet: GetDataAttributeAsync(string, CallSettings)
            // Additional: GetDataAttributeAsync(string, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATATAXONOMY]/attributes/[DATA_ATTRIBUTE_ID]";
            // Make the request
            gcdv::DataAttribute response = await dataTaxonomyServiceClient.GetDataAttributeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAttribute</summary>
        public void GetDataAttributeResourceNames()
        {
            // Snippet: GetDataAttribute(DataAttributeName, CallSettings)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = gcdv::DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DataAttributeName name = gcdv::DataAttributeName.FromProjectLocationDataTaxonomyDataAttribute("[PROJECT]", "[LOCATION]", "[DATATAXONOMY]", "[DATA_ATTRIBUTE_ID]");
            // Make the request
            gcdv::DataAttribute response = dataTaxonomyServiceClient.GetDataAttribute(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAttributeAsync</summary>
        public async Task GetDataAttributeResourceNamesAsync()
        {
            // Snippet: GetDataAttributeAsync(DataAttributeName, CallSettings)
            // Additional: GetDataAttributeAsync(DataAttributeName, CancellationToken)
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DataAttributeName name = gcdv::DataAttributeName.FromProjectLocationDataTaxonomyDataAttribute("[PROJECT]", "[LOCATION]", "[DATATAXONOMY]", "[DATA_ATTRIBUTE_ID]");
            // Make the request
            gcdv::DataAttribute response = await dataTaxonomyServiceClient.GetDataAttributeAsync(name);
            // End snippet
        }
    }
}
