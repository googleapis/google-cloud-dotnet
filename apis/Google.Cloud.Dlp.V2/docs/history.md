# Version history

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
