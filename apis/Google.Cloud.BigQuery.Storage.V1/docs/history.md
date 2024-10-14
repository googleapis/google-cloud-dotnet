# Version history

## Version 3.17.0, released 2024-10-14

### New features

- Add experimental ArrowData type and arrow_data field within AppendRowsRequest ([commit f556dca](https://github.com/googleapis/google-cloud-dotnet/commit/f556dca9d15fdbc3d8b93896f101b961f1b7b510))

## Version 3.16.0, released 2024-09-26

No API surface changes; just dependency updates.

## Version 3.15.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.14.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.13.0, released 2024-03-13

No API surface changes; just dependency updates.

## Version 3.12.0, released 2024-02-20

### New features

- Add the RANGE type to the google.cloud.bigquery.storage.v1.TableFieldSchema ([commit 7867a64](https://github.com/googleapis/google-cloud-dotnet/commit/7867a6402a3216bc1387a9e5c44a99f0379c350b))

## Version 3.11.0, released 2024-01-16

### New features

- Add ability to request compressed ReadRowsResponse rows ([commit 2f64e53](https://github.com/googleapis/google-cloud-dotnet/commit/2f64e5396d8aca9ac8da452a5c385d0283bdfefb))

## Version 3.10.0, released 2023-08-16

### New features

- Add default_missing_value_interpretation field; indicate KMS_SERVICE_ERROR is retryable ([commit 6d11153](https://github.com/googleapis/google-cloud-dotnet/commit/6d1115399c4ea9a0478ec15b1b725c5cc8e91f12))

## Version 3.9.0, released 2023-07-13

### New features

- Add ResourceExhausted to retryable error for Write API unary calls ([commit a1262a2](https://github.com/googleapis/google-cloud-dotnet/commit/a1262a25eb219cd79c04f9c36914a9cabeb910a4))

### Documentation improvements

- Add multiplexing documentation ([commit a1262a2](https://github.com/googleapis/google-cloud-dotnet/commit/a1262a25eb219cd79c04f9c36914a9cabeb910a4))

## Version 3.8.0, released 2023-06-27

### New features

- Add estimated physical file sizes to ReadAPI v1 ([commit d0b88e9](https://github.com/googleapis/google-cloud-dotnet/commit/d0b88e9c69da74879df35f4b8b0a1a15fd6a7bd8))

## Version 3.7.0, released 2023-05-26

### New features

- Add table sampling to ReadAPI v1 ([commit 954a186](https://github.com/googleapis/google-cloud-dotnet/commit/954a1867605844c1889aadb6bf4ff480c5eadd36))
- Add storage error codes for KMS ([commit 954a186](https://github.com/googleapis/google-cloud-dotnet/commit/954a1867605844c1889aadb6bf4ff480c5eadd36))
## Version 3.6.0, released 2023-02-22

### New features

- Add default_value_expression to TableFieldSchema ([commit d97c2ac](https://github.com/googleapis/google-cloud-dotnet/commit/d97c2acecbca8b6ff15810a2f263079fcf83b63e))

## Version 3.5.0, released 2022-12-14

### New features

- Add estimated number of rows to CreateReadSession response ([commit 2ac8ed0](https://github.com/googleapis/google-cloud-dotnet/commit/2ac8ed0add87367717aa7593a5013153d374d328))

## Version 3.4.0, released 2022-12-01

### New features

- Add missing_value_interpretations to AppendRowsRequest ([commit 13e3cd7](https://github.com/googleapis/google-cloud-dotnet/commit/13e3cd7ffc5e3ab283b9934470a9cb0729dbe102))

### Documentation improvements

- Remove stale header guidance for AppendRows ([commit b934a52](https://github.com/googleapis/google-cloud-dotnet/commit/b934a529b6cc89898e143ff3865dde5ceb3f4fa9))

## Version 3.3.0, released 2022-09-15

### New features

- Add proto annotation for non-ascii field mapping ([commit ec6eae4](https://github.com/googleapis/google-cloud-dotnet/commit/ec6eae416255d035935ef97ce9880693498160e6))
- Add location to WriteStream and add WriteStreamView support ([commit b7711a6](https://github.com/googleapis/google-cloud-dotnet/commit/b7711a6da9d6d3ba4e04e72d961ec082acfc3923))

## Version 3.2.0, released 2022-08-26

### New features

- Allow users to set Apache Avro output format options through avro_serialization_options param in TableReadOptions message ([commit 9c2cc6c](https://github.com/googleapis/google-cloud-dotnet/commit/9c2cc6cb2215773f75923eddec131204b6da03ea))

### Documentation improvements

- Clarify size limitations for AppendRowsRequest ([commit 8b061b5](https://github.com/googleapis/google-cloud-dotnet/commit/8b061b52b56c6bc7649d2b62a7771ea9ef48da69))

## Version 3.1.0, released 2022-07-11

### Bug fixes

- Modify client lib retry policy for CreateWriteStream with longer backoff, more error code and longer overall time ([commit 51e9621](https://github.com/googleapis/google-cloud-dotnet/commit/51e9621868b3fe3daf573c0c1509217d50097f7c))

### New features

- Add fields to eventually contain row level errors ([commit 2b870d5](https://github.com/googleapis/google-cloud-dotnet/commit/2b870d51a51b79b3b36aacdf02a29d36207b2bad))

## Version 3.0.0, released 2022-06-08

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
## Version 2.9.0, released 2022-04-04

### New features

- Deprecate format specific `row_count` field in Read API ([commit 682ee9e](https://github.com/googleapis/google-cloud-dotnet/commit/682ee9e031905a71c664234e6901de88438d7556))

## Version 2.8.0, released 2022-03-14

### New features

- Update default timeout/retry information ([commit e64637d](https://github.com/googleapis/google-cloud-dotnet/commit/e64637d6ed0544c3fe2981560a8ea8c8a5532364))
- Update parent annotation for BatchCommitWriteStreamsRequest ([commit e64637d](https://github.com/googleapis/google-cloud-dotnet/commit/e64637d6ed0544c3fe2981560a8ea8c8a5532364))
- Expose additional StorageError enum values ([commit e64637d](https://github.com/googleapis/google-cloud-dotnet/commit/e64637d6ed0544c3fe2981560a8ea8c8a5532364))

### Documentation improvements

- Improve documentation for write client ([commit e64637d](https://github.com/googleapis/google-cloud-dotnet/commit/e64637d6ed0544c3fe2981560a8ea8c8a5532364))

## Version 2.7.0, released 2022-02-22

### New features

- Add trace_id for Read API ([commit 2cac347](https://github.com/googleapis/google-cloud-dotnet/commit/2cac34761c11e939b6150fb70fd4409f40c7edb8))

### Additional notes

- The `bigquery.readonly` auth scope has been removed has been removed from the default scope set ([commit f691c91](https://github.com/googleapis/google-cloud-dotnet/commit/f691c9119d6b00f1c0629a5d5bc65c7b6ee8ed12)). We don't expect that to break any users, but please be aware of the change.


## Version 2.6.0, released 2022-01-17

### New features

- Add write_mode support for BigQuery Storage Write API v1 ([commit 129c391](https://github.com/googleapis/google-cloud-dotnet/commit/129c391394ff748a5f9ae34cd0ee68acf4acc421))

## Version 2.5.0, released 2021-09-24

- [Commit d200346](https://github.com/googleapis/google-cloud-dotnet/commit/d200346): fix: add missing read api retry setting on SplitReadStream
- [Commit c896df1](https://github.com/googleapis/google-cloud-dotnet/commit/c896df1): feat: add BigQuery Storage Write API v1
- [Commit beebb6a](https://github.com/googleapis/google-cloud-dotnet/commit/beebb6a):
  - docs: Align session length with public documentation
  - feat: Expose estimated bytes that a session will scan.

## Version 2.4.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.3.0, released 2021-06-22

- [Commit 72f542b](https://github.com/googleapis/google-cloud-dotnet/commit/72f542b): feat: Add ZSTD compression as an option for Arrow.

## Version 2.2.0, released 2021-04-14

- [Commit 9f5f0aa](https://github.com/googleapis/google-cloud-dotnet/commit/9f5f0aa): Regenerate server-streaming calls with Google request params. Fixes [issue 6310](https://github.com/googleapis/google-cloud-dotnet/issues/6310).
- [Commit 10a22c9](https://github.com/googleapis/google-cloud-dotnet/commit/10a22c9):
  - feat: add a Arrow compression options (Only LZ4 for now).
  - feat: Return schema on first ReadRowsResponse. doc: clarify limit on filter string.

## Version 2.1.0, released 2020-10-08

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 062f39c](https://github.com/googleapis/google-cloud-dotnet/commit/062f39c): docs: Update an out-of-date external link.
- [Commit 5632dbd](https://github.com/googleapis/google-cloud-dotnet/commit/5632dbd): docs: Comment fix

## Version 2.0.0, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependency,
comment and implementation changes.

## Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0-beta01, released 2020-02-11

Initial beta release.
