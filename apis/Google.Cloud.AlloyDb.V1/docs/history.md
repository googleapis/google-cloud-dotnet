# Version history

## Version 1.9.0, released 2024-10-29

### New features

- Add new PSC instance configuration setting and output the PSC DNS name ([commit e79b0b3](https://github.com/googleapis/google-cloud-dotnet/commit/e79b0b3717b7c9aae913bf6a0262e4985c74dcf7))
- Add new API to execute SQL statements ([commit e79b0b3](https://github.com/googleapis/google-cloud-dotnet/commit/e79b0b3717b7c9aae913bf6a0262e4985c74dcf7))
- Add support for Free Trials ([commit e79b0b3](https://github.com/googleapis/google-cloud-dotnet/commit/e79b0b3717b7c9aae913bf6a0262e4985c74dcf7))
- Add support to schedule maintenance ([commit e79b0b3](https://github.com/googleapis/google-cloud-dotnet/commit/e79b0b3717b7c9aae913bf6a0262e4985c74dcf7))
- Additional field to set tags on a backup or cluster ([commit e79b0b3](https://github.com/googleapis/google-cloud-dotnet/commit/e79b0b3717b7c9aae913bf6a0262e4985c74dcf7))
- Add more observability options on the Instance level ([commit e79b0b3](https://github.com/googleapis/google-cloud-dotnet/commit/e79b0b3717b7c9aae913bf6a0262e4985c74dcf7))
- Add new API to perform a promotion or switchover on secondary instances ([commit e79b0b3](https://github.com/googleapis/google-cloud-dotnet/commit/e79b0b3717b7c9aae913bf6a0262e4985c74dcf7))
- Support for obtaining the public ip addresses of an instance and enabling either inbound or outbound public ip ([commit e79b0b3](https://github.com/googleapis/google-cloud-dotnet/commit/e79b0b3717b7c9aae913bf6a0262e4985c74dcf7))
- Add new API to list the databases in a project and location ([commit e79b0b3](https://github.com/googleapis/google-cloud-dotnet/commit/e79b0b3717b7c9aae913bf6a0262e4985c74dcf7))
- Add optional field to keep extra roles on a user if it already exists ([commit e79b0b3](https://github.com/googleapis/google-cloud-dotnet/commit/e79b0b3717b7c9aae913bf6a0262e4985c74dcf7))

### Documentation improvements

- Various typo fixes, correcting the formatting, and clarifications on the request_id and validate_only fields in API requests and on the page_size when listing the database ([commit e79b0b3](https://github.com/googleapis/google-cloud-dotnet/commit/e79b0b3717b7c9aae913bf6a0262e4985c74dcf7))

## Version 1.8.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 1.7.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.6.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.5.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 1.4.0, released 2023-11-07

### New features

- Add new field in `GenerateClientCertificate` v1 API to allow AlloyDB connectors request client certs with metadata exchange support ([commit adc660e](https://github.com/googleapis/google-cloud-dotnet/commit/adc660e37b842eac165982bd8d1c8e479a11ba65))

### Documentation improvements

- Clarify that `readPoolConfig` is required under certain circumstances, and fix doc formatting on `allocatedIpRange`. ([commit adc660e](https://github.com/googleapis/google-cloud-dotnet/commit/adc660e37b842eac165982bd8d1c8e479a11ba65))

## Version 1.3.0, released 2023-10-02

### New features

- Add support to generate client certificate and get connection info for auth proxy in AlloyDB v1 ([commit 70f274b](https://github.com/googleapis/google-cloud-dotnet/commit/70f274b3403655350cb3db768ae678fda5543c22))

## Version 1.2.0, released 2023-09-25

### New features

- Changed description for recovery_window_days in ContinuousBackupConfig ([commit 4de4022](https://github.com/googleapis/google-cloud-dotnet/commit/4de402263662134af0f348db4d8d16dcbfc7799e))
- Added NetworkConfig, deprecated network ([commit 4de4022](https://github.com/googleapis/google-cloud-dotnet/commit/4de402263662134af0f348db4d8d16dcbfc7799e))
- Added ClientConnectionConfig ([commit 4de4022](https://github.com/googleapis/google-cloud-dotnet/commit/4de402263662134af0f348db4d8d16dcbfc7799e))
- Added DatabaseVersion ([commit 4de4022](https://github.com/googleapis/google-cloud-dotnet/commit/4de402263662134af0f348db4d8d16dcbfc7799e))
- Added QuantityBasedExpiry ([commit 4de4022](https://github.com/googleapis/google-cloud-dotnet/commit/4de402263662134af0f348db4d8d16dcbfc7799e))
## Version 1.1.0, released 2023-06-20

### Bug fixes

- Deprecated SSL modes SSL_MODE_ALLOW, SSL_MODE_REQUIRE, SSL_MODE_VERIFY_CA ([commit debc17d](https://github.com/googleapis/google-cloud-dotnet/commit/debc17db6a30676abaee3175bde76105bf4c6eb2))

### New features

- Added new SSL modes ALLOW_UNENCRYPTED_AND_ENCRYPTED, ENCRYPTED_ONLY ([commit debc17d](https://github.com/googleapis/google-cloud-dotnet/commit/debc17db6a30676abaee3175bde76105bf4c6eb2))
- Added support for continuous backups ([commit debc17d](https://github.com/googleapis/google-cloud-dotnet/commit/debc17db6a30676abaee3175bde76105bf4c6eb2))
- Added support for cross-region replication (secondary clusters/instances and promotion) ([commit debc17d](https://github.com/googleapis/google-cloud-dotnet/commit/debc17db6a30676abaee3175bde76105bf4c6eb2))
- Added users API ([commit debc17d](https://github.com/googleapis/google-cloud-dotnet/commit/debc17db6a30676abaee3175bde76105bf4c6eb2))
- Added fault injection API ([commit debc17d](https://github.com/googleapis/google-cloud-dotnet/commit/debc17db6a30676abaee3175bde76105bf4c6eb2))

## Version 1.0.0, released 2023-06-12

Primary purpose of release is to update dependencies and promote to 1.0.0.

### Documentation improvements

- Minor formatting in description of AvailabilityType ([commit fa13762](https://github.com/googleapis/google-cloud-dotnet/commit/fa13762d844bda825fd8caa4473c55c405e0c5b1))

## Version 1.0.0-beta01, released 2023-03-02

Initial release.
