# Version history

## Version 2.7.0, released 2025-04-23

### New features

- Adding new BackupChannel, RestoreChannel, BackupPlanBinding and RestorePlanBinding ([commit 0ae7a96](https://github.com/googleapis/google-cloud-dotnet/commit/0ae7a9678d9a731ecb4b2dd219f3b8bb05e9e97e))
- Generation of new cross project APIs ([commit 0ae7a96](https://github.com/googleapis/google-cloud-dotnet/commit/0ae7a9678d9a731ecb4b2dd219f3b8bb05e9e97e))
- Adding `last_successful_backup_time` field in BackupPlan ([commit 0ae7a96](https://github.com/googleapis/google-cloud-dotnet/commit/0ae7a9678d9a731ecb4b2dd219f3b8bb05e9e97e))
- Adding `VALIDATING` enum in state field of restore.proto ([commit 0ae7a96](https://github.com/googleapis/google-cloud-dotnet/commit/0ae7a9678d9a731ecb4b2dd219f3b8bb05e9e97e))
- Adding `CLEANED_UP` enum in state field of volume.proto ([commit 0ae7a96](https://github.com/googleapis/google-cloud-dotnet/commit/0ae7a9678d9a731ecb4b2dd219f3b8bb05e9e97e))

### Documentation improvements

- Minor documentation fixes ([commit 0ae7a96](https://github.com/googleapis/google-cloud-dotnet/commit/0ae7a9678d9a731ecb4b2dd219f3b8bb05e9e97e))

## Version 2.6.0, released 2024-06-04

### New features

- Add fine-grained restore ([commit 34adaa4](https://github.com/googleapis/google-cloud-dotnet/commit/34adaa426a01647954131fe89a383ae1d00c5b17))
- Add volume restore flexibility ([commit 34adaa4](https://github.com/googleapis/google-cloud-dotnet/commit/34adaa426a01647954131fe89a383ae1d00c5b17))
- Add restore order ([commit 34adaa4](https://github.com/googleapis/google-cloud-dotnet/commit/34adaa426a01647954131fe89a383ae1d00c5b17))
- Add strict-permissive mode ([commit 34adaa4](https://github.com/googleapis/google-cloud-dotnet/commit/34adaa426a01647954131fe89a383ae1d00c5b17))
- Add gitops ([commit 34adaa4](https://github.com/googleapis/google-cloud-dotnet/commit/34adaa426a01647954131fe89a383ae1d00c5b17))

### Documentation improvements

- Update duration comment to include new validation from smart scheduling ([commit 34adaa4](https://github.com/googleapis/google-cloud-dotnet/commit/34adaa426a01647954131fe89a383ae1d00c5b17))

## Version 2.5.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))
- Add smart scheduling ([commit 41a63ef](https://github.com/googleapis/google-cloud-dotnet/commit/41a63ef2d51dec24dd60ce04f2000841fe67245e))
- Add backup indexing ([commit 41a63ef](https://github.com/googleapis/google-cloud-dotnet/commit/41a63ef2d51dec24dd60ce04f2000841fe67245e))

### Documentation improvements

- Remove the next id annotation ([commit 41a63ef](https://github.com/googleapis/google-cloud-dotnet/commit/41a63ef2d51dec24dd60ce04f2000841fe67245e))
- Add output only and optional api field behavior label ([commit 41a63ef](https://github.com/googleapis/google-cloud-dotnet/commit/41a63ef2d51dec24dd60ce04f2000841fe67245e))
- Update retention policy and cron schedule comment to include new constraints from smart scheduling ([commit 41a63ef](https://github.com/googleapis/google-cloud-dotnet/commit/41a63ef2d51dec24dd60ce04f2000841fe67245e))

## Version 2.3.0, released 2024-02-28

### Documentation improvements

- Minor formatting ([commit 9498ba9](https://github.com/googleapis/google-cloud-dotnet/commit/9498ba98ecac1ebc1aa1fa0174aadd089d9f853c))

## Version 2.2.0, released 2023-06-27

### New features

- Added new restore scope options ([commit b606f4c](https://github.com/googleapis/google-cloud-dotnet/commit/b606f4c5293289554f5a035f3f8e0ce4c71ef3fe))
- Added transformation rules for restore ([commit b606f4c](https://github.com/googleapis/google-cloud-dotnet/commit/b606f4c5293289554f5a035f3f8e0ce4c71ef3fe))
- Added BackupPlan and RestorePlan state information ([commit b606f4c](https://github.com/googleapis/google-cloud-dotnet/commit/b606f4c5293289554f5a035f3f8e0ce4c71ef3fe))

### Documentation improvements

- Minor documentation fixes ([commit c78b468](https://github.com/googleapis/google-cloud-dotnet/commit/c78b46845ade4aafe6388159c5d12796fe150c77))

## Version 2.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 2.0.0, released 2022-11-02

No API surface changes; just dependency updates and promotion to general availability.

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

## Version 1.0.0-beta01, released 2022-05-17

Initial release.
