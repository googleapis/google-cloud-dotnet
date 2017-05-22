// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.VideoIntelligence.V1Beta1;
using Google.LongRunning;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.VideoIntelligence.V1Beta1.Snippets
{
    public class GeneratedVideoIntelligenceServiceClientSnippets
    {
        public async Task AnnotateVideoAsync()
        {
            // Snippet: AnnotateVideoAsync(string,IEnumerable<Feature>,VideoContext,string,string,CallSettings)
            // Additional: AnnotateVideoAsync(string,IEnumerable<Feature>,VideoContext,string,string,CancellationToken)
            // Create client
            VideoIntelligenceServiceClient videoIntelligenceServiceClient = await VideoIntelligenceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string inputUri = "";
            IEnumerable<Feature> features = new List<Feature>();
            VideoContext videoContext = new VideoContext();
            string outputUri = "";
            string locationId = "";
            // Make the request
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> response =
                await videoIntelligenceServiceClient.AnnotateVideoAsync(inputUri, features, videoContext, outputUri, locationId);

            // Poll until the returned long-running operation is complete
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotateVideoResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> retrievedResponse =
                await videoIntelligenceServiceClient.PollOnceAnnotateVideoAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotateVideoResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public void AnnotateVideo()
        {
            // Snippet: AnnotateVideo(string,IEnumerable<Feature>,VideoContext,string,string,CallSettings)
            // Create client
            VideoIntelligenceServiceClient videoIntelligenceServiceClient = VideoIntelligenceServiceClient.Create();
            // Initialize request argument(s)
            string inputUri = "";
            IEnumerable<Feature> features = new List<Feature>();
            VideoContext videoContext = new VideoContext();
            string outputUri = "";
            string locationId = "";
            // Make the request
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> response =
                videoIntelligenceServiceClient.AnnotateVideo(inputUri, features, videoContext, outputUri, locationId);

            // Poll until the returned long-running operation is complete
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotateVideoResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> retrievedResponse =
                videoIntelligenceServiceClient.PollOnceAnnotateVideo(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotateVideoResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public async Task AnnotateVideoAsync_RequestObject()
        {
            // Snippet: AnnotateVideoAsync(AnnotateVideoRequest,CallSettings)
            // Create client
            VideoIntelligenceServiceClient videoIntelligenceServiceClient = await VideoIntelligenceServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnnotateVideoRequest request = new AnnotateVideoRequest
            {
                InputUri = "",
                Features = { },
            };
            // Make the request
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> response =
                await videoIntelligenceServiceClient.AnnotateVideoAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnnotateVideoResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> retrievedResponse =
                await videoIntelligenceServiceClient.PollOnceAnnotateVideoAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotateVideoResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        public void AnnotateVideo_RequestObject()
        {
            // Snippet: AnnotateVideo(AnnotateVideoRequest,CallSettings)
            // Create client
            VideoIntelligenceServiceClient videoIntelligenceServiceClient = VideoIntelligenceServiceClient.Create();
            // Initialize request argument(s)
            AnnotateVideoRequest request = new AnnotateVideoRequest
            {
                InputUri = "",
                Features = { },
            };
            // Make the request
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> response =
                videoIntelligenceServiceClient.AnnotateVideo(request);

            // Poll until the returned long-running operation is complete
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            AnnotateVideoResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> retrievedResponse =
                videoIntelligenceServiceClient.PollOnceAnnotateVideo(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnnotateVideoResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

    }
}
