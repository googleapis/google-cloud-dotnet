# Version history

## Version 2.2.0, released 2023-01-20

### New features

- Enable REST transport ([commit 46d4fe8](https://github.com/googleapis/google-cloud-dotnet/commit/46d4fe8461ac30e7666600e44e7bd16228768621))

### Documentation improvements

- Marking keyword_searchable_job_custom_attributes on the company object as deprecated ([commit 30e9c09](https://github.com/googleapis/google-cloud-dotnet/commit/30e9c09203c5238c48dffcdc7742504428234bfe))
- Marking company_size histogram facet as deprecated ([commit 30e9c09](https://github.com/googleapis/google-cloud-dotnet/commit/30e9c09203c5238c48dffcdc7742504428234bfe))

## Version 2.1.0, released 2022-09-15

No API surface changes, just dependency updates.

(Two commits appeared to make changes, but these cancelled each
other out.)
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

### New features

- Add a new operator on companyDisplayNames filter to further support fuzzy match by treating input value as a multi word token ([commit 1de79aa](https://github.com/googleapis/google-cloud-dotnet/commit/1de79aa011a02033e0505a0adb6a38c683e82116))
- Add a new option TELECOMMUTE_JOBS_EXCLUDED under enum TelecommutePreference to completely filter out the telecommute jobs in response ([commit 1de79aa](https://github.com/googleapis/google-cloud-dotnet/commit/1de79aa011a02033e0505a0adb6a38c683e82116))

### Deprecations

- Deprecate option TELECOMMUTE_EXCLUDED under enum TelecommutePreference ([commit 1de79aa](https://github.com/googleapis/google-cloud-dotnet/commit/1de79aa011a02033e0505a0adb6a38c683e82116))

## Version 1.4.0, released 2022-04-26

### Documentation improvements

- Added functionality in the companyDisplayNames filter to support fuzzy matching ([commit 349a1e3](https://github.com/googleapis/google-cloud-dotnet/commit/349a1e3f81e7bd4fa3bfad4543889146523ac57a))

## Version 1.3.0, released 2021-12-07

- [Commit 10ebf7f](https://github.com/googleapis/google-cloud-dotnet/commit/10ebf7f): docs: fix docstring formatting
## Version 1.2.0, released 2021-09-23

- [Commit 87bf8a2](https://github.com/googleapis/google-cloud-dotnet/commit/87bf8a2):
  - feat: Added a new `KeywordMatchMode` field to support more keyword matching options
  - feat: Added more `DiversificationLevel` configuration options
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs
- [Commit 4dfd11f](https://github.com/googleapis/google-cloud-dotnet/commit/4dfd11f):
  - feat: Add new commute methods in Search APIs
  - feat: Add new histogram type 'publish_time_in_day'
  - feat: Support filtering by requisitionId is ListJobs API

## Version 1.1.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 1.0.0, released 2021-01-20

No API changes since 1.0.0-beta02.

## Version 1.0.0-beta02, released 2020-10-01

- [Commit f4c1f60](https://github.com/googleapis/google-cloud-dotnet/commit/f4c1f60): fix!: removed Cycling and Walking elements from CommuteMethod enum
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

Please note the breaking change of removing CommuteMethod.Cycling and CommuteMethod.Walking. (No major version bump as the library is still in beta.)

## Version 1.0.0-beta01, released 2020-09-15

First beta release of GA v4 API.


