# Version history

## Version 4.2.0, released 2022-07-27

### New features

- Added database ID to request messages ([commit adf2d20](https://github.com/googleapis/google-cloud-dotnet/commit/adf2d202eb0fc206df6195cb46df98e7a6486160))
## Version 4.1.0, released 2022-06-22

### New features

- Add `IN` and `NOT_IN` operators ([commit 409b4f5](https://github.com/googleapis/google-cloud-dotnet/commit/409b4f5a273550d7aaf03af95aab0803327aa405))

## Version 4.0.0, released 2022-06-08

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

### Documentation improvements

- Document encoding of non-UTF-8 key strings in the Cloud Datastore API ([commit ee61d4d](https://github.com/googleapis/google-cloud-dotnet/commit/ee61d4d37ab4dd330bdc39d35f5172a6d6985aa0))
## Version 3.5.0, released 2022-04-26

### New features

- Expose new read_time API fields, currently only available in private preview ([commit 4bc260c](https://github.com/googleapis/google-cloud-dotnet/commit/4bc260c0f34a5f5296badaefa4e6d962499cc225))

## Version 3.4.0, released 2022-04-04

### New features

- Add IN/NOT_IN/NOT_EQUALS support to cloud datastore proto ([commit e76f560](https://github.com/googleapis/google-cloud-dotnet/commit/e76f5605392877acebaaa0b652896e3e27b72418))

## Version 3.3.0, released 2021-08-18

- [Commit d9a3648](https://github.com/googleapis/google-cloud-dotnet/commit/d9a3648): fix: Fix Firestore and Datastore for self-signed JWTs
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 3.2.0, released 2021-05-05

- [Commit 8bb2981](https://github.com/googleapis/google-cloud-dotnet/commit/8bb2981): Use CopySettingsForEmulator in DatastoreDbBuilder

No API surface changes, but CopySettingsForEmulator ensures that any UserAgent or GrpcAdapter set in the client builder is also used in the emulator.

## Version 3.1.0, released 2020-09-28

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit a009b4b](https://github.com/googleapis/google-cloud-dotnet/commit/a009b4b): fix: Specify insecure credentials when connecting to the emulator. Fixes [issue 5365](https://github.com/googleapis/google-cloud-dotnet/issues/5365).
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): feat: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Regenerate all APIs with proper timeout handling
- [Commit 42b9797](https://github.com/googleapis/google-cloud-dotnet/commit/42b9797): chore: set Ruby namespace in proto options
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 03279b9](https://github.com/googleapis/google-cloud-dotnet/commit/03279b9): docs: Fix documentation for string_value. The value does not have to be at least 1MB, but rather, at most 1MB.

## Version 3.0.0, released 2020-03-17

No API surface changes compared with 3.0.0-beta01, just dependency
and implementation changes.

## Version 3.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

Additional breaking changes not covered in the guide:

- The `EmulatorDetection` enum is now in the `Google.Api.Gax`
  namespace, and the previous `ProductionOrEmulator` value within
  it has been renamed to `EmulatorOrProduction`.

## Version 2.2.0, released 2019-12-09

- Implement DatastoreDbBuilder for easy configuration, including emulator support
- Multiple code generation improvements
- Some retry-based settings are now obsolete, and will be removed in the next major release

## Version 2.1.0, released 2018-02-01

- [Commit 3730474](https://github.com/googleapis/google-cloud-dotnet/commit/3730474): Implement Datastore transaction options in DatastoreDb.
- [Commit 6287f81](https://github.com/googleapis/google-cloud-dotnet/commit/6287f81): Added transaction options to underlying API

## Version 2.0.0, released 2017-06-22

- [Commit 04c3fdc](https://github.com/googleapis/google-cloud-dotnet/commit/04c3fdc): Retry setting changes
- [Commit 49e0362](https://github.com/googleapis/google-cloud-dotnet/commit/49e0362): ConfigureAwait fixes
- Dependency on GAX updated to v2

## Version 1.0.0, released 2017-03-30

Initial GA release.
