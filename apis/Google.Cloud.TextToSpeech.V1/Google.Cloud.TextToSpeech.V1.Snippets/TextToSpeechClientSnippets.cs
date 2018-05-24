// Copyright 2018 Google LLC
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

using Google.Cloud.ClientTesting;
using System;
using System.IO;
using Xunit;

namespace Google.Cloud.TextToSpeech.V1.Snippets
{
    [SnippetOutputCollector]
    public class TextToSpeechClientSnippets
    {
        [Fact]
        public void SimpleExample()
        {
            // Sample: SynthesizeSpeech
            // Additional: SynthesizeSpeech(SynthesisInput,VoiceSelectionParams,AudioConfig,CallSettings)
            TextToSpeechClient client = TextToSpeechClient.Create();
            // The input can be provided as text or SSML.
            SynthesisInput input = new SynthesisInput
            {
                Text = "This is a demonstration of the Google Cloud Text-to-Speech API"
            };
            // You can specify a particular voice, or ask the server to pick based
            // on specified criteria.
            VoiceSelectionParams voiceSelection = new VoiceSelectionParams
            {
                LanguageCode = "en-US",
                SsmlGender = SsmlVoiceGender.Female
            };
            // The audio configuration determines the output format and speaking rate.
            AudioConfig audioConfig = new AudioConfig
            {
                AudioEncoding = AudioEncoding.Mp3
            };
            SynthesizeSpeechResponse response = client.SynthesizeSpeech(input, voiceSelection, audioConfig);
            using (Stream output = File.Create("sample.mp3"))
            {
                // response.AudioContent is a ByteString. This can easily be converted into
                // a byte array or written to a stream.
                response.AudioContent.WriteTo(output);
            }
            // End sample
        }

        [Fact]
        public void ListVoices()
        {
            // Snippet: ListVoices(string,CallSettings)
            TextToSpeechClient client = TextToSpeechClient.Create();
            ListVoicesResponse response = client.ListVoices("en");
            foreach (Voice voice in response.Voices)
            {
                Console.WriteLine($"{voice.Name} ({voice.SsmlGender}); Language codes: {string.Join(", ", voice.LanguageCodes)}");
            }
            // End snippet
        }
    }
}
