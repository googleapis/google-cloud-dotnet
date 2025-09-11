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
    public sealed class AllGeneratedBusinessGlossaryServiceClientSnippets
    {
        /// <summary>Snippet for CreateGlossary</summary>
        public void CreateGlossaryRequestObject()
        {
            // Snippet: CreateGlossary(CreateGlossaryRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateGlossaryRequest request = new gcdv::CreateGlossaryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GlossaryId = "",
                Glossary = new gcdv::Glossary(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Glossary, gcdv::OperationMetadata> response = businessGlossaryServiceClient.CreateGlossary(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Glossary, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Glossary, gcdv::OperationMetadata> retrievedResponse = businessGlossaryServiceClient.PollOnceCreateGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryAsync</summary>
        public async Task CreateGlossaryRequestObjectAsync()
        {
            // Snippet: CreateGlossaryAsync(CreateGlossaryRequest, CallSettings)
            // Additional: CreateGlossaryAsync(CreateGlossaryRequest, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateGlossaryRequest request = new gcdv::CreateGlossaryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GlossaryId = "",
                Glossary = new gcdv::Glossary(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Glossary, gcdv::OperationMetadata> response = await businessGlossaryServiceClient.CreateGlossaryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Glossary, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Glossary, gcdv::OperationMetadata> retrievedResponse = await businessGlossaryServiceClient.PollOnceCreateGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossary</summary>
        public void CreateGlossary()
        {
            // Snippet: CreateGlossary(string, Glossary, string, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::Glossary glossary = new gcdv::Glossary();
            string glossaryId = "";
            // Make the request
            Operation<gcdv::Glossary, gcdv::OperationMetadata> response = businessGlossaryServiceClient.CreateGlossary(parent, glossary, glossaryId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Glossary, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Glossary, gcdv::OperationMetadata> retrievedResponse = businessGlossaryServiceClient.PollOnceCreateGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryAsync</summary>
        public async Task CreateGlossaryAsync()
        {
            // Snippet: CreateGlossaryAsync(string, Glossary, string, CallSettings)
            // Additional: CreateGlossaryAsync(string, Glossary, string, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::Glossary glossary = new gcdv::Glossary();
            string glossaryId = "";
            // Make the request
            Operation<gcdv::Glossary, gcdv::OperationMetadata> response = await businessGlossaryServiceClient.CreateGlossaryAsync(parent, glossary, glossaryId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Glossary, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Glossary, gcdv::OperationMetadata> retrievedResponse = await businessGlossaryServiceClient.PollOnceCreateGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossary</summary>
        public void CreateGlossaryResourceNames()
        {
            // Snippet: CreateGlossary(LocationName, Glossary, string, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::Glossary glossary = new gcdv::Glossary();
            string glossaryId = "";
            // Make the request
            Operation<gcdv::Glossary, gcdv::OperationMetadata> response = businessGlossaryServiceClient.CreateGlossary(parent, glossary, glossaryId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Glossary, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Glossary, gcdv::OperationMetadata> retrievedResponse = businessGlossaryServiceClient.PollOnceCreateGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryAsync</summary>
        public async Task CreateGlossaryResourceNamesAsync()
        {
            // Snippet: CreateGlossaryAsync(LocationName, Glossary, string, CallSettings)
            // Additional: CreateGlossaryAsync(LocationName, Glossary, string, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::Glossary glossary = new gcdv::Glossary();
            string glossaryId = "";
            // Make the request
            Operation<gcdv::Glossary, gcdv::OperationMetadata> response = await businessGlossaryServiceClient.CreateGlossaryAsync(parent, glossary, glossaryId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Glossary, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Glossary, gcdv::OperationMetadata> retrievedResponse = await businessGlossaryServiceClient.PollOnceCreateGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossary</summary>
        public void UpdateGlossaryRequestObject()
        {
            // Snippet: UpdateGlossary(UpdateGlossaryRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateGlossaryRequest request = new gcdv::UpdateGlossaryRequest
            {
                Glossary = new gcdv::Glossary(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Glossary, gcdv::OperationMetadata> response = businessGlossaryServiceClient.UpdateGlossary(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Glossary, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Glossary, gcdv::OperationMetadata> retrievedResponse = businessGlossaryServiceClient.PollOnceUpdateGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryAsync</summary>
        public async Task UpdateGlossaryRequestObjectAsync()
        {
            // Snippet: UpdateGlossaryAsync(UpdateGlossaryRequest, CallSettings)
            // Additional: UpdateGlossaryAsync(UpdateGlossaryRequest, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateGlossaryRequest request = new gcdv::UpdateGlossaryRequest
            {
                Glossary = new gcdv::Glossary(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Glossary, gcdv::OperationMetadata> response = await businessGlossaryServiceClient.UpdateGlossaryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Glossary, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Glossary, gcdv::OperationMetadata> retrievedResponse = await businessGlossaryServiceClient.PollOnceUpdateGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossary</summary>
        public void UpdateGlossary()
        {
            // Snippet: UpdateGlossary(Glossary, FieldMask, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::Glossary glossary = new gcdv::Glossary();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Glossary, gcdv::OperationMetadata> response = businessGlossaryServiceClient.UpdateGlossary(glossary, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Glossary, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Glossary, gcdv::OperationMetadata> retrievedResponse = businessGlossaryServiceClient.PollOnceUpdateGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryAsync</summary>
        public async Task UpdateGlossaryAsync()
        {
            // Snippet: UpdateGlossaryAsync(Glossary, FieldMask, CallSettings)
            // Additional: UpdateGlossaryAsync(Glossary, FieldMask, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::Glossary glossary = new gcdv::Glossary();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Glossary, gcdv::OperationMetadata> response = await businessGlossaryServiceClient.UpdateGlossaryAsync(glossary, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Glossary, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Glossary result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Glossary, gcdv::OperationMetadata> retrievedResponse = await businessGlossaryServiceClient.PollOnceUpdateGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Glossary retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossary</summary>
        public void DeleteGlossaryRequestObject()
        {
            // Snippet: DeleteGlossary(DeleteGlossaryRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteGlossaryRequest request = new gcdv::DeleteGlossaryRequest
            {
                GlossaryName = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = businessGlossaryServiceClient.DeleteGlossary(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = businessGlossaryServiceClient.PollOnceDeleteGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryAsync</summary>
        public async Task DeleteGlossaryRequestObjectAsync()
        {
            // Snippet: DeleteGlossaryAsync(DeleteGlossaryRequest, CallSettings)
            // Additional: DeleteGlossaryAsync(DeleteGlossaryRequest, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteGlossaryRequest request = new gcdv::DeleteGlossaryRequest
            {
                GlossaryName = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await businessGlossaryServiceClient.DeleteGlossaryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await businessGlossaryServiceClient.PollOnceDeleteGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossary</summary>
        public void DeleteGlossary()
        {
            // Snippet: DeleteGlossary(string, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = businessGlossaryServiceClient.DeleteGlossary(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = businessGlossaryServiceClient.PollOnceDeleteGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryAsync</summary>
        public async Task DeleteGlossaryAsync()
        {
            // Snippet: DeleteGlossaryAsync(string, CallSettings)
            // Additional: DeleteGlossaryAsync(string, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await businessGlossaryServiceClient.DeleteGlossaryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await businessGlossaryServiceClient.PollOnceDeleteGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossary</summary>
        public void DeleteGlossaryResourceNames()
        {
            // Snippet: DeleteGlossary(GlossaryName, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GlossaryName name = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = businessGlossaryServiceClient.DeleteGlossary(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = businessGlossaryServiceClient.PollOnceDeleteGlossary(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryAsync</summary>
        public async Task DeleteGlossaryResourceNamesAsync()
        {
            // Snippet: DeleteGlossaryAsync(GlossaryName, CallSettings)
            // Additional: DeleteGlossaryAsync(GlossaryName, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GlossaryName name = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await businessGlossaryServiceClient.DeleteGlossaryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await businessGlossaryServiceClient.PollOnceDeleteGlossaryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetGlossary</summary>
        public void GetGlossaryRequestObject()
        {
            // Snippet: GetGlossary(GetGlossaryRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetGlossaryRequest request = new gcdv::GetGlossaryRequest
            {
                GlossaryName = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            // Make the request
            gcdv::Glossary response = businessGlossaryServiceClient.GetGlossary(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryAsync</summary>
        public async Task GetGlossaryRequestObjectAsync()
        {
            // Snippet: GetGlossaryAsync(GetGlossaryRequest, CallSettings)
            // Additional: GetGlossaryAsync(GetGlossaryRequest, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetGlossaryRequest request = new gcdv::GetGlossaryRequest
            {
                GlossaryName = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            // Make the request
            gcdv::Glossary response = await businessGlossaryServiceClient.GetGlossaryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlossary</summary>
        public void GetGlossary()
        {
            // Snippet: GetGlossary(string, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            gcdv::Glossary response = businessGlossaryServiceClient.GetGlossary(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryAsync</summary>
        public async Task GetGlossaryAsync()
        {
            // Snippet: GetGlossaryAsync(string, CallSettings)
            // Additional: GetGlossaryAsync(string, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            gcdv::Glossary response = await businessGlossaryServiceClient.GetGlossaryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossary</summary>
        public void GetGlossaryResourceNames()
        {
            // Snippet: GetGlossary(GlossaryName, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GlossaryName name = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            gcdv::Glossary response = businessGlossaryServiceClient.GetGlossary(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryAsync</summary>
        public async Task GetGlossaryResourceNamesAsync()
        {
            // Snippet: GetGlossaryAsync(GlossaryName, CallSettings)
            // Additional: GetGlossaryAsync(GlossaryName, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GlossaryName name = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            gcdv::Glossary response = await businessGlossaryServiceClient.GetGlossaryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGlossaries</summary>
        public void ListGlossariesRequestObject()
        {
            // Snippet: ListGlossaries(ListGlossariesRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListGlossariesRequest request = new gcdv::ListGlossariesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListGlossariesResponse, gcdv::Glossary> response = businessGlossaryServiceClient.ListGlossaries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Glossary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListGlossariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Glossary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Glossary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Glossary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossariesAsync</summary>
        public async Task ListGlossariesRequestObjectAsync()
        {
            // Snippet: ListGlossariesAsync(ListGlossariesRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListGlossariesRequest request = new gcdv::ListGlossariesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListGlossariesResponse, gcdv::Glossary> response = businessGlossaryServiceClient.ListGlossariesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Glossary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListGlossariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Glossary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Glossary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Glossary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaries</summary>
        public void ListGlossaries()
        {
            // Snippet: ListGlossaries(string, string, int?, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListGlossariesResponse, gcdv::Glossary> response = businessGlossaryServiceClient.ListGlossaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Glossary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListGlossariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Glossary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Glossary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Glossary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossariesAsync</summary>
        public async Task ListGlossariesAsync()
        {
            // Snippet: ListGlossariesAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListGlossariesResponse, gcdv::Glossary> response = businessGlossaryServiceClient.ListGlossariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Glossary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListGlossariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Glossary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Glossary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Glossary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaries</summary>
        public void ListGlossariesResourceNames()
        {
            // Snippet: ListGlossaries(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListGlossariesResponse, gcdv::Glossary> response = businessGlossaryServiceClient.ListGlossaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Glossary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListGlossariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Glossary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Glossary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Glossary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossariesAsync</summary>
        public async Task ListGlossariesResourceNamesAsync()
        {
            // Snippet: ListGlossariesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListGlossariesResponse, gcdv::Glossary> response = businessGlossaryServiceClient.ListGlossariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Glossary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListGlossariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Glossary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Glossary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Glossary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryCategory</summary>
        public void CreateGlossaryCategoryRequestObject()
        {
            // Snippet: CreateGlossaryCategory(CreateGlossaryCategoryRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateGlossaryCategoryRequest request = new gcdv::CreateGlossaryCategoryRequest
            {
                ParentAsGlossaryName = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                CategoryId = "",
                Category = new gcdv::GlossaryCategory(),
            };
            // Make the request
            gcdv::GlossaryCategory response = businessGlossaryServiceClient.CreateGlossaryCategory(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryCategoryAsync</summary>
        public async Task CreateGlossaryCategoryRequestObjectAsync()
        {
            // Snippet: CreateGlossaryCategoryAsync(CreateGlossaryCategoryRequest, CallSettings)
            // Additional: CreateGlossaryCategoryAsync(CreateGlossaryCategoryRequest, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateGlossaryCategoryRequest request = new gcdv::CreateGlossaryCategoryRequest
            {
                ParentAsGlossaryName = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                CategoryId = "",
                Category = new gcdv::GlossaryCategory(),
            };
            // Make the request
            gcdv::GlossaryCategory response = await businessGlossaryServiceClient.CreateGlossaryCategoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryCategory</summary>
        public void CreateGlossaryCategory()
        {
            // Snippet: CreateGlossaryCategory(string, GlossaryCategory, string, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            gcdv::GlossaryCategory category = new gcdv::GlossaryCategory();
            string categoryId = "";
            // Make the request
            gcdv::GlossaryCategory response = businessGlossaryServiceClient.CreateGlossaryCategory(parent, category, categoryId);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryCategoryAsync</summary>
        public async Task CreateGlossaryCategoryAsync()
        {
            // Snippet: CreateGlossaryCategoryAsync(string, GlossaryCategory, string, CallSettings)
            // Additional: CreateGlossaryCategoryAsync(string, GlossaryCategory, string, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            gcdv::GlossaryCategory category = new gcdv::GlossaryCategory();
            string categoryId = "";
            // Make the request
            gcdv::GlossaryCategory response = await businessGlossaryServiceClient.CreateGlossaryCategoryAsync(parent, category, categoryId);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryCategory</summary>
        public void CreateGlossaryCategoryResourceNames()
        {
            // Snippet: CreateGlossaryCategory(GlossaryName, GlossaryCategory, string, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GlossaryName parent = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            gcdv::GlossaryCategory category = new gcdv::GlossaryCategory();
            string categoryId = "";
            // Make the request
            gcdv::GlossaryCategory response = businessGlossaryServiceClient.CreateGlossaryCategory(parent, category, categoryId);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryCategoryAsync</summary>
        public async Task CreateGlossaryCategoryResourceNamesAsync()
        {
            // Snippet: CreateGlossaryCategoryAsync(GlossaryName, GlossaryCategory, string, CallSettings)
            // Additional: CreateGlossaryCategoryAsync(GlossaryName, GlossaryCategory, string, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GlossaryName parent = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            gcdv::GlossaryCategory category = new gcdv::GlossaryCategory();
            string categoryId = "";
            // Make the request
            gcdv::GlossaryCategory response = await businessGlossaryServiceClient.CreateGlossaryCategoryAsync(parent, category, categoryId);
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryCategory</summary>
        public void UpdateGlossaryCategoryRequestObject()
        {
            // Snippet: UpdateGlossaryCategory(UpdateGlossaryCategoryRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateGlossaryCategoryRequest request = new gcdv::UpdateGlossaryCategoryRequest
            {
                Category = new gcdv::GlossaryCategory(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcdv::GlossaryCategory response = businessGlossaryServiceClient.UpdateGlossaryCategory(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryCategoryAsync</summary>
        public async Task UpdateGlossaryCategoryRequestObjectAsync()
        {
            // Snippet: UpdateGlossaryCategoryAsync(UpdateGlossaryCategoryRequest, CallSettings)
            // Additional: UpdateGlossaryCategoryAsync(UpdateGlossaryCategoryRequest, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateGlossaryCategoryRequest request = new gcdv::UpdateGlossaryCategoryRequest
            {
                Category = new gcdv::GlossaryCategory(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcdv::GlossaryCategory response = await businessGlossaryServiceClient.UpdateGlossaryCategoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryCategory</summary>
        public void UpdateGlossaryCategory()
        {
            // Snippet: UpdateGlossaryCategory(GlossaryCategory, FieldMask, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GlossaryCategory category = new gcdv::GlossaryCategory();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::GlossaryCategory response = businessGlossaryServiceClient.UpdateGlossaryCategory(category, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryCategoryAsync</summary>
        public async Task UpdateGlossaryCategoryAsync()
        {
            // Snippet: UpdateGlossaryCategoryAsync(GlossaryCategory, FieldMask, CallSettings)
            // Additional: UpdateGlossaryCategoryAsync(GlossaryCategory, FieldMask, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GlossaryCategory category = new gcdv::GlossaryCategory();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::GlossaryCategory response = await businessGlossaryServiceClient.UpdateGlossaryCategoryAsync(category, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryCategory</summary>
        public void DeleteGlossaryCategoryRequestObject()
        {
            // Snippet: DeleteGlossaryCategory(DeleteGlossaryCategoryRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteGlossaryCategoryRequest request = new gcdv::DeleteGlossaryCategoryRequest
            {
                GlossaryCategoryName = gcdv::GlossaryCategoryName.FromProjectLocationGlossaryGlossaryCategory("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_CATEGORY]"),
            };
            // Make the request
            businessGlossaryServiceClient.DeleteGlossaryCategory(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryCategoryAsync</summary>
        public async Task DeleteGlossaryCategoryRequestObjectAsync()
        {
            // Snippet: DeleteGlossaryCategoryAsync(DeleteGlossaryCategoryRequest, CallSettings)
            // Additional: DeleteGlossaryCategoryAsync(DeleteGlossaryCategoryRequest, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteGlossaryCategoryRequest request = new gcdv::DeleteGlossaryCategoryRequest
            {
                GlossaryCategoryName = gcdv::GlossaryCategoryName.FromProjectLocationGlossaryGlossaryCategory("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_CATEGORY]"),
            };
            // Make the request
            await businessGlossaryServiceClient.DeleteGlossaryCategoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryCategory</summary>
        public void DeleteGlossaryCategory()
        {
            // Snippet: DeleteGlossaryCategory(string, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]/categories/[GLOSSARY_CATEGORY]";
            // Make the request
            businessGlossaryServiceClient.DeleteGlossaryCategory(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryCategoryAsync</summary>
        public async Task DeleteGlossaryCategoryAsync()
        {
            // Snippet: DeleteGlossaryCategoryAsync(string, CallSettings)
            // Additional: DeleteGlossaryCategoryAsync(string, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]/categories/[GLOSSARY_CATEGORY]";
            // Make the request
            await businessGlossaryServiceClient.DeleteGlossaryCategoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryCategory</summary>
        public void DeleteGlossaryCategoryResourceNames()
        {
            // Snippet: DeleteGlossaryCategory(GlossaryCategoryName, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GlossaryCategoryName name = gcdv::GlossaryCategoryName.FromProjectLocationGlossaryGlossaryCategory("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_CATEGORY]");
            // Make the request
            businessGlossaryServiceClient.DeleteGlossaryCategory(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryCategoryAsync</summary>
        public async Task DeleteGlossaryCategoryResourceNamesAsync()
        {
            // Snippet: DeleteGlossaryCategoryAsync(GlossaryCategoryName, CallSettings)
            // Additional: DeleteGlossaryCategoryAsync(GlossaryCategoryName, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GlossaryCategoryName name = gcdv::GlossaryCategoryName.FromProjectLocationGlossaryGlossaryCategory("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_CATEGORY]");
            // Make the request
            await businessGlossaryServiceClient.DeleteGlossaryCategoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryCategory</summary>
        public void GetGlossaryCategoryRequestObject()
        {
            // Snippet: GetGlossaryCategory(GetGlossaryCategoryRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetGlossaryCategoryRequest request = new gcdv::GetGlossaryCategoryRequest
            {
                GlossaryCategoryName = gcdv::GlossaryCategoryName.FromProjectLocationGlossaryGlossaryCategory("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_CATEGORY]"),
            };
            // Make the request
            gcdv::GlossaryCategory response = businessGlossaryServiceClient.GetGlossaryCategory(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryCategoryAsync</summary>
        public async Task GetGlossaryCategoryRequestObjectAsync()
        {
            // Snippet: GetGlossaryCategoryAsync(GetGlossaryCategoryRequest, CallSettings)
            // Additional: GetGlossaryCategoryAsync(GetGlossaryCategoryRequest, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetGlossaryCategoryRequest request = new gcdv::GetGlossaryCategoryRequest
            {
                GlossaryCategoryName = gcdv::GlossaryCategoryName.FromProjectLocationGlossaryGlossaryCategory("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_CATEGORY]"),
            };
            // Make the request
            gcdv::GlossaryCategory response = await businessGlossaryServiceClient.GetGlossaryCategoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryCategory</summary>
        public void GetGlossaryCategory()
        {
            // Snippet: GetGlossaryCategory(string, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]/categories/[GLOSSARY_CATEGORY]";
            // Make the request
            gcdv::GlossaryCategory response = businessGlossaryServiceClient.GetGlossaryCategory(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryCategoryAsync</summary>
        public async Task GetGlossaryCategoryAsync()
        {
            // Snippet: GetGlossaryCategoryAsync(string, CallSettings)
            // Additional: GetGlossaryCategoryAsync(string, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]/categories/[GLOSSARY_CATEGORY]";
            // Make the request
            gcdv::GlossaryCategory response = await businessGlossaryServiceClient.GetGlossaryCategoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryCategory</summary>
        public void GetGlossaryCategoryResourceNames()
        {
            // Snippet: GetGlossaryCategory(GlossaryCategoryName, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GlossaryCategoryName name = gcdv::GlossaryCategoryName.FromProjectLocationGlossaryGlossaryCategory("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_CATEGORY]");
            // Make the request
            gcdv::GlossaryCategory response = businessGlossaryServiceClient.GetGlossaryCategory(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryCategoryAsync</summary>
        public async Task GetGlossaryCategoryResourceNamesAsync()
        {
            // Snippet: GetGlossaryCategoryAsync(GlossaryCategoryName, CallSettings)
            // Additional: GetGlossaryCategoryAsync(GlossaryCategoryName, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GlossaryCategoryName name = gcdv::GlossaryCategoryName.FromProjectLocationGlossaryGlossaryCategory("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_CATEGORY]");
            // Make the request
            gcdv::GlossaryCategory response = await businessGlossaryServiceClient.GetGlossaryCategoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryCategories</summary>
        public void ListGlossaryCategoriesRequestObject()
        {
            // Snippet: ListGlossaryCategories(ListGlossaryCategoriesRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListGlossaryCategoriesRequest request = new gcdv::ListGlossaryCategoriesRequest
            {
                ParentAsGlossaryName = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListGlossaryCategoriesResponse, gcdv::GlossaryCategory> response = businessGlossaryServiceClient.ListGlossaryCategories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::GlossaryCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListGlossaryCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::GlossaryCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::GlossaryCategory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::GlossaryCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryCategoriesAsync</summary>
        public async Task ListGlossaryCategoriesRequestObjectAsync()
        {
            // Snippet: ListGlossaryCategoriesAsync(ListGlossaryCategoriesRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListGlossaryCategoriesRequest request = new gcdv::ListGlossaryCategoriesRequest
            {
                ParentAsGlossaryName = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListGlossaryCategoriesResponse, gcdv::GlossaryCategory> response = businessGlossaryServiceClient.ListGlossaryCategoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::GlossaryCategory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListGlossaryCategoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::GlossaryCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::GlossaryCategory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::GlossaryCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryCategories</summary>
        public void ListGlossaryCategories()
        {
            // Snippet: ListGlossaryCategories(string, string, int?, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            PagedEnumerable<gcdv::ListGlossaryCategoriesResponse, gcdv::GlossaryCategory> response = businessGlossaryServiceClient.ListGlossaryCategories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::GlossaryCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListGlossaryCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::GlossaryCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::GlossaryCategory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::GlossaryCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryCategoriesAsync</summary>
        public async Task ListGlossaryCategoriesAsync()
        {
            // Snippet: ListGlossaryCategoriesAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListGlossaryCategoriesResponse, gcdv::GlossaryCategory> response = businessGlossaryServiceClient.ListGlossaryCategoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::GlossaryCategory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListGlossaryCategoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::GlossaryCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::GlossaryCategory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::GlossaryCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryCategories</summary>
        public void ListGlossaryCategoriesResourceNames()
        {
            // Snippet: ListGlossaryCategories(GlossaryName, string, int?, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GlossaryName parent = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            PagedEnumerable<gcdv::ListGlossaryCategoriesResponse, gcdv::GlossaryCategory> response = businessGlossaryServiceClient.ListGlossaryCategories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::GlossaryCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListGlossaryCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::GlossaryCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::GlossaryCategory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::GlossaryCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryCategoriesAsync</summary>
        public async Task ListGlossaryCategoriesResourceNamesAsync()
        {
            // Snippet: ListGlossaryCategoriesAsync(GlossaryName, string, int?, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GlossaryName parent = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListGlossaryCategoriesResponse, gcdv::GlossaryCategory> response = businessGlossaryServiceClient.ListGlossaryCategoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::GlossaryCategory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListGlossaryCategoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::GlossaryCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::GlossaryCategory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::GlossaryCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryTerm</summary>
        public void CreateGlossaryTermRequestObject()
        {
            // Snippet: CreateGlossaryTerm(CreateGlossaryTermRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateGlossaryTermRequest request = new gcdv::CreateGlossaryTermRequest
            {
                ParentAsGlossaryName = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                TermId = "",
                Term = new gcdv::GlossaryTerm(),
            };
            // Make the request
            gcdv::GlossaryTerm response = businessGlossaryServiceClient.CreateGlossaryTerm(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryTermAsync</summary>
        public async Task CreateGlossaryTermRequestObjectAsync()
        {
            // Snippet: CreateGlossaryTermAsync(CreateGlossaryTermRequest, CallSettings)
            // Additional: CreateGlossaryTermAsync(CreateGlossaryTermRequest, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateGlossaryTermRequest request = new gcdv::CreateGlossaryTermRequest
            {
                ParentAsGlossaryName = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                TermId = "",
                Term = new gcdv::GlossaryTerm(),
            };
            // Make the request
            gcdv::GlossaryTerm response = await businessGlossaryServiceClient.CreateGlossaryTermAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryTerm</summary>
        public void CreateGlossaryTerm()
        {
            // Snippet: CreateGlossaryTerm(string, GlossaryTerm, string, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            gcdv::GlossaryTerm term = new gcdv::GlossaryTerm();
            string termId = "";
            // Make the request
            gcdv::GlossaryTerm response = businessGlossaryServiceClient.CreateGlossaryTerm(parent, term, termId);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryTermAsync</summary>
        public async Task CreateGlossaryTermAsync()
        {
            // Snippet: CreateGlossaryTermAsync(string, GlossaryTerm, string, CallSettings)
            // Additional: CreateGlossaryTermAsync(string, GlossaryTerm, string, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            gcdv::GlossaryTerm term = new gcdv::GlossaryTerm();
            string termId = "";
            // Make the request
            gcdv::GlossaryTerm response = await businessGlossaryServiceClient.CreateGlossaryTermAsync(parent, term, termId);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryTerm</summary>
        public void CreateGlossaryTermResourceNames()
        {
            // Snippet: CreateGlossaryTerm(GlossaryName, GlossaryTerm, string, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GlossaryName parent = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            gcdv::GlossaryTerm term = new gcdv::GlossaryTerm();
            string termId = "";
            // Make the request
            gcdv::GlossaryTerm response = businessGlossaryServiceClient.CreateGlossaryTerm(parent, term, termId);
            // End snippet
        }

        /// <summary>Snippet for CreateGlossaryTermAsync</summary>
        public async Task CreateGlossaryTermResourceNamesAsync()
        {
            // Snippet: CreateGlossaryTermAsync(GlossaryName, GlossaryTerm, string, CallSettings)
            // Additional: CreateGlossaryTermAsync(GlossaryName, GlossaryTerm, string, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GlossaryName parent = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            gcdv::GlossaryTerm term = new gcdv::GlossaryTerm();
            string termId = "";
            // Make the request
            gcdv::GlossaryTerm response = await businessGlossaryServiceClient.CreateGlossaryTermAsync(parent, term, termId);
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryTerm</summary>
        public void UpdateGlossaryTermRequestObject()
        {
            // Snippet: UpdateGlossaryTerm(UpdateGlossaryTermRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateGlossaryTermRequest request = new gcdv::UpdateGlossaryTermRequest
            {
                Term = new gcdv::GlossaryTerm(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcdv::GlossaryTerm response = businessGlossaryServiceClient.UpdateGlossaryTerm(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryTermAsync</summary>
        public async Task UpdateGlossaryTermRequestObjectAsync()
        {
            // Snippet: UpdateGlossaryTermAsync(UpdateGlossaryTermRequest, CallSettings)
            // Additional: UpdateGlossaryTermAsync(UpdateGlossaryTermRequest, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateGlossaryTermRequest request = new gcdv::UpdateGlossaryTermRequest
            {
                Term = new gcdv::GlossaryTerm(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcdv::GlossaryTerm response = await businessGlossaryServiceClient.UpdateGlossaryTermAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryTerm</summary>
        public void UpdateGlossaryTerm()
        {
            // Snippet: UpdateGlossaryTerm(GlossaryTerm, FieldMask, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GlossaryTerm term = new gcdv::GlossaryTerm();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::GlossaryTerm response = businessGlossaryServiceClient.UpdateGlossaryTerm(term, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateGlossaryTermAsync</summary>
        public async Task UpdateGlossaryTermAsync()
        {
            // Snippet: UpdateGlossaryTermAsync(GlossaryTerm, FieldMask, CallSettings)
            // Additional: UpdateGlossaryTermAsync(GlossaryTerm, FieldMask, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GlossaryTerm term = new gcdv::GlossaryTerm();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcdv::GlossaryTerm response = await businessGlossaryServiceClient.UpdateGlossaryTermAsync(term, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryTerm</summary>
        public void DeleteGlossaryTermRequestObject()
        {
            // Snippet: DeleteGlossaryTerm(DeleteGlossaryTermRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteGlossaryTermRequest request = new gcdv::DeleteGlossaryTermRequest
            {
                GlossaryTermName = gcdv::GlossaryTermName.FromProjectLocationGlossaryGlossaryTerm("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_TERM]"),
            };
            // Make the request
            businessGlossaryServiceClient.DeleteGlossaryTerm(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryTermAsync</summary>
        public async Task DeleteGlossaryTermRequestObjectAsync()
        {
            // Snippet: DeleteGlossaryTermAsync(DeleteGlossaryTermRequest, CallSettings)
            // Additional: DeleteGlossaryTermAsync(DeleteGlossaryTermRequest, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteGlossaryTermRequest request = new gcdv::DeleteGlossaryTermRequest
            {
                GlossaryTermName = gcdv::GlossaryTermName.FromProjectLocationGlossaryGlossaryTerm("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_TERM]"),
            };
            // Make the request
            await businessGlossaryServiceClient.DeleteGlossaryTermAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryTerm</summary>
        public void DeleteGlossaryTerm()
        {
            // Snippet: DeleteGlossaryTerm(string, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]/terms/[GLOSSARY_TERM]";
            // Make the request
            businessGlossaryServiceClient.DeleteGlossaryTerm(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryTermAsync</summary>
        public async Task DeleteGlossaryTermAsync()
        {
            // Snippet: DeleteGlossaryTermAsync(string, CallSettings)
            // Additional: DeleteGlossaryTermAsync(string, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]/terms/[GLOSSARY_TERM]";
            // Make the request
            await businessGlossaryServiceClient.DeleteGlossaryTermAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryTerm</summary>
        public void DeleteGlossaryTermResourceNames()
        {
            // Snippet: DeleteGlossaryTerm(GlossaryTermName, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GlossaryTermName name = gcdv::GlossaryTermName.FromProjectLocationGlossaryGlossaryTerm("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_TERM]");
            // Make the request
            businessGlossaryServiceClient.DeleteGlossaryTerm(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGlossaryTermAsync</summary>
        public async Task DeleteGlossaryTermResourceNamesAsync()
        {
            // Snippet: DeleteGlossaryTermAsync(GlossaryTermName, CallSettings)
            // Additional: DeleteGlossaryTermAsync(GlossaryTermName, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GlossaryTermName name = gcdv::GlossaryTermName.FromProjectLocationGlossaryGlossaryTerm("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_TERM]");
            // Make the request
            await businessGlossaryServiceClient.DeleteGlossaryTermAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryTerm</summary>
        public void GetGlossaryTermRequestObject()
        {
            // Snippet: GetGlossaryTerm(GetGlossaryTermRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetGlossaryTermRequest request = new gcdv::GetGlossaryTermRequest
            {
                GlossaryTermName = gcdv::GlossaryTermName.FromProjectLocationGlossaryGlossaryTerm("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_TERM]"),
            };
            // Make the request
            gcdv::GlossaryTerm response = businessGlossaryServiceClient.GetGlossaryTerm(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryTermAsync</summary>
        public async Task GetGlossaryTermRequestObjectAsync()
        {
            // Snippet: GetGlossaryTermAsync(GetGlossaryTermRequest, CallSettings)
            // Additional: GetGlossaryTermAsync(GetGlossaryTermRequest, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetGlossaryTermRequest request = new gcdv::GetGlossaryTermRequest
            {
                GlossaryTermName = gcdv::GlossaryTermName.FromProjectLocationGlossaryGlossaryTerm("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_TERM]"),
            };
            // Make the request
            gcdv::GlossaryTerm response = await businessGlossaryServiceClient.GetGlossaryTermAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryTerm</summary>
        public void GetGlossaryTerm()
        {
            // Snippet: GetGlossaryTerm(string, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]/terms/[GLOSSARY_TERM]";
            // Make the request
            gcdv::GlossaryTerm response = businessGlossaryServiceClient.GetGlossaryTerm(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryTermAsync</summary>
        public async Task GetGlossaryTermAsync()
        {
            // Snippet: GetGlossaryTermAsync(string, CallSettings)
            // Additional: GetGlossaryTermAsync(string, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]/terms/[GLOSSARY_TERM]";
            // Make the request
            gcdv::GlossaryTerm response = await businessGlossaryServiceClient.GetGlossaryTermAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryTerm</summary>
        public void GetGlossaryTermResourceNames()
        {
            // Snippet: GetGlossaryTerm(GlossaryTermName, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GlossaryTermName name = gcdv::GlossaryTermName.FromProjectLocationGlossaryGlossaryTerm("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_TERM]");
            // Make the request
            gcdv::GlossaryTerm response = businessGlossaryServiceClient.GetGlossaryTerm(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlossaryTermAsync</summary>
        public async Task GetGlossaryTermResourceNamesAsync()
        {
            // Snippet: GetGlossaryTermAsync(GlossaryTermName, CallSettings)
            // Additional: GetGlossaryTermAsync(GlossaryTermName, CancellationToken)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GlossaryTermName name = gcdv::GlossaryTermName.FromProjectLocationGlossaryGlossaryTerm("[PROJECT]", "[LOCATION]", "[GLOSSARY]", "[GLOSSARY_TERM]");
            // Make the request
            gcdv::GlossaryTerm response = await businessGlossaryServiceClient.GetGlossaryTermAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryTerms</summary>
        public void ListGlossaryTermsRequestObject()
        {
            // Snippet: ListGlossaryTerms(ListGlossaryTermsRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListGlossaryTermsRequest request = new gcdv::ListGlossaryTermsRequest
            {
                ParentAsGlossaryName = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListGlossaryTermsResponse, gcdv::GlossaryTerm> response = businessGlossaryServiceClient.ListGlossaryTerms(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::GlossaryTerm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListGlossaryTermsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::GlossaryTerm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::GlossaryTerm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::GlossaryTerm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryTermsAsync</summary>
        public async Task ListGlossaryTermsRequestObjectAsync()
        {
            // Snippet: ListGlossaryTermsAsync(ListGlossaryTermsRequest, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListGlossaryTermsRequest request = new gcdv::ListGlossaryTermsRequest
            {
                ParentAsGlossaryName = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListGlossaryTermsResponse, gcdv::GlossaryTerm> response = businessGlossaryServiceClient.ListGlossaryTermsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::GlossaryTerm item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListGlossaryTermsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::GlossaryTerm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::GlossaryTerm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::GlossaryTerm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryTerms</summary>
        public void ListGlossaryTerms()
        {
            // Snippet: ListGlossaryTerms(string, string, int?, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            PagedEnumerable<gcdv::ListGlossaryTermsResponse, gcdv::GlossaryTerm> response = businessGlossaryServiceClient.ListGlossaryTerms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::GlossaryTerm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListGlossaryTermsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::GlossaryTerm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::GlossaryTerm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::GlossaryTerm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryTermsAsync</summary>
        public async Task ListGlossaryTermsAsync()
        {
            // Snippet: ListGlossaryTermsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/glossaries/[GLOSSARY]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListGlossaryTermsResponse, gcdv::GlossaryTerm> response = businessGlossaryServiceClient.ListGlossaryTermsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::GlossaryTerm item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListGlossaryTermsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::GlossaryTerm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::GlossaryTerm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::GlossaryTerm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryTerms</summary>
        public void ListGlossaryTermsResourceNames()
        {
            // Snippet: ListGlossaryTerms(GlossaryName, string, int?, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = gcdv::BusinessGlossaryServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GlossaryName parent = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            PagedEnumerable<gcdv::ListGlossaryTermsResponse, gcdv::GlossaryTerm> response = businessGlossaryServiceClient.ListGlossaryTerms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::GlossaryTerm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListGlossaryTermsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::GlossaryTerm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::GlossaryTerm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::GlossaryTerm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGlossaryTermsAsync</summary>
        public async Task ListGlossaryTermsResourceNamesAsync()
        {
            // Snippet: ListGlossaryTermsAsync(GlossaryName, string, int?, CallSettings)
            // Create client
            gcdv::BusinessGlossaryServiceClient businessGlossaryServiceClient = await gcdv::BusinessGlossaryServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GlossaryName parent = gcdv::GlossaryName.FromProjectLocationGlossary("[PROJECT]", "[LOCATION]", "[GLOSSARY]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListGlossaryTermsResponse, gcdv::GlossaryTerm> response = businessGlossaryServiceClient.ListGlossaryTermsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::GlossaryTerm item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListGlossaryTermsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::GlossaryTerm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::GlossaryTerm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::GlossaryTerm item in singlePage)
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
