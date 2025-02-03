# Version history

## Version 3.11.0, released 2025-02-03

### Bug fixes

- Remove column name validation. ([commit d79c8ff](https://github.com/googleapis/google-cloud-dotnet/commit/d79c8ff6ae3db02b73a5a5bed3b2b56333a55eb9))

## Version 3.10.0, released 2024-05-30

### New features

- Add a view option to GetTable ([commit 258e723](https://github.com/googleapis/google-cloud-dotnet/commit/258e723949d58454111e456feaae62836557672f))

## Version 3.9.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.8.0, released 2024-03-14

### New features

- Expose GetQueryResultsResponse.CacheHit ([commit 8a349d9](https://github.com/googleapis/google-cloud-dotnet/commit/8a349d9c62c1f5bbca89323af6d5764f4692f861))

## Version 3.7.0, released 2024-03-06

No API surface changes; just dependency updates.

## Version 3.6.0, released 2024-02-20

### New features

- Implement int64-based timestamps ([commit 9677fcb](https://github.com/googleapis/google-cloud-dotnet/commit/9677fcb585130adead6bbb1963477dc77be13f57))

## Version 3.5.0, released 2023-10-13

### New features

- Adds config modifier to BigQuery job options ([commit fbacbb8](https://github.com/googleapis/google-cloud-dotnet/commit/fbacbb8315d62ac10b2960e18fe239e0754420c3))
- Adds support for policy tags ([commit 730a30e](https://github.com/googleapis/google-cloud-dotnet/commit/730a30e2ae3a4e7e94877918df82641e527a4708))

## Version 3.4.0, released 2023-06-07

### New features

- Add support for encoding in BigQuery load jobs ([commit a1db93c](https://github.com/googleapis/google-cloud-dotnet/commit/a1db93c7a66590b3365869ccd71bfd02985b6576))

## Version 3.3.0, released 2023-04-19

### New features

- Add support for snapshot clones ([commit 09aadf7](https://github.com/googleapis/google-cloud-dotnet/commit/09aadf792d8d20346f0c2e1e4bb45abda2775897))

## Version 3.2.0, released 2022-11-16

### New features

- Add JSON DB type support in BigQuery ([commit afa19c1](https://github.com/googleapis/google-cloud-dotnet/commit/afa19c179ae8fde5e78655041c72915bc6a0afaa))

## Version 3.1.0, released 2022-07-25

### New features

- Adds table ACLs support ([commit 22b00e2](https://github.com/googleapis/google-cloud-dotnet/commit/22b00e2ef09095a5cd2bc1c0261a8967bbdff6b4))
- Add support for BigQuery job metadata deletion. ([commit 2b501e8](https://github.com/googleapis/google-cloud-dotnet/commit/2b501e824bd8ab6a5a88ef8cbfee137d13b65576))
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

### Bug fixes

- Numeric truncation. ([commit 13ae78a](https://github.com/googleapis/google-cloud-dotnet/commit/13ae78ae3234173745c985fb6264c36911de2f04))

### New features

- Add BigQueryJob.ThrowOnFatalError ([commit 788a4d0](https://github.com/googleapis/google-cloud-dotnet/commit/788a4d01dde3b34f2ca799a634f5d971d91828a5))
  - The existing BigQueryJob.ThrowOnAnyError will throw an exception if
    *any* errors are detected, even if the job goes on to complete
    successfully. This can happen in a query job against an external
    data source which has been configured to permit a certain number of
    "bad" rows, for example. The new method is a convenient way of
    throwing an exception for a genuinely-failed job, as indicated by the
    JobStatus.ErrorResult
    property.
## Version 2.4.0, released 2022-05-05

GA release of the features previously in beta: support for BigNumeric, and more detailed exceptions.

## Version 2.4.0-beta02, released 2022-04-26

### New features

- Include more information on GoogleApiException.Message when possible. ([commit 2057c2e](https://github.com/googleapis/google-cloud-dotnet/commit/2057c2eea72f205fd79860094d7d28a4ae056eac))

BREAKING CHANGE: If calling code depended on the exact exception message, it could be broken by this change. Customers are strongly encouraged not to depend on error message text.
## Version 2.4.0-beta01, released 2022-02-07

### New features

- Add support for BigNumeric. ([commit 4dc2e9b](https://github.com/googleapis/google-cloud-dotnet/commit/4dc2e9bc641e629838a909c49e691bbadd1d6ab6))

## Version 2.3.0, released 2021-08-10

- [Commit d51544c](https://github.com/googleapis/google-cloud-dotnet/commit/d51544c): In GetOrCreate methods, retry "get" operation if "create" fails due to conflict. Fixes [issue 6902](https://github.com/googleapis/google-cloud-dotnet/issues/6902)

## Version 2.2.0, released 2021-05-05

- [Commit a07ebae](https://github.com/googleapis/google-cloud-dotnet/commit/a07ebae): feat: Model extract jobs.
- [Commit 648196d](https://github.com/googleapis/google-cloud-dotnet/commit/648196d): Fix BigQueryInsertStatus bullet point descriptions

## Version 2.1.0, released 2020-09-23

- [Commit 14be654](https://github.com/googleapis/google-cloud-dotnet/commit/14be654): feat: Disable pretty printing in BigQuery unless explicitly requested. Fixes [issue 5330](https://github.com/googleapis/google-cloud-dotnet/issues/5330).
- [Commit 909f568](https://github.com/googleapis/google-cloud-dotnet/commit/909f568): docs: Clarify the scopes used by BigQueryClient.Create and CreateAsync

## Version 2.0.0, released 2020-06-04

- [Commit 0970dff](https://github.com/googleapis/google-cloud-dotnet/commit/0970dff): Fix: Propagates some cancellation tokens that weren't being propagated before.
- [Commit e9e6a47](https://github.com/googleapis/google-cloud-dotnet/commit/e9e6a47): Binary breaking change: Adds missing CancellationToken parameter on BigQueryDataset.DeleteModelAsync.
- [Commit 8e9c40f](https://github.com/googleapis/google-cloud-dotnet/commit/8e9c40f): Adds BigQuery Routines CRUD operations.
  - Fixes [issue 3762](https://github.com/googleapis/google-cloud-dotnet/issues/3762)
- [Commit 575c61a](https://github.com/googleapis/google-cloud-dotnet/commit/575c61a):
  - Convert BigQuery field validation from a regex to hand-written code.
  - This is entirely for the sake of performance. Benchmark results are approximately 10x better.
  - Fixes [issue 4975](https://github.com/googleapis/google-cloud-dotnet/issues/4975)

## Version 2.0.0-beta04, released 2020-04-07

- [Commit f58fa79](https://github.com/googleapis/google-cloud-dotnet/commit/f58fa79): Makes BigQueryRow.TimestampConverter accept pre 1970 dates. Fixes [issue 4821](https://github.com/googleapis/google-cloud-dotnet/issues/4821).

## Version 2.0.0-beta03, released 2020-03-30

- [Commit 7ab60e1](https://github.com/googleapis/google-cloud-dotnet/commit/7ab60e1): Fixes ReadPage and ReadPageAsync incorrect PageToken when starting again. Fixes [issue 4678](https://github.com/googleapis/google-cloud-dotnet/issues/4678).

## Version 2.0.0-beta02, released 2020-03-18

- [Commit 2b4c06f](https://github.com/googleapis/google-cloud-dotnet/commit/2b4c06f):
  - Table creation breaking change:
  -   * All options have been removed from Google.Cloud.BigQuery.V2.TableCreateOptions.
  -   * Table create operations overloads added that received a Google.Apis.Bigquery.v2.Data.Table instead.
  -   * Extension methods have been added to help in setting some Google.Apis.Bigquery.v2.Data.Table properties.
- [Commit d951c14](https://github.com/googleapis/google-cloud-dotnet/commit/d951c14):
  - Dataset creation breaking change:
  -   * All options have been removed from Google.Cloud.BigQuery.V2.DatasetCreateOptions.
  -   * Dataset create operations now received a Google.Apis.Bigquery.v2.Data.Dataset instead.
  -   * Extension methods have been added to help in setting some Google.Apis.Bigquery.v2.Data.Dataset properties.
- [Commit acad11b](https://github.com/googleapis/google-cloud-dotnet/commit/acad11b):
  - BigQueryResults breaking change.
  -   * TotalRows is now ulong? instead of ulong.
  -   * SafeTotalRows has been removed.
  
In addition to the above changes, this release now targets GAX 3.0.0 (GA).

## Version 2.0.0-beta01, released 2020-02-20

Breaking changes:

- Updated to GAX v3, which has breaking changes, particularly around async pagination
- Removed obsolete BigQueryResults constructor
- Insert operations now return a BigQueryInsertResults instead of void

Further breaking changes are being considered before the 3.0.0
release, specifically around BigQueryResults.SafeTotalRows and
options to create resources (tables, datasets etc).

New features:

- Introduced BigQueryInsertResults as a cleaner way of handling insert errors
- Retrieval of partial results via GetTableOptions.SelectedFields
- Support for ParentJobId filtering when listing jobs
- CRUD support for models

Specific commits:

- [Commit 3c900ed](https://github.com/googleapis/google-cloud-dotnet/commit/3c900ed): Remove obsolete BigQueryResults constructor
- [Commit 21117b7](https://github.com/googleapis/google-cloud-dotnet/commit/21117b7): Fixes issue introduced in [issue 4073](https://github.com/googleapis/google-cloud-dotnet/issues/4073).
- [Commit 3cadc8e](https://github.com/googleapis/google-cloud-dotnet/commit/3cadc8e): Modifies insert methods to return BigQueryInsertResults.
- [Commit 9a2f966](https://github.com/googleapis/google-cloud-dotnet/commit/9a2f966): Adds BigQueryInsertResults which wraps the response obtained from insert attempts.
- [Commit a849e5c](https://github.com/googleapis/google-cloud-dotnet/commit/a849e5c): Supports listing partial rows by specifying a partial table schema.
- [Commit a820034](https://github.com/googleapis/google-cloud-dotnet/commit/a820034): Supports fetching a partial table schema when getting a table.
- [Commit 06e0d6e](https://github.com/googleapis/google-cloud-dotnet/commit/06e0d6e): Adds Model CRUD operations wrappers to BigQueryDataset and BigQueryModel.
- [Commit 38e755a](https://github.com/googleapis/google-cloud-dotnet/commit/38e755a): Adds some Model CRUD operations and supporting types.
- [Commit ade13ba](https://github.com/googleapis/google-cloud-dotnet/commit/ade13ba): Support ParentJobId filtering when listing Jobs.
- [Commit ebeece5](https://github.com/googleapis/google-cloud-dotnet/commit/ebeece5): Parse timestamp JSON values as decimal instead of double. Fixes [issue 4031](https://github.com/googleapis/google-cloud-dotnet/issues/4031).

## Version 1.4.0, released 2019-12-16

New features since 1.3.0:

- [Commit 1074e9f](https://github.com/googleapis/google-cloud-dotnet/commit/1074e9f): Support for empty InsertIds when inserting rows.
- Add TemplateSuffix, SkipInvalidRows and SuppressInsertErrors to InsertOptions.
- Add DefaultPartitionExpiration and DefaultEncryptionConfiguration to CreateDatasetOptions.
- Add table CreationTime, ExpirationTime and Clustering info to ListTables output.
- Loosen the restriction on JobConfigurationQuery.DestinationTable not being null.
- Provide option for using Avro logical types for load/extract.
- Adds creation time filtering to BigQuery job listing.
- New type BigQueryClientBuilder to simplify configuration.
- Implement support for BigQuery GEOGRAPHY type.
- netstandard2.0 target
- Reimplemented query handling using GetQueryResults RPC instead of ListRows,
  resulting in a performance improvement

## Version 1.3.0, released 2019-02-07

New features since 1.2.0:

- Support for table clustering in `CreateTableOptions`
- Nullable row count properties (`SafeTotalRows` and `NumDmlAffectedRows`) in `BigQueryResults`
- Support for the `NUMERIC` type via `BigQueryNumeric`
- Support for a projection to be specified when listing jobs
- Support for time-based partitioning in load and query jobs
- Support for time-based partitioning by a specific field
- Support for SchemaUpdateOptions for load and query jobs
- Support for Parquet load jobs
- Support for ORC load jobs
- Support for job labels
- Support for supplying page tokens to all list operations
- Public constructors for BigQueryTable etc, for improved testability

## Version 1.2.0, released 2018-04-09

New features since 1.1.0:

- Support for geo-regionalization for data sets and jobs

## Version 1.1.0, released 2018-03-06

New features since 1.0.0:

- Support for [customer managed encryption](https://cloud.google.com/bigquery/docs/customer-managed-encryption)
  (Cloud KMS)

## Version 1.0.0, released 2017-12-07

Initial release.
