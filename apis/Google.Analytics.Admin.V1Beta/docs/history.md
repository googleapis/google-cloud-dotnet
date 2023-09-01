# Version history

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
