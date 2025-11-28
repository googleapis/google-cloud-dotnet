# Version history

## Version 2.0.0-beta07, released 2025-11-05

### New features

- Update dependencies

## Version 2.0.0-beta06, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.0.0-beta05, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-beta04, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-beta03, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.0.0-beta02, released 2022-09-02

### Bug fixes

- **BREAKING CHANGE** Refactor references to Category message ([commit 56b0759](https://github.com/googleapis/google-cloud-dotnet/commit/56b0759444c88b64334b25873891ff81edcd74bd))

### New features

- **BREAKING CHANGE** Update BigQuery Analytics Hub API v1beta1 client ([commit 56b0759](https://github.com/googleapis/google-cloud-dotnet/commit/56b0759444c88b64334b25873891ff81edcd74bd))

### Documentation improvements

- Improve proto documentation. ([commit 56b0759](https://github.com/googleapis/google-cloud-dotnet/commit/56b0759444c88b64334b25873891ff81edcd74bd))

### Breaking changes

- Refresh current dataexchange/v1beta1/* directory to include recent change in protos. Removed common directory and use local enum Category ([commit 56b0759](https://github.com/googleapis/google-cloud-dotnet/commit/56b0759444c88b64334b25873891ff81edcd74bd))

Note that the Google.Cloud.BigQuery.DataExchange.Common package is
no longer a dependency of this package, and will be delisted from
nuget.org.

## Version 2.0.0-beta01, released 2022-06-09

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

## Version 1.0.0-beta01, released 2022-05-10

Initial release.
