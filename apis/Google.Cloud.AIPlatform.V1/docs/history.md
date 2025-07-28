# Version history

## Version 3.39.0, released 2025-07-28

### New features

- Add service_account to Reasoning Engine public protos

## Version 3.38.0, released 2025-07-09

### New features

- Expose task_unique_name in pipeline task details for pipeline rerun

## Version 3.37.0, released 2025-07-07

### New features

- Add message ColabImage, add field colab_image to NotebookSoftwareConfig
- Allow user input for schedule_resource_name in NotebookExecutionJob
- Add computer use support to tools
- Add invoke_route_prefix to ModelContainerSpec in aiplatform v1 models.proto

### Documentation improvements

- A comment for message NotebookRuntime is changed
- A comment for enum value BEING_STARTED in enum NotebookRuntime.RuntimeState is changed
- A comment for message NotebookSoftwareConfig is changed

## Version 3.36.0, released 2025-06-25

### New features

- Add PSCAutomationConfig to PrivateServiceConnectConfig in service_networking.proto
- Add GenAiAdvancedFeaturesConfig to endpoint.proto
- Add Model Garden deploy OSS model API

### Documentation improvements

- Update dedicateEndpointDns documentation

## Version 3.35.0, released 2025-06-17

### New features

- Add DnsPeeringConfig in service_networking.proto
- Add dns_peering_configs to PscInterfaceConfig
- Add RagEngineConfig update/get APIs to v1
- Add Unprovisioned tier to RagEngineConfig to disable RagEngine service and delete all data within the service.

## Version 3.34.0, released 2025-06-13

### New features

- Add EncryptionSpec field for RagCorpus CMEK feature to v1

## Version 3.33.0, released 2025-06-09

### New features

- Expose UrlContextMetadata API to v1
- Add network_attachment to PscInterfaceConfig
- Add psc_interface_config to CustomJobSpec
- Add psc_interface_config to PersistentResource
- Add psc_interface_config to PipelineJob
- Add json schema support to structured output and function declaration
- Expose URL Context API to v1

### Bug fixes

- Upgrade gRPC service registration func

## Version 3.32.0, released 2025-05-29

### New features

- A new field `include_thoughts` is added to message `.google.cloud.aiplatform.v1.Part`
- A new field `thought` is added to message `.google.cloud.aiplatform.v1.Part`
- A new field `thought_signature` is added to message `.google.cloud.aiplatform.v1.GenerationConfig.ThinkingConfig`

## Version 3.31.0, released 2025-05-20

### New features

- Add VertexAISearch.max_results, filter, data_store_specs options

## Version 3.30.0, released 2025-05-19

### New features

- Adding thoughts_token_count to prediction service

## Version 3.29.0, released 2025-05-15

### New features

- Add checkpoint ID to endpoint proto
- New field `additional_properties` is added to message `.google.cloud.aiplatform.v1.Schema`
- Add ANN feature for RagManagedDb
- Tuning Checkpoints API
- A new value `NVIDIA_B200 & NVIDIA_H200_141GB` is added to enum `AcceleratorType`

## Version 3.28.0, released 2025-05-06

### New features

- Expose llm parser to public v1 proto to prepare for GA

### Documentation improvements

- update an outdated URL

## Version 3.27.0, released 2025-04-30

### New features

- allow customers to set encryption_spec for context caching
- new fields `ref` and `defs` are added to message `.google.cloud.aiplatform.v1.Schema`

### Documentation improvements

- Deprecate election category HARM_CATEGORY_CIVIC_INTEGRITY

## Version 3.26.0, released 2025-04-29

### New features

- Adding ThinkingConfig to v1 client library ([commit cb44e6e](https://github.com/googleapis/google-cloud-dotnet/commit/cb44e6e4235d928bdddf3a46172367ccc726da5b))
- Model Registry Model Checkpoint API ([commit b698c85](https://github.com/googleapis/google-cloud-dotnet/commit/b698c85f1cc0379dd5703887cfaa52fcee11139a))

## Version 3.25.0, released 2025-03-31

### New features

- Add page spans in retrieved contexts from Vertex RAG Engine in aiplatform v1 ([commit a14589e](https://github.com/googleapis/google-cloud-dotnet/commit/a14589e0d698d55b0ec3ce487077315b92acf961))
- Add support for Vertex AI Search engine ([commit 27dd031](https://github.com/googleapis/google-cloud-dotnet/commit/27dd031f9239a8318f57be843f8838c354f275a5))
- Enable force deletion in ReasoningEngine ([commit e0d55af](https://github.com/googleapis/google-cloud-dotnet/commit/e0d55af4c335ee74cd667b67cc5671cd7d793302))

## Version 3.24.0, released 2025-03-24

### New features

- Add import result gcs sink to the import files API ([commit b313b52](https://github.com/googleapis/google-cloud-dotnet/commit/b313b526fcd2fd8c71aa46904e1bb4ac36a2b351))
- Add import result bq sink to the import files API ([commit b313b52](https://github.com/googleapis/google-cloud-dotnet/commit/b313b526fcd2fd8c71aa46904e1bb4ac36a2b351))
- Add env variables and agent framework to ReasoningEngineSpec ([commit 65eb876](https://github.com/googleapis/google-cloud-dotnet/commit/65eb876885c7d19a7af9758f9588b06a93ac1385))

### Documentation improvements

- Update comment for `package_spec` from required to optional in `ReasoningEngineSpec`. ([commit 65eb876](https://github.com/googleapis/google-cloud-dotnet/commit/65eb876885c7d19a7af9758f9588b06a93ac1385))
- Add `deployment_spec` and `agent_framework` field to `ReasoningEngineSpec`. ([commit 65eb876](https://github.com/googleapis/google-cloud-dotnet/commit/65eb876885c7d19a7af9758f9588b06a93ac1385))

## Version 3.23.0, released 2025-03-17

### New features

- Add VertexAISearch.engine option ([commit 1fe1f81](https://github.com/googleapis/google-cloud-dotnet/commit/1fe1f81406fcfa5dcde96c48aed91d6c29b3bb2e))
- Add reranker config to RAG v1 API ([commit 2e97dd3](https://github.com/googleapis/google-cloud-dotnet/commit/2e97dd3f1fd45a81c0630a08c4e6f5289e97eaac))

## Version 3.22.0, released 2025-03-10

### New features

- Allowing users to specify the version id of the Model Garden model ([commit caed93e](https://github.com/googleapis/google-cloud-dotnet/commit/caed93e21d3b7227caf1f3d93bc213c02435899b))
- Allowing users to choose whether to use the hf model cache ([commit caed93e](https://github.com/googleapis/google-cloud-dotnet/commit/caed93e21d3b7227caf1f3d93bc213c02435899b))
- Add Layout Parser to RAG v1 API ([commit d85534f](https://github.com/googleapis/google-cloud-dotnet/commit/d85534fbb08fe54a671822f19c69fd9dca0b1a00))

## Version 3.21.0, released 2025-03-04

Note: the bug fix here is clearly a breaking change due to an API
publication error. We believe it is less disruptive to publish this
in a minor version (one day after the now-removed API surface was
published) than to take a new major version. Apologies if you are
disrupted by this.

### Bug fixes

- **BREAKING CHANGE** Remove VertexAISearch.engine option ([commit 966aaea](https://github.com/googleapis/google-cloud-dotnet/commit/966aaea6a4398972d2ae0ad3df399044c584ac7d))

## Version 3.20.0, released 2025-03-03

### New features

- Add VertexAISearch.engine option ([commit cffeac2](https://github.com/googleapis/google-cloud-dotnet/commit/cffeac2417604e2cce38884d322b5f40141775b8))
- Add EnterpriseWebSearch tool option ([commit 1b04726](https://github.com/googleapis/google-cloud-dotnet/commit/1b047263b3b77afdb0ee4f7c3072aaeef6070af1))

## Version 3.19.0, released 2025-02-18

### New features

- A new field `response_id` is added to message `.google.cloud.aiplatform.v1.GenerateContentResponse` ([commit 8888750](https://github.com/googleapis/google-cloud-dotnet/commit/88887505d7629bc810b57c255f0ed0133970d0a3))
- A new field `create_time` is added to message `.google.cloud.aiplatform.v1.GenerateContentResponse` ([commit 8888750](https://github.com/googleapis/google-cloud-dotnet/commit/88887505d7629bc810b57c255f0ed0133970d0a3))

## Version 3.18.0, released 2025-02-10

### New features

- Add additional Probe options to v1 model.proto ([commit 4549842](https://github.com/googleapis/google-cloud-dotnet/commit/454984226dc7e5a6c2cab2e180485c87a042475b))
- Add Notebooks Runtime Software Configuration ([commit a2ea7f4](https://github.com/googleapis/google-cloud-dotnet/commit/a2ea7f4977c825b1c8c7731d541909a9f8e01c67))

### Documentation improvements

- A comment for field `filter` in message `.google.cloud.aiplatform.v1.ListNotebookRuntimeTemplatesRequest` is changed ([commit a2ea7f4](https://github.com/googleapis/google-cloud-dotnet/commit/a2ea7f4977c825b1c8c7731d541909a9f8e01c67))
- A comment for field `filter` in message `.google.cloud.aiplatform.v1.ListNotebookRuntimesRequest` is changed ([commit a2ea7f4](https://github.com/googleapis/google-cloud-dotnet/commit/a2ea7f4977c825b1c8c7731d541909a9f8e01c67))

## Version 3.17.0, released 2025-02-06

No API surface changes; just product renaming.

## Version 3.16.0, released 2025-02-03

### New features

- Model Registry Checkpoint API ([commit 7d299ef](https://github.com/googleapis/google-cloud-dotnet/commit/7d299ef3ac6b222ee809493ed8d45731e0b859cf))
- Add optimized config in v1 API ([commit 4f583e0](https://github.com/googleapis/google-cloud-dotnet/commit/4f583e04b31270c6e10fb8e186b6b7cb0d288d16))

### Documentation improvements

- Update comments for NumericFilter and Operator ([commit 4f583e0](https://github.com/googleapis/google-cloud-dotnet/commit/4f583e04b31270c6e10fb8e186b6b7cb0d288d16))

## Version 3.15.0, released 2025-01-27

### New features

- Expose code execution tool API to v1 ([commit 211a43b](https://github.com/googleapis/google-cloud-dotnet/commit/211a43b6408ec56e1a14958606ea9501f1060e9f))
- Enable FeatureView Service Account in v1 API version ([commit 34dc1ce](https://github.com/googleapis/google-cloud-dotnet/commit/34dc1ce66d1079f9a1314a3bf4fa901d5d1655b1))
- Add per-modality token count break downs for GenAI APIs ([commit 2bcde58](https://github.com/googleapis/google-cloud-dotnet/commit/2bcde58e01cb095c711ede71c3782659ecab8083))
- Add speculative decoding spec to DeployedModel proto ([commit 82e8ed5](https://github.com/googleapis/google-cloud-dotnet/commit/82e8ed5c5884869131537c2c0ae0134410b1b2d0))
- Add machine_spec, data_persistent_disk_spec, network_spec, euc_config, shielded_vm_config to message `.google.cloud.aiplatform.v1.NotebookRuntime` ([commit 4b7f03d](https://github.com/googleapis/google-cloud-dotnet/commit/4b7f03d8c197a823ccc00b99c420de6080924318))
- Reasoning Engine v1 GAPIC release ([commit b5ac4d9](https://github.com/googleapis/google-cloud-dotnet/commit/b5ac4d90c0ce4d62c74d81b34da679f898b83bf4))
- Add retrieval_config to ToolConfig v1 ([commit bb1c6e6](https://github.com/googleapis/google-cloud-dotnet/commit/bb1c6e6d73a8a4b96956dcf454d3d6fe588c468b))

### Documentation improvements

- Deprecate `is_default` in message `.google.cloud.aiplatform.v1.NotebookRuntimeTemplate` ([commit 4b7f03d](https://github.com/googleapis/google-cloud-dotnet/commit/4b7f03d8c197a823ccc00b99c420de6080924318))
- Deprecate `service_account` in message `.google.cloud.aiplatform.v1.NotebookRuntimeTemplate` ([commit 4b7f03d](https://github.com/googleapis/google-cloud-dotnet/commit/4b7f03d8c197a823ccc00b99c420de6080924318))
- Deprecate `service_account` in message `.google.cloud.aiplatform.v1.NotebookRuntime` ([commit 4b7f03d](https://github.com/googleapis/google-cloud-dotnet/commit/4b7f03d8c197a823ccc00b99c420de6080924318))

## Version 3.14.0, released 2025-01-13

### New features

- Add Context Cache to v1 ([commit 9997d14](https://github.com/googleapis/google-cloud-dotnet/commit/9997d14f4a344d1bff059fec85eb0b5cda081efc))

## Version 3.13.0, released 2024-12-12

### New features

- A new value `NVIDIA_H100_MEGA_80GB` is added to enum `AcceleratorType` ([commit 1bb5a2d](https://github.com/googleapis/google-cloud-dotnet/commit/1bb5a2d2aded81918b6f3141f00cfd4e31a5ab02))

## Version 3.12.0, released 2024-12-06

### New features

- Add workbench_runtime and kernel_name to NotebookExecutionJob ([commit 5835c7c](https://github.com/googleapis/google-cloud-dotnet/commit/5835c7cc3e9ed46f05a7c9d19a69de19c4aaf334))
- Add new `Status` field to DeployedModel in Endpoint ([commit 4226ced](https://github.com/googleapis/google-cloud-dotnet/commit/4226ced8c84e3f401404225b46a0708cb34250f6))
- Add new `RequiredReplicaCount` field to DedicatedResources in MachineResources ([commit 4226ced](https://github.com/googleapis/google-cloud-dotnet/commit/4226ced8c84e3f401404225b46a0708cb34250f6))
- Add Vertex RAG service proto to v1 ([commit ebf9b3f](https://github.com/googleapis/google-cloud-dotnet/commit/ebf9b3fb51cfe13b68fd35c467c57125523c1ddf))
- Add a v1 UpdateEndpointLongRunning API ([commit 69c07c0](https://github.com/googleapis/google-cloud-dotnet/commit/69c07c0d7ae57a1e045affd11300246b81108e6e))
- Add CustomEnvironmentSpec to NotebookExecutionJob ([commit 39afa50](https://github.com/googleapis/google-cloud-dotnet/commit/39afa501f82de87c2b2149f2e9d6d3d6703272b3))

### Documentation improvements

- A comment for field `encryption_spec` in message `.google.cloud.aiplatform.v1.NotebookExecutionJob` is changed ([commit 5835c7c](https://github.com/googleapis/google-cloud-dotnet/commit/5835c7cc3e9ed46f05a7c9d19a69de19c4aaf334))

## Version 3.11.0, released 2024-11-18

### New features

- Add fast_tryout_enabled to FasterDeploymentConfig v1 proto ([commit 25d598b](https://github.com/googleapis/google-cloud-dotnet/commit/25d598b66734afa0e1a390f4ced86b76f3f6bd15))
- COMET added to evaluation service proto ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- MetricX added to evaluation service proto ([commit ed0bd17](https://github.com/googleapis/google-cloud-dotnet/commit/ed0bd176aaaa1a542a6f55eac0a7583a6242b4f9))
- Add BYOSA field to tuning_job ([commit f223db7](https://github.com/googleapis/google-cloud-dotnet/commit/f223db7a4c84b46e59eb13f47f2f081981ff39a6))
- Added support for specifying function response type in FunctionDeclaration ([commit feb4c6f](https://github.com/googleapis/google-cloud-dotnet/commit/feb4c6f65f6ea97d5a0558ab03202d28537f3866))
- Add BatchCreateFeatures rpc to feature_registry_service.proto ([commit 319b9ab](https://github.com/googleapis/google-cloud-dotnet/commit/319b9ab8b26a4e38c292d5daf6fed58d4de01036))
- Add system labels field to model garden deployments ([commit 7329429](https://github.com/googleapis/google-cloud-dotnet/commit/73294293202ded12bfb8595d196bae1dcc55a09a))
- Add StopNotebookRuntime method ([commit d01775a](https://github.com/googleapis/google-cloud-dotnet/commit/d01775adf7c31fb526857f96074ac6717799c8e0))

### Documentation improvements

- A comment for field `saved_query_id` in message `.google.cloud.aiplatform.v1.ExportDataConfig` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `annotation_schema_uri` in message `.google.cloud.aiplatform.v1.ExportDataConfig` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `predictions` in message `.google.cloud.aiplatform.v1.EvaluatedAnnotation` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `attributions` in message `.google.cloud.aiplatform.v1.Explanation` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for message `DeleteFeatureViewRequest` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `page_token` in message `.google.cloud.aiplatform.v1.ListFeatureGroupsRequest` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for message `StreamingReadFeatureValuesRequest` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for message `DeleteEntityTypeRequest` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `page_token` in message `.google.cloud.aiplatform.v1.ListTuningJobsRequest` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `deployed_index` in message `.google.cloud.aiplatform.v1.MutateDeployedIndexRequest` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `request` in message `.google.cloud.aiplatform.v1.BatchMigrateResourcesOperationMetadata` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `data_stats` in message `.google.cloud.aiplatform.v1.Model` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `enable_logging` in message `.google.cloud.aiplatform.v1.ModelMonitoringAlertConfig` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `page_token` in message `.google.cloud.aiplatform.v1.ListNotebookExecutionJobsRequest` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `next_page_token` in message `.google.cloud.aiplatform.v1.ListNotebookExecutionJobsResponse` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for message `ListPersistentResourcesRequest` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `page_token` in message `.google.cloud.aiplatform.v1.ListPersistentResourcesRequest` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for method `ResumeSchedule` in service `ScheduleService` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `bool_val` in message `.google.cloud.aiplatform.v1.Tensor` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `string_val` in message `.google.cloud.aiplatform.v1.Tensor` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `bytes_val` in message `.google.cloud.aiplatform.v1.Tensor` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `float_val` in message `.google.cloud.aiplatform.v1.Tensor` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `double_val` in message `.google.cloud.aiplatform.v1.Tensor` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `int_val` in message `.google.cloud.aiplatform.v1.Tensor` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `int64_val` in message `.google.cloud.aiplatform.v1.Tensor` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `uint_val` in message `.google.cloud.aiplatform.v1.Tensor` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `uint64_val` in message `.google.cloud.aiplatform.v1.Tensor` is changed ([commit 02fa803](https://github.com/googleapis/google-cloud-dotnet/commit/02fa8030f6a38fa1a07c42fb2c35e0bdcd8f2678))
- A comment for field `timeout` in message `.google.cloud.aiplatform.v1.Scheduling` is changed ([commit ed0bd17](https://github.com/googleapis/google-cloud-dotnet/commit/ed0bd176aaaa1a542a6f55eac0a7583a6242b4f9))
- A comment for field `restart_job_on_worker_restart` in message `.google.cloud.aiplatform.v1.Scheduling` is changed ([commit ed0bd17](https://github.com/googleapis/google-cloud-dotnet/commit/ed0bd176aaaa1a542a6f55eac0a7583a6242b4f9))
- A comment for method `ListAnnotations` in service `DatasetService` is changed ([commit ed0bd17](https://github.com/googleapis/google-cloud-dotnet/commit/ed0bd176aaaa1a542a6f55eac0a7583a6242b4f9))
- A comment for message `GetDatasetRequest` is changed ([commit ed0bd17](https://github.com/googleapis/google-cloud-dotnet/commit/ed0bd176aaaa1a542a6f55eac0a7583a6242b4f9))
- A comment for message `GetDatasetVersionRequest` is changed ([commit ed0bd17](https://github.com/googleapis/google-cloud-dotnet/commit/ed0bd176aaaa1a542a6f55eac0a7583a6242b4f9))
- A comment for field `update_mask` in message `.google.cloud.aiplatform.v1.UpdateFeatureViewRequest` is changed ([commit ed0bd17](https://github.com/googleapis/google-cloud-dotnet/commit/ed0bd176aaaa1a542a6f55eac0a7583a6242b4f9))
- A comment for method `RebaseTunedModel` in service `GenAiTuningService` is changed ([commit ed0bd17](https://github.com/googleapis/google-cloud-dotnet/commit/ed0bd176aaaa1a542a6f55eac0a7583a6242b4f9))
- Updated the maximum number of function declarations from 64 to 128 ([commit feb4c6f](https://github.com/googleapis/google-cloud-dotnet/commit/feb4c6f65f6ea97d5a0558ab03202d28537f3866))
- A comment for field `feature_group_id` in message `.google.cloud.aiplatform.v1.CreateFeatureGroupRequest` is changed ([commit 319b9ab](https://github.com/googleapis/google-cloud-dotnet/commit/319b9ab8b26a4e38c292d5daf6fed58d4de01036))
- A comment for message `BatchCreateFeaturesRequest` is modified to call out BatchCreateFeatures ([commit 319b9ab](https://github.com/googleapis/google-cloud-dotnet/commit/319b9ab8b26a4e38c292d5daf6fed58d4de01036))

## Version 3.10.0, released 2024-10-29

### New features

- Add `text` field for Grounding metadata support chunk output ([commit d09eec7](https://github.com/googleapis/google-cloud-dotnet/commit/d09eec728557c8fc8062c7c574367f34e7578b93))

## Version 3.9.0, released 2024-10-07

### New features

- Add a dynamic retrieval API ([commit 39346c1](https://github.com/googleapis/google-cloud-dotnet/commit/39346c19aabf3069615026f5f668d04e41a370ca))
- Add continuous sync option in feature_view.proto ([commit de039c0](https://github.com/googleapis/google-cloud-dotnet/commit/de039c0d341ff01cae7af23cabf9759140795d60))
- Add psc_automation_configs to DeployIndex v1 ([commit 100ccd6](https://github.com/googleapis/google-cloud-dotnet/commit/100ccd6f0f9db723c786b231e931866f84536e23))

## Version 3.8.0, released 2024-09-26

### New features

- Add TunedModelRef and RebaseTunedModel Api for Vertex GenAiTuningService ([commit d139bd8](https://github.com/googleapis/google-cloud-dotnet/commit/d139bd8d89a9d80965eaa7b011edee608266b622))
- Add CIVIC_INTEGRITY category to SafetySettings for prediction service ([commit bfe994b](https://github.com/googleapis/google-cloud-dotnet/commit/bfe994b519b81d40c1352093956be04b0517d4f8))
- A new field `generation_config` is added to message `.google.cloud.aiplatform.v1.CountTokensRequest` ([commit ba7bd07](https://github.com/googleapis/google-cloud-dotnet/commit/ba7bd0711d214682c47fe867a28fea446ecffa96))
- A new field `labels` is added to message `.google.cloud.aiplatform.v1.GenerateContentRequest` ([commit ba7bd07](https://github.com/googleapis/google-cloud-dotnet/commit/ba7bd0711d214682c47fe867a28fea446ecffa96))
- A new field `property_ordering` is added to message `.google.cloud.aiplatform.v1.Schema` ([commit eda71ab](https://github.com/googleapis/google-cloud-dotnet/commit/eda71ab7b64b017de6b983a80a48ae4b04609de8))

### Documentation improvements

- Limit comment `SupervisedTuningSpec` for 1p tuning ([commit d139bd8](https://github.com/googleapis/google-cloud-dotnet/commit/d139bd8d89a9d80965eaa7b011edee608266b622))

## Version 3.7.0, released 2024-09-09

### New features

- Add OFF to HarmBlockThreshold ([commit bba431e](https://github.com/googleapis/google-cloud-dotnet/commit/bba431edd175a9a968164a02868ee80027576cdb))
- Add more configurability to feature_group.proto ([commit fa557a4](https://github.com/googleapis/google-cloud-dotnet/commit/fa557a4671ef84bae4b7f5d4772ba249117c372f))
- Add ragSource to feature_view.proto ([commit fa557a4](https://github.com/googleapis/google-cloud-dotnet/commit/fa557a4671ef84bae4b7f5d4772ba249117c372f))
- Add sync watermark to feature_view_sync.proto ([commit fa557a4](https://github.com/googleapis/google-cloud-dotnet/commit/fa557a4671ef84bae4b7f5d4772ba249117c372f))
- Add FLEX_START to Scheduling.strategy ([commit 971a41a](https://github.com/googleapis/google-cloud-dotnet/commit/971a41a3c707eab021f60fd026812c29de19a371))
- Add v1 NotebookExecutionJob to Schedule ([commit 8774035](https://github.com/googleapis/google-cloud-dotnet/commit/877403533fc9c890a9d2c9b217e48c4fb2bbc15e))
- Add max_wait_duration to Scheduling ([commit 20099e6](https://github.com/googleapis/google-cloud-dotnet/commit/20099e6810cb3f67476284df526071a441861883))

### Documentation improvements

- Fix typo in feature_online_store_admin_service.proto ([commit fa557a4](https://github.com/googleapis/google-cloud-dotnet/commit/fa557a4671ef84bae4b7f5d4772ba249117c372f))

## Version 3.6.0, released 2024-08-13

### New features

- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.BatchPredictionJob` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.BatchPredictionJob` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new message `RoutingConfig` is added ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `seed` is added to message `.google.cloud.aiplatform.v1.GenerationConfig` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `routing_config` is added to message `.google.cloud.aiplatform.v1.GenerationConfig` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `avg_logprobs` is added to message `.google.cloud.aiplatform.v1.Candidate` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.CustomJob` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.CustomJob` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.DataItem` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.DataItem` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.Dataset` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.Dataset` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.DatasetVersion` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.DatasetVersion` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.DeploymentResourcePool` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.DeploymentResourcePool` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.EntityType` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.EntityType` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new message `TimeSeries` is added ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `time_series` is added to message `.google.cloud.aiplatform.v1.FeatureGroup` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.FeatureOnlineStore` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.FeatureOnlineStore` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.FeatureView` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.FeatureView` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.FeatureViewSync` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.FeatureViewSync` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.Featurestore` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.Featurestore` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.HyperparameterTuningJob` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.HyperparameterTuningJob` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.Index` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.Index` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.IndexEndpoint` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.IndexEndpoint` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `hugging_face_token` is added to message `.google.cloud.aiplatform.v1.GetPublisherModelRequest` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.NasJob` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.NasJob` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `encryption_spec` is added to message `.google.cloud.aiplatform.v1.NotebookExecutionJob` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `sample_request` is added to message `.google.cloud.aiplatform.v1.PublisherModel` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new resource_definition `compute.googleapis.com/NetworkAttachment` is added ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `service_attachment` is added to message `.google.cloud.aiplatform.v1.PrivateServiceConnectConfig` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `total_truncated_example_count` is added to message `.google.cloud.aiplatform.v1.SupervisedTuningDataStats` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A new field `truncated_example_indices` is added to message `.google.cloud.aiplatform.v1.SupervisedTuningDataStats` ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- Allow v1 api calls for some dataset_service, llm_utility_service, and prediction_service apis without project and location ([commit e0ad69c](https://github.com/googleapis/google-cloud-dotnet/commit/e0ad69ccc9f3e98a9de3bf2d91716070d157e407))
- Add evaluation service proto to v1 ([commit 40a4eac](https://github.com/googleapis/google-cloud-dotnet/commit/40a4eac882cf2e612d0e8ea606d0a7ca359050ce))
- Add reservation affinity proto ([commit 4f76ad8](https://github.com/googleapis/google-cloud-dotnet/commit/4f76ad81c9813dc842688e930cae5fbb197a46bc))
- Add spot field to Vertex Prediction's Dedicated Resources and Custom Training's Scheduling Strategy ([commit 4f76ad8](https://github.com/googleapis/google-cloud-dotnet/commit/4f76ad81c9813dc842688e930cae5fbb197a46bc))

### Documentation improvements

- A comment for enum value `STOP` in enum `FinishReason` is changed ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A comment for enum value `MAX_TOKENS` in enum `FinishReason` is changed ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A comment for enum value `SAFETY` in enum `FinishReason` is changed ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A comment for enum value `RECITATION` in enum `FinishReason` is changed ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A comment for enum value `OTHER` in enum `FinishReason` is changed ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A comment for enum value `BLOCKLIST` in enum `FinishReason` is changed ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A comment for enum value `PROHIBITED_CONTENT` in enum `FinishReason` is changed ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A comment for enum value `SPII` in enum `FinishReason` is changed ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A comment for enum `Strategy` is changed ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A comment for enum value `STRATEGY_UNSPECIFIED` in enum `Strategy` is changed ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A comment for field `model` in message `.google.cloud.aiplatform.v1.GenerateContentRequest` is changed ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- A comment for enum value `AUTO` in enum `Mode` is changed ([commit c372e3f](https://github.com/googleapis/google-cloud-dotnet/commit/c372e3f4404df1f257779d2544a93d8a24fbbfa0))
- Update the description for the deprecated GPU (K80) ([commit 4f76ad8](https://github.com/googleapis/google-cloud-dotnet/commit/4f76ad81c9813dc842688e930cae5fbb197a46bc))

## Version 3.5.0, released 2024-07-29

### New features

- A new field `score` is added to message `.google.cloud.aiplatform.v1.Candidate` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new message `Segment` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new message `GroundingChunk` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new message `GroundingSupport` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `grounding_chunks` is added to message `.google.cloud.aiplatform.v1.GroundingMetadata` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `grounding_supports` is added to message `.google.cloud.aiplatform.v1.GroundingMetadata` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new enum `Strategy` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `strategy` is added to message `.google.cloud.aiplatform.v1.Scheduling` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `dedicated_endpoint_enabled` is added to message `.google.cloud.aiplatform.v1.Endpoint` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `dedicated_endpoint_dns` is added to message `.google.cloud.aiplatform.v1.Endpoint` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `satisfies_pzs` is added to message `.google.cloud.aiplatform.v1.Endpoint` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `satisfies_pzi` is added to message `.google.cloud.aiplatform.v1.Endpoint` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new message `NumericFilter` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `numeric_filters` is added to message `.google.cloud.aiplatform.v1.NearestNeighborQuery` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `is_hugging_face_model` is added to message `.google.cloud.aiplatform.v1.GetPublisherModelRequest` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new message `NotebookExecutionJob` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new resource_definition `aiplatform.googleapis.com/NotebookExecutionJob` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new method `CreateNotebookExecutionJob` is added to service `NotebookService` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new method `GetNotebookExecutionJob` is added to service `NotebookService` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new method `ListNotebookExecutionJobs` is added to service `NotebookService` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new method `DeleteNotebookExecutionJob` is added to service `NotebookService` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new enum `NotebookExecutionJobView` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new message `CreateNotebookExecutionJobRequest` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new message `CreateNotebookExecutionJobOperationMetadata` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new message `GetNotebookExecutionJobRequest` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new message `ListNotebookExecutionJobsRequest` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new message `ListNotebookExecutionJobsResponse` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new message `DeleteNotebookExecutionJobRequest` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `ray_logs_spec` is added to message `.google.cloud.aiplatform.v1.RaySpec` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new message `RayLogsSpec` is added ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `system_instruction` is added to message `.google.cloud.aiplatform.v1.CountTokensRequest` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `tools` is added to message `.google.cloud.aiplatform.v1.CountTokensRequest` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `billable_sum` is added to message `.google.cloud.aiplatform.v1.SupervisedTuningDatasetDistribution` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new field `total_billable_token_count` is added to message `.google.cloud.aiplatform.v1.SupervisedTuningDataStats` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A new value `ADAPTER_SIZE_THIRTY_TWO` is added to enum `AdapterSize` ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))

### Documentation improvements

- A comment for field `name` in message `.google.cloud.aiplatform.v1.Dataset` is changed ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A comment for field `name` in message `.google.cloud.aiplatform.v1.DatasetVersion` is changed ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A comment for field `update_mask` in message `.google.cloud.aiplatform.v1.UpdateFeatureOnlineStoreRequest` is changed ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A comment for field `update_mask` in message `.google.cloud.aiplatform.v1.UpdateFeatureViewRequest` is changed ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A comment for field `update_mask` in message `.google.cloud.aiplatform.v1.UpdateFeatureGroupRequest` is changed ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A comment for field `update_mask` in message `.google.cloud.aiplatform.v1.UpdateFeatureRequest` is changed ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A comment for field `language_code` in message `.google.cloud.aiplatform.v1.GetPublisherModelRequest` is changed ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A comment for field `model` in message `.google.cloud.aiplatform.v1.CountTokensRequest` is changed ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A comment for field `instances` in message `.google.cloud.aiplatform.v1.CountTokensRequest` is changed ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A comment for field `contents` in message `.google.cloud.aiplatform.v1.CountTokensRequest` is changed ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A comment for message `TrialContext` is changed ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))
- A comment for field `disable_attribution` in message `.google.cloud.aiplatform.v1.Retrieval` is changed ([commit 0a28ce6](https://github.com/googleapis/google-cloud-dotnet/commit/0a28ce62eac697ca772aa0d34e55faec1c4cd33b))

## Version 3.4.0, released 2024-07-08

### New features

- Add model and contents fields to ComputeTokensRequest v1 ([commit 03a2748](https://github.com/googleapis/google-cloud-dotnet/commit/03a27482e0eb99b6cb57bea3bf4e8ddfb44b2df8))
- Add role field to TokensInfo v1 ([commit 03a2748](https://github.com/googleapis/google-cloud-dotnet/commit/03a27482e0eb99b6cb57bea3bf4e8ddfb44b2df8))

## Version 3.3.0, released 2024-07-01

### New features

- Add UpdateDeploymentResourcePool method to DeploymentResourcePoolService v1 ([commit 66af553](https://github.com/googleapis/google-cloud-dotnet/commit/66af5538e93ab19a2de6b1d640c4b61c040585e2))
- Add private_service_connect_config and service_attachment fields to DedicatedServingEndpoint v1 ([commit 66af553](https://github.com/googleapis/google-cloud-dotnet/commit/66af5538e93ab19a2de6b1d640c4b61c040585e2))
- Add satisfies_pzs and satisfies_pzi fields to Model v1 ([commit 66af553](https://github.com/googleapis/google-cloud-dotnet/commit/66af5538e93ab19a2de6b1d640c4b61c040585e2))
- Add deploy_metadata to PublisherModel.Deploy v1 ([commit 66af553](https://github.com/googleapis/google-cloud-dotnet/commit/66af5538e93ab19a2de6b1d640c4b61c040585e2))
- Add satisfies_pzs and satisfies_pzi fields to Tensorboard v1 ([commit 66af553](https://github.com/googleapis/google-cloud-dotnet/commit/66af5538e93ab19a2de6b1d640c4b61c040585e2))

### Documentation improvements

- Update comments of AutoscalingSpec v1 ([commit 66af553](https://github.com/googleapis/google-cloud-dotnet/commit/66af5538e93ab19a2de6b1d640c4b61c040585e2))

## Version 3.2.0, released 2024-06-24

### New features

- Add MALFORMED_FUNCTION_CALL to FinishReason ([commit 7e31c25](https://github.com/googleapis/google-cloud-dotnet/commit/7e31c25d0fa8eb19d26835bab8f12b6da839b68f))
- Add preflight_validations to PipelineJob ([commit 7e31c25](https://github.com/googleapis/google-cloud-dotnet/commit/7e31c25d0fa8eb19d26835bab8f12b6da839b68f))
- Add encryption_spec to TuningJob ([commit 7e31c25](https://github.com/googleapis/google-cloud-dotnet/commit/7e31c25d0fa8eb19d26835bab8f12b6da839b68f))

## Version 3.1.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 3.0.0, released 2024-05-31

### Bug fixes

- **BREAKING CHANGE** An existing message `Segment` is removed ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- **BREAKING CHANGE** An existing message `GroundingAttribution` is removed ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- **BREAKING CHANGE** An existing field `grounding_attributions` is removed from message `.google.cloud.aiplatform.v1beta1.GroundingMetadata` ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- **BREAKING CHANGE** An existing field `disable_attribution` is removed from message `.google.cloud.aiplatform.v1beta1.GoogleSearchRetrieval` ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))

### New features

- Add ValueType.STRUCT to Feature ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add encryption_spec to FeatureOnlineStore ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add struct_value to FeatureValue ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add encryption_spec, service_account, disable_container_logging to DeploymentResourcePool ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add model_reference to Dataset ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add tool_config to GenerateContentRequest ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add dataplex_config to MetadataStore ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add model_reference to DatasetVersion ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add INVALID_SPARSE_DIMENSIONS, INVALID_SPARSE_EMBEDDING, INVALID_EMBEDDING to NearestNeighborSearchOperationMetadata.RecordError ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add valid_sparse_record_count, invalid_sparse_record_count to NearestNeighborSearchOperationMetadata.ContentValidationStats ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add sparse_embedding to IndexDatapoint ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add sparse_vectors_count to IndexStats ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add sparse_distance to FindNeighborsResponse.Neighbor ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add more fields in FindNeighborsRequest.Query ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add UpdateNotebookRuntimeTemplate to NotebookService ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add direct_notebook_source to NotebookExecutionJob ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add encryption_spec to NotebookRuntimeTemplate ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add idle_shutdown_config, encryption_spec, satisfies_pzs, satisfies_pzi to NotebookRuntime ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- Add RaySpec to PersistentResource ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))

### Documentation improvements

- A comment for field `feature_vector` in message `.google.cloud.aiplatform.v1beta1.IndexDatapoint` is changed ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- A comment for field `vectors_count` in message `.google.cloud.aiplatform.v1beta1.IndexStats` is changed ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- A comment for enum value `EMBEDDING_SIZE_MISMATCH` in enum `RecordErrorType` is changed ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))
- A comment for field `exec` in message `.google.cloud.aiplatform.v1beta1.Probe` is changed ([commit 73f03ff](https://github.com/googleapis/google-cloud-dotnet/commit/73f03ff83f7f7adb3b72809b9cc2875312ec8c81))

## Version 2.28.0, released 2024-05-08

### New features

- A new value `TPU_V5_LITEPOD` is added to enum `AcceleratorType` ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- A new field `search_entry_point` is added to message `.google.cloud.aiplatform.v1.GroundingMetadata` ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- A new message `SearchEntryPoint` is added ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- A new field `private_service_connect_config` is added to message `.google.cloud.aiplatform.v1.Endpoint` ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- A new value `INVALID_TOKEN_VALUE` is added to enum `RecordErrorType` ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- A new field `deploy_task_name` is added to message `.google.cloud.aiplatform.v1.PublisherModel` ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

### Documentation improvements

- A comment for field `parent` in message `.google.cloud.aiplatform.v1.CreateFeatureGroupRequest` is changed ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- A comment for field `name` in message `.google.cloud.aiplatform.v1.NotebookRuntimeTemplate` is changed ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- A comment for field `base_model` in message `.google.cloud.aiplatform.v1.TuningJob` is changed ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- A comment for field `tuned_model_display_name` in message `.google.cloud.aiplatform.v1.TuningJob` is changed ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- A comment for field `epoch_count` in message `.google.cloud.aiplatform.v1.SupervisedHyperParameters` is changed ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- A comment for field `learning_rate_multiplier` in message `.google.cloud.aiplatform.v1.SupervisedHyperParameters` is changed ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- A comment for field `training_dataset_uri` in message `.google.cloud.aiplatform.v1.SupervisedTuningSpec` is changed ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))
- A comment for field `validation_dataset_uri` in message `.google.cloud.aiplatform.v1.SupervisedTuningSpec` is changed ([commit 988b653](https://github.com/googleapis/google-cloud-dotnet/commit/988b65358899ac8a04d9104642c363ec3ae57f95))

## Version 2.27.0, released 2024-04-19

### New features

- GenAiTuningService aiplatform v1 initial release ([commit 9c1510e](https://github.com/googleapis/google-cloud-dotnet/commit/9c1510eb266a9c55c8b555c2408f8112883aa078))
- A new field `presence_penalty` is added to message `.google.cloud.aiplatform.v1.GenerationConfig` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `frequency_penalty` is added to message `.google.cloud.aiplatform.v1.GenerationConfig` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `response_mime_type` is added to message `.google.cloud.aiplatform.v1.GenerationConfig` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new enum `HarmBlockMethod` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `method` is added to message `.google.cloud.aiplatform.v1.SafetySetting` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `persistent_resource_id` is added to message `.google.cloud.aiplatform.v1.CustomJobSpec` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `disable_explanations` is added to message `.google.cloud.aiplatform.v1.DeployedModel` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `title` is added to message `.google.cloud.aiplatform.v1.Schema` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `default` is added to message `.google.cloud.aiplatform.v1.Schema` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `min_items` is added to message `.google.cloud.aiplatform.v1.Schema` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `max_items` is added to message `.google.cloud.aiplatform.v1.Schema` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `min_properties` is added to message `.google.cloud.aiplatform.v1.Schema` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `max_properties` is added to message `.google.cloud.aiplatform.v1.Schema` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `minimum` is added to message `.google.cloud.aiplatform.v1.Schema` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `maximum` is added to message `.google.cloud.aiplatform.v1.Schema` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `min_length` is added to message `.google.cloud.aiplatform.v1.Schema` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `max_length` is added to message `.google.cloud.aiplatform.v1.Schema` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `pattern` is added to message `.google.cloud.aiplatform.v1.Schema` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `PersistentResource` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new resource_definition `aiplatform.googleapis.com/PersistentResource` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `ResourcePool` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `ResourceRuntimeSpec` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `RaySpec` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `ResourceRuntime` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `ServiceAccountSpec` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new service `PersistentResourceService` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `CreatePersistentResourceRequest` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `CreatePersistentResourceOperationMetadata` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `UpdatePersistentResourceOperationMetadata` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `RebootPersistentResourceOperationMetadata` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `GetPersistentResourceRequest` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `ListPersistentResourcesRequest` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `ListPersistentResourcesResponse` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `DeletePersistentResourceRequest` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `UpdatePersistentResourceRequest` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new message `RebootPersistentResourceRequest` is added ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new field `system_instruction` is added to message `.google.cloud.aiplatform.v1.GenerateContentRequest` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new value `BLOCKLIST` is added to enum `BlockedReason` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- A new value `PROHIBITED_CONTENT` is added to enum `BlockedReason` ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))
- Add NotebookRuntime resource and APIs to public v1 client library ([commit 4c42095](https://github.com/googleapis/google-cloud-dotnet/commit/4c4209583e0c903f524cc9ceebbd20136be2335f))

### Documentation improvements

- Documentation updates ([commit 8629568](https://github.com/googleapis/google-cloud-dotnet/commit/8629568d46593d443aa4df6fe00cad2bad9cb0ab))

## Version 2.26.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))
- Add Optimized feature store proto ([commit a6e68f0](https://github.com/googleapis/google-cloud-dotnet/commit/a6e68f0a3dfeebe9c73ad415478efd5ed91a8e46))
- Add data_key field in feature online store service ([commit a6e68f0](https://github.com/googleapis/google-cloud-dotnet/commit/a6e68f0a3dfeebe9c73ad415478efd5ed91a8e46))
- Add dedicated_serving_endpoint ([commit a6e68f0](https://github.com/googleapis/google-cloud-dotnet/commit/a6e68f0a3dfeebe9c73ad415478efd5ed91a8e46))
- Add index_config field ([commit a6e68f0](https://github.com/googleapis/google-cloud-dotnet/commit/a6e68f0a3dfeebe9c73ad415478efd5ed91a8e46))

## Version 2.25.0, released 2024-03-21

### New features

- A new value `NVIDIA_H100_80GB` is added to enum `AcceleratorType` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new enum `HarmSeverity` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new field `probability_score` is added to message `.google.cloud.aiplatform.v1.SafetyRating` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new field `severity` is added to message `.google.cloud.aiplatform.v1.SafetyRating` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new field `severity_score` is added to message `.google.cloud.aiplatform.v1.SafetyRating` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new value `BLOCKLIST` is added to enum `FinishReason` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new value `PROHIBITED_CONTENT` is added to enum `FinishReason` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new value `SPII` is added to enum `FinishReason` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new field `grounding_metadata` is added to message `.google.cloud.aiplatform.v1.Candidate` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `Segment` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `GroundingAttribution` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `GroundingMetadata` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new field `display_name` is added to message `.google.cloud.aiplatform.v1.DatasetVersion` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new field `metadata` is added to message `.google.cloud.aiplatform.v1.DatasetVersion` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new field `project_number` is added to message `.google.cloud.aiplatform.v1.FeatureView` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `SyncSummary` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new field `sync_summary` is added to message `.google.cloud.aiplatform.v1.FeatureViewSync` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new value `NOT_EQUAL` is added to enum `Operator` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `BaseModelSource` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new field `base_model_source` is added to message `.google.cloud.aiplatform.v1.Model` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `ModelGardenSource` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `GenieSource` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new method `BatchDeletePipelineJobs` is added to service `PipelineService` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new method `BatchCancelPipelineJobs` is added to service `PipelineService` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `BatchCancelPipelineJobsOperationMetadata` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `BatchDeletePipelineJobsRequest` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `BatchDeletePipelineJobsResponse` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `BatchCancelPipelineJobsRequest` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `BatchCancelPipelineJobsResponse` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new field `retrieval` is added to message `.google.cloud.aiplatform.v1.Tool` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new field `google_search_retrieval` is added to message `.google.cloud.aiplatform.v1.Tool` ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `Retrieval` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `VertexAISearch` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))
- A new message `GoogleSearchRetrieval` is added ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))

### Documentation improvements

- Various documentation improvements ([commit 4c7dfcf](https://github.com/googleapis/google-cloud-dotnet/commit/4c7dfcf7d26b5e51f96fc650a70789ff128cbec2))

## Version 2.24.0, released 2024-02-27

### New features

- Add CompositeKey message and composite_key field to FeatureViewDataKey ([commit 0fd7d02](https://github.com/googleapis/google-cloud-dotnet/commit/0fd7d02fcb8b65b4f5213936ed99a30002759b8b))
- Add `point_of_contact` to `Feature` message ([commit d4ab784](https://github.com/googleapis/google-cloud-dotnet/commit/d4ab784aa1a32cc3b4fa4fbf20c13f6a5e838f9e))

## Version 2.23.0, released 2024-02-12

Note: including a breaking change in a minor version is highly
unusual, and violates Semantic Versioning. We have chosen to do so
for this release, as the property in question
(`Scheduling.MaxWaitDuration`) was introduced less than two weeks
before this release. We don't expect this removal to affect many
customers (if any), whereas a new major version would call for due
diligence of *all* customers. We believe violating Semantic
Versioning will therefore be less disruptive for customers overall.
We do not take Semantic Versioning violations lightly, and would
welcome feedback if this decision has caused you any problems.

### Bug fixes

- **BREAKING CHANGE** Remove field `max_wait_duration` from message Scheduling ([commit 61d419e](https://github.com/googleapis/google-cloud-dotnet/commit/61d419ed90fb29d73368d56f898db3e74e81aaac))

### New features

- Add psc_automated_endpoints to IndexPrivateEndpoints ([commit 61d419e](https://github.com/googleapis/google-cloud-dotnet/commit/61d419ed90fb29d73368d56f898db3e74e81aaac))
- Add request_response_logging_schema_version to ModelDeploymentMonitoringBigQueryTable ([commit 61d419e](https://github.com/googleapis/google-cloud-dotnet/commit/61d419ed90fb29d73368d56f898db3e74e81aaac))
- Add resource_title, resource_use_case, resource_description to RegionalResourceReferences ([commit 61d419e](https://github.com/googleapis/google-cloud-dotnet/commit/61d419ed90fb29d73368d56f898db3e74e81aaac))
- Add deploy_gke, open_tine_tuning_pipelines, open_notebooks to CallToAction ([commit 61d419e](https://github.com/googleapis/google-cloud-dotnet/commit/61d419ed90fb29d73368d56f898db3e74e81aaac))

### Documentation improvements

- Deprecate use_case and description in ResourceReference ([commit 61d419e](https://github.com/googleapis/google-cloud-dotnet/commit/61d419ed90fb29d73368d56f898db3e74e81aaac))
- Minor changes to comments ([commit 61d419e](https://github.com/googleapis/google-cloud-dotnet/commit/61d419ed90fb29d73368d56f898db3e74e81aaac))

## Version 2.22.0, released 2024-02-08

### New features

- Add SearchNearestEntities rpc to FeatureOnlineStoreService in aiplatform v1 ([commit 2572a76](https://github.com/googleapis/google-cloud-dotnet/commit/2572a7605aaf4d4270ef12d900e4580c6ad08ff8))
- Add generateContent Unary API for aiplatform_v1 ([commit d0ece95](https://github.com/googleapis/google-cloud-dotnet/commit/d0ece9564685912690966b80fb05b533ca2ae3b8))

### Documentation improvements

- Update comment for DirectPredict and DirectRawPredict ([commit d0ece95](https://github.com/googleapis/google-cloud-dotnet/commit/d0ece9564685912690966b80fb05b533ca2ae3b8))

## Version 2.21.0, released 2024-01-31

### New features

- Add models to CustomJobSpec
- Add Content
- Add ExportUse and ExportFilterSplit to Dataset
- Add data_stats to ExportDataResponse
- Add display_name to DeployedIndex
- Add DeploymentResourcePool
- Add DeploymentResourcePoolService
- Add shared_resources to DeployedModel
- Add DataStats to Model
- Add model and contents to PredictionService
- Add Tool
- Add data_stats to Model
- Add data_stats to ExportDataResponse
- Add filter_split to ExportDataConfig
- Add saved_query_id to ExportDataConfig
- Add annotation_schema_uri to ExportDataConfig
- Add export_use to ExportDataConfig
- Add grpc_ports to UploadModel ModelContainerSpec
- Add DirectPredict to PredictionService
- Add DirectRawPredict to PredictionService
- Add StreamingPredict to PredictionService.
- Add StreamingRawPredict to PredictionService.
- Add deployment_timeout to UploadModel ModelContainerSpec
- Add shared_memory_size_mb to UploadModel ModelContainerSpec
- Add startup_probe, health_probe to UploadModel ModelContainerSpec
- Add protected_artifact_location_id to CustomJob
- Add value_type, version_column_name to Feature
- Add FeatureGroup, FeatureOnlineStore, FeatureOnlineStoreAdminService, FeatureOnlineStoreService, FeatureRegistryService, FeatureView, FeatureViewSync
- Add NumericRestriction to Index
- Add tpu_topology to MachineSpec
- Add CountTokensRequest to PredictionService
- Add StudyTimeConstraint to Study
- Add ComputeTokens and CountTokens API

### Documentation improvements

- Add comments for FeatureOnlineStoreService and ModelMonitoringAlertConfig
- Update exported_files description in ExportDataResponse

## Version 2.20.0, released 2023-10-26

### New features

- Add DatasetVersion and dataset version RPCs to DatasetService ([commit fe2818c](https://github.com/googleapis/google-cloud-dotnet/commit/fe2818c21082a33ec5a8ee8f74e99628bee9333e))
- Add PersistentDiskSpec ([commit fe2818c](https://github.com/googleapis/google-cloud-dotnet/commit/fe2818c21082a33ec5a8ee8f74e99628bee9333e))

## Version 2.19.0, released 2023-09-11

### New features

- Add encryption_spec to index.proto and index_endpoint.proto ([commit e03e41b](https://github.com/googleapis/google-cloud-dotnet/commit/e03e41b4698958ed0b42e3fb4233ad89985196a2))
- Add TrialContext to study.proto ([commit e03e41b](https://github.com/googleapis/google-cloud-dotnet/commit/e03e41b4698958ed0b42e3fb4233ad89985196a2))
- Add contexts to SuggestTrialsRequest in vizier_service.proto ([commit e03e41b](https://github.com/googleapis/google-cloud-dotnet/commit/e03e41b4698958ed0b42e3fb4233ad89985196a2))

## Version 2.18.0, released 2023-08-16

### New features

- Update field_behavior for `name` to be IMMUTABLE instead of OUTPUT_ONLY in Context, ModelMonitor, Schedule, DeploymentResourcePool ([commit 67e1930](https://github.com/googleapis/google-cloud-dotnet/commit/67e1930923029f84aab0fe7d0d60bf744a94f099))
- Expose CreateDatasetVersionOperationMetadata and RestoreDatasetVersionOperationMetadata to DatasetService ([commit 67e1930](https://github.com/googleapis/google-cloud-dotnet/commit/67e1930923029f84aab0fe7d0d60bf744a94f099))
- Add disk_type and disk_size_gb to PersistentDiskSpec ([commit 67e1930](https://github.com/googleapis/google-cloud-dotnet/commit/67e1930923029f84aab0fe7d0d60bf744a94f099))
- Add schedule_name to PipelineJob ([commit 67e1930](https://github.com/googleapis/google-cloud-dotnet/commit/67e1930923029f84aab0fe7d0d60bf744a94f099))
- Add open_evaluation_pipeline to PublisherModel ([commit 67e1930](https://github.com/googleapis/google-cloud-dotnet/commit/67e1930923029f84aab0fe7d0d60bf744a94f099))
- Add ReadTensorboardSize to TensorboardService ([commit 67e1930](https://github.com/googleapis/google-cloud-dotnet/commit/67e1930923029f84aab0fe7d0d60bf744a94f099))

## Version 2.17.0, released 2023-08-04

### New features

- Add `PredictionService.ServerStreamingPredict` method ([commit 48c78fe](https://github.com/googleapis/google-cloud-dotnet/commit/48c78fe766c4163c6cd9e2726e9a35583ddd6dda))
- Add `StreamingPredictRequest` type ([commit 48c78fe](https://github.com/googleapis/google-cloud-dotnet/commit/48c78fe766c4163c6cd9e2726e9a35583ddd6dda))
- Add `StreamingPredictResponse` type ([commit 48c78fe](https://github.com/googleapis/google-cloud-dotnet/commit/48c78fe766c4163c6cd9e2726e9a35583ddd6dda))
- Add `Tensor` type ([commit 48c78fe](https://github.com/googleapis/google-cloud-dotnet/commit/48c78fe766c4163c6cd9e2726e9a35583ddd6dda))
- ScheduleService (schedule_service.proto) creates and manages Schedule resources to launch scheduled pipelines runs ([commit dc5bfd6](https://github.com/googleapis/google-cloud-dotnet/commit/dc5bfd69d99d3e8b0290656645c7fba0acd2718e))
- Schedule (schedule.proto) periodically schedules runs to make API calls ([commit dc5bfd6](https://github.com/googleapis/google-cloud-dotnet/commit/dc5bfd69d99d3e8b0290656645c7fba0acd2718e))
- Add data_item_count to Dataset ([commit 445fa0e](https://github.com/googleapis/google-cloud-dotnet/commit/445fa0e87ace33fa1fee4c90a4a531fee6a9456c))
- Add DeleteSavedQuery to DatasetService ([commit 445fa0e](https://github.com/googleapis/google-cloud-dotnet/commit/445fa0e87ace33fa1fee4c90a4a531fee6a9456c))
- Add JOB_STATE_PARTIALLY_SUCCEEDED to JobState ([commit 445fa0e](https://github.com/googleapis/google-cloud-dotnet/commit/445fa0e87ace33fa1fee4c90a4a531fee6a9456c))
- Add pipeline_job to Model ([commit 445fa0e](https://github.com/googleapis/google-cloud-dotnet/commit/445fa0e87ace33fa1fee4c90a4a531fee6a9456c))
- Add reserved_ip_ranges to PipelineJob ([commit 445fa0e](https://github.com/googleapis/google-cloud-dotnet/commit/445fa0e87ace33fa1fee4c90a4a531fee6a9456c))

## Version 2.16.0, released 2023-06-20

### New features

- Add UpdateExplanationDataset to aiplatform ([commit 8a49530](https://github.com/googleapis/google-cloud-dotnet/commit/8a49530dc8ab6b000c2063b1a4c9385cc1b139f8))
- Add NVIDIA_A100_80GB to AcceleratorType ([commit 8bed9db](https://github.com/googleapis/google-cloud-dotnet/commit/8bed9dbdf9786825c3ab885a32e99d0f49ea6026))
- Add blocking_operation_ids to ImportFeatureValuesOperationMetadata ([commit 8bed9db](https://github.com/googleapis/google-cloud-dotnet/commit/8bed9dbdf9786825c3ab885a32e99d0f49ea6026))
- Support for Model Garden -- A single place to search, discover, and interact with a wide variety of foundation models from Google and Google partners, available on Vertex AI ([commit 617cfa1](https://github.com/googleapis/google-cloud-dotnet/commit/617cfa127c0a381dafd046b2fbb60d245dc12a39))

## Version 2.15.0, released 2023-05-23

### New features

- Add match service in aiplatform v1 ([commit 7fa56aa](https://github.com/googleapis/google-cloud-dotnet/commit/7fa56aa6604cfeb78597c7799e3d9ea10a39e4a7))
- Add examples to ExplanationParameters in aiplatform v1 explanation.proto ([commit 0ec8cc2](https://github.com/googleapis/google-cloud-dotnet/commit/0ec8cc2caa812e2a879687d0ba2150806b42078a))

## Version 2.14.0, released 2023-05-03

### New features

- Add NVIDIA_L4 to AcceleratorType ([commit 1a69433](https://github.com/googleapis/google-cloud-dotnet/commit/1a694333f553a44b96d342049495250b75c15ff8))
- Add experiment and experiment_run to CustomJobSpec ([commit 1a69433](https://github.com/googleapis/google-cloud-dotnet/commit/1a694333f553a44b96d342049495250b75c15ff8))
- Add MutateDeployedModel RPC to endpoint_service ([commit 1a69433](https://github.com/googleapis/google-cloud-dotnet/commit/1a694333f553a44b96d342049495250b75c15ff8))
- Add offline_storage_ttl_days to EntityType ([commit 1a69433](https://github.com/googleapis/google-cloud-dotnet/commit/1a694333f553a44b96d342049495250b75c15ff8))
- Add online_storage_ttl_days to FeatureStore ([commit 1a69433](https://github.com/googleapis/google-cloud-dotnet/commit/1a694333f553a44b96d342049495250b75c15ff8))
- Add GENIE to ModelSourceType ([commit 1a69433](https://github.com/googleapis/google-cloud-dotnet/commit/1a694333f553a44b96d342049495250b75c15ff8))

## Version 2.13.0, released 2023-04-19

### New features

- Add is_default to Tensorboard in aiplatform v1 tensorboard.proto and v1beta1 tensorboard.proto ([commit 0fe126a](https://github.com/googleapis/google-cloud-dotnet/commit/0fe126af822d5691488387da74cccb9650040d5e))

## Version 2.12.0, released 2023-04-12

### New features

- Add public_endpoint_enabled and publid_endpoint_domain_name to IndexEndpoint ([commit 6456df3](https://github.com/googleapis/google-cloud-dotnet/commit/6456df3710bf03715fd60988726c5fc75e76747d))
- Add ModelSourceType.MODEL_GARDEN enum to ModelSourceInfo ([commit 6456df3](https://github.com/googleapis/google-cloud-dotnet/commit/6456df3710bf03715fd60988726c5fc75e76747d))
- Add copy to ModelSourceInfo ([commit 6456df3](https://github.com/googleapis/google-cloud-dotnet/commit/6456df3710bf03715fd60988726c5fc75e76747d))

## Version 2.11.0, released 2023-03-06

### New features

- Add disable_container_logging to BatchPredictionJob in aiplatform v1,v1beta1 batch_prediction_job.proto ([commit 368e543](https://github.com/googleapis/google-cloud-dotnet/commit/368e543246160ac767770be0ea4ec89feb6e62d1))
- Add TPU_V4_POD to AcceleratorType in aiplatform v1 accelerator_type.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add split to ExportDataConfig in aiplatform v1 dataset.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add offline_storage_ttl_days to EntityType in aiplatform v1 entity_type.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add evaluated_annotation.proto to aiplatform v1 ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add cpu_utilization_target to Featurestore.OnlineServingConfig.Scaling in aiplatform v1 featurestore.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add online_storage_ttl_days to Featurestore in aiplatform v1 featurestore.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add slice_spec to ModelEvaluationSlice in aiplatform v1 model_evaluation_slice.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add BatchImportEvaluatedAnnotations rpc to aiplatform v1 model_service.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))

## Version 2.10.0, released 2023-02-08

### New features

- Add service_networking.proto to aiplatform v1 ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add private_service_connect_config to IndexEndpoint in aiplatform v1 index_endpoint.proto ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add nas_job.proto to aiplatform v1 ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add CreateNasJob, GetNasJob, ListNasJobs, DeleteNasJob, CancelNasJob, GetNasTrialDetail, ListNasTrialDetails RPCs to aiplatform v1 job_service.proto ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add original_model_info to Model in aiplatform v1 model.proto ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add CopyModel RPC to aiplatform v1 model_service.proto ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add failed_jobs to CustomJobDetail to aiplatform v1 pipeline_job.proto ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add safety_config to StudySpec in aiplatform v1 study.proto ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))

## Version 2.9.0, released 2023-01-18

### New features

- Add enable_dashboard_access in aiplatform v1 and v1beta1 ([commit 5eef07b](https://github.com/googleapis/google-cloud-dotnet/commit/5eef07bfa85941015645598a0df3362e7db55378))

## Version 2.8.0, released 2023-01-16

### New features

- Add instance_config to BatchPredictionJob in aiplatform v1 batch_prediction_job.proto ([commit f868bc8](https://github.com/googleapis/google-cloud-dotnet/commit/f868bc8f601d12499c7212b0b992ea205fe310f3))
- Add saved_queries to Dataset in aiplatform v1 dataset.proto ([commit e7acad2](https://github.com/googleapis/google-cloud-dotnet/commit/e7acad20e505522f02023821ee133cc48ad8205c))
- Add order_by to ListModelVersionRequest in aiplatform v1 model_service.proto ([commit e7acad2](https://github.com/googleapis/google-cloud-dotnet/commit/e7acad20e505522f02023821ee133cc48ad8205c))
- Add update_all_stopped_trials to ConvexAutomatedStoppingSpec in aiplatform v1 study.proto ([commit e7acad2](https://github.com/googleapis/google-cloud-dotnet/commit/e7acad20e505522f02023821ee133cc48ad8205c))
- Add ReadTensorboardUsage rpc in aiplatform v1 tensorboard_service.proto ([commit e7acad2](https://github.com/googleapis/google-cloud-dotnet/commit/e7acad20e505522f02023821ee133cc48ad8205c))

## Version 2.7.0, released 2022-12-14

### New features

- Add service_account to UploadModelRequest in aiplatform v1 model_service.proto ([commit d2f3215](https://github.com/googleapis/google-cloud-dotnet/commit/d2f32151d16303b4684188ca44e19ba6c115ee5d))
- Add SearchDataItems RPC in aiplatform version v1 and v1beta1 dataset_service.proto ([commit c44d0dc](https://github.com/googleapis/google-cloud-dotnet/commit/c44d0dc34e3d22c26c2edd1eef2df32ea7f6d4e9))

## Version 2.6.0, released 2022-12-01

### New features

- Add metadata_artifact to Dataset in aiplatform v1 dataset.proto ([commit 7f369da](https://github.com/googleapis/google-cloud-dotnet/commit/7f369dafdab8345660654a36e08ecfb53664518a))
- Add WriteFeatureValues rpc to FeaturestoreOnlineServingService in aiplatform v1 featurestore_online_service.proto ([commit 7f369da](https://github.com/googleapis/google-cloud-dotnet/commit/7f369dafdab8345660654a36e08ecfb53664518a))
- Add service_account to batch_prediction_job in aiplatform v1 batch_prediction_job.proto ([commit 047a19c](https://github.com/googleapis/google-cloud-dotnet/commit/047a19c79d0d9ef0c63d596aa0088bac4f9f5a58))

## Version 2.5.0, released 2022-11-10

### New features

- Add annotation_labels to ImportDataConfig in aiplatform v1 dataset.proto ([commit f94d859](https://github.com/googleapis/google-cloud-dotnet/commit/f94d8598ffce8de96037023be374fef58e528061))
- Add start_time to BatchReadFeatureValuesRequest in aiplatform v1 featurestore_service.proto ([commit f94d859](https://github.com/googleapis/google-cloud-dotnet/commit/f94d8598ffce8de96037023be374fef58e528061))
- Add metadata_artifact to Model in aiplatform v1 model.proto ([commit f94d859](https://github.com/googleapis/google-cloud-dotnet/commit/f94d8598ffce8de96037023be374fef58e528061))
- Add failed_main_jobs and failed_pre_caching_check_jobs to ContainerDetail in aiplatform v1 pipeline_job.proto ([commit f94d859](https://github.com/googleapis/google-cloud-dotnet/commit/f94d8598ffce8de96037023be374fef58e528061))
- Add persist_ml_use_assignment to InputDataConfig in aiplatform v1 training_pipeline.proto ([commit f94d859](https://github.com/googleapis/google-cloud-dotnet/commit/f94d8598ffce8de96037023be374fef58e528061))

## Version 2.4.0, released 2022-10-03

### New features

- Add model_source_info to Model in aiplatform v1 model.proto ([commit 52a99e7](https://github.com/googleapis/google-cloud-dotnet/commit/52a99e7720eb6eb1328746a500c1354ce48948fc))
- Add timestamp_outside_retention_rows_count to ImportFeatureValuesResponse and ImportFeatureValuesOperationMetadata in aiplatform v1 featurestore_service.proto ([commit 093a3f1](https://github.com/googleapis/google-cloud-dotnet/commit/093a3f1a3ea1e44cdb2dc558113cee303208f2ff))
- Add RemoveContextChildren rpc to aiplatform v1 metadata_service.proto ([commit 093a3f1](https://github.com/googleapis/google-cloud-dotnet/commit/093a3f1a3ea1e44cdb2dc558113cee303208f2ff))
- Add order_by to ListArtifactsRequest, ListContextsRequest, and ListExecutionsRequest in aiplatform v1 metadata_service.proto ([commit 093a3f1](https://github.com/googleapis/google-cloud-dotnet/commit/093a3f1a3ea1e44cdb2dc558113cee303208f2ff))

## Version 2.3.0, released 2022-08-26

### New features

- Add read_mask to ListPipelineJobsRequest in aiplatform v1 pipeline_service ([commit 099522b](https://github.com/googleapis/google-cloud-dotnet/commit/099522b4f29dc941b522f23d9c32aadf6b4b7d63))
- Add input_artifacts to PipelineJob.runtime_config in aiplatform v1 pipeline_job ([commit 099522b](https://github.com/googleapis/google-cloud-dotnet/commit/099522b4f29dc941b522f23d9c32aadf6b4b7d63))
- Add UpsertDatapoints and RemoveDatapoints rpcs to IndexService in aiplatform v1 index_service.proto ([commit 592d099](https://github.com/googleapis/google-cloud-dotnet/commit/592d0997fa583f3741b60490fdd4cb131e5ac100))

## Version 2.2.0, released 2022-08-04

### New features

- Making network arg optional in aiplatform v1 custom_job.proto ([commit fbae4d8](https://github.com/googleapis/google-cloud-dotnet/commit/fbae4d8e9d39732ee2c570126f055171256121ba))
- Added SHARED_RESOURCES enum to aiplatform v1 model.proto ([commit fbae4d8](https://github.com/googleapis/google-cloud-dotnet/commit/fbae4d8e9d39732ee2c570126f055171256121ba))

### Documentation improvements

- Doc edits to aiplatform v1 dataset_service.proto, job_service.proto, model_service.proto, pipeline_service.proto, saved_query.proto, study.proto, types.proto ([commit fbae4d8](https://github.com/googleapis/google-cloud-dotnet/commit/fbae4d8e9d39732ee2c570126f055171256121ba))

## Version 2.1.0, released 2022-07-11

### New features

- Add ListSavedQueries rpc to aiplatform v1 dataset_service.proto ([commit 0ac2a25](https://github.com/googleapis/google-cloud-dotnet/commit/0ac2a258631c1925ae90cac40d4a371be3eebf13))
- Add saved_query.proto to aiplatform v1 ([commit 0ac2a25](https://github.com/googleapis/google-cloud-dotnet/commit/0ac2a258631c1925ae90cac40d4a371be3eebf13))
- Add saved_query_id to InputDataConfig in aiplatform v1 training_pipeline.proto ([commit 0ac2a25](https://github.com/googleapis/google-cloud-dotnet/commit/0ac2a258631c1925ae90cac40d4a371be3eebf13))
- Add BatchImportModelEvaluationSlices API in aiplatform v1 model_service.proto ([commit f742d07](https://github.com/googleapis/google-cloud-dotnet/commit/f742d07982cab375c0e81478f473e8e393c985dd))
- Add model_version_id to BatchPredictionJob in aiplatform v1 batch_prediction_job.proto ([commit 2b4568a](https://github.com/googleapis/google-cloud-dotnet/commit/2b4568ab92390c4e8bfaed567dcc831fe59d6641))
- Add model_version_id to DeployedModel in aiplatform v1 endpoint.proto ([commit 2b4568a](https://github.com/googleapis/google-cloud-dotnet/commit/2b4568ab92390c4e8bfaed567dcc831fe59d6641))
- Add model_version_id to PredictResponse in aiplatform v1 prediction_service.proto ([commit 2b4568a](https://github.com/googleapis/google-cloud-dotnet/commit/2b4568ab92390c4e8bfaed567dcc831fe59d6641))
- Add model_version_id to UploadModelResponse in aiplatform v1 model_service.proto ([commit c85aa57](https://github.com/googleapis/google-cloud-dotnet/commit/c85aa57f26f70d7fdb6877b4fa7a58f3bdf864fd))
- Add default_skew_threshold to TrainingPredictionSkewDetectionConfig in aiplatform v1beta1, v1 model_monitoring.proto ([commit 5e87a0c](https://github.com/googleapis/google-cloud-dotnet/commit/5e87a0c5da96ffa7bb5b9526d4b982705831c1a2))
- Add default_drift_threshold to PredictionDriftDetectionConfig in aiplatform v1beta1, v1 model_monitoring.proto ([commit 5e87a0c](https://github.com/googleapis/google-cloud-dotnet/commit/5e87a0c5da96ffa7bb5b9526d4b982705831c1a2))
- Add successful_forecast_point_count to CompletionStats in aiplatform v1 completion_stats.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add neighbors to Explanation in aiplatform v1 explanation.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add examples_override to ExplanationSpecOverride in aiplatform v1 explanation.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add version_id, version_aliases, version_create_time, version_update_time, and version_description to aiplatform v1 model.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add ModelVersion CRUD methods in aiplatform v1 model_service.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add model_id and parent_model to TrainingPipeline in aiplatform v1 training_pipeline.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))

## Version 2.0.0, released 2022-06-08

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
documentation](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax4).
We don't anticipate any changes to most customer code, but please [file a
GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if you run into problems.

The most important change in this release is the use of the Grpc.Net.Client package
for gRPC communication, instead of Grpc.Core. When using .NET Core 3.1 or .NET 5.0+
this should lead to a smaller installation footprint and greater compatibility (e.g.
with Apple M1 chips). Any significant change in a core component comes with the risk
of incompatibility, however - so again, please let us know if you encounter any
issues.

### New features also in this release

- Add monitor_window to ModelDeploymentMonitoringScheduleConfig proto in aiplatform v1/v1beta1 model_deployment_monitoring_job.proto ([commit 4a6d865](https://github.com/googleapis/google-cloud-dotnet/commit/4a6d865f55d52f480e4d5f792d0ff3bf0b68b620))
- Add failure_policy to PipelineJob in aiplatform v1 & v1beta1 pipeline_job.proto ([commit 660482a](https://github.com/googleapis/google-cloud-dotnet/commit/660482a467778c562889b98c382edfaded70446c))
- Add latent_space_source to ExplanationMetadata in aiplatform v1 explanation_metadata.proto ([commit ce1e55d](https://github.com/googleapis/google-cloud-dotnet/commit/ce1e55d51e8e8837f572b470001a6772db87ddab))
- Add scaling to OnlineServingConfig in aiplatform v1 featurestore.proto ([commit ce1e55d](https://github.com/googleapis/google-cloud-dotnet/commit/ce1e55d51e8e8837f572b470001a6772db87ddab))
- Add template_metadata to PipelineJob in aiplatform v1 pipeline_job.proto ([commit ce1e55d](https://github.com/googleapis/google-cloud-dotnet/commit/ce1e55d51e8e8837f572b470001a6772db87ddab))

## Version 1.8.0, released 2022-05-24

### New features

- Add display_name and metadata to ModelEvaluation in aiplatform model_evaluation.proto ([commit f3160c5](https://github.com/googleapis/google-cloud-dotnet/commit/f3160c58825803c39dcd24d73777caebd5d49481))
## Version 1.7.0, released 2022-04-26

### New features

- Add reserved_ip_ranges to CustomJobSpec in aiplatform v1 custom_job.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
- Add nfs_mounts to WorkPoolSpec in aiplatform v1 custom_job.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
- Add JOB_STATE_UPDATING to JobState in aiplatform v1 job_state.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
- Add MfsMount in aiplatform v1 machine_resources.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
- Add ConvexAutomatedStoppingSpec to StudySpec in aiplatform v1 study.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
## Version 1.6.0, released 2022-04-04

### New features

- Add ImportModelEvaluation in aiplatform v1 model_service.proto ([commit 9406420](https://github.com/googleapis/google-cloud-dotnet/commit/940642037b4217cf427e3042bf0e7de74abe1d37))
- Add data_item_schema_uri, annotation_schema_uri, explanation_specs to ModelEvaluationExplanationSpec in aiplatform v1 model_evaluation.proto ([commit 9406420](https://github.com/googleapis/google-cloud-dotnet/commit/940642037b4217cf427e3042bf0e7de74abe1d37))
- Add ImportModelEvaluation in aiplatform v1beta1 model_service.proto ([commit 9406420](https://github.com/googleapis/google-cloud-dotnet/commit/940642037b4217cf427e3042bf0e7de74abe1d37))

## Version 1.5.0, released 2022-03-14

### New features

- Add monitoring_config to EntityType in aiplatform v1 entity_type.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add disable_monitoring to Feature in aiplatform v1 feature.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add monitoring_stats_anomalies to Feature in aiplatform v1 feature.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add staleness_days to SnapshotAnalysis in aiplatform v1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add import_features_analysis to FeaturestoreMonitoringConfig in aiplatform v1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add numerical_threshold_config to FeaturestoreMonitoringConfig in aiplatform v1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add categorical_threshold_config to FeaturestoreMonitoringConfig in aiplatform v1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add objective to MonitoringStatsSpec in aiplatform v1 featurestore_service.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add disable_monitoring to Feature in aiplatform v1beta1 feature.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add monitoring_stats_anomalies to Feature in aiplatform v1beta1 feature.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add staleness_days to SnapshotAnalysis in aiplatform v1beta1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add import_features_analysis to FeaturestoreMonitoringConfig in aiplatform v1beta1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add numerical_threshold_config to FeaturestoreMonitoringConfig in aiplatform v1beta1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add categorical_threshold_config to FeaturestoreMonitoringConfig in aiplatform v1beta1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add objective to MonitoringStatsSpec in aiplatform v1beta1 featurestore_service.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add PredictRequestResponseLoggingConfig to Endpoint in aiplatform v1 endpoint.proto ([commit a3d6d2b](https://github.com/googleapis/google-cloud-dotnet/commit/a3d6d2b7af22f4a19e78435512861b6dab0b1a7d))

## Version 1.4.0, released 2022-02-28

### New features

- Add TPU_V2 & TPU_V3 values to AcceleratorType in aiplatform v1/v1beta1 accelerator_type.proto ([commit 354f7fd](https://github.com/googleapis/google-cloud-dotnet/commit/354f7fd84ba22d2eef391d63e633ef836bea54e9))

### Documentation improvements

- Fix misformatted field description ([commit 95bf8b9](https://github.com/googleapis/google-cloud-dotnet/commit/95bf8b971a5ebaf3e9c57b69139e6a3b2b69ce32))

## Version 1.3.0, released 2022-02-07

### New features

- Add dedicated_resources to DeployedIndex message in aiplatform v1 index_endpoint.proto ([commit 6be632d](https://github.com/googleapis/google-cloud-dotnet/commit/6be632d58049af3165675d56db2837c7d6b78a81))

## Version 1.2.0, released 2022-01-17

### New features

- Add enable_private_service_connect field to Endpoint ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add id field to DeployedModel ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add service_attachment field to PrivateEndpoints ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add endpoint_id to CreateEndpointRequest and method signature to CreateEndpoint ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add method signature to CreateFeatureStore, CreateEntityType, CreateFeature ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add network and enable_private_service_connect to IndexEndpoint ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add service_attachment to IndexPrivateEndpoints ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add stratified_split field to training_pipeline InputDataConfig ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))

## Version 1.1.0, released 2021-11-18

- [Commit 0d5a6b7](https://github.com/googleapis/google-cloud-dotnet/commit/0d5a6b7):
  - feat:Tensorboard v1 protos release
  - feat:Exposing a field for v1 CustomJob-Tensorboard integration.

## Version 1.0.0, released 2021-11-10

- [Commit 68f7900](https://github.com/googleapis/google-cloud-dotnet/commit/68f7900): feat: Adds support for `google.protobuf.Value` pipeline parameters in the `parameter_values` field

First GA release. Note that the dependencies on Google.Cloud.AutoML.V1 and Google.Cloud.DataLabeling.V1Beta1 have been removed in this release.

## Version 1.0.0-beta05, released 2021-10-20

- [Commit 43bcfc3](https://github.com/googleapis/google-cloud-dotnet/commit/43bcfc3):
  - feat: add featurestore service to aiplatform v1
  - feat: add metadata service to aiplatform v1
  - docs: fix typo in alert.proto

## Version 1.0.0-beta04, released 2021-09-24

- [Commit 656f5ca](https://github.com/googleapis/google-cloud-dotnet/commit/656f5ca): feat: add Vizier service to aiplatform v1
- [Commit cd4557f](https://github.com/googleapis/google-cloud-dotnet/commit/cd4557f): feat: add XAI, model monitoring, and index services to aiplatform v1

## Version 1.0.0-beta03, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta02, released 2021-08-09

- [Commit b950563](https://github.com/googleapis/google-cloud-dotnet/commit/b950563): feat!: Removes breaking change from v1 version of AI Platform protos
- [Commit 8ecff2b](https://github.com/googleapis/google-cloud-dotnet/commit/8ecff2b): feat!: Removes AcceleratorType.TPU_V2 and TPU_V3 constants feat: Adds AcceleratorType.NVIDIA_TESLA_A100 constant feat: Adds BigQuery output table field to batch prediction job output config feat: Adds JobState.JOB_STATE_EXPIRED constant feat: Adds AutoscalingMetricSpec message feat: Adds PipelineService methods: CreatePipelineJob, GetPipelineJob, ListPipelineJobs, DeletePipelineJobs, CancelPipelineJobs feat: Adds fields to Study message
- [Commit 50afb69](https://github.com/googleapis/google-cloud-dotnet/commit/50afb69): fix: Explicitly use Google.Protobuf.WellKnownTypes.Value in ValueConverter
- [Commit b123458](https://github.com/googleapis/google-cloud-dotnet/commit/b123458):
  - feat: Adds additional_experiments field to AutoMlTablesInputs
  - feat: Adds two new ModelType constants for Video Action Recognition training jobs

## Version 1.0.0-beta01, released 2021-06-28

Initial release.
