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

## Version 3.2.0, released 2023-05-11

### New features

- [Cloud Memorystore for Redis] Add CMEK key field ([commit 5856c34](https://github.com/googleapis/google-cloud-dotnet/commit/5856c345a5b226fe041eebdfabeb70e53d2ec9b4))
- [Cloud Memorystore for Redis] Add suspension_reasons field ([commit 5856c34](https://github.com/googleapis/google-cloud-dotnet/commit/5856c345a5b226fe041eebdfabeb70e53d2ec9b4))
- [Cloud Memorystore for Redis] Add persistence support ([commit 5856c34](https://github.com/googleapis/google-cloud-dotnet/commit/5856c345a5b226fe041eebdfabeb70e53d2ec9b4))
- [Cloud Memorystore for Redis] Add self service update maintenance version support ([commit 5856c34](https://github.com/googleapis/google-cloud-dotnet/commit/5856c345a5b226fe041eebdfabeb70e53d2ec9b4))

## Version 3.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

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


## Version 2.5.0, released 2022-04-04

### New features

- Add support for Maintenance Window ([commit fa2f5e9](https://github.com/googleapis/google-cloud-dotnet/commit/fa2f5e95b580a0aa03618408b09d798c9e6d82d8))
- Add support for AUTH functionality ([commit bed04f2](https://github.com/googleapis/google-cloud-dotnet/commit/bed04f2667156b728fe42c748f71fddf613c02e7))
- Add support for TLS functionality ([commit bed04f2](https://github.com/googleapis/google-cloud-dotnet/commit/bed04f2667156b728fe42c748f71fddf613c02e7))
- Add secondary_ip_range field ([commit bed04f2](https://github.com/googleapis/google-cloud-dotnet/commit/bed04f2667156b728fe42c748f71fddf613c02e7))

## Version 2.4.0, released 2021-11-10

- [Commit a7e87ee](https://github.com/googleapis/google-cloud-dotnet/commit/a7e87ee): feat: Support Multiple Read Replicas when creating Instance

## Version 2.3.0, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-11-09

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 0014243](https://github.com/googleapis/google-cloud-dotnet/commit/0014243): redis: v1 add UpgradeInstance request
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit a9ff54c](https://github.com/googleapis/google-cloud-dotnet/commit/a9ff54c): docs: change relative URLs to absolute URLs to fix broken links.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit c9149b9](https://github.com/googleapis/google-cloud-dotnet/commit/c9149b9): docs: Comment-only changes

## Version 2.0.0, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.1.0, released 2019-12-09

- [Commit 95691ca](https://github.com/googleapis/google-cloud-dotnet/commit/95691ca): Retry settings are now obsolete, and will be removed from the next major version
- Async RPC methods now always have overloads accepting request objects
- Resource name classes now have format methods

## Version 1.0.0, released 2019-07-10

Initial GA release.
