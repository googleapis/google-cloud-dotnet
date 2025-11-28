# Version history

## Version 3.0.0-beta10, released 2025-11-06

### New features

- Update dependencies

### Documentation improvements

- A comment for field `parent` in message `.google.cloud.oslogin.v1beta.SignSshPublicKeyRequest` is changed

## Version 3.0.0-beta09, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.0.0-beta08, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 3.0.0-beta07, released 2024-02-29

No API surface changes; just dependency updates.

## Version 3.0.0-beta06, released 2024-01-16

### New features

- Added field `ImportSshPublicKeyRequest.regions` ([commit 6d6fe74](https://github.com/googleapis/google-cloud-dotnet/commit/6d6fe7487ba6998ad5749ef1b52bb43961647be0))

## Version 3.0.0-beta05, released 2023-10-30

### New features

- Location-based HTTP binding for SignSshPublicKey ([commit ff031f2](https://github.com/googleapis/google-cloud-dotnet/commit/ff031f2f1d40c147ad8c078f09b3fe09c7a23615))

## Version 3.0.0-beta04, released 2023-10-02

### New features

- Added SecurityKey.device_nickname ([commit 37ff7f1](https://github.com/googleapis/google-cloud-dotnet/commit/37ff7f1392bd794af3bd44281df320f8ff4c0e91))

## Version 3.0.0-beta03, released 2023-08-16

### New features

- Launch signSshPublicKey in beta ([commit 19c34de](https://github.com/googleapis/google-cloud-dotnet/commit/19c34de1802c255a1e87a7f3a136ce07aaab2ec0))

## Version 3.0.0-beta02, released 2023-02-08

### New features

- Enable REST transport ([commit 46d4fe8](https://github.com/googleapis/google-cloud-dotnet/commit/46d4fe8461ac30e7666600e44e7bd16228768621))
- Added CreateSshPublicKey RPC ([commit ea76949](https://github.com/googleapis/google-cloud-dotnet/commit/ea76949ef04bdb3444666b5d79532f06cdc3d8c0))

## Version 3.0.0-beta01, released 2022-06-09

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

## Version 2.0.0-beta05, released 2021-09-20

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.0.0-beta04, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.0.0-beta03, released 2020-11-12

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

(This release took multiple attempts, so there are multiple commits with this message.)

## Version 2.0.0-beta02, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0-beta02, released 2019-12-11

## Version 1.0.0-beta01, released 2017-12-22

Initial beta release.
