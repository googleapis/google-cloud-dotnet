# Version history

## Version 2.2.0, released 2023-02-08

### Bug fixes

- Make `GetFileRequest.name` and `ListFilesRequest.parent` required ([commit fdab706](https://github.com/googleapis/google-cloud-dotnet/commit/fdab7068c60f640d21113616cc77978578a3cf36))
- Make `Package` a resource ([commit fdab706](https://github.com/googleapis/google-cloud-dotnet/commit/fdab7068c60f640d21113616cc77978578a3cf36))
- Deprecate `REDIRECTION_FROM_GCR_IO_FINALIZED` ([commit fdab706](https://github.com/googleapis/google-cloud-dotnet/commit/fdab7068c60f640d21113616cc77978578a3cf36))

### New features

- Add format-specific resources `MavenArtifact`, `NpmPackage`, `KfpArtifact` and `PythonPackage` ([commit fdab706](https://github.com/googleapis/google-cloud-dotnet/commit/fdab7068c60f640d21113616cc77978578a3cf36))
- Add `order_by` to `ListDockerImages` ([commit fdab706](https://github.com/googleapis/google-cloud-dotnet/commit/fdab7068c60f640d21113616cc77978578a3cf36))
- Add an API to get and update VPCSC config ([commit fdab706](https://github.com/googleapis/google-cloud-dotnet/commit/fdab7068c60f640d21113616cc77978578a3cf36))
- Add `BatchDeleteVersionMetadata` to return version that failed to delete ([commit fdab706](https://github.com/googleapis/google-cloud-dotnet/commit/fdab7068c60f640d21113616cc77978578a3cf36))

## Version 2.1.0, released 2023-01-16

### New features

- Enable REST transport in C# ([commit a6c4606](https://github.com/googleapis/google-cloud-dotnet/commit/a6c46063bd961a9dadc728a780d66de772f28e71))
- Add location methods ([commit a8855da](https://github.com/googleapis/google-cloud-dotnet/commit/a8855dae9bdb866553cd29b0fb3f52f4cf529dd5))

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


## Version 1.1.0, released 2022-04-04

### New features

- Promote v1beta2 features to v1 ([commit 5c5d56f](https://github.com/googleapis/google-cloud-dotnet/commit/5c5d56f989536b2764bf777e6db6a3a98da6ab27))

## Version 1.0.0, released 2021-11-10

- [Commit a21c747](https://github.com/googleapis/google-cloud-dotnet/commit/a21c747): docs: fix docstring formatting

Initial GA release.

## Version 1.0.0-beta01, released 2021-10-14

Initial beta release.
