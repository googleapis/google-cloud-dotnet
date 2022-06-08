# Version history

## Version 2.0.0-alpha01, released 2022-06-08

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code.The changes that aren't specific to any given API are [described in the Google Cloud
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
## Version 1.0.0-alpha12, released 2022-05-24

### Bug fixes

- CustomDimension and CustomMetric resource configuration in Analytics Admin API ([commit 2a16d98](https://github.com/googleapis/google-cloud-dotnet/commit/2a16d9851457e8fccdef93e1c8c479e46d150da1))

## Version 1.0.0-alpha11, released 2022-03-14

### New features

- **BREAKING CHANGE** Remove `WebDataStream`, `IosAppDataStream`, `AndroidAppDataStream` resources, and corresponding operations, as they are replaced by the `DataStream` resource ([commit 9f989fd](https://github.com/googleapis/google-cloud-dotnet/commit/9f989fd74cd939ea7b6e08cb95f3aa8d567464ce))
- Add `restricted_metric_type` field to the `CustomMetric` resource ([commit 9f989fd](https://github.com/googleapis/google-cloud-dotnet/commit/9f989fd74cd939ea7b6e08cb95f3aa8d567464ce))
- **BREAKING CHANGE** Move the `GlobalSiteTag` resource from the property level to the data stream level ([commit 9f989fd](https://github.com/googleapis/google-cloud-dotnet/commit/9f989fd74cd939ea7b6e08cb95f3aa8d567464ce))
## Version 1.0.0-alpha10, released 2022-01-17

### Bug fixes

- **BREAKING CHANGE** Remove `GetEnhancedMeasurementSettings`, `UpdateEnhancedMeasurementSettingsRequest`, `UpdateEnhancedMeasurementSettingsRequest` operations from the API ([commit 2a70fba](https://github.com/googleapis/google-cloud-dotnet/commit/2a70fbab54fb4c9fdac5b742a382e0f17b73d853))

### New features

- Add the `AcknowledgeUserDataCollection` operation which acknowledges the terms of user data collection for the specified property ([commit 2a70fba](https://github.com/googleapis/google-cloud-dotnet/commit/2a70fbab54fb4c9fdac5b742a382e0f17b73d853))
- Add the new resource type `DataStream`, which is planned to eventually replace `WebDataStream`, `IosAppDataStream`, `AndroidAppDataStream` resources ([commit 2a70fba](https://github.com/googleapis/google-cloud-dotnet/commit/2a70fbab54fb4c9fdac5b742a382e0f17b73d853))
- Add `CreateDataStream`, `DeleteDataStream`, `UpdateDataStream`, `ListDataStreams` operations to support the new `DataStream` resource ([commit 2a70fba](https://github.com/googleapis/google-cloud-dotnet/commit/2a70fbab54fb4c9fdac5b742a382e0f17b73d853))
- Add `DISPLAY_VIDEO_360_ADVERTISER_LINK`,  `DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL` fields to `ChangeHistoryResourceType` enum ([commit 2a70fba](https://github.com/googleapis/google-cloud-dotnet/commit/2a70fbab54fb4c9fdac5b742a382e0f17b73d853))
- Add the `account` field to the `Property` type ([commit 2a70fba](https://github.com/googleapis/google-cloud-dotnet/commit/2a70fbab54fb4c9fdac5b742a382e0f17b73d853))

### Documentation improvements

- Update the documentation with a new list of valid values for `UserLink.direct_roles` field ([commit 2a70fba](https://github.com/googleapis/google-cloud-dotnet/commit/2a70fbab54fb4c9fdac5b742a382e0f17b73d853))
## Version 1.0.0-alpha09, released 2021-09-23

- [Commit 31dfcff](https://github.com/googleapis/google-cloud-dotnet/commit/31dfcff):
  - feat: add `GetDataRetentionSettings`, `UpdateDataRetentionSettings` methods to the API
  - feat: add `GetDisplayVideo360AdvertiserLink`, `ListDisplayVideo360AdvertiserLinks`, `CreateDisplayVideo360AdvertiserLink`, `DeleteDisplayVideo360AdvertiserLink` methods to the API
  - feat: add `GetDisplayVideo360AdvertiserLinkProposal`, `ListDisplayVideo360AdvertiserLinkProposals`,`DeleteDisplayVideo360AdvertiserLinkProposal`, `CancelDisplayVideo360AdvertiserLinkProposal` methods to the API
  - feat: add `LinkProposalStatusDetails`, `DisplayVideo360AdvertiserLinkProposal`, `DisplayVideo360AdvertiserLink`
  - `LinkProposalState`, `LinkProposalInitiatingProduct`, `ServiceLevel`, `DataRetentionSettings` types to the API
  - feat: add `service_level` field to `Property` type
  - feat: add `display_video_360_advertiser_link`, `display_video_360_advertiser_link_proposal`, `data_retention_settings` fields to `ChangeHistoryChange.resource` oneof field.
  - feat: add `custom` output only field to `ConversionEvent` type
  - feat: change `measurement_unit` field to mutable in `CustomMetric` type
  - fix!: remove `UpdateFirebaseLink` method from the API
  - fix!: rename `is_deletable` field of `ConversionEvent` type to `deletable`
  - fix!: rename `email_address` field of `GoogleAdsLink` type to `creator_email_address`
  - fix!: remove `maximum_user_access` field from `FirebaseLink` type
  - fix!: remove `MaximumUserAccess` enum from the API

## Version 1.0.0-alpha08, released 2021-08-18

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-alpha07, released 2021-06-22

- [Commit 1ca49a3](https://github.com/googleapis/google-cloud-dotnet/commit/1ca49a3):
  - feat: add `GetMeasurementProtocolSecret`, `ListMeasurementProtocolSecrets`, `CreateMeasurementProtocolSecret`, `DeleteMeasurementProtocolSecret`, `UpdateMeasurementProtocolSecret` methods to the API
  - feat: add `GetGoogleSignalsSettings`, `UpdateGoogleSignalsSettings` methods to the API
  - feat: add `CreateConversionEvent`, `GetConversionEvent`, `DeleteConversionEvent`, `ListConversionEvents` methods to the API
  - feat: add `CreateCustomDimension`, `GetCustomDimension`, `UpdateCustomDimension`, `ListCustomDimensions`, `ArchiveCustomDimension` methods to the API
  - feat: add `CreateCustomMetric`, `GetCustomMetric`, `UpdateCustomMetric`, `ListCustomMetrics`, `ArchiveCustomMetric` methods to the API
  - feat: add `GoogleSignalsState`, `GoogleSignalsConsent` types
  - feat: add `GoogleSignalsSettings` type
  - feat: add `MeasurementProtocolSecret` type
  - feat: add `ConversionEvent` type
  - feat: add `CustomDimension` type
  - feat: add `CustomMetric` type
  - feat: extend `ChangeHistoryResourceType` enum to support `GOOGLE_SIGNALS_SETTINGS`, `CONVERSION_EVENT`, `MEASUREMENT_PROTOCOL_SECRET`, `CUSTOM_DIMENSION`, `CUSTOM_METRIC` values fix: label `email_address` field of `UserLink` type as immutable fix: label `name` field of `UserLink` type as output only

## Version 1.0.0-alpha06, released 2021-04-28

- [Commit b01d59c](https://github.com/googleapis/google-cloud-dotnet/commit/b01d59c):
  - fix!: remove `CreateIosAppDataStream`, `CreateAndroidAppDataStream` methods from the API
  - feat: add `SearchChangeHistoryEvents` method to the API
  - fix!: update `DeleteProperty` method to return the deleted property data as `Property` type instead of returning an empty response
  - feat: add `ActorType`, `ActionType`, `ChangeHistoryResourceType`, `ChangeHistoryEvent`, `ChangeHistoryChange` types used by `SearchChangeHistoryEvents` method
  - fix!: update `time_zone` field of `Property` type to be required
  - feat: add `delete_time`, `expire_time` output only fields to `Property` type
  - fix!: remove `deleted` field from `Property` type

## Version 1.0.0-alpha05, released 2021-04-14

- [Commit 6904fb8](https://github.com/googleapis/google-cloud-dotnet/commit/6904fb8): fix: add `https://www.googleapis.com/auth/analytics.edit` OAuth2 scope to the list of acceptable scopes for all read only methods of the Admin API docs: update the documentation of the `update_mask` field used by Update() methods

## Version 1.0.0-alpha04, released 2021-02-05

- [Commit 3a758af](https://github.com/googleapis/google-cloud-dotnet/commit/3a758af):
  - fix!: remove unused fields from `EnhancedMeasurementSettings`
  - fix!: `update_mask` field is required for all Update operations
  - feat: add pagination support for `ListFirebaseLinks` operation
  - fix!: rename `country_code` field to `region_code` in `Account`
  - fix!: rename `url_query_parameter` field to `uri_query_parameter` in `EnhancedMeasurementSettings`
  - fix!: remove `parent` field from `GoogleAdsLink` ([issue 5841](https://github.com/googleapis/google-cloud-dotnet/issues/5841))
- [Commit 99b6d03](https://github.com/googleapis/google-cloud-dotnet/commit/99b6d03): docs: put markdown table in a codeblock
- [Commit 4f5c935](https://github.com/googleapis/google-cloud-dotnet/commit/4f5c935): feat: Add global site tag name

## Version 1.0.0-alpha03, released 2020-11-19

- [Commit 766a6d0](https://github.com/googleapis/google-cloud-dotnet/commit/766a6d0):
  - fix: 'requests' field of CreateUserLink, UpdateUserLink, DeleteUserLink methods is now required
  - docs: minor documentation updates

## Version 1.0.0-alpha02, released 2020-11-05

- [Commit 667e40f](https://github.com/googleapis/google-cloud-dotnet/commit/667e40f): docs: renamed App + Web to Google Analytics 4 (GA4) in public documentation
- [Commit 7824ab2](https://github.com/googleapis/google-cloud-dotnet/commit/7824ab2): feat: added ListAccountSummaries method ([issue 5441](https://github.com/googleapis/google-cloud-dotnet/issues/5441))
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

## Version 1.0.0-alpha01, released 2020-07-14

Initial alpha release.


