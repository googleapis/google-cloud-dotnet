# Version history

## Version 2.7.0, released 2024-08-13

### New features

- Added `build_service_account` field to CloudFunction ([commit 079e5b0](https://github.com/googleapis/google-cloud-dotnet/commit/079e5b09d5f5eda0408af303685bada9e2c0f97e))

### Documentation improvements

- A comment for field `runtime_version` in message `.google.cloud.functions.v1.CloudFunction` is changed ([commit 079e5b0](https://github.com/googleapis/google-cloud-dotnet/commit/079e5b09d5f5eda0408af303685bada9e2c0f97e))
- A comment for field `docker_repository` in message `.google.cloud.functions.v1.CloudFunction` is changed ([commit 079e5b0](https://github.com/googleapis/google-cloud-dotnet/commit/079e5b09d5f5eda0408af303685bada9e2c0f97e))
- A comment for field `automatic_update_policy` in message `.google.cloud.functions.v1.CloudFunction` is changed ([commit 079e5b0](https://github.com/googleapis/google-cloud-dotnet/commit/079e5b09d5f5eda0408af303685bada9e2c0f97e))
- A comment for field `on_deploy_update_policy` in message `.google.cloud.functions.v1.CloudFunction` is changed ([commit 079e5b0](https://github.com/googleapis/google-cloud-dotnet/commit/079e5b09d5f5eda0408af303685bada9e2c0f97e))
- A comment for field `url` in message `.google.cloud.functions.v1.SourceRepository` is changed ([commit 079e5b0](https://github.com/googleapis/google-cloud-dotnet/commit/079e5b09d5f5eda0408af303685bada9e2c0f97e))
- A comment for field `url` in message `.google.cloud.functions.v1.HttpsTrigger` is changed ([commit 079e5b0](https://github.com/googleapis/google-cloud-dotnet/commit/079e5b09d5f5eda0408af303685bada9e2c0f97e))

## Version 2.6.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.5.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.4.0, released 2024-03-13

No API surface changes; just dependency updates.

## Version 2.3.0, released 2024-02-09

### New features

- Updated description for `docker_registry` to reflect transition to Artifact Registry ([commit 9a4683f](https://github.com/googleapis/google-cloud-dotnet/commit/9a4683f9311e6e7357f63a204cd7dbef08494f24))
- Fields for automatic runtime updates ([commit 9a4683f](https://github.com/googleapis/google-cloud-dotnet/commit/9a4683f9311e6e7357f63a204cd7dbef08494f24))
- Additional optional parameter `version_id` added to `GetFunctionRequest` ([commit 9a4683f](https://github.com/googleapis/google-cloud-dotnet/commit/9a4683f9311e6e7357f63a204cd7dbef08494f24))
- Reflects deprecation of `network` field ([commit 9a4683f](https://github.com/googleapis/google-cloud-dotnet/commit/9a4683f9311e6e7357f63a204cd7dbef08494f24))
- Minor updates in comments throughout ([commit 9a4683f](https://github.com/googleapis/google-cloud-dotnet/commit/9a4683f9311e6e7357f63a204cd7dbef08494f24))

## Version 2.2.0, released 2023-05-11

### New features

- Added mix-ins for long running operations, IAM, and locations ([commit 598f5cd](https://github.com/googleapis/google-cloud-dotnet/commit/598f5cdfce9da1355657232d9ed878093b469b3b))

### Documentation improvements

- Clarified that vpcConnector shortname is only returned if the connector is in the same project as the function ([commit 598f5cd](https://github.com/googleapis/google-cloud-dotnet/commit/598f5cdfce9da1355657232d9ed878093b469b3b))
- Applied general style guide updates to descriptions ([commit 598f5cd](https://github.com/googleapis/google-cloud-dotnet/commit/598f5cdfce9da1355657232d9ed878093b469b3b))

## Version 2.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

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

- Added support for CMEK ([commit 0a513ca](https://github.com/googleapis/google-cloud-dotnet/commit/0a513ca35d45c878eb6a35dc2780c6965bcb7211))

### Documentation improvements

- Clarified wording around quota usage ([commit 0a513ca](https://github.com/googleapis/google-cloud-dotnet/commit/0a513ca35d45c878eb6a35dc2780c6965bcb7211))
## Version 1.3.0, released 2021-11-10

- [Commit 2b667d4](https://github.com/googleapis/google-cloud-dotnet/commit/2b667d4):
  - feat: Secret Manager integration fields 'secret_environment_variables' and 'secret_volumes' added
  - feat: CMEK integration fields 'kms_key_name' and 'docker_repository' added

## Version 1.2.0, released 2021-09-23

- [Commit d4815e4](https://github.com/googleapis/google-cloud-dotnet/commit/d4815e4): feat: add SecurityLevel option on HttpsTrigger
- [Commit 9ac0b1d](https://github.com/googleapis/google-cloud-dotnet/commit/9ac0b1d): docs: minor formatting fixes to Cloud Functions reference docs
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs
- [Commit 6aa7606](https://github.com/googleapis/google-cloud-dotnet/commit/6aa7606):
  - fix: Updating behavior of source_upload_url during Get/List function calls
  - Regenerating cloud functions docs

## Version 1.1.0, released 2021-05-05

No API surface changes; just dependency updates.

## Version 1.0.0, released 2020-10-19

Initial GA release.

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

## Version 1.0.0-beta01, released 2020-07-15

Initial beta release.


