# Version history

## Version 3.7.0, released 2025-11-06

### New features

- Update dependencies

## Version 3.6.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.5.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.4.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 3.3.0, released 2023-01-25

### New features

- Add Cloud Trace v2 retry defaults for BatchWriteSpans ([commit be4bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/be4bdf14bdb2dbfeff2eb3a747c07c1b952a3ec5))

### Documentation improvements

- Remove html formatting (cleanup) ([commit 8b31e3d](https://github.com/googleapis/google-cloud-dotnet/commit/8b31e3d4fe7aaf88e25aa933a66586d22b088e03))

## Version 3.2.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit f6a1c3e](https://github.com/googleapis/google-cloud-dotnet/commit/f6a1c3e8930f0e8209a079352765be3bb9039be2))

## Version 3.1.0, released 2022-09-15

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
## Version 2.3.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-11-11

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 9e2dd7a](https://github.com/googleapis/google-cloud-dotnet/commit/9e2dd7a):
  - feat: added support for span kind
  - Clients can now specify the span kind of spans.
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit ec6af90](https://github.com/googleapis/google-cloud-dotnet/commit/ec6af90): chore: set Ruby namespace in proto options
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-19

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.1.0, released 2019-12-09

- [Commit 8f268e0](https://github.com/googleapis/google-cloud-dotnet/commit/8f268e0): Some retry settings are now obsolete, and will be removed from the next major version
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Adds resource name Format methods

## Version 1.0.0, released 2019-07-10

Initial GA release.
