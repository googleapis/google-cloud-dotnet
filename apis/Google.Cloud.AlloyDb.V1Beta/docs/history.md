# Version history

## Version 1.0.0-beta10, released 2025-03-24

### New features

- A new method `ExportCluster` is added to service `AlloyDBAdmin` ([commit 3c466ca](https://github.com/googleapis/google-cloud-dotnet/commit/3c466cae59fa3ecb67105cc46ca10e39cde91192))
- A new message `GcsDestination` is added ([commit 3c466ca](https://github.com/googleapis/google-cloud-dotnet/commit/3c466cae59fa3ecb67105cc46ca10e39cde91192))
- A new message `ExportClusterRequest` is added ([commit 3c466ca](https://github.com/googleapis/google-cloud-dotnet/commit/3c466cae59fa3ecb67105cc46ca10e39cde91192))
- A new message `ExportClusterResponse` is added ([commit 3c466ca](https://github.com/googleapis/google-cloud-dotnet/commit/3c466cae59fa3ecb67105cc46ca10e39cde91192))

### Documentation improvements

- A comment for field `zone_id` in message `.google.cloud.alloydb.v1beta.Instance` is changed ([commit 3c466ca](https://github.com/googleapis/google-cloud-dotnet/commit/3c466cae59fa3ecb67105cc46ca10e39cde91192))
- A comment for field `id` in message `.google.cloud.alloydb.v1beta.Instance` is changed ([commit 3c466ca](https://github.com/googleapis/google-cloud-dotnet/commit/3c466cae59fa3ecb67105cc46ca10e39cde91192))
- A comment for field `ip` in message `.google.cloud.alloydb.v1beta.Instance` is changed ([commit 3c466ca](https://github.com/googleapis/google-cloud-dotnet/commit/3c466cae59fa3ecb67105cc46ca10e39cde91192))
- A comment for field `state` in message `.google.cloud.alloydb.v1beta.Instance` is changed ([commit 3c466ca](https://github.com/googleapis/google-cloud-dotnet/commit/3c466cae59fa3ecb67105cc46ca10e39cde91192))
- A comment for field `database_flags` in message `.google.cloud.alloydb.v1beta.Instance` is changed ([commit 3c466ca](https://github.com/googleapis/google-cloud-dotnet/commit/3c466cae59fa3ecb67105cc46ca10e39cde91192))
- A comment for field `requested_cancellation` in message `.google.cloud.alloydb.v1beta.OperationMetadata` is changed ([commit 3c466ca](https://github.com/googleapis/google-cloud-dotnet/commit/3c466cae59fa3ecb67105cc46ca10e39cde91192))

## Version 1.0.0-beta09, released 2024-11-18

### Bug fixes

- **BREAKING CHANGE** Deprecated various PSC instance configuration fields ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))

### New features

- Add new PSC instance configuration setting and output the PSC DNS name ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))
- Add new API to upgrade a cluster ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))
- Add new API to execute SQL statements ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))
- Add new cluster and instance level configurations to interact with Gemini ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))
- Add support for Free Trials ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))
- Add support to schedule maintenance ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))
- Additional field to set tags on a backup or cluster ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))
- Add more observability options on the Instance level ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))
- Add new API to perform a promotion or switchover on secondary instances ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))
- Add new CloudSQL backup resource ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))
- Support for obtaining the public ip addresses of an instance and enabling outbound public ip ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))
- Add optional field to keep extra roles on a user if it already exists ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))

### Documentation improvements

- Various typo fixes, correcting the formatting, and clarifications on the request_id and validate_only fields in API requests and on the page_size when listing the database ([commit 8af4d47](https://github.com/googleapis/google-cloud-dotnet/commit/8af4d47005f38b2859c35889e4c4066d5f3546ef))

## Version 1.0.0-beta08, released 2024-09-09

### New features

- Support for enabling outbound public IP on an instance ([commit 189b96d](https://github.com/googleapis/google-cloud-dotnet/commit/189b96d0f47ffeabf37a4c1144f6e06cd570778c))
- Support for getting outbound public IP addresses of an instance ([commit 189b96d](https://github.com/googleapis/google-cloud-dotnet/commit/189b96d0f47ffeabf37a4c1144f6e06cd570778c))
- Support for setting maintenance update policy on a cluster ([commit 189b96d](https://github.com/googleapis/google-cloud-dotnet/commit/189b96d0f47ffeabf37a4c1144f6e06cd570778c))
- Support for getting maintenance schedule of a cluster ([commit 189b96d](https://github.com/googleapis/google-cloud-dotnet/commit/189b96d0f47ffeabf37a4c1144f6e06cd570778c))

## Version 1.0.0-beta07, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 1.0.0-beta06, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta05, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.0.0-beta04, released 2024-02-27

### New features

- Support for obtaining the public IP address of an Instance ([commit 28c0d9d](https://github.com/googleapis/google-cloud-dotnet/commit/28c0d9d23d02ec425e360ebc5b1d53814fc6dffd))
- Support for getting PSC DNS name from the GetConnectionInfo API ([commit 28c0d9d](https://github.com/googleapis/google-cloud-dotnet/commit/28c0d9d23d02ec425e360ebc5b1d53814fc6dffd))
- Add PSC cluster and instance configuration settings to enable/disable PSC and obtain the PSC endpoint name ([commit 28c0d9d](https://github.com/googleapis/google-cloud-dotnet/commit/28c0d9d23d02ec425e360ebc5b1d53814fc6dffd))
- Add new API to list the databases in a project and location ([commit 28c0d9d](https://github.com/googleapis/google-cloud-dotnet/commit/28c0d9d23d02ec425e360ebc5b1d53814fc6dffd))

### Documentation improvements

- Clarified read pool config is for read pool type instances ([commit 28c0d9d](https://github.com/googleapis/google-cloud-dotnet/commit/28c0d9d23d02ec425e360ebc5b1d53814fc6dffd))

## Version 1.0.0-beta03, released 2023-09-25

### New features

- Added enum value for PG15 ([commit c4cb2c1](https://github.com/googleapis/google-cloud-dotnet/commit/c4cb2c151c4dc63b650dae9f5bf6c88ef910abe0))
- Changed description for recovery_window_days in ContinuousBackupConfig ([commit c4cb2c1](https://github.com/googleapis/google-cloud-dotnet/commit/c4cb2c151c4dc63b650dae9f5bf6c88ef910abe0))
- Deprecate network field in favor of network_config.network ([commit c4cb2c1](https://github.com/googleapis/google-cloud-dotnet/commit/c4cb2c151c4dc63b650dae9f5bf6c88ef910abe0))
- Added ClientConnectionConfig ([commit c4cb2c1](https://github.com/googleapis/google-cloud-dotnet/commit/c4cb2c151c4dc63b650dae9f5bf6c88ef910abe0))
- Added QuantityBasedExpiry ([commit c4cb2c1](https://github.com/googleapis/google-cloud-dotnet/commit/c4cb2c151c4dc63b650dae9f5bf6c88ef910abe0))
- Added DatabaseVersion ([commit c4cb2c1](https://github.com/googleapis/google-cloud-dotnet/commit/c4cb2c151c4dc63b650dae9f5bf6c88ef910abe0))

## Version 1.0.0-beta02, released 2023-06-20

### Bug fixes

- Deprecated SSL modes SSL_MODE_ALLOW, SSL_MODE_REQUIRE, SSL_MODE_VERIFY_CA ([commit a839416](https://github.com/googleapis/google-cloud-dotnet/commit/a839416ee1a6572e3c0fb71b57c277d71dcfb424))

### New features

- Added ClusterView supporting more granular view of continuous backups ([commit a839416](https://github.com/googleapis/google-cloud-dotnet/commit/a839416ee1a6572e3c0fb71b57c277d71dcfb424))
- Added new SSL modes ALLOW_UNENCRYPTED_AND_ENCRYPTED, ENCRYPTED_ONLY ([commit a839416](https://github.com/googleapis/google-cloud-dotnet/commit/a839416ee1a6572e3c0fb71b57c277d71dcfb424))
- Added users API ([commit a839416](https://github.com/googleapis/google-cloud-dotnet/commit/a839416ee1a6572e3c0fb71b57c277d71dcfb424))
- Added fault injection API ([commit a839416](https://github.com/googleapis/google-cloud-dotnet/commit/a839416ee1a6572e3c0fb71b57c277d71dcfb424))
- Added instance update policy ([commit a839416](https://github.com/googleapis/google-cloud-dotnet/commit/a839416ee1a6572e3c0fb71b57c277d71dcfb424))
- Added cluster network config ([commit a839416](https://github.com/googleapis/google-cloud-dotnet/commit/a839416ee1a6572e3c0fb71b57c277d71dcfb424))

### Documentation improvements

- Minor formatting in description of AvailabilityType ([commit 460b883](https://github.com/googleapis/google-cloud-dotnet/commit/460b88319a026f0a3e9da6a21880b1fb0dbf3731))

## Version 1.0.0-beta01, released 2023-03-02

Initial release.
