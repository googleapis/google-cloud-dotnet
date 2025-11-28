# Version history

## Version 3.5.0, released 2025-11-03

### New features

- Update dependencies

## Version 3.4.0, released 2025-10-09

### New features

- Add ListOperations partial success flag
- Add ListOperations unreachable resources

### Documentation improvements

- Clarity and typo fixes for documentation
- Fix example rpc naming

## Version 3.3.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.2.0, released 2024-03-25

### New features

This library now targets netstandard2.0 instead of netstandard2.1.
This should be compatible with existing libraries that depend on it,
but will allow new libraries to also target netstandard2.0.

## Version 3.1.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 3.0.0, released 2022-06-07

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code.The changes that aren't specific to any given API are [described in the Google Cloud
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

- [Commit 604c39b](https://github.com/googleapis/google-cloud-dotnet/commit/604c39b): Regenerated Google.LongRunning with extended_operations.proto ([issue 7117](https://github.com/googleapis/google-cloud-dotnet/issues/7117))
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-19

No API surface changes since 2.1.0, just dependency and comment updates.

## Version 2.1.0, released 2020-10-19

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-03-16

No API surface changes compared with 2.0.0-beta01, just dependencies
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.2.0-beta01, released 2019-06-10

- [Commit ee5c7dc](https://github.com/googleapis/google-cloud-dotnet/commit/ee5c7dc):
  - Introduce ClientBuilders for all APIs (except Grafeas)
  - (We need to work out what to do about Grafeas separately. Next commit will be code to remove the new builder which is generated for Grafeas.)
- [Commit 0cb5661](https://github.com/googleapis/google-cloud-dotnet/commit/0cb5661):
  - Revert "Regenerate all clients, without retrying on DeadlineExceeded"
  - This reverts commit 877f04bb6a47d51399d2e4945e60f05a2b9097d0.
- [Commit 877f04b](https://github.com/googleapis/google-cloud-dotnet/commit/877f04b): Regenerate all clients, without retrying on DeadlineExceeded
- [Commit 34507ab](https://github.com/googleapis/google-cloud-dotnet/commit/34507ab): Use effective settings for PollUntilCompleted more carefully. Fixes [issue 3029](https://github.com/googleapis/google-cloud-dotnet/issues/3029).
- [Commit a1a01f9](https://github.com/googleapis/google-cloud-dotnet/commit/a1a01f9):
  - Regenerate all APIs with updated generator
  - This populates x-goog-request-params on all requests
- [Commit 45cd32e](https://github.com/googleapis/google-cloud-dotnet/commit/45cd32e):
  - Regenerate Long Running Operations API
  - This introduces a new WaitOperation call, along with comment changes
- [Commit e539ddc](https://github.com/googleapis/google-cloud-dotnet/commit/e539ddc): Regenerate LRO API: comment changes only

## Version 1.1.0, released 2019-02-19

Added async RPC methods accepting full request objects.

## Version 1.0.0, released 2017-09-19

Initial GA release.
