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

namespace Google.Cloud.Translation.V2
{
    /// <summary>
    /// Model logic.
    /// </summary>
    internal static class TranslationModels
    {
        private const string BaseApiName = "base";
        private const string NeuralMachineTranslationApiName = "nmt";

        internal static void ValidateModel(TranslationModel model)
        {
            switch (model)
            {
                case TranslationModel.ServiceDefault: return;
                case TranslationModel.Base: return;
                case TranslationModel.NeuralMachineTranslation: return;
            }
            throw new ArgumentException($"Unknown translation model {model}", nameof(model));
        }

        internal static string ToApiName(this TranslationModel model)
        {
            switch (model)
            {
                // null in an outbound API call means "no client preference"
                case TranslationModel.ServiceDefault: return null;
                case TranslationModel.Base: return BaseApiName;
                case TranslationModel.NeuralMachineTranslation: return NeuralMachineTranslationApiName;
                default: throw new InvalidOperationException($"Unknown translation model {model}");
            }
        }

        internal static TranslationModel? GetModel(string name)
        {
            switch (name)
            {
                case BaseApiName: return TranslationModel.Base;
                case NeuralMachineTranslationApiName: return TranslationModel.NeuralMachineTranslation;
                default: return null;
            }
        }
    }
}
