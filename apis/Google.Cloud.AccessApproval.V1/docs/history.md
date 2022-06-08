# Version history

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
