# Version history

## Version 2.0.0-beta03, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 31e55cd](https://github.com/googleapis/google-cloud-dotnet/commit/31e55cdbafe12bfae68e28a75a1b75ceb445684f))

## Version 2.0.0-beta02, released 2022-11-10

### New features

- Introduce the event publishing using JSON representation of CloudEvents ([commit 9e59b13](https://github.com/googleapis/google-cloud-dotnet/commit/9e59b13261111da71197061589a8716f0fb4cd4d))

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

## Version 1.0.0-beta02, released 2022-04-21

### New features

- Add publishing methods for channel resources ([commit b5ef156](https://github.com/googleapis/google-cloud-dotnet/commit/b5ef156498297f70af0d736dbbe170ccb4a3365c))

## Version 1.0.0-beta01, released 2022-01-10

Initial release.
