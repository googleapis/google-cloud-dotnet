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

using Google.Apis.Translate.v2.Data;

namespace Google.Cloud.Translation.V2
{
    /// <summary>
    /// A result of detecting the language of a piece of text
    /// via <see cref="TranslationClient.DetectLanguage(string)"/> or
    /// <see cref="TranslationClient.DetectLanguageAsync(string, System.Threading.CancellationToken)"/>,
    /// or the multiple-item equivalents.
    /// </summary>
    public sealed class Detection
    {
        /// <summary>
        /// The text that was used for the input of language detection.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// The language code for the detected language.
        /// </summary>
        public string Language { get; }

        /// <summary>
        /// The confidence level (between 0 and 1) of the detection.
        /// </summary>
        public float Confidence { get; }

        /// <summary>
        /// The reliability of the detection.
        /// </summary>
        public bool IsReliable { get; }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="text">The text that was used for the input of language detection.</param>
        /// <param name="language">The detected language code.</param>
        /// <param name="confidence">The confidence of the detection.</param>
        /// <param name="isReliable">The reliability of the detection.</param>
        public Detection(string text, string language, float confidence, bool isReliable)
        {
            Text = text;
            Language = language;
            Confidence = confidence;
            IsReliable = isReliable;
        }

        internal Detection(string text, DetectionsResourceItems resource)
            : this(text, resource.Language, resource.Confidence.GetValueOrDefault(), resource.IsReliable ?? false)
        {
        }
    }
}
