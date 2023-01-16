# Version history

## Version 2.2.0, released 2023-01-16

### New features

- Enable REST transport in C# ([commit a6c4606](https://github.com/googleapis/google-cloud-dotnet/commit/a6c46063bd961a9dadc728a780d66de772f28e71))

### Documentation improvements

- Fix formatting for subnetwork field pattern ([commit a8ef93b](https://github.com/googleapis/google-cloud-dotnet/commit/a8ef93b5bdd4fba20274b4ec2ae004509cc25741))

## Version 2.1.0, released 2022-12-01

### New features

- Added federation API ([commit 31c802d](https://github.com/googleapis/google-cloud-dotnet/commit/31c802d35e428ca28039f9af3f2aca4398b2517b))
- Added EncryptionConfig field ([commit 31c802d](https://github.com/googleapis/google-cloud-dotnet/commit/31c802d35e428ca28039f9af3f2aca4398b2517b))
- Added NetworkConfig field ([commit 31c802d](https://github.com/googleapis/google-cloud-dotnet/commit/31c802d35e428ca28039f9af3f2aca4398b2517b))
- Added DatabaseType field ([commit 31c802d](https://github.com/googleapis/google-cloud-dotnet/commit/31c802d35e428ca28039f9af3f2aca4398b2517b))
- Added TelemetryConfiguration field ([commit 31c802d](https://github.com/googleapis/google-cloud-dotnet/commit/31c802d35e428ca28039f9af3f2aca4398b2517b))

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


## Version 1.1.0, released 2021-09-23

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs
- [Commit 95dd8f3](https://github.com/googleapis/google-cloud-dotnet/commit/95dd8f3):
  - feat: Added the Backup resource and Backup resource GetIamPolicy/SetIamPolicy to V1
  - feat: Added the RestoreService method to V1
  - Promoted additional Dataproc Metastore metadata management methods to V1

## Version 1.0.0, released 2021-06-08

No API surface changes; just promoting to GA.

## Version 1.0.0-beta02, released 2021-05-05

No API surface changes; just dependency updates.

## Version 1.0.0-beta01, released 2021-04-01

Initial release.
