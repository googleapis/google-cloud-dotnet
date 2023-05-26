# Version history

## Version 2.1.0, released 2023-05-26

### New features

- Add Oracle to PostgreSQL migration APIs ([commit fcf9391](https://github.com/googleapis/google-cloud-dotnet/commit/fcf93912233be05f0f170eb3472ca3a23f8d0815))

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


## Version 1.2.0, released 2021-10-12

- [Commit 8e7d0f8](https://github.com/googleapis/google-cloud-dotnet/commit/8e7d0f8): docs: Fix NOT_STARTED state documentation in MigrationJob resource

## Version 1.1.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-06-16

- [Commit 5be25f6](https://github.com/googleapis/google-cloud-dotnet/commit/5be25f6): docs: update link in comments

Other than the comment change shown above, this is just a dependency
update and promotion to GA.

## Version 1.0.0-beta01, released 2021-05-11

Initial release.
