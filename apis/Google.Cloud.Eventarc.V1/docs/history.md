# Version history

## Version 2.6.0, released 2024-10-29

### New features

- Publish Eventarc Advanced protos ([commit 5bb7fc6](https://github.com/googleapis/google-cloud-dotnet/commit/5bb7fc6b056a33c2d61a1104d231701f288369d2))

### Documentation improvements

- Clarified multiple comments in Eventarc Standard protos ([commit 5bb7fc6](https://github.com/googleapis/google-cloud-dotnet/commit/5bb7fc6b056a33c2d61a1104d231701f288369d2))

## Version 2.5.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.3.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.2.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 2.1.0, released 2022-11-10

### New features

- Add CMEK support to Eventarc client library ([commit 907cfb5](https://github.com/googleapis/google-cloud-dotnet/commit/907cfb526db4fad4c9bdb0ff4d10608603248c1c))
- Update Eventarc Channel to support custom events ([commit 907cfb5](https://github.com/googleapis/google-cloud-dotnet/commit/907cfb526db4fad4c9bdb0ff4d10608603248c1c))

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


## Version 1.3.0, released 2022-05-24

### New features

- Add Provider resources ([commit 80b4859](https://github.com/googleapis/google-cloud-dotnet/commit/80b4859ce09adb71406b210b1b4ad2f7c974e1c5))

## Version 1.2.0, released 2022-02-07

### New features

- Add Channel and ChannelConnection resources ([commit 19356ba](https://github.com/googleapis/google-cloud-dotnet/commit/19356bad85fefa8e1c8d7b42c9494d60dbb77481))

## Version 1.1.0, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-07-05

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2021-06-16

Initial release.
