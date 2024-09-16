# Version history

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
