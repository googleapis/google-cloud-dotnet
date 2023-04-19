# Version history

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
