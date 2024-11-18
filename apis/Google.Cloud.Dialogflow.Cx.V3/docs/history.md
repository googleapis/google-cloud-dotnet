# Version history

## Version 2.21.0, released 2024-11-18

### New features

- Add options of client_certificate_settings, bigquery_export_settings, bearer_token_config and boost_control_spec; add support of ALAW encoding ([commit 5f708d8](https://github.com/googleapis/google-cloud-dotnet/commit/5f708d833e320527b225017042e40f8e129a2ce4))

## Version 2.20.0, released 2024-07-29

### New features

- Exposed DataStoreConnectionSignals ([commit 4a52f53](https://github.com/googleapis/google-cloud-dotnet/commit/4a52f533537949ab4f66b4c13e63194f0c48693d))
- Added support for lock flow ([commit 4a52f53](https://github.com/googleapis/google-cloud-dotnet/commit/4a52f533537949ab4f66b4c13e63194f0c48693d))
- Added support for multi language settings in flow ([commit 4a52f53](https://github.com/googleapis/google-cloud-dotnet/commit/4a52f533537949ab4f66b4c13e63194f0c48693d))
- Added support for service directory in tools ([commit 4a52f53](https://github.com/googleapis/google-cloud-dotnet/commit/4a52f533537949ab4f66b4c13e63194f0c48693d))
- Added support for oauth and service agent auth for webhook. ([commit 4a52f53](https://github.com/googleapis/google-cloud-dotnet/commit/4a52f533537949ab4f66b4c13e63194f0c48693d))
- Expose store tts option in security settings ([commit 4a52f53](https://github.com/googleapis/google-cloud-dotnet/commit/4a52f533537949ab4f66b4c13e63194f0c48693d))
- Expose PersonalizationSettings & SpeechSettings in v3 API. ([commit 4a52f53](https://github.com/googleapis/google-cloud-dotnet/commit/4a52f533537949ab4f66b4c13e63194f0c48693d))

### Documentation improvements

- Clarified wording around enable_stackdriver_logging & enable_interaction_logging ([commit 4a52f53](https://github.com/googleapis/google-cloud-dotnet/commit/4a52f533537949ab4f66b4c13e63194f0c48693d))
- Clarified wording around start point of test config. ([commit 4a52f53](https://github.com/googleapis/google-cloud-dotnet/commit/4a52f533537949ab4f66b4c13e63194f0c48693d))
- Clarified wording around audio redaction ([commit 4a52f53](https://github.com/googleapis/google-cloud-dotnet/commit/4a52f533537949ab4f66b4c13e63194f0c48693d))

## Version 2.19.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.18.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.17.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.16.0, released 2024-03-13

No API surface changes; just dependency updates.

## Version 2.15.0, released 2024-02-09

### New features

- A new field `opt_out_conformer_model_migration` is added to message `.google.cloud.dialogflow.cx.v3.InputAudioConfig` ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new field `language_code` is added to message `.google.cloud.dialogflow.cx.v3.Changelog` ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new method `ExportEntityTypes` is added to service `EntityTypes` ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new method `ImportEntityTypes` is added to service `EntityTypes` ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new message `ExportEntityTypesRequest` is added ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new message `ExportEntityTypesResponse` is added ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new message `ExportEntityTypesMetadata` is added ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new message `ImportEntityTypesRequest` is added ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new message `ImportEntityTypesResponse` is added ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new message `ImportEntityTypesMetadata` is added ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new field `disable_data_store_fallback` is added to message `.google.cloud.dialogflow.cx.v3.GenerativeSettings` ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new field `description` is added to message `.google.cloud.dialogflow.cx.v3.Page` ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new method `ServerStreamingDetectIntent` is added to service `Sessions` ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new field `webhook_ids` is added to message `.google.cloud.dialogflow.cx.v3.QueryResult` ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new field `webhook_display_names` is added to message `.google.cloud.dialogflow.cx.v3.QueryResult` ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new field `webhook_latencies` is added to message `.google.cloud.dialogflow.cx.v3.QueryResult` ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new field `webhook_tags` is added to message `.google.cloud.dialogflow.cx.v3.QueryResult` ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A new field `current_flow` is added to message `.google.cloud.dialogflow.cx.v3.QueryResult` ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))

### Documentation improvements

- A comment for field `start_flow` in message `.google.cloud.dialogflow.cx.v3.Agent` is changed ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A comment for enum value `USE_BEST_AVAILABLE` in enum `SpeechModelVariant` is changed ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A comment for enum value `USE_ENHANCED` in enum `SpeechModelVariant` is changed ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A comment for field `model` in message `.google.cloud.dialogflow.cx.v3.InputAudioConfig` is changed ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A comment for enum value `END_OF_SINGLE_UTTERANCE` in enum `MessageType` is changed ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A comment for field `session_ttl` in message `.google.cloud.dialogflow.cx.v3.QueryParameters` is changed ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A comment for message `QueryInput` is changed ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- A comment for field `text` in message `.google.cloud.dialogflow.cx.v3.TextInput` is changed ([commit f21d994](https://github.com/googleapis/google-cloud-dotnet/commit/f21d994a91ab23a255f903c694e214b0ed32b4cf))
- Fix formatting due to unclosed backtick ([commit 334ef80](https://github.com/googleapis/google-cloud-dotnet/commit/334ef80628dbb31a49d27b330749feed4fccea91))

## Version 2.14.0, released 2023-12-04

### New features

- Added Generator API ([commit 7fa7921](https://github.com/googleapis/google-cloud-dotnet/commit/7fa79211ca59b340b1645230c74d942753b5037f))
- Add agent answer feedback capability ([commit 8a953a2](https://github.com/googleapis/google-cloud-dotnet/commit/8a953a2401c75a6022e490f4103ce857fac6bcaa))
- Add fields for supporting barge-in in StreamingDetectIntent API ([commit 8a953a2](https://github.com/googleapis/google-cloud-dotnet/commit/8a953a2401c75a6022e490f4103ce857fac6bcaa))
- Add end_user_metadata to QueryParameters ([commit 8a953a2](https://github.com/googleapis/google-cloud-dotnet/commit/8a953a2401c75a6022e490f4103ce857fac6bcaa))
- Add boost & bury and filter ES controls ([commit 8a953a2](https://github.com/googleapis/google-cloud-dotnet/commit/8a953a2401c75a6022e490f4103ce857fac6bcaa))

### Documentation improvements

- Updated doc for speech mode ([commit 7fa7921](https://github.com/googleapis/google-cloud-dotnet/commit/7fa79211ca59b340b1645230c74d942753b5037f))

## Version 2.13.0, released 2023-10-02

### New features

- Add support for AdvancedSettings ([commit adc32d3](https://github.com/googleapis/google-cloud-dotnet/commit/adc32d30748d6e97822a2add6d326e2618c2c0f7))
- Add Intent import/export APIs ([commit adc32d3](https://github.com/googleapis/google-cloud-dotnet/commit/adc32d30748d6e97822a2add6d326e2618c2c0f7))
- Add Inline destination ([commit adc32d3](https://github.com/googleapis/google-cloud-dotnet/commit/adc32d30748d6e97822a2add6d326e2618c2c0f7))

## Version 2.12.0, released 2023-09-18

### Bug fixes

- Fix Ruby namespaces for generative AI classes ([commit 14f47b3](https://github.com/googleapis/google-cloud-dotnet/commit/14f47b39303a84751ea8e43945abdda45af4f6f1))

## Version 2.11.0, released 2023-09-06

### New features

- Added generative AI, safety/security and speech endpointing settings ([commit f62319c](https://github.com/googleapis/google-cloud-dotnet/commit/f62319c38194fafcc40ac79e7879e99d17ba0964))

## Version 2.10.0, released 2023-08-16

### New features

- Added agent level route group ([commit a1d57da](https://github.com/googleapis/google-cloud-dotnet/commit/a1d57da865d33facbeddbf03d0e72de6caa48e4a))
- Added flow import strategy ([commit a1d57da](https://github.com/googleapis/google-cloud-dotnet/commit/a1d57da865d33facbeddbf03d0e72de6caa48e4a))

## Version 2.9.0, released 2023-07-13

### New features

- Added GitIntegrationSettings to the Agent ([commit 307819a](https://github.com/googleapis/google-cloud-dotnet/commit/307819a2def31c7cbfd2951d9725cb083b05b0e4))

## Version 2.8.0, released 2023-06-20

### New features

- Added include_bigquery_export_settings to ExportAgentRequest ([commit d127ca2](https://github.com/googleapis/google-cloud-dotnet/commit/d127ca2ad19c6b3ececae30e974220d308925d17))
- Added session_ttl to SessionProto ([commit d127ca2](https://github.com/googleapis/google-cloud-dotnet/commit/d127ca2ad19c6b3ececae30e974220d308925d17))
- Add support for flexible webhook ([commit 79c2a12](https://github.com/googleapis/google-cloud-dotnet/commit/79c2a127df990fdf14ae8657fc7e16dd2321acbf))

### Documentation improvements

- Update synthesize speech configs's documentation ([commit 79c2a12](https://github.com/googleapis/google-cloud-dotnet/commit/79c2a127df990fdf14ae8657fc7e16dd2321acbf))

## Version 2.7.0, released 2023-05-11

### New features

- Extended CreateAgent timeout to 180 seconds ([commit f12f32b](https://github.com/googleapis/google-cloud-dotnet/commit/f12f32b063816b420d3e7d38b2cf0f77a83f4942))
- Added debug info to StreamingDetectIntent ([commit f12f32b](https://github.com/googleapis/google-cloud-dotnet/commit/f12f32b063816b420d3e7d38b2cf0f77a83f4942))
- Added dtmf digits to WebhookRequest ([commit f12f32b](https://github.com/googleapis/google-cloud-dotnet/commit/f12f32b063816b420d3e7d38b2cf0f77a83f4942))
- Added FLOW as a new DiffType in TestRunDifference ([commit f12f32b](https://github.com/googleapis/google-cloud-dotnet/commit/f12f32b063816b420d3e7d38b2cf0f77a83f4942))

### Documentation improvements

- Clarified wording around quota usage ([commit 9439fbb](https://github.com/googleapis/google-cloud-dotnet/commit/9439fbb6268ef09a480e37d4e521512629546332))

## Version 2.6.0, released 2023-03-06

### New features

- Added persist_parameter_changes field from `query_params` to MatchIntentRequest ([commit 3798668](https://github.com/googleapis/google-cloud-dotnet/commit/3798668f292c995ca023d2c03d236c6e7d60b00c))

## Version 2.5.0, released 2023-02-22

### New features

- Added gcs.proto. added support for GcsDestination and TextToSpeechSettings ([commit c799095](https://github.com/googleapis/google-cloud-dotnet/commit/c7990957ad016f53bd9c783a07a22456310bef2d))
- Remove [REQUIRED] for VersionConfig ([commit c799095](https://github.com/googleapis/google-cloud-dotnet/commit/c7990957ad016f53bd9c783a07a22456310bef2d))

### Documentation improvements

- Add more meaningful comments ([commit c799095](https://github.com/googleapis/google-cloud-dotnet/commit/c7990957ad016f53bd9c783a07a22456310bef2d))

## Version 2.4.0, released 2023-01-25

### New features

- Added JSON_PACKAGE field to ExportAgentRequest ([commit a336a72](https://github.com/googleapis/google-cloud-dotnet/commit/a336a72f5259a3b33318dde2f929201122515371))

## Version 2.3.0, released 2023-01-16

### New features

- Enable REST transport in C# ([commit a6c4606](https://github.com/googleapis/google-cloud-dotnet/commit/a6c46063bd961a9dadc728a780d66de772f28e71))
- ResponseMessage proto contains channel information ([commit 8e8343d](https://github.com/googleapis/google-cloud-dotnet/commit/8e8343d1e2407d38b6f9db0af08214b6628506f3))

### Documentation improvements

- Updated go library package ([commit 8e8343d](https://github.com/googleapis/google-cloud-dotnet/commit/8e8343d1e2407d38b6f9db0af08214b6628506f3))

## Version 2.2.0, released 2022-12-01

### Documentation improvements

- Clarified Agent Assist max retention is 30 days ([commit 8ebde4f](https://github.com/googleapis/google-cloud-dotnet/commit/8ebde4f5eceb04d7833acb0890df634d8b0d2501))
- Clarified TTL as time-to-live ([commit 8aa3a16](https://github.com/googleapis/google-cloud-dotnet/commit/8aa3a16cf991d8ab13004ce85fbbb418be652573))
- Removed pre-GA disclaimer from Interaction Logging (has been GA for awhile) ([commit 8aa3a16](https://github.com/googleapis/google-cloud-dotnet/commit/8aa3a16cf991d8ab13004ce85fbbb418be652573))
- Clarified gcs_bucket field of the SecuritySettings message ([commit 4888598](https://github.com/googleapis/google-cloud-dotnet/commit/488859889ab68c0fcf4e0bcff00b203ca0641b39))

## Version 2.1.0, released 2022-07-11

### Documentation improvements

- Improve comments for protos ([commit 27b3c67](https://github.com/googleapis/google-cloud-dotnet/commit/27b3c678ac58d003776a4db0f95e80af268eaed1))

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


## Version 1.13.0, released 2022-05-24

### New features

- Added audio_export_settings ([commit 396b331](https://github.com/googleapis/google-cloud-dotnet/commit/396b3316365f67eced6fb96320738c439f2b1bd7))

### Documentation improvements

- Update the doc on diagnostic info ([commit 6e61aab](https://github.com/googleapis/google-cloud-dotnet/commit/6e61aabbedcd6009980f876d880ba2aa5874bf16))

## Version 1.12.0, released 2022-04-26

### Documentation improvements

- Minor wording update ([commit d4281ec](https://github.com/googleapis/google-cloud-dotnet/commit/d4281ecab7d92f097db170e837640ab28719519b))

## Version 1.11.0, released 2022-04-04

### New features

- Added support for locking an agent for changes ([commit 7afeda7](https://github.com/googleapis/google-cloud-dotnet/commit/7afeda772cb17f1bd039bd53554df68e67cff1b9))
- Added data format specification for export agent ([commit 7afeda7](https://github.com/googleapis/google-cloud-dotnet/commit/7afeda772cb17f1bd039bd53554df68e67cff1b9))

### Documentation improvements

- Improved docs format ([commit 034e33b](https://github.com/googleapis/google-cloud-dotnet/commit/034e33b72ef0ad4e40cbc6fe3838b30fbde59e57))

## Version 1.10.0, released 2022-03-14

### New features

- Added page in TestConfig ([commit 6f8eedf](https://github.com/googleapis/google-cloud-dotnet/commit/6f8eedfe6d4e0433331bef4480db18a50d0292ce))

### Documentation improvements

- Clarified wording around Cloud Storage usage ([commit 6f8eedf](https://github.com/googleapis/google-cloud-dotnet/commit/6f8eedfe6d4e0433331bef4480db18a50d0292ce))
## Version 1.9.0, released 2022-01-17

### New features

- Added the display name of the current page in webhook requests ([commit 889b18e](https://github.com/googleapis/google-cloud-dotnet/commit/889b18e0efeae3a6095d46813d436b36f9d190d4))

## Version 1.8.0, released 2021-12-07

- [Commit 2c44579](https://github.com/googleapis/google-cloud-dotnet/commit/2c44579):
  - feat: added support for custom content types
  - docs: reformat comments

## Version 1.7.0, released 2021-11-18

- [Commit 042a99f](https://github.com/googleapis/google-cloud-dotnet/commit/042a99f):
  - feat: allow setting custom CA for generic webhooks and release CompareVersions API
  - docs: clarify DLP template reader usage

## Version 1.6.0, released 2021-11-10

- [Commit 36bae8f](https://github.com/googleapis/google-cloud-dotnet/commit/36bae8f):
  - feat: added API for changelogs
  - docs: clarified semantic of the streaming APIs
## Version 1.5.0, released 2021-10-12

- [Commit 74b880a](https://github.com/googleapis/google-cloud-dotnet/commit/74b880a):
  - feat: added deployment API
  - feat: exposed DTMF input info in the query result
  - docs: added notes on long running operation
- [Commit de40ef5](https://github.com/googleapis/google-cloud-dotnet/commit/de40ef5):
  - feat: update gapic-generator-csharp to 1.3.11
  - feat: update rules_gapic to 0.8.0

## Version 1.4.0, released 2021-09-23

- [Commit 6b21a68](https://github.com/googleapis/google-cloud-dotnet/commit/6b21a68):
  - docs: clarified some LRO types
  - docs: fixed some wrong update mask descriptions
- [Commit 29077ad](https://github.com/googleapis/google-cloud-dotnet/commit/29077ad): chore: Configure Dialogflow CX for Ruby clients
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs
- [Commit 992c711](https://github.com/googleapis/google-cloud-dotnet/commit/992c711): feat: added support for DLP templates; expose `Locations` service to get/list avaliable locations of Dialogflow products

## Version 1.3.0, released 2021-08-10

- [Commit c2e92a3](https://github.com/googleapis/google-cloud-dotnet/commit/c2e92a3):
  - feat: add advanced settings for agent level
  - feat: add rollout config, state and failure reason for experiment
  - feat: add insights export settings for security setting
  - feat: add language code for streaming recognition result and flow versions for query parameters
  - docs: deprecate legacy logging settings

## Version 1.2.0, released 2021-06-22

- [Commit 9e5afc5](https://github.com/googleapis/google-cloud-dotnet/commit/9e5afc5):
  - feat!: mark agent.default_language_code as required
  - feat: add return_partial response to Fulfillment
  - docs: add notes to train agent before sending queries
- [Commit 7fb97ab](https://github.com/googleapis/google-cloud-dotnet/commit/7fb97ab): feat: support sentiment analysis in bot testing
- [Commit f2b218e](https://github.com/googleapis/google-cloud-dotnet/commit/f2b218e): feat: added API for running continuous test
- [Commit d2778b1](https://github.com/googleapis/google-cloud-dotnet/commit/d2778b1): docs: clarified documentation for security settings docs: clarified documentation for session parameters
- [Commit e48e2f5](https://github.com/googleapis/google-cloud-dotnet/commit/e48e2f5): feat: add support for service directory webhooks

## Version 1.1.0, released 2021-04-29

- [Commit 4f8b084](https://github.com/googleapis/google-cloud-dotnet/commit/4f8b084):
  - feat: Expose supported languages of the agent
  - feat: add export / import flow API
  - docs: Update docs on Pages, Session, Version, etc.
- [Commit ce8af2b](https://github.com/googleapis/google-cloud-dotnet/commit/ce8af2b): feat: support setting current_page to resume sessions; expose transition_route_groups in flows and language_code in webhook
- [Commit b7c7654](https://github.com/googleapis/google-cloud-dotnet/commit/b7c7654): 
  - feat: include original user query in WebhookRequest; add GetTextCaseresult API.
  - docs: clarify resource format for session response.
- [Commit 178d139](https://github.com/googleapis/google-cloud-dotnet/commit/178d139):
  - feat: added fallback option when restoring an agent
  - docs: clarified experiment length
- [Commit 169fa02](https://github.com/googleapis/google-cloud-dotnet/commit/169fa02): feat: allow to disable webhook invocation per request
- [Commit 94e5bf2](https://github.com/googleapis/google-cloud-dotnet/commit/94e5bf2): docs: update languages link
- [Commit e8eb0a0](https://github.com/googleapis/google-cloud-dotnet/commit/e8eb0a0):
  - fix: RunTestCase http template. PHP REST client lib can be generated.
  - feat: Support transition route group coverage for Test Cases.
  - feat: Support SentimentAnalysisResult input in the WebhookRequest.
- [Commit aeff7bf](https://github.com/googleapis/google-cloud-dotnet/commit/aeff7bf):
  - feat: supports SentimentAnalysisResult in webhook request, add http rules for long running operations
  - docs: minor updates in wording
- [Commit fffad62](https://github.com/googleapis/google-cloud-dotnet/commit/fffad62):
  - feat: Add new Experiment service
  - docs: minor doc update on redact field in intent.proto and page.proto
- [Commit 41e91ab](https://github.com/googleapis/google-cloud-dotnet/commit/41e91ab): docs: test cases doc update
- [Commit 2711bfe](https://github.com/googleapis/google-cloud-dotnet/commit/2711bfe): feat: added support for test cases and agent validation

## Version 1.0.0, released 2021-01-20

- [Commit 3ff57b5](https://github.com/googleapis/google-cloud-dotnet/commit/3ff57b5): feat: add experiment and API docs: update comments on parameters and agent

## Version 1.0.0-beta01, released 2020-12-14

Initial release.
