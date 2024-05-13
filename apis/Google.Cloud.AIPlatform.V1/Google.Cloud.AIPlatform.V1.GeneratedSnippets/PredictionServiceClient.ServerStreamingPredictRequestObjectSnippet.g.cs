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
    // [START aiplatform_v1_generated_PredictionService_ServerStreamingPredict_sync]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.AIPlatform.V1;
    using Google.Protobuf;
    using System.Threading.Tasks;

    public sealed partial class GeneratedPredictionServiceClientSnippets
    {
        /// <summary>Snippet for ServerStreamingPredict</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ServerStreamingPredictRequestObject()
        {
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            StreamingPredictRequest request = new StreamingPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Inputs =
                {
                    new Tensor
                    {
                        Dtype = Tensor.Types.DataType.Unspecified,
                        Shape = { 0L, },
                        BoolVal = { false, },
                        FloatVal = { 0F, },
                        DoubleVal = { 0, },
                        IntVal = { 0, },
                        Int64Val = { 0L, },
                        UintVal = { 0U, },
                        Uint64Val = { 0UL, },
                        ListVal = { new Tensor { }, },
                        StructVal = { { "", new Tensor { } }, },
                        TensorVal = ByteString.Empty,
                        StringVal = { "", },
                        BytesVal = { ByteString.Empty, },
                    },
                },
                Parameters = new Tensor
                {
                    Dtype = Tensor.Types.DataType.Unspecified,
                    Shape = { 0L, },
                    BoolVal = { false, },
                    FloatVal = { 0F, },
                    DoubleVal = { 0, },
                    IntVal = { 0, },
                    Int64Val = { 0L, },
                    UintVal = { 0U, },
                    Uint64Val = { 0UL, },
                    ListVal = { new Tensor { }, },
                    StructVal = { { "", new Tensor { } }, },
                    TensorVal = ByteString.Empty,
                    StringVal = { "", },
                    BytesVal = { ByteString.Empty, },
                },
            };
            // Make the request, returning a streaming response
            using PredictionServiceClient.ServerStreamingPredictStream response = predictionServiceClient.ServerStreamingPredict(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<StreamingPredictResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                StreamingPredictResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
    // [END aiplatform_v1_generated_PredictionService_ServerStreamingPredict_sync]
}
