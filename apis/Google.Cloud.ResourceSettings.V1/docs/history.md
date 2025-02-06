# Version history

## Version 2.5.0, released 2025-02-05

This release is being used to publish a new front-page of
documentation, to indicate package deprecation.

## Version 2.4.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.3.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.2.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 2.1.0, released 2023-01-18

### New features

- Enable REST transport in C# ([commit f9ccce7](https://github.com/googleapis/google-cloud-dotnet/commit/f9ccce7aa4e16a8049445724cf57e8e390c66bfc))

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
## Version 1.2.0, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.1.0, released 2021-08-10

- [Commit 4d6b7e8](https://github.com/googleapis/google-cloud-dotnet/commit/4d6b7e8): feat:Publish Cloud ResourceSettings v1 API

## Version 1.0.0, released 2021-06-28

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2021-06-08

Initial release.
