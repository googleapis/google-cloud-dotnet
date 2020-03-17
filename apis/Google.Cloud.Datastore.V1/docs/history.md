# Version history

# Version 3.0.0, released 2020-03-17

No API surface changes compared with 3.0.0-beta01, just dependency
and implementation changes.

# Version 3.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

Additional breaking changes not covered in the guide:

- The `EmulatorDetection` enum is now in the `Google.Api.Gax`
  namespace, and the previous `ProductionOrEmulator` value within
  it has been renamed to `EmulatorOrProduction`.

# Version 2.2.0, released 2019-12-09

- Implement DatastoreDbBuilder for easy configuration, including emulator support
- Multiple code generation improvements
- Some retry-based settings are now obsolete, and will be removed in the next major release

# Version 2.1.0, released 2018-02-01

- [Commit 3730474](https://github.com/googleapis/google-cloud-dotnet/commit/3730474): Implement Datastore transaction options in DatastoreDb.
- [Commit 6287f81](https://github.com/googleapis/google-cloud-dotnet/commit/6287f81): Added transaction options to underlying API

# Version 2.0.0, released 2017-06-22

- [Commit 04c3fdc](https://github.com/googleapis/google-cloud-dotnet/commit/04c3fdc): Retry setting changes
- [Commit 49e0362](https://github.com/googleapis/google-cloud-dotnet/commit/49e0362): ConfigureAwait fixes
- Dependency on GAX updated to v2

# Version 1.0.0, released 2017-03-30

Initial GA release.
