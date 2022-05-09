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

namespace Google.Cloud.Speech.V1.Snippets
{
    // [START speech_v1_generated_Adaptation_CreateCustomClass_sync_flattened]
    using Google.Cloud.Speech.V1;

    public sealed partial class GeneratedAdaptationClientSnippets
    {
        /// <summary>Snippet for CreateCustomClass</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateCustomClass()
        {
            // Create client
            AdaptationClient adaptationClient = AdaptationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CustomClass customClass = new CustomClass();
            string customClassId = "";
            // Make the request
            CustomClass response = adaptationClient.CreateCustomClass(parent, customClass, customClassId);
        }
    }
    // [END speech_v1_generated_Adaptation_CreateCustomClass_sync_flattened]
}
