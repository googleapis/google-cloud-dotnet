# Version history

## Version 2.0.0-beta06, released 2025-11-06

### New features

- Update dependencies

### Documentation improvements

- A comment for field `revision_id` in message `.google.cloud.workflows.v1beta.Workflow` is changed
- A comment for field `service_account` in message `.google.cloud.workflows.v1beta.Workflow` is changed
- A comment for field `source_contents` in message `.google.cloud.workflows.v1beta.Workflow` is changed

## Version 2.0.0-beta05, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-beta04, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 2.0.0-beta03, released 2024-02-29

No API surface changes; just dependency updates.

## Version 2.0.0-beta02, released 2023-02-08

### New features

- Enable REST transport ([commit 46d4fe8](https://github.com/googleapis/google-cloud-dotnet/commit/46d4fe8461ac30e7666600e44e7bd16228768621))

## Version 2.0.0-beta01, released 2022-06-09

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

## Version 1.0.0-beta03, released 2021-09-20

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta02, released 2021-05-26

No API surface changes; just dependency updates.

## Version 1.0.0-beta01, released 2020-10-14

Initial beta release.
