# Version history

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
