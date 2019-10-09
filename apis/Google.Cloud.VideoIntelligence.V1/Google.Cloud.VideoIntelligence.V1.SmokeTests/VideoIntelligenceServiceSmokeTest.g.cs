// Copyright 2019 Google LLC
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

namespace Google.Cloud.VideoIntelligence.V1.SmokeTests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;

    public class VideoIntelligenceServiceSmokeTest
    {
        public static int Main(string[] args)
        {
            // Create client
            VideoIntelligenceServiceClient client = VideoIntelligenceServiceClient.Create();

            // Initialize request argument(s)
            string inputUri = "gs://cloud-samples-data/video/cat.mp4";
            IEnumerable<Feature> features = new[]
            {
                Feature.LabelDetection,
            };

            // Call API method
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> operationResponse = client.AnnotateVideo(inputUri, features);
            // Poll the operation until it's complete.
            // This returns a new operation containing the result (or error).
            operationResponse = operationResponse.PollUntilCompleted();
            // Show the result
            Console.WriteLine(operationResponse.Result);

            // Success
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
