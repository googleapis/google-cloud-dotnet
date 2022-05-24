# Version history

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
