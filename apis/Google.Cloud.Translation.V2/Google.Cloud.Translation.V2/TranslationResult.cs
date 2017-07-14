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
    /// The result of a translation operation.
    /// </summary>
    public sealed class TranslationResult
    {
        /// <summary>
        /// The original text (or HTML) that was translated.
        /// </summary>
        public string OriginalText { get; }

        /// <summary>
        /// The translated text.
        /// </summary>
        public string TranslatedText { get; }

        /// <summary>
        /// The source language code detected by the server. This may
        /// be null, typically due to the source language being supplied
        /// by the caller.
        /// </summary>
        public string DetectedSourceLanguage { get; }

        /// <summary>
        /// The source language code supplied by the caller, if any.
        /// </summary>
        public string SpecifiedSourceLanguage { get; }

        /// <summary>
        /// The target language code that the text was translated into.
        /// </summary>
        public string TargetLanguage { get; }

        /// <summary>
        /// The model used to perform the translation, if known and available
        /// as one of the values in <see cref="TranslationModel"/>.
        /// </summary>
        public TranslationModel? Model { get; }

        /// <summary>
        /// The name of the model used to perform the translation. This may be present
        /// even if <see cref="Model"/> is null, if a custom model name has been specified
        /// via <see cref="AdvancedTranslationClient"/>.
        /// </summary>
        public string ModelName { get; }

        /// <summary>
        /// Constructs an instance.
        /// </summary>
        /// <remarks>This constructor is for the benefit of testability, in case you wish to provide your own
        /// fake implementation of <see cref="TranslationClient"/>.</remarks>
        /// <param name="originalText">The original text.</param>
        /// <param name="translatedText">The translated text.</param>
        /// <param name="detectedSourceLanguage">The source language code detected by the server, if any.</param>
        /// <param name="specifiedSourceLanguage">The source language code specified by the API caller.</param>
        /// <param name="targetLanguage">The target language code.</param>
        /// <param name="model">The model used to perform the translation, if known.</param>
        public TranslationResult(string originalText, string translatedText, string detectedSourceLanguage, string specifiedSourceLanguage,
            string targetLanguage, TranslationModel? model) : this(originalText, translatedText, detectedSourceLanguage, specifiedSourceLanguage,
                targetLanguage, model, model == null ? null : TranslationModels.ToApiName(model.Value))
        {
        }

        /// <summary>
        /// Constructs an instance.
        /// </summary>
        /// <remarks>This constructor is for the benefit of testability, in case you wish to provide your own
        /// fake implementation of <see cref="TranslationClient"/>.</remarks>
        /// <param name="originalText">The original text.</param>
        /// <param name="translatedText">The translated text.</param>
        /// <param name="detectedSourceLanguage">The source language code detected by the server, if any.</param>
        /// <param name="specifiedSourceLanguage">The source language code specified by the API caller.</param>
        /// <param name="targetLanguage">The target language code.</param>
        /// <param name="model">The model used to perform the translation, if known.</param>
        /// <param name="modelName">The name of the model used to perform the translation.</param>
        public TranslationResult(string originalText, string translatedText, string detectedSourceLanguage, string specifiedSourceLanguage,
            string targetLanguage, TranslationModel? model, string modelName)
        {
            OriginalText = originalText;
            TranslatedText = translatedText;
            SpecifiedSourceLanguage = specifiedSourceLanguage;
            DetectedSourceLanguage = detectedSourceLanguage;
            TargetLanguage = targetLanguage;
            Model = model;
            ModelName = modelName;
        }

        /// <summary>
        /// Constructs an instance from an API result.
        /// </summary>
        internal TranslationResult(TranslationsResource resource, string originalText, string specifiedSourceLanguage, string targetLanguage)
            : this(originalText, resource.TranslatedText, resource.DetectedSourceLanguage, 
                  specifiedSourceLanguage, targetLanguage, TranslationModels.GetModel(resource.Model), resource.Model)
        {
        }
    }
}
