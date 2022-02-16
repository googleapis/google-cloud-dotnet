// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Speech.V1P1Beta1.Snippets
{
    // [START speech_v1p1beta1_generated_Adaptation_UpdateCustomClass_sync_flattened]
    using Google.Cloud.Speech.V1P1Beta1;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedAdaptationClientSnippets
    {
        /// <summary>Snippet for UpdateCustomClass</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateCustomClass()
        {
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            CustomClass customClass = new CustomClass();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CustomClass response = adaptationClient.UpdateCustomClass(customClass, updateMask);
        }
    }
    // [END speech_v1p1beta1_generated_Adaptation_UpdateCustomClass_sync_flattened]
}
