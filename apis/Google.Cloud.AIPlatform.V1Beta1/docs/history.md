# Version history

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
