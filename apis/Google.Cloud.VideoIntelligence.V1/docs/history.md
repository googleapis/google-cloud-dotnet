# Version history

## Version 3.5.0, released 2025-11-06

### New features

- Update dependencies

## Version 3.4.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.3.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.2.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 3.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 6ce3faf](https://github.com/googleapis/google-cloud-dotnet/commit/6ce3faf6f74ea6c63e14ee4c77627a6774fb807f))

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


## Version 2.3.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-04-29

- [Commit dc219ec](https://github.com/googleapis/google-cloud-dotnet/commit/dc219ec): feat: Introduce tracks and thumbnails fields for FaceDetectionAnnotations proto.

## Version 2.1.0, released 2020-10-05

- [Commit dfb141a](https://github.com/googleapis/google-cloud-dotnet/commit/dfb141a): feat: GA launch for PersonDetection and FaceDetection features.
- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-03-19

No API surface changes compared with 2.0.0-beta02, just dependency
and implementation changes.

## Version 2.0.0-beta02, released 2020-03-12

- [Commit 1d8b26a](https://github.com/googleapis/google-cloud-dotnet/commit/1d8b26a): Generator change to allow interception of builder methods
- [Commit 9982d04](https://github.com/googleapis/google-cloud-dotnet/commit/9982d04): Feature: Logo recognition
- [Commit ba6f275](https://github.com/googleapis/google-cloud-dotnet/commit/ba6f275): Documentation: Links in comments are now full URLs

## Version 2.0.0-beta01, released 2020-02-19

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.3.0, released 2019-12-09

- [Commit cf20a0e](https://github.com/googleapis/google-cloud-dotnet/commit/cf20a0e): Retry settings are now obsolete, and will be removed in the next major version.

## Version 1.2.0, released 2019-08-13

- [Commit e24d5be](https://github.com/googleapis/google-cloud-dotnet/commit/e24d5be): Adds support for segment and shot presence
- [Commit abbbf43](https://github.com/googleapis/google-cloud-dotnet/commit/abbbf43): Provides segment and feature tracking in results

## Version 1.1.0, released 2019-07-10

- Expose AnnotateVideoException
- Added object tracking
- Added text detection
- Added speech transcription

## Version 1.0.0, released 2017-11-15

Initial GA release.
