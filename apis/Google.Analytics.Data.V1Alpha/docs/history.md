# Version history

# Version 1.0.0-alpha05, released 2021-05-25

No API surface changes; just dependency updates.

# Version 1.0.0-alpha04, released 2021-02-05

- [Commit b6675d1](https://github.com/googleapis/google-cloud-dotnet/commit/b6675d1):
  - feat: custom_definition field added to DimensionMetadata object, indicating whether a dimension is a custom dimension for a property
  - feat: custom_definition field added to MetricMetadata object, indicating whether a metric is a custom metric for a property
  - docs: documentation urls updated docs: documentation for Cohort reporting feature is updated ([issue 5658](https://github.com/googleapis/google-cloud-dotnet/issues/5658))

# Version 1.0.0-alpha03, released 2020-11-19

- [Commit 92d988e](https://github.com/googleapis/google-cloud-dotnet/commit/92d988e):
  - fix!: GetUniversalMetadata method removed from the API, GetMetadata method should be used instead feat: reporting requests now support date ranges longer than one year docs: minor documentation updates ([issue 5556](https://github.com/googleapis/google-cloud-dotnet/issues/5556))
  - fix!: GetUniversalMetadata method removed from the API, GetMetadata method should be used instead
  - feat: reporting requests now support date ranges longer than one year
  - docs: minor documentation updates ([issue 5556](https://github.com/googleapis/google-cloud-dotnet/issues/5556))

# Version 1.0.0-alpha02, released 2020-11-05

- [Commit b85cd73](https://github.com/googleapis/google-cloud-dotnet/commit/b85cd73):
  - feat: added RunRealtimeReport method that returns a customized report of realtime event data for a GA4 property
  - docs: minor documentation updates
- [Commit ff07808](https://github.com/googleapis/google-cloud-dotnet/commit/ff07808): docs: App+Web properties renamed to GA4
- [Commit 36b2ef2](https://github.com/googleapis/google-cloud-dotnet/commit/36b2ef2): feat: added GetMetadata method for metadata including custom dimensions and metrics.
- [Commit ee32999](https://github.com/googleapis/google-cloud-dotnet/commit/ee32999):
  - feat!: GetMetadata method renamed to GetUniversalMetdata
  - docs: documentation updates
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 1b0afcc](https://github.com/googleapis/google-cloud-dotnet/commit/1b0afcc):
  - feat: added GetMetadata method
  - feat: DimensionHeader type renamed to PivotDimensionHeader
  - feat: added TYPE_SECONDS,TYPE_CURRENCY to MetricType enum
  - docs: documentation updates

# Version 1.0.0-alpha01, released 2020-08-18

First alpha release.
