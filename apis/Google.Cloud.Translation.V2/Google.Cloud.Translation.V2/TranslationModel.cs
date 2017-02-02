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

namespace Google.Cloud.Translation.V2
{
    /// <summary>
    /// Underlying model used by the Google Cloud Translation API.
    /// </summary>
    public enum TranslationModel
    {
        /// <summary>
        /// Standard edition translation model.
        /// </summary>
        Base,
        /// <summary>
        /// Only available in Premium edition, the Neural Machine Translation
        /// model provides higher quality results.
        /// </summary>
        NeuralMachineTranslation
    }
}
