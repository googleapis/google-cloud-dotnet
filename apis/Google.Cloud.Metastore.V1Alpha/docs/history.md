# Version history

## Version 2.0.0-alpha12, released 2025-11-05

### New features

- Update dependencies

## Version 2.0.0-alpha11, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.0.0-alpha10, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-alpha09, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-alpha08, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.0.0-alpha07, released 2023-10-02

### New features

- Added EndpointLocation (v1, v1beta, v1alpha) ([commit 65fb54b](https://github.com/googleapis/google-cloud-dotnet/commit/65fb54b33ba9641ad02457b035df5a397f4dbaee))

## Version 2.0.0-alpha06, released 2023-07-13

### New features

- Added Admin Interface (v1) ([commit a162298](https://github.com/googleapis/google-cloud-dotnet/commit/a162298c75f8de10922c8f881c1783479b32a2cb))
- Added gRPC endpoint protocol (v1) ([commit a162298](https://github.com/googleapis/google-cloud-dotnet/commit/a162298c75f8de10922c8f881c1783479b32a2cb))
- Added BigQuery as a backend metastore (v1) ([commit a162298](https://github.com/googleapis/google-cloud-dotnet/commit/a162298c75f8de10922c8f881c1783479b32a2cb))

## Version 2.0.0-alpha05, released 2023-04-19

### New features

- Added ScalingConfig (v1) ([commit c10f31b](https://github.com/googleapis/google-cloud-dotnet/commit/c10f31b98522c71db743117dab653063f7396132))
- Added Auxiliary Versions Config (v1) ([commit c10f31b](https://github.com/googleapis/google-cloud-dotnet/commit/c10f31b98522c71db743117dab653063f7396132))
- Added Dataplex and BQ metastore types for federation (v1alpa, v1beta) ([commit c10f31b](https://github.com/googleapis/google-cloud-dotnet/commit/c10f31b98522c71db743117dab653063f7396132))

## Version 2.0.0-alpha04, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

## Version 2.0.0-alpha03, released 2023-01-16

### New features

- Added RemoveIamPolicy API ([commit 7844ed8](https://github.com/googleapis/google-cloud-dotnet/commit/7844ed8ed245c704f85d9de72423e8eb6d761a1f))
- Added QueryMetadata API ([commit 7844ed8](https://github.com/googleapis/google-cloud-dotnet/commit/7844ed8ed245c704f85d9de72423e8eb6d761a1f))
- Added MoveTableToDatabase API ([commit 7844ed8](https://github.com/googleapis/google-cloud-dotnet/commit/7844ed8ed245c704f85d9de72423e8eb6d761a1f))
- Added AlterMetadataResourceLocation API ([commit 7844ed8](https://github.com/googleapis/google-cloud-dotnet/commit/7844ed8ed245c704f85d9de72423e8eb6d761a1f))

## Version 2.0.0-alpha02, released 2022-12-01

### New features

- Added federation API ([commit 08fe5f7](https://github.com/googleapis/google-cloud-dotnet/commit/08fe5f76045f0a237bc23f1f0d54639e7fd150c3))
- Added EncryptionConfig field ([commit 08fe5f7](https://github.com/googleapis/google-cloud-dotnet/commit/08fe5f76045f0a237bc23f1f0d54639e7fd150c3))
- Added NetworkConfig field ([commit 08fe5f7](https://github.com/googleapis/google-cloud-dotnet/commit/08fe5f76045f0a237bc23f1f0d54639e7fd150c3))
- Added DatabaseType field ([commit 08fe5f7](https://github.com/googleapis/google-cloud-dotnet/commit/08fe5f76045f0a237bc23f1f0d54639e7fd150c3))
- Added TelemetryConfiguration field ([commit 08fe5f7](https://github.com/googleapis/google-cloud-dotnet/commit/08fe5f76045f0a237bc23f1f0d54639e7fd150c3))

## Version 2.0.0-alpha01, released 2022-06-08

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


## Version 1.0.0-alpha04, released 2022-04-04

### New features

- Added DatabaseType field for the type of backing store used ([commit 0bce443](https://github.com/googleapis/google-cloud-dotnet/commit/0bce44378e0541f44128c9e862cdcaf32d859c8d))
- Added AVRO DatabaseDumpSpec for importing and exporting Avro files ([commit 0bce443](https://github.com/googleapis/google-cloud-dotnet/commit/0bce44378e0541f44128c9e862cdcaf32d859c8d))
- Added additional endTime field for MetadataImports ([commit 0bce443](https://github.com/googleapis/google-cloud-dotnet/commit/0bce44378e0541f44128c9e862cdcaf32d859c8d))
- Added RESTORING status on Backups ([commit 0bce443](https://github.com/googleapis/google-cloud-dotnet/commit/0bce44378e0541f44128c9e862cdcaf32d859c8d))
- Added support to record the services that are restoring the backup ([commit 0bce443](https://github.com/googleapis/google-cloud-dotnet/commit/0bce44378e0541f44128c9e862cdcaf32d859c8d))
- Added configuration for Dataplex integration ([commit 0bce443](https://github.com/googleapis/google-cloud-dotnet/commit/0bce44378e0541f44128c9e862cdcaf32d859c8d))
- Added support for IAM management for metadata resources ([commit 0bce443](https://github.com/googleapis/google-cloud-dotnet/commit/0bce44378e0541f44128c9e862cdcaf32d859c8d))
- Added AuxiliaryVersionConfig for configuring the auxiliary hive versions during creation or update of the DPMS instance ([commit 0bce443](https://github.com/googleapis/google-cloud-dotnet/commit/0bce44378e0541f44128c9e862cdcaf32d859c8d))
- Added NetworkConfig for exposing the DPMS endpoint in multiple subnetworks using PSC (this skips the need for VPC peering) ([commit 0bce443](https://github.com/googleapis/google-cloud-dotnet/commit/0bce44378e0541f44128c9e862cdcaf32d859c8d))
- Added EncryptionConfig which contains information used to configure the Dataproc Metastore service to encrypt customer data at rest (CMEK) ([commit 0bce443](https://github.com/googleapis/google-cloud-dotnet/commit/0bce44378e0541f44128c9e862cdcaf32d859c8d))

### Documentation improvements

- Formatting improvements ([commit 0bce443](https://github.com/googleapis/google-cloud-dotnet/commit/0bce44378e0541f44128c9e862cdcaf32d859c8d))

## Version 1.0.0-alpha03, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-alpha02, released 2021-03-10

- [Commit 7ee3de9](https://github.com/googleapis/google-cloud-dotnet/commit/7ee3de9): feat: added support for release channels when creating service
- [Commit 4019cd7](https://github.com/googleapis/google-cloud-dotnet/commit/4019cd7): feat: Backup and export support

## Version 1.0.0-alpha01, released 2021-02-26

Initial release.


