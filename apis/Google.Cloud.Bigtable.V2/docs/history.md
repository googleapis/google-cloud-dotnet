# Version history

## Version 3.18.0, released 2025-05-28

### Bug fixes

- ReadRow/s respects rowsLimit and retries on Aborted exception. Fixes TestReadRows_Retry_PausedScan, TestReadRows_NoRetry_ErrorAfterLastRow, and TestReadRow_Generic_DeadlineExceeded. (#14794)

## Version 3.17.0, released 2025-03-17

### New features

- Add MaterializedViewName to ReadRows and SampleRowKeys ([commit 2221165](https://github.com/googleapis/google-cloud-dotnet/commit/22211658e798f214adb6b0543c657da06b44ba33))

## Version 3.16.0, released 2025-03-10

### New features

- Add PrepareQuery api and update ExecuteQuery to support it ([commit f222067](https://github.com/googleapis/google-cloud-dotnet/commit/f2220677139a51d4304c872292aad1b7c353831b))

### Documentation improvements

- Update ExecuteQuery API docs to reflect changes ([commit f222067](https://github.com/googleapis/google-cloud-dotnet/commit/f2220677139a51d4304c872292aad1b7c353831b))

## Version 3.15.0, released 2024-10-29

### New features

- Add feature flags proto for Direct Access ([commit 70094ae](https://github.com/googleapis/google-cloud-dotnet/commit/70094aea955279d55e675a50ee723b76ff65e4c8))

## Version 3.14.0, released 2024-07-22

### New features

- Add MergeToCell to Mutation APIs ([commit df73f37](https://github.com/googleapis/google-cloud-dotnet/commit/df73f3746e5e6f88b8d27dfea7218c76420ae0fe))
- Update Go Datastore import path ([commit 7f6db1c](https://github.com/googleapis/google-cloud-dotnet/commit/7f6db1c7b5315efdb47d6c76cec97c096e47d45c))
- Update Go Bigtable import path ([commit 7f6db1c](https://github.com/googleapis/google-cloud-dotnet/commit/7f6db1c7b5315efdb47d6c76cec97c096e47d45c))
- Publish ProtoRows Message ([commit 2a57721](https://github.com/googleapis/google-cloud-dotnet/commit/2a57721fa79603917f627877bded42820a015d05))
- Publish the Cloud Bigtable ExecuteQuery API ([commit 92257e9](https://github.com/googleapis/google-cloud-dotnet/commit/92257e9e856a0266eac59f9174c89ccbcf92b229))
## Version 3.13.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.12.0, released 2024-03-28

### New features

- Add feature flag for client side metrics ([commit 1f14edf](https://github.com/googleapis/google-cloud-dotnet/commit/1f14edf5d46734175e945ff69f28be3f2e7b0767))

## Version 3.11.0, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 3.10.0, released 2024-03-12

### New features

- Publish new bigtable APIs for types and aggregates ([commit 47a6ffd](https://github.com/googleapis/google-cloud-dotnet/commit/47a6ffdfeb169ed5c08eb0243b7810bb42e9bf29))
- Add authorized view bindings to Cloud Bigtable data APIs and messages ([commit f09ba5c](https://github.com/googleapis/google-cloud-dotnet/commit/f09ba5cdffa0cd059141ed921e12440ac32e8002))
- (From 3.10.0-beta01) Bigtable supports universe domain ([commit c3610f9](https://github.com/googleapis/google-cloud-dotnet/commit/c3610f97235f1582376e3a124b9531dc01a43a77))

### Documentation improvements

- The field `table_name` in message `.google.bigtable.v2.ReadRowsRequest` is changed from required to optional ([commit f09ba5c](https://github.com/googleapis/google-cloud-dotnet/commit/f09ba5cdffa0cd059141ed921e12440ac32e8002))
- The field `table_name` in message `.google.bigtable.v2.SampleRowKeysRequest` is changed from required to optional ([commit f09ba5c](https://github.com/googleapis/google-cloud-dotnet/commit/f09ba5cdffa0cd059141ed921e12440ac32e8002))
- The field `table_name` in message `.google.bigtable.v2.MutateRowRequest` is changed from required to optional ([commit f09ba5c](https://github.com/googleapis/google-cloud-dotnet/commit/f09ba5cdffa0cd059141ed921e12440ac32e8002))
- The field `table_name` in message `.google.bigtable.v2.MutateRowsRequest` is changed from required to optional ([commit f09ba5c](https://github.com/googleapis/google-cloud-dotnet/commit/f09ba5cdffa0cd059141ed921e12440ac32e8002))
- The field `table_name` in message `.google.bigtable.v2.CheckAndMutateRowRequest` is changed from required to optional ([commit f09ba5c](https://github.com/googleapis/google-cloud-dotnet/commit/f09ba5cdffa0cd059141ed921e12440ac32e8002))
- The field `table_name` in message `.google.bigtable.v2.ReadModifyWriteRowRequest` is changed from required to optional ([commit f09ba5c](https://github.com/googleapis/google-cloud-dotnet/commit/f09ba5cdffa0cd059141ed921e12440ac32e8002))

## Version 3.10.0-beta01, released 2024-02-08

### New features

- Bigtable supports universe domain ([commit c3610f9](https://github.com/googleapis/google-cloud-dotnet/commit/c3610f97235f1582376e3a124b9531dc01a43a77))

## Version 3.9.0, released 2024-01-08

### New features

- Adding feature flags for routing cookie and retry info ([commit af7aca5](https://github.com/googleapis/google-cloud-dotnet/commit/af7aca508568fba8e04d3d037ed6485f1dba1b12))

## Version 3.8.0, released 2023-09-18

### Bug fixes

- Add feature flag for improved mutate rows throttling ([commit ecb32d7](https://github.com/googleapis/google-cloud-dotnet/commit/ecb32d7dd57e3eaa044e470889df2fbbb7422d06))

## Version 3.7.0, released 2023-08-04

### New features

- Add last_scanned_row_key feature ([commit 8ed082d](https://github.com/googleapis/google-cloud-dotnet/commit/8ed082d39a3cf87df915b5f294fc0099a7941129))
- Add experimental reverse scan for public preview ([commit 132fa75](https://github.com/googleapis/google-cloud-dotnet/commit/132fa75640c28dc851d2da10f6ff0b696bd249b1))

### Documentation improvements

- Fix formatting for reversed order field example ([commit 5b10786](https://github.com/googleapis/google-cloud-dotnet/commit/5b107861e31136cb169dc84b070227d15cbbdc4b))

## Version 3.6.0, released 2023-05-26

### Bug fixes

- Bigtable disposal of gRPC streaming call. ([commit 2a12927](https://github.com/googleapis/google-cloud-dotnet/commit/2a1292746e30e4dabc6ae5eddbb63fecf75521db))

## Version 3.5.0, released 2023-05-03

### New features

- Publish RateLimitInfo and FeatureFlag protos ([commit b1efbfe](https://github.com/googleapis/google-cloud-dotnet/commit/b1efbfeabdbe21c90b7a5028828d935b75fa1b15))

## Version 3.4.0, released 2023-03-01

### Bug fixes

- Return all columns when multiple families have the same qualifier. ([commit 137e40f](https://github.com/googleapis/google-cloud-dotnet/commit/137e40f186af7e884ad6111987f2cdc05aa9e91d))

### New features

- Add new_partitions field for CloseStream for Cloud Bigtable ChangeStream ([commit 873b2fa](https://github.com/googleapis/google-cloud-dotnet/commit/873b2fadce5aab85b93d6e088cfb572c165284d9))
- Publish the Cloud Bigtable Change Streams ([commit 5b4d425](https://github.com/googleapis/google-cloud-dotnet/commit/5b4d425005eb83d899332fa77190293ac663c7db))

## Version 3.3.0, released 2022-10-14

This release removes some changes accidentally released in 3.2.0. We
don't *expect* this to break customers, even though it's obviously
theoretically possible. Therefore we have decided to only use a minor
version bump for this change. Please [file an issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if this release causes problems for you.

### Breaking changes

- Remove proto ReadEfficiencyStats ([commit d1e6323](https://github.com/googleapis/google-cloud-dotnet/commit/d1e632344103f7d869913cfac4d5a2c0fd623e4e))
- Remove field RequestStats.read_efficiency_stats ([commit d1e6323](https://github.com/googleapis/google-cloud-dotnet/commit/d1e632344103f7d869913cfac4d5a2c0fd623e4e))
- Rename proto AllReadStats to FullReadStatsView ([commit d1e6323](https://github.com/googleapis/google-cloud-dotnet/commit/d1e632344103f7d869913cfac4d5a2c0fd623e4e))
- Rename field RequestStats.all_read_stats to full_read_stats_view ([commit d1e6323](https://github.com/googleapis/google-cloud-dotnet/commit/d1e632344103f7d869913cfac4d5a2c0fd623e4e))
- Rename proto ReadIteratorStats to ReadIterationStats ([commit d1e6323](https://github.com/googleapis/google-cloud-dotnet/commit/d1e632344103f7d869913cfac4d5a2c0fd623e4e))
- Remove enum value ReadRowsRequest.RequestStatsView.REQUEST_STATS_EFFICIENCY ([commit d1e6323](https://github.com/googleapis/google-cloud-dotnet/commit/d1e632344103f7d869913cfac4d5a2c0fd623e4e))
- Remove field ReadIterationStats.deletes_seen ([commit d1e6323](https://github.com/googleapis/google-cloud-dotnet/commit/d1e632344103f7d869913cfac4d5a2c0fd623e4e))

## Version 3.2.0, released 2022-10-03

### New features

- Publish the RequestStats proto ([commit a344d8f](https://github.com/googleapis/google-cloud-dotnet/commit/a344d8fd5e8fd743cefc809769675388caf8fc13))

## Version 3.1.0, released 2022-07-11

### New features

- Added ResponseParams proto messages

## Version 3.0.0, released 2022-06-09

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

### New features

- Add emulator support for Bigtable (including the admin client) ([commit 7ab4d78](https://github.com/googleapis/google-cloud-dotnet/commit/7ab4d78047586eaa7c761b4557baedc90a6c0afb))
  - This follows the same pattern as other clients.
## Version 2.6.0, released 2022-02-22

### New features

- Add WarmAndPing request for channel priming ([commit 263af4c](https://github.com/googleapis/google-cloud-dotnet/commit/263af4c4f666ebbe9e4e183fe4fb9616029bdaed))
- Add explicit routing header annotations for bigtable/v2 ([commit 53d712e](https://github.com/googleapis/google-cloud-dotnet/commit/53d712e19ed4fc727b47534fc771363fc901f9ab))
## Version 2.5.0, released 2022-01-18

No API surface changes; just dependency updates.

## Version 2.4.0, released 2021-09-23

- [Commit 2a57d32](https://github.com/googleapis/google-cloud-dotnet/commit/2a57d32): docs: Fix the documentation for BigtableServiceApiSettings

## Version 2.3.0, released 2021-08-18

- [Commit b58fa0b](https://github.com/googleapis/google-cloud-dotnet/commit/b58fa0b): Fix Bigtable for self-signed JWTs
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): Regenerate all APIs with self-signed JWT support

This release fixes a subtle bug that would cause BigtableServiceApiClient.Create() to fail when used with GAX 3.5.0, as well as enabling self-signed JWT support.

## Version 2.2.0, released 2021-05-05

- [Commit 9f5f0aa](https://github.com/googleapis/google-cloud-dotnet/commit/9f5f0aa): fix: Regenerate server-streaming calls with Google request params. Fixes [issue 6310](https://github.com/googleapis/google-cloud-dotnet/issues/6310).
- [Commit 1b91d27](https://github.com/googleapis/google-cloud-dotnet/commit/1b91d27): feat: migrate bigtable retry/timeout settings to gRPC's service configs

## Version 2.1.1, released 2020-12-02

- [Commit ef17912](https://github.com/googleapis/google-cloud-dotnet/commit/ef17912): feat: Reduce the gRPC keepalive time from 1 minute to 30 seconds

This change may improve reliability (and makes this library consistent with other languages) but does not affect the API surface.

## Version 2.1.0, released 2020-10-12

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Regenerate all APIs with generator changes to fix timeouts
- [Commit 808fab8](https://github.com/googleapis/google-cloud-dotnet/commit/808fab8): chore: set Ruby namespace in proto options
- [Commit 0c129ac](https://github.com/googleapis/google-cloud-dotnet/commit/0c129ac): chore: Update bigtable grpc service config
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-04-08

No API surface changes compared with 2.0.0-beta02, just a GA release.

## Version 2.0.0-beta02, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.1.0, released 2019-12-10

- [Commit 372e60b](https://github.com/googleapis/google-cloud-dotnet/commit/372e60b): Some retry settings are now obsolete, and will be removed from the next major version
- [Commit ee5c7dc](https://github.com/googleapis/google-cloud-dotnet/commit/ee5c7dc): Introduce client builder types for simpler configuration
- Additional RPC overloads

## Version 1.0.0, released 2019-05-23

Initial GA release.
