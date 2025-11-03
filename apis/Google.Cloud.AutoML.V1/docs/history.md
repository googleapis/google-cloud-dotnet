# Version history

## Version 3.5.0, released 2025-11-03

### New features

- Update dependencies

### Documentation improvements

- Update io.proto to use markdown headings instead of HTML, remove some unused HTML from markdown

## Version 3.4.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.3.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.2.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 3.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 3.0.0, released 2022-06-08

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


## Version 2.6.0, released 2022-04-26

No API surface changes; just dependency updates.

## Version 2.5.0, released 2022-01-17

### Bug fixes

- Proto field markdown comment for the display_name field in annotation_payload.proto to point the correct public v1/ version ([commit c26a158](https://github.com/googleapis/google-cloud-dotnet/commit/c26a15832ac35576ec09cf8f54e18170443dd8bf))
- Add back java_multiple_files option to the text_sentiment.proto to match with the previous published version of text_sentiment proto ([commit c26a158](https://github.com/googleapis/google-cloud-dotnet/commit/c26a15832ac35576ec09cf8f54e18170443dd8bf))
- **BREAKING CHANGE** One of the fields now have field_behavior as REQUIRED in cloud/automl/v1 service definition. ([commit b1398f1](https://github.com/googleapis/google-cloud-dotnet/commit/b1398f19035a33d46b0574b486aaf6d80fe86b6e))

### New features

- Publish updated protos for cloud/automl/v1 service ([commit b1398f1](https://github.com/googleapis/google-cloud-dotnet/commit/b1398f19035a33d46b0574b486aaf6d80fe86b6e))

## Version 2.4.0, released 2021-12-07

- [Commit f182ed9](https://github.com/googleapis/google-cloud-dotnet/commit/f182ed9): docs: fix docstring formatting

## Version 2.3.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-25

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-10-07

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Regenerate all APIs with generator changes (fixes timeouts)
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 3e2a816](https://github.com/googleapis/google-cloud-dotnet/commit/3e2a816): docs: Remove raw html from proto comments as this breaks client library documentation generators.

In addition, dependencies have been updated.

## Version 2.0.0, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependencies
and implementation changes.

## Version 2.0.0-beta01, released 2020-03-05

This is the first prerelease targeting GAX v3. Please see the
[breaking changes guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0, released 2019-12-10

First GA release. No API surface changes since 1.0.0-beta03.

## Version 1.0.0-beta03, released 2019-11-07

- [Commit 1c275a8](https://github.com/googleapis/google-cloud-dotnet/commit/1c275a8): Removed ImageInputConfig
- [Commit fda30ff](https://github.com/googleapis/google-cloud-dotnet/commit/fda30ff): New RPCs, with supporting classes and properties:
  - GetAnnotationSpec
  - DeployModel
  - ExportModel
  - UndeployModel
  - BatchPredict

## Version 1.0.0-beta02, released 2019-10-08

- [Commit fb2b456](https://github.com/googleapis/google-cloud-dotnet/commit/fb2b456): Modifies long-running operations to give them response/metadata types

## Version 1.0.0-beta01, released 2019-09-24

- [Commit ba7dfdd](https://github.com/googleapis/google-cloud-dotnet/commit/ba7dfdd): First generation of AutoML

