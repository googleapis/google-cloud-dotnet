# Version history

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
