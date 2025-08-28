# Version history

## Version 1.0.0-beta48, released 2025-08-28

### New features

- Add API response for Gen AI Evaluation in Tuning
- Add `disable_container_logging` in v1beta1 api

## Version 1.0.0-beta47, released 2025-08-14

### New features

- Add option EndpointUserId and ModelUserId fields
- Migrate dedicated endpoint to be enabled by default

### Documentation improvements

- A comment for field `dedicated_endpoint_enabled` in message `.google.cloud.aiplatform.v1beta1.DeployRequest` is changed

## Version 1.0.0-beta46, released 2025-08-13

### New features

- Add API for Gen AI Evaluation in Tuning
- Add `gpu_partition_size` to `MachineSpec`

## Version 1.0.0-beta45, released 2025-08-12

### New features

- Added document_name for vertex ai search as part of retrieved context from grounding chunk
- Expose RecommendSpecs api to vertex python SDK for Custom Weights Model deployment

## Version 1.0.0-beta44, released 2025-08-08

### New features

- Add Grounding with Google Maps tool
- Add expiration for TTL for Memory and Sessions
- Add direct_memories_source
- Add force_delete field to DeleteRagFile 'preview' API request for Vertex RAG

### Documentation improvements

- Update comment for allowed values for config models
- A comment for field `monitored_resource_labels` in message `.google.cloud.aiplatform.v1beta1.AutoscalingMetricSpec` is changed

## Version 1.0.0-beta43, released 2025-08-05

### New features

- Add embedding_metadata to google.cloud.aiplatform.v1.Index
- A new value `NVIDIA_GB200` is added to enum `AcceleratorType`
- Add exclude_domains for grounding with GoogleSearch and EnterpriseWebSearch
- Online Prediction DeployModel API to support custom metrics based autoscaling
- Add FeatureViewDirectWrite API in v1

## Version 1.0.0-beta42, released 2025-08-04

### New features

- Add field ReasoningEngineSpec.service_account
- Add field ReasoningEngine.encryption_spec
- Add `DeploymentStage` for CreateEndpointOperationMetadata and DeployModelOperationMetadata
- Add the VeoTuningSpec
- Add enable_datapoint_upsert_logging to google.cloud.aiplatform.v1.DeployedIndex
- Add a FooBar API

### Documentation improvements

- Update MutateDeployedModel documentation

## Version 1.0.0-beta41, released 2025-07-28

### New features

- Adds DWS and spot VM feature support to custom batch predictions 2.0
- Add service_account to Reasoning Engine public protos

## Version 1.0.0-beta40, released 2025-07-22

### Bug fixes

- Remove gemini_template_config and request_column_name fields from DatasetService.AssessData and DatasetService.AssembleData

## Version 1.0.0-beta39, released 2025-07-15

### New features

- Vertex AI Model Garden custom model deploy Public Preview
- Add API for Managed OSS Fine Tuning

### Documentation improvements

- A comment for field `model` in message `.google.cloud.aiplatform.v1beta1.TunedModel` is changed
- A comment for field `learning_rate_multiplier` in message `.google.cloud.aiplatform.v1beta1.SupervisedHyperParameters` is changed
- A comment for field `training_dataset_uri` in message `.google.cloud.aiplatform.v1beta1.SupervisedTuningSpec` is changed
- A comment for field `validation_dataset_uri` in message `.google.cloud.aiplatform.v1beta1.SupervisedTuningSpec` is changed

## Version 1.0.0-beta38, released 2025-07-11

### New features

- Add flexstart option to v1beta1
- Some comments changes in machine_resources.proto to v1beta1
- Add Aggregation Output in EvaluateDataset Get Operation Response

### Documentation improvements

- A comment for message `DedicatedResources` is changed
- A comment for field `machine_spec` in message `.google.cloud.aiplatform.v1beta1.DedicatedResources` is changed
- A comment for field `min_replica_count` in message `.google.cloud.aiplatform.v1beta1.DedicatedResources` is changed
- A comment for field `max_replica_count` in message `.google.cloud.aiplatform.v1beta1.DedicatedResources` is changed
- A comment for field `required_replica_count` in message `.google.cloud.aiplatform.v1beta1.DedicatedResources` is changed
- A comment for field `min_replica_count` in message `.google.cloud.aiplatform.v1beta1.AutomaticResources` is changed
- A comment for field `max_replica_count` in message `.google.cloud.aiplatform.v1beta1.AutomaticResources` is changed
- A comment for field `boot_disk_type` in message `.google.cloud.aiplatform.v1beta1.DiskSpec` is changed
- Add constraints for AggregationMetric enum and default value for flip_enabled field in AutoraterConfig

## Version 1.0.0-beta37, released 2025-07-07

### New features

- Add message ColabImage, add field colab_image to NotebookSoftwareConfig
- Allow user input for schedule_resource_name in NotebookExecutionJob
- Expose task_unique_name in pipeline task details for pipeline rerun
- Add computer use support to tools

### Documentation improvements

- A comment for message NotebookRuntime is changed
- A comment for enum value BEING_STARTED in enum NotebookRuntime.RuntimeState is changed
- A comment for message NotebookSoftwareConfig is changed

## Version 1.0.0-beta36, released 2025-06-25

### New features

- Add PSCAutomationConfig to PrivateServiceConnectConfig in service_networking.proto
- Add GenAiAdvancedFeaturesConfig to endpoint.proto
- Reasoning Engine v1beta1 subresource updates
- Add invoke_route_prefix to ModelContainerSpec in aiplatform v1beta1 models.proto

### Documentation improvements

- Update dedicateEndpointDns documentation
- Clarify that the names for sessions and session_events are no longer required.

## Version 1.0.0-beta35, released 2025-06-17

### New features

- Add DnsPeeringConfig in service_networking.proto
- Add dns_peering_configs to PscInterfaceConfig
- Add Scaled tier for RagEngineConfig to v1beta, equivalent to Enterprise
- Add Unprovisioned tier to RagEngineConfig in v1beta1 that can disable RagEngine service and delete all data within the service

### Documentation improvements

- Enterprise tier in RagEngineConfig, use Scaled tier instead.

## Version 1.0.0-beta34, released 2025-06-13

### New features

- Introduce RagFileMetadataConfig for importing metadata to Rag

## Version 1.0.0-beta33, released 2025-06-09

### New features

- Expose UrlContextMetadata API to v1beta1
- Add json schema support to structured output and function declaration
- A new field `include_thoughts` is added to message `.google.cloud.aiplatform.v1.GenerationConfig.ThinkingConfig`
- A new field `thought_signature` is added to message `.google.cloud.aiplatform.v1.Part`
- A new field `thought` is added to message `.google.cloud.aiplatform.v1.Part`
- Expose URL Context API to v1beta1

### Bug fixes

- Upgrade gRPC service registration func

### Documentation improvements

- Allow field `thought` to be set as input

## Version 1.0.0-beta32, released 2025-05-28

### New features

- Introduce RAG as context/memory store for Gemini Live API
- Add ImportIndex to IndexService

### Documentation improvements

- A comment for message `RagFileParsingConfig` is updated.
- A comment for field `global_max_embedding_requests_per_min` in message `.google.cloud.aiplatform.v1beta1.ImportRagFilesConfig` is updated.

## Version 1.0.0-beta31, released 2025-05-20

### New features

- Add VertexAISearch.max_results, filter, data_store_specs options

## Version 1.0.0-beta30, released 2025-05-19

### New features

- Add encryption_spec to Model Monitoring public preview API
- Adding thoughts_token_count to v1beta1 client library

## Version 1.0.0-beta29, released 2025-05-15

### New features

- Add checkpoint ID to endpoint proto
- Add ANN feature for RagManagedDb
- Tuning Checkpoints API
- New field `additional_properties` is added to message `.google.cloud.aiplatform.v1beta1.Schema`
- Add EncryptionSpec for RagCorpus CMEK feature
- A new value `NVIDIA_B200 & NVIDIA_H200_141GB` is added to enum `AcceleratorType`

### Documentation improvements

- Fix links and typos
- Remove comments for a non public feature

## Version 1.0.0-beta28, released 2025-05-06

### New features

- A new field `system_labels` is added to message `google.cloud.aiplatform.v1beta1.DeployRequest`

### Documentation improvements

- update an outdated URL

## Version 1.0.0-beta27, released 2025-04-30

### New features

- add gemini_request_read_config field to AssembleDataRequest and AssessDataRequest in aiplatform v1beta
- allow customers to set encryption_spec for context caching
- new fields `ref` and `defs` are added to message `.google.cloud.aiplatform.v1beta1.Schema`

### Documentation improvements

- fix comment for field_mapping field in GeminiTemplateConfig
- Deprecate election category HARM_CATEGORY_CIVIC_INTEGRITY

## Version 1.0.0-beta26, released 2025-04-29

### Bug fixes

- **BREAKING CHANGE** Removed support for session resource paths that do not include reasoning engine ([commit 3f9a249](https://github.com/googleapis/google-cloud-dotnet/commit/3f9a24942c5d487a9d5145bfb15c2fd1f9bf7572))

### New features

- Adding ThinkingConfig to v1beta1 client library ([commit fa3ad70](https://github.com/googleapis/google-cloud-dotnet/commit/fa3ad706c7956fa7f1c2fe1ebb512876d1210c15))
- Add Model Garden EULA(End User License Agreement) related APIs ([commit 3f9a249](https://github.com/googleapis/google-cloud-dotnet/commit/3f9a24942c5d487a9d5145bfb15c2fd1f9bf7572))
- Model Registry Model Checkpoint API ([commit 3f9a249](https://github.com/googleapis/google-cloud-dotnet/commit/3f9a24942c5d487a9d5145bfb15c2fd1f9bf7572))
- Deprecated EventActions.transfer_to_agent and replaced with EventActions.transfer_agent ([commit 3f9a249](https://github.com/googleapis/google-cloud-dotnet/commit/3f9a24942c5d487a9d5145bfb15c2fd1f9bf7572))

## Version 1.0.0-beta25, released 2025-04-14

### New features

- Add UpdateRagEngineConfig rpc ([commit 5f27e9d](https://github.com/googleapis/google-cloud-dotnet/commit/5f27e9daf30450d2419be4f151c151a85cf6bcd0))
- Add RagEngineConfig to specify RAG project-level config ([commit 5f27e9d](https://github.com/googleapis/google-cloud-dotnet/commit/5f27e9daf30450d2419be4f151c151a85cf6bcd0))
- Add rag_managed_db_config to RagEngineConfig for specifying Basic or Enterprise RagManagedDb tiers ([commit 5f27e9d](https://github.com/googleapis/google-cloud-dotnet/commit/5f27e9daf30450d2419be4f151c151a85cf6bcd0))
- Add global quota config to vertex rag engine api ([commit 0156095](https://github.com/googleapis/google-cloud-dotnet/commit/015609574a9ca49480434b301cd11b463b0f8eff))
- Add FeatureViewDirectWrite API ([commit 41b15c9](https://github.com/googleapis/google-cloud-dotnet/commit/41b15c999d57962e1ac94d1cf0193f09748b7ac3))
- Add Gen AI logging public preview API ([commit e0cca8f](https://github.com/googleapis/google-cloud-dotnet/commit/e0cca8f8a70e916c0c710923c7659e2816febbc8))

## Version 1.0.0-beta24, released 2025-03-31

### New features

- Add page spans in retrieved contexts from Vertex RAG Engine in aiplatform v1beta1 ([commit e03b1fc](https://github.com/googleapis/google-cloud-dotnet/commit/e03b1fc06676cff9942c71158d7978cc2890cfa0))
- Add example, example_store, and example_store_service protos ([commit e5da036](https://github.com/googleapis/google-cloud-dotnet/commit/e5da0366dc06127f27d6b24c7ce9a96e020d398f))
- Add session.proto and session_service.proto ([commit ddc4e6a](https://github.com/googleapis/google-cloud-dotnet/commit/ddc4e6af6cc0544eda61ffcde87ead0702d010a3))
- Add batch prediction assessments to multimodal dataset RPCs ([commit 6d65548](https://github.com/googleapis/google-cloud-dotnet/commit/6d65548bb5470f20484e03d66b2b4107f7eb94e1))
- Enable force deletion in ReasoningEngine v1beta1 ([commit 4acec61](https://github.com/googleapis/google-cloud-dotnet/commit/4acec61cba8af321c4872b8adaa70221e2d03944))
- Add model_config field for model selection preference ([commit 6135f3e](https://github.com/googleapis/google-cloud-dotnet/commit/6135f3e9b176b7abaae76b43b6fa463e642a08e3))

### Documentation improvements

- A comment for field `rag_files_count` in message `.google.cloud.aiplatform.v1beta1.RagCorpus` is changed ([commit e03b1fc](https://github.com/googleapis/google-cloud-dotnet/commit/e03b1fc06676cff9942c71158d7978cc2890cfa0))
- A comment for field `model_name` in message `.google.cloud.aiplatform.v1beta1.RagFileParsingConfig` is changed ([commit e03b1fc](https://github.com/googleapis/google-cloud-dotnet/commit/e03b1fc06676cff9942c71158d7978cc2890cfa0))

## Version 1.0.0-beta23, released 2025-03-24

### New features

- Update multimodal evaluation (content_map_instance), rubric generation (rubric_based_instance, etc) and raw_output(raw_output, custom_output, etc) proto change in online eval API ([commit 8f0bb30](https://github.com/googleapis/google-cloud-dotnet/commit/8f0bb30db5cd989737f0579cb8b3c126e29dc373))
- Add a ExportPublisherModel API ([commit 364b4aa](https://github.com/googleapis/google-cloud-dotnet/commit/364b4aac349cf5b6191635f32f32db8378f17d6a))
- Add AssessData and AssembleData RPCs to DatasetService ([commit 82b9306](https://github.com/googleapis/google-cloud-dotnet/commit/82b93069400563e28865fb3a8a2b33e0a1a656ed))
- Add import result gcs sink to the import files API ([commit f7a477d](https://github.com/googleapis/google-cloud-dotnet/commit/f7a477dfb73f7e38b47457daead53df8ca967179))
- Add import result bq sink to the import files API ([commit f7a477d](https://github.com/googleapis/google-cloud-dotnet/commit/f7a477dfb73f7e38b47457daead53df8ca967179))
- Add env variables and agent framework to ReasoningEngineSpec in v1beta1 ([commit ed0a196](https://github.com/googleapis/google-cloud-dotnet/commit/ed0a1961f96c15259d687191ad71300cb8b42364))

### Documentation improvements

- A comment for field `autorater_config` in message `.google.cloud.aiplatform.v1beta1.EvaluateDatasetRequest` is changed ([commit 8f0bb30](https://github.com/googleapis/google-cloud-dotnet/commit/8f0bb30db5cd989737f0579cb8b3c126e29dc373))
- A comment for field `gcs_source` in message `.google.cloud.aiplatform.v1beta1.EvaluationDataset` is changed ([commit 8f0bb30](https://github.com/googleapis/google-cloud-dotnet/commit/8f0bb30db5cd989737f0579cb8b3c126e29dc373))
- Update comment for `package_spec` from required to optional in `ReasoningEngineSpec`. ([commit ed0a196](https://github.com/googleapis/google-cloud-dotnet/commit/ed0a1961f96c15259d687191ad71300cb8b42364))
- Add `deployment_spec` and `agent_framework` field to `ReasoningEngineSpec`. ([commit ed0a196](https://github.com/googleapis/google-cloud-dotnet/commit/ed0a1961f96c15259d687191ad71300cb8b42364))

## Version 1.0.0-beta22, released 2025-03-17

### New features

- Add VertexAISearch.engine option ([commit 93bab4b](https://github.com/googleapis/google-cloud-dotnet/commit/93bab4b9bb801aa91adac8fcf023c4b8eae28de3))
- Add function_call.id and function_response.id ([commit ee278c3](https://github.com/googleapis/google-cloud-dotnet/commit/ee278c310686bc16f0acfff79bf0a078b6030e66))

## Version 1.0.0-beta21, released 2025-03-10

### New features

- Add multihost_gpu_node_count to Vertex SDK for multihost GPU support ([commit a99144f](https://github.com/googleapis/google-cloud-dotnet/commit/a99144f288e5d8c6dfafdba72c2c8cc629b73484))
- Allowing users to specify the version id of the Model Garden model ([commit 33f9df1](https://github.com/googleapis/google-cloud-dotnet/commit/33f9df1a2607447629d6edc3241b67717d3ccc91))
- Allowing users to choose whether to use the hf model cache ([commit 33f9df1](https://github.com/googleapis/google-cloud-dotnet/commit/33f9df1a2607447629d6edc3241b67717d3ccc91))

## Version 1.0.0-beta20, released 2025-03-04

### Bug fixes

- **BREAKING CHANGE** Remove VertexAISearch.engine option ([commit 18d4598](https://github.com/googleapis/google-cloud-dotnet/commit/18d4598f4fb71440f1c2b82505a0a79a7bbe3d46))

## Version 1.0.0-beta19, released 2025-03-03

### Bug fixes

- **BREAKING CHANGE** An existing google.api.http annotation `http_uri` is changed for method `DeployPublisherModel` in service `ModelGardenService` ([commit 3da797d](https://github.com/googleapis/google-cloud-dotnet/commit/3da797da48b643f96a3cd4441ea1dba7cd21a08b))

### New features

- A new field `include_equivalent_model_garden_model_deployment_configs` is added to message `.google.cloud.aiplatform.v1beta1.GetPublisherModelRequest` ([commit 3da797d](https://github.com/googleapis/google-cloud-dotnet/commit/3da797da48b643f96a3cd4441ea1dba7cd21a08b))
- Add VertexAISearch.engine option ([commit 05449f3](https://github.com/googleapis/google-cloud-dotnet/commit/05449f39c675677dc32ef63bc38a865c5d9e8f0a))
- Add EnterpriseWebSearch tool option ([commit 50d3edf](https://github.com/googleapis/google-cloud-dotnet/commit/50d3edf8b8ab7aeea9f457ed316fe42af5b93a08))

### Documentation improvements

- A comment for field `model` in message `.google.cloud.aiplatform.v1beta1.DeployPublisherModelRequest` is changed ([commit 3da797d](https://github.com/googleapis/google-cloud-dotnet/commit/3da797da48b643f96a3cd4441ea1dba7cd21a08b))

## Version 1.0.0-beta18, released 2025-02-25

### New features

- Add Model Garden deploy API ([commit 9c643e2](https://github.com/googleapis/google-cloud-dotnet/commit/9c643e2f174f62596dd09404a4c2e22e1bdfebd1))

## Version 1.0.0-beta17, released 2025-02-10

### New features

- A new field `response_id` is added to message `.google.cloud.aiplatform.v1.GenerateContentResponse` ([commit 96edae6](https://github.com/googleapis/google-cloud-dotnet/commit/96edae615ae72e283fd7bcffc73aab724a24c17e))
- A new field `create_time` is added to message `.google.cloud.aiplatform.v1.GenerateContentResponse` ([commit 96edae6](https://github.com/googleapis/google-cloud-dotnet/commit/96edae615ae72e283fd7bcffc73aab724a24c17e))
- Add Notebooks Runtime Software Configuration ([commit 40f33a4](https://github.com/googleapis/google-cloud-dotnet/commit/40f33a4326873c397b8b6ed56c8373940dfe6684))
- Add RolloutOptions to DeployedModel in v1beta1 endpoint.proto, add additional Probe options in v1beta1 model.proto ([commit aeee7bc](https://github.com/googleapis/google-cloud-dotnet/commit/aeee7bcc9bc126bbf92bebaffa135d4c68a74ca0))

### Documentation improvements

- A comment for field `filter` in message `.google.cloud.aiplatform.v1beta1.ListNotebookRuntimeTemplatesRequest` is changed ([commit 40f33a4](https://github.com/googleapis/google-cloud-dotnet/commit/40f33a4326873c397b8b6ed56c8373940dfe6684))
- A comment for field `filter` in message `.google.cloud.aiplatform.v1beta1.ListNotebookRuntimesRequest` is changed ([commit 40f33a4](https://github.com/googleapis/google-cloud-dotnet/commit/40f33a4326873c397b8b6ed56c8373940dfe6684))

## Version 1.0.0-beta16, released 2025-02-06

### New features

- EvaluateDataset API v1beta1 initial release ([commit b343f9f](https://github.com/googleapis/google-cloud-dotnet/commit/b343f9f9817575fa9968b0c8c9b25e402b91bd03))

## Version 1.0.0-beta15, released 2025-02-03

### New features

- Add rag_files_count to RagCorpus to count number of associated files ([commit 39f1a59](https://github.com/googleapis/google-cloud-dotnet/commit/39f1a590bdca3c35a42da95828480f432a56f552))
- Model Registry Checkpoint API ([commit fc5de1c](https://github.com/googleapis/google-cloud-dotnet/commit/fc5de1c17745fe36bb37ab35f9b3d0078ae5a2a2))

## Version 1.0.0-beta14, released 2025-01-27

### New features

- Remove autorater config related visibility v1beta1 ([commit 0f0bb7a](https://github.com/googleapis/google-cloud-dotnet/commit/0f0bb7ab82f229c827b611d51a08d51693f54214))
- Enable UpdateFeatureMonitor in v1beta1 API version ([commit c1ca304](https://github.com/googleapis/google-cloud-dotnet/commit/c1ca3040e3746a5da6e70caefaa9122f555d3e72))
- Add per-modality token count break downs for GenAI APIs ([commit fcf3080](https://github.com/googleapis/google-cloud-dotnet/commit/fcf3080eb36f2e6862897e433ee7dd521f2de185))
- Enable FeatureGroup IAM Methods in v1beta1 API version ([commit f74c733](https://github.com/googleapis/google-cloud-dotnet/commit/f74c73333870b89ab5f85cfedd032cb21b5f00d5))
- Add machine_spec, data_persistent_disk_spec, network_spec, euc_config, shielded_vm_config to `.google.cloud.aiplatform.v1beta1.NotebookRuntime` ([commit c1bc4e9](https://github.com/googleapis/google-cloud-dotnet/commit/c1bc4e99bf551d0a9e08eb8ade33c85845b783ec))
- Add retrieval_config to ToolConfig v1beta1 ([commit d12475e](https://github.com/googleapis/google-cloud-dotnet/commit/d12475ebe56adb1252ce21a122b41d25e8cdda89))

### Documentation improvements

- Deprecate `is_default` in message `.google.cloud.aiplatform.v1beta1.NotebookRuntimeTemplate` ([commit c1bc4e9](https://github.com/googleapis/google-cloud-dotnet/commit/c1bc4e99bf551d0a9e08eb8ade33c85845b783ec))
- Deprecate `service_account` in message `.google.cloud.aiplatform.v1beta1.NotebookRuntimeTemplate` ([commit c1bc4e9](https://github.com/googleapis/google-cloud-dotnet/commit/c1bc4e99bf551d0a9e08eb8ade33c85845b783ec))
- Deprecate `service_account` in message `.google.cloud.aiplatform.v1beta1.NotebookRuntime` ([commit c1bc4e9](https://github.com/googleapis/google-cloud-dotnet/commit/c1bc4e99bf551d0a9e08eb8ade33c85845b783ec))

## Version 1.0.0-beta13, released 2025-01-06

### New features

- Add Model Garden deploy API ([commit bc4928d](https://github.com/googleapis/google-cloud-dotnet/commit/bc4928dd78560d2cf7854bc37cb9f4f63f269cef))
- Add a new thought field in content proto ([commit f267357](https://github.com/googleapis/google-cloud-dotnet/commit/f26735783a4d532cc78c933b05a1c552ce2f6c9b))

### Documentation improvements

- A comment for field `labels` in message `.google.cloud.aiplatform.v1beta1.PublisherModel` is changed ([commit bc4928d](https://github.com/googleapis/google-cloud-dotnet/commit/bc4928dd78560d2cf7854bc37cb9f4f63f269cef))

## Version 1.0.0-beta12, released 2024-12-12

### New features

- Add LLM parser proto to API ([commit 239b1c1](https://github.com/googleapis/google-cloud-dotnet/commit/239b1c14269962f5813649a2e34c77808fdaceaf))
- Add Tool.GoogleSearch ([commit ec1d79d](https://github.com/googleapis/google-cloud-dotnet/commit/ec1d79d7d0a431eae959ffb5e25b641ab6ff08e1))
- Add GenerationConfig.Modality ([commit ec1d79d](https://github.com/googleapis/google-cloud-dotnet/commit/ec1d79d7d0a431eae959ffb5e25b641ab6ff08e1))
- Add GenerationConfig.SpeechConfig ([commit ec1d79d](https://github.com/googleapis/google-cloud-dotnet/commit/ec1d79d7d0a431eae959ffb5e25b641ab6ff08e1))
- Add GenerationConfig.MediaResolution ([commit ec1d79d](https://github.com/googleapis/google-cloud-dotnet/commit/ec1d79d7d0a431eae959ffb5e25b641ab6ff08e1))
- Enable FeatureGroup Service Account and IAM methods ([commit 6ee5a6b](https://github.com/googleapis/google-cloud-dotnet/commit/6ee5a6b34a6ab2f578644575d1de804dfa7eabc0))
- A new value `NVIDIA_H100_MEGA_80GB` is added to enum `AcceleratorType` ([commit 0ced559](https://github.com/googleapis/google-cloud-dotnet/commit/0ced559c9981dfe9edee669f822ecf476480fcdb))
- A new field `list_all_versions` to `ListPublisherModelsRequest` ([commit afd7734](https://github.com/googleapis/google-cloud-dotnet/commit/afd7734b115d6cad9ca3f094e60f08cc261c4134))

## Version 1.0.0-beta11, released 2024-12-06

### New features

- Add workbench_runtime and kernel_name to NotebookExecutionJob ([commit 83da91f](https://github.com/googleapis/google-cloud-dotnet/commit/83da91f15cab2187154bfac773124db526c1331e))
- Add new `Status` field to DeployedModel in Endpoint ([commit 5846fb6](https://github.com/googleapis/google-cloud-dotnet/commit/5846fb6f2ace37bae6ac601f24ea6d1066eaa299))
- Add new `RequiredReplicaCount` field to DedicatedResources in MachineResources ([commit 5846fb6](https://github.com/googleapis/google-cloud-dotnet/commit/5846fb6f2ace37bae6ac601f24ea6d1066eaa299))
- Support streaming and multi class methods in Reasoning Engine v1beta1 API ([commit 6bbb600](https://github.com/googleapis/google-cloud-dotnet/commit/6bbb60019830f09c06232d7388f9da86303edaae))
- Introduce HybridSearch and Ranking configuration for RAG ([commit 15ac66e](https://github.com/googleapis/google-cloud-dotnet/commit/15ac66e002b904c88f0d0026812b2d8521b92fe6))
- Introduce VertexAiSearch integration for RAG ([commit 15ac66e](https://github.com/googleapis/google-cloud-dotnet/commit/15ac66e002b904c88f0d0026812b2d8521b92fe6))
- Trajectory eval metrics added to evaluation service proto ([commit 1c70f59](https://github.com/googleapis/google-cloud-dotnet/commit/1c70f59263847378163534b32b95b82f1da3256d))
- Add CustomEnvironmentSpec to NotebookExecutionJob ([commit 92e884c](https://github.com/googleapis/google-cloud-dotnet/commit/92e884cfb7432915923e0ff27fa918cb5b173ab5))

### Documentation improvements

- A comment for field `encryption_spec` in message `.google.cloud.aiplatform.v1beta1.NotebookExecutionJob` is changed ([commit 83da91f](https://github.com/googleapis/google-cloud-dotnet/commit/83da91f15cab2187154bfac773124db526c1331e))
- A comment for field `class_method` in message `.google.cloud.aiplatform.v1beta1.StreamQueryReasoningEngineRequest` is changed (from steam_query to stream_query) ([commit d2f716f](https://github.com/googleapis/google-cloud-dotnet/commit/d2f716fe8691d4c2f79cffb692a5e197620a3c6b))
- Added support for multiple `class_methods` in QueryReasoningEngine ([commit 6bbb600](https://github.com/googleapis/google-cloud-dotnet/commit/6bbb60019830f09c06232d7388f9da86303edaae))
- Added support for StreamQueryReasoningEngine ([commit 6bbb600](https://github.com/googleapis/google-cloud-dotnet/commit/6bbb60019830f09c06232d7388f9da86303edaae))
- A comment for field `api_key_config` in message `.google.cloud.aiplatform.v1beta1.JiraSource` is changed ([commit 15ac66e](https://github.com/googleapis/google-cloud-dotnet/commit/15ac66e002b904c88f0d0026812b2d8521b92fe6))
- A comment for field `partial_failure_gcs_sink` in message `.google.cloud.aiplatform.v1beta1.ImportRagFilesConfig` is changed ([commit 15ac66e](https://github.com/googleapis/google-cloud-dotnet/commit/15ac66e002b904c88f0d0026812b2d8521b92fe6))
- A comment for field `partial_failure_bigquery_sink` in message `.google.cloud.aiplatform.v1beta1.ImportRagFilesConfig` is changed ([commit 15ac66e](https://github.com/googleapis/google-cloud-dotnet/commit/15ac66e002b904c88f0d0026812b2d8521b92fe6))
- A comment for field `rag_file_parsing_config` in message `.google.cloud.aiplatform.v1beta1.ImportRagFilesConfig` is changed ([commit 15ac66e](https://github.com/googleapis/google-cloud-dotnet/commit/15ac66e002b904c88f0d0026812b2d8521b92fe6))
- A comment for field `source_uri` in message `.google.cloud.aiplatform.v1beta1.RagContexts` is changed ([commit 15ac66e](https://github.com/googleapis/google-cloud-dotnet/commit/15ac66e002b904c88f0d0026812b2d8521b92fe6))
- Fixed typo for field `use_strict_string_match` in message `.google.cloud.aiplatform.v1beta1.ToolParameterKVMatchSpec` ([commit 1c70f59](https://github.com/googleapis/google-cloud-dotnet/commit/1c70f59263847378163534b32b95b82f1da3256d))

## Version 1.0.0-beta10, released 2024-11-18

### New features

- Add a `nfs_mounts` to RaySpec in PersistentResource API ([commit 33bbebd](https://github.com/googleapis/google-cloud-dotnet/commit/33bbebd77f62bf877e16d6c09747f1f6d3051bd4))
- Add BYOSA field to tuning_job ([commit ce4d5a1](https://github.com/googleapis/google-cloud-dotnet/commit/ce4d5a18873dc350b95d283a69f2debbc337d140))
- Add BatchCreateFeatures rpc to feature_registry_service.proto ([commit d17404c](https://github.com/googleapis/google-cloud-dotnet/commit/d17404c51f29526d3c3af4c43caad3ab948232e7))
- Add OptimizedConfig for feature_view ([commit d17404c](https://github.com/googleapis/google-cloud-dotnet/commit/d17404c51f29526d3c3af4c43caad3ab948232e7))
- Add Feature Monitoring API to Feature Store ([commit e986f24](https://github.com/googleapis/google-cloud-dotnet/commit/e986f247bdfbb86b91747dc6cc60708c229e5517))
- Add StopNotebookRuntime method ([commit efa9ded](https://github.com/googleapis/google-cloud-dotnet/commit/efa9ded7476d9c5732449fe22d6e6ec6820921ea))

### Documentation improvements

- Update feature creation message commentary ([commit e986f24](https://github.com/googleapis/google-cloud-dotnet/commit/e986f247bdfbb86b91747dc6cc60708c229e5517))

## Version 1.0.0-beta09, released 2024-10-30

### New features

- Add UpdateEndpointLongRunning API in v1beta1 version ([commit 42c90e3](https://github.com/googleapis/google-cloud-dotnet/commit/42c90e3a092a9757a6e1af1a44d9f049bb580c86))

## Version 1.0.0-beta08, released 2024-10-29

### New features

- Add fast_tryout_enabled to FasterDeploymentConfig message in aiplatform v1beta1 endpoint.proto ([commit 546a95b](https://github.com/googleapis/google-cloud-dotnet/commit/546a95bbb6816231ec35d14bd4d7aa3b2555076f))
- Add new PscInterfaceConfig field to custom_job.proto ([commit ce7c3b6](https://github.com/googleapis/google-cloud-dotnet/commit/ce7c3b6e6466f1978102ff1760f3b8f07dbbe1e0))

## Version 1.0.0-beta07, released 2024-10-21

### New features

- Add audio_timestamp to GenerationConfig ([commit dd3c974](https://github.com/googleapis/google-cloud-dotnet/commit/dd3c974dfc0838e95a943a7791207e60297f6829))
- Introduce DefaultRuntime to PipelineJob ([commit 273b397](https://github.com/googleapis/google-cloud-dotnet/commit/273b397a2e7016be42b51d343f7f1ae8f9a4439a))

### Documentation improvements

- A comment for field `partner_model_tuning_spec` in message `.google.cloud.aiplatform.v1beta1.TuningJob` is changed ([commit 2d1b3a7](https://github.com/googleapis/google-cloud-dotnet/commit/2d1b3a77a86e5a82121e487f40104bdab3645550))

## Version 1.0.0-beta06, released 2024-10-07

### New features

- Add enable_secure_private_service_connect in service attachment ([commit d90dd21](https://github.com/googleapis/google-cloud-dotnet/commit/d90dd21d5ba02c10e77c7dbb16f7338f8a66d04d))
- Add new `PscInterfaceConfig` field to `pipeline_job.proto` ([commit 92d7924](https://github.com/googleapis/google-cloud-dotnet/commit/92d79245bb9139aca60efa72bc2642131d32e982))

## Version 1.0.0-beta05, released 2024-09-30

### Bug fixes

- Annotate PipelineJob and PipelineTaskRerunConfig fields as optional ([commit 7b00bf9](https://github.com/googleapis/google-cloud-dotnet/commit/7b00bf9de9e656c3eae14474e94a411ba8dcbd12))

### New features

- Add a dynamic retrieval API ([commit 76aa5a6](https://github.com/googleapis/google-cloud-dotnet/commit/76aa5a6a4d2e7750429f18634bd550f196066c5a))

## Version 1.0.0-beta04, released 2024-09-26

### New features

- Add TunedModelRef and RebaseTunedModel Api for Vertex GenAiTuningService ([commit 7810c1b](https://github.com/googleapis/google-cloud-dotnet/commit/7810c1b37d94170c68b7df70c48617462827db7b))
- Add CIVIC_INTEGRITY category to SafetySettings for prediction service ([commit 1071ade](https://github.com/googleapis/google-cloud-dotnet/commit/1071aded4dad82414f385fb08421f5923d061eac))
- Add psc_automation_configs to DeployIndex v1beta1 ([commit 9dad2ff](https://github.com/googleapis/google-cloud-dotnet/commit/9dad2fff36902e42a0f64225b0b4a036bfedf9ce))
- Add new `PipelineTaskRerunConfig` field to `pipeline_job.proto` ([commit b748a67](https://github.com/googleapis/google-cloud-dotnet/commit/b748a6791444392ae88e47f89cf09a58c8273691))
- Expose `RuntimeArtifact` proto in `ui_pipeline_spec.proto` ([commit b748a67](https://github.com/googleapis/google-cloud-dotnet/commit/b748a6791444392ae88e47f89cf09a58c8273691))
- A new field `generation_config` is added to message `.google.cloud.aiplatform.v1beta1.CountTokensRequest` ([commit 5723ee2](https://github.com/googleapis/google-cloud-dotnet/commit/5723ee23257af6f6f0bb0c7253707e2a7f7752f1))
- A new field `labels` is added to message `.google.cloud.aiplatform.v1beta1.GenerateContentRequest` ([commit 5723ee2](https://github.com/googleapis/google-cloud-dotnet/commit/5723ee23257af6f6f0bb0c7253707e2a7f7752f1))

### Documentation improvements

- Limit comment `SupervisedTuningSpec` for 1p tuning ([commit 7810c1b](https://github.com/googleapis/google-cloud-dotnet/commit/7810c1b37d94170c68b7df70c48617462827db7b))

## Version 1.0.0-beta03, released 2024-09-16

### New features

- A new field `property_ordering` is added to message `.google.cloud.aiplatform.v1beta1.Schema` ([commit 7ff096f](https://github.com/googleapis/google-cloud-dotnet/commit/7ff096f4b8f3db5b113cffbc9e4f4515c5291830))
- Add file_id to SharePointSource ([commit 536a4cc](https://github.com/googleapis/google-cloud-dotnet/commit/536a4cc0cf5f651072a83c202e365bcefd4f9f53))
- Add share_point_sources to RagFile ([commit 536a4cc](https://github.com/googleapis/google-cloud-dotnet/commit/536a4cc0cf5f651072a83c202e365bcefd4f9f53))
- Add Pinecone and Vector Search integration for Vertex RAG ([commit a63a2f8](https://github.com/googleapis/google-cloud-dotnet/commit/a63a2f8a53f533b58112beca032acb69a6139319))
- Add share_point_sources to SharePointSources ([commit eba1f55](https://github.com/googleapis/google-cloud-dotnet/commit/eba1f554ed8f992bd272c3e31e781b40da42ff42))
- Add sharepoint_folder_path to SharePointSource ([commit eba1f55](https://github.com/googleapis/google-cloud-dotnet/commit/eba1f554ed8f992bd272c3e31e781b40da42ff42))
- Add sharepoint_folder_id to SharePointSource ([commit eba1f55](https://github.com/googleapis/google-cloud-dotnet/commit/eba1f554ed8f992bd272c3e31e781b40da42ff42))
- Add drive_name to SharePointSource ([commit eba1f55](https://github.com/googleapis/google-cloud-dotnet/commit/eba1f554ed8f992bd272c3e31e781b40da42ff42))
- Add drive_id to SharePointSource ([commit eba1f55](https://github.com/googleapis/google-cloud-dotnet/commit/eba1f554ed8f992bd272c3e31e781b40da42ff42))
- Add client_id to SharePointSource ([commit eba1f55](https://github.com/googleapis/google-cloud-dotnet/commit/eba1f554ed8f992bd272c3e31e781b40da42ff42))
- Add client_secret to SharePointSource ([commit eba1f55](https://github.com/googleapis/google-cloud-dotnet/commit/eba1f554ed8f992bd272c3e31e781b40da42ff42))
- Add tenant_id to SharePointSource ([commit eba1f55](https://github.com/googleapis/google-cloud-dotnet/commit/eba1f554ed8f992bd272c3e31e781b40da42ff42))
- Add sharepoint_site_name to SharePointSource ([commit eba1f55](https://github.com/googleapis/google-cloud-dotnet/commit/eba1f554ed8f992bd272c3e31e781b40da42ff42))
- Add share_point_sources to ImportRagFilesConfig ([commit eba1f55](https://github.com/googleapis/google-cloud-dotnet/commit/eba1f554ed8f992bd272c3e31e781b40da42ff42))
- Add partial_failure_gcs_sink tp ImportRagFilesConfig ([commit eba1f55](https://github.com/googleapis/google-cloud-dotnet/commit/eba1f554ed8f992bd272c3e31e781b40da42ff42))
- Add partial_failure_bigquery_sink to ImportRagFilesConfig ([commit eba1f55](https://github.com/googleapis/google-cloud-dotnet/commit/eba1f554ed8f992bd272c3e31e781b40da42ff42))

## Version 1.0.0-beta02, released 2024-09-09

### New features

- Add OFF to HarmBlockThreshold ([commit c4c7995](https://github.com/googleapis/google-cloud-dotnet/commit/c4c79958efd870f77504ec801cd05e2224513def))
- Add more configurability to feature_group.proto ([commit 82b085c](https://github.com/googleapis/google-cloud-dotnet/commit/82b085c0fdf3a0fdadc8bb1f555d9cb4de717c95))
- Add ragSource to feature_view.proto ([commit 82b085c](https://github.com/googleapis/google-cloud-dotnet/commit/82b085c0fdf3a0fdadc8bb1f555d9cb4de717c95))
- Add sync watermark to feature_view_sync.proto ([commit 82b085c](https://github.com/googleapis/google-cloud-dotnet/commit/82b085c0fdf3a0fdadc8bb1f555d9cb4de717c95))
- Add FLEX_START to Scheduling.strategy ([commit 6a5910f](https://github.com/googleapis/google-cloud-dotnet/commit/6a5910f8b01b13fdfb442a3d9a947cce1aba930c))
- Returns usage metadata for context caching ([commit beabf21](https://github.com/googleapis/google-cloud-dotnet/commit/beabf21077445c8f8bf1d3a86e3c7ff228e1f73e))
- Add Vector DB config for Vertex RAG (Weaviate + FeatureStore) ([commit 47a98d9](https://github.com/googleapis/google-cloud-dotnet/commit/47a98d9239cc53364b07cfaa862d2c5eed1ebce4))
- Add UpdateRagCorpus API for Vertex RAG ([commit 47a98d9](https://github.com/googleapis/google-cloud-dotnet/commit/47a98d9239cc53364b07cfaa862d2c5eed1ebce4))
- Add ApiKeyConfig field to ApiAuth ([commit 47a98d9](https://github.com/googleapis/google-cloud-dotnet/commit/47a98d9239cc53364b07cfaa862d2c5eed1ebce4))
- Add max_wait_duration to Scheduling ([commit 71cd0dd](https://github.com/googleapis/google-cloud-dotnet/commit/71cd0dd793425318b691aaea84dc05d200a42bed))

### Documentation improvements

- Fix typo in feature_online_store_admin_service.proto ([commit 82b085c](https://github.com/googleapis/google-cloud-dotnet/commit/82b085c0fdf3a0fdadc8bb1f555d9cb4de717c95))
- A comment for field `vertex_prediction_endpoint` in message `.google.cloud.aiplatform.v1beta1.RagEmbeddingModelConfig` is changed ([commit 47a98d9](https://github.com/googleapis/google-cloud-dotnet/commit/47a98d9239cc53364b07cfaa862d2c5eed1ebce4))
- A comment for field `distance` in message `.google.cloud.aiplatform.v1beta1.RagContexts` is changed ([commit 47a98d9](https://github.com/googleapis/google-cloud-dotnet/commit/47a98d9239cc53364b07cfaa862d2c5eed1ebce4))

## Version 1.0.0-beta01, released 2024-08-14

Initial release.
