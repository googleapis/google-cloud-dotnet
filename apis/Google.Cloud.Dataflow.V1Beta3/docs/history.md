# Version history

## Version 2.0.0-beta03, released 2023-01-17

### New features

- Enable REST transport in C# ([commit cdb518c](https://github.com/googleapis/google-cloud-dotnet/commit/cdb518c3524106ea73f0e546557a0180589ca3b0))

## Version 2.0.0-beta02, released 2022-07-11

### Documentation improvements

- Corrected the Dataflow job name regex ([commit 7501e60](https://github.com/googleapis/google-cloud-dotnet/commit/7501e6036aad008e6021fd7968730223a3bb6bc3))

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
## Version 1.0.0-beta03, released 2022-03-28

### Bug fixes

- Added google.api.http annotations to RPCs. Fixes [issue 7038](https://github.com/googleapis/google-cloud-dotnet/issues/7038). ([commit 7e6edad](https://github.com/googleapis/google-cloud-dotnet/commit/7e6edad1653324684e07186c859ee4b7c41ebea5))

### New features

- Add the ability to plumb environment capabilities through v1beta3 protos. ([commit f703fba](https://github.com/googleapis/google-cloud-dotnet/commit/f703fba5ac47cef0badc2248c5a41088ca49dd5e))
- New parameters in FlexTemplateRuntimeEnvironment ([commit 7e6edad](https://github.com/googleapis/google-cloud-dotnet/commit/7e6edad1653324684e07186c859ee4b7c41ebea5))

## Version 1.0.0-beta02, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta01, released 2021-06-23

Initial release.
