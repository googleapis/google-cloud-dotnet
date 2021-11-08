# Version history

# Version 1.0.0-beta07, released 2021-11-08

- [Commit ebf6fab](https://github.com/googleapis/google-cloud-dotnet/commit/ebf6fab):
  - feat: add the `schema_restriction_response` field to the `ResponseMetaData` type that contains the schema restrictions actively enforced in creating a report
  - feat: add the `currency_code`, `time_zone` fields to the `ResponseMetaData` type
  - feat: add the `empty_reason` field to the `ResponseMetaData` type that contains an empty report reason, if specified
  - feat: add the `blocked_reasons` field to the `MetricMetadata` type that contains reasons why access was blocked to a certain metric in a report, if specified

# Version 1.0.0-beta06, released 2021-09-24

- [Commit 75ffe93](https://github.com/googleapis/google-cloud-dotnet/commit/75ffe93):
  - feat: add `CheckCompatibility` method to the API
  - feat: add `DimensionCompatibility`, `MetricCompatibility`, `Compatibility` types to the API
  - feat: add `category` field to `DimensionMetadata`, `MetricMetadata` types

# Version 1.0.0-beta05, released 2021-08-18

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

# Version 1.0.0-beta04, released 2021-07-26

- [Commit 5d64452](https://github.com/googleapis/google-cloud-dotnet/commit/5d64452): feat: add `minute_ranges` field to `RunRealtimeReportRequest` object which can be used to specify the time range (in minutes) for realtime report queries docs: document the increase from 8 to 9 of the number of allowed dimensions in a report query

# Version 1.0.0-beta03, released 2021-04-28

- [Commit 391b953](https://github.com/googleapis/google-cloud-dotnet/commit/391b953):
  - feat: add `kind` field which is used to distinguish between response types
  - feat: add `potentially_thresholded_requests_per_hour` field to `PropertyQuota`

# Version 1.0.0-beta02, released 2021-03-09

- [Commit 20bb7e1](https://github.com/googleapis/google-cloud-dotnet/commit/20bb7e1): fix!: rename the 'page_size', 'page_token', 'total_size' fields to 'limit', 'offset' and 'row_count' respectively

# Version 1.0.0-beta01, released 2021-02-19

Initial release.
