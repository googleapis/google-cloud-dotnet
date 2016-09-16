// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Longrunning;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Speech.V1Beta1.RecognitionConfig.Types;

namespace Google.Cloud.Speech.V1Beta1.Snippets
{
    [Collection(nameof(SpeechFixture))]
    public class SpeechRecognizerSnippets
    {
        private readonly SpeechFixture _fixture;

        public SpeechRecognizerSnippets(SpeechFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Recognize()
        {
            var audio = _fixture.LoadResourceAudio("speech.raw");
            // Snippet: Recognize
            SpeechRecognizer recognizer = SpeechRecognizer.Create();
            RecognitionConfig config = new RecognitionConfig { Encoding = AudioEncoding.Linear16, SampleRate = 16000 };
            SyncRecognizeResponse response = recognizer.Recognize(config, audio);
            Console.WriteLine(response);
            // End snippet

            Assert.Equal(
                "this is a test file for the google cloud speech api",
                response.Results[0].Alternatives[0].Transcript,
                true);
        }

        [Fact]
        public void BeginRecognize()
        {
            var uri = _fixture.UploadAudioToStorage("speech.raw");
            // Snippet: BeginRecognize
            RecognitionAudio audio = RecognitionAudio.FromStorageUri(uri);
            SpeechRecognizer recognizer = SpeechRecognizer.Create();
            RecognitionConfig config = new RecognitionConfig { Encoding = AudioEncoding.Linear16, SampleRate = 16000 };
            Operation<AsyncRecognizeResponse> operation = recognizer.BeginRecognize(config, audio);
            Console.WriteLine($"Complete immediately? {operation.IsCompleted}");
            var response = operation.PollUntilCompleted().Result;
            Console.WriteLine(response);
            // End snippet

            Assert.Equal(
                "this is a test file for the google cloud speech api",
                response.Results[0].Alternatives[0].Transcript,
                true);
        }

        [Fact]
        public void PollRecognize()
        {
            var uri = _fixture.UploadAudioToStorage("speech.raw");
            // Snippet: PollRecognize
            RecognitionAudio audio = RecognitionAudio.FromStorageUri(uri);
            SpeechRecognizer recognizer = SpeechRecognizer.Create();
            RecognitionConfig config = new RecognitionConfig { Encoding = AudioEncoding.Linear16, SampleRate = 16000 };
            Operation<AsyncRecognizeResponse> operation = recognizer.BeginRecognize(config, audio);
            string operationName = operation.Name;
            Console.WriteLine($"Operation name: {operationName}");

            // Use case: you now persist the operation name (e.g. to a database) so you can later check it:
            var laterOperation = recognizer.PollRecognize(operationName);
            // On a status dashboard you may just show the current state - or maybe you want to wait
            // at this point.
            var response = laterOperation.PollUntilCompleted().Result;
            Console.WriteLine(response);
            // End snippet

            Assert.Equal(
                "this is a test file for the google cloud speech api",
                response.Results[0].Alternatives[0].Transcript,
                true);
        }

        [Fact]
        public async Task Streaming()
        {
            var audioByteString = _fixture.LoadResourceAudio("speech.raw").Content;
            // Snippet: BeginStreamingRecognize
            SpeechRecognizer recognizer = SpeechRecognizer.Create();
            RecognitionConfig config = new RecognitionConfig { Encoding = AudioEncoding.Linear16, SampleRate = 16000 };
            StreamingRecognitionConfig streamingConfig = new StreamingRecognitionConfig { Config = config };
            RecognizerStream stream = await recognizer.BeginStreamingRecognize(streamingConfig);
            Task displayResponsesTask = Task.Run(async () =>
            {
                Console.WriteLine("Start of streaming output");
                var responseStream = stream.ResponseStream;
                while (await responseStream.MoveNext())
                {
                    Console.WriteLine($"Streaming response: {responseStream.Current}");
                }
                Console.WriteLine("End of streaming output");
            });
            // This example just writes a single piece of data. Real code is more likely to
            // take data from a system event such as microphone activity. Note that only one pending
            // write can be "in-flight" at a time. (We may provide queuing functionality to simplify this...)
            await stream.RequestStream.WriteAsync(audioByteString);
            // When you're done, call CompleteAsync...
            await stream.RequestStream.CompleteAsync();
            await displayResponsesTask;
            // End snippet
        }
    }
}
