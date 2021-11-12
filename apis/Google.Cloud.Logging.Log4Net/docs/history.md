# Version history

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

This is the first prerelease targeting GAX v3. Please see the [breaking changes guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html) for details of changes to both GAX and code generation.

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
