# Version history

## Version 4.15.0, released 2025-03-12

### New features

- Introduce DatastoreQuery as a central point for query features, including query profiling ([commit e499bc9](https://github.com/googleapis/google-cloud-dotnet/commit/e499bc91992d6437186707ec161647622ecf9724))

## Version 4.14.0, released 2024-10-14

### New features

- Add FindNearest API to the stable branch ([commit 6ffb6fc](https://github.com/googleapis/google-cloud-dotnet/commit/6ffb6fc4a24412e92502f27759c2c75b0f4452cb))
- Support for field update operators in the Datastore API and resolution strategies when there is a conflict at write time ([commit fbdfc79](https://github.com/googleapis/google-cloud-dotnet/commit/fbdfc79f108f64af5caae1ba32bb43954a59b39d))

## Version 4.13.0, released 2024-08-13

### New features

- Update Go Datastore import path ([commit eb3a95f](https://github.com/googleapis/google-cloud-dotnet/commit/eb3a95f79d6af2ca0b183f6d63ea2a60fdca279c))
- Update Go Bigtable import path ([commit eb3a95f](https://github.com/googleapis/google-cloud-dotnet/commit/eb3a95f79d6af2ca0b183f6d63ea2a60fdca279c))

## Version 4.12.0, released 2024-05-30

### New features

- New PropertyMask field which allows partial commits, lookups, and query results ([commit d2d3c83](https://github.com/googleapis/google-cloud-dotnet/commit/d2d3c83729068ac7fa329b3cea1281519f16adec))

## Version 4.11.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 4.10.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 4.9.0, released 2024-03-21

### New features

- Add new types ExplainOptions, ExplainMetrics, PlanSummary, ExecutionStats ([commit 6049921](https://github.com/googleapis/google-cloud-dotnet/commit/60499218b493f600c9920abd0bc9471191200d3c))
- Add ExplainOptions field to RunQueryRequest ([commit 6049921](https://github.com/googleapis/google-cloud-dotnet/commit/60499218b493f600c9920abd0bc9471191200d3c))
- Add ExplainMetrics field to RunQueryResponse ([commit 6049921](https://github.com/googleapis/google-cloud-dotnet/commit/60499218b493f600c9920abd0bc9471191200d3c))
- Add ExplainOptions field to RunAggregationQueryRequest ([commit 6049921](https://github.com/googleapis/google-cloud-dotnet/commit/60499218b493f600c9920abd0bc9471191200d3c))
- Add ExplainMetrics field to RunAggregationQueryResponse ([commit 6049921](https://github.com/googleapis/google-cloud-dotnet/commit/60499218b493f600c9920abd0bc9471191200d3c))

## Version 4.8.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 4.7.0, released 2024-01-30

### New features

Multiple database support is now GA.

### Bug fixes (from beta)

- The new features released in 4.7.0-beta03 have been removed. This
  is a breaking change, but the features were never available to
  customers in terms of server interactions (only protos) and were
  not published in a stable release.

## Version 4.7.0-beta03, released 2024-01-08

### New features

- Add new types QueryMode, QueryPlan, ResultSetStats ([commit 44bca87](https://github.com/googleapis/google-cloud-dotnet/commit/44bca8714317d24b5db5acb28ba62a95a0bd0c39))
- Add QueryMode field to RunQueryRequest ([commit 44bca87](https://github.com/googleapis/google-cloud-dotnet/commit/44bca8714317d24b5db5acb28ba62a95a0bd0c39))
- Add ResultSetStats field to RunQueryResponse ([commit 44bca87](https://github.com/googleapis/google-cloud-dotnet/commit/44bca8714317d24b5db5acb28ba62a95a0bd0c39))
- Add QueryMode field to RunAggregationQueryRequest ([commit 44bca87](https://github.com/googleapis/google-cloud-dotnet/commit/44bca8714317d24b5db5acb28ba62a95a0bd0c39))
- Add ResultSetStats field to RunAggregationQueryResponse ([commit 44bca87](https://github.com/googleapis/google-cloud-dotnet/commit/44bca8714317d24b5db5acb28ba62a95a0bd0c39))

## Version 4.7.0-beta02, released 2023-12-05

### Bug fixes

- Specify the database ID in transaction-oriented operations. Fixes [issue 11375](https://github.com/googleapis/google-cloud-dotnet/issues/11375). ([commit 715167e](https://github.com/googleapis/google-cloud-dotnet/commit/715167eee78a8c129f0dd2b21714ebecda6310ba))

## Version 4.7.0-beta01, released 2023-11-29

Note: this is a beta release as multiple database support in Datastore is still in preview. We don't expect the API surface to change between now and the final release, but we don't guarantee that.

### New features

- Multi-db support in Datastore. ([commit 4e7700f](https://github.com/googleapis/google-cloud-dotnet/commit/4e7700ffb1850e405654a4893ad1a3fe87ed5c2f))

## Version 4.6.0, released 2023-08-22

### New features

- Add sum and average aggregates ([commit 4b253b0](https://github.com/googleapis/google-cloud-dotnet/commit/4b253b0d2b2c09a379142e59481f3ce8a3643b1e))
- Publish proto definitions for SUM/AVG ([commit ab0464e](https://github.com/googleapis/google-cloud-dotnet/commit/ab0464e993fbacc50d91f80c6f6d7b87ff8682da))

### Documentation improvements

- Update property requirement specifications ([commit 11b3f20](https://github.com/googleapis/google-cloud-dotnet/commit/11b3f208b70651234d2bfef07460b98220ed23a7))
- Minor comment update for Entity message ([commit 1d662d5](https://github.com/googleapis/google-cloud-dotnet/commit/1d662d52c880b995c733f1a2b0d70f8957fb5bf1))

## Version 4.5.0, released 2023-03-13

### New features

- Add Filter.Or static convenience methods ([issue 9946](https://github.com/googleapis/google-cloud-dotnet/issues/9946)) ([commit 00967cb](https://github.com/googleapis/google-cloud-dotnet/commit/00967cbe9cedd631dc6bbc3bd297db4a87e5d86b))
- Add `OR` query support (underlying proto API) ([commit 603dee4](https://github.com/googleapis/google-cloud-dotnet/commit/603dee4be049456477c82c6cbd7a3f8e1c334dd6))
- Add support for count(*) aggregation ([commit 8ee696d](https://github.com/googleapis/google-cloud-dotnet/commit/8ee696dfa57e0f5c80e8024d54ae536f2cd0ec00))

### Documentation improvements

- Minor documentation formatting and cleanup ([commit 603dee4](https://github.com/googleapis/google-cloud-dotnet/commit/603dee4be049456477c82c6cbd7a3f8e1c334dd6))

## Version 4.4.0, released 2023-01-16

### New features

- Enable REST transport in C# ([commit a6c4606](https://github.com/googleapis/google-cloud-dotnet/commit/a6c46063bd961a9dadc728a780d66de772f28e71))
- New transaction options for datastoreV1 ([commit 9e48eda](https://github.com/googleapis/google-cloud-dotnet/commit/9e48eda004a534ce7b4e53bbb6d6ef53471a2568))
- Add dynamic routing header annotation to DatastoreV1 ([commit 1e6c8b7](https://github.com/googleapis/google-cloud-dotnet/commit/1e6c8b78b0409f142f2e6f7e54bf1a4900e0428a))

## Version 4.3.0, released 2022-11-02

### New features

- Add datastore aggregation query APIs ([commit 5e75d6c](https://github.com/googleapis/google-cloud-dotnet/commit/5e75d6cffa660cbdf66b4d78f17975adf62a313c))

## Version 4.2.0, released 2022-07-27

### New features

- Added database ID to request messages ([commit adf2d20](https://github.com/googleapis/google-cloud-dotnet/commit/adf2d202eb0fc206df6195cb46df98e7a6486160))
## Version 4.1.0, released 2022-06-22

### New features

- Add `IN` and `NOT_IN` operators ([commit 409b4f5](https://github.com/googleapis/google-cloud-dotnet/commit/409b4f5a273550d7aaf03af95aab0803327aa405))

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

### Documentation improvements

- Document encoding of non-UTF-8 key strings in the Cloud Datastore API ([commit ee61d4d](https://github.com/googleapis/google-cloud-dotnet/commit/ee61d4d37ab4dd330bdc39d35f5172a6d6985aa0))
## Version 3.5.0, released 2022-04-26

### New features

- Expose new read_time API fields, currently only available in private preview ([commit 4bc260c](https://github.com/googleapis/google-cloud-dotnet/commit/4bc260c0f34a5f5296badaefa4e6d962499cc225))

## Version 3.4.0, released 2022-04-04

### New features

- Add IN/NOT_IN/NOT_EQUALS support to cloud datastore proto ([commit e76f560](https://github.com/googleapis/google-cloud-dotnet/commit/e76f5605392877acebaaa0b652896e3e27b72418))

## Version 3.3.0, released 2021-08-18

- [Commit d9a3648](https://github.com/googleapis/google-cloud-dotnet/commit/d9a3648): fix: Fix Firestore and Datastore for self-signed JWTs
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 3.2.0, released 2021-05-05

- [Commit 8bb2981](https://github.com/googleapis/google-cloud-dotnet/commit/8bb2981): Use CopySettingsForEmulator in DatastoreDbBuilder

No API surface changes, but CopySettingsForEmulator ensures that any UserAgent or GrpcAdapter set in the client builder is also used in the emulator.

## Version 3.1.0, released 2020-09-28

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit a009b4b](https://github.com/googleapis/google-cloud-dotnet/commit/a009b4b): fix: Specify insecure credentials when connecting to the emulator. Fixes [issue 5365](https://github.com/googleapis/google-cloud-dotnet/issues/5365).
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): feat: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Regenerate all APIs with proper timeout handling
- [Commit 42b9797](https://github.com/googleapis/google-cloud-dotnet/commit/42b9797): chore: set Ruby namespace in proto options
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 03279b9](https://github.com/googleapis/google-cloud-dotnet/commit/03279b9): docs: Fix documentation for string_value. The value does not have to be at least 1MB, but rather, at most 1MB.

## Version 3.0.0, released 2020-03-17

No API surface changes compared with 3.0.0-beta01, just dependency
and implementation changes.

## Version 3.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

Additional breaking changes not covered in the guide:

- The `EmulatorDetection` enum is now in the `Google.Api.Gax`
  namespace, and the previous `ProductionOrEmulator` value within
  it has been renamed to `EmulatorOrProduction`.

## Version 2.2.0, released 2019-12-09

- Implement DatastoreDbBuilder for easy configuration, including emulator support
- Multiple code generation improvements
- Some retry-based settings are now obsolete, and will be removed in the next major release

## Version 2.1.0, released 2018-02-01

- [Commit 3730474](https://github.com/googleapis/google-cloud-dotnet/commit/3730474): Implement Datastore transaction options in DatastoreDb.
- [Commit 6287f81](https://github.com/googleapis/google-cloud-dotnet/commit/6287f81): Added transaction options to underlying API

## Version 2.0.0, released 2017-06-22

- [Commit 04c3fdc](https://github.com/googleapis/google-cloud-dotnet/commit/04c3fdc): Retry setting changes
- [Commit 49e0362](https://github.com/googleapis/google-cloud-dotnet/commit/49e0362): ConfigureAwait fixes
- Dependency on GAX updated to v2

## Version 1.0.0, released 2017-03-30

Initial GA release.
