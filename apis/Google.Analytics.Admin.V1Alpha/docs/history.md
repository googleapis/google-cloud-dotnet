# Version history

## Version 2.0.0-alpha22, released 2025-03-10

### New features

- Added support for KeyEvents AdminAPI ChangeHistory ([commit 9112be9](https://github.com/googleapis/google-cloud-dotnet/commit/9112be9248c78c11e105d3f47a3776ce64425545))

## Version 2.0.0-alpha21, released 2025-02-03

### Bug fixes

- Mark `event_data_retention` field in `DataRetentionSettings` as `REQUIRED` ([commit 22ae76a](https://github.com/googleapis/google-cloud-dotnet/commit/22ae76a162d95a8aee08c1b21a5540f335b2da53))

### New features

- Add `user_data_retention` field to `DataRetentionSettings` and mark as `REQUIRED` ([commit 22ae76a](https://github.com/googleapis/google-cloud-dotnet/commit/22ae76a162d95a8aee08c1b21a5540f335b2da53))

### Documentation improvements

- Replace "GA4" with "Google Analytics" or "GA" in all comments ([commit 22ae76a](https://github.com/googleapis/google-cloud-dotnet/commit/22ae76a162d95a8aee08c1b21a5540f335b2da53))

## Version 2.0.0-alpha20, released 2024-08-05

### Bug fixes

- **BREAKING CHANGE** Rename custom method `CreateSubpropertyRequest` to `ProvisionSubpropertyRequest` ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))

### New features

- Add `GetKeyEvent`, `CreateKeyEvent`, `ListKeyEvents`, `UpdateKeyEvent`, and `DeleteKeyEvent` methods ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))
- Mark `GetConversionEvent`, `CreateConversionEvent`, `ListConversionEvents`, `UpdateConversionEvent`, and `DeleteConversionEvent` methods as deprecated ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))
- Add the `create_time` field to the `Audience` resource ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))
- Add the `primary` field to the `ChannelGroup` resource ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))
- Add `CreateBigQueryLink`, `UpdateBigQueryLink`, and `DeleteBigQueryLink` methods ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))
- Add the `dataset_location` field to the `BigQueryLink` resource ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))
- Add the `BIGQUERY_LINK` option to the `ChangeHistoryResourceType` enum ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))
- Add the `gmp_organization` field to the `Account` resource ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))
- Add `GetEventEditRule`, `CreateEventEditRule`, `ListEventEditRules`, `UpdateEventEditRule`, `DeleteEventEditRule`, and `ReorderEventEditRules` methods to the Admin API v1 alpha ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))

### Documentation improvements

- Add deprecation comment to `GetConversionEvent`, `CreateConversionEvent`, `ListConversionEvents`, `UpdateConversionEvent`, and `DeleteConversionEvent` methods ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))
- Improve comment formatting of the `parent` field in `CreateFirebaseLinkRequest` and `ListFirebaseLinksRequest` ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))
- Improve comment formatting of the `name` field in `DeleteFirebaseLinkRequest`, `GetGlobalSiteTagRequest`, and `GetDataSharingSettingsRequest` ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))
- Improve comment formatting of `account` and `property` fields in `SearchChangeHistoryEventsRequest` ([commit 998db44](https://github.com/googleapis/google-cloud-dotnet/commit/998db446b4a48cc8addaf19c30d54bebf8950b3d))

## Version 2.0.0-alpha19, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-alpha18, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-alpha17, released 2024-03-13

No API surface changes; just dependency updates.

## Version 2.0.0-alpha16, released 2024-02-08

### New features

- Add `GetCalculatedMetric`, `CreateCalculatedMetric`, `ListCalculatedMetrics`, `UpdateCalculatedMetric`, `DeleteCalculatedMetric` methods to the Admin API v1alpha ([commit 7e182b3](https://github.com/googleapis/google-cloud-dotnet/commit/7e182b31f53fef45ab151247c672a4a70a825138))
- Add the `CALCULATED_METRIC` option to the `ChangeHistoryResourceType` enum ([commit 7e182b3](https://github.com/googleapis/google-cloud-dotnet/commit/7e182b31f53fef45ab151247c672a4a70a825138))
- Add the `calculated_metric` field to the `ChangeHistoryResource.resource` oneof field ([commit 7e182b3](https://github.com/googleapis/google-cloud-dotnet/commit/7e182b31f53fef45ab151247c672a4a70a825138))
- Add the `CalculatedMetric` resource ([commit 7e182b3](https://github.com/googleapis/google-cloud-dotnet/commit/7e182b31f53fef45ab151247c672a4a70a825138))

## Version 2.0.0-alpha15, released 2024-01-08

### Bug fixes

- **BREAKING CHANGE** Remove values `PAID_AND_ORGANIC_CHANNELS_FIRST_CLICK`, `PAID_AND_ORGANIC_CHANNELS_LINEAR`, `PAID_AND_ORGANIC_CHANNELS_POSITION_BASED`, `PAID_AND_ORGANIC_CHANNELS_TIME_DECAY` corresponding to the deprecated attribution models from the `ReportingAttributionModel` enum, as per announcement in https://support.google.com/analytics/answer/9164320[issue 040623](https://github.com/googleapis/google-cloud-dotnet/issues/040623) ([commit c84ffbc](https://github.com/googleapis/google-cloud-dotnet/commit/c84ffbc15dbfd02f6583db2ec96b6e72c9c83e12))

### New features

- Add `GetSubpropertyEventFilter`, `ListSubpropertyEventFilters` methods to the Admin API v1 alpha ([commit c84ffbc](https://github.com/googleapis/google-cloud-dotnet/commit/c84ffbc15dbfd02f6583db2ec96b6e72c9c83e12))
- Add the `default_conversion_value` field to the `ConversionEvent` type ([commit c84ffbc](https://github.com/googleapis/google-cloud-dotnet/commit/c84ffbc15dbfd02f6583db2ec96b6e72c9c83e12))

### Documentation improvements

- Update the documentation for the `RunAccessReport` method ([commit c84ffbc](https://github.com/googleapis/google-cloud-dotnet/commit/c84ffbc15dbfd02f6583db2ec96b6e72c9c83e12))
- Update the documentation for `grouping_rule`, `system_defined` fields of the `ChannelGroup` type ([commit c84ffbc](https://github.com/googleapis/google-cloud-dotnet/commit/c84ffbc15dbfd02f6583db2ec96b6e72c9c83e12))

## Version 2.0.0-alpha14, released 2023-10-25

### Bug fixes

- **BREAKING CHANGE** Delete `BatchDeleteUserLinks`, `DeleteUserLink`, `BatchUpdateUserLinks`, `UpdateUserLink`, `BatchCreateUserLinks`, `CreateUserLink`, `AuditUserLinks`, `ListUserLinks`, `BatchGetUserLinks`, `GetUserLink` from the Admin API v1 alpha as per the announcement in https://bit.ly/46yBIDt ([commit 5948499](https://github.com/googleapis/google-cloud-dotnet/commit/5948499acbe3711fe1e3a05c691a41918b26ea1c))

### New features

- Add `UpdateDataRedactionSettings`, `CreateRollupProperty`, `GetRollupPropertySourceLink`, `ListRollupPropertySourceLinks`, `CreateRollupPropertySourceLink`, `DeleteRollupPropertySourceLink`, `CreateSubproperty`, `CreateSubpropertyEventFilter`, `CreateSubpropertyEventFilter`, `ListSubpropertyEventFilters`, `UpdateSubpropertyEventFilter`, `DeleteSubpropertyEventFilter` methods to the Admin API v1 alpha ([commit 5948499](https://github.com/googleapis/google-cloud-dotnet/commit/5948499acbe3711fe1e3a05c691a41918b26ea1c))
- Add `include_all_users`, `expand_groups` fields to `RunAccessReportRequest` ([commit 5948499](https://github.com/googleapis/google-cloud-dotnet/commit/5948499acbe3711fe1e3a05c691a41918b26ea1c))
- Add `DataRedactionSettings`, `RollupPropertySourceLink`, `SubpropertyEventFilterCondition`, `SubpropertyEventFilterExpression`, `SubpropertyEventFilterExpressionList`, `SubpropertyEventFilterClause`, `SubpropertyEventFilter` types ([commit 5948499](https://github.com/googleapis/google-cloud-dotnet/commit/5948499acbe3711fe1e3a05c691a41918b26ea1c))
- Add the `DATA_REDACTION_SETTINGS` option to the `ChangeHistoryResourceType` enum ([commit 5948499](https://github.com/googleapis/google-cloud-dotnet/commit/5948499acbe3711fe1e3a05c691a41918b26ea1c))
- Add the `data_redaction_settings` field to the `ChangeHistoryResource.resource` oneof field ([commit 5948499](https://github.com/googleapis/google-cloud-dotnet/commit/5948499acbe3711fe1e3a05c691a41918b26ea1c))

## Version 2.0.0-alpha13, released 2023-09-01

### Bug fixes

- **BREAKING CHANGE** Rename the `enterprise_daily_export_enabled` field to `fresh_daily_export_enabled` in the `BigQueryLink` resource ([commit 58e7869](https://github.com/googleapis/google-cloud-dotnet/commit/58e786952625c333bd690f1a9e64687e5d68a2fc))

### New features

- Add `GetSKAdNetworkConversionValueSchema`, `CreateSKAdNetworkConversionValueSchema`, `DeleteSKAdNetworkConversionValueSchema`, `UpdateSKAdNetworkConversionValueSchema`, `ListSKAdNetworkConversionValueSchemas` methods to the Admin API v1 alpha ([commit 58e7869](https://github.com/googleapis/google-cloud-dotnet/commit/58e786952625c333bd690f1a9e64687e5d68a2fc))
- Add the `skadnetwork_conversion_value_schema` field to the `ChangeHistoryResource.resource` oneof type ([commit 58e7869](https://github.com/googleapis/google-cloud-dotnet/commit/58e786952625c333bd690f1a9e64687e5d68a2fc))
- Add the `SKADNETWORK_CONVERSION_VALUE_SCHEMA` option to the `ChangeHistoryResourceType` enum ([commit 58e7869](https://github.com/googleapis/google-cloud-dotnet/commit/58e786952625c333bd690f1a9e64687e5d68a2fc))
- Add `CoarseValue`, `ConversionValues`, `EventMapping`, `SKAdNetworkConversionValueSchema` types ([commit 58e7869](https://github.com/googleapis/google-cloud-dotnet/commit/58e786952625c333bd690f1a9e64687e5d68a2fc))

## Version 2.0.0-alpha12, released 2023-08-16

### Bug fixes

- **BREAKING CHANGE** Rename the `enterprise_daily_export_enabled` field to `fresh_daily_export_enabled` in the `BigQueryLink` resource ([commit bb7b89d](https://github.com/googleapis/google-cloud-dotnet/commit/bb7b89df13baa26b976c2829cd4c41349853bd4e))

### New features

- Add `UpdateConversionEvent` method to the Admin API v1 alpha ([commit bb7b89d](https://github.com/googleapis/google-cloud-dotnet/commit/bb7b89df13baa26b976c2829cd4c41349853bd4e))
- Add the `counting_method` field to the `ConversionEvent` type ([commit bb7b89d](https://github.com/googleapis/google-cloud-dotnet/commit/bb7b89df13baa26b976c2829cd4c41349853bd4e))
- Add the `ConversionCountingMethod` enum ([commit bb7b89d](https://github.com/googleapis/google-cloud-dotnet/commit/bb7b89df13baa26b976c2829cd4c41349853bd4e))

## Version 2.0.0-alpha11, released 2023-08-04

### Bug fixes

- **BREAKING CHANGE** Update the `ReportingAttributionModel` enum to rename `CROSS_CHANNEL_DATA_DRIVEN` to `PAID_AND_ORGANIC_CHANNELS_DATA_DRIVEN`, `CROSS_CHANNEL_LAST_CLICK` to `PAID_AND_ORGANIC_CHANNELS_LAST_CLICK`, `CROSS_CHANNEL_FIRST_CLICK` to `PAID_AND_ORGANIC_CHANNELS_FIRST_CLICK`, `CROSS_CHANNEL_LINEAR` to `PAID_AND_ORGANIC_CHANNELS_LINEAR`, `CROSS_CHANNEL_POSITION_BASED` to `PAID_AND_ORGANIC_CHANNELS_POSITION_BASED` `CROSS_CHANNEL_TIME_DECAY` to `PAID_AND_ORGANIC_CHANNELS_TIME_DECAY`, `ADS_PREFERRED_LAST_CLICK` to `GOOGLE_PAID_CHANNELS_LAST_CLICK` ([commit c79ae51](https://github.com/googleapis/google-cloud-dotnet/commit/c79ae51d613741a86429d3a9b151867f9622d9db))
- **BREAKING CHANGE** Update the `AdsWebConversionDataExportScope` enum to rename `CROSS_CHANNEL` to `PAID_AND_ORGANIC_CHANNELS`, `ADS_PREFERRED` to `GOOGLE_PAID_CHANNELS` ([commit c79ae51](https://github.com/googleapis/google-cloud-dotnet/commit/c79ae51d613741a86429d3a9b151867f9622d9db))

## Version 2.0.0-alpha10, released 2023-06-27

### New features

- Update the `default_uri` field of the `WebStreamData` type to be mutable ([commit e8c8b20](https://github.com/googleapis/google-cloud-dotnet/commit/e8c8b209240faca77da8e750e2feb15b01155982))
- Add the `ads_web_conversion_data_export_scope` field to the `ReportingAttributionModel` type ([commit e8c8b20](https://github.com/googleapis/google-cloud-dotnet/commit/e8c8b209240faca77da8e750e2feb15b01155982))
- Add `AdsWebConversionDataExportScope` enum to the Admin API v1alpha ([commit e8c8b20](https://github.com/googleapis/google-cloud-dotnet/commit/e8c8b209240faca77da8e750e2feb15b01155982))

### Documentation improvements

- Announce the deprecation of first-click, linear, time-decay and position-based attribution models ([commit e8c8b20](https://github.com/googleapis/google-cloud-dotnet/commit/e8c8b209240faca77da8e750e2feb15b01155982))

## Version 2.0.0-alpha09, released 2023-05-16

### New features

- Add `GetAdSenseLink`, `CreateAdSenseLink`, `DeleteAdSenseLink`, `ListAdSenseLinks` methods to the Admin API v1alpha ([commit 9e6f80c](https://github.com/googleapis/google-cloud-dotnet/commit/9e6f80cee15d2582dad4f230ada810a24d808374))
- Add `FetchConnectedGa4Property` method to the Admin API v1alpha ([commit 9e6f80c](https://github.com/googleapis/google-cloud-dotnet/commit/9e6f80cee15d2582dad4f230ada810a24d808374))
- Add `CreateEventCreateRule`, `UpdateEventCreateRule`,`DeleteEventCreateRule`, `ListEventCreateRules` methods to the Admin API v1alpha ([commit 9e6f80c](https://github.com/googleapis/google-cloud-dotnet/commit/9e6f80cee15d2582dad4f230ada810a24d808374))
- Add `EventCreateRule`, `MatchingCondition` types to the Admin API v1alpha ([commit 9e6f80c](https://github.com/googleapis/google-cloud-dotnet/commit/9e6f80cee15d2582dad4f230ada810a24d808374))
- Add `AdSenseLink` type to the Admin API v1alpha ([commit 9e6f80c](https://github.com/googleapis/google-cloud-dotnet/commit/9e6f80cee15d2582dad4f230ada810a24d808374))
- Add `AUDIENCE`, `EVENT_CREATE_RULE` options to the `ChangeHistoryResourceType` enum ([commit 9e6f80c](https://github.com/googleapis/google-cloud-dotnet/commit/9e6f80cee15d2582dad4f230ada810a24d808374))
- Add `audience`, `event_create_rule` fields to the `ChangeHistoryResource.resource` oneof field ([commit 9e6f80c](https://github.com/googleapis/google-cloud-dotnet/commit/9e6f80cee15d2582dad4f230ada810a24d808374))

## Version 2.0.0-alpha08, released 2023-05-03

### New features

- Add FetchConnectedGa4Property method to the Admin API v1alpha ([commit c8b636f](https://github.com/googleapis/google-cloud-dotnet/commit/c8b636f560e7144b101451be96564d247e0eb879))
- Add `GetChannelGroup`, `ListChannelGroups`, `CreateChannelGroup`, `UpdateChannelGroup` methods to the Admin API v1alpha ([commit c8b636f](https://github.com/googleapis/google-cloud-dotnet/commit/c8b636f560e7144b101451be96564d247e0eb879))
- Add `ChannelGroupFilter`, `ChannelGroupFilterExpression`, `ChannelGroupFilterExpressionList`, `GroupingRule`, `ChannelGroup` types to the Admin API v1alpha ([commit c8b636f](https://github.com/googleapis/google-cloud-dotnet/commit/c8b636f560e7144b101451be96564d247e0eb879))

## Version 2.0.0-alpha07, released 2023-03-27

### New features

- Add account-level binding for the`RunAccessReport` method (example: /v1alpha/accounts/1234567:runAccessReport) ([commit 94adeed](https://github.com/googleapis/google-cloud-dotnet/commit/94adeed8d5afba8d537ec2787f1bee54d7ab271f))
- Add `GetEnhancedMeasurementSettings`, `UpdateEnhancedMeasurementSettings` methods to the Admin API v1alpha ([commit 94adeed](https://github.com/googleapis/google-cloud-dotnet/commit/94adeed8d5afba8d537ec2787f1bee54d7ab271f))
- Add `CreateConnectedSiteTag`, `DeleteConnectedSiteTag`, `ListConnectedSiteTags` methods to the Admin API v1alpha ([commit 94adeed](https://github.com/googleapis/google-cloud-dotnet/commit/94adeed8d5afba8d537ec2787f1bee54d7ab271f))
- Add `EnhancedMeasurementSettings`, `ConnectedSiteTag` resource types to the Admin API v1alpha ([commit 94adeed](https://github.com/googleapis/google-cloud-dotnet/commit/94adeed8d5afba8d537ec2787f1bee54d7ab271f))
- Add `GetEnhancedMeasurementSettingsRequest`, ([commit 94adeed](https://github.com/googleapis/google-cloud-dotnet/commit/94adeed8d5afba8d537ec2787f1bee54d7ab271f))
- Add `ENHANCED_MEASUREMENT_SETTINGS` option to the `ChangeHistoryResourceType` enum ([commit 94adeed](https://github.com/googleapis/google-cloud-dotnet/commit/94adeed8d5afba8d537ec2787f1bee54d7ab271f))
- Add `enhanced_measurement_settings` option to the `ChangeHistoryResource.resource` oneof field ([commit 94adeed](https://github.com/googleapis/google-cloud-dotnet/commit/94adeed8d5afba8d537ec2787f1bee54d7ab271f))
- Add `intraday_export_enabled` field to the `BigQueryLink` resource ([commit 94adeed](https://github.com/googleapis/google-cloud-dotnet/commit/94adeed8d5afba8d537ec2787f1bee54d7ab271f))

## Version 2.0.0-alpha06, released 2023-02-21

### New features

- Add `CreateAccessBinding`, `GetAccessBinding`, `UpdateAccessBinding`, `DeleteAccessBinding`, `ListAccessBindings`, `BatchCreateAccessBindings`, `BatchGetAccessBindings`, `BatchUpdateAccessBindings`, `BatchDeleteAccessBindings` methods to the Admin API v1alpha ([commit 60827e8](https://github.com/googleapis/google-cloud-dotnet/commit/60827e81ee3eed5a4c92b26070385b7e46451172))
- Add `GetExpandedDataSet`, `ListExpandedDataSets`, `CreateExpandedDataSet`, `UpdateExpandedDataSet`, `DeleteExpandedDataSet` methods to the Admin API v1alpha ([commit 60827e8](https://github.com/googleapis/google-cloud-dotnet/commit/60827e81ee3eed5a4c92b26070385b7e46451172))
- Add `AccessBinding`, `ExpandedDataSet`, `ExpandedDataSetFilter`, `ExpandedDataSetFilterExpression`, `ExpandedDataSetFilterExpressionList` resource types to the Admin API v1alpha ([commit 60827e8](https://github.com/googleapis/google-cloud-dotnet/commit/60827e81ee3eed5a4c92b26070385b7e46451172))

## Version 2.0.0-alpha05, released 2023-02-08

### Bug fixes

- **BREAKING CHANGE** Remove `LESS_THAN_OR_EQUAL`, `GREATER_THAN_OR_EQUAL` values from NumericFilter.Operation enum ([commit 8f3fc34](https://github.com/googleapis/google-cloud-dotnet/commit/8f3fc3433185ee3f9b0f79f4c295b923e6796c1c))
- **BREAKING CHANGE** Remove `PARTIAL_REGEXP` value from StringFilter.MatchType enum ([commit 8f3fc34](https://github.com/googleapis/google-cloud-dotnet/commit/8f3fc3433185ee3f9b0f79f4c295b923e6796c1c))

### New features

- Add `GetSearchAds360Link`, `ListSearchAds360Links`, `CreateSearchAds360Link`, `DeleteSearchAds360Link`, `UpdateSearchAds360Link` methods to the Admin API v1alpha ([commit 8f3fc34](https://github.com/googleapis/google-cloud-dotnet/commit/8f3fc3433185ee3f9b0f79f4c295b923e6796c1c))
- Add `SetAutomatedGa4ConfigurationOptOut`, `FetchAutomatedGa4ConfigurationOptOut` methods to the Admin API v1alpha ([commit 8f3fc34](https://github.com/googleapis/google-cloud-dotnet/commit/8f3fc3433185ee3f9b0f79f4c295b923e6796c1c))
- Add `GetBigQueryLink`, `ListBigQueryLinks` methods to the Admin API v1alpha ([commit 8f3fc34](https://github.com/googleapis/google-cloud-dotnet/commit/8f3fc3433185ee3f9b0f79f4c295b923e6796c1c))
- Add `tokens_per_project_per_hour` field to `AccessQuota` type ([commit 8f3fc34](https://github.com/googleapis/google-cloud-dotnet/commit/8f3fc3433185ee3f9b0f79f4c295b923e6796c1c))
- Add `EXPANDED_DATA_SET`, `CHANNEL_GROUP` values to `ChangeHistoryResourceType` enum ([commit 8f3fc34](https://github.com/googleapis/google-cloud-dotnet/commit/8f3fc3433185ee3f9b0f79f4c295b923e6796c1c))
- Add `search_ads_360_link`, `expanded_data_set`, `bigquery_link` values to ChangeHistoryResource.resource oneof field ([commit 8f3fc34](https://github.com/googleapis/google-cloud-dotnet/commit/8f3fc3433185ee3f9b0f79f4c295b923e6796c1c))
- Add `BigQueryLink`, `SearchAds360Link` resource types to the Admin API v1alpha ([commit 8f3fc34](https://github.com/googleapis/google-cloud-dotnet/commit/8f3fc3433185ee3f9b0f79f4c295b923e6796c1c))

## Version 2.0.0-alpha04, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 2.0.0-alpha03, released 2022-12-14

No API surface changes; just dependency updates.

## Version 2.0.0-alpha02, released 2022-08-26

### New features

- Add `RunAccessReport` method to the Admin API v1alpha ([commit aefb670](https://github.com/googleapis/google-cloud-dotnet/commit/aefb670273c7d80966120278a4be22648601bd4e))
- Add `GetAudience`, 'ListAudience', 'CreateAudience', 'UpdateAudience', 'ArchiveAudience' methods to the Admin API v1alpha ([commit 12697c8](https://github.com/googleapis/google-cloud-dotnet/commit/12697c884fbb2bb660ff58413c6d4ef5a1b7436f))
- Add `GetAttributionSettings`, `UpdateAttributionSettings` methods to the Admin API v1alpha ([commit 12697c8](https://github.com/googleapis/google-cloud-dotnet/commit/12697c884fbb2bb660ff58413c6d4ef5a1b7436f))

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


