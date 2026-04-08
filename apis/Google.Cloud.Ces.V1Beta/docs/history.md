# Version history

## Version 1.0.0-beta04, released 2026-04-06

### New features

- Update public libraries for CES v1beta
- Add support for generating app resources with LLM
- Deprecate `root_agent` in message `.google.cloud.ces.v1beta.AgentTool` in favor of new `agent` field.
- [Memorystore for Redis Cluster] Add support for Flexible CA feature
- Update public libraries for CES v1beta
- Add support for generating app resources with LLM
- Deprecate `root_agent` in message `.google.cloud.ces.v1beta.AgentTool` in favor of new `agent` field.

### Documentation improvements

- A comment for field `root_agent` in message `.google.cloud.ces.v1beta.AgentTool` is changed
- A comment for field `root_agent` in message `.google.cloud.ces.v1beta.AgentTool` is changed

## Version 1.0.0-beta03, released 2026-03-23

### New features

- Update public libraries for CES v1beta

### Documentation improvements

- A comment for field `fallback_action` in message `.google.cloud.ces.v1beta.LanguageSettings` is changed
- A comment for enum value `ERROR_HANDLING_STRATEGY_UNSPECIFIED` in enum `ErrorHandlingStrategy` is changed
- A comment for enum value `FALLBACK_RESPONSE` in enum `ErrorHandlingStrategy` is changed
- A comment for field `project` in message `.google.cloud.ces.v1beta.BigQueryExportSettings` is changed
- A comment for field `dataset` in message `.google.cloud.ces.v1beta.BigQueryExportSettings` is changed
- A comment for message `RunEvaluationOperationMetadata` is changed
- A comment for method `RunSession` in service `SessionService` is changed

## Version 1.0.0-beta02, released 2026-03-09

### New features

- Update public libraries for CES v1beta

### Bug fixes

- An existing google.api.http annotation `http_uri` is changed for method `UploadEvaluationAudio` in service `EvaluationService`
- An existing method_signature `app,audio_content` is removed from method `UploadEvaluationAudio` in service `EvaluationService`
- An existing field `app` is renamed to `name` in message `.google.cloud.ces.v1beta.UploadEvaluationAudioRequest`
- An existing field `audio_transcript` is renamed to `transcript` in message `.google.cloud.ces.v1beta.UploadEvaluationAudioResponse`
- An existing field `audio_duration` is renamed to `duration` in message `.google.cloud.ces.v1beta.UploadEvaluationAudioResponse`
- An existing field `variables` is moved in to oneof in message `.google.cloud.ces.v1beta.ExecuteToolRequest`

### Documentation improvements

- A comment for field `cert` in message `.google.cloud.ces.v1beta.TlsConfig` is changed
- A comment for field `entry_agent` in message `.google.cloud.ces.v1beta.SessionConfig` is changed
- A comment for field `name` in message `.google.cloud.ces.v1beta.Tool` is changed

## Version 1.0.0-beta01, released 2026-03-02

### New features

- Initial generation for Google.Cloud.Ces.V1Beta

