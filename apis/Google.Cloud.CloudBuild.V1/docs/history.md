# Version history

# Version 1.3.0, released 2021-07-29

- [Commit 0ded664](https://github.com/googleapis/google-cloud-dotnet/commit/0ded664): docs: Add a new build phase `SETUPBUILD` for timing information
- [Commit cf7e645](https://github.com/googleapis/google-cloud-dotnet/commit/cf7e645): feat: Implementation of Build Failure Info
- [Commit ae27ce0](https://github.com/googleapis/google-cloud-dotnet/commit/ae27ce0): feat!: add a WorkerPools API
- [Commit 48b5b1d](https://github.com/googleapis/google-cloud-dotnet/commit/48b5b1d): Synchronize new proto/yaml changes.

Note that the new WorkerPools API is a technically-breaking change,
as there was a previous, similar API in earlier releases. However,
as that API wasn't implemented on the back-end, we're not bumping
the major version: we don't expect customers were actually referring
to the old messages in their code.

# Version 1.2.0, released 2021-06-22

- [Commit 8c80969](https://github.com/googleapis/google-cloud-dotnet/commit/8c80969):
  - feat: Implementation of Source Manifests
    - Added message StorageSourceManifest as an option for the Source message
    - Added StorageSourceManifest field to the SourceProvenance message

# Version 1.1.0, released 2021-04-29

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

# Version 1.0.0, released 2021-03-02

No API surface changes since 1.0.0-beta01.

# Version 1.0.0-beta01, released 2021-01-06

Initial release.
