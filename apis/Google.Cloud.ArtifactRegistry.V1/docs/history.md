# Version history

## Version 2.10.0, released 2025-04-14

### New features

- add the GoModule and KfpArtifact resources

### Documentation improvements

- remove the restriction of the maximum numbers of versions that can be deleted in one BatchDeleteVersions call

## Version 2.9.0, released 2024-10-29

### New features

- Add Artifact Registry attachment API ([commit 04eb4d7](https://github.com/googleapis/google-cloud-dotnet/commit/04eb4d7d1da82e897d63f34b629ccc427ea86e16))
- Add Artifact Registry custom remote support ([commit 04eb4d7](https://github.com/googleapis/google-cloud-dotnet/commit/04eb4d7d1da82e897d63f34b629ccc427ea86e16))
- Add Artifact Registry generic repository support ([commit 04eb4d7](https://github.com/googleapis/google-cloud-dotnet/commit/04eb4d7d1da82e897d63f34b629ccc427ea86e16))
- Add Artifact Registry server side resource filtering and sorting ([commit 04eb4d7](https://github.com/googleapis/google-cloud-dotnet/commit/04eb4d7d1da82e897d63f34b629ccc427ea86e16))
- Add Artifact Registry rule APIs ([commit 04eb4d7](https://github.com/googleapis/google-cloud-dotnet/commit/04eb4d7d1da82e897d63f34b629ccc427ea86e16))
- Add Artifact Registry UpdateFile and DeleteFile APIs ([commit 04eb4d7](https://github.com/googleapis/google-cloud-dotnet/commit/04eb4d7d1da82e897d63f34b629ccc427ea86e16))

### Documentation improvements

- Include max page size for all Artifact Registry APIs ([commit 04eb4d7](https://github.com/googleapis/google-cloud-dotnet/commit/04eb4d7d1da82e897d63f34b629ccc427ea86e16))

## Version 2.8.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.7.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.6.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.5.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.4.0, released 2023-10-30

### New features

- Add support for virtual and remote repositories ([commit 766f731](https://github.com/googleapis/google-cloud-dotnet/commit/766f731eafdcded59f327e962976d35f5cb1d791))
- Add support for cleanup policies ([commit 766f731](https://github.com/googleapis/google-cloud-dotnet/commit/766f731eafdcded59f327e962976d35f5cb1d791))
- Add support for Docker immutable tags ([commit 766f731](https://github.com/googleapis/google-cloud-dotnet/commit/766f731eafdcded59f327e962976d35f5cb1d791))
- Add support for Go and KFP repositories ([commit 766f731](https://github.com/googleapis/google-cloud-dotnet/commit/766f731eafdcded59f327e962976d35f5cb1d791))
- Add support for Physical Zone Separation ([commit 766f731](https://github.com/googleapis/google-cloud-dotnet/commit/766f731eafdcded59f327e962976d35f5cb1d791))
- Expose the size of the Repository resource ([commit 766f731](https://github.com/googleapis/google-cloud-dotnet/commit/766f731eafdcded59f327e962976d35f5cb1d791))

### Documentation improvements

- Use code font for resource name references ([commit 766f731](https://github.com/googleapis/google-cloud-dotnet/commit/766f731eafdcded59f327e962976d35f5cb1d791))
- Mark the create_time and update_time in the Repository resource as output only fields ([commit 766f731](https://github.com/googleapis/google-cloud-dotnet/commit/766f731eafdcded59f327e962976d35f5cb1d791))
- Mark the repository_id and repository fields in the CreateRepository request as required fields ([commit 766f731](https://github.com/googleapis/google-cloud-dotnet/commit/766f731eafdcded59f327e962976d35f5cb1d791))

## Version 2.3.0, released 2023-09-26

### Bug fixes

- Make repository and repository_id in CreateRepository required ([commit b0752af](https://github.com/googleapis/google-cloud-dotnet/commit/b0752afb3c5a83bffb901743d9a8cd44d526d574))

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
