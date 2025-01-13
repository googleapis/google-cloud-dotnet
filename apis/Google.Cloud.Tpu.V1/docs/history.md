# Version history

## Version 2.4.0, released 2025-01-13

### New features

- Add UNKNOWN to TPU node state, This state will be used to prevent a node from being marked as READY during diagnose after it has failed repair ([commit 5bcb874](https://github.com/googleapis/google-cloud-dotnet/commit/5bcb874031918e9b82d7cdf9ae947d044a5522f6))

## Version 2.3.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.2.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.1.0, released 2024-02-29

### Documentation improvements

- Minor updates in comments ([commit 4386e68](https://github.com/googleapis/google-cloud-dotnet/commit/4386e6852ffac109d2e464d3e1f2bf41c6239c3b))

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


## Version 1.1.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-06-22

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2021-05-27

Initial release.
