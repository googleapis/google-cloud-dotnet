# Version history

## Version 2.9.0, released 2022-02-22

### New features

- Add IAM mixin to Google.Cloud.Kms.V1 ([commit dd98ae1](https://github.com/googleapis/google-cloud-dotnet/commit/dd98ae17324b3f6817af7ff01ae42f1ff6503f6a))

## Version 2.8.0, released 2022-02-07

### New features

- Add a new EkmService API ([commit 507277b](https://github.com/googleapis/google-cloud-dotnet/commit/507277b44a27618bd92d2318ea4280e3d09420d6))

## Version 2.7.0, released 2021-11-10

- [Commit 9b6c247](https://github.com/googleapis/google-cloud-dotnet/commit/9b6c247): feat: add support for Raw PKCS\#1 signing keys

## Version 2.6.0, released 2021-10-12

- [Commit 19b3652](https://github.com/googleapis/google-cloud-dotnet/commit/19b3652): feat: add RPC retry information for MacSign, MacVerify, and GenerateRandomBytes
- [Commit 419bd7c](https://github.com/googleapis/google-cloud-dotnet/commit/419bd7c): feat: add OAEP+SHA1 to the list of supported algorithms

## Version 2.5.0, released 2021-09-23

- [Commit b91de3f](https://github.com/googleapis/google-cloud-dotnet/commit/b91de3f): feat: add support for Key Reimport
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.4.0, released 2021-08-10

- [Commit f62f458](https://github.com/googleapis/google-cloud-dotnet/commit/f62f458): feat: add support for HMAC, Variable Key Destruction, and GenerateRandom

## Version 2.3.0, released 2021-06-22

- [Commit f1d52c1](https://github.com/googleapis/google-cloud-dotnet/commit/f1d52c1): feat: add ECDSA secp256k1 to the list of supported algorithms.

## Version 2.2.0, released 2021-04-29

- [Commit e89b7c2](https://github.com/googleapis/google-cloud-dotnet/commit/e89b7c2):
  - feat: Add maxAttempts to retry policy for KMS gRPC service config
  - feat: Add Bazel exports_files entry for KMS gRPC service config
- [Commit aeb69c3](https://github.com/googleapis/google-cloud-dotnet/commit/aeb69c3): fix: do not retry on 13 INTERNAL

## Version 2.1.0, released 2020-10-20

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit ad918b1](https://github.com/googleapis/google-cloud-dotnet/commit/ad918b1): Add client integrity verification fields to the KMS protos
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit d183f72](https://github.com/googleapis/google-cloud-dotnet/commit/d183f72): docs: change relative URLs to absolute URLs to fix broken links.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-04-08

- [Commit 45c8362](https://github.com/googleapis/google-cloud-dotnet/commit/45c8362): Add support for Cloud EKM to the Cloud KMS service and resource protos.

## Version 2.0.0-beta03, released 2020-03-18

No API surface changes compared with 2.0.0-beta02, just dependency
and implementation changes.

## Version 2.0.0-beta02, released 2020-02-21

- [Commit 2305571](https://github.com/googleapis/google-cloud-dotnet/commit/2305571):
  - Regenerate Google.Cloud.Kms.V1
  - Restores some method signatures that were in 1.1.0:
    - GetCryptoKey(name)
    - GetCryptoKeyVersion(name)
    - GetImportJob(name)
    - GetPublicKey(name)
  - (Breaking) Changes Encrypt parameter type from CryptoKeyName to IResourceName
  - (Breaking) Changes ListCryptoKeyVersions from KeyRingName to CryptoKeyName

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.1.0, released 2019-12-10

New features:

- RPCs for CreateImportJob, GetImportJob, ImportCryptoKeVersion, ListImportJobs
- Added filtering and ordering when listing crypto keys
- Added filtering and ordering when listing keyrings
- Added Format methods to all resource names
- Added method overloads accepting requests for RPCs that didn't already have them
- Added CryptoKeyVersion properties ImportTime, ImportFailureReason, ImportJob
- Added new CryptoKeyVersionAlgorithm enum values
- Added KeyManagementServiceClientBuilder for simpler configuration

## Version 1.0.0, released 2019-01-24

Initial GA release.
