# Version history

## Version 2.15.0, released 2025-02-18

### New features

- Support for git proxy setup ([commit 377ec77](https://github.com/googleapis/google-cloud-dotnet/commit/377ec7749999ee4d288205056975c1c39bfb3d64))
- Add option to enable fetching dependencies ([commit f4430c8](https://github.com/googleapis/google-cloud-dotnet/commit/f4430c836be3850d8444a8009d33924b89224dee))

### Documentation improvements

- Updates to proto message comments ([commit 377ec77](https://github.com/googleapis/google-cloud-dotnet/commit/377ec7749999ee4d288205056975c1c39bfb3d64))

## Version 2.14.0, released 2025-01-13

### New features

- Add option to enable structured logging ([commit 881f147](https://github.com/googleapis/google-cloud-dotnet/commit/881f147890736fc7eb43747dec7db60afa527841))
- Add GoModule to Artifact and Results messages and new GO_MODULE_H1 hash type ([commit 6903167](https://github.com/googleapis/google-cloud-dotnet/commit/6903167f75cb3fc38012f0780fefd1a2492dcf9f))

## Version 2.13.0, released 2024-10-29

### New features

- Add PrivateServiceConnect option to WorkerPool ([commit 59748e6](https://github.com/googleapis/google-cloud-dotnet/commit/59748e60fa58d45650d8f63981db904478308272))

## Version 2.12.0, released 2024-09-26

### New features

- Add LEGACY_BUCKET option to DefaultLogsBucketBehavior ([commit 2f2b8d0](https://github.com/googleapis/google-cloud-dotnet/commit/2f2b8d05336d6487277288331c7d2c674a827c37))

### Documentation improvements

- Sanitize docs ([commit 2f2b8d0](https://github.com/googleapis/google-cloud-dotnet/commit/2f2b8d05336d6487277288331c7d2c674a827c37))

## Version 2.11.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.10.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.9.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.8.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.7.0, released 2023-11-07

### New features

- Add optional field "SourceFetcher" to choose source fetcher tool ([commit 5740cd2](https://github.com/googleapis/google-cloud-dotnet/commit/5740cd23080c15d0d2c7e872cc2c3e55307a7a27))

## Version 2.6.0, released 2023-08-04

### New features

- Add update_mask to UpdateBuildTriggerRequest proto ([commit 1b10e84](https://github.com/googleapis/google-cloud-dotnet/commit/1b10e842187af385bf22f2ab334785539c72a0c3))
- Add automap_substitutions flag to use substitutions as envs in Cloud Build ([commit ae515fb](https://github.com/googleapis/google-cloud-dotnet/commit/ae515fb363445ea21c06500acce5d53a08d34081))
- Add git_file_source and git_repo_source to build_trigger ([commit 510e913](https://github.com/googleapis/google-cloud-dotnet/commit/510e9133c70a36d731b563d10225d5238422be75))

## Version 2.5.0, released 2023-07-13

### New features

- Add routing information in Cloud Build GRPC clients ([commit 89156c3](https://github.com/googleapis/google-cloud-dotnet/commit/89156c3719f4dcf1d371fe6a974cf8d62cd9384a))
- Added e2-medium machine type ([commit dc5d51f](https://github.com/googleapis/google-cloud-dotnet/commit/dc5d51ff8eda2db70bb23bb4034cc65c404c7731))
- Add repositoryevent to buildtrigger ([commit e207559](https://github.com/googleapis/google-cloud-dotnet/commit/e207559237a093beef962df0b10d973518eac4b4))

## Version 2.4.0, released 2023-04-19

### New features

- Add PeeredNetworkIpRange to NetworkConfigs message ([commit dcab5a1](https://github.com/googleapis/google-cloud-dotnet/commit/dcab5a1f3b313f883978d151f09bcf9a3fc0dbca))
- Add NpmPackages to Artifact and Results messages and new SHA512 hash type ([commit dcab5a1](https://github.com/googleapis/google-cloud-dotnet/commit/dcab5a1f3b313f883978d151f09bcf9a3fc0dbca))
- Update third party clodubuild.proto library to include git_source ([commit 6c369f5](https://github.com/googleapis/google-cloud-dotnet/commit/6c369f5baaab5af66addcde14d7cf4483a8d4709))

### Documentation improvements

- Various doc updates ([commit dcab5a1](https://github.com/googleapis/google-cloud-dotnet/commit/dcab5a1f3b313f883978d151f09bcf9a3fc0dbca))

## Version 2.3.0, released 2023-03-20

### New features

- Add DefaultLogsBucketBehavior to BuildOptions ([commit bff0128](https://github.com/googleapis/google-cloud-dotnet/commit/bff012833bd33f2c4b60f92aea08632e25419234))

## Version 2.2.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 31e55cd](https://github.com/googleapis/google-cloud-dotnet/commit/31e55cdbafe12bfae68e28a75a1b75ceb445684f))

## Version 2.1.0, released 2022-11-02

### New features

- Integration of Cloud Build with Artifact Registry ([commit 6fb3a24](https://github.com/googleapis/google-cloud-dotnet/commit/6fb3a24d473518376fd5b7c039a8539dfd7d1f9c))
- Add allow_failure, exit_code, and allow_exit_code to BuildStep message ([commit 7612013](https://github.com/googleapis/google-cloud-dotnet/commit/7612013d377a10dc35baba930ce30fe61ba77ad0))

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


## Version 1.4.0, released 2021-09-23

- [Commit e84109d](https://github.com/googleapis/google-cloud-dotnet/commit/e84109d):
  - feat: Add script field to BuildStep message
  - feat: Update cloudbuild proto with the service_account for BYOSA Triggers.
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs
- [Commit 26753cf](https://github.com/googleapis/google-cloud-dotnet/commit/26753cf): feat: Add ability to configure BuildTriggers to create Builds that require approval before executing and ApproveBuild API to approve or reject pending Builds

## Version 1.3.0, released 2021-07-29

- [Commit 0ded664](https://github.com/googleapis/google-cloud-dotnet/commit/0ded664): docs: Add a new build phase `SETUPBUILD` for timing information
- [Commit cf7e645](https://github.com/googleapis/google-cloud-dotnet/commit/cf7e645): feat: Implementation of Build Failure Info
- [Commit ae27ce0](https://github.com/googleapis/google-cloud-dotnet/commit/ae27ce0): feat!: add a WorkerPools API
- [Commit 48b5b1d](https://github.com/googleapis/google-cloud-dotnet/commit/48b5b1d): Synchronize new proto/yaml changes.

Note that the new WorkerPools API is a technically-breaking change,
as there was a previous, similar API in earlier releases. However,
as that API wasn't implemented on the back-end, we're not bumping
the major version: we don't expect customers were actually referring
to the old messages in their code.

## Version 1.2.0, released 2021-06-22

- [Commit 8c80969](https://github.com/googleapis/google-cloud-dotnet/commit/8c80969):
  - feat: Implementation of Source Manifests
    - Added message StorageSourceManifest as an option for the Source message
    - Added StorageSourceManifest field to the SourceProvenance message

## Version 1.1.0, released 2021-04-29

- [Commit f4e1ad2](https://github.com/googleapis/google-cloud-dotnet/commit/f4e1ad2): feat: Add fields for Pub/Sub triggers
- [Commit f3ab04e](https://github.com/googleapis/google-cloud-dotnet/commit/f3ab04e):
  - fix: Specify `build` as the body of a `CreateBuild` call. The Cloud Build API has always assumed this, but now we are actually specifying it.
  - feat: Add `ReceiveTriggerWebhook` for webhooks activating specific triggers.
  - docs: Update field docs on required-ness behavior and fix typos.
  - docs: Add `$PROJECT_NUMBER` as a substitution variable.
  - feat: Add `SecretManager`-related resources and messages for corresponding integration.
  - docs: Clarify lifetime/expiration behavior around `ListBuilds` page tokens.
  - feat: Add `COMMENTS_ENABLED_FOR_EXTERNAL_CONTRIBUTORS_ONLY` for corresponding comment control behavior with triggered builds.
  - feat: Add `E2_HIGHCPU_8` and `E2_HIGHCPU_32` machine types.

## Version 1.0.0, released 2021-03-02

No API surface changes since 1.0.0-beta01.

## Version 1.0.0-beta01, released 2021-01-06

Initial release.
