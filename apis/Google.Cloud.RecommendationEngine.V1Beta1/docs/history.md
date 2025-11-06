# Version history

## Version 2.0.0-beta07, released 2025-11-06

### New features

- Update dependencies

## Version 2.0.0-beta06, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-beta05, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-beta04, released 2024-02-29

No API surface changes; just dependency updates.

## Version 2.0.0-beta03, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 31e55cd](https://github.com/googleapis/google-cloud-dotnet/commit/31e55cdbafe12bfae68e28a75a1b75ceb445684f))

### Documentation improvements

- Fix minor docstring formatting ([commit fda6528](https://github.com/googleapis/google-cloud-dotnet/commit/fda6528eb5dfdfa5b99238fd21a85ec660efde14))

## Version 2.0.0-beta02, released 2022-09-15

### Bug fixes

- Fix recommendationengine resource name configuration ([commit c9e5588](https://github.com/googleapis/google-cloud-dotnet/commit/c9e558821f1b2f9451015cb3cf34142f2ae95d1d))

## Version 2.0.0-beta01, released 2022-06-08

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


## Version 1.0.0-beta03, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta02, released 2021-05-05

- [Commit 4766903](https://github.com/googleapis/google-cloud-dotnet/commit/4766903): docs: place paths in code spans

## Version 1.0.0-beta01, released 2020-11-09

First beta release.
