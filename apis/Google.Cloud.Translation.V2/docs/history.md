# Version history

## Version 3.5.0, released 2025-11-06

### New features

- Update dependencies

## Version 3.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.3.0, released 2024-03-06

No API surface changes; just dependency updates.

## Version 3.2.0, released 2023-03-27

No API surface changes; just dependency updates and a GA release for self-signed JWTs.

## Version 3.2.0-beta01, released 2023-01-16

### New features

- Enable self-signed JWTs for Storage and Translation clients ([commit 10d2787](https://github.com/googleapis/google-cloud-dotnet/commit/10d2787c9963b49199ffdf8d4ed69169142272fb))

## Version 3.1.0, released 2022-07-25

## New features

- Added parameterless Create/CreateAsync factory methods for the
  clients, in preparation for potentially deprecating the methods
  accepting `GoogleCredential`. The builder classes now form
  the recommended way of customizing clients.

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
## Version 2.1.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.0.0, released 2020-03-19

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-19

This is the first prerelease targeting GAX v3. The immediate API
surface hasn't changed from 1.2.0, but there can still be transitive
breaking changes via the dependencies. Please see the [breaking
changes guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes for GAX, noting that gRPC-specific changes
are irrelevant to this package.

## Version 1.2.0, released 2019-12-09

- [Commit 5c5afff](https://github.com/googleapis/google-cloud-dotnet/commit/5c5afff): Added client builders for simplified configuration
- [Commit 4c1905b](https://github.com/googleapis/google-cloud-dotnet/commit/4c1905b): Use Translate method instead of List method, to avoid URI construction limits. Fixes [issue 2957](https://github.com/googleapis/google-cloud-dotnet/issues/2957) as far as we can.

## Version 1.1.0, released 2018-08-07

- [Commit 9f2bde3](https://github.com/googleapis/google-cloud-dotnet/commit/9f2bde3): Implement IDisposable on clients ([issue 1624](https://github.com/googleapis/google-cloud-dotnet/issues/1624)). Fixes [issue 407](https://github.com/googleapis/google-cloud-dotnet/issues/407)
- [Commit 1630044](https://github.com/googleapis/google-cloud-dotnet/commit/1630044): Cleanup default expressions ([issue 1388](https://github.com/googleapis/google-cloud-dotnet/issues/1388))
- [Commit 048afaa](https://github.com/googleapis/google-cloud-dotnet/commit/048afaa): Add AdvancedTranslationClient for custom model scenarios
- [Commit bcf665c](https://github.com/googleapis/google-cloud-dotnet/commit/bcf665c): Fix the TranslationResult.Model property not being populated.

## Version 1.0.0, released 2017-06-28

Initial GA release.
