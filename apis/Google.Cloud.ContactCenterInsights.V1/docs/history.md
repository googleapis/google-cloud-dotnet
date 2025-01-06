# Version history

## Version 2.19.0, released 2025-01-06

### New features

- A new resource pattern value `projects/{project}/locations/{location}/authorizedViewSets/{authorized_view_set}/authorizedViews/{authorized_view}/conversations/{conversation}` added to the resource definition `contactcenterinsights.googleapis.com/Conversation` ([commit 3b15a19](https://github.com/googleapis/google-cloud-dotnet/commit/3b15a195acfda579bff8f120c3da9557cd03a1ac))
- A new field `agent_type` is added to message `.google.cloud.contactcenterinsights.v1.Conversation` ([commit 3b15a19](https://github.com/googleapis/google-cloud-dotnet/commit/3b15a195acfda579bff8f120c3da9557cd03a1ac))
- A new resource pattern value `projects/{project}/locations/{location}/authorizedViewSets/{authorized_view_set}/authorizedViews/{authorized_view}/conversations/{conversation}/analyses/{analysis}` added to the resource definition `contactcenterinsights.googleapis.com/Analysis` ([commit 3b15a19](https://github.com/googleapis/google-cloud-dotnet/commit/3b15a195acfda579bff8f120c3da9557cd03a1ac))
- A new resource pattern value `projects/{project}/locations/{location}/authorizedViewSets/{authorized_view_set}/authorizedViews/{authorized_view}/conversations/{conversation}/feedbackLabels/{feedback_label}` added to the resource definition `contactcenterinsights.googleapis.com/FeedbackLabel` ([commit 3b15a19](https://github.com/googleapis/google-cloud-dotnet/commit/3b15a195acfda579bff8f120c3da9557cd03a1ac))

## Version 2.18.0, released 2024-11-18

### New features

- Add FeedbackLabel resource and APIs ([commit fc735ad](https://github.com/googleapis/google-cloud-dotnet/commit/fc735add3c94e539818b5adfcf1137750e682099))
- Add QueryMetrics API ([commit fc735ad](https://github.com/googleapis/google-cloud-dotnet/commit/fc735add3c94e539818b5adfcf1137750e682099))
- Add Quality AI resources and APIs ([commit fc735ad](https://github.com/googleapis/google-cloud-dotnet/commit/fc735add3c94e539818b5adfcf1137750e682099))
- Add AnalysisRules resource and APIs ([commit fc735ad](https://github.com/googleapis/google-cloud-dotnet/commit/fc735add3c94e539818b5adfcf1137750e682099))

### Documentation improvements

- A comment for method `InitializeEncryptionSpec` in service `ContactCenterInsights` is changed ([commit fc735ad](https://github.com/googleapis/google-cloud-dotnet/commit/fc735add3c94e539818b5adfcf1137750e682099))
- A comment for field `custom_metadata_keys` in message `.google.cloud.contactcenterinsights.v1.IngestConversationsRequest` is changed ([commit fc735ad](https://github.com/googleapis/google-cloud-dotnet/commit/fc735add3c94e539818b5adfcf1137750e682099))
- A comment for field `encryption_spec` in message `.google.cloud.contactcenterinsights.v1.InitializeEncryptionSpecRequest` is changed ([commit fc735ad](https://github.com/googleapis/google-cloud-dotnet/commit/fc735add3c94e539818b5adfcf1137750e682099))
- A comment for field `partial_errors` in message `.google.cloud.contactcenterinsights.v1.InitializeEncryptionSpecMetadata` is changed ([commit fc735ad](https://github.com/googleapis/google-cloud-dotnet/commit/fc735add3c94e539818b5adfcf1137750e682099))
- A comment for field `labels` in message `.google.cloud.contactcenterinsights.v1.Conversation` is changed ([commit fc735ad](https://github.com/googleapis/google-cloud-dotnet/commit/fc735add3c94e539818b5adfcf1137750e682099))
- A comment for field `metadata_json` in message `.google.cloud.contactcenterinsights.v1.Conversation` is changed ([commit fc735ad](https://github.com/googleapis/google-cloud-dotnet/commit/fc735add3c94e539818b5adfcf1137750e682099))
- A comment for message `EncryptionSpec` is changed ([commit fc735ad](https://github.com/googleapis/google-cloud-dotnet/commit/fc735add3c94e539818b5adfcf1137750e682099))
- A comment for field `kms_key` in message `.google.cloud.contactcenterinsights.v1.EncryptionSpec` is changed ([commit fc735ad](https://github.com/googleapis/google-cloud-dotnet/commit/fc735add3c94e539818b5adfcf1137750e682099))

## Version 2.17.0, released 2024-10-14

### New features

- Add import / export IssueModel ([commit 8b67ba5](https://github.com/googleapis/google-cloud-dotnet/commit/8b67ba5b2dd26e7663b7d9faa633596ada676e77))
- Add CMEK InitializeLroSpec ([commit 8b67ba5](https://github.com/googleapis/google-cloud-dotnet/commit/8b67ba5b2dd26e7663b7d9faa633596ada676e77))
- Add metadata import to IngestConversations ([commit 8b67ba5](https://github.com/googleapis/google-cloud-dotnet/commit/8b67ba5b2dd26e7663b7d9faa633596ada676e77))
- Add sampling to IngestConversations ([commit 8b67ba5](https://github.com/googleapis/google-cloud-dotnet/commit/8b67ba5b2dd26e7663b7d9faa633596ada676e77))

### Documentation improvements

- Add a comment for valid `order_by` values in ListConversations ([commit 8b67ba5](https://github.com/googleapis/google-cloud-dotnet/commit/8b67ba5b2dd26e7663b7d9faa633596ada676e77))
- Add a comment for valid `update_mask` values in UpdateConversation ([commit 8b67ba5](https://github.com/googleapis/google-cloud-dotnet/commit/8b67ba5b2dd26e7663b7d9faa633596ada676e77))

## Version 2.16.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.15.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.14.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.13.0, released 2024-03-13

No API surface changes; just dependency updates.

## Version 2.12.0, released 2024-02-08

### New features

- Add Conversation QualityMetadata ([commit 2d19ea5](https://github.com/googleapis/google-cloud-dotnet/commit/2d19ea59d50517ee78226de36995e13661f7c037))

### Documentation improvements

- Clarify usage of agent and customer channel fields in IngestConversationsRequest ([commit 2d19ea5](https://github.com/googleapis/google-cloud-dotnet/commit/2d19ea59d50517ee78226de36995e13661f7c037))
- Update IngestConversations and BulkAnalyzeConversations comments ([commit 891d0b4](https://github.com/googleapis/google-cloud-dotnet/commit/891d0b4a222fd1de35dbc8e13ec4f89bc1e57d7d))

## Version 2.11.0, released 2023-11-07

### New features

- Launch BulkDelete API, and bulk audio import via the IngestConversations API ([commit 0b9a453](https://github.com/googleapis/google-cloud-dotnet/commit/0b9a45328ae585feaa5e5ece93f2dcb3f9859582))

## Version 2.10.0, released 2023-09-26

### New features

- Add optional SpeechConfig to UploadConversationRequest ([commit d09e252](https://github.com/googleapis/google-cloud-dotnet/commit/d09e252125bbffaa2b42e4c43fd8c9b48c8888e3))

## Version 2.9.0, released 2023-07-13

### New features

- Support topic model type V2 ([commit 1ad9bc2](https://github.com/googleapis/google-cloud-dotnet/commit/1ad9bc2a2dca4468dd5a8f5ab8a1da3ecc2070ff))

## Version 2.8.0, released 2023-06-05

### New features

- Add the resource definition of a STT recognizer ([commit 2f4ff72](https://github.com/googleapis/google-cloud-dotnet/commit/2f4ff7209aa4b7942f36bebda1413298d554245a))

## Version 2.7.0, released 2023-05-03

### New features

- Support for generating summaries during conversation analysis ([commit c70b046](https://github.com/googleapis/google-cloud-dotnet/commit/c70b046ffae1b852cbad6a3a8dc495172770afa8))

## Version 2.6.0, released 2023-04-12

### New features

- Launch UploadConversation endpoint ([commit 99ac4c9](https://github.com/googleapis/google-cloud-dotnet/commit/99ac4c9821b8315805959915b2d0bb48c9c4357e))

### Documentation improvements

- Reformat some lines of code ([commit 3721f87](https://github.com/googleapis/google-cloud-dotnet/commit/3721f874ba11b28fff8b2a89405d0babef8a65fa))

## Version 2.5.0, released 2023-03-06

### New features

- Add a way to specify the conversation automatic analysis percentage for the UploadConversation API when creating Analyses in Insights ([commit 02f447e](https://github.com/googleapis/google-cloud-dotnet/commit/02f447e727147530aadf0f76e4d12d8c809f5525))

## Version 2.4.0, released 2023-02-08

### New features

- Add IngestConversationsStats ([commit 467ac8e](https://github.com/googleapis/google-cloud-dotnet/commit/467ac8e5ec448df06ad7e4f9a749e2f3ef925929))

### Documentation improvements

- Reformat some lines of code ([commit 467ac8e](https://github.com/googleapis/google-cloud-dotnet/commit/467ac8e5ec448df06ad7e4f9a749e2f3ef925929))

## Version 2.3.0, released 2023-01-18

### New features

- Enable REST transport in C# ([commit 0f8560c](https://github.com/googleapis/google-cloud-dotnet/commit/0f8560c840725bf41bc060c8beecafc7d99f38eb))

## Version 2.2.1, released 2022-12-15

Patch release due to a release failure in 2.2.0.
This has the exact same code as 2.2.0 should have had, but rolling
forward is simpler than trying to re-release 2.2.0.

## Version 2.2.0, released 2022-12-14

### New features

- Add Configurable Analysis, Bulk Upload, Bulk Analyze, Delete Issue Apis ([commit 6f38b9f](https://github.com/googleapis/google-cloud-dotnet/commit/6f38b9fdafff95df2d059178a6e96b2175dd368d))

## Version 2.1.0, released 2022-09-15

### Documentation improvements

- Updating comments ([commit d3d45d0](https://github.com/googleapis/google-cloud-dotnet/commit/d3d45d08c53e657abbdc82539a8882c39d603a89))
- Updating comments ([commit d2c2f44](https://github.com/googleapis/google-cloud-dotnet/commit/d2c2f4497c029f388c583d7079f487136915b18a))

## Version 2.0.0, released 2022-06-08

### Documentation improvements

- Updating comments ([commit dc72a89](https://github.com/googleapis/google-cloud-dotnet/commit/dc72a89ff01ed2eb919c50881520956afa6558c3))

## Version 1.3.0, released 2022-04-26

### Documentation improvements

- Clarify comments of ConversationView enum ([commit 386897f](https://github.com/googleapis/google-cloud-dotnet/commit/386897f1e70a91bcdbe262a7b0c4dc51f7229b92))

## Version 1.2.0, released 2022-01-17

### New features

- New API for the View resource ([commit 0810531](https://github.com/googleapis/google-cloud-dotnet/commit/08105316df285d5adb1f95a9213f420b6783cc49))

## Version 1.1.0, released 2021-12-07

- [Commit c917530](https://github.com/googleapis/google-cloud-dotnet/commit/c917530): feat: Add WriteDisposition to BigQuery Export API
- [Commit 2e7bb0f](https://github.com/googleapis/google-cloud-dotnet/commit/2e7bb0f): feat: remove feature flag disable_issue_modeling
- [Commit 053ecfd](https://github.com/googleapis/google-cloud-dotnet/commit/053ecfd):
  - feat: new feature flag disable_issue_modeling
  - docs: fixed formatting issues in the reference documentation

## Version 1.0.0, released 2021-11-10

First GA release.

- [Commit 6cf6933](https://github.com/googleapis/google-cloud-dotnet/commit/6cf6933):
  - feat: Add ability to update phrase matchers
  - feat: Add issue model stats to time series
  - feat: Add display name to issue model stats
- [Commit f7c2450](https://github.com/googleapis/google-cloud-dotnet/commit/f7c2450):
  - feat: deprecate issue_matches
  - docs: if conversation medium is unspecified, it will default to PHONE_CALL

## Version 1.0.0-beta03, released 2021-09-29

- [Commit ddab19e](https://github.com/googleapis/google-cloud-dotnet/commit/ddab19e):
  - feat: add metadata from dialogflow related to transcript segment
  - feat: add sentiment data for transcript segment
  - feat: add obfuscated if from dialogflow

## Version 1.0.0-beta02, released 2021-09-23

- [Commit 37fa769](https://github.com/googleapis/google-cloud-dotnet/commit/37fa769):
  - feat: filter is used to filter conversations used for issue model training
  - feat: update_time is used to indicate when the phrase matcher was updated
- [Commit bb4e4ba](https://github.com/googleapis/google-cloud-dotnet/commit/bb4e4ba): feat: display_name is the display name for the assigned issue
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs
- [Commit bd5d389](https://github.com/googleapis/google-cloud-dotnet/commit/bd5d389):
  - feat: add new issue model API methods
  - feat: support Dialogflow and user-specified participant IDs
  - docs: update pubsub_notification_settings docs

## Version 1.0.0-beta01, released 2021-08-10

Initial release.
