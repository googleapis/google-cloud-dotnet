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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.TextToSpeech.V1Beta1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTextToSpeechClientSnippets
    {
        /// <summary>Snippet for ListVoices</summary>
        public void ListVoicesRequestObject()
        {
            // Snippet: ListVoices(ListVoicesRequest, CallSettings)
            // Create client
            TextToSpeechClient textToSpeechClient = TextToSpeechClient.Create();
            // Initialize request argument(s)
            ListVoicesRequest request = new ListVoicesRequest { LanguageCode = "", };
            // Make the request
            ListVoicesResponse response = textToSpeechClient.ListVoices(request);
            // End snippet
        }

        /// <summary>Snippet for ListVoicesAsync</summary>
        public async Task ListVoicesRequestObjectAsync()
        {
            // Snippet: ListVoicesAsync(ListVoicesRequest, CallSettings)
            // Additional: ListVoicesAsync(ListVoicesRequest, CancellationToken)
            // Create client
            TextToSpeechClient textToSpeechClient = await TextToSpeechClient.CreateAsync();
            // Initialize request argument(s)
            ListVoicesRequest request = new ListVoicesRequest { LanguageCode = "", };
            // Make the request
            ListVoicesResponse response = await textToSpeechClient.ListVoicesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListVoices</summary>
        public void ListVoices()
        {
            // Snippet: ListVoices(string, CallSettings)
            // Create client
            TextToSpeechClient textToSpeechClient = TextToSpeechClient.Create();
            // Initialize request argument(s)
            string languageCode = "";
            // Make the request
            ListVoicesResponse response = textToSpeechClient.ListVoices(languageCode);
            // End snippet
        }

        /// <summary>Snippet for ListVoicesAsync</summary>
        public async Task ListVoicesAsync()
        {
            // Snippet: ListVoicesAsync(string, CallSettings)
            // Additional: ListVoicesAsync(string, CancellationToken)
            // Create client
            TextToSpeechClient textToSpeechClient = await TextToSpeechClient.CreateAsync();
            // Initialize request argument(s)
            string languageCode = "";
            // Make the request
            ListVoicesResponse response = await textToSpeechClient.ListVoicesAsync(languageCode);
            // End snippet
        }

        /// <summary>Snippet for SynthesizeSpeech</summary>
        public void SynthesizeSpeechRequestObject()
        {
            // Snippet: SynthesizeSpeech(SynthesizeSpeechRequest, CallSettings)
            // Create client
            TextToSpeechClient textToSpeechClient = TextToSpeechClient.Create();
            // Initialize request argument(s)
            SynthesizeSpeechRequest request = new SynthesizeSpeechRequest
            {
                Input = new SynthesisInput(),
                Voice = new VoiceSelectionParams(),
                AudioConfig = new AudioConfig(),
                EnableTimePointing =
                {
                    SynthesizeSpeechRequest.Types.TimepointType.Unspecified,
                },
                AdvancedVoiceOptions = new AdvancedVoiceOptions(),
            };
            // Make the request
            SynthesizeSpeechResponse response = textToSpeechClient.SynthesizeSpeech(request);
            // End snippet
        }

        /// <summary>Snippet for SynthesizeSpeechAsync</summary>
        public async Task SynthesizeSpeechRequestObjectAsync()
        {
            // Snippet: SynthesizeSpeechAsync(SynthesizeSpeechRequest, CallSettings)
            // Additional: SynthesizeSpeechAsync(SynthesizeSpeechRequest, CancellationToken)
            // Create client
            TextToSpeechClient textToSpeechClient = await TextToSpeechClient.CreateAsync();
            // Initialize request argument(s)
            SynthesizeSpeechRequest request = new SynthesizeSpeechRequest
            {
                Input = new SynthesisInput(),
                Voice = new VoiceSelectionParams(),
                AudioConfig = new AudioConfig(),
                EnableTimePointing =
                {
                    SynthesizeSpeechRequest.Types.TimepointType.Unspecified,
                },
                AdvancedVoiceOptions = new AdvancedVoiceOptions(),
            };
            // Make the request
            SynthesizeSpeechResponse response = await textToSpeechClient.SynthesizeSpeechAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SynthesizeSpeech</summary>
        public void SynthesizeSpeech()
        {
            // Snippet: SynthesizeSpeech(SynthesisInput, VoiceSelectionParams, AudioConfig, CallSettings)
            // Create client
            TextToSpeechClient textToSpeechClient = TextToSpeechClient.Create();
            // Initialize request argument(s)
            SynthesisInput input = new SynthesisInput();
            VoiceSelectionParams voice = new VoiceSelectionParams();
            AudioConfig audioConfig = new AudioConfig();
            // Make the request
            SynthesizeSpeechResponse response = textToSpeechClient.SynthesizeSpeech(input, voice, audioConfig);
            // End snippet
        }

        /// <summary>Snippet for SynthesizeSpeechAsync</summary>
        public async Task SynthesizeSpeechAsync()
        {
            // Snippet: SynthesizeSpeechAsync(SynthesisInput, VoiceSelectionParams, AudioConfig, CallSettings)
            // Additional: SynthesizeSpeechAsync(SynthesisInput, VoiceSelectionParams, AudioConfig, CancellationToken)
            // Create client
            TextToSpeechClient textToSpeechClient = await TextToSpeechClient.CreateAsync();
            // Initialize request argument(s)
            SynthesisInput input = new SynthesisInput();
            VoiceSelectionParams voice = new VoiceSelectionParams();
            AudioConfig audioConfig = new AudioConfig();
            // Make the request
            SynthesizeSpeechResponse response = await textToSpeechClient.SynthesizeSpeechAsync(input, voice, audioConfig);
            // End snippet
        }

        /// <summary>Snippet for StreamingSynthesize</summary>
        public async Task StreamingSynthesize()
        {
            // Snippet: StreamingSynthesize(CallSettings, BidirectionalStreamingSettings)
            // Create client
            TextToSpeechClient textToSpeechClient = TextToSpeechClient.Create();
            // Initialize streaming call, retrieving the stream object
            using TextToSpeechClient.StreamingSynthesizeStream response = textToSpeechClient.StreamingSynthesize();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamingSynthesizeResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamingSynthesizeResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamingSynthesizeRequest request = new StreamingSynthesizeRequest
                {
                    StreamingConfig = new StreamingSynthesizeConfig(),
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }
    }
}
