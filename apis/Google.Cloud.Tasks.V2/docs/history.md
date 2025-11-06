# Version history

## Version 3.6.0, released 2025-11-06

### New features

- Update dependencies

## Version 3.5.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.3.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 3.2.0, released 2023-08-04

### New features

- Increase timeout of RPC methods to 20s ([commit f2145a6](https://github.com/googleapis/google-cloud-dotnet/commit/f2145a6c006382a1e136aeca6db3f07c914d195e))
- Add YAML config for GetLocation and ListLocation ([commit f2145a6](https://github.com/googleapis/google-cloud-dotnet/commit/f2145a6c006382a1e136aeca6db3f07c914d195e))

## Version 3.1.0, released 2023-01-11

This is primarily a promotion of the previous beta, which includes
REST transport support. No API surface changes; just dependency updates.

## Version 3.1.0-beta01, released 2022-12-08

### New features

- Enable REST transport in selected APIs. Set GrpcAdapter=RestGrpcAdapter.Default in the client builder to use this transport ([commit 5008946](https://github.com/googleapis/google-cloud-dotnet/commit/500894667ba84ecc3d8e3e4ebc09ac0cd597100b))

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


## Version 2.5.0, released 2022-04-26

No API surface changes; just dependency updates.

## Version 2.4.0, released 2021-12-07

- [Commit bb10aef](https://github.com/googleapis/google-cloud-dotnet/commit/bb10aef): docs: fix docstring formatting

## Version 2.3.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-11-11

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-03-19

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta02, released 2020-03-11

- [Commit 8d040c3](https://github.com/googleapis/google-cloud-dotnet/commit/8d040c3): Adds StackdriverLoggingConfig and Queue.StackdriverLoggingConfig

## Version 2.0.0-beta01, released 2020-02-19

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.1.0, released 2019-12-09

- [Commit dc37caa](https://github.com/googleapis/google-cloud-dotnet/commit/dc37caa): Retry settings are now obsolete and will be removed in the next major version
- [Commit af47eb8](https://github.com/googleapis/google-cloud-dotnet/commit/af47eb8): Adds HttpRequest target
- [Commit ee5c7dc](https://github.com/googleapis/google-cloud-dotnet/commit/ee5c7dc): Add client builders for simple configuration
- [Commit 1424e89](https://github.com/googleapis/google-cloud-dotnet/commit/1424e89): Add string-accepting equivalents to all resource-name-accepting methods
- Resource name types now have format methods

## Version 1.0.0, released 2019-04-25

Initial GA release.

