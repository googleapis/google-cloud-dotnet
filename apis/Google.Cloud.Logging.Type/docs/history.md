# Version history

## Version 4.3.0, released 2025-11-03

### New features

- Update dependencies

## Version 4.2.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 4.1.0, released 2024-02-28

### Documentation improvements

- Fix link to RFC 2616 ([commit 5868d25](https://github.com/googleapis/google-cloud-dotnet/commit/5868d2595a028cca59aa9bd5882e0389ead7eed5))

## Version 4.0.0, released 2022-06-08

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
## Version 3.5.0, released 2022-03-14

### New features

- KMS configuration in settings ([commit 07fd1d2](https://github.com/googleapis/google-cloud-dotnet/commit/07fd1d2571c192bdce5a4f1aa2f4caf53bfc3b41))

## Version 3.4.0, released 2022-02-22

### New features

- Update Logging API with latest changes ([commit b29bee2](https://github.com/googleapis/google-cloud-dotnet/commit/b29bee29cd0000c5d6aea64169dbe4866f74b17a))

## Version 3.3.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 3.2.0, released 2020-11-18

- [Commit 762ed1f](https://github.com/googleapis/google-cloud-dotnet/commit/762ed1f): docs: Updates to IP address comments

## Version 3.1.0, released 2020-10-20

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

## Version 3.0.0, released 2020-03-18

No API surface changes compared with 3.0.0-beta01, just dependency
and implementation changes.

## Version 3.0.0-beta01, released 2020-02-18

No significant changes since 2.1.0, other than depending on a new major version of Google.Api.CommonProtos.

## Version 2.1.0, released 2019-12-10

- Added HttpRequest.Protocol property

## Version 2.0.0, released 2017-06-22

Initial 2.0.0 release, with major dependency change.

## Version 1.0.0, released 2017-03-30

Initial GA release.
