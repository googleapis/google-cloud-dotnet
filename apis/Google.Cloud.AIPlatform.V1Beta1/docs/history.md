# Version history

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
