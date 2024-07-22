# Version history

## Version 2.9.0, released 2024-07-22

### New features

- Support update_mask in Cloud Run UpdateService ([commit bb34cc0](https://github.com/googleapis/google-cloud-dotnet/commit/bb34cc0531c91e8f2468ad6833da92fcff735936))
- Add Job start_execution_token and run_execution_token to execute jobs immediately on creation ([commit bb34cc0](https://github.com/googleapis/google-cloud-dotnet/commit/bb34cc0531c91e8f2468ad6833da92fcff735936))
- Add Job ExecutionReference.completion_status to show status of the most recent execution ([commit bb34cc0](https://github.com/googleapis/google-cloud-dotnet/commit/bb34cc0531c91e8f2468ad6833da92fcff735936))

### Documentation improvements

- Clarify optional fields in Cloud Run requests ([commit bb34cc0](https://github.com/googleapis/google-cloud-dotnet/commit/bb34cc0531c91e8f2468ad6833da92fcff735936))

## Version 2.8.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.7.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.6.0, released 2024-03-05

### New features

- Support mounting NFS and GCS volumes in Cloud Run Jobs and Services ([commit e85fcd7](https://github.com/googleapis/google-cloud-dotnet/commit/e85fcd750c48d20b360e2cb8a4cd9bbc2eb821b8))
- Support specifying a per-Service min-instance-count ([commit e85fcd7](https://github.com/googleapis/google-cloud-dotnet/commit/e85fcd750c48d20b360e2cb8a4cd9bbc2eb821b8))
- Support disabling waiting for health checks during Service deployment. ([commit e85fcd7](https://github.com/googleapis/google-cloud-dotnet/commit/e85fcd750c48d20b360e2cb8a4cd9bbc2eb821b8))
- Allow disabling the default URL (run.app) for Cloud Run Services ([commit e85fcd7](https://github.com/googleapis/google-cloud-dotnet/commit/e85fcd750c48d20b360e2cb8a4cd9bbc2eb821b8))

### Documentation improvements

- Clarify some defaults and required or optional values ([commit e85fcd7](https://github.com/googleapis/google-cloud-dotnet/commit/e85fcd750c48d20b360e2cb8a4cd9bbc2eb821b8))

## Version 2.5.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 2.4.0, released 2023-09-28

BREAKING CHANGE: The removal of the TrafficTagsCleanupThreshold
(introduced in 2.3.0 accidentally) is clearly a breaking change, but
we hope we've released this update quickly enough to avoid any
customers actually being affected. We believe that using a minor
version is less disruptive to customers than using a major version
bump in this particular case. We apologize for any inconvenience.

### Bug fixes

- Removes accidentally exposed field service.traffic_tags_cleanup_threshold in Cloud Run Service ([commit 6b18d1f](https://github.com/googleapis/google-cloud-dotnet/commit/6b18d1fdef57b8e2087a8a5e013e3a59bd4a7c94))

### Documentation improvements

- Minor comment fixes ([commit 6b18d1f](https://github.com/googleapis/google-cloud-dotnet/commit/6b18d1fdef57b8e2087a8a5e013e3a59bd4a7c94))

## Version 2.3.0, released 2023-09-26

### New features

- Adds support for cancel Execution ([commit 887dc16](https://github.com/googleapis/google-cloud-dotnet/commit/887dc168d55116c4969e7e7b66c5df9063b8a19a))
- Adds support for Execution overrides ([commit 887dc16](https://github.com/googleapis/google-cloud-dotnet/commit/887dc168d55116c4969e7e7b66c5df9063b8a19a))
- Adds support for Direct VPC egress setting ([commit 887dc16](https://github.com/googleapis/google-cloud-dotnet/commit/887dc168d55116c4969e7e7b66c5df9063b8a19a))
- New fields for multi-container ([commit 887dc16](https://github.com/googleapis/google-cloud-dotnet/commit/887dc168d55116c4969e7e7b66c5df9063b8a19a))
- New field for Task's scheduled timestamp ([commit 887dc16](https://github.com/googleapis/google-cloud-dotnet/commit/887dc168d55116c4969e7e7b66c5df9063b8a19a))

### Documentation improvements

- General documentation fixes. ([commit 887dc16](https://github.com/googleapis/google-cloud-dotnet/commit/887dc168d55116c4969e7e7b66c5df9063b8a19a))

## Version 2.2.0, released 2023-07-13

### New features

- Adds support for custom audiences ([commit 5233add](https://github.com/googleapis/google-cloud-dotnet/commit/5233add1e8fb5a8ab6bb5324ac830e4926373357))

## Version 2.1.0, released 2023-05-03

### New features

- Adds support for Startup CPU Boost (GA) ([commit 32b5017](https://github.com/googleapis/google-cloud-dotnet/commit/32b5017e4f86393961797f15d84b0d5206e58daf))
- Adds support for Session affinity in Service (GA) ([commit 32b5017](https://github.com/googleapis/google-cloud-dotnet/commit/32b5017e4f86393961797f15d84b0d5206e58daf))
- New 'port' field for HttpGetAction probe type ([commit 32b5017](https://github.com/googleapis/google-cloud-dotnet/commit/32b5017e4f86393961797f15d84b0d5206e58daf))
- New fields/enum values ([commit 32b5017](https://github.com/googleapis/google-cloud-dotnet/commit/32b5017e4f86393961797f15d84b0d5206e58daf))

### Documentation improvements

- General documentation fixes. ([commit 32b5017](https://github.com/googleapis/google-cloud-dotnet/commit/32b5017e4f86393961797f15d84b0d5206e58daf))

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
