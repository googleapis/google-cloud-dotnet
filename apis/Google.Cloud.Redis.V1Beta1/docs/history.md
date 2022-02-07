# Version history

## Version 2.0.0-beta08, released 2022-02-07

### New features

- Add automated RDB (AKA persistence) ([commit 6e089e6](https://github.com/googleapis/google-cloud-dotnet/commit/6e089e6d230539017573c479183e8e710c81ac4e))

## Version 2.0.0-beta07, released 2022-01-17

### Bug fixes

- [Cloud Memorystore for Redis] Add missing fields for TLS and Maintenance Window features ([commit 7dc9e4c](https://github.com/googleapis/google-cloud-dotnet/commit/7dc9e4c2ddf74ef3ab49b137df07af8c9a57a517))

## Version 2.0.0-beta06, released 2021-11-10

- [Commit bdfaff0](https://github.com/googleapis/google-cloud-dotnet/commit/bdfaff0): feat: Support Multiple Read Replicas when creating Instance

## Version 2.0.0-beta05, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.0.0-beta04, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.0.0-beta03, released 2020-11-16

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit af55fde](https://github.com/googleapis/google-cloud-dotnet/commit/af55fde): docs: change relative URLs to absolute URLs to fix broken links.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 2c4b73f](https://github.com/googleapis/google-cloud-dotnet/commit/2c4b73f): docs: Comment-only changes

## Version 2.0.0-beta02, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0-beta04, released 2019-12-09

- Use the common LocationName type in GAX rather than a Redis-specific one
- Retry settings have been removed

## Version 1.0.0-beta03, released 2019-06-24

- Added instance import/export/failover functionality
- Added GCS as a source and destination

## Version 1.0.0-beta02, released 2018-08-02

- Added more request resource name properties
- Some method parameters converted from strings to resource names

## Version 1.0.0-beta01, released 2018-05-08

Initial release.

