# Version history

## Version 3.0.0-beta06, released 2025-01-06

### New features

- A new enum `RelevanceThreshold` is added ([commit d704518](https://github.com/googleapis/google-cloud-dotnet/commit/d70451883734a3c0675a9d646074011da7b0bf5f))
- A new field `relevance_threshold` is added to message `.google.cloud.talent.v4beta1.SearchJobsRequest` ([commit d704518](https://github.com/googleapis/google-cloud-dotnet/commit/d70451883734a3c0675a9d646074011da7b0bf5f))

## Version 3.0.0-beta05, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.0.0-beta04, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.0.0-beta03, released 2024-02-29

No API surface changes; just dependency updates.

## Version 3.0.0-beta02, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 6ce3faf](https://github.com/googleapis/google-cloud-dotnet/commit/6ce3faf6f74ea6c63e14ee4c77627a6774fb807f))

### Documentation improvements

- Marking keyword_searchable_job_custom_attributes on the company object as deprecated ([commit b8dc192](https://github.com/googleapis/google-cloud-dotnet/commit/b8dc1922c3c190d26afc1fa2f1ac33424a49ecbd))
- Marking company_size histogram facet as deprecated ([commit b8dc192](https://github.com/googleapis/google-cloud-dotnet/commit/b8dc1922c3c190d26afc1fa2f1ac33424a49ecbd))

## Version 3.0.0-beta01, released 2022-06-08

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

### API specific breaking changes

- Remove Application and Profile services and and related protos, enums, and messages ([commit affecf6](https://github.com/googleapis/google-cloud-dotnet/commit/affecf654fe6114347f1effd7fda46bb584d737b))

## Version 2.0.0-beta07, released 2021-12-07

- [Commit 54f0341](https://github.com/googleapis/google-cloud-dotnet/commit/54f0341): docs: fix docstring formatting
## Version 2.0.0-beta06, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.0.0-beta05, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.0.0-beta04, released 2020-11-18

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 8381822](https://github.com/googleapis/google-cloud-dotnet/commit/8381822): docs: Remove a broken link from the documentation.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0-beta03, released 2020-04-14

- [Commit 28bdca8](https://github.com/googleapis/google-cloud-dotnet/commit/28bdca8): Fix (breaking change): reorder Company and Job resources in talent API to be consistent with old gapic config.

Note that this breaking change was expected, and was performed to
improve the experience moving forward. (As part of a beta API,
periodic breaking changes are somewhat expected.)

## Version 2.0.0-beta02, released 2020-03-19

- [Commit aadcdb6](https://github.com/googleapis/google-cloud-dotnet/commit/aadcdb6): This removes the TenantOrProject resource, so is a breaking change. This "fake" resource predates the ability to refer to multiple parent resources.

The mitigation for the breaking change is typically just to replace
uses of `TenantOrProjectName` with `TenantName` or `ProjectName`.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

(This API has changed significantly over time, and the history before this point is tricky to backfill.)

## Version 1.0.0-beta09, released 2019-12-10

## Version 1.0.0-beta08, released 2019-11-11

## Version 1.0.0-beta07, released 2019-09-17

## Version 1.0.0-beta06, released 2019-07-30

## Version 1.0.0-beta05, released 2019-06-05

## Version 1.0.0-beta04, released 2019-05-01

## Version 1.0.0-beta03, released 2019-04-03

## Version 1.0.0-beta02, released 2019-02-26

## Version 1.0.0-beta01, released 2019-02-20

Initial beta release.
