# Version history

## Version 2.6.0, released 2025-11-03

### New features

- Update dependencies

## Version 2.5.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.3.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.2.0, released 2023-01-11

This is primarily a promotion of the previous beta, which includes
REST transport support. No API surface changes; just dependency updates.

## Version 2.2.0-beta01, released 2022-12-08

### New features

- Enable REST transport in selected APIs. Set GrpcAdapter=RestGrpcAdapter.Default in the client builder to use this transport ([commit 5008946](https://github.com/googleapis/google-cloud-dotnet/commit/500894667ba84ecc3d8e3e4ebc09ac0cd597100b))

## Version 2.1.0, released 2022-08-26

### Documentation improvements

- Added Cloud Dataproc and Secret Manager to the list of supported services ([commit 2e67e98](https://github.com/googleapis/google-cloud-dotnet/commit/2e67e9886da7e0c76743b4176bf3a9509e7db922))

## Version 2.0.0, released 2022-06-08

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code.The changes that aren't specific to any given API are [described in the Google Cloud
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
## Version 1.4.0, released 2022-05-24

### New features

- Update protos to include InvalidateApprovalRequest and GetAccessApprovalServiceAccount APIs ([commit 35064fa](https://github.com/googleapis/google-cloud-dotnet/commit/35064fa422497ab9577ec95e466896778472ec8f))

## Version 1.3.0, released 2022-02-14

### New features

- Added flag for implicit dismissal for `DismissDecision` ([commit 5d1b5af](https://github.com/googleapis/google-cloud-dotnet/commit/5d1b5af90988ddb6ac2e62e8d9cd9711b51e54cd))

### Documentation improvements

- Added resource annotations ([commit 5d1b5af](https://github.com/googleapis/google-cloud-dotnet/commit/5d1b5af90988ddb6ac2e62e8d9cd9711b51e54cd))

## Version 1.2.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.1.0, released 2021-05-25

No API surface changes; just dependency updates.

## Version 1.0.0, released 2021-01-18

No API changes since 1.0.0-beta02.

## Version 1.0.0-beta02, released 2020-12-09

- [Commit d093233](https://github.com/googleapis/google-cloud-dotnet/commit/d093233): fix!: Regenerate Google.Cloud.AccessApproval.V1

BREAKING CHANGE: The gRPC "raw" client classes are renamed compared with beta01. However, beta01 would be unable to make any RPCs due to incorrect generation.

## Version 1.0.0-beta01, released 2020-12-07

Initial release.
