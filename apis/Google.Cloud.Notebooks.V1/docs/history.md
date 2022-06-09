# Version history

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

## Version 1.0.0-beta04, released 2022-05-24

### Documentation improvements

- Modifies the project ID pattern in comment for Workbench environment ([commit 9f67d86](https://github.com/googleapis/google-cloud-dotnet/commit/9f67d8655c028fcde14849d480b53e3d26873caf))

## Version 1.0.0-beta03, released 2022-04-26

### New features

- Update Notebooks API for clients libraries ([commit bfb3a24](https://github.com/googleapis/google-cloud-dotnet/commit/bfb3a2492df98b5a42b9aceb1ea04c67dae043c3))

## Version 1.0.0-beta02, released 2021-12-07

- [Commit 2460a97](https://github.com/googleapis/google-cloud-dotnet/commit/2460a97):
  - docs: fix typos and docstring formatting
## Version 1.0.0-beta01, released 2021-10-11

Initial release.
