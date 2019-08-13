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

using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using System;
using Xunit;

namespace Google.Cloud.Translate.V3.Snippets
{
    public class TranslationServiceClientSnippets
    {
        [Fact]
        public void GettingStarted()
        {
            string projectId = TestEnvironment.GetTestProjectId();

            // Sample: GettingStarted
            TranslationServiceClient client = TranslationServiceClient.Create();
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents = { "It is raining." },
                TargetLanguageCode = "fr-FR",
                Parent = new ProjectName(projectId).ToString()
            };
            TranslateTextResponse response = client.TranslateText(request);
            // response.Translations will have one entry, because request.Contents has one entry.
            Translation translation = response.Translations[0];
            Console.WriteLine($"Detected language: {translation.DetectedLanguageCode}");
            Console.WriteLine($"Translated text: {translation.TranslatedText}");
            // End sample

            Assert.Equal(1, response.Translations.Count);
            Assert.Equal("en", translation.DetectedLanguageCode);
            Assert.Equal("Il pleut.", translation.TranslatedText);
        }
    }
}
