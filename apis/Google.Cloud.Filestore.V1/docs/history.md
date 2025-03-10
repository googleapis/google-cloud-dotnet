# Version history

## Version 2.7.0, released 2025-03-10

### New features

- Added REGIONAL tier support in the v1 API ([commit d93c9d6](https://github.com/googleapis/google-cloud-dotnet/commit/d93c9d676313bb4087cbf1c635f13b9031de066c))

## Version 2.6.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.5.0, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 2.4.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.3.0, released 2023-12-04

### New features

- Added REGIONAL tier support in the v1 API ([commit e6cd7ec](https://github.com/googleapis/google-cloud-dotnet/commit/e6cd7ec6b26d49ce07b835ceca6b283cf55ec8ca))

## Version 2.2.0, released 2023-03-20

### New features

- Updating the client to match the latest v1 API ([commit 6db60e7](https://github.com/googleapis/google-cloud-dotnet/commit/6db60e7abeaee758b2783effe51c0e1ac81ad05a))

## Version 2.1.0, released 2023-01-17

### New features

- Enable REST transport in C# ([commit cdb518c](https://github.com/googleapis/google-cloud-dotnet/commit/cdb518c3524106ea73f0e546557a0180589ca3b0))

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

- [Commit 4ab10f4](https://github.com/googleapis/google-cloud-dotnet/commit/4ab10f4): fix(filestore): add missing operation_metadata.proto import

## Version 1.1.0, released 2021-09-23

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs
- [Commit a64eeae](https://github.com/googleapis/google-cloud-dotnet/commit/a64eeae): docs(filestore): Fix various formatting issues and broken links

## Version 1.0.0, released 2021-07-19

No API surface changes; just promotion to GA.

## Version 1.0.0-beta01, released 2021-06-25

Initial release.
