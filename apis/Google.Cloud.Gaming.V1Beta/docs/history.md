# Version history

## Version 2.0.0-beta01, released 2022-06-08

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


## Version 1.0.0-beta09, released 2021-12-07

- [Commit 00bded1](https://github.com/googleapis/google-cloud-dotnet/commit/00bded1): docs: fix docstring formatting
## Version 1.0.0-beta08, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta07, released 2021-05-26

No API surface changes; just dependency updates.

## Version 1.0.0-beta06, released 2020-11-18

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

## Version 1.0.0-beta05, released 2020-09-22

- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Adds service comments to client documentation
- [Commit 1765de9](https://github.com/googleapis/google-cloud-dotnet/commit/1765de9):
  - fix!: Corrects return type of long running delete operations
  - fix: Increases timeout for CreateGameServerCluster ([issue 5125](https://github.com/googleapis/google-cloud-dotnet/issues/5125))
- [Commit 0bf565a](https://github.com/googleapis/google-cloud-dotnet/commit/0bf565a): feat: Adds retry configuration.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Adds more explicit documentation.
  
## Version 1.0.0-beta04, released 2020-04-23

No API changes; this release is for release automation testing.

## Version 1.0.0-beta03, released 2020-04-22

No API changes; this release is for release automation testing.

## Version 1.0.0-beta02, released 2020-04-17

No API changes; this release is for release automation testing.

## Version 1.0.0-beta01, released 2020-03-19

Initial release for beta API.
