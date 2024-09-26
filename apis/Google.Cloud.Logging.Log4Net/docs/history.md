# Version history

## Version 4.4.0, released 2024-09-26

### New features

- Update log4net dependency. ([commit 0ab782a](https://github.com/googleapis/google-cloud-dotnet/commit/0ab782a2c14733e86fcdf9854465000ba0ed01c6))

## Version 4.3.0, released 2024-03-28

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit cba7759](https://github.com/googleapis/google-cloud-dotnet/commit/cba77591907c4a4594a184466534ee9e258bb5ef))

## Version 4.2.0, released 2024-03-13

No API surface changes; just dependency updates.

## Version 4.1.0, released 2023-09-25

### Bug fixes

- Make Log4Net type searching more robust ([commit 3a9cf53](https://github.com/googleapis/google-cloud-dotnet/commit/3a9cf538123553707bf7e49b82d8887102254c5c))

## Version 4.0.0, released 2022-06-09

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


## Version 3.3.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 3.2.0, released 2020-11-19

No API surface changes, but this release updates dependencies.

## Version 3.1.0, released 2020-04-16

- [Commit 51d65fa](https://github.com/googleapis/google-cloud-dotnet/commit/51d65fa): Feature: Allow GoogleStackdriverAppender to be configured to create JSON payloads
  - User code needs to implement a new IJsonLayout interface, and configure the appender appropriately.
  - Fixes [issue 4845](https://github.com/googleapis/google-cloud-dotnet/issues/4845).

## Version 3.0.0, released 2020-03-18

No API surface changes compared with 3.0.0-beta01, just dependency
and implementation changes.

## Version 3.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2) for details of changes to both GAX and code generation.

This package has not taken any direct breaking changes, but has a major version number change due to its dependencies.

## Version 2.5.0, released 2019-12-10

No API surface change - just dependency updates.

## Version 2.4.0, released 2019-07-10

No API surface change - just dependency updates.

## Version 2.4.0-beta01, released 2019-06-10

- [Commit 5c43b1a](https://github.com/googleapis/google-cloud-dotnet/commit/5c43b1a): Pattern Conversions in Log4Net custom labels ([issue 3103](https://github.com/googleapis/google-cloud-dotnet/issues/3103))

## Version 2.3.0, released 2019-02-26

- [Commit b36872c](https://github.com/googleapis/google-cloud-dotnet/commit/b36872c): Support JSON credentials ([issue 2322](https://github.com/googleapis/google-cloud-dotnet/issues/2322)). Fixes [issue 2314](https://github.com/googleapis/google-cloud-dotnet/issues/2314)

## Version 2.2.1, released 2018-03-06

- [Commit f6bfe3e](https://github.com/googleapis/google-cloud-dotnet/commit/f6bfe3e): Add flushing to log4net, and improve snippet ([issue 1951](https://github.com/googleapis/google-cloud-dotnet/issues/1951)). Fixes [issue 1926](https://github.com/googleapis/google-cloud-dotnet/issues/1926)

## Version 2.2.0, released 2017-11-23

- [Commit a7dbff3](https://github.com/googleapis/google-cloud-dotnet/commit/a7dbff3): Added the ability to configure credentials using a JSON file ([issue 1424](https://github.com/googleapis/google-cloud-dotnet/issues/1424))

## Version 2.1.0, released 2017-08-02

No API surface change - just dependency updates.

## Version 2.0.0, released 2017-06-28

First GA release. (1.0.0 was never released.)
