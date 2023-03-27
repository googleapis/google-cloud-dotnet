# Version history

## Version 2.3.0, released 2023-03-27

### New features

- Added supported for Cloud Deploy Progressive Deployment Strategy ([commit 1b6adf3](https://github.com/googleapis/google-cloud-dotnet/commit/1b6adf30328422af2ebbf0a20d9b583d845a4915))

### Deprecations

- TYPE_RENDER_STATUSES_CHANGE is deprecated, use RELEASE_RENDER log type instead ([commit 1b6adf3](https://github.com/googleapis/google-cloud-dotnet/commit/1b6adf30328422af2ebbf0a20d9b583d845a4915))

## Version 2.2.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 2.1.0, released 2022-10-03

### New features

- Publish new JobRun resource and associated methods for Google Cloud Deploy ([commit a8b0725](https://github.com/googleapis/google-cloud-dotnet/commit/a8b0725c866b5e0942c78646cb6eb690b81fb5c0))

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


## Version 1.1.0, released 2022-04-26

### New features

- Add support for Anthos worker pool. ([commit 456b719](https://github.com/googleapis/google-cloud-dotnet/commit/456b71950b4e34b14de76a63effd2fa5e5d92ff9))

### Documentation improvements

- Cloud Deploy API Platform Logging documentation ([commit 456b719](https://github.com/googleapis/google-cloud-dotnet/commit/456b71950b4e34b14de76a63effd2fa5e5d92ff9))

## Version 1.0.0, released 2022-01-25

No API surface changes; just dependency updates and promotion to 1.0.0.

## Version 1.0.0-beta02, released 2021-12-07

- [Commit 1c771ae](https://github.com/googleapis/google-cloud-dotnet/commit/1c771ae): docs: fix docstring formatting
## Version 1.0.0-beta01, released 2021-09-23

Initial release.
