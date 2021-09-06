# Version history

# Version 3.4.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

# Version 3.3.0, released 2021-05-05

- [Commit 3e216d0](https://github.com/googleapis/google-cloud-dotnet/commit/3e216d0): feat: add the Tailing API to get a live stream of the tail end of filtered logs

# Version 3.2.0, released 2020-11-18

- [Commit 23bc620](https://github.com/googleapis/google-cloud-dotnet/commit/23bc620): feat: Makes remaining LogBucket and LogViews methods public

# Version 3.1.0, released 2020-10-21

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 98e71af](https://github.com/googleapis/google-cloud-dotnet/commit/98e71af): docs: Specify client retry behavior and rename Stackdriver Logging to Cloud Logging
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 29a7aba](https://github.com/googleapis/google-cloud-dotnet/commit/29a7aba): docs: change relative URLs to absolute URLs to fix broken links.

# Version 3.0.0, released 2020-03-18

- [Commit 8727521](https://github.com/googleapis/google-cloud-dotnet/commit/8727521): Large set of changes, primarily to resource names

The listed commit causes lots of breaking changes, but these were expected, and almost all are due to resource name changes.
The logging API is primarily used from integration points, so probably doesn't affect much user code.

Other changes are all just dependencies and implementation details.

# Version 3.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

# Version 2.3.0, released 2019-12-10

- Methods accepting resource names now have equivalent string-accepting overloads
- Resource names have format methods
- Added LogMetric.CreateTime and UpdateTime properties
- New BigQueryOptions class
- Added LogSink.BigqueryOptions property
- Added LogEntry.TraceSampled and Metadata properties
- Added client builder for simplified configuration

# Version 2.2.0, released 2018-07-11

- Added method overloads accepting request objects
- Added WriteLogEntriesRequest.DryRun
- LogSink.StartTime/EndTime/OutputVersionFormat are now obsolete
- LogMetric.Version is now obsolete

# Version 2.1.0, released 2017-11-23

- Added methods and classes for exclusions
- Added LogMetric properties BucketOptions, MetricDescriptor, LabelExtractors, ValueExtractor
- Added an update mask to UpdateSink
- Added LogEntry.SpanId

# Version 2.0.0, released 2017-06-22

First GA release of 2.x with updated major dependency versions.

# Version 1.0.0, released 2017-03-30

Initial GA release.
