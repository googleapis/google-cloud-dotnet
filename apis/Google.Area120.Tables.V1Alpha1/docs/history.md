# Version history

## Version 2.0.0-alpha02, released 2023-01-17

### New features

- Enable REST transport in C# ([commit cdb518c](https://github.com/googleapis/google-cloud-dotnet/commit/cdb518c3524106ea73f0e546557a0180589ca3b0))

## Version 2.0.0-alpha01, released 2022-06-08

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
## Version 1.0.0-alpha04, released 2021-08-18

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-alpha03, released 2021-04-28

- [Commit 294f56e](https://github.com/googleapis/google-cloud-dotnet/commit/294f56e): feat: Added ListWorkspaces, GetWorkspace, BatchDeleteRows APIs.

## Version 1.0.0-alpha02, released 2020-11-19

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

## Version 1.0.0-alpha01, released 2020-09-22

First alpha release.

