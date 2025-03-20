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

namespace GoogleCSharpSnippets
{
    // [START aiplatform_v1beta1_generated_TensorboardService_ReadTensorboardBlobData_sync_flattened]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.AIPlatform.V1Beta1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedTensorboardServiceClientSnippets
    {
        /// <summary>Snippet for ReadTensorboardBlobData</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ReadTensorboardBlobData()
        {
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string timeSeries = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]/timeSeries/[TIME_SERIES]";
            // Make the request, returning a streaming response
            using TensorboardServiceClient.ReadTensorboardBlobDataStream response = tensorboardServiceClient.ReadTensorboardBlobData(timeSeries);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadTensorboardBlobDataResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadTensorboardBlobDataResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
    // [END aiplatform_v1beta1_generated_TensorboardService_ReadTensorboardBlobData_sync_flattened]
}
