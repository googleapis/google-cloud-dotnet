# Version history

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
