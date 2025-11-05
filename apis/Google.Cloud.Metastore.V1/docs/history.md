# Version history

## Version 2.10.0, released 2025-11-05

### New features

- Update dependencies

## Version 2.9.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.8.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.7.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.6.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.5.0, released 2023-10-02

### New features

- Added EndpointLocation (v1, v1beta, v1alpha) ([commit 264ddbe](https://github.com/googleapis/google-cloud-dotnet/commit/264ddbe6cb6038cc68573ca7230a2e8446554490))

## Version 2.4.0, released 2023-07-13

### New features

- Added Admin Interface (v1) ([commit bbd1b88](https://github.com/googleapis/google-cloud-dotnet/commit/bbd1b8818823d9cec0994cc232b427f988cf291a))
- Added gRPC endpoint protocol (v1) ([commit bbd1b88](https://github.com/googleapis/google-cloud-dotnet/commit/bbd1b8818823d9cec0994cc232b427f988cf291a))
- Added BigQuery as a backend metastore (v1) ([commit bbd1b88](https://github.com/googleapis/google-cloud-dotnet/commit/bbd1b8818823d9cec0994cc232b427f988cf291a))

## Version 2.3.0, released 2023-04-19

### New features

- Added ScalingConfig (v1) ([commit d2e0f6c](https://github.com/googleapis/google-cloud-dotnet/commit/d2e0f6c8f53092c18b2d25bd9fc0e78fa29824d5))
- Added Auxiliary Versions Config (v1) ([commit d2e0f6c](https://github.com/googleapis/google-cloud-dotnet/commit/d2e0f6c8f53092c18b2d25bd9fc0e78fa29824d5))
- Added Dataplex and BQ metastore types for federation (v1alpa, v1beta) ([commit d2e0f6c](https://github.com/googleapis/google-cloud-dotnet/commit/d2e0f6c8f53092c18b2d25bd9fc0e78fa29824d5))

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
