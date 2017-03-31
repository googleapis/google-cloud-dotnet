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

using System;
using System.Reflection;
using Xunit;
using static Google.Cloud.Speech.V1.RecognitionConfig.Types;

namespace Google.Cloud.Speech.V1.Snippets
{
    public class SpeechClientSnippets
    {
        [Fact]
        public void Recognize()
        {
            var audio = LoadResourceAudio("speech.raw");
            // Sample: Recognize
            // Additional: Recognize(*,*,*)
            SpeechClient client = SpeechClient.Create();
            RecognitionConfig config = new RecognitionConfig
            {
                Encoding = AudioEncoding.Linear16,
                SampleRateHertz = 16000,
                LanguageCode = LanguageCodes.English.UnitedStates
            };
            RecognizeResponse response = client.Recognize(config, audio);
            Console.WriteLine(response);
            // End sample

            Assert.Equal(
                "this is a test file for the google cloud speech api",
                response.Results[0].Alternatives[0].Transcript,
                true);
        }

        private static RecognitionAudio LoadResourceAudio(string name)
        {
            var type = typeof(SpeechClientSnippets);
            using (var stream = type.GetTypeInfo().Assembly.GetManifestResourceStream($"{type.Namespace}.{name}"))
            {
                return RecognitionAudio.FromStream(stream);
            }
        }
    }
}
