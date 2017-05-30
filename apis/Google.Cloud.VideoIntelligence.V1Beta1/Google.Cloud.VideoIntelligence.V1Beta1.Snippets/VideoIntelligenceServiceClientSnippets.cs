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

using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.VideoIntelligence.V1Beta1.Snippets
{
    public class VideoIntelligenceServiceClientSnippets
    {
        [Fact]
        public void AnnotateVideo()
        {
            // Sample: AnnotateVideo
            // Additional: AnnotateVideo(string,IEnumerable<Feature>,VideoContext,string,string,CallSettings)
            var client = VideoIntelligenceServiceClient.Create();
            var request = new AnnotateVideoRequest {
                InputUri = "gs://cloudmleap/video/next/gbikes_dinosaur.mp4",
                Features = { Feature.LabelDetection }
            };
            var operation = client.AnnotateVideo(request);

            var resultOperation = operation.PollUntilCompleted();

            var result = resultOperation.Result.AnnotationResults[0];
            foreach (var label in result.LabelAnnotations)
            {
                Console.WriteLine($"Label: {label.Description}");
                Console.WriteLine("Locations:");
                foreach (var location in label.Locations)
                {
                    Console.WriteLine($"  {location.Segment.StartTimeOffset}-{location.Segment.EndTimeOffset}: {location.Confidence}");
                }
            }
            // End sample

            Assert.True(result.LabelAnnotations.Any(lab => lab.Description == "Dinosaur"));
        }
    }
}
