# Version history

## Version 3.3.0, released 2025-11-03

### New features

- Update dependencies

## Version 3.2.0, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.1.1, released 2024-02-29

Purely a release-process patch, re-releasing 3.1.0 which failed to
release.

## Version 3.1.0, released 2024-02-28

No API surface changes; just dependency updates.

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
## Version 2.1.0, released 2021-05-25

No API surface changes; just dependency updates.

## Version 2.0.0, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-18

No significant changes since 1.1.0, other than depending on a new major version of Google.Api.CommonProtos.

## Version 1.1.0, released 2019-12-09

- [Commit 518728a](https://github.com/googleapis/google-cloud-dotnet/commit/518728a): A few minor tidy-ups of comments
- Dependency updates

## Version 1.0.0, released 2017-08-01

Initial GA release.
