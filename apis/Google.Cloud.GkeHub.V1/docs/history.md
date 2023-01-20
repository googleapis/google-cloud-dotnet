# Version history

## Version 2.1.0, released 2023-01-20

### New features

- Enable REST transport ([commit 46d4fe8](https://github.com/googleapis/google-cloud-dotnet/commit/46d4fe8461ac30e7666600e44e7bd16228768621))

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


## Version 1.2.0, released 2022-02-07

### New features

- Add `kubernetes_resource` field ([commit d03595e](https://github.com/googleapis/google-cloud-dotnet/commit/d03595ea86e200b93c35f761a358cbf6346ebbe2))

### Documentation improvements

- Update API annotation ([commit d03595e](https://github.com/googleapis/google-cloud-dotnet/commit/d03595ea86e200b93c35f761a358cbf6346ebbe2))

## Version 1.1.0, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-08-16

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2021-07-21

Initial release.
