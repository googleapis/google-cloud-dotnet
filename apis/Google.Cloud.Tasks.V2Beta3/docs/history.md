# Version history

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
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
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

