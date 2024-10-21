# Version history

## Version 4.15.0, released 2024-10-21

### New features

- Discovery of BigQuery snapshots ([commit 6a666e4](https://github.com/googleapis/google-cloud-dotnet/commit/6a666e46ee98a0ee20e57a334bee5d01c9f60e50))

### Documentation improvements

- Documentation revisions for data profiles ([commit 6a666e4](https://github.com/googleapis/google-cloud-dotnet/commit/6a666e46ee98a0ee20e57a334bee5d01c9f60e50))

## Version 4.14.0, released 2024-09-26

### New features

- Action for publishing data profiles to SecOps (formelly known as Chronicle) ([commit d6641c2](https://github.com/googleapis/google-cloud-dotnet/commit/d6641c27d51c828d5c6d5930d93b30d79a6782e3))
- Action for publishing data profiles to Security Command Center ([commit d6641c2](https://github.com/googleapis/google-cloud-dotnet/commit/d6641c27d51c828d5c6d5930d93b30d79a6782e3))
- Discovery configs for AWS S3 buckets ([commit d6641c2](https://github.com/googleapis/google-cloud-dotnet/commit/d6641c27d51c828d5c6d5930d93b30d79a6782e3))

### Documentation improvements

- Small improvements and clarifications ([commit d6641c2](https://github.com/googleapis/google-cloud-dotnet/commit/d6641c27d51c828d5c6d5930d93b30d79a6782e3))

## Version 4.13.0, released 2024-09-09

### New features

- Inspect template modified cadence discovery config for Cloud SQL ([commit 23f8df4](https://github.com/googleapis/google-cloud-dotnet/commit/23f8df41b49a13da263184e7723468f680120326))
- File store data profiles can now be filtered by type and storage location ([commit 23f8df4](https://github.com/googleapis/google-cloud-dotnet/commit/23f8df41b49a13da263184e7723468f680120326))

### Documentation improvements

- Small improvements ([commit 23f8df4](https://github.com/googleapis/google-cloud-dotnet/commit/23f8df41b49a13da263184e7723468f680120326))

## Version 4.12.0, released 2024-08-13

### New features

- Add the TagResources API ([commit 1be7ce3](https://github.com/googleapis/google-cloud-dotnet/commit/1be7ce396894cac23dc57f3bb33f7bdd4eb780fb))

## Version 4.11.0, released 2024-08-05

### New features

- Org-level connection bindings ([commit 2268fa6](https://github.com/googleapis/google-cloud-dotnet/commit/2268fa61a7f338d380c9371defd3547d4df6d55c))
- GRPC config for get, list, and delete FileStoreDataProfiles ([commit 2268fa6](https://github.com/googleapis/google-cloud-dotnet/commit/2268fa61a7f338d380c9371defd3547d4df6d55c))
- Add refresh frequency for data profiling ([commit 2268fa6](https://github.com/googleapis/google-cloud-dotnet/commit/2268fa61a7f338d380c9371defd3547d4df6d55c))

### Documentation improvements

- Replace HTML tags with CommonMark notation ([commit 9eb36ce](https://github.com/googleapis/google-cloud-dotnet/commit/9eb36ce1f7e1a41f873983424d20af053c472c28))
- Small improvements ([commit 2268fa6](https://github.com/googleapis/google-cloud-dotnet/commit/2268fa61a7f338d380c9371defd3547d4df6d55c))

## Version 4.10.0, released 2024-07-22

### New features

- Add Cloud Storage discovery support ([commit e42223b](https://github.com/googleapis/google-cloud-dotnet/commit/e42223be9b17224ce05e282f5f03e7afacf58466))

### Documentation improvements

- Updated method documentation ([commit e42223b](https://github.com/googleapis/google-cloud-dotnet/commit/e42223be9b17224ce05e282f5f03e7afacf58466))

## Version 4.9.0, released 2024-06-03

### New features

- Add secrets discovery support ([commit ec67558](https://github.com/googleapis/google-cloud-dotnet/commit/ec675587050d36090ce23ac6b618d551d2a0074b))
- Add RPCs for deleting TableDataProfiles ([commit 4c44194](https://github.com/googleapis/google-cloud-dotnet/commit/4c44194c2aa30cb7ff16aae08d31225f297563dc))
- Add RPCs for enabling discovery of Cloud SQL ([commit 4c44194](https://github.com/googleapis/google-cloud-dotnet/commit/4c44194c2aa30cb7ff16aae08d31225f297563dc))
- Add field to InspectJobs num_rows_processed for BigQuery inspect jobs ([commit 4c44194](https://github.com/googleapis/google-cloud-dotnet/commit/4c44194c2aa30cb7ff16aae08d31225f297563dc))
- Add new countries for supported detectors ([commit 4c44194](https://github.com/googleapis/google-cloud-dotnet/commit/4c44194c2aa30cb7ff16aae08d31225f297563dc))
- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))
- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

### Documentation improvements

- Updated method documentation ([commit ec67558](https://github.com/googleapis/google-cloud-dotnet/commit/ec675587050d36090ce23ac6b618d551d2a0074b))
- Updated method documentation ([commit 4c44194](https://github.com/googleapis/google-cloud-dotnet/commit/4c44194c2aa30cb7ff16aae08d31225f297563dc))

### Notes

This includes changes that were accidentally released in 2.15.0 and
2.16.0 (now delisted), after version 4.8.0.

## Version 4.8.0, released 2024-03-21

### New features

- Add RPCs for getting and listing project, table, and column data profiles ([commit 5dd8bca](https://github.com/googleapis/google-cloud-dotnet/commit/5dd8bca0b4def432d3c7714d21947a2632208431))

### Documentation improvements

- Update urls to reflect branding change to Sensitive Data Protection ([commit 5dd8bca](https://github.com/googleapis/google-cloud-dotnet/commit/5dd8bca0b4def432d3c7714d21947a2632208431))

## Version 4.7.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 4.6.0, released 2023-10-30

### New features

- Introduce Discovery API protos and methods ([commit 89da231](https://github.com/googleapis/google-cloud-dotnet/commit/89da231f9973f8f481d10251f598e44b8c9e50cf))

### Documentation improvements

- Update comments for many messages. ([commit 89da231](https://github.com/googleapis/google-cloud-dotnet/commit/89da231f9973f8f481d10251f598e44b8c9e50cf))

## Version 4.5.0, released 2023-01-17

### New features

- Enable REST transport in C# ([commit cdb518c](https://github.com/googleapis/google-cloud-dotnet/commit/cdb518c3524106ea73f0e546557a0180589ca3b0))

## Version 4.4.0, released 2022-12-01

### New features

- ExcludeByHotword added as an ExclusionRule type, NEW_ZEALAND added as a LocationCategory value ([commit fde47e7](https://github.com/googleapis/google-cloud-dotnet/commit/fde47e7a0e12822bfae2fc17fe0040c1a7b04202))

## Version 4.3.0, released 2022-10-03

### Bug fixes

- Deprecate extra field to avoid confusion ([commit 2947b46](https://github.com/googleapis/google-cloud-dotnet/commit/2947b46a8e23cbbc7187d1573e567373cc8d6968))

## Version 4.2.0, released 2022-09-05

### New features

- Add Deidentify action ([commit c74e772](https://github.com/googleapis/google-cloud-dotnet/commit/c74e77280744b8cfe3827bdbc152889cf96fbb17))

## Version 4.1.0, released 2022-07-25

### New features

- InfoType categories were added to built-in infoTypes ([commit cafbab1](https://github.com/googleapis/google-cloud-dotnet/commit/cafbab1089c725e668ebb6abaa28045e45382162))

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
## Version 3.5.0, released 2022-04-04

### New features

- Add DataProfilePubSubMessage supporting pub/sub integration ([commit 5d46153](https://github.com/googleapis/google-cloud-dotnet/commit/5d461532af7674d5494ee29dfb9867897910b347))
- New Bytes and File types: POWERPOINT and EXCEL ([commit 114219d](https://github.com/googleapis/google-cloud-dotnet/commit/114219d198dc22acfd4fdf2839e3bda6bc7f17af))

## Version 3.4.0, released 2021-12-07

- [Commit 4ccc8e5](https://github.com/googleapis/google-cloud-dotnet/commit/4ccc8e5):
  - feat: added deidentify replacement dictionaries
  - feat: added field for BigQuery inspect template inclusion lists
  - feat: added field to support infotype versioning

## Version 3.3.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 3.2.0, released 2021-05-25

No API surface changes; just dependency updates.

## Version 3.1.0, released 2020-10-19

- [Commit 18f5adb](https://github.com/googleapis/google-cloud-dotnet/commit/18f5adb): Fix: retrieve job config for risk analysis jobs. Docs: clarify timespan config for BigQuery and Datastore.
- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 381929c](https://github.com/googleapis/google-cloud-dotnet/commit/381929c): docs: correct the links for parent fields
- [Commit 2722f39](https://github.com/googleapis/google-cloud-dotnet/commit/2722f39): docs: expand parent field format, and BigQuery sampling options. Also describing which transformations are allowed for ReidentifyContent API calls, and the custom alphabet allowed for format-preserving encryption (FPE).
- [Commit f38e102](https://github.com/googleapis/google-cloud-dotnet/commit/f38e102):
  - feat: Add CSV and TSV to file types.
  - fix: Cleaned up resource_reference annotations for correct semantics and improved client library generation
  - fix: BucketingConfig.replacement_value marked as required ([issue 5153](https://github.com/googleapis/google-cloud-dotnet/issues/5153))
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit f4f2b5f](https://github.com/googleapis/google-cloud-dotnet/commit/f4f2b5f): docs: fix several broken links in the docs.

## Version 3.0.0, released 2020-06-01

- [Commit dee878e](https://github.com/googleapis/google-cloud-dotnet/commit/dee878e): Fix routing by including location resource names
- [Commit 363bfe4](https://github.com/googleapis/google-cloud-dotnet/commit/363bfe4):
  - feat: Release new file type enums and new MetadataLocation proto
  - chore: Rename InspectFindingName to FindingName (due to resource name changes)

Both of these changes are breaking, hence the major version bump.

## Version 2.0.0, released 2020-04-08

No API surface changes since 2.0.0-beta03.

## Version 2.0.0-beta03, released 2020-03-26

- [Commit 0490888](https://github.com/googleapis/google-cloud-dotnet/commit/0490888):
  - Feature: Adds fields to Finding
  - Feature: Support for hybrid jobs

## Version 2.0.0-beta02, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.1.0, released 2019-12-11

- [Commit 484e335](https://github.com/googleapis/google-cloud-dotnet/commit/484e335): Adds LocationId to multiple messages in preparation for regionalization
- [Commit 8dd3a37](https://github.com/googleapis/google-cloud-dotnet/commit/8dd3a37): Added "publish to Stackdriver" functionality.
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Added Format method to all resource name classes

## Version 1.0.0, released 2019-07-10

Initial GA release.
