# Version history

# Version 2.0.0-beta02, released 2020-02-21

- [Commit 2305571](https://github.com/googleapis/google-cloud-dotnet/commit/2305571):
  - Regenerate Google.Cloud.Kms.V1
  - Restores some method signatures that were in 1.1.0:
    - GetCryptoKey(name)
    - GetCryptoKeyVersion(name)
    - GetImportJob(name)
    - GetPublicKey(name)
  - (Breaking) Changes Encrypt parameter type from CryptoKeyName to IResourceName
  - (Breaking) Changes ListCryptoKeyVersions from KeyRingName to CryptoKeyName

# Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

# Version 1.1.0, released 2019-12-10

New features:

- RPCs for CreateImportJob, GetImportJob, ImportCryptoKeVersion, ListImportJobs
- Added filtering and ordering when listing crypto keys
- Added filtering and ordering when listing keyrings
- Added Format methods to all resource names
- Added method overloads accepting requests for RPCs that didn't already have them
- Added CryptoKeyVersion properties ImportTime, ImportFailureReason, ImportJob
- Added new CryptoKeyVersionAlgorithm enum values
- Added KeyManagementServiceClientBuilder for simpler configuration

# Version 1.0.0, released 2019-01-24

Initial GA release.
