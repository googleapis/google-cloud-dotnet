# Version history

## Version 2.0.0-beta12, released 2025-11-05

### New features

- Update dependencies

## Version 2.0.0-beta11, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.0.0-beta10, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-beta09, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-beta08, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.0.0-beta07, released 2023-10-02

### New features

- Added EndpointLocation (v1, v1beta, v1alpha) ([commit fe44771](https://github.com/googleapis/google-cloud-dotnet/commit/fe44771fd325b3e63ba63cbf518d4dfc362ceecc))

## Version 2.0.0-beta06, released 2023-07-13

### New features

- Added Admin Interface (v1) ([commit 699426c](https://github.com/googleapis/google-cloud-dotnet/commit/699426cc14735db516958999cf02588aa7e2e40c))
- Added gRPC endpoint protocol (v1) ([commit 699426c](https://github.com/googleapis/google-cloud-dotnet/commit/699426cc14735db516958999cf02588aa7e2e40c))
- Added BigQuery as a backend metastore (v1) ([commit 699426c](https://github.com/googleapis/google-cloud-dotnet/commit/699426cc14735db516958999cf02588aa7e2e40c))

## Version 2.0.0-beta05, released 2023-04-19

### New features

- Added ScalingConfig (v1) ([commit ca0d304](https://github.com/googleapis/google-cloud-dotnet/commit/ca0d3042ca823b64105b27b3cbd72b4f095825e0))
- Added Auxiliary Versions Config (v1) ([commit ca0d304](https://github.com/googleapis/google-cloud-dotnet/commit/ca0d3042ca823b64105b27b3cbd72b4f095825e0))
- Added Dataplex and BQ metastore types for federation (v1alpa, v1beta) ([commit ca0d304](https://github.com/googleapis/google-cloud-dotnet/commit/ca0d3042ca823b64105b27b3cbd72b4f095825e0))

## Version 2.0.0-beta04, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

## Version 2.0.0-beta03, released 2023-01-16

### New features

- Added RemoveIamPolicy API ([commit d87bbd9](https://github.com/googleapis/google-cloud-dotnet/commit/d87bbd98854765b5fe797745a308b7a795ca7fda))
- Added QueryMetadata API ([commit d87bbd9](https://github.com/googleapis/google-cloud-dotnet/commit/d87bbd98854765b5fe797745a308b7a795ca7fda))
- Added MoveTableToDatabase API ([commit d87bbd9](https://github.com/googleapis/google-cloud-dotnet/commit/d87bbd98854765b5fe797745a308b7a795ca7fda))
- Added AlterMetadataResourceLocation API ([commit d87bbd9](https://github.com/googleapis/google-cloud-dotnet/commit/d87bbd98854765b5fe797745a308b7a795ca7fda))

### Documentation improvements

- Fix formatting for subnetwork field pattern ([commit b86e735](https://github.com/googleapis/google-cloud-dotnet/commit/b86e73590f171a4656f4ffca9fda332b50c3315c))

## Version 2.0.0-beta02, released 2022-12-01

### New features

- Added federation API ([commit a361045](https://github.com/googleapis/google-cloud-dotnet/commit/a361045b4e61362de9e580d870803b297dc8f9e1))
- Added EncryptionConfig field ([commit a361045](https://github.com/googleapis/google-cloud-dotnet/commit/a361045b4e61362de9e580d870803b297dc8f9e1))
- Added NetworkConfig field ([commit a361045](https://github.com/googleapis/google-cloud-dotnet/commit/a361045b4e61362de9e580d870803b297dc8f9e1))
- Added DatabaseType field ([commit a361045](https://github.com/googleapis/google-cloud-dotnet/commit/a361045b4e61362de9e580d870803b297dc8f9e1))
- Added TelemetryConfiguration field ([commit a361045](https://github.com/googleapis/google-cloud-dotnet/commit/a361045b4e61362de9e580d870803b297dc8f9e1))

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


## Version 1.0.0-beta02, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta01, released 2021-03-10

Initial release.
