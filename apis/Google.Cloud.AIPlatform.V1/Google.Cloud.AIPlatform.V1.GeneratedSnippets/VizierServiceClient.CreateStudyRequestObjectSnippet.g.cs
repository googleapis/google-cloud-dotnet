// Copyright 2024 Google LLC
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

namespace GoogleCSharpSnippets
{
    // [START aiplatform_v1_generated_VizierService_CreateStudy_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;

    public sealed partial class GeneratedVizierServiceClientSnippets
    {
        /// <summary>Snippet for CreateStudy</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateStudyRequestObject()
        {
            // Create client
            VizierServiceClient vizierServiceClient = VizierServiceClient.Create();
            // Initialize request argument(s)
            CreateStudyRequest request = new CreateStudyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Study = new Study
                {
                    DisplayName = "",
                    StudySpec = new StudySpec
                    {
                        Metrics =
                        {
                            new StudySpec.Types.MetricSpec
                            {
                                MetricId = "",
                                Goal = StudySpec.Types.MetricSpec.Types.GoalType.Unspecified,
                            },
                        },
                        Parameters =
                        {
                            new StudySpec.Types.ParameterSpec
                            {
                                ParameterId = "",
                                DoubleValueSpec = new StudySpec.Types.ParameterSpec.Types.DoubleValueSpec
                                {
                                    MinValue = 0,
                                    MaxValue = 0,
                                },
                            },
                        },
                        DecayCurveStoppingSpec = new StudySpec.Types.DecayCurveAutomatedStoppingSpec { },
                    },
                },
            };
            // Make the request
            Study response = vizierServiceClient.CreateStudy(request);
        }
    }
    // [END aiplatform_v1_generated_VizierService_CreateStudy_sync]
}
