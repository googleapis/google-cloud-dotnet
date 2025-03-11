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
    // [START dataplex_v1_generated_DataTaxonomyService_UpdateDataAttributeBinding_async]
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    public sealed partial class GeneratedDataTaxonomyServiceClientSnippets
    {
        /// <summary>Snippet for UpdateDataAttributeBindingAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        [ObsoleteAttribute]
        public async Task UpdateDataAttributeBindingRequestObjectAsync()
        {
            // Create client
            gcdv::DataTaxonomyServiceClient dataTaxonomyServiceClient = await gcdv::DataTaxonomyServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateDataAttributeBindingRequest request = new gcdv::UpdateDataAttributeBindingRequest
            {
                UpdateMask = new FieldMask(),
#pragma warning disable CS0612
                DataAttributeBinding = new gcdv::DataAttributeBinding(),
#pragma warning restore CS0612
                ValidateOnly = false,
            };
            // Make the request
#pragma warning disable CS0612
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> response = await dataTaxonomyServiceClient.UpdateDataAttributeBindingAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            gcdv::DataAttributeBinding result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<gcdv::DataAttributeBinding, gcdv::OperationMetadata> retrievedResponse = await dataTaxonomyServiceClient.PollOnceUpdateDataAttributeBindingAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                gcdv::DataAttributeBinding retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
            }
        }
    }
    // [END dataplex_v1_generated_DataTaxonomyService_UpdateDataAttributeBinding_async]
}
