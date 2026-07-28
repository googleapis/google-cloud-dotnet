# Version history

## Version 3.0.0-beta08, released 2025-11-06

### New features

- Update dependencies

## Version 3.0.0-beta07, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.0.0-beta06, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.0.0-beta05, released 2024-03-13

No API surface changes; just dependency updates.

## Version 3.0.0-beta04, released 2024-02-09

### Bug fixes

- **BREAKING CHANGE** Remove BufferTask method which cannot be called from client libraries ([commit 41c1707](https://github.com/googleapis/google-cloud-dotnet/commit/41c170792d0bb39fdceddfcee7938ebb06bb4588))

## Version 3.0.0-beta03, released 2023-08-04

### New features

- Add BufferTask RPC method for CloudTasks service for v2beta3 ([commit 36504a4](https://github.com/googleapis/google-cloud-dotnet/commit/36504a43d32649cb13b347bd18263c341eaf2c26))
- Add YAML config for GetLocation and ListLocations for v2beta3 ([commit 36504a4](https://github.com/googleapis/google-cloud-dotnet/commit/36504a43d32649cb13b347bd18263c341eaf2c26))

### Documentation improvements

- Minor formatting ([commit 7c49dff](https://github.com/googleapis/google-cloud-dotnet/commit/7c49dffc44bf828460d367673ec802778832cd1d))

## Version 3.0.0-beta02, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 6ce3faf](https://github.com/googleapis/google-cloud-dotnet/commit/6ce3faf6f74ea6c63e14ee4c77627a6774fb807f))

## Version 3.0.0-beta01, released 2022-06-08

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


## Version 2.0.0-beta08, released 2021-12-07

- [Commit e90a4a5](https://github.com/googleapis/google-cloud-dotnet/commit/e90a4a5): docs: fix docstring formatting

## Version 2.0.0-beta07, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.0.0-beta06, released 2021-06-22

- [Commit db0b36e](https://github.com/googleapis/google-cloud-dotnet/commit/db0b36e): docs: fix grammar in documentation.

## Version 2.0.0-beta05, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.0.0-beta04, released 2021-01-22

- [Commit 3bc4a75](https://github.com/googleapis/google-cloud-dotnet/commit/3bc4a75):
  - feat: Configurable tombstoning and task retention
  - docs: updates to max burst size description

## Version 2.0.0-beta03, released 2020-11-18

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 975c526](https://github.com/googleapis/google-cloud-dotnet/commit/975c526): feat: introducing field Queue.type docs: fixing typos and minor updates
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0-beta02, released 2020-03-19

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-19

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0-beta08, released 2019-12-09

- Remove use of Tasks-specific LocationName; use the one in GAX instead
- IAM methods now accept IResourceName instead of specific resource name types
- Retry settings removed
- Resource name types have format methods

## Version 1.0.0-beta07, released 2019-06-18

(No API surface changes.)

## Version 1.0.0-beta06, released 2019-06-18

(No API surface changes.)

## Version 1.0.0-beta05, released 2019-06-17

- [Commit ee5c7dc](https://github.com/googleapis/google-cloud-dotnet/commit/ee5c7dc): Added client builders for simplified configuration

## Version 1.0.0-beta04, released 2019-05-15

- Queue.LogSamplingRatio removed
- Methods accepting resource name parameters now have equivalents accepting string parameters
- Added StackdriverLoggingConfig

## Version 1.0.0-beta03, released 2019-04-08

- [Commit fb520db](https://github.com/googleapis/google-cloud-dotnet/commit/fb520db): Added HttpRequest authorization

## Version 1.0.0-beta02, released 2019-03-12

- Extra HttpMethod enum values
- Added HttpRequest support

## Version 1.0.0-beta01, released 2018-09-03

Initial beta release.

