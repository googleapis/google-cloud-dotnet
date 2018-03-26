// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Dlp.V2Beta1;
using Google.LongRunning;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Dlp.V2Beta1.Snippets
{
    /// <summary>Generated snippets</summary>
    public class GeneratedDlpServiceClientSnippets
    {
        /// <summary>Snippet for InspectContentAsync</summary>
        public async Task InspectContentAsync()
        {
            // Snippet: InspectContentAsync(InspectConfig,IEnumerable<ContentItem>,CallSettings)
            // Additional: InspectContentAsync(InspectConfig,IEnumerable<ContentItem>,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectConfig inspectConfig = new InspectConfig
            {
                InfoTypes = {
                                new InfoType
                                {
                                    Name = "EMAIL_ADDRESS",
                                },
                            },
            };
            IEnumerable<ContentItem> items = new[]
            {
                new ContentItem
                {
                    Type = "text/plain",
                    Value = "My email is example@example.com.",
                },
            };
            // Make the request
            InspectContentResponse response = await dlpServiceClient.InspectContentAsync(inspectConfig, items);
            // End snippet
        }

        /// <summary>Snippet for InspectContent</summary>
        public void InspectContent()
        {
            // Snippet: InspectContent(InspectConfig,IEnumerable<ContentItem>,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectConfig inspectConfig = new InspectConfig
            {
                InfoTypes = {
                                new InfoType
                                {
                                    Name = "EMAIL_ADDRESS",
                                },
                            },
            };
            IEnumerable<ContentItem> items = new[]
            {
                new ContentItem
                {
                    Type = "text/plain",
                    Value = "My email is example@example.com.",
                },
            };
            // Make the request
            InspectContentResponse response = dlpServiceClient.InspectContent(inspectConfig, items);
            // End snippet
        }

        /// <summary>Snippet for InspectContentAsync</summary>
        public async Task InspectContentAsync_RequestObject()
        {
            // Snippet: InspectContentAsync(InspectContentRequest,CallSettings)
            // Additional: InspectContentAsync(InspectContentRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectContentRequest request = new InspectContentRequest
            {
                InspectConfig = new InspectConfig
                                {
                                    InfoTypes = {
                                                    new InfoType
                                                    {
                                                        Name = "EMAIL_ADDRESS",
                                                    },
                                                },
                                },
                Items = {
                            new ContentItem
                            {
                                Type = "text/plain",
                                Value = "My email is example@example.com.",
                            },
                        },
            };
            // Make the request
            InspectContentResponse response = await dlpServiceClient.InspectContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for InspectContent</summary>
        public void InspectContent_RequestObject()
        {
            // Snippet: InspectContent(InspectContentRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectContentRequest request = new InspectContentRequest
            {
                InspectConfig = new InspectConfig
                                {
                                    InfoTypes = {
                                                    new InfoType
                                                    {
                                                        Name = "EMAIL_ADDRESS",
                                                    },
                                                },
                                },
                Items = {
                            new ContentItem
                            {
                                Type = "text/plain",
                                Value = "My email is example@example.com.",
                            },
                        },
            };
            // Make the request
            InspectContentResponse response = dlpServiceClient.InspectContent(request);
            // End snippet
        }

        /// <summary>Snippet for RedactContentAsync</summary>
        public async Task RedactContentAsync_RequestObject()
        {
            // Snippet: RedactContentAsync(RedactContentRequest,CallSettings)
            // Additional: RedactContentAsync(RedactContentRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            RedactContentRequest request = new RedactContentRequest
            {
                InspectConfig = new InspectConfig
                                {
                                    InfoTypes = {
                                                    new InfoType
                                                    {
                                                        Name = "EMAIL_ADDRESS",
                                                    },
                                                },
                                },
                Items = {
                            new ContentItem
                            {
                                Type = "text/plain",
                                Value = "My email is example@example.com.",
                            },
                        },
                ReplaceConfigs = {
                                     new RedactContentRequest.Types.ReplaceConfig
                                     {
                                         InfoType = new InfoType
                                                    {
                                                        Name = "EMAIL_ADDRESS",
                                                    },
                                         ReplaceWith = "REDACTED",
                                     },
                                 },
            };
            // Make the request
            RedactContentResponse response = await dlpServiceClient.RedactContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RedactContent</summary>
        public void RedactContent_RequestObject()
        {
            // Snippet: RedactContent(RedactContentRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            RedactContentRequest request = new RedactContentRequest
            {
                InspectConfig = new InspectConfig
                                {
                                    InfoTypes = {
                                                    new InfoType
                                                    {
                                                        Name = "EMAIL_ADDRESS",
                                                    },
                                                },
                                },
                Items = {
                            new ContentItem
                            {
                                Type = "text/plain",
                                Value = "My email is example@example.com.",
                            },
                        },
                ReplaceConfigs = {
                                     new RedactContentRequest.Types.ReplaceConfig
                                     {
                                         InfoType = new InfoType
                                                    {
                                                        Name = "EMAIL_ADDRESS",
                                                    },
                                         ReplaceWith = "REDACTED",
                                     },
                                 },
            };
            // Make the request
            RedactContentResponse response = dlpServiceClient.RedactContent(request);
            // End snippet
        }

        /// <summary>Snippet for DeidentifyContentAsync</summary>
        public async Task DeidentifyContentAsync()
        {
            // Snippet: DeidentifyContentAsync(DeidentifyConfig,InspectConfig,IEnumerable<ContentItem>,CallSettings)
            // Additional: DeidentifyContentAsync(DeidentifyConfig,InspectConfig,IEnumerable<ContentItem>,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeidentifyConfig deidentifyConfig = new DeidentifyConfig();
            InspectConfig inspectConfig = new InspectConfig();
            IEnumerable<ContentItem> items = new List<ContentItem>();
            // Make the request
            DeidentifyContentResponse response = await dlpServiceClient.DeidentifyContentAsync(deidentifyConfig, inspectConfig, items);
            // End snippet
        }

        /// <summary>Snippet for DeidentifyContent</summary>
        public void DeidentifyContent()
        {
            // Snippet: DeidentifyContent(DeidentifyConfig,InspectConfig,IEnumerable<ContentItem>,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeidentifyConfig deidentifyConfig = new DeidentifyConfig();
            InspectConfig inspectConfig = new InspectConfig();
            IEnumerable<ContentItem> items = new List<ContentItem>();
            // Make the request
            DeidentifyContentResponse response = dlpServiceClient.DeidentifyContent(deidentifyConfig, inspectConfig, items);
            // End snippet
        }

        /// <summary>Snippet for DeidentifyContentAsync</summary>
        public async Task DeidentifyContentAsync_RequestObject()
        {
            // Snippet: DeidentifyContentAsync(DeidentifyContentRequest,CallSettings)
            // Additional: DeidentifyContentAsync(DeidentifyContentRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                DeidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Items = { },
            };
            // Make the request
            DeidentifyContentResponse response = await dlpServiceClient.DeidentifyContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeidentifyContent</summary>
        public void DeidentifyContent_RequestObject()
        {
            // Snippet: DeidentifyContent(DeidentifyContentRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                DeidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Items = { },
            };
            // Make the request
            DeidentifyContentResponse response = dlpServiceClient.DeidentifyContent(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeDataSourceRiskAsync</summary>
        public async Task AnalyzeDataSourceRiskAsync()
        {
            // Snippet: AnalyzeDataSourceRiskAsync(PrivacyMetric,BigQueryTable,CallSettings)
            // Additional: AnalyzeDataSourceRiskAsync(PrivacyMetric,BigQueryTable,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            PrivacyMetric privacyMetric = new PrivacyMetric();
            BigQueryTable sourceTable = new BigQueryTable();
            // Make the request
            Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> response =
                await dlpServiceClient.AnalyzeDataSourceRiskAsync(privacyMetric, sourceTable);

            // Poll until the returned long-running operation is complete
            Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RiskAnalysisOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> retrievedResponse =
                await dlpServiceClient.PollOnceAnalyzeDataSourceRiskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RiskAnalysisOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnalyzeDataSourceRisk</summary>
        public void AnalyzeDataSourceRisk()
        {
            // Snippet: AnalyzeDataSourceRisk(PrivacyMetric,BigQueryTable,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            PrivacyMetric privacyMetric = new PrivacyMetric();
            BigQueryTable sourceTable = new BigQueryTable();
            // Make the request
            Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> response =
                dlpServiceClient.AnalyzeDataSourceRisk(privacyMetric, sourceTable);

            // Poll until the returned long-running operation is complete
            Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            RiskAnalysisOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> retrievedResponse =
                dlpServiceClient.PollOnceAnalyzeDataSourceRisk(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RiskAnalysisOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnalyzeDataSourceRiskAsync</summary>
        public async Task AnalyzeDataSourceRiskAsync_RequestObject()
        {
            // Snippet: AnalyzeDataSourceRiskAsync(AnalyzeDataSourceRiskRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeDataSourceRiskRequest request = new AnalyzeDataSourceRiskRequest
            {
                PrivacyMetric = new PrivacyMetric(),
                SourceTable = new BigQueryTable(),
            };
            // Make the request
            Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> response =
                await dlpServiceClient.AnalyzeDataSourceRiskAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RiskAnalysisOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> retrievedResponse =
                await dlpServiceClient.PollOnceAnalyzeDataSourceRiskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RiskAnalysisOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnalyzeDataSourceRisk</summary>
        public void AnalyzeDataSourceRisk_RequestObject()
        {
            // Snippet: AnalyzeDataSourceRisk(AnalyzeDataSourceRiskRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeDataSourceRiskRequest request = new AnalyzeDataSourceRiskRequest
            {
                PrivacyMetric = new PrivacyMetric(),
                SourceTable = new BigQueryTable(),
            };
            // Make the request
            Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> response =
                dlpServiceClient.AnalyzeDataSourceRisk(request);

            // Poll until the returned long-running operation is complete
            Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            RiskAnalysisOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> retrievedResponse =
                dlpServiceClient.PollOnceAnalyzeDataSourceRisk(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RiskAnalysisOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInspectOperationAsync</summary>
        public async Task CreateInspectOperationAsync()
        {
            // Snippet: CreateInspectOperationAsync(InspectConfig,StorageConfig,OutputStorageConfig,CallSettings)
            // Additional: CreateInspectOperationAsync(InspectConfig,StorageConfig,OutputStorageConfig,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            InspectConfig inspectConfig = new InspectConfig
            {
                InfoTypes = {
                                new InfoType
                                {
                                    Name = "EMAIL_ADDRESS",
                                },
                            },
            };
            StorageConfig storageConfig = new StorageConfig
            {
                CloudStorageOptions = new CloudStorageOptions
                                      {
                                          FileSet = new CloudStorageOptions.Types.FileSet
                                                    {
                                                        Url = "gs://example_bucket/example_file.png",
                                                    },
                                      },
            };
            OutputStorageConfig outputConfig = new OutputStorageConfig();
            // Make the request
            Operation<InspectOperationResult, InspectOperationMetadata> response =
                await dlpServiceClient.CreateInspectOperationAsync(inspectConfig, storageConfig, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<InspectOperationResult, InspectOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InspectOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InspectOperationResult, InspectOperationMetadata> retrievedResponse =
                await dlpServiceClient.PollOnceCreateInspectOperationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InspectOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInspectOperation</summary>
        public void CreateInspectOperation()
        {
            // Snippet: CreateInspectOperation(InspectConfig,StorageConfig,OutputStorageConfig,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            InspectConfig inspectConfig = new InspectConfig
            {
                InfoTypes = {
                                new InfoType
                                {
                                    Name = "EMAIL_ADDRESS",
                                },
                            },
            };
            StorageConfig storageConfig = new StorageConfig
            {
                CloudStorageOptions = new CloudStorageOptions
                                      {
                                          FileSet = new CloudStorageOptions.Types.FileSet
                                                    {
                                                        Url = "gs://example_bucket/example_file.png",
                                                    },
                                      },
            };
            OutputStorageConfig outputConfig = new OutputStorageConfig();
            // Make the request
            Operation<InspectOperationResult, InspectOperationMetadata> response =
                dlpServiceClient.CreateInspectOperation(inspectConfig, storageConfig, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<InspectOperationResult, InspectOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            InspectOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InspectOperationResult, InspectOperationMetadata> retrievedResponse =
                dlpServiceClient.PollOnceCreateInspectOperation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InspectOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInspectOperationAsync</summary>
        public async Task CreateInspectOperationAsync_RequestObject()
        {
            // Snippet: CreateInspectOperationAsync(CreateInspectOperationRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateInspectOperationRequest request = new CreateInspectOperationRequest
            {
                InspectConfig = new InspectConfig
                                {
                                    InfoTypes = {
                                                    new InfoType
                                                    {
                                                        Name = "EMAIL_ADDRESS",
                                                    },
                                                },
                                },
                StorageConfig = new StorageConfig
                                {
                                    CloudStorageOptions = new CloudStorageOptions
                                                          {
                                                              FileSet = new CloudStorageOptions.Types.FileSet
                                                                        {
                                                                            Url = "gs://example_bucket/example_file.png",
                                                                        },
                                                          },
                                },
                OutputConfig = new OutputStorageConfig(),
            };
            // Make the request
            Operation<InspectOperationResult, InspectOperationMetadata> response =
                await dlpServiceClient.CreateInspectOperationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InspectOperationResult, InspectOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InspectOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InspectOperationResult, InspectOperationMetadata> retrievedResponse =
                await dlpServiceClient.PollOnceCreateInspectOperationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InspectOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInspectOperation</summary>
        public void CreateInspectOperation_RequestObject()
        {
            // Snippet: CreateInspectOperation(CreateInspectOperationRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            CreateInspectOperationRequest request = new CreateInspectOperationRequest
            {
                InspectConfig = new InspectConfig
                                {
                                    InfoTypes = {
                                                    new InfoType
                                                    {
                                                        Name = "EMAIL_ADDRESS",
                                                    },
                                                },
                                },
                StorageConfig = new StorageConfig
                                {
                                    CloudStorageOptions = new CloudStorageOptions
                                                          {
                                                              FileSet = new CloudStorageOptions.Types.FileSet
                                                                        {
                                                                            Url = "gs://example_bucket/example_file.png",
                                                                        },
                                                          },
                                },
                OutputConfig = new OutputStorageConfig(),
            };
            // Make the request
            Operation<InspectOperationResult, InspectOperationMetadata> response =
                dlpServiceClient.CreateInspectOperation(request);

            // Poll until the returned long-running operation is complete
            Operation<InspectOperationResult, InspectOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            InspectOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InspectOperationResult, InspectOperationMetadata> retrievedResponse =
                dlpServiceClient.PollOnceCreateInspectOperation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InspectOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListInspectFindingsAsync</summary>
        public async Task ListInspectFindingsAsync()
        {
            // Snippet: ListInspectFindingsAsync(ResultName,CallSettings)
            // Additional: ListInspectFindingsAsync(ResultName,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResultName name = new ResultName("[RESULT]");
            // Make the request
            ListInspectFindingsResponse response = await dlpServiceClient.ListInspectFindingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListInspectFindings</summary>
        public void ListInspectFindings()
        {
            // Snippet: ListInspectFindings(ResultName,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ResultName name = new ResultName("[RESULT]");
            // Make the request
            ListInspectFindingsResponse response = dlpServiceClient.ListInspectFindings(name);
            // End snippet
        }

        /// <summary>Snippet for ListInspectFindingsAsync</summary>
        public async Task ListInspectFindingsAsync_RequestObject()
        {
            // Snippet: ListInspectFindingsAsync(ListInspectFindingsRequest,CallSettings)
            // Additional: ListInspectFindingsAsync(ListInspectFindingsRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInspectFindingsRequest request = new ListInspectFindingsRequest
            {
                ResultName = new ResultName("[RESULT]"),
            };
            // Make the request
            ListInspectFindingsResponse response = await dlpServiceClient.ListInspectFindingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListInspectFindings</summary>
        public void ListInspectFindings_RequestObject()
        {
            // Snippet: ListInspectFindings(ListInspectFindingsRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListInspectFindingsRequest request = new ListInspectFindingsRequest
            {
                ResultName = new ResultName("[RESULT]"),
            };
            // Make the request
            ListInspectFindingsResponse response = dlpServiceClient.ListInspectFindings(request);
            // End snippet
        }

        /// <summary>Snippet for ListInfoTypesAsync</summary>
        public async Task ListInfoTypesAsync()
        {
            // Snippet: ListInfoTypesAsync(string,string,CallSettings)
            // Additional: ListInfoTypesAsync(string,string,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string category = "PII";
            string languageCode = "en";
            // Make the request
            ListInfoTypesResponse response = await dlpServiceClient.ListInfoTypesAsync(category, languageCode);
            // End snippet
        }

        /// <summary>Snippet for ListInfoTypes</summary>
        public void ListInfoTypes()
        {
            // Snippet: ListInfoTypes(string,string,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string category = "PII";
            string languageCode = "en";
            // Make the request
            ListInfoTypesResponse response = dlpServiceClient.ListInfoTypes(category, languageCode);
            // End snippet
        }

        /// <summary>Snippet for ListInfoTypesAsync</summary>
        public async Task ListInfoTypesAsync_RequestObject()
        {
            // Snippet: ListInfoTypesAsync(ListInfoTypesRequest,CallSettings)
            // Additional: ListInfoTypesAsync(ListInfoTypesRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInfoTypesRequest request = new ListInfoTypesRequest
            {
                Category = "PII",
                LanguageCode = "en",
            };
            // Make the request
            ListInfoTypesResponse response = await dlpServiceClient.ListInfoTypesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListInfoTypes</summary>
        public void ListInfoTypes_RequestObject()
        {
            // Snippet: ListInfoTypes(ListInfoTypesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListInfoTypesRequest request = new ListInfoTypesRequest
            {
                Category = "PII",
                LanguageCode = "en",
            };
            // Make the request
            ListInfoTypesResponse response = dlpServiceClient.ListInfoTypes(request);
            // End snippet
        }

        /// <summary>Snippet for ListRootCategoriesAsync</summary>
        public async Task ListRootCategoriesAsync()
        {
            // Snippet: ListRootCategoriesAsync(string,CallSettings)
            // Additional: ListRootCategoriesAsync(string,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            string languageCode = "en";
            // Make the request
            ListRootCategoriesResponse response = await dlpServiceClient.ListRootCategoriesAsync(languageCode);
            // End snippet
        }

        /// <summary>Snippet for ListRootCategories</summary>
        public void ListRootCategories()
        {
            // Snippet: ListRootCategories(string,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            string languageCode = "en";
            // Make the request
            ListRootCategoriesResponse response = dlpServiceClient.ListRootCategories(languageCode);
            // End snippet
        }

        /// <summary>Snippet for ListRootCategoriesAsync</summary>
        public async Task ListRootCategoriesAsync_RequestObject()
        {
            // Snippet: ListRootCategoriesAsync(ListRootCategoriesRequest,CallSettings)
            // Additional: ListRootCategoriesAsync(ListRootCategoriesRequest,CancellationToken)
            // Create client
            DlpServiceClient dlpServiceClient = await DlpServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRootCategoriesRequest request = new ListRootCategoriesRequest
            {
                LanguageCode = "en",
            };
            // Make the request
            ListRootCategoriesResponse response = await dlpServiceClient.ListRootCategoriesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListRootCategories</summary>
        public void ListRootCategories_RequestObject()
        {
            // Snippet: ListRootCategories(ListRootCategoriesRequest,CallSettings)
            // Create client
            DlpServiceClient dlpServiceClient = DlpServiceClient.Create();
            // Initialize request argument(s)
            ListRootCategoriesRequest request = new ListRootCategoriesRequest
            {
                LanguageCode = "en",
            };
            // Make the request
            ListRootCategoriesResponse response = dlpServiceClient.ListRootCategories(request);
            // End snippet
        }

    }
}
