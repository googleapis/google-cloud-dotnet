# Version history

## Version 2.7.0, released 2025-04-10

### New features

- A new method_signature `parent,submission` is added to method `SubmitUri` in service `WebRiskService`

### Documentation improvements

- A comment for message `ThreatInfo` is changed
- A comment for message `SubmitUriMetadata` is changed

## Version 2.6.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.5.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.4.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 2.3.0, released 2023-05-26

### New features

- Add SubmitUri endpoint ([commit bb16fb8](https://github.com/googleapis/google-cloud-dotnet/commit/bb16fb8d44f4dd3e922e10aca6ead540ed74481c))

## Version 2.2.0, released 2023-01-17

### New features

- Enable REST transport in C# ([commit cdb518c](https://github.com/googleapis/google-cloud-dotnet/commit/cdb518c3524106ea73f0e546557a0180589ca3b0))

## Version 2.1.0, released 2022-10-17

### New features

- Add SOCIAL_ENGINEERING_EXTENDED_COVERAGE threat type ([commit df88f32](https://github.com/googleapis/google-cloud-dotnet/commit/df88f324f85e9c127c22e943e9d12c5268aea08e))

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
## Version 1.3.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 1.1.0, released 2020-11-11

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 0edb34b](https://github.com/googleapis/google-cloud-dotnet/commit/0edb34b): fix: add CreateSubmission to webrisk/v1 config
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 1.0.0, released 2020-04-08

No API surface changes since 1.0.0-beta01.

## Version 1.0.0-beta01, released 2020-03-19

Initial beta release for V1 API.


