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
    // [START aiplatform_v1_generated_VizierService_CreateStudy_async_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedVizierServiceClientSnippets
    {
        /// <summary>Snippet for CreateStudyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateStudyResourceNamesAsync()
        {
            // Create client
            VizierServiceClient vizierServiceClient = await VizierServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Study study = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "",
                StudySpec = new StudySpec
                {
                    Metrics =
                    {
                        new StudySpec.Types.MetricSpec
                        {
                            MetricId = "",
                            Goal = StudySpec.Types.MetricSpec.Types.GoalType.Unspecified,
                            SafetyConfig = new StudySpec.Types.MetricSpec.Types.SafetyMetricConfig
                            {
                                SafetyThreshold = 0,
                                DesiredMinSafeTrialsFraction = 0,
                            },
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
                                DefaultValue = 0,
                            },
                            IntegerValueSpec = new StudySpec.Types.ParameterSpec.Types.IntegerValueSpec
                            {
                                MinValue = 0L,
                                MaxValue = 0L,
                                DefaultValue = 0L,
                            },
                            CategoricalValueSpec = new StudySpec.Types.ParameterSpec.Types.CategoricalValueSpec
                            {
                                Values = { "", },
                                DefaultValue = "",
                            },
                            DiscreteValueSpec = new StudySpec.Types.ParameterSpec.Types.DiscreteValueSpec
                            {
                                Values = { 0, },
                                DefaultValue = 0,
                            },
                            ScaleType = StudySpec.Types.ParameterSpec.Types.ScaleType.Unspecified,
                            ConditionalParameterSpecs =
                            {
                                new StudySpec.Types.ParameterSpec.Types.ConditionalParameterSpec
                                {
                                    ParameterSpec = new StudySpec.Types.ParameterSpec { },
                                    ParentDiscreteValues = new StudySpec.Types.ParameterSpec.Types.ConditionalParameterSpec.Types.DiscreteValueCondition { Values = { 0, }, },
                                    ParentIntValues = new StudySpec.Types.ParameterSpec.Types.ConditionalParameterSpec.Types.IntValueCondition { Values = { 0L, }, },
                                    ParentCategoricalValues = new StudySpec.Types.ParameterSpec.Types.ConditionalParameterSpec.Types.CategoricalValueCondition { Values = { "", }, },
                                },
                            },
                        },
                    },
                    Algorithm = StudySpec.Types.Algorithm.Unspecified,
                    DecayCurveStoppingSpec = new StudySpec.Types.DecayCurveAutomatedStoppingSpec
                    {
                        UseElapsedDuration = false,
                    },
                    MedianAutomatedStoppingSpec = new StudySpec.Types.MedianAutomatedStoppingSpec
                    {
                        UseElapsedDuration = false,
                    },
                    ObservationNoise = StudySpec.Types.ObservationNoise.Unspecified,
                    MeasurementSelectionType = StudySpec.Types.MeasurementSelectionType.Unspecified,
                    ConvexAutomatedStoppingSpec = new StudySpec.Types.ConvexAutomatedStoppingSpec
                    {
                        MaxStepCount = 0L,
                        MinStepCount = 0L,
                        MinMeasurementCount = 0L,
                        LearningRateParameterName = "",
                        UseElapsedDuration = false,
                        UpdateAllStoppedTrials = false,
                    },
                    StudyStoppingConfig = new StudySpec.Types.StudyStoppingConfig
                    {
                        ShouldStopAsap = false,
                        MinimumRuntimeConstraint = new StudyTimeConstraint
                        {
                            MaxDuration = new Duration
                            {
                                Seconds = 0L,
                                Nanos = 0,
                            },
                            EndTime = new Timestamp
                            {
                                Seconds = 0L,
                                Nanos = 0,
                            },
                        },
                        MaximumRuntimeConstraint = new StudyTimeConstraint
                        {
                            MaxDuration = new Duration
                            {
                                Seconds = 0L,
                                Nanos = 0,
                            },
                            EndTime = new Timestamp
                            {
                                Seconds = 0L,
                                Nanos = 0,
                            },
                        },
                        MinNumTrials = 0,
                        MaxNumTrials = 0,
                        MaxNumTrialsNoProgress = 0,
                        MaxDurationNoProgress = new Duration
                        {
                            Seconds = 0L,
                            Nanos = 0,
                        },
                    },
                },
                State = Study.Types.State.Unspecified,
                CreateTime = new Timestamp
                {
                    Seconds = 0L,
                    Nanos = 0,
                },
                InactiveReason = "",
            };
            // Make the request
            Study response = await vizierServiceClient.CreateStudyAsync(parent, study);
        }
    }
    // [END aiplatform_v1_generated_VizierService_CreateStudy_async_flattened_resourceNames]
}
