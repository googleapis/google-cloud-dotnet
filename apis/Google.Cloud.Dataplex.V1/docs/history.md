# Version history

## Version 2.0.0, released 2022-06-08

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


## Version 1.0.0, released 2022-03-14

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta02, released 2022-02-22

### New features

- New Content APIs ([commit 1ea3fe0](https://github.com/googleapis/google-cloud-dotnet/commit/1ea3fe02fc4352000e3ff9ad291268e963f89029))
- Create|Update|Delete Metadata APIs (e.g. Entity and/or Partition) ([commit 1ea3fe0](https://github.com/googleapis/google-cloud-dotnet/commit/1ea3fe02fc4352000e3ff9ad291268e963f89029))
## Version 1.0.0-beta01, released 2022-02-16

Initial release.
