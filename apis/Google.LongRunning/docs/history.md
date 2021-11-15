# Version history

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
