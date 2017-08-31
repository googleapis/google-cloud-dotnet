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
using Xunit;

namespace Google.Cloud.Translation.V2.Tests
{
    public class TranslationResultTest
    {
        [Fact]
        public void Construction()
        {
            var result = new TranslationResult("original", "translated", "detectedLang", "specifiedLang", "targetLang", TranslationModel.NeuralMachineTranslation);
            Assert.Equal("original", result.OriginalText);
            Assert.Equal("translated", result.TranslatedText);
            Assert.Equal("detectedLang", result.DetectedSourceLanguage);
            Assert.Equal("specifiedLang", result.SpecifiedSourceLanguage);
            Assert.Equal("targetLang", result.TargetLanguage);
            Assert.Equal(TranslationModel.NeuralMachineTranslation, result.Model);
            Assert.Equal("nmt", result.ModelName);
        }

        [Fact]
        public void InvalidModel()
        {
            // Not an ideal exception, but it's good enough for this unusual situation.
            Assert.Throws<InvalidOperationException>(() => new TranslationResult("", "", "", "", "", (TranslationModel) 123));
        }
    }
}
