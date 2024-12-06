# Version history

## Version 2.6.0, released 2024-12-06

No API changes, just dependency updates.
## Version 2.5.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.3.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 2.2.0, released 2023-08-04

### New features

- Added network and uid fields in Endpoint message ([commit 2ac10dd](https://github.com/googleapis/google-cloud-dotnet/commit/2ac10dd0784cc229899d7b135c5f10ccd249c501))
- Added uid field to Namespace message ([commit 2ac10dd](https://github.com/googleapis/google-cloud-dotnet/commit/2ac10dd0784cc229899d7b135c5f10ccd249c501))
- Added uid field to Service message ([commit 2ac10dd](https://github.com/googleapis/google-cloud-dotnet/commit/2ac10dd0784cc229899d7b135c5f10ccd249c501))
- Enable Location methods ([commit 2ac10dd](https://github.com/googleapis/google-cloud-dotnet/commit/2ac10dd0784cc229899d7b135c5f10ccd249c501))

### Documentation improvements

- Updated docs for ResolveServiceRequest message ([commit 2ac10dd](https://github.com/googleapis/google-cloud-dotnet/commit/2ac10dd0784cc229899d7b135c5f10ccd249c501))
- Updated docs for ListServicesRequest and ListEndpointsRequest message ([commit 2ac10dd](https://github.com/googleapis/google-cloud-dotnet/commit/2ac10dd0784cc229899d7b135c5f10ccd249c501))

## Version 2.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

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


## Version 1.4.0, released 2022-04-26

No API surface changes; just dependency updates.

## Version 1.3.0, released 2021-12-07

- [Commit 7c9d9f0](https://github.com/googleapis/google-cloud-dotnet/commit/7c9d9f0): docs: fix docstring formatting
## Version 1.2.0, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.1.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 1.0.0, released 2021-01-20

No API changes since 1.0.0-beta01.

## Version 1.0.0-beta01, released 2020-11-16

Initial release.
