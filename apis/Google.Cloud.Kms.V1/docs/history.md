# Version history

## Version 3.18.0, released 2025-05-16

### Documentation improvements

- A comment for enum value `DESTROYED` in enum `CryptoKeyVersionState` is changed

## Version 3.17.0, released 2025-05-15

### New features

- Adding eTag field to AutokeyConfig

### Documentation improvements

- Updating docs for total_size field in KMS List APIs

## Version 3.16.0, released 2025-02-25

### New features

- Support PQC asymmetric signing algorithms ML_DSA_65 and SLH_DSA_SHA2_128s ([commit 0f261f0](https://github.com/googleapis/google-cloud-dotnet/commit/0f261f0ccd662035e9eabd289b64aeb1271d5c59))
- Add a PublicKeyFormat enum to allow specifying the format the public is going to be exported in ([commit 0f261f0](https://github.com/googleapis/google-cloud-dotnet/commit/0f261f0ccd662035e9eabd289b64aeb1271d5c59))

### Documentation improvements

- Modify enum comment ([commit 0cf6e5b](https://github.com/googleapis/google-cloud-dotnet/commit/0cf6e5bb7fbbcaffa670bc844b1cd517c92dd01b))
- Code documentation improvements ([commit 87c4799](https://github.com/googleapis/google-cloud-dotnet/commit/87c479909782d2cc1859dd94652cb8507933c9f2))
- A comment for enum `CryptoKeyVersionAlgorithm` is changed ([commit d7e6cd5](https://github.com/googleapis/google-cloud-dotnet/commit/d7e6cd5afe2c0b14d09dcd9a41cd5edb676bc741))

## Version 3.15.0, released 2024-10-30

### Documentation improvements

- Improve comment formatting


## Version 3.14.0, released 2024-09-26

### Bug fixes

- **BREAKING CHANGE** Pagination feature is introduced for method `ListKeyHandles` in service `Autokey` ([commit d036220](https://github.com/googleapis/google-cloud-dotnet/commit/d036220251afc1d36c2ee530197ad37a404c54f7))

This breaking change is being introduced without a new major version
as we believe customers are unlikely to be using the existing API
surface, and that it's in the best interestes of most customers to
keep to a minor release. (We completely acknowledge that this *is* a
breaking change, and we apologize if you're affected by it. Please
[raise an issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
with any concerns - we're keen to improve this balance where we can.)

### New features

- Adding a state field for AutokeyConfig ([commit d036220](https://github.com/googleapis/google-cloud-dotnet/commit/d036220251afc1d36c2ee530197ad37a404c54f7))

### Documentation improvements

- Field service_resolvers in message .google.cloud.kms.v1.EkmConnection is Explicitly is marked as to have field behavior of Optional ([commit d036220](https://github.com/googleapis/google-cloud-dotnet/commit/d036220251afc1d36c2ee530197ad37a404c54f7))
- A comment for field `destroy_scheduled_duration` in message `.google.cloud.kms.v1.CryptoKey` is updated for the default duration ([commit d036220](https://github.com/googleapis/google-cloud-dotnet/commit/d036220251afc1d36c2ee530197ad37a404c54f7))

## Version 3.13.0, released 2024-06-24

### New features

- Support Key Access Justifications policy configuration ([commit 801775b](https://github.com/googleapis/google-cloud-dotnet/commit/801775b978e387c2cc0bff81a1450fd002fdbf30))

## Version 3.12.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 3.11.0, released 2024-05-08

### New features

- Add client library for KMS Autokey service, which enables automated KMS key provision and management ([commit 5ff96b3](https://github.com/googleapis/google-cloud-dotnet/commit/5ff96b3bb71b5732b4bc9d0a21f195440a7ac1d3))
- Introduce Long-Running Operations (LRO) for KMS ([commit 3020530](https://github.com/googleapis/google-cloud-dotnet/commit/3020530fd4cac7f9c8185059b9e69091eb89afe6))
- Support the ED25519 asymmetric signing algorithm ([commit 820f2ec](https://github.com/googleapis/google-cloud-dotnet/commit/820f2ec4dc8134c0a63434a93b930bb88e3788e1))
- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

### Documentation improvements

- In google.cloud.kms.v1.PublicKey, pem field is always populated ([commit 790ddc8](https://github.com/googleapis/google-cloud-dotnet/commit/790ddc8e9191b3652679ab54e7cf8c5f74518002))

## Version 3.10.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.9.0, released 2024-03-13

No API surface changes; just dependency updates.

## Version 3.8.0, released 2024-02-09

### Documentation improvements

- Update comments ([commit 38d35cd](https://github.com/googleapis/google-cloud-dotnet/commit/38d35cd2bb934d9a58fe9ef72249477dc87fc610))
- Minor formatting ([commit 5f3c5d6](https://github.com/googleapis/google-cloud-dotnet/commit/5f3c5d6339cf46a241e75cb83688161686ab3212))
- Minor formatting ([commit 21481f5](https://github.com/googleapis/google-cloud-dotnet/commit/21481f59e36ab85882dfe30eb8c2c9d5549ae8dd))
## Version 3.7.0, released 2023-08-04

### New features

- Add interoperable symmetric encryption system ([commit 0a36eb9](https://github.com/googleapis/google-cloud-dotnet/commit/0a36eb98bd94e46576c52d63e5c6b44910e41ba2))

### Documentation improvements

- Minor formatting ([commit 2d4d254](https://github.com/googleapis/google-cloud-dotnet/commit/2d4d254457a1bb700638f18409522f631be92300))

## Version 3.6.0, released 2023-07-13

### New features

- Add interoperable symmetric encryption system ([commit 9ce4e96](https://github.com/googleapis/google-cloud-dotnet/commit/9ce4e965f7a88a2712bc0c64f14f64dd1a58d489))

## Version 3.5.0, released 2023-05-26

### New features

- Added VerifyConnectivity RPC ([commit 6a49888](https://github.com/googleapis/google-cloud-dotnet/commit/6a4988813f39d14905cdcb84ddf93b452f062d86))

### Documentation improvements

- Improve descriptions of different hash functions/values for ECDSA signing ([issue 10118](https://github.com/googleapis/google-cloud-dotnet/issues/10118)) ([commit c41a931](https://github.com/googleapis/google-cloud-dotnet/commit/c41a9317d52a5d26eb47fd6fa9adf0f4af69e260))

## Version 3.4.0, released 2023-03-20

### New features

- Add support for Coordinated External Keys ([commit 08d67d7](https://github.com/googleapis/google-cloud-dotnet/commit/08d67d7dd565dcbf814259038cfb6504b721a5d0))

## Version 3.3.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

## Version 3.2.0, released 2022-12-01

### New features

- Add SHA-2 import methods ([issue 9353](https://github.com/googleapis/google-cloud-dotnet/issues/9353)) ([commit df7a29e](https://github.com/googleapis/google-cloud-dotnet/commit/df7a29ea4d48c819d451a47e5d3e3d944a1ceb51))
- Add support for additional HMAC algorithms ([issue 9327](https://github.com/googleapis/google-cloud-dotnet/issues/9327)) ([commit 26da664](https://github.com/googleapis/google-cloud-dotnet/commit/26da664a2c73758fedb9e527fa3562119719399d))

## Version 3.1.0, released 2022-11-02

### New features

- Enable generation of Locations mixin ([commit 4475616](https://github.com/googleapis/google-cloud-dotnet/commit/4475616495319b60ff12f73d4eb06877302ed9ea))

## Version 3.0.0, released 2022-06-08

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

### API specific breaking changes

- IAM access should now be via the IAMPolicyClient property in the client. ([commit a47cb51](https://github.com/googleapis/google-cloud-dotnet/commit/a47cb5159450dbdf3ecbfc0a36144862085511db))

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
