// Copyright 2026 Google LLC
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
    using Google.Api.Gax;
    using Google.Cloud.Ces.V1Beta;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEvaluationServiceClientSnippets
    {
        /// <summary>Snippet for RunEvaluation</summary>
        public void RunEvaluationRequestObject()
        {
            // Snippet: RunEvaluation(RunEvaluationRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            RunEvaluationRequest request = new RunEvaluationRequest
            {
                AppAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                EvaluationsAsEvaluationNames =
                {
                    EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]"),
                },
                EvaluationDatasetAsEvaluationDatasetName = EvaluationDatasetName.FromProjectLocationAppEvaluationDataset("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_DATASET]"),
                DisplayName = "",
                AppVersionAsAppVersionName = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]"),
                Config = new EvaluationConfig(),
                RunCount = 0,
                PersonaRunConfigs =
                {
                    new PersonaRunConfig(),
                },
                OptimizationConfig = new OptimizationConfig(),
                ScheduledEvaluationRunAsScheduledEvaluationRunName = ScheduledEvaluationRunName.FromProjectLocationAppScheduledEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[SCHEDULED_EVALUATION_RUN]"),
                GoldenRunMethod = GoldenRunMethod.Unspecified,
                GenerateLatencyReport = false,
            };
            // Make the request
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> response = evaluationServiceClient.RunEvaluation(request);

            // Poll until the returned long-running operation is complete
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunEvaluationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceRunEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunEvaluationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunEvaluationAsync</summary>
        public async Task RunEvaluationRequestObjectAsync()
        {
            // Snippet: RunEvaluationAsync(RunEvaluationRequest, CallSettings)
            // Additional: RunEvaluationAsync(RunEvaluationRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunEvaluationRequest request = new RunEvaluationRequest
            {
                AppAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                EvaluationsAsEvaluationNames =
                {
                    EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]"),
                },
                EvaluationDatasetAsEvaluationDatasetName = EvaluationDatasetName.FromProjectLocationAppEvaluationDataset("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_DATASET]"),
                DisplayName = "",
                AppVersionAsAppVersionName = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]"),
                Config = new EvaluationConfig(),
                RunCount = 0,
                PersonaRunConfigs =
                {
                    new PersonaRunConfig(),
                },
                OptimizationConfig = new OptimizationConfig(),
                ScheduledEvaluationRunAsScheduledEvaluationRunName = ScheduledEvaluationRunName.FromProjectLocationAppScheduledEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[SCHEDULED_EVALUATION_RUN]"),
                GoldenRunMethod = GoldenRunMethod.Unspecified,
                GenerateLatencyReport = false,
            };
            // Make the request
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> response = await evaluationServiceClient.RunEvaluationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RunEvaluationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceRunEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunEvaluationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunEvaluation</summary>
        public void RunEvaluation()
        {
            // Snippet: RunEvaluation(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string app = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> response = evaluationServiceClient.RunEvaluation(app);

            // Poll until the returned long-running operation is complete
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunEvaluationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceRunEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunEvaluationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunEvaluationAsync</summary>
        public async Task RunEvaluationAsync()
        {
            // Snippet: RunEvaluationAsync(string, CallSettings)
            // Additional: RunEvaluationAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string app = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> response = await evaluationServiceClient.RunEvaluationAsync(app);

            // Poll until the returned long-running operation is complete
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RunEvaluationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceRunEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunEvaluationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunEvaluation</summary>
        public void RunEvaluationResourceNames()
        {
            // Snippet: RunEvaluation(AppName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName app = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> response = evaluationServiceClient.RunEvaluation(app);

            // Poll until the returned long-running operation is complete
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunEvaluationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceRunEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunEvaluationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunEvaluationAsync</summary>
        public async Task RunEvaluationResourceNamesAsync()
        {
            // Snippet: RunEvaluationAsync(AppName, CallSettings)
            // Additional: RunEvaluationAsync(AppName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName app = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> response = await evaluationServiceClient.RunEvaluationAsync(app);

            // Poll until the returned long-running operation is complete
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RunEvaluationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceRunEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunEvaluationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UploadEvaluationAudio</summary>
        public void UploadEvaluationAudioRequestObject()
        {
            // Snippet: UploadEvaluationAudio(UploadEvaluationAudioRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            UploadEvaluationAudioRequest request = new UploadEvaluationAudioRequest
            {
                AppAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                AudioContent = ByteString.Empty,
            };
            // Make the request
            UploadEvaluationAudioResponse response = evaluationServiceClient.UploadEvaluationAudio(request);
            // End snippet
        }

        /// <summary>Snippet for UploadEvaluationAudioAsync</summary>
        public async Task UploadEvaluationAudioRequestObjectAsync()
        {
            // Snippet: UploadEvaluationAudioAsync(UploadEvaluationAudioRequest, CallSettings)
            // Additional: UploadEvaluationAudioAsync(UploadEvaluationAudioRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UploadEvaluationAudioRequest request = new UploadEvaluationAudioRequest
            {
                AppAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                AudioContent = ByteString.Empty,
            };
            // Make the request
            UploadEvaluationAudioResponse response = await evaluationServiceClient.UploadEvaluationAudioAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UploadEvaluationAudio</summary>
        public void UploadEvaluationAudio()
        {
            // Snippet: UploadEvaluationAudio(string, ByteString, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string app = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            ByteString audioContent = ByteString.Empty;
            // Make the request
            UploadEvaluationAudioResponse response = evaluationServiceClient.UploadEvaluationAudio(app, audioContent);
            // End snippet
        }

        /// <summary>Snippet for UploadEvaluationAudioAsync</summary>
        public async Task UploadEvaluationAudioAsync()
        {
            // Snippet: UploadEvaluationAudioAsync(string, ByteString, CallSettings)
            // Additional: UploadEvaluationAudioAsync(string, ByteString, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string app = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            ByteString audioContent = ByteString.Empty;
            // Make the request
            UploadEvaluationAudioResponse response = await evaluationServiceClient.UploadEvaluationAudioAsync(app, audioContent);
            // End snippet
        }

        /// <summary>Snippet for UploadEvaluationAudio</summary>
        public void UploadEvaluationAudioResourceNames()
        {
            // Snippet: UploadEvaluationAudio(AppName, ByteString, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName app = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            ByteString audioContent = ByteString.Empty;
            // Make the request
            UploadEvaluationAudioResponse response = evaluationServiceClient.UploadEvaluationAudio(app, audioContent);
            // End snippet
        }

        /// <summary>Snippet for UploadEvaluationAudioAsync</summary>
        public async Task UploadEvaluationAudioResourceNamesAsync()
        {
            // Snippet: UploadEvaluationAudioAsync(AppName, ByteString, CallSettings)
            // Additional: UploadEvaluationAudioAsync(AppName, ByteString, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName app = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            ByteString audioContent = ByteString.Empty;
            // Make the request
            UploadEvaluationAudioResponse response = await evaluationServiceClient.UploadEvaluationAudioAsync(app, audioContent);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluation</summary>
        public void CreateEvaluationRequestObject()
        {
            // Snippet: CreateEvaluation(CreateEvaluationRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            CreateEvaluationRequest request = new CreateEvaluationRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                EvaluationId = "",
                Evaluation = new Evaluation(),
            };
            // Make the request
            Evaluation response = evaluationServiceClient.CreateEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationAsync</summary>
        public async Task CreateEvaluationRequestObjectAsync()
        {
            // Snippet: CreateEvaluationAsync(CreateEvaluationRequest, CallSettings)
            // Additional: CreateEvaluationAsync(CreateEvaluationRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEvaluationRequest request = new CreateEvaluationRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                EvaluationId = "",
                Evaluation = new Evaluation(),
            };
            // Make the request
            Evaluation response = await evaluationServiceClient.CreateEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluation</summary>
        public void CreateEvaluation1()
        {
            // Snippet: CreateEvaluation(string, Evaluation, string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Evaluation evaluation = new Evaluation();
            string evaluationId = "";
            // Make the request
            Evaluation response = evaluationServiceClient.CreateEvaluation(parent, evaluation, evaluationId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationAsync</summary>
        public async Task CreateEvaluation1Async()
        {
            // Snippet: CreateEvaluationAsync(string, Evaluation, string, CallSettings)
            // Additional: CreateEvaluationAsync(string, Evaluation, string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Evaluation evaluation = new Evaluation();
            string evaluationId = "";
            // Make the request
            Evaluation response = await evaluationServiceClient.CreateEvaluationAsync(parent, evaluation, evaluationId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluation</summary>
        public void CreateEvaluation1ResourceNames()
        {
            // Snippet: CreateEvaluation(AppName, Evaluation, string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Evaluation evaluation = new Evaluation();
            string evaluationId = "";
            // Make the request
            Evaluation response = evaluationServiceClient.CreateEvaluation(parent, evaluation, evaluationId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationAsync</summary>
        public async Task CreateEvaluation1ResourceNamesAsync()
        {
            // Snippet: CreateEvaluationAsync(AppName, Evaluation, string, CallSettings)
            // Additional: CreateEvaluationAsync(AppName, Evaluation, string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Evaluation evaluation = new Evaluation();
            string evaluationId = "";
            // Make the request
            Evaluation response = await evaluationServiceClient.CreateEvaluationAsync(parent, evaluation, evaluationId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluation</summary>
        public void CreateEvaluation2()
        {
            // Snippet: CreateEvaluation(string, Evaluation, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Evaluation evaluation = new Evaluation();
            // Make the request
            Evaluation response = evaluationServiceClient.CreateEvaluation(parent, evaluation);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationAsync</summary>
        public async Task CreateEvaluation2Async()
        {
            // Snippet: CreateEvaluationAsync(string, Evaluation, CallSettings)
            // Additional: CreateEvaluationAsync(string, Evaluation, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            Evaluation evaluation = new Evaluation();
            // Make the request
            Evaluation response = await evaluationServiceClient.CreateEvaluationAsync(parent, evaluation);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluation</summary>
        public void CreateEvaluation2ResourceNames()
        {
            // Snippet: CreateEvaluation(AppName, Evaluation, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Evaluation evaluation = new Evaluation();
            // Make the request
            Evaluation response = evaluationServiceClient.CreateEvaluation(parent, evaluation);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationAsync</summary>
        public async Task CreateEvaluation2ResourceNamesAsync()
        {
            // Snippet: CreateEvaluationAsync(AppName, Evaluation, CallSettings)
            // Additional: CreateEvaluationAsync(AppName, Evaluation, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            Evaluation evaluation = new Evaluation();
            // Make the request
            Evaluation response = await evaluationServiceClient.CreateEvaluationAsync(parent, evaluation);
            // End snippet
        }

        /// <summary>Snippet for GenerateEvaluation</summary>
        public void GenerateEvaluationRequestObject()
        {
            // Snippet: GenerateEvaluation(GenerateEvaluationRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            GenerateEvaluationRequest request = new GenerateEvaluationRequest
            {
                ConversationAsConversationName = ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]"),
            };
            // Make the request
            Operation<Evaluation, GenerateEvaluationOperationMetadata> response = evaluationServiceClient.GenerateEvaluation(request);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, GenerateEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, GenerateEvaluationOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceGenerateEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateEvaluationAsync</summary>
        public async Task GenerateEvaluationRequestObjectAsync()
        {
            // Snippet: GenerateEvaluationAsync(GenerateEvaluationRequest, CallSettings)
            // Additional: GenerateEvaluationAsync(GenerateEvaluationRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateEvaluationRequest request = new GenerateEvaluationRequest
            {
                ConversationAsConversationName = ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]"),
            };
            // Make the request
            Operation<Evaluation, GenerateEvaluationOperationMetadata> response = await evaluationServiceClient.GenerateEvaluationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, GenerateEvaluationOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, GenerateEvaluationOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceGenerateEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateEvaluation</summary>
        public void GenerateEvaluation()
        {
            // Snippet: GenerateEvaluation(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string conversation = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/conversations/[CONVERSATION]";
            // Make the request
            Operation<Evaluation, GenerateEvaluationOperationMetadata> response = evaluationServiceClient.GenerateEvaluation(conversation);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, GenerateEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, GenerateEvaluationOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceGenerateEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateEvaluationAsync</summary>
        public async Task GenerateEvaluationAsync()
        {
            // Snippet: GenerateEvaluationAsync(string, CallSettings)
            // Additional: GenerateEvaluationAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string conversation = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/conversations/[CONVERSATION]";
            // Make the request
            Operation<Evaluation, GenerateEvaluationOperationMetadata> response = await evaluationServiceClient.GenerateEvaluationAsync(conversation);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, GenerateEvaluationOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, GenerateEvaluationOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceGenerateEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateEvaluation</summary>
        public void GenerateEvaluationResourceNames()
        {
            // Snippet: GenerateEvaluation(ConversationName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ConversationName conversation = ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]");
            // Make the request
            Operation<Evaluation, GenerateEvaluationOperationMetadata> response = evaluationServiceClient.GenerateEvaluation(conversation);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, GenerateEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, GenerateEvaluationOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceGenerateEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateEvaluationAsync</summary>
        public async Task GenerateEvaluationResourceNamesAsync()
        {
            // Snippet: GenerateEvaluationAsync(ConversationName, CallSettings)
            // Additional: GenerateEvaluationAsync(ConversationName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName conversation = ConversationName.FromProjectLocationAppConversation("[PROJECT]", "[LOCATION]", "[APP]", "[CONVERSATION]");
            // Make the request
            Operation<Evaluation, GenerateEvaluationOperationMetadata> response = await evaluationServiceClient.GenerateEvaluationAsync(conversation);

            // Poll until the returned long-running operation is complete
            Operation<Evaluation, GenerateEvaluationOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Evaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Evaluation, GenerateEvaluationOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceGenerateEvaluationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Evaluation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEvaluations</summary>
        public void ImportEvaluationsRequestObject()
        {
            // Snippet: ImportEvaluations(ImportEvaluationsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ImportEvaluationsRequest request = new ImportEvaluationsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ConversationList = new ImportEvaluationsRequest.Types.ConversationList(),
                ImportOptions = new ImportEvaluationsRequest.Types.ImportOptions(),
            };
            // Make the request
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> response = evaluationServiceClient.ImportEvaluations(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportEvaluationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceImportEvaluations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportEvaluationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEvaluationsAsync</summary>
        public async Task ImportEvaluationsRequestObjectAsync()
        {
            // Snippet: ImportEvaluationsAsync(ImportEvaluationsRequest, CallSettings)
            // Additional: ImportEvaluationsAsync(ImportEvaluationsRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportEvaluationsRequest request = new ImportEvaluationsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ConversationList = new ImportEvaluationsRequest.Types.ConversationList(),
                ImportOptions = new ImportEvaluationsRequest.Types.ImportOptions(),
            };
            // Make the request
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> response = await evaluationServiceClient.ImportEvaluationsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportEvaluationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceImportEvaluationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportEvaluationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEvaluations</summary>
        public void ImportEvaluations()
        {
            // Snippet: ImportEvaluations(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> response = evaluationServiceClient.ImportEvaluations(parent);

            // Poll until the returned long-running operation is complete
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportEvaluationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceImportEvaluations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportEvaluationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEvaluationsAsync</summary>
        public async Task ImportEvaluationsAsync()
        {
            // Snippet: ImportEvaluationsAsync(string, CallSettings)
            // Additional: ImportEvaluationsAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> response = await evaluationServiceClient.ImportEvaluationsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportEvaluationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceImportEvaluationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportEvaluationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEvaluations</summary>
        public void ImportEvaluationsResourceNames()
        {
            // Snippet: ImportEvaluations(AppName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> response = evaluationServiceClient.ImportEvaluations(parent);

            // Poll until the returned long-running operation is complete
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportEvaluationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceImportEvaluations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportEvaluationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEvaluationsAsync</summary>
        public async Task ImportEvaluationsResourceNamesAsync()
        {
            // Snippet: ImportEvaluationsAsync(AppName, CallSettings)
            // Additional: ImportEvaluationsAsync(AppName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> response = await evaluationServiceClient.ImportEvaluationsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportEvaluationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceImportEvaluationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportEvaluationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationDataset</summary>
        public void CreateEvaluationDatasetRequestObject()
        {
            // Snippet: CreateEvaluationDataset(CreateEvaluationDatasetRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            CreateEvaluationDatasetRequest request = new CreateEvaluationDatasetRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                EvaluationDatasetId = "",
                EvaluationDataset = new EvaluationDataset(),
            };
            // Make the request
            EvaluationDataset response = evaluationServiceClient.CreateEvaluationDataset(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationDatasetAsync</summary>
        public async Task CreateEvaluationDatasetRequestObjectAsync()
        {
            // Snippet: CreateEvaluationDatasetAsync(CreateEvaluationDatasetRequest, CallSettings)
            // Additional: CreateEvaluationDatasetAsync(CreateEvaluationDatasetRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEvaluationDatasetRequest request = new CreateEvaluationDatasetRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                EvaluationDatasetId = "",
                EvaluationDataset = new EvaluationDataset(),
            };
            // Make the request
            EvaluationDataset response = await evaluationServiceClient.CreateEvaluationDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationDataset</summary>
        public void CreateEvaluationDataset1()
        {
            // Snippet: CreateEvaluationDataset(string, EvaluationDataset, string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            EvaluationDataset evaluationDataset = new EvaluationDataset();
            string evaluationDatasetId = "";
            // Make the request
            EvaluationDataset response = evaluationServiceClient.CreateEvaluationDataset(parent, evaluationDataset, evaluationDatasetId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationDatasetAsync</summary>
        public async Task CreateEvaluationDataset1Async()
        {
            // Snippet: CreateEvaluationDatasetAsync(string, EvaluationDataset, string, CallSettings)
            // Additional: CreateEvaluationDatasetAsync(string, EvaluationDataset, string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            EvaluationDataset evaluationDataset = new EvaluationDataset();
            string evaluationDatasetId = "";
            // Make the request
            EvaluationDataset response = await evaluationServiceClient.CreateEvaluationDatasetAsync(parent, evaluationDataset, evaluationDatasetId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationDataset</summary>
        public void CreateEvaluationDataset1ResourceNames()
        {
            // Snippet: CreateEvaluationDataset(AppName, EvaluationDataset, string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            EvaluationDataset evaluationDataset = new EvaluationDataset();
            string evaluationDatasetId = "";
            // Make the request
            EvaluationDataset response = evaluationServiceClient.CreateEvaluationDataset(parent, evaluationDataset, evaluationDatasetId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationDatasetAsync</summary>
        public async Task CreateEvaluationDataset1ResourceNamesAsync()
        {
            // Snippet: CreateEvaluationDatasetAsync(AppName, EvaluationDataset, string, CallSettings)
            // Additional: CreateEvaluationDatasetAsync(AppName, EvaluationDataset, string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            EvaluationDataset evaluationDataset = new EvaluationDataset();
            string evaluationDatasetId = "";
            // Make the request
            EvaluationDataset response = await evaluationServiceClient.CreateEvaluationDatasetAsync(parent, evaluationDataset, evaluationDatasetId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationDataset</summary>
        public void CreateEvaluationDataset2()
        {
            // Snippet: CreateEvaluationDataset(string, EvaluationDataset, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            EvaluationDataset evaluationDataset = new EvaluationDataset();
            // Make the request
            EvaluationDataset response = evaluationServiceClient.CreateEvaluationDataset(parent, evaluationDataset);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationDatasetAsync</summary>
        public async Task CreateEvaluationDataset2Async()
        {
            // Snippet: CreateEvaluationDatasetAsync(string, EvaluationDataset, CallSettings)
            // Additional: CreateEvaluationDatasetAsync(string, EvaluationDataset, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            EvaluationDataset evaluationDataset = new EvaluationDataset();
            // Make the request
            EvaluationDataset response = await evaluationServiceClient.CreateEvaluationDatasetAsync(parent, evaluationDataset);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationDataset</summary>
        public void CreateEvaluationDataset2ResourceNames()
        {
            // Snippet: CreateEvaluationDataset(AppName, EvaluationDataset, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            EvaluationDataset evaluationDataset = new EvaluationDataset();
            // Make the request
            EvaluationDataset response = evaluationServiceClient.CreateEvaluationDataset(parent, evaluationDataset);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationDatasetAsync</summary>
        public async Task CreateEvaluationDataset2ResourceNamesAsync()
        {
            // Snippet: CreateEvaluationDatasetAsync(AppName, EvaluationDataset, CallSettings)
            // Additional: CreateEvaluationDatasetAsync(AppName, EvaluationDataset, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            EvaluationDataset evaluationDataset = new EvaluationDataset();
            // Make the request
            EvaluationDataset response = await evaluationServiceClient.CreateEvaluationDatasetAsync(parent, evaluationDataset);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluation</summary>
        public void UpdateEvaluationRequestObject()
        {
            // Snippet: UpdateEvaluation(UpdateEvaluationRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            UpdateEvaluationRequest request = new UpdateEvaluationRequest
            {
                Evaluation = new Evaluation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Evaluation response = evaluationServiceClient.UpdateEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationAsync</summary>
        public async Task UpdateEvaluationRequestObjectAsync()
        {
            // Snippet: UpdateEvaluationAsync(UpdateEvaluationRequest, CallSettings)
            // Additional: UpdateEvaluationAsync(UpdateEvaluationRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEvaluationRequest request = new UpdateEvaluationRequest
            {
                Evaluation = new Evaluation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Evaluation response = await evaluationServiceClient.UpdateEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluation</summary>
        public void UpdateEvaluation()
        {
            // Snippet: UpdateEvaluation(Evaluation, FieldMask, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            Evaluation evaluation = new Evaluation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Evaluation response = evaluationServiceClient.UpdateEvaluation(evaluation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationAsync</summary>
        public async Task UpdateEvaluationAsync()
        {
            // Snippet: UpdateEvaluationAsync(Evaluation, FieldMask, CallSettings)
            // Additional: UpdateEvaluationAsync(Evaluation, FieldMask, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            Evaluation evaluation = new Evaluation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Evaluation response = await evaluationServiceClient.UpdateEvaluationAsync(evaluation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationDataset</summary>
        public void UpdateEvaluationDatasetRequestObject()
        {
            // Snippet: UpdateEvaluationDataset(UpdateEvaluationDatasetRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            UpdateEvaluationDatasetRequest request = new UpdateEvaluationDatasetRequest
            {
                EvaluationDataset = new EvaluationDataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EvaluationDataset response = evaluationServiceClient.UpdateEvaluationDataset(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationDatasetAsync</summary>
        public async Task UpdateEvaluationDatasetRequestObjectAsync()
        {
            // Snippet: UpdateEvaluationDatasetAsync(UpdateEvaluationDatasetRequest, CallSettings)
            // Additional: UpdateEvaluationDatasetAsync(UpdateEvaluationDatasetRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEvaluationDatasetRequest request = new UpdateEvaluationDatasetRequest
            {
                EvaluationDataset = new EvaluationDataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EvaluationDataset response = await evaluationServiceClient.UpdateEvaluationDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationDataset</summary>
        public void UpdateEvaluationDataset()
        {
            // Snippet: UpdateEvaluationDataset(EvaluationDataset, FieldMask, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationDataset evaluationDataset = new EvaluationDataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EvaluationDataset response = evaluationServiceClient.UpdateEvaluationDataset(evaluationDataset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationDatasetAsync</summary>
        public async Task UpdateEvaluationDatasetAsync()
        {
            // Snippet: UpdateEvaluationDatasetAsync(EvaluationDataset, FieldMask, CallSettings)
            // Additional: UpdateEvaluationDatasetAsync(EvaluationDataset, FieldMask, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationDataset evaluationDataset = new EvaluationDataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EvaluationDataset response = await evaluationServiceClient.UpdateEvaluationDatasetAsync(evaluationDataset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluation</summary>
        public void DeleteEvaluationRequestObject()
        {
            // Snippet: DeleteEvaluation(DeleteEvaluationRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            DeleteEvaluationRequest request = new DeleteEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]"),
                Force = false,
                Etag = "",
            };
            // Make the request
            evaluationServiceClient.DeleteEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationAsync</summary>
        public async Task DeleteEvaluationRequestObjectAsync()
        {
            // Snippet: DeleteEvaluationAsync(DeleteEvaluationRequest, CallSettings)
            // Additional: DeleteEvaluationAsync(DeleteEvaluationRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEvaluationRequest request = new DeleteEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]"),
                Force = false,
                Etag = "",
            };
            // Make the request
            await evaluationServiceClient.DeleteEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluation</summary>
        public void DeleteEvaluation()
        {
            // Snippet: DeleteEvaluation(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluations/[EVALUATION]";
            // Make the request
            evaluationServiceClient.DeleteEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationAsync</summary>
        public async Task DeleteEvaluationAsync()
        {
            // Snippet: DeleteEvaluationAsync(string, CallSettings)
            // Additional: DeleteEvaluationAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluations/[EVALUATION]";
            // Make the request
            await evaluationServiceClient.DeleteEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluation</summary>
        public void DeleteEvaluationResourceNames()
        {
            // Snippet: DeleteEvaluation(EvaluationName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]");
            // Make the request
            evaluationServiceClient.DeleteEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationAsync</summary>
        public async Task DeleteEvaluationResourceNamesAsync()
        {
            // Snippet: DeleteEvaluationAsync(EvaluationName, CallSettings)
            // Additional: DeleteEvaluationAsync(EvaluationName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]");
            // Make the request
            await evaluationServiceClient.DeleteEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationResult</summary>
        public void DeleteEvaluationResultRequestObject()
        {
            // Snippet: DeleteEvaluationResult(DeleteEvaluationResultRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            DeleteEvaluationResultRequest request = new DeleteEvaluationResultRequest
            {
                EvaluationResultName = EvaluationResultName.FromProjectLocationAppEvaluationEvaluationResult("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]", "[EVALUATION_RESULT]"),
            };
            // Make the request
            evaluationServiceClient.DeleteEvaluationResult(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationResultAsync</summary>
        public async Task DeleteEvaluationResultRequestObjectAsync()
        {
            // Snippet: DeleteEvaluationResultAsync(DeleteEvaluationResultRequest, CallSettings)
            // Additional: DeleteEvaluationResultAsync(DeleteEvaluationResultRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEvaluationResultRequest request = new DeleteEvaluationResultRequest
            {
                EvaluationResultName = EvaluationResultName.FromProjectLocationAppEvaluationEvaluationResult("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]", "[EVALUATION_RESULT]"),
            };
            // Make the request
            await evaluationServiceClient.DeleteEvaluationResultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationResult</summary>
        public void DeleteEvaluationResult()
        {
            // Snippet: DeleteEvaluationResult(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluations/[EVALUATION]/results/[EVALUATION_RESULT]";
            // Make the request
            evaluationServiceClient.DeleteEvaluationResult(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationResultAsync</summary>
        public async Task DeleteEvaluationResultAsync()
        {
            // Snippet: DeleteEvaluationResultAsync(string, CallSettings)
            // Additional: DeleteEvaluationResultAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluations/[EVALUATION]/results/[EVALUATION_RESULT]";
            // Make the request
            await evaluationServiceClient.DeleteEvaluationResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationResult</summary>
        public void DeleteEvaluationResultResourceNames()
        {
            // Snippet: DeleteEvaluationResult(EvaluationResultName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationResultName name = EvaluationResultName.FromProjectLocationAppEvaluationEvaluationResult("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]", "[EVALUATION_RESULT]");
            // Make the request
            evaluationServiceClient.DeleteEvaluationResult(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationResultAsync</summary>
        public async Task DeleteEvaluationResultResourceNamesAsync()
        {
            // Snippet: DeleteEvaluationResultAsync(EvaluationResultName, CallSettings)
            // Additional: DeleteEvaluationResultAsync(EvaluationResultName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationResultName name = EvaluationResultName.FromProjectLocationAppEvaluationEvaluationResult("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]", "[EVALUATION_RESULT]");
            // Make the request
            await evaluationServiceClient.DeleteEvaluationResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationDataset</summary>
        public void DeleteEvaluationDatasetRequestObject()
        {
            // Snippet: DeleteEvaluationDataset(DeleteEvaluationDatasetRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            DeleteEvaluationDatasetRequest request = new DeleteEvaluationDatasetRequest
            {
                EvaluationDatasetName = EvaluationDatasetName.FromProjectLocationAppEvaluationDataset("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_DATASET]"),
                Etag = "",
            };
            // Make the request
            evaluationServiceClient.DeleteEvaluationDataset(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationDatasetAsync</summary>
        public async Task DeleteEvaluationDatasetRequestObjectAsync()
        {
            // Snippet: DeleteEvaluationDatasetAsync(DeleteEvaluationDatasetRequest, CallSettings)
            // Additional: DeleteEvaluationDatasetAsync(DeleteEvaluationDatasetRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEvaluationDatasetRequest request = new DeleteEvaluationDatasetRequest
            {
                EvaluationDatasetName = EvaluationDatasetName.FromProjectLocationAppEvaluationDataset("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_DATASET]"),
                Etag = "",
            };
            // Make the request
            await evaluationServiceClient.DeleteEvaluationDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationDataset</summary>
        public void DeleteEvaluationDataset()
        {
            // Snippet: DeleteEvaluationDataset(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluationDatasets/[EVALUATION_DATASET]";
            // Make the request
            evaluationServiceClient.DeleteEvaluationDataset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationDatasetAsync</summary>
        public async Task DeleteEvaluationDatasetAsync()
        {
            // Snippet: DeleteEvaluationDatasetAsync(string, CallSettings)
            // Additional: DeleteEvaluationDatasetAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluationDatasets/[EVALUATION_DATASET]";
            // Make the request
            await evaluationServiceClient.DeleteEvaluationDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationDataset</summary>
        public void DeleteEvaluationDatasetResourceNames()
        {
            // Snippet: DeleteEvaluationDataset(EvaluationDatasetName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationDatasetName name = EvaluationDatasetName.FromProjectLocationAppEvaluationDataset("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_DATASET]");
            // Make the request
            evaluationServiceClient.DeleteEvaluationDataset(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationDatasetAsync</summary>
        public async Task DeleteEvaluationDatasetResourceNamesAsync()
        {
            // Snippet: DeleteEvaluationDatasetAsync(EvaluationDatasetName, CallSettings)
            // Additional: DeleteEvaluationDatasetAsync(EvaluationDatasetName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationDatasetName name = EvaluationDatasetName.FromProjectLocationAppEvaluationDataset("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_DATASET]");
            // Make the request
            await evaluationServiceClient.DeleteEvaluationDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationRun</summary>
        public void DeleteEvaluationRunRequestObject()
        {
            // Snippet: DeleteEvaluationRun(DeleteEvaluationRunRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            DeleteEvaluationRunRequest request = new DeleteEvaluationRunRequest
            {
                EvaluationRunName = EvaluationRunName.FromProjectLocationAppEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_RUN]"),
            };
            // Make the request
            Operation<Empty, DeleteEvaluationRunOperationMetadata> response = evaluationServiceClient.DeleteEvaluationRun(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteEvaluationRunOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteEvaluationRunOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceDeleteEvaluationRun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationRunAsync</summary>
        public async Task DeleteEvaluationRunRequestObjectAsync()
        {
            // Snippet: DeleteEvaluationRunAsync(DeleteEvaluationRunRequest, CallSettings)
            // Additional: DeleteEvaluationRunAsync(DeleteEvaluationRunRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEvaluationRunRequest request = new DeleteEvaluationRunRequest
            {
                EvaluationRunName = EvaluationRunName.FromProjectLocationAppEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_RUN]"),
            };
            // Make the request
            Operation<Empty, DeleteEvaluationRunOperationMetadata> response = await evaluationServiceClient.DeleteEvaluationRunAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteEvaluationRunOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteEvaluationRunOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceDeleteEvaluationRunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationRun</summary>
        public void DeleteEvaluationRun()
        {
            // Snippet: DeleteEvaluationRun(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluationRuns/[EVALUATION_RUN]";
            // Make the request
            Operation<Empty, DeleteEvaluationRunOperationMetadata> response = evaluationServiceClient.DeleteEvaluationRun(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteEvaluationRunOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteEvaluationRunOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceDeleteEvaluationRun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationRunAsync</summary>
        public async Task DeleteEvaluationRunAsync()
        {
            // Snippet: DeleteEvaluationRunAsync(string, CallSettings)
            // Additional: DeleteEvaluationRunAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluationRuns/[EVALUATION_RUN]";
            // Make the request
            Operation<Empty, DeleteEvaluationRunOperationMetadata> response = await evaluationServiceClient.DeleteEvaluationRunAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteEvaluationRunOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteEvaluationRunOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceDeleteEvaluationRunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationRun</summary>
        public void DeleteEvaluationRunResourceNames()
        {
            // Snippet: DeleteEvaluationRun(EvaluationRunName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationRunName name = EvaluationRunName.FromProjectLocationAppEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_RUN]");
            // Make the request
            Operation<Empty, DeleteEvaluationRunOperationMetadata> response = evaluationServiceClient.DeleteEvaluationRun(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteEvaluationRunOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteEvaluationRunOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceDeleteEvaluationRun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationRunAsync</summary>
        public async Task DeleteEvaluationRunResourceNamesAsync()
        {
            // Snippet: DeleteEvaluationRunAsync(EvaluationRunName, CallSettings)
            // Additional: DeleteEvaluationRunAsync(EvaluationRunName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationRunName name = EvaluationRunName.FromProjectLocationAppEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_RUN]");
            // Make the request
            Operation<Empty, DeleteEvaluationRunOperationMetadata> response = await evaluationServiceClient.DeleteEvaluationRunAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteEvaluationRunOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteEvaluationRunOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceDeleteEvaluationRunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluationRequestObject()
        {
            // Snippet: GetEvaluation(GetEvaluationRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]"),
            };
            // Make the request
            Evaluation response = evaluationServiceClient.GetEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationRequestObjectAsync()
        {
            // Snippet: GetEvaluationAsync(GetEvaluationRequest, CallSettings)
            // Additional: GetEvaluationAsync(GetEvaluationRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]"),
            };
            // Make the request
            Evaluation response = await evaluationServiceClient.GetEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluation()
        {
            // Snippet: GetEvaluation(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluations/[EVALUATION]";
            // Make the request
            Evaluation response = evaluationServiceClient.GetEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationAsync()
        {
            // Snippet: GetEvaluationAsync(string, CallSettings)
            // Additional: GetEvaluationAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluations/[EVALUATION]";
            // Make the request
            Evaluation response = await evaluationServiceClient.GetEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluationResourceNames()
        {
            // Snippet: GetEvaluation(EvaluationName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]");
            // Make the request
            Evaluation response = evaluationServiceClient.GetEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationResourceNamesAsync()
        {
            // Snippet: GetEvaluationAsync(EvaluationName, CallSettings)
            // Additional: GetEvaluationAsync(EvaluationName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]");
            // Make the request
            Evaluation response = await evaluationServiceClient.GetEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationResult</summary>
        public void GetEvaluationResultRequestObject()
        {
            // Snippet: GetEvaluationResult(GetEvaluationResultRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            GetEvaluationResultRequest request = new GetEvaluationResultRequest
            {
                EvaluationResultName = EvaluationResultName.FromProjectLocationAppEvaluationEvaluationResult("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]", "[EVALUATION_RESULT]"),
            };
            // Make the request
            EvaluationResult response = evaluationServiceClient.GetEvaluationResult(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationResultAsync</summary>
        public async Task GetEvaluationResultRequestObjectAsync()
        {
            // Snippet: GetEvaluationResultAsync(GetEvaluationResultRequest, CallSettings)
            // Additional: GetEvaluationResultAsync(GetEvaluationResultRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEvaluationResultRequest request = new GetEvaluationResultRequest
            {
                EvaluationResultName = EvaluationResultName.FromProjectLocationAppEvaluationEvaluationResult("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]", "[EVALUATION_RESULT]"),
            };
            // Make the request
            EvaluationResult response = await evaluationServiceClient.GetEvaluationResultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationResult</summary>
        public void GetEvaluationResult()
        {
            // Snippet: GetEvaluationResult(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluations/[EVALUATION]/results/[EVALUATION_RESULT]";
            // Make the request
            EvaluationResult response = evaluationServiceClient.GetEvaluationResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationResultAsync</summary>
        public async Task GetEvaluationResultAsync()
        {
            // Snippet: GetEvaluationResultAsync(string, CallSettings)
            // Additional: GetEvaluationResultAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluations/[EVALUATION]/results/[EVALUATION_RESULT]";
            // Make the request
            EvaluationResult response = await evaluationServiceClient.GetEvaluationResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationResult</summary>
        public void GetEvaluationResultResourceNames()
        {
            // Snippet: GetEvaluationResult(EvaluationResultName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationResultName name = EvaluationResultName.FromProjectLocationAppEvaluationEvaluationResult("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]", "[EVALUATION_RESULT]");
            // Make the request
            EvaluationResult response = evaluationServiceClient.GetEvaluationResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationResultAsync</summary>
        public async Task GetEvaluationResultResourceNamesAsync()
        {
            // Snippet: GetEvaluationResultAsync(EvaluationResultName, CallSettings)
            // Additional: GetEvaluationResultAsync(EvaluationResultName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationResultName name = EvaluationResultName.FromProjectLocationAppEvaluationEvaluationResult("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]", "[EVALUATION_RESULT]");
            // Make the request
            EvaluationResult response = await evaluationServiceClient.GetEvaluationResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationDataset</summary>
        public void GetEvaluationDatasetRequestObject()
        {
            // Snippet: GetEvaluationDataset(GetEvaluationDatasetRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            GetEvaluationDatasetRequest request = new GetEvaluationDatasetRequest
            {
                EvaluationDatasetName = EvaluationDatasetName.FromProjectLocationAppEvaluationDataset("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_DATASET]"),
            };
            // Make the request
            EvaluationDataset response = evaluationServiceClient.GetEvaluationDataset(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationDatasetAsync</summary>
        public async Task GetEvaluationDatasetRequestObjectAsync()
        {
            // Snippet: GetEvaluationDatasetAsync(GetEvaluationDatasetRequest, CallSettings)
            // Additional: GetEvaluationDatasetAsync(GetEvaluationDatasetRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEvaluationDatasetRequest request = new GetEvaluationDatasetRequest
            {
                EvaluationDatasetName = EvaluationDatasetName.FromProjectLocationAppEvaluationDataset("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_DATASET]"),
            };
            // Make the request
            EvaluationDataset response = await evaluationServiceClient.GetEvaluationDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationDataset</summary>
        public void GetEvaluationDataset()
        {
            // Snippet: GetEvaluationDataset(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluationDatasets/[EVALUATION_DATASET]";
            // Make the request
            EvaluationDataset response = evaluationServiceClient.GetEvaluationDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationDatasetAsync</summary>
        public async Task GetEvaluationDatasetAsync()
        {
            // Snippet: GetEvaluationDatasetAsync(string, CallSettings)
            // Additional: GetEvaluationDatasetAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluationDatasets/[EVALUATION_DATASET]";
            // Make the request
            EvaluationDataset response = await evaluationServiceClient.GetEvaluationDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationDataset</summary>
        public void GetEvaluationDatasetResourceNames()
        {
            // Snippet: GetEvaluationDataset(EvaluationDatasetName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationDatasetName name = EvaluationDatasetName.FromProjectLocationAppEvaluationDataset("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_DATASET]");
            // Make the request
            EvaluationDataset response = evaluationServiceClient.GetEvaluationDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationDatasetAsync</summary>
        public async Task GetEvaluationDatasetResourceNamesAsync()
        {
            // Snippet: GetEvaluationDatasetAsync(EvaluationDatasetName, CallSettings)
            // Additional: GetEvaluationDatasetAsync(EvaluationDatasetName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationDatasetName name = EvaluationDatasetName.FromProjectLocationAppEvaluationDataset("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_DATASET]");
            // Make the request
            EvaluationDataset response = await evaluationServiceClient.GetEvaluationDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationRun</summary>
        public void GetEvaluationRunRequestObject()
        {
            // Snippet: GetEvaluationRun(GetEvaluationRunRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            GetEvaluationRunRequest request = new GetEvaluationRunRequest
            {
                EvaluationRunName = EvaluationRunName.FromProjectLocationAppEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_RUN]"),
            };
            // Make the request
            EvaluationRun response = evaluationServiceClient.GetEvaluationRun(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationRunAsync</summary>
        public async Task GetEvaluationRunRequestObjectAsync()
        {
            // Snippet: GetEvaluationRunAsync(GetEvaluationRunRequest, CallSettings)
            // Additional: GetEvaluationRunAsync(GetEvaluationRunRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEvaluationRunRequest request = new GetEvaluationRunRequest
            {
                EvaluationRunName = EvaluationRunName.FromProjectLocationAppEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_RUN]"),
            };
            // Make the request
            EvaluationRun response = await evaluationServiceClient.GetEvaluationRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationRun</summary>
        public void GetEvaluationRun()
        {
            // Snippet: GetEvaluationRun(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluationRuns/[EVALUATION_RUN]";
            // Make the request
            EvaluationRun response = evaluationServiceClient.GetEvaluationRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationRunAsync</summary>
        public async Task GetEvaluationRunAsync()
        {
            // Snippet: GetEvaluationRunAsync(string, CallSettings)
            // Additional: GetEvaluationRunAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluationRuns/[EVALUATION_RUN]";
            // Make the request
            EvaluationRun response = await evaluationServiceClient.GetEvaluationRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationRun</summary>
        public void GetEvaluationRunResourceNames()
        {
            // Snippet: GetEvaluationRun(EvaluationRunName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationRunName name = EvaluationRunName.FromProjectLocationAppEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_RUN]");
            // Make the request
            EvaluationRun response = evaluationServiceClient.GetEvaluationRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationRunAsync</summary>
        public async Task GetEvaluationRunResourceNamesAsync()
        {
            // Snippet: GetEvaluationRunAsync(EvaluationRunName, CallSettings)
            // Additional: GetEvaluationRunAsync(EvaluationRunName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationRunName name = EvaluationRunName.FromProjectLocationAppEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_RUN]");
            // Make the request
            EvaluationRun response = await evaluationServiceClient.GetEvaluationRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEvaluations</summary>
        public void ListEvaluationsRequestObject()
        {
            // Snippet: ListEvaluations(ListEvaluationsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ListEvaluationsRequest request = new ListEvaluationsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                OrderBy = "",
                LastTenResults = false,
                EvaluationFilter = "",
                EvaluationRunFilter = "",
            };
            // Make the request
            PagedEnumerable<ListEvaluationsResponse, Evaluation> response = evaluationServiceClient.ListEvaluations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationsAsync</summary>
        public async Task ListEvaluationsRequestObjectAsync()
        {
            // Snippet: ListEvaluationsAsync(ListEvaluationsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEvaluationsRequest request = new ListEvaluationsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                OrderBy = "",
                LastTenResults = false,
                EvaluationFilter = "",
                EvaluationRunFilter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> response = evaluationServiceClient.ListEvaluationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluations</summary>
        public void ListEvaluations()
        {
            // Snippet: ListEvaluations(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListEvaluationsResponse, Evaluation> response = evaluationServiceClient.ListEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationsAsync</summary>
        public async Task ListEvaluationsAsync()
        {
            // Snippet: ListEvaluationsAsync(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> response = evaluationServiceClient.ListEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluations</summary>
        public void ListEvaluationsResourceNames()
        {
            // Snippet: ListEvaluations(AppName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListEvaluationsResponse, Evaluation> response = evaluationServiceClient.ListEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationsAsync</summary>
        public async Task ListEvaluationsResourceNamesAsync()
        {
            // Snippet: ListEvaluationsAsync(AppName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> response = evaluationServiceClient.ListEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationResults</summary>
        public void ListEvaluationResultsRequestObject()
        {
            // Snippet: ListEvaluationResults(ListEvaluationResultsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ListEvaluationResultsRequest request = new ListEvaluationResultsRequest
            {
                ParentAsEvaluationName = EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEvaluationResultsResponse, EvaluationResult> response = evaluationServiceClient.ListEvaluationResults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationResultsAsync</summary>
        public async Task ListEvaluationResultsRequestObjectAsync()
        {
            // Snippet: ListEvaluationResultsAsync(ListEvaluationResultsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEvaluationResultsRequest request = new ListEvaluationResultsRequest
            {
                ParentAsEvaluationName = EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEvaluationResultsResponse, EvaluationResult> response = evaluationServiceClient.ListEvaluationResultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EvaluationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationResults</summary>
        public void ListEvaluationResults()
        {
            // Snippet: ListEvaluationResults(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluations/[EVALUATION]";
            // Make the request
            PagedEnumerable<ListEvaluationResultsResponse, EvaluationResult> response = evaluationServiceClient.ListEvaluationResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationResultsAsync</summary>
        public async Task ListEvaluationResultsAsync()
        {
            // Snippet: ListEvaluationResultsAsync(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluations/[EVALUATION]";
            // Make the request
            PagedAsyncEnumerable<ListEvaluationResultsResponse, EvaluationResult> response = evaluationServiceClient.ListEvaluationResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EvaluationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationResults</summary>
        public void ListEvaluationResultsResourceNames()
        {
            // Snippet: ListEvaluationResults(EvaluationName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationName parent = EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]");
            // Make the request
            PagedEnumerable<ListEvaluationResultsResponse, EvaluationResult> response = evaluationServiceClient.ListEvaluationResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationResultsAsync</summary>
        public async Task ListEvaluationResultsResourceNamesAsync()
        {
            // Snippet: ListEvaluationResultsAsync(EvaluationName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName parent = EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]");
            // Make the request
            PagedAsyncEnumerable<ListEvaluationResultsResponse, EvaluationResult> response = evaluationServiceClient.ListEvaluationResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EvaluationResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationDatasets</summary>
        public void ListEvaluationDatasetsRequestObject()
        {
            // Snippet: ListEvaluationDatasets(ListEvaluationDatasetsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ListEvaluationDatasetsRequest request = new ListEvaluationDatasetsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> response = evaluationServiceClient.ListEvaluationDatasets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationDataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationDatasetsAsync</summary>
        public async Task ListEvaluationDatasetsRequestObjectAsync()
        {
            // Snippet: ListEvaluationDatasetsAsync(ListEvaluationDatasetsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEvaluationDatasetsRequest request = new ListEvaluationDatasetsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> response = evaluationServiceClient.ListEvaluationDatasetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EvaluationDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationDataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationDatasets</summary>
        public void ListEvaluationDatasets()
        {
            // Snippet: ListEvaluationDatasets(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> response = evaluationServiceClient.ListEvaluationDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationDataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationDatasetsAsync</summary>
        public async Task ListEvaluationDatasetsAsync()
        {
            // Snippet: ListEvaluationDatasetsAsync(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> response = evaluationServiceClient.ListEvaluationDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EvaluationDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationDataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationDatasets</summary>
        public void ListEvaluationDatasetsResourceNames()
        {
            // Snippet: ListEvaluationDatasets(AppName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> response = evaluationServiceClient.ListEvaluationDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationDataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationDatasetsAsync</summary>
        public async Task ListEvaluationDatasetsResourceNamesAsync()
        {
            // Snippet: ListEvaluationDatasetsAsync(AppName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> response = evaluationServiceClient.ListEvaluationDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EvaluationDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationDataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationRuns</summary>
        public void ListEvaluationRunsRequestObject()
        {
            // Snippet: ListEvaluationRuns(ListEvaluationRunsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ListEvaluationRunsRequest request = new ListEvaluationRunsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEvaluationRunsResponse, EvaluationRun> response = evaluationServiceClient.ListEvaluationRuns(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationRunsAsync</summary>
        public async Task ListEvaluationRunsRequestObjectAsync()
        {
            // Snippet: ListEvaluationRunsAsync(ListEvaluationRunsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEvaluationRunsRequest request = new ListEvaluationRunsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEvaluationRunsResponse, EvaluationRun> response = evaluationServiceClient.ListEvaluationRunsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EvaluationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationRuns</summary>
        public void ListEvaluationRuns()
        {
            // Snippet: ListEvaluationRuns(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListEvaluationRunsResponse, EvaluationRun> response = evaluationServiceClient.ListEvaluationRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationRunsAsync</summary>
        public async Task ListEvaluationRunsAsync()
        {
            // Snippet: ListEvaluationRunsAsync(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListEvaluationRunsResponse, EvaluationRun> response = evaluationServiceClient.ListEvaluationRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EvaluationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationRuns</summary>
        public void ListEvaluationRunsResourceNames()
        {
            // Snippet: ListEvaluationRuns(AppName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListEvaluationRunsResponse, EvaluationRun> response = evaluationServiceClient.ListEvaluationRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationRunsAsync</summary>
        public async Task ListEvaluationRunsResourceNamesAsync()
        {
            // Snippet: ListEvaluationRunsAsync(AppName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListEvaluationRunsResponse, EvaluationRun> response = evaluationServiceClient.ListEvaluationRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EvaluationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationExpectations</summary>
        public void ListEvaluationExpectationsRequestObject()
        {
            // Snippet: ListEvaluationExpectations(ListEvaluationExpectationsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ListEvaluationExpectationsRequest request = new ListEvaluationExpectationsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> response = evaluationServiceClient.ListEvaluationExpectations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationExpectation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationExpectationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationExpectation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationExpectation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationExpectation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationExpectationsAsync</summary>
        public async Task ListEvaluationExpectationsRequestObjectAsync()
        {
            // Snippet: ListEvaluationExpectationsAsync(ListEvaluationExpectationsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEvaluationExpectationsRequest request = new ListEvaluationExpectationsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> response = evaluationServiceClient.ListEvaluationExpectationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EvaluationExpectation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationExpectationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationExpectation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationExpectation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationExpectation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationExpectations</summary>
        public void ListEvaluationExpectations()
        {
            // Snippet: ListEvaluationExpectations(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> response = evaluationServiceClient.ListEvaluationExpectations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationExpectation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationExpectationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationExpectation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationExpectation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationExpectation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationExpectationsAsync</summary>
        public async Task ListEvaluationExpectationsAsync()
        {
            // Snippet: ListEvaluationExpectationsAsync(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> response = evaluationServiceClient.ListEvaluationExpectationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EvaluationExpectation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationExpectationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationExpectation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationExpectation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationExpectation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationExpectations</summary>
        public void ListEvaluationExpectationsResourceNames()
        {
            // Snippet: ListEvaluationExpectations(AppName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> response = evaluationServiceClient.ListEvaluationExpectations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EvaluationExpectation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationExpectationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationExpectation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationExpectation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationExpectation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationExpectationsAsync</summary>
        public async Task ListEvaluationExpectationsResourceNamesAsync()
        {
            // Snippet: ListEvaluationExpectationsAsync(AppName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> response = evaluationServiceClient.ListEvaluationExpectationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (EvaluationExpectation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListEvaluationExpectationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EvaluationExpectation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EvaluationExpectation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EvaluationExpectation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationExpectation</summary>
        public void GetEvaluationExpectationRequestObject()
        {
            // Snippet: GetEvaluationExpectation(GetEvaluationExpectationRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            GetEvaluationExpectationRequest request = new GetEvaluationExpectationRequest
            {
                EvaluationExpectationName = EvaluationExpectationName.FromProjectLocationAppEvaluationExpectation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_EXPECTATION]"),
            };
            // Make the request
            EvaluationExpectation response = evaluationServiceClient.GetEvaluationExpectation(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationExpectationAsync</summary>
        public async Task GetEvaluationExpectationRequestObjectAsync()
        {
            // Snippet: GetEvaluationExpectationAsync(GetEvaluationExpectationRequest, CallSettings)
            // Additional: GetEvaluationExpectationAsync(GetEvaluationExpectationRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEvaluationExpectationRequest request = new GetEvaluationExpectationRequest
            {
                EvaluationExpectationName = EvaluationExpectationName.FromProjectLocationAppEvaluationExpectation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_EXPECTATION]"),
            };
            // Make the request
            EvaluationExpectation response = await evaluationServiceClient.GetEvaluationExpectationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationExpectation</summary>
        public void GetEvaluationExpectation()
        {
            // Snippet: GetEvaluationExpectation(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluationExpectations/[EVALUATION_EXPECTATION]";
            // Make the request
            EvaluationExpectation response = evaluationServiceClient.GetEvaluationExpectation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationExpectationAsync</summary>
        public async Task GetEvaluationExpectationAsync()
        {
            // Snippet: GetEvaluationExpectationAsync(string, CallSettings)
            // Additional: GetEvaluationExpectationAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluationExpectations/[EVALUATION_EXPECTATION]";
            // Make the request
            EvaluationExpectation response = await evaluationServiceClient.GetEvaluationExpectationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationExpectation</summary>
        public void GetEvaluationExpectationResourceNames()
        {
            // Snippet: GetEvaluationExpectation(EvaluationExpectationName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationExpectationName name = EvaluationExpectationName.FromProjectLocationAppEvaluationExpectation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_EXPECTATION]");
            // Make the request
            EvaluationExpectation response = evaluationServiceClient.GetEvaluationExpectation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationExpectationAsync</summary>
        public async Task GetEvaluationExpectationResourceNamesAsync()
        {
            // Snippet: GetEvaluationExpectationAsync(EvaluationExpectationName, CallSettings)
            // Additional: GetEvaluationExpectationAsync(EvaluationExpectationName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationExpectationName name = EvaluationExpectationName.FromProjectLocationAppEvaluationExpectation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_EXPECTATION]");
            // Make the request
            EvaluationExpectation response = await evaluationServiceClient.GetEvaluationExpectationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationExpectation</summary>
        public void CreateEvaluationExpectationRequestObject()
        {
            // Snippet: CreateEvaluationExpectation(CreateEvaluationExpectationRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            CreateEvaluationExpectationRequest request = new CreateEvaluationExpectationRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                EvaluationExpectationId = "",
                EvaluationExpectation = new EvaluationExpectation(),
            };
            // Make the request
            EvaluationExpectation response = evaluationServiceClient.CreateEvaluationExpectation(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationExpectationAsync</summary>
        public async Task CreateEvaluationExpectationRequestObjectAsync()
        {
            // Snippet: CreateEvaluationExpectationAsync(CreateEvaluationExpectationRequest, CallSettings)
            // Additional: CreateEvaluationExpectationAsync(CreateEvaluationExpectationRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEvaluationExpectationRequest request = new CreateEvaluationExpectationRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                EvaluationExpectationId = "",
                EvaluationExpectation = new EvaluationExpectation(),
            };
            // Make the request
            EvaluationExpectation response = await evaluationServiceClient.CreateEvaluationExpectationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationExpectation</summary>
        public void CreateEvaluationExpectation1()
        {
            // Snippet: CreateEvaluationExpectation(string, EvaluationExpectation, string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            EvaluationExpectation evaluationExpectation = new EvaluationExpectation();
            string evaluationExpectationId = "";
            // Make the request
            EvaluationExpectation response = evaluationServiceClient.CreateEvaluationExpectation(parent, evaluationExpectation, evaluationExpectationId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationExpectationAsync</summary>
        public async Task CreateEvaluationExpectation1Async()
        {
            // Snippet: CreateEvaluationExpectationAsync(string, EvaluationExpectation, string, CallSettings)
            // Additional: CreateEvaluationExpectationAsync(string, EvaluationExpectation, string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            EvaluationExpectation evaluationExpectation = new EvaluationExpectation();
            string evaluationExpectationId = "";
            // Make the request
            EvaluationExpectation response = await evaluationServiceClient.CreateEvaluationExpectationAsync(parent, evaluationExpectation, evaluationExpectationId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationExpectation</summary>
        public void CreateEvaluationExpectation1ResourceNames()
        {
            // Snippet: CreateEvaluationExpectation(AppName, EvaluationExpectation, string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            EvaluationExpectation evaluationExpectation = new EvaluationExpectation();
            string evaluationExpectationId = "";
            // Make the request
            EvaluationExpectation response = evaluationServiceClient.CreateEvaluationExpectation(parent, evaluationExpectation, evaluationExpectationId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationExpectationAsync</summary>
        public async Task CreateEvaluationExpectation1ResourceNamesAsync()
        {
            // Snippet: CreateEvaluationExpectationAsync(AppName, EvaluationExpectation, string, CallSettings)
            // Additional: CreateEvaluationExpectationAsync(AppName, EvaluationExpectation, string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            EvaluationExpectation evaluationExpectation = new EvaluationExpectation();
            string evaluationExpectationId = "";
            // Make the request
            EvaluationExpectation response = await evaluationServiceClient.CreateEvaluationExpectationAsync(parent, evaluationExpectation, evaluationExpectationId);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationExpectation</summary>
        public void CreateEvaluationExpectation2()
        {
            // Snippet: CreateEvaluationExpectation(string, EvaluationExpectation, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            EvaluationExpectation evaluationExpectation = new EvaluationExpectation();
            // Make the request
            EvaluationExpectation response = evaluationServiceClient.CreateEvaluationExpectation(parent, evaluationExpectation);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationExpectationAsync</summary>
        public async Task CreateEvaluationExpectation2Async()
        {
            // Snippet: CreateEvaluationExpectationAsync(string, EvaluationExpectation, CallSettings)
            // Additional: CreateEvaluationExpectationAsync(string, EvaluationExpectation, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            EvaluationExpectation evaluationExpectation = new EvaluationExpectation();
            // Make the request
            EvaluationExpectation response = await evaluationServiceClient.CreateEvaluationExpectationAsync(parent, evaluationExpectation);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationExpectation</summary>
        public void CreateEvaluationExpectation2ResourceNames()
        {
            // Snippet: CreateEvaluationExpectation(AppName, EvaluationExpectation, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            EvaluationExpectation evaluationExpectation = new EvaluationExpectation();
            // Make the request
            EvaluationExpectation response = evaluationServiceClient.CreateEvaluationExpectation(parent, evaluationExpectation);
            // End snippet
        }

        /// <summary>Snippet for CreateEvaluationExpectationAsync</summary>
        public async Task CreateEvaluationExpectation2ResourceNamesAsync()
        {
            // Snippet: CreateEvaluationExpectationAsync(AppName, EvaluationExpectation, CallSettings)
            // Additional: CreateEvaluationExpectationAsync(AppName, EvaluationExpectation, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            EvaluationExpectation evaluationExpectation = new EvaluationExpectation();
            // Make the request
            EvaluationExpectation response = await evaluationServiceClient.CreateEvaluationExpectationAsync(parent, evaluationExpectation);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationExpectation</summary>
        public void UpdateEvaluationExpectationRequestObject()
        {
            // Snippet: UpdateEvaluationExpectation(UpdateEvaluationExpectationRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            UpdateEvaluationExpectationRequest request = new UpdateEvaluationExpectationRequest
            {
                EvaluationExpectation = new EvaluationExpectation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EvaluationExpectation response = evaluationServiceClient.UpdateEvaluationExpectation(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationExpectationAsync</summary>
        public async Task UpdateEvaluationExpectationRequestObjectAsync()
        {
            // Snippet: UpdateEvaluationExpectationAsync(UpdateEvaluationExpectationRequest, CallSettings)
            // Additional: UpdateEvaluationExpectationAsync(UpdateEvaluationExpectationRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEvaluationExpectationRequest request = new UpdateEvaluationExpectationRequest
            {
                EvaluationExpectation = new EvaluationExpectation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EvaluationExpectation response = await evaluationServiceClient.UpdateEvaluationExpectationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationExpectation</summary>
        public void UpdateEvaluationExpectation()
        {
            // Snippet: UpdateEvaluationExpectation(EvaluationExpectation, FieldMask, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationExpectation evaluationExpectation = new EvaluationExpectation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EvaluationExpectation response = evaluationServiceClient.UpdateEvaluationExpectation(evaluationExpectation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEvaluationExpectationAsync</summary>
        public async Task UpdateEvaluationExpectationAsync()
        {
            // Snippet: UpdateEvaluationExpectationAsync(EvaluationExpectation, FieldMask, CallSettings)
            // Additional: UpdateEvaluationExpectationAsync(EvaluationExpectation, FieldMask, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationExpectation evaluationExpectation = new EvaluationExpectation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EvaluationExpectation response = await evaluationServiceClient.UpdateEvaluationExpectationAsync(evaluationExpectation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationExpectation</summary>
        public void DeleteEvaluationExpectationRequestObject()
        {
            // Snippet: DeleteEvaluationExpectation(DeleteEvaluationExpectationRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            DeleteEvaluationExpectationRequest request = new DeleteEvaluationExpectationRequest
            {
                EvaluationExpectationName = EvaluationExpectationName.FromProjectLocationAppEvaluationExpectation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_EXPECTATION]"),
                Etag = "",
            };
            // Make the request
            evaluationServiceClient.DeleteEvaluationExpectation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationExpectationAsync</summary>
        public async Task DeleteEvaluationExpectationRequestObjectAsync()
        {
            // Snippet: DeleteEvaluationExpectationAsync(DeleteEvaluationExpectationRequest, CallSettings)
            // Additional: DeleteEvaluationExpectationAsync(DeleteEvaluationExpectationRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEvaluationExpectationRequest request = new DeleteEvaluationExpectationRequest
            {
                EvaluationExpectationName = EvaluationExpectationName.FromProjectLocationAppEvaluationExpectation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_EXPECTATION]"),
                Etag = "",
            };
            // Make the request
            await evaluationServiceClient.DeleteEvaluationExpectationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationExpectation</summary>
        public void DeleteEvaluationExpectation()
        {
            // Snippet: DeleteEvaluationExpectation(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluationExpectations/[EVALUATION_EXPECTATION]";
            // Make the request
            evaluationServiceClient.DeleteEvaluationExpectation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationExpectationAsync</summary>
        public async Task DeleteEvaluationExpectationAsync()
        {
            // Snippet: DeleteEvaluationExpectationAsync(string, CallSettings)
            // Additional: DeleteEvaluationExpectationAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/evaluationExpectations/[EVALUATION_EXPECTATION]";
            // Make the request
            await evaluationServiceClient.DeleteEvaluationExpectationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationExpectation</summary>
        public void DeleteEvaluationExpectationResourceNames()
        {
            // Snippet: DeleteEvaluationExpectation(EvaluationExpectationName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluationExpectationName name = EvaluationExpectationName.FromProjectLocationAppEvaluationExpectation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_EXPECTATION]");
            // Make the request
            evaluationServiceClient.DeleteEvaluationExpectation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvaluationExpectationAsync</summary>
        public async Task DeleteEvaluationExpectationResourceNamesAsync()
        {
            // Snippet: DeleteEvaluationExpectationAsync(EvaluationExpectationName, CallSettings)
            // Additional: DeleteEvaluationExpectationAsync(EvaluationExpectationName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationExpectationName name = EvaluationExpectationName.FromProjectLocationAppEvaluationExpectation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_EXPECTATION]");
            // Make the request
            await evaluationServiceClient.DeleteEvaluationExpectationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduledEvaluationRun</summary>
        public void CreateScheduledEvaluationRunRequestObject()
        {
            // Snippet: CreateScheduledEvaluationRun(CreateScheduledEvaluationRunRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            CreateScheduledEvaluationRunRequest request = new CreateScheduledEvaluationRunRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ScheduledEvaluationRunId = "",
                ScheduledEvaluationRun = new ScheduledEvaluationRun(),
            };
            // Make the request
            ScheduledEvaluationRun response = evaluationServiceClient.CreateScheduledEvaluationRun(request);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduledEvaluationRunAsync</summary>
        public async Task CreateScheduledEvaluationRunRequestObjectAsync()
        {
            // Snippet: CreateScheduledEvaluationRunAsync(CreateScheduledEvaluationRunRequest, CallSettings)
            // Additional: CreateScheduledEvaluationRunAsync(CreateScheduledEvaluationRunRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateScheduledEvaluationRunRequest request = new CreateScheduledEvaluationRunRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                ScheduledEvaluationRunId = "",
                ScheduledEvaluationRun = new ScheduledEvaluationRun(),
            };
            // Make the request
            ScheduledEvaluationRun response = await evaluationServiceClient.CreateScheduledEvaluationRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduledEvaluationRun</summary>
        public void CreateScheduledEvaluationRun1()
        {
            // Snippet: CreateScheduledEvaluationRun(string, ScheduledEvaluationRun, string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            ScheduledEvaluationRun scheduledEvaluationRun = new ScheduledEvaluationRun();
            string scheduledEvaluationRunId = "";
            // Make the request
            ScheduledEvaluationRun response = evaluationServiceClient.CreateScheduledEvaluationRun(parent, scheduledEvaluationRun, scheduledEvaluationRunId);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduledEvaluationRunAsync</summary>
        public async Task CreateScheduledEvaluationRun1Async()
        {
            // Snippet: CreateScheduledEvaluationRunAsync(string, ScheduledEvaluationRun, string, CallSettings)
            // Additional: CreateScheduledEvaluationRunAsync(string, ScheduledEvaluationRun, string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            ScheduledEvaluationRun scheduledEvaluationRun = new ScheduledEvaluationRun();
            string scheduledEvaluationRunId = "";
            // Make the request
            ScheduledEvaluationRun response = await evaluationServiceClient.CreateScheduledEvaluationRunAsync(parent, scheduledEvaluationRun, scheduledEvaluationRunId);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduledEvaluationRun</summary>
        public void CreateScheduledEvaluationRun1ResourceNames()
        {
            // Snippet: CreateScheduledEvaluationRun(AppName, ScheduledEvaluationRun, string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            ScheduledEvaluationRun scheduledEvaluationRun = new ScheduledEvaluationRun();
            string scheduledEvaluationRunId = "";
            // Make the request
            ScheduledEvaluationRun response = evaluationServiceClient.CreateScheduledEvaluationRun(parent, scheduledEvaluationRun, scheduledEvaluationRunId);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduledEvaluationRunAsync</summary>
        public async Task CreateScheduledEvaluationRun1ResourceNamesAsync()
        {
            // Snippet: CreateScheduledEvaluationRunAsync(AppName, ScheduledEvaluationRun, string, CallSettings)
            // Additional: CreateScheduledEvaluationRunAsync(AppName, ScheduledEvaluationRun, string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            ScheduledEvaluationRun scheduledEvaluationRun = new ScheduledEvaluationRun();
            string scheduledEvaluationRunId = "";
            // Make the request
            ScheduledEvaluationRun response = await evaluationServiceClient.CreateScheduledEvaluationRunAsync(parent, scheduledEvaluationRun, scheduledEvaluationRunId);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduledEvaluationRun</summary>
        public void CreateScheduledEvaluationRun2()
        {
            // Snippet: CreateScheduledEvaluationRun(string, ScheduledEvaluationRun, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            ScheduledEvaluationRun scheduledEvaluationRun = new ScheduledEvaluationRun();
            // Make the request
            ScheduledEvaluationRun response = evaluationServiceClient.CreateScheduledEvaluationRun(parent, scheduledEvaluationRun);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduledEvaluationRunAsync</summary>
        public async Task CreateScheduledEvaluationRun2Async()
        {
            // Snippet: CreateScheduledEvaluationRunAsync(string, ScheduledEvaluationRun, CallSettings)
            // Additional: CreateScheduledEvaluationRunAsync(string, ScheduledEvaluationRun, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            ScheduledEvaluationRun scheduledEvaluationRun = new ScheduledEvaluationRun();
            // Make the request
            ScheduledEvaluationRun response = await evaluationServiceClient.CreateScheduledEvaluationRunAsync(parent, scheduledEvaluationRun);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduledEvaluationRun</summary>
        public void CreateScheduledEvaluationRun2ResourceNames()
        {
            // Snippet: CreateScheduledEvaluationRun(AppName, ScheduledEvaluationRun, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            ScheduledEvaluationRun scheduledEvaluationRun = new ScheduledEvaluationRun();
            // Make the request
            ScheduledEvaluationRun response = evaluationServiceClient.CreateScheduledEvaluationRun(parent, scheduledEvaluationRun);
            // End snippet
        }

        /// <summary>Snippet for CreateScheduledEvaluationRunAsync</summary>
        public async Task CreateScheduledEvaluationRun2ResourceNamesAsync()
        {
            // Snippet: CreateScheduledEvaluationRunAsync(AppName, ScheduledEvaluationRun, CallSettings)
            // Additional: CreateScheduledEvaluationRunAsync(AppName, ScheduledEvaluationRun, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            ScheduledEvaluationRun scheduledEvaluationRun = new ScheduledEvaluationRun();
            // Make the request
            ScheduledEvaluationRun response = await evaluationServiceClient.CreateScheduledEvaluationRunAsync(parent, scheduledEvaluationRun);
            // End snippet
        }

        /// <summary>Snippet for GetScheduledEvaluationRun</summary>
        public void GetScheduledEvaluationRunRequestObject()
        {
            // Snippet: GetScheduledEvaluationRun(GetScheduledEvaluationRunRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            GetScheduledEvaluationRunRequest request = new GetScheduledEvaluationRunRequest
            {
                ScheduledEvaluationRunName = ScheduledEvaluationRunName.FromProjectLocationAppScheduledEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[SCHEDULED_EVALUATION_RUN]"),
            };
            // Make the request
            ScheduledEvaluationRun response = evaluationServiceClient.GetScheduledEvaluationRun(request);
            // End snippet
        }

        /// <summary>Snippet for GetScheduledEvaluationRunAsync</summary>
        public async Task GetScheduledEvaluationRunRequestObjectAsync()
        {
            // Snippet: GetScheduledEvaluationRunAsync(GetScheduledEvaluationRunRequest, CallSettings)
            // Additional: GetScheduledEvaluationRunAsync(GetScheduledEvaluationRunRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetScheduledEvaluationRunRequest request = new GetScheduledEvaluationRunRequest
            {
                ScheduledEvaluationRunName = ScheduledEvaluationRunName.FromProjectLocationAppScheduledEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[SCHEDULED_EVALUATION_RUN]"),
            };
            // Make the request
            ScheduledEvaluationRun response = await evaluationServiceClient.GetScheduledEvaluationRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetScheduledEvaluationRun</summary>
        public void GetScheduledEvaluationRun()
        {
            // Snippet: GetScheduledEvaluationRun(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/scheduledEvaluationRuns/[SCHEDULED_EVALUATION_RUN]";
            // Make the request
            ScheduledEvaluationRun response = evaluationServiceClient.GetScheduledEvaluationRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetScheduledEvaluationRunAsync</summary>
        public async Task GetScheduledEvaluationRunAsync()
        {
            // Snippet: GetScheduledEvaluationRunAsync(string, CallSettings)
            // Additional: GetScheduledEvaluationRunAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/scheduledEvaluationRuns/[SCHEDULED_EVALUATION_RUN]";
            // Make the request
            ScheduledEvaluationRun response = await evaluationServiceClient.GetScheduledEvaluationRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetScheduledEvaluationRun</summary>
        public void GetScheduledEvaluationRunResourceNames()
        {
            // Snippet: GetScheduledEvaluationRun(ScheduledEvaluationRunName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ScheduledEvaluationRunName name = ScheduledEvaluationRunName.FromProjectLocationAppScheduledEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[SCHEDULED_EVALUATION_RUN]");
            // Make the request
            ScheduledEvaluationRun response = evaluationServiceClient.GetScheduledEvaluationRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetScheduledEvaluationRunAsync</summary>
        public async Task GetScheduledEvaluationRunResourceNamesAsync()
        {
            // Snippet: GetScheduledEvaluationRunAsync(ScheduledEvaluationRunName, CallSettings)
            // Additional: GetScheduledEvaluationRunAsync(ScheduledEvaluationRunName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduledEvaluationRunName name = ScheduledEvaluationRunName.FromProjectLocationAppScheduledEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[SCHEDULED_EVALUATION_RUN]");
            // Make the request
            ScheduledEvaluationRun response = await evaluationServiceClient.GetScheduledEvaluationRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListScheduledEvaluationRuns</summary>
        public void ListScheduledEvaluationRunsRequestObject()
        {
            // Snippet: ListScheduledEvaluationRuns(ListScheduledEvaluationRunsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ListScheduledEvaluationRunsRequest request = new ListScheduledEvaluationRunsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> response = evaluationServiceClient.ListScheduledEvaluationRuns(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScheduledEvaluationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScheduledEvaluationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScheduledEvaluationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScheduledEvaluationRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScheduledEvaluationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScheduledEvaluationRunsAsync</summary>
        public async Task ListScheduledEvaluationRunsRequestObjectAsync()
        {
            // Snippet: ListScheduledEvaluationRunsAsync(ListScheduledEvaluationRunsRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListScheduledEvaluationRunsRequest request = new ListScheduledEvaluationRunsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> response = evaluationServiceClient.ListScheduledEvaluationRunsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ScheduledEvaluationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScheduledEvaluationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScheduledEvaluationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScheduledEvaluationRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScheduledEvaluationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScheduledEvaluationRuns</summary>
        public void ListScheduledEvaluationRuns()
        {
            // Snippet: ListScheduledEvaluationRuns(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> response = evaluationServiceClient.ListScheduledEvaluationRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScheduledEvaluationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScheduledEvaluationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScheduledEvaluationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScheduledEvaluationRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScheduledEvaluationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScheduledEvaluationRunsAsync</summary>
        public async Task ListScheduledEvaluationRunsAsync()
        {
            // Snippet: ListScheduledEvaluationRunsAsync(string, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> response = evaluationServiceClient.ListScheduledEvaluationRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ScheduledEvaluationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScheduledEvaluationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScheduledEvaluationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScheduledEvaluationRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScheduledEvaluationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScheduledEvaluationRuns</summary>
        public void ListScheduledEvaluationRunsResourceNames()
        {
            // Snippet: ListScheduledEvaluationRuns(AppName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> response = evaluationServiceClient.ListScheduledEvaluationRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScheduledEvaluationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScheduledEvaluationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScheduledEvaluationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScheduledEvaluationRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScheduledEvaluationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScheduledEvaluationRunsAsync</summary>
        public async Task ListScheduledEvaluationRunsResourceNamesAsync()
        {
            // Snippet: ListScheduledEvaluationRunsAsync(AppName, string, int?, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> response = evaluationServiceClient.ListScheduledEvaluationRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ScheduledEvaluationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScheduledEvaluationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScheduledEvaluationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScheduledEvaluationRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScheduledEvaluationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateScheduledEvaluationRun</summary>
        public void UpdateScheduledEvaluationRunRequestObject()
        {
            // Snippet: UpdateScheduledEvaluationRun(UpdateScheduledEvaluationRunRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            UpdateScheduledEvaluationRunRequest request = new UpdateScheduledEvaluationRunRequest
            {
                ScheduledEvaluationRun = new ScheduledEvaluationRun(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ScheduledEvaluationRun response = evaluationServiceClient.UpdateScheduledEvaluationRun(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateScheduledEvaluationRunAsync</summary>
        public async Task UpdateScheduledEvaluationRunRequestObjectAsync()
        {
            // Snippet: UpdateScheduledEvaluationRunAsync(UpdateScheduledEvaluationRunRequest, CallSettings)
            // Additional: UpdateScheduledEvaluationRunAsync(UpdateScheduledEvaluationRunRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateScheduledEvaluationRunRequest request = new UpdateScheduledEvaluationRunRequest
            {
                ScheduledEvaluationRun = new ScheduledEvaluationRun(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ScheduledEvaluationRun response = await evaluationServiceClient.UpdateScheduledEvaluationRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateScheduledEvaluationRun</summary>
        public void UpdateScheduledEvaluationRun()
        {
            // Snippet: UpdateScheduledEvaluationRun(ScheduledEvaluationRun, FieldMask, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ScheduledEvaluationRun scheduledEvaluationRun = new ScheduledEvaluationRun();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ScheduledEvaluationRun response = evaluationServiceClient.UpdateScheduledEvaluationRun(scheduledEvaluationRun, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateScheduledEvaluationRunAsync</summary>
        public async Task UpdateScheduledEvaluationRunAsync()
        {
            // Snippet: UpdateScheduledEvaluationRunAsync(ScheduledEvaluationRun, FieldMask, CallSettings)
            // Additional: UpdateScheduledEvaluationRunAsync(ScheduledEvaluationRun, FieldMask, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduledEvaluationRun scheduledEvaluationRun = new ScheduledEvaluationRun();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ScheduledEvaluationRun response = await evaluationServiceClient.UpdateScheduledEvaluationRunAsync(scheduledEvaluationRun, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteScheduledEvaluationRun</summary>
        public void DeleteScheduledEvaluationRunRequestObject()
        {
            // Snippet: DeleteScheduledEvaluationRun(DeleteScheduledEvaluationRunRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            DeleteScheduledEvaluationRunRequest request = new DeleteScheduledEvaluationRunRequest
            {
                ScheduledEvaluationRunName = ScheduledEvaluationRunName.FromProjectLocationAppScheduledEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[SCHEDULED_EVALUATION_RUN]"),
                Etag = "",
            };
            // Make the request
            evaluationServiceClient.DeleteScheduledEvaluationRun(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteScheduledEvaluationRunAsync</summary>
        public async Task DeleteScheduledEvaluationRunRequestObjectAsync()
        {
            // Snippet: DeleteScheduledEvaluationRunAsync(DeleteScheduledEvaluationRunRequest, CallSettings)
            // Additional: DeleteScheduledEvaluationRunAsync(DeleteScheduledEvaluationRunRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteScheduledEvaluationRunRequest request = new DeleteScheduledEvaluationRunRequest
            {
                ScheduledEvaluationRunName = ScheduledEvaluationRunName.FromProjectLocationAppScheduledEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[SCHEDULED_EVALUATION_RUN]"),
                Etag = "",
            };
            // Make the request
            await evaluationServiceClient.DeleteScheduledEvaluationRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteScheduledEvaluationRun</summary>
        public void DeleteScheduledEvaluationRun()
        {
            // Snippet: DeleteScheduledEvaluationRun(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/scheduledEvaluationRuns/[SCHEDULED_EVALUATION_RUN]";
            // Make the request
            evaluationServiceClient.DeleteScheduledEvaluationRun(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteScheduledEvaluationRunAsync</summary>
        public async Task DeleteScheduledEvaluationRunAsync()
        {
            // Snippet: DeleteScheduledEvaluationRunAsync(string, CallSettings)
            // Additional: DeleteScheduledEvaluationRunAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/scheduledEvaluationRuns/[SCHEDULED_EVALUATION_RUN]";
            // Make the request
            await evaluationServiceClient.DeleteScheduledEvaluationRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteScheduledEvaluationRun</summary>
        public void DeleteScheduledEvaluationRunResourceNames()
        {
            // Snippet: DeleteScheduledEvaluationRun(ScheduledEvaluationRunName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            ScheduledEvaluationRunName name = ScheduledEvaluationRunName.FromProjectLocationAppScheduledEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[SCHEDULED_EVALUATION_RUN]");
            // Make the request
            evaluationServiceClient.DeleteScheduledEvaluationRun(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteScheduledEvaluationRunAsync</summary>
        public async Task DeleteScheduledEvaluationRunResourceNamesAsync()
        {
            // Snippet: DeleteScheduledEvaluationRunAsync(ScheduledEvaluationRunName, CallSettings)
            // Additional: DeleteScheduledEvaluationRunAsync(ScheduledEvaluationRunName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduledEvaluationRunName name = ScheduledEvaluationRunName.FromProjectLocationAppScheduledEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[SCHEDULED_EVALUATION_RUN]");
            // Make the request
            await evaluationServiceClient.DeleteScheduledEvaluationRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for TestPersonaVoice</summary>
        public void TestPersonaVoiceRequestObject()
        {
            // Snippet: TestPersonaVoice(TestPersonaVoiceRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            TestPersonaVoiceRequest request = new TestPersonaVoiceRequest
            {
                AppAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                PersonaId = "",
                Text = "",
            };
            // Make the request
            TestPersonaVoiceResponse response = evaluationServiceClient.TestPersonaVoice(request);
            // End snippet
        }

        /// <summary>Snippet for TestPersonaVoiceAsync</summary>
        public async Task TestPersonaVoiceRequestObjectAsync()
        {
            // Snippet: TestPersonaVoiceAsync(TestPersonaVoiceRequest, CallSettings)
            // Additional: TestPersonaVoiceAsync(TestPersonaVoiceRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            TestPersonaVoiceRequest request = new TestPersonaVoiceRequest
            {
                AppAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                PersonaId = "",
                Text = "",
            };
            // Make the request
            TestPersonaVoiceResponse response = await evaluationServiceClient.TestPersonaVoiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestPersonaVoice</summary>
        public void TestPersonaVoice()
        {
            // Snippet: TestPersonaVoice(string, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            string app = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            TestPersonaVoiceResponse response = evaluationServiceClient.TestPersonaVoice(app);
            // End snippet
        }

        /// <summary>Snippet for TestPersonaVoiceAsync</summary>
        public async Task TestPersonaVoiceAsync()
        {
            // Snippet: TestPersonaVoiceAsync(string, CallSettings)
            // Additional: TestPersonaVoiceAsync(string, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string app = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            TestPersonaVoiceResponse response = await evaluationServiceClient.TestPersonaVoiceAsync(app);
            // End snippet
        }

        /// <summary>Snippet for TestPersonaVoice</summary>
        public void TestPersonaVoiceResourceNames()
        {
            // Snippet: TestPersonaVoice(AppName, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            AppName app = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            TestPersonaVoiceResponse response = evaluationServiceClient.TestPersonaVoice(app);
            // End snippet
        }

        /// <summary>Snippet for TestPersonaVoiceAsync</summary>
        public async Task TestPersonaVoiceResourceNamesAsync()
        {
            // Snippet: TestPersonaVoiceAsync(AppName, CallSettings)
            // Additional: TestPersonaVoiceAsync(AppName, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName app = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            TestPersonaVoiceResponse response = await evaluationServiceClient.TestPersonaVoiceAsync(app);
            // End snippet
        }
    }
}
