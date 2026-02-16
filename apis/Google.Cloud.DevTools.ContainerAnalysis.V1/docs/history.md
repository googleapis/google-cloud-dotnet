# Version history

## Version 3.14.0, released 2026-02-16

### New features

- A new field `registry` is added to message `.grafeas.v1.BaseImage`
- A new field `advisory_publish_time` is added to message `.grafeas.v1.VulnerabilityNote`

## Version 3.13.0, released 2026-01-29

### New features

- A new field `last_vulnerability_update_time` is added to message `.grafeas.v1.DiscoveryOccurrence`

## Version 3.12.0, released 2026-01-13

### New features

- A new message `File` is added
- A new field `files` is added to message `.grafeas.v1.DiscoveryOccurrence`
- A new field `return_partial_success` is added to message `.grafeas.v1.ListOccurrencesRequest`
- A new field `unreachable` is added to message `.grafeas.v1.ListOccurrencesResponse`
- A new field `return_partial_success` is added to message `.grafeas.v1.ListNotesRequest`
- A new field `unreachable` is added to message `.grafeas.v1.ListNotesResponse`
- A new message `Risk` is added
- A new message `CISAKnownExploitedVulnerabilities` is added
- A new message `ExploitPredictionScoringSystem` is added
- A new field `data` is added to message `.grafeas.v1.SecretOccurrence`
- A new field `digest` is added to message `.grafeas.v1.SecretOccurrence`
- A new value `SECRET_KIND_GCP_API_KEY` is added to enum `SecretKind`
- A new value `SECRET_KIND_GCP_OAUTH2_CLIENT_CREDENTIALS` is added to enum `SecretKind`
- A new value `SECRET_KIND_GCP_OAUTH2_ACCESS_TOKEN` is added to enum `SecretKind`
- A new value `SECRET_KIND_ANTHROPIC_ADMIN_API_KEY` is added to enum `SecretKind`
- A new value `SECRET_KIND_ANTHROPIC_API_KEY` is added to enum `SecretKind`
- A new value `SECRET_KIND_AZURE_ACCESS_TOKEN` is added to enum `SecretKind`
- A new value `SECRET_KIND_AZURE_IDENTITY_TOKEN` is added to enum `SecretKind`
- A new value `SECRET_KIND_DOCKER_HUB_PERSONAL_ACCESS_TOKEN` is added to enum `SecretKind`
- A new value `SECRET_KIND_GITHUB_APP_REFRESH_TOKEN` is added to enum `SecretKind`
- A new value `SECRET_KIND_GITHUB_APP_SERVER_TO_SERVER_TOKEN` is added to enum `SecretKind`
- A new value `SECRET_KIND_GITHUB_APP_USER_TO_SERVER_TOKEN` is added to enum `SecretKind`
- A new value `SECRET_KIND_GITHUB_CLASSIC_PERSONAL_ACCESS_TOKEN` is added to enum `SecretKind`
- A new value `SECRET_KIND_GITHUB_FINE_GRAINED_PERSONAL_ACCESS_TOKEN` is added to enum `SecretKind`
- A new value `SECRET_KIND_GITHUB_OAUTH_TOKEN` is added to enum `SecretKind`
- A new value `SECRET_KIND_HUGGINGFACE_API_KEY` is added to enum `SecretKind`
- A new value `SECRET_KIND_OPENAI_API_KEY` is added to enum `SecretKind`
- A new value `SECRET_KIND_PERPLEXITY_API_KEY` is added to enum `SecretKind`
- A new value `SECRET_KIND_STRIPE_SECRET_KEY` is added to enum `SecretKind`
- A new value `SECRET_KIND_STRIPE_RESTRICTED_KEY` is added to enum `SecretKind`
- A new value `SECRET_KIND_STRIPE_WEBHOOK_SECRET` is added to enum `SecretKind`
- A new field `risk` is added to message `.grafeas.v1.VulnerabilityOccurrence`

### Documentation improvements

- A comment for enum value `SECRET_KIND_GCP_SERVICE_ACCOUNT_KEY` in enum `SecretKind` is changed

## Version 3.11.0, released 2025-11-05

### New features

- Update dependencies

## Version 3.10.0, released 2025-05-08

Same code as 3.9.0, just a re-release to fix process issues.

## Version 3.9.0, released 2025-05-06

Note: this release failed due to release process changes; we will release a 3.10.0 shortly.

### New features

- Support for Secrets
- Support for Layer Details

## Version 3.8.0, released 2025-04-03

### New features

- Add ExportSBOM API method for v1 ([commit 8213d4c](https://github.com/googleapis/google-cloud-dotnet/commit/8213d4ce0aec3f7a881da94aa707da9539ca5266))

### Documentation improvements

- Minor formatting changes to proto headers ([commit 8213d4c](https://github.com/googleapis/google-cloud-dotnet/commit/8213d4ce0aec3f7a881da94aa707da9539ca5266))

## Version 3.7.0, released 2024-11-18

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.6.0, released 2024-03-28

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.5.0, released 2024-03-05

No API surface changes; just dependency updates.

## Version 3.4.0, released 2023-05-03

No API surface changes; just dependency updates.

## Version 3.3.0, released 2023-03-20

No API surface changes; just dependency updates.

## Version 3.2.0, released 2023-03-06

No API surface changes; just dependency updates.

## Version 3.1.0, released 2023-02-08

### Bug fixes

- Fix package API metadata for ContainerAnalysis ([commit db7de2a](https://github.com/googleapis/google-cloud-dotnet/commit/db7de2a0379d0530ef86b42383d39ae03e130ec3))

### New features

- Enable REST transport in C# ([commit 31e55cd](https://github.com/googleapis/google-cloud-dotnet/commit/31e55cdbafe12bfae68e28a75a1b75ceb445684f))

## Version 3.0.0, released 2022-06-09

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

## Version 2.4.0, released 2022-01-18

### Bug fixes

- Modify the bazel.BUILD file by hand to include the compliance protos which are not autogenerated ([commit b0a7017](https://github.com/googleapis/google-cloud-dotnet/commit/b0a7017a7cbde18bb043ca1e231528829341ff43))

## Version 2.3.0, released 2021-09-20

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-25

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-11-12

- [Commit fcf0dd6](https://github.com/googleapis/google-cloud-dotnet/commit/fcf0dd6): feat: add GetVulnerabilityOccurrencesSummary rpc.
- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-03-19

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-19

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0, released 2019-12-10

Initial GA release.
