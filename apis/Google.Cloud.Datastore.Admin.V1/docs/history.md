# Version history

## Version 2.5.0, released 2025-11-05

### New features

- Update dependencies

## Version 2.4.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.3.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.2.0, released 2024-02-28

### Documentation improvements

- Specify limit for `properties` in `Index` message in Datastore Admin API ([commit 2e2e21b](https://github.com/googleapis/google-cloud-dotnet/commit/2e2e21bc8c6e01672dc17e966f8d824c37ec60de))
- Minor formatting in Datastore Admin API ([commit 2e2e21b](https://github.com/googleapis/google-cloud-dotnet/commit/2e2e21bc8c6e01672dc17e966f8d824c37ec60de))

## Version 2.1.0, released 2023-01-16

### New features

- Enable REST transport in C# ([commit a6c4606](https://github.com/googleapis/google-cloud-dotnet/commit/a6c46063bd961a9dadc728a780d66de772f28e71))

## Version 2.0.0, released 2022-06-08

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

### New features

- New enum value `OPTIMISTIC_WITH_ENTITY_GROUPS` for `ConcurrencyMode` ([commit 20717a1](https://github.com/googleapis/google-cloud-dotnet/commit/20717a1d76222e984e7f32ac12016b78cc99b435))

### Documentation improvements

- Clarifications for `DatastoreFirestoreMigraitonMetadata` ([commit 20717a1](https://github.com/googleapis/google-cloud-dotnet/commit/20717a1d76222e984e7f32ac12016b78cc99b435))

## Version 1.4.0, released 2022-01-17

### New features

- Define Datastore -> Firestore in Datastore mode migration long running operation metadata ([commit f182b74](https://github.com/googleapis/google-cloud-dotnet/commit/f182b7447ea2c831093b3bb5c5abf3fe5f829f39))

## Version 1.3.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.2.0, released 2021-08-10

- [Commit c13f1e3](https://github.com/googleapis/google-cloud-dotnet/commit/c13f1e3): feat: Publish message definitions for new Cloud Datastore migration logging steps.

## Version 1.1.0, released 2021-04-29

- [Commit 1313ce6](https://github.com/googleapis/google-cloud-dotnet/commit/1313ce6): feat: Added methods for creating and deleting composite indexes
- [Commit 823a43e](https://github.com/googleapis/google-cloud-dotnet/commit/823a43e): feat: Publish message definitions for Cloud Datastore migration logging.

## Version 1.0.0, released 2020-11-18

First GA release.

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

## Version 1.0.0-beta01, released 2020-09-07

First beta release.


