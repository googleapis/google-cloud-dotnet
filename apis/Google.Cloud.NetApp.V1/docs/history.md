# Version history

## Version 1.5.0, released 2024-09-16

### New features

- A new rpc 'SwitchActiveReplicaZone' is added to service 'google.cloud.netapp.v1.NetApp' ([commit ba31386](https://github.com/googleapis/google-cloud-dotnet/commit/ba313865bce91eaafad141e100b10afb67d683cf))
- A new message 'google.cloud.netapp.v1.SwitchActiveReplicaZoneRequest' is added ([commit ba31386](https://github.com/googleapis/google-cloud-dotnet/commit/ba313865bce91eaafad141e100b10afb67d683cf))
- A new field 'allow_auto_tiering' in message 'google.cloud.netapp.v1.StoragePool' is added ([commit ba31386](https://github.com/googleapis/google-cloud-dotnet/commit/ba313865bce91eaafad141e100b10afb67d683cf))
- A new field 'cold_tier_size_gib' in message 'google.cloud.netapp.v1.Volume' is added ([commit ba31386](https://github.com/googleapis/google-cloud-dotnet/commit/ba313865bce91eaafad141e100b10afb67d683cf))

## Version 1.4.0, released 2024-08-05

### New features

- A new field `administrators` is added to message `.google.cloud.netapp.v1.ActiveDirectory` ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A new field `replica_zone` is added to message `.google.cloud.netapp.v1.StoragePool` ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A new field `zone` is added to message `.google.cloud.netapp.v1.StoragePool` ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A new field `large_capacity` is added to message `.google.cloud.netapp.v1.Volume` ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A new field `multiple_endpoints` is added to message `.google.cloud.netapp.v1.Volume` ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A new field `replica_zone` is added to message `.google.cloud.netapp.v1.Volume` ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A new field `zone` is added to message `.google.cloud.netapp.v1.Volume` ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))

### Documentation improvements

- A comment for field `active_directory_id` in message `.google.cloud.netapp.v1.CreateActiveDirectoryRequest` is changed ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A comment for field `backup_id` in message `.google.cloud.netapp.v1.CreateBackupRequest` is changed ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A comment for field `backup_policy_id` in message `.google.cloud.netapp.v1.CreateBackupPolicyRequest` is changed ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A comment for field `backup_vault_id` in message `.google.cloud.netapp.v1.CreateBackupVaultRequest` is changed ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A comment for field `kms_config_id` in message `.google.cloud.netapp.v1.CreateKmsConfigRequest` is changed ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A comment for field `transfer_bytes` in message `.google.cloud.netapp.v1.TransferStats` is changed ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A comment for field `total_transfer_duration` in message `.google.cloud.netapp.v1.TransferStats` is changed ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A comment for enum value `TRANSFERRING` in enum `MirrorState` is changed ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A comment for field `replication_id` in message `.google.cloud.netapp.v1.CreateReplicationRequest` is changed ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A comment for field `snapshot_id` in message `.google.cloud.netapp.v1.CreateSnapshotRequest` is changed ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A comment for field `storage_pool_id` in message `.google.cloud.netapp.v1.CreateStoragePoolRequest` is changed ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))
- A comment for field `volume_id` in message `.google.cloud.netapp.v1.CreateVolumeRequest` is changed ([commit 9d56122](https://github.com/googleapis/google-cloud-dotnet/commit/9d561227111b97734496715af709b36ffd9be526))

## Version 1.3.0, released 2024-05-17

### New features

- Add a new Service Level FLEX ([commit 77da572](https://github.com/googleapis/google-cloud-dotnet/commit/77da5720c8820c47d6738502351ecc4edd76eb73))
- Add Tiering Policy to Volume ([commit 77da572](https://github.com/googleapis/google-cloud-dotnet/commit/77da5720c8820c47d6738502351ecc4edd76eb73))
- Add backup chain bytes to BackupConfig in Volume ([commit 77da572](https://github.com/googleapis/google-cloud-dotnet/commit/77da5720c8820c47d6738502351ecc4edd76eb73))
- Add Location metadata support ([commit 77da572](https://github.com/googleapis/google-cloud-dotnet/commit/77da5720c8820c47d6738502351ecc4edd76eb73))

## Version 1.2.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.1.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

### Documentation improvements

- Rephrase comment on psa_range ([commit 0387455](https://github.com/googleapis/google-cloud-dotnet/commit/038745567fb5baf838ac550c5733a08113a602df))
- Fix comment for UNIX of SecurityStyle ([commit 0387455](https://github.com/googleapis/google-cloud-dotnet/commit/038745567fb5baf838ac550c5733a08113a602df))

## Version 1.0.0, released 2024-03-12

This is the first GA release of the library.

### Documentation improvements

- Mark optional fields explicitly in Storage Pool ([commit 41065fe](https://github.com/googleapis/google-cloud-dotnet/commit/41065fe41d33abf18e9055cb6c079f80eaec571f))
- Change comments of the psa_range field to note it is currently not implemented ([commit 41065fe](https://github.com/googleapis/google-cloud-dotnet/commit/41065fe41d33abf18e9055cb6c079f80eaec571f))
- Update comments of ServiceLevel and EncryptionType ([commit 41065fe](https://github.com/googleapis/google-cloud-dotnet/commit/41065fe41d33abf18e9055cb6c079f80eaec571f))

## Version 1.0.0-beta03, released 2024-02-28

No API surface changes; just dependency updates.

## Version 1.0.0-beta02, released 2024-01-08

### New features

- Enable Backup, Backup Vault, and Backup Policy ([commit 8b670b6](https://github.com/googleapis/google-cloud-dotnet/commit/8b670b64bb211aaa66f436028024abe21d7f60dd))
- Add singular and plural annotations ([commit 8b670b6](https://github.com/googleapis/google-cloud-dotnet/commit/8b670b64bb211aaa66f436028024abe21d7f60dd))
- Set field_behavior to IDENTIFIER on the "name" fields ([commit 8b670b6](https://github.com/googleapis/google-cloud-dotnet/commit/8b670b64bb211aaa66f436028024abe21d7f60dd))

### Documentation improvements

- Comments are updated for several fields/enums ([commit 8b670b6](https://github.com/googleapis/google-cloud-dotnet/commit/8b670b64bb211aaa66f436028024abe21d7f60dd))

## Version 1.0.0-beta01, released 2023-08-09

Initial release.
