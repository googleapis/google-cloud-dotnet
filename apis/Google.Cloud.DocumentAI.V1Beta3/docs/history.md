# Version history

## Version 2.0.0-beta01, released 2022-06-08

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

### API-specific breaking changes

- Mark Document.Entity.type as REQUIRED in all versions ([commit 0dcc4ad](https://github.com/googleapis/google-cloud-dotnet/commit/0dcc4ade7a1acb57efbfcfb03c6972c6bae60ee5))
- Remove Document.Entity.bounding_poly_for_demo_frontend from v1beta2 ([commit 0dcc4ad](https://github.com/googleapis/google-cloud-dotnet/commit/0dcc4ade7a1acb57efbfcfb03c6972c6bae60ee5))
## Version 1.0.0-beta04, released 2022-02-22

### New features

- Add `symbols` field, and auto-format comments ([commit 6387c47](https://github.com/googleapis/google-cloud-dotnet/commit/6387c47557b17044e11e01da8f23889373b26490))

## Version 1.0.0-beta03, released 2022-02-07

### New features

- Add question_id field in ReviewDocumentOperationMetadata ([commit 5ecd61e](https://github.com/googleapis/google-cloud-dotnet/commit/5ecd61efcb1a538591d9bbeed33e14c750e82d17))

## Version 1.0.0-beta02, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta01, released 2021-06-16

Initial release.
