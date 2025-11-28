# Version history

## Version 3.0.0-beta06, released 2025-11-06

### New features

- Update dependencies

## Version 3.0.0-beta05, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.0.0-beta04, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.0.0-beta03, released 2024-02-29

No API surface changes; just dependency updates.

## Version 3.0.0-beta02, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

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


## Version 2.0.0-beta09, released 2022-02-14

### New features

- Add secondary_ip_range field ([commit cb003a3](https://github.com/googleapis/google-cloud-dotnet/commit/cb003a32f9f077fd5a14da788a3a842c52698f67))

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

