# Version history

## Version 2.0.0-beta09, released 2024-12-05

### New features

- Add `EmptyFilter` type to the Data API v1beta ([commit 1f4a8b3](https://github.com/googleapis/google-cloud-dotnet/commit/1f4a8b3dd4bc8fd91be21f5a270e88af1a1c6c5d))
- Add the `empty_filter` field to the `Filter` type ([commit 1f4a8b3](https://github.com/googleapis/google-cloud-dotnet/commit/1f4a8b3dd4bc8fd91be21f5a270e88af1a1c6c5d))

### Documentation improvements

- Update documentation for the`RunReport` method ([commit 1f4a8b3](https://github.com/googleapis/google-cloud-dotnet/commit/1f4a8b3dd4bc8fd91be21f5a270e88af1a1c6c5d))
- Remove all references to 'GA4' in documentation ([commit 1f4a8b3](https://github.com/googleapis/google-cloud-dotnet/commit/1f4a8b3dd4bc8fd91be21f5a270e88af1a1c6c5d))

## Version 2.0.0-beta08, released 2024-08-05

### New features

- Add the `comparisons` field to the `Metadata` resource ([commit 06b5f26](https://github.com/googleapis/google-cloud-dotnet/commit/06b5f26b32e4914cd8aea9dfc9d000c638c5d0c9))
- Add the `comparisons` field to the `RunReportRequest`, `RunPivotReportRequest` resources ([commit 06b5f26](https://github.com/googleapis/google-cloud-dotnet/commit/06b5f26b32e4914cd8aea9dfc9d000c638c5d0c9))
- Add the `Comparison` type ([commit 06b5f26](https://github.com/googleapis/google-cloud-dotnet/commit/06b5f26b32e4914cd8aea9dfc9d000c638c5d0c9))
- Add the `ComparisonMetadata` type ([commit 06b5f26](https://github.com/googleapis/google-cloud-dotnet/commit/06b5f26b32e4914cd8aea9dfc9d000c638c5d0c9))

### Documentation improvements

- A comment for field `custom_definition` in message `DimensionMetadata` is changed ([commit 06b5f26](https://github.com/googleapis/google-cloud-dotnet/commit/06b5f26b32e4914cd8aea9dfc9d000c638c5d0c9))

## Version 2.0.0-beta07, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-beta06, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-beta05, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.0.0-beta04, released 2023-12-11

### Bug fixes

- **BREAKING CHANGE** Add `optional` label to `consumed`, `remaining` fields of the `QuotaStatus` type ([commit a5715d6](https://github.com/googleapis/google-cloud-dotnet/commit/a5715d6a230fc24222a6cdc8e2840040f93c9e59))

### New features

- Add `CreateAudienceExport`, `QueryAudienceExport`, `GetAudienceExport`, `ListAudienceExports` methods to the Data API v1 beta ([commit a5715d6](https://github.com/googleapis/google-cloud-dotnet/commit/a5715d6a230fc24222a6cdc8e2840040f93c9e59))
- Add `sampling_metadatas` field to `ResponseMetaData` ([commit a5715d6](https://github.com/googleapis/google-cloud-dotnet/commit/a5715d6a230fc24222a6cdc8e2840040f93c9e59))
- Add `SamplingMetadata`, `AudienceExport`, `AudienceExportMetadata`, `AudienceDimensionValue` types ([commit a5715d6](https://github.com/googleapis/google-cloud-dotnet/commit/a5715d6a230fc24222a6cdc8e2840040f93c9e59))

### Documentation improvements

- Updated comments ([commit a5715d6](https://github.com/googleapis/google-cloud-dotnet/commit/a5715d6a230fc24222a6cdc8e2840040f93c9e59))
- Minor formatting ([commit 8c49dd7](https://github.com/googleapis/google-cloud-dotnet/commit/8c49dd73c4e337e7e67db23a8726b5d01d073317))
- Add clarifications ([commit 8c49dd7](https://github.com/googleapis/google-cloud-dotnet/commit/8c49dd73c4e337e7e67db23a8726b5d01d073317))

## Version 2.0.0-beta03, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 2.0.0-beta02, released 2022-10-17

### New features

- Add `subject_to_thresholding` field to `ResponseMetadata` type ([commit 5be9430](https://github.com/googleapis/google-cloud-dotnet/commit/5be9430f582a6fadedcd2f3ccc3aa45dcf0a0253))
- Add `tokens_per_project_per_hour` field to `PropertyQuota` type ([commit 5be9430](https://github.com/googleapis/google-cloud-dotnet/commit/5be9430f582a6fadedcd2f3ccc3aa45dcf0a0253))

## Version 2.0.0-beta01, released 2022-06-08

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
## Version 1.0.0-beta08, released 2022-01-18

No API changes; just dependency updates.
## Version 1.0.0-beta07, released 2021-11-08

- [Commit ebf6fab](https://github.com/googleapis/google-cloud-dotnet/commit/ebf6fab):
  - feat: add the `schema_restriction_response` field to the `ResponseMetaData` type that contains the schema restrictions actively enforced in creating a report
  - feat: add the `currency_code`, `time_zone` fields to the `ResponseMetaData` type
  - feat: add the `empty_reason` field to the `ResponseMetaData` type that contains an empty report reason, if specified
  - feat: add the `blocked_reasons` field to the `MetricMetadata` type that contains reasons why access was blocked to a certain metric in a report, if specified

## Version 1.0.0-beta06, released 2021-09-24

- [Commit 75ffe93](https://github.com/googleapis/google-cloud-dotnet/commit/75ffe93):
  - feat: add `CheckCompatibility` method to the API
  - feat: add `DimensionCompatibility`, `MetricCompatibility`, `Compatibility` types to the API
  - feat: add `category` field to `DimensionMetadata`, `MetricMetadata` types

## Version 1.0.0-beta05, released 2021-08-18

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta04, released 2021-07-26

- [Commit 5d64452](https://github.com/googleapis/google-cloud-dotnet/commit/5d64452): feat: add `minute_ranges` field to `RunRealtimeReportRequest` object which can be used to specify the time range (in minutes) for realtime report queries docs: document the increase from 8 to 9 of the number of allowed dimensions in a report query

## Version 1.0.0-beta03, released 2021-04-28

- [Commit 391b953](https://github.com/googleapis/google-cloud-dotnet/commit/391b953):
  - feat: add `kind` field which is used to distinguish between response types
  - feat: add `potentially_thresholded_requests_per_hour` field to `PropertyQuota`

## Version 1.0.0-beta02, released 2021-03-09

- [Commit 20bb7e1](https://github.com/googleapis/google-cloud-dotnet/commit/20bb7e1): fix!: rename the 'page_size', 'page_token', 'total_size' fields to 'limit', 'offset' and 'row_count' respectively

## Version 1.0.0-beta01, released 2021-02-19

Initial release.
