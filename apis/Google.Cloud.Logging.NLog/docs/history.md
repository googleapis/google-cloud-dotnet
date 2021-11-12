# Version history

## Version 3.3.0, released 2021-03-22

- [Commit 9ed450c](https://github.com/googleapis/google-cloud-dotnet/commit/9ed450c): refactor: Extract RenderJsonPayload from BuildLogEntry in GoogleStackdriverTarget
- [Commit f553511](https://github.com/googleapis/google-cloud-dotnet/commit/f553511): docs: Add documentation for trace related config options in GoogleStackdriverTarget
- [Commit d94c27b](https://github.com/googleapis/google-cloud-dotnet/commit/d94c27b): docs: Clarify XML doc for GoogleStackdriverTarget trace related options
- [Commit 0da1f45](https://github.com/googleapis/google-cloud-dotnet/commit/0da1f45): test: Add more unit tests around log and trace correlation
- Commits [a106579](https://github.com/googleapis/google-cloud-dotnet/commit/a106579) and [858f161](https://github.com/googleapis/google-cloud-dotnet/commit/858f161): feat: Add support for trace information to be included with log entries

## Version 3.2.0, released 2020-12-07

- [Commit a0f7730](https://github.com/googleapis/google-cloud-dotnet/commit/a0f7730): docs: Move NLog configuration into docs directory and expand it
- [Commit 932a8d1](https://github.com/googleapis/google-cloud-dotnet/commit/932a8d1): feat: Adds EnableJsonLayout option to use custom jsonLayout

## Version 3.1.0, released 2020-11-19

- [Commit cbaa00a](https://github.com/googleapis/google-cloud-dotnet/commit/cbaa00a): Renormalize line endings
- [Commit 02e2ddc](https://github.com/googleapis/google-cloud-dotnet/commit/02e2ddc): NLog GoogleStackDriverTarget skip reflection on Stream-objects ([issue 5230](https://github.com/googleapis/google-cloud-dotnet/issues/5230))
- [Commit 0e6d135](https://github.com/googleapis/google-cloud-dotnet/commit/0e6d135): NLog GoogleStackdriverTarget improve handling of System.Reflection (MemberInfo is better than MethodInfo)

## Version 3.0.1, released 2020-04-20

- [Commit ced67e4](https://github.com/googleapis/google-cloud-dotnet/commit/ced67e4): Fix: Improve handling of System.Reflection objects that will dump all types in the application-assembly.

## Version 3.0.0, released 2020-03-18

No API surface changes compared with 3.0.0-beta02, just dependency
changes.

## Version 3.0.0-beta02, released 2020-03-10

- [Commit 528388f](https://github.com/googleapis/google-cloud-dotnet/commit/528388f): Configured Project ID takes precedence over Project ID of project in which the code is running for using as log writing target.

## Version 3.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

This package has not taken any direct breaking changes, but has a major version number change due to its dependencies.

## Version 2.2.0, released 2019-12-10

- [Commit e708f35](https://github.com/googleapis/google-cloud-dotnet/commit/e708f35): Improve handling of dangerous object properties that throws exceptions during Json.Net serialization. ([issue 3668](https://github.com/googleapis/google-cloud-dotnet/issues/3668))

## Version 2.1.0, released 2019-07-10

- [Commit 4cb5765](https://github.com/googleapis/google-cloud-dotnet/commit/4cb5765): Include ServiceContext to allow errors to be forwarded (docs) ([issue 3125](https://github.com/googleapis/google-cloud-dotnet/issues/3125))
- [Commit dac0dbd](https://github.com/googleapis/google-cloud-dotnet/commit/dac0dbd): Include ServiceContext to allow errors to be forwarded ([issue 3115](https://github.com/googleapis/google-cloud-dotnet/issues/3115))
- [Commit d007553](https://github.com/googleapis/google-cloud-dotnet/commit/d007553): Avoid InvalidCastException for custom IConvertible that returns TypeCode.Boolean ([issue 3088](https://github.com/googleapis/google-cloud-dotnet/issues/3088))

## Version 2.0.0, released 2019-02-26

Initial GA release.
