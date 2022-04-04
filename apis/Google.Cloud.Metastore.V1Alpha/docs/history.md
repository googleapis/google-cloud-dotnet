# Version history

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


