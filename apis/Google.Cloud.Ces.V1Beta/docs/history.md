# Version history

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

