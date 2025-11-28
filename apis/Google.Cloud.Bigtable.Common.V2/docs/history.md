# Version history

## Version 3.3.0, released 2025-11-03

### New features

- Update dependencies

## Version 3.2.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.1.0, released 2024-03-13

No API surface changes; just dependency updates.

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

### Bigtable-specific breaking changes

- Move InstanceName into Google.Cloud.Bigtable.Common.V2 ([commit cb8d93e](https://github.com/googleapis/google-cloud-dotnet/commit/cb8d93ebcc822c45361a1d756fdddf0d13fae051))
  (Previously, this was in Google.Cloud.Bigtable.V2 and Google.Cloud.Bigtable.Admin.V2)
## Version 2.1.0, released 2021-05-25

No API surface changes; just dependency updates.

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

- [Commit d29c61b](https://github.com/googleapis/google-cloud-dotnet/commit/d29c61b): Add resource name format methods to resource name classes

## Version 1.0.0, released 2019-05-23

Initial GA release.
