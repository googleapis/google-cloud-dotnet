// Copyright 2017 Google Inc. All Rights Reserved.
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
using System.IO;
using System.Reflection;
using Xunit;

namespace Google.Cloud.Translation.V2.IntegrationTests
{
    public class TranslationClientTest
    {
        private static readonly string LargeText = LoadResource("independence.txt");

        [Fact]
        public void DetectLanguage_LargeText()
        {
            var client = TranslationClient.Create();
            var detection = client.DetectLanguage(LargeText);
            Assert.Equal("en", detection.Language);
        }
        
        [Fact]
        public void Translate_LargeText()
        {
            var client = TranslationClient.Create();
            var translation = client.TranslateText(LargeText, LanguageCodes.French);
            Assert.StartsWith("Lorsque, au cours des", translation.TranslatedText);
        }

        private static string LoadResource(string name)
        {
            var type = typeof(TranslationClientTest);
            using (var stream = type.GetTypeInfo().Assembly.GetManifestResourceStream($"{type.Namespace}.{name}"))
            {
                return new StreamReader(stream).ReadToEnd();
            }
        }
    }
}
