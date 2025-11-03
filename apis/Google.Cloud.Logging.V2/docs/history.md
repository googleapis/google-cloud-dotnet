# Version history

## Version 4.5.0, released 2025-11-03

### New features

- Update dependencies

## Version 4.4.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 4.3.0, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 4.2.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 4.1.0, released 2023-06-20

### New features

- Log Analytics features of the Cloud Logging API ([commit 5a7f88f](https://github.com/googleapis/google-cloud-dotnet/commit/5a7f88f19321e890f3f91fecfbc13a2ff1335ed6))
- Add ConfigServiceV2.CreateBucketAsync method for creating Log Buckets asynchronously ([commit 5a7f88f](https://github.com/googleapis/google-cloud-dotnet/commit/5a7f88f19321e890f3f91fecfbc13a2ff1335ed6))
- Add ConfigServiceV2.UpdateBucketAsync method for creating Log Buckets asynchronously ([commit 5a7f88f](https://github.com/googleapis/google-cloud-dotnet/commit/5a7f88f19321e890f3f91fecfbc13a2ff1335ed6))
- Add ConfigServiceV2.CreateLink method for creating linked datasets for Log Analytics Buckets ([commit 5a7f88f](https://github.com/googleapis/google-cloud-dotnet/commit/5a7f88f19321e890f3f91fecfbc13a2ff1335ed6))
- Add ConfigServiceV2.DeleteLink method for deleting linked datasets ([commit 5a7f88f](https://github.com/googleapis/google-cloud-dotnet/commit/5a7f88f19321e890f3f91fecfbc13a2ff1335ed6))
- Add ConfigServiceV2.ListLinks method for listing linked datasets ([commit 5a7f88f](https://github.com/googleapis/google-cloud-dotnet/commit/5a7f88f19321e890f3f91fecfbc13a2ff1335ed6))
- Add ConfigServiceV2.GetLink methods for describing linked datasets ([commit 5a7f88f](https://github.com/googleapis/google-cloud-dotnet/commit/5a7f88f19321e890f3f91fecfbc13a2ff1335ed6))
- Add LogBucket.analytics_enabled field that specifies whether Log Bucket's Analytics features are enabled ([commit 5a7f88f](https://github.com/googleapis/google-cloud-dotnet/commit/5a7f88f19321e890f3f91fecfbc13a2ff1335ed6))
- Add LogBucket.index_configs field that contains a list of Log Bucket's indexed fields and related configuration data ([commit 5a7f88f](https://github.com/googleapis/google-cloud-dotnet/commit/5a7f88f19321e890f3f91fecfbc13a2ff1335ed6))

### Documentation improvements

- Documentation for the Log Analytics features of the Cloud Logging API ([commit 5a7f88f](https://github.com/googleapis/google-cloud-dotnet/commit/5a7f88f19321e890f3f91fecfbc13a2ff1335ed6))

## Version 4.0.0, released 2022-06-08

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
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


## Version 3.6.0, released 2022-02-28

### New features

- KMS configuration in settings ([commit 058dff4](https://github.com/googleapis/google-cloud-dotnet/commit/058dff439fa8075576f7a78e03ec7aceed4b7295))

## Version 3.5.0, released 2022-02-22

### New features

- Update Logging API with latest changes ([commit 644279c](https://github.com/googleapis/google-cloud-dotnet/commit/644279c4e5b4725b6fada108667372b39f52f83e))

## Version 3.4.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 3.3.0, released 2021-05-05

- [Commit 3e216d0](https://github.com/googleapis/google-cloud-dotnet/commit/3e216d0): feat: add the Tailing API to get a live stream of the tail end of filtered logs

## Version 3.2.0, released 2020-11-18

- [Commit 23bc620](https://github.com/googleapis/google-cloud-dotnet/commit/23bc620): feat: Makes remaining LogBucket and LogViews methods public

## Version 3.1.0, released 2020-10-21

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 98e71af](https://github.com/googleapis/google-cloud-dotnet/commit/98e71af): docs: Specify client retry behavior and rename Stackdriver Logging to Cloud Logging
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 29a7aba](https://github.com/googleapis/google-cloud-dotnet/commit/29a7aba): docs: change relative URLs to absolute URLs to fix broken links.

## Version 3.0.0, released 2020-03-18

- [Commit 8727521](https://github.com/googleapis/google-cloud-dotnet/commit/8727521): Large set of changes, primarily to resource names

The listed commit causes lots of breaking changes, but these were expected, and almost all are due to resource name changes.
The logging API is primarily used from integration points, so probably doesn't affect much user code.

Other changes are all just dependencies and implementation details.

## Version 3.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 2.3.0, released 2019-12-10

- Methods accepting resource names now have equivalent string-accepting overloads
- Resource names have format methods
- Added LogMetric.CreateTime and UpdateTime properties
- New BigQueryOptions class
- Added LogSink.BigqueryOptions property
- Added LogEntry.TraceSampled and Metadata properties
- Added client builder for simplified configuration

## Version 2.2.0, released 2018-07-11

- Added method overloads accepting request objects
- Added WriteLogEntriesRequest.DryRun
- LogSink.StartTime/EndTime/OutputVersionFormat are now obsolete
- LogMetric.Version is now obsolete

## Version 2.1.0, released 2017-11-23

- Added methods and classes for exclusions
- Added LogMetric properties BucketOptions, MetricDescriptor, LabelExtractors, ValueExtractor
- Added an update mask to UpdateSink
- Added LogEntry.SpanId

## Version 2.0.0, released 2017-06-22

First GA release of 2.x with updated major dependency versions.

## Version 1.0.0, released 2017-03-30

Initial GA release.
