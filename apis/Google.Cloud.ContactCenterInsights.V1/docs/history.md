# Version history

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
