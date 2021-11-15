# Version history

## Version 2.4.0, released 2021-09-23

- [Commit 2a57d32](https://github.com/googleapis/google-cloud-dotnet/commit/2a57d32): docs: Fix the documentation for BigtableServiceApiSettings

## Version 2.3.0, released 2021-08-18

- [Commit b58fa0b](https://github.com/googleapis/google-cloud-dotnet/commit/b58fa0b): Fix Bigtable for self-signed JWTs
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): Regenerate all APIs with self-signed JWT support

This release fixes a subtle bug that would cause BigtableServiceApiClient.Create() to fail when used with GAX 3.5.0, as well as enabling self-signed JWT support.

## Version 2.2.0, released 2021-05-05

- [Commit 9f5f0aa](https://github.com/googleapis/google-cloud-dotnet/commit/9f5f0aa): fix: Regenerate server-streaming calls with Google request params. Fixes [issue 6310](https://github.com/googleapis/google-cloud-dotnet/issues/6310).
- [Commit 1b91d27](https://github.com/googleapis/google-cloud-dotnet/commit/1b91d27): feat: migrate bigtable retry/timeout settings to gRPC's service configs

## Version 2.1.1, released 2020-12-02

- [Commit ef17912](https://github.com/googleapis/google-cloud-dotnet/commit/ef17912): feat: Reduce the gRPC keepalive time from 1 minute to 30 seconds

This change may improve reliability (and makes this library consistent with other languages) but does not affect the API surface.

## Version 2.1.0, released 2020-10-12

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Regenerate all APIs with generator changes to fix timeouts
- [Commit 808fab8](https://github.com/googleapis/google-cloud-dotnet/commit/808fab8): chore: set Ruby namespace in proto options
- [Commit 0c129ac](https://github.com/googleapis/google-cloud-dotnet/commit/0c129ac): chore: Update bigtable grpc service config
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-04-08

No API surface changes compared with 2.0.0-beta02, just a GA release.

## Version 2.0.0-beta02, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.1.0, released 2019-12-10

- [Commit 372e60b](https://github.com/googleapis/google-cloud-dotnet/commit/372e60b): Some retry settings are now obsolete, and will be removed from the next major version
- [Commit ee5c7dc](https://github.com/googleapis/google-cloud-dotnet/commit/ee5c7dc): Introduce client builder types for simpler configuration
- Additional RPC overloads

## Version 1.0.0, released 2019-05-23

Initial GA release.
