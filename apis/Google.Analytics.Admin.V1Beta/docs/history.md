# Version history

## Version 1.0.0-beta09, released 2025-02-03

### Bug fixes

- Mark `event_data_retention` field in `DataRetentionSettings` as `REQUIRED` ([commit 44fa61c](https://github.com/googleapis/google-cloud-dotnet/commit/44fa61cd05e4920e93ddcb281d9cf1e3edac23ff))

### New features

- Add `user_data_retention` field to `DataRetentionSettings` and mark as `REQUIRED` ([commit 44fa61c](https://github.com/googleapis/google-cloud-dotnet/commit/44fa61cd05e4920e93ddcb281d9cf1e3edac23ff))

### Documentation improvements

- Replace "GA4" with "Google Analytics" or "GA" in all comments ([commit 44fa61c](https://github.com/googleapis/google-cloud-dotnet/commit/44fa61cd05e4920e93ddcb281d9cf1e3edac23ff))

## Version 1.0.0-beta08, released 2024-07-22

### New features

- Add `GetKeyEvent`, `CreateKeyEvent`, `ListKeyEvents`, `UpdateKeyEvent`, `DeleteKeyEvent` methods to the Admin API v1beta ([commit 64af82f](https://github.com/googleapis/google-cloud-dotnet/commit/64af82fa4eb39e9f5149c06ee20b2a9694c3a8a4))
- Mark `GetConversionEvent`, `CreateConversionEvent`, `ListConversionEvents`, `UpdateConversionEvent`, `DeleteConversionEvent` methods as deprecated in the Admin API v1beta ([commit 64af82f](https://github.com/googleapis/google-cloud-dotnet/commit/64af82fa4eb39e9f5149c06ee20b2a9694c3a8a4))
- Add the `default_conversion_value` field to the `ConversionEvent` resource in the Admin API v1beta ([commit 64af82f](https://github.com/googleapis/google-cloud-dotnet/commit/64af82fa4eb39e9f5149c06ee20b2a9694c3a8a4))
- Add the `include_all_users` and `expand_groups` fields to the `RunAccessReportRequest` resource in the Admin API v1beta ([commit 64af82f](https://github.com/googleapis/google-cloud-dotnet/commit/64af82fa4eb39e9f5149c06ee20b2a9694c3a8a4))
- Add the `gmp_organization` field to the `Account` resource in the Admin API v1beta ([commit 64af82f](https://github.com/googleapis/google-cloud-dotnet/commit/64af82fa4eb39e9f5149c06ee20b2a9694c3a8a4))

### Documentation improvements

- Change comment for methods `DeleteAccount`, `DeleteProperty`, and `RunAccessReport` in service `AnalyticsAdminService` ([commit 64af82f](https://github.com/googleapis/google-cloud-dotnet/commit/64af82fa4eb39e9f5149c06ee20b2a9694c3a8a4))
- Change comment in fields `account` and `property` in message `SearchChangeHistoryEventsRequest` ([commit 64af82f](https://github.com/googleapis/google-cloud-dotnet/commit/64af82fa4eb39e9f5149c06ee20b2a9694c3a8a4))
- Change comment for field `property_type` in message `Property` ([commit 64af82f](https://github.com/googleapis/google-cloud-dotnet/commit/64af82fa4eb39e9f5149c06ee20b2a9694c3a8a4))

## Version 1.0.0-beta07, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta06, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.0.0-beta05, released 2024-02-28

No API surface changes; just dependency updates.

## Version 1.0.0-beta04, released 2023-09-01

### Bug fixes

- **BREAKING CHANGE** Add the missing `REQUIRED` annotation to the `update_mask` field of `UpdateMeasurementProtocolSecretRequest` ([commit c54eaea](https://github.com/googleapis/google-cloud-dotnet/commit/c54eaea9c6fb63c36eb3ec72c53da88c64e82dae))

### New features

- Add `UpdateConversionEvent` method to the Admin API v1 beta ([commit c54eaea](https://github.com/googleapis/google-cloud-dotnet/commit/c54eaea9c6fb63c36eb3ec72c53da88c64e82dae))
- Add the `counting_method` field to the `ConversionEvent` type ([commit c54eaea](https://github.com/googleapis/google-cloud-dotnet/commit/c54eaea9c6fb63c36eb3ec72c53da88c64e82dae))
- Add the `ConversionCountingMethod` enum ([commit c54eaea](https://github.com/googleapis/google-cloud-dotnet/commit/c54eaea9c6fb63c36eb3ec72c53da88c64e82dae))
- Add the `ITEM` option to the `DimensionScope` enum ([commit c54eaea](https://github.com/googleapis/google-cloud-dotnet/commit/c54eaea9c6fb63c36eb3ec72c53da88c64e82dae))
- Make the field `default_uri` of `WebStreamData` mutable ([commit c54eaea](https://github.com/googleapis/google-cloud-dotnet/commit/c54eaea9c6fb63c36eb3ec72c53da88c64e82dae))

## Version 1.0.0-beta03, released 2023-03-27

### New features

- Add `RunAccessReport` method (with bindings for account and property resources) to the Admin API v1beta ([commit 2efaa1a](https://github.com/googleapis/google-cloud-dotnet/commit/2efaa1adc9e2c0c7c96f0696928dad011e0888c4))
- Add `AccessDimension`, `AccessMetric`, `AccessDateRange`, `AccessFilterExpression`, `AccessFilterExpressionList`, `AccessFilter`, `AccessStringFilter`, `AccessInListFilter`, `AccessNumericFilter`, `AccessBetweenFilter`, `NumericValue`, `AccessOrderBy`, `AccessDimensionHeader`, `AccessMetricHeader`, `AccessRow`, `AccessDimensionValue`, `AccessMetricValue`, `AccessQuota`, `AccessQuotaStatus` types to the Admin API v1beta ([commit 2efaa1a](https://github.com/googleapis/google-cloud-dotnet/commit/2efaa1adc9e2c0c7c96f0696928dad011e0888c4))

## Version 1.0.0-beta02, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 1.0.0-beta01, released 2022-08-01

Initial release.
