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
using System.Linq;
using System.Reflection;
using Xunit;

namespace Google.Cloud.Translation.V2.IntegrationTests
{
    public class TranslationClientTest
    {
        private static readonly string LargeText = LoadResource("independence.txt");
        private const int ApiLimit = 30 * 1024;
        private static readonly string VeryLargeText = string.Join("\n", Enumerable.Repeat(LargeText, ApiLimit / LargeText.Length));

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
            Assert.Contains("au cours d", translation.TranslatedText);
            Assert.Equal(LargeText, translation.OriginalText);
            Assert.Equal(LanguageCodes.French, translation.TargetLanguage);
            Assert.Equal(LanguageCodes.English, translation.DetectedSourceLanguage);
            Assert.Null(translation.SpecifiedSourceLanguage);
        }

        [Fact]
        public void Translate_VeryLargeText()
        {
            var client = TranslationClient.Create();
            var translation = client.TranslateText(VeryLargeText, LanguageCodes.French);
            Assert.Contains("au cours d", translation.TranslatedText);
            Assert.Equal(VeryLargeText, translation.OriginalText);
            Assert.Equal(LanguageCodes.French, translation.TargetLanguage);
            Assert.Equal(LanguageCodes.English, translation.DetectedSourceLanguage);
            Assert.Null(translation.SpecifiedSourceLanguage);
        }

        [Fact]
        public void Translate_SpecifyLanguage()
        {
            var client = TranslationClient.Create();
            var translation = client.TranslateText(LargeText, LanguageCodes.French, LanguageCodes.English);
            Assert.Equal(LargeText, translation.OriginalText);
            Assert.Equal(LanguageCodes.French, translation.TargetLanguage);
            Assert.Null(translation.DetectedSourceLanguage);
            Assert.Equal(LanguageCodes.English, translation.SpecifiedSourceLanguage);
        }

        [Fact]
        public void Translate_ModelInResult()
        {
            var client = TranslationClient.Create();
            var model = TranslationModel.NeuralMachineTranslation;
            var translation = client.TranslateText("Please translate this", LanguageCodes.French, model: model);
            Assert.Equal(model, translation.Model);
        }

        [Fact]
        public void InvalidModel()
        {
            var client = TranslationClient.Create();
            Assert.Throws<ArgumentException>(() => client.TranslateText("Please translate this", LanguageCodes.French, model: (TranslationModel) 12345));
        }

        [Fact]
        public void ApplicationName()
        {
            TranslationClientImpl.ApplicationName = "TestApplication";
            var client = TranslationClient.Create();
            Assert.Equal("TestApplication", client.Service.ApplicationName);
        }

        internal static string LoadResource(string name)
        {
            var type = typeof(TranslationClientTest);
            using (var stream = type.GetTypeInfo().Assembly.GetManifestResourceStream($"{type.Namespace}.{name}"))
            {
                return new StreamReader(stream).ReadToEnd();
            }
        }
    }
}
