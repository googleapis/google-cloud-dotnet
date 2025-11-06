# Version history

## Version 2.5.0, released 2025-11-06

### New features

- Update dependencies

## Version 2.4.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.3.0, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 2.2.0, released 2024-02-27

### New features

- Include api_key_uid in service control check response ([commit dffe35a](https://github.com/googleapis/google-cloud-dotnet/commit/dffe35a814210c672e29aa83bf8449acd5fdace3))

## Version 2.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit f6a1c3e](https://github.com/googleapis/google-cloud-dotnet/commit/f6a1c3e8930f0e8209a079352765be3bb9039be2))

## Version 2.0.0, released 2022-06-08

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


## Version 1.4.0, released 2021-12-07

- [Commit db2e28f](https://github.com/googleapis/google-cloud-dotnet/commit/db2e28f): docs: fix docstring formatting
## Version 1.3.0, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.2.0, released 2021-08-10

- [Commit 574bc96](https://github.com/googleapis/google-cloud-dotnet/commit/574bc96):
  - feat: Added the gRPC service config for the Service Controller v1 API
  - docs: Updated some comments.

## Version 1.1.0, released 2021-04-29

No API surface changes, but a minor version bump for dependency updates.

## Version 1.0.0, released 2021-01-18

No API changes since 1.0.0-beta01.

## Version 1.0.0-beta01, released 2020-11-05

First beta release.
