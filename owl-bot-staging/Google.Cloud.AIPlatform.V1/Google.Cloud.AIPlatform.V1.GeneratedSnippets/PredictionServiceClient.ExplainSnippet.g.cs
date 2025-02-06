// Copyright 2025 Google LLC
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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    // [START aiplatform_v1_generated_PredictionService_Explain_sync_flattened]
    using Google.Cloud.AIPlatform.V1;
    using System.Collections.Generic;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedPredictionServiceClientSnippets
    {
        /// <summary>Snippet for Explain</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void Explain()
        {
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            wkt::Value parameters = new wkt::Value();
            string deployedModelId = "";
            // Make the request
            ExplainResponse response = predictionServiceClient.Explain(endpoint, instances, parameters, deployedModelId);
        }
    }
    // [END aiplatform_v1_generated_PredictionService_Explain_sync_flattened]
}
