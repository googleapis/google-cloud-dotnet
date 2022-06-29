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

using Google.Cloud.ClientTesting;
using Google.LongRunning;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.VideoIntelligence.V1.Snippets
{
    [SnippetOutputCollector]
    public class VideoIntelligenceServiceClientSnippets
    {
        [Fact]
        public void AnnotateVideo()
        {
            // Sample: AnnotateVideo
            // Additional: AnnotateVideo(string, IEnumerable<Feature>, CallSettings)
            VideoIntelligenceServiceClient client = VideoIntelligenceServiceClient.Create();
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> operation = client.AnnotateVideo(
                "gs://cloud-samples-data/video/gbikes_dinosaur.mp4",
                new[] { Feature.LabelDetection });
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> resultOperation = operation.PollUntilCompleted();

            VideoAnnotationResults result = resultOperation.Result.AnnotationResults[0];
            foreach (LabelAnnotation label in result.ShotLabelAnnotations)
            {
                Console.WriteLine($"Label entity: {label.Entity.Description}");
                Console.WriteLine("Frames:");
                foreach (LabelSegment segment in label.Segments)
                {
                    Console.WriteLine($"  {segment.Segment.StartTimeOffset}-{segment.Segment.EndTimeOffset}: {segment.Confidence}");
                }
            }
            // End sample

            Assert.Contains(result.ShotLabelAnnotations, lab => lab.Entity.Description == "dinosaur");
        }

        [Fact]
        public void SpeechTranscription()
        {
            // Sample: SpeechTranscription
            VideoIntelligenceServiceClient client = VideoIntelligenceServiceClient.Create();
            AnnotateVideoRequest request = new AnnotateVideoRequest
            {
                InputUri = "gs://cloud-samples-data/video/googlework_short.mp4",
                Features = { Feature.SpeechTranscription },
                VideoContext = new VideoContext
                {
                    SpeechTranscriptionConfig = new SpeechTranscriptionConfig
                    {
                        LanguageCode = "en-US",
                        EnableAutomaticPunctuation = true
                    }
                }
            };
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> operation = client.AnnotateVideo(request);
            Operation<AnnotateVideoResponse, AnnotateVideoProgress> resultOperation = operation.PollUntilCompleted();

            VideoAnnotationResults result = resultOperation.Result.AnnotationResults[0];
            foreach (SpeechTranscription transcription in result.SpeechTranscriptions)
            {
                Console.WriteLine($"Language code: {transcription.LanguageCode}");
                Console.WriteLine("Alternatives:");
                foreach (SpeechRecognitionAlternative alternative in transcription.Alternatives)
                {
                    Console.WriteLine($"({alternative.Confidence}) {alternative.Transcript}");
                }
            }
            // End sample

            IEnumerable<string> allTranscripts = result.SpeechTranscriptions
                .SelectMany(st => st.Alternatives)
                .Select(alt => alt.Transcript);
            
            Assert.Contains(allTranscripts, t => t.Contains("shows the will of Google to invest for long-term in France"));
        }
    }
}
