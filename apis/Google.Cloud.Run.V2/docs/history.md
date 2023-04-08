# Version history

## Version 2.0.0, released 2023-03-27

No API surface changes; just dependency updates and initial GA release.

## Version 2.0.0-beta05, released 2023-01-20

### New features

- Adding support for encryption_key_revocation_action and encryption_key_shutdown_duration for RevisionTemplate and ExecutionTemplate ([commit 1ba9bc3](https://github.com/googleapis/google-cloud-dotnet/commit/1ba9bc37c06b483268f38acedd0e71f1f9d494f4))

### Documentation improvements

- Documentation improvements, including clarification that v1 labels/annotations are rejected in v2 API ([commit 1ba9bc3](https://github.com/googleapis/google-cloud-dotnet/commit/1ba9bc37c06b483268f38acedd0e71f1f9d494f4))

## Version 2.0.0-beta04, released 2023-01-18

### New features

- Enable REST transport in C# ([commit f9ccce7](https://github.com/googleapis/google-cloud-dotnet/commit/f9ccce7aa4e16a8049445724cf57e8e390c66bfc))

## Version 2.0.0-beta03, released 2022-11-10

### New features

- Adds gRPC probe support to Cloud Run v2 API client libraries ([commit e832ba9](https://github.com/googleapis/google-cloud-dotnet/commit/e832ba9d89b130ebc9be9f0344c272000b5060d0))
- Adds Cloud Run Jobs v2 API client libraries ([commit 85bc403](https://github.com/googleapis/google-cloud-dotnet/commit/85bc403b5b3336fc5aff49ab08b43d06626dfeef))

## Version 2.0.0-beta02, released 2022-10-17

### New features

- Adds Startup and Liveness probes to Cloud Run v2 API client libraries ([commit 79832b5](https://github.com/googleapis/google-cloud-dotnet/commit/79832b51d30d70ae16f1108a145141be7fd06816))

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

## Version 1.0.0-beta02, released 2022-05-11

### Bug fixes

- **BREAKING CHANGE** Updates pre-release Cloud Run v2 Preview client libraries to work with the latest API revision ([commit f438701](https://github.com/googleapis/google-cloud-dotnet/commit/f438701b1c7d1ebd9611522c597084daa1f85a7e))

## Version 1.0.0-beta01, released 2022-04-22

Initial release.
