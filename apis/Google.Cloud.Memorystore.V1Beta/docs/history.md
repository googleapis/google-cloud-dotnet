# Version history

## Version 1.0.0-beta06, released 2026-07-20

### New features

- A new resource_definition `cloudkms.googleapis.com/CryptoKey` is added
- A new resource_definition `cloudkms.googleapis.com/CryptoKeyVersion` is added
- A new resource_definition `compute.googleapis.com/NetworkAttachment` is added
- A new oauth_scope `https://www.googleapis.com/auth/memorystore.read-only` is added to service `Memorystore`
- A new oauth_scope `https://www.googleapis.com/auth/memorystore.read-write` is added to service `Memorystore`
- A new method `RescheduleMaintenance` is added to service `Memorystore`
- A new method `ListBackupCollections` is added to service `Memorystore`
- A new method `GetBackupCollection` is added to service `Memorystore`
- A new method `ListBackups` is added to service `Memorystore`
- A new method `GetBackup` is added to service `Memorystore`
- A new method `DeleteBackup` is added to service `Memorystore`
- A new method `ExportBackup` is added to service `Memorystore`
- A new method `BackupInstance` is added to service `Memorystore`
- A new method `StartMigration` is added to service `Memorystore`
- A new method `FinishMigration` is added to service `Memorystore`
- A new method `ListTokenAuthUsers` is added to service `Memorystore`
- A new method `GetTokenAuthUser` is added to service `Memorystore`
- A new method `ListAuthTokens` is added to service `Memorystore`
- A new method `GetAuthToken` is added to service `Memorystore`
- A new method `AddTokenAuthUser` is added to service `Memorystore`
- A new method `DeleteTokenAuthUser` is added to service `Memorystore`
- A new method `AddAuthToken` is added to service `Memorystore`
- A new method `DeleteAuthToken` is added to service `Memorystore`
- A new field `target_engine_version` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `target_node_type` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new message `GcsBackupSource` is added
- A new message `ManagedBackupSource` is added
- A new value `MIGRATING` is added to enum `State`
- A new value `TOKEN_AUTH` is added to enum `AuthorizationMode`
- A new field `gcs_source` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `managed_backup_source` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `psc_attachment_details` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `simulate_maintenance_event` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `ondemand_maintenance` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `satisfies_pzs` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `satisfies_pzi` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `maintenance_policy` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `maintenance_schedule` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `cross_instance_replication_config` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `async_instance_endpoints_deletion_enabled` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `kms_key` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `encryption_info` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `backup_collection` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `automated_backup_config` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `maintenance_version` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `effective_maintenance_version` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `available_maintenance_versions` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `allow_fewer_zones_deployment` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new field `migration_config` is added to message `.google.cloud.memorystore.v1beta.Instance`
- A new message `StartMigrationRequest` is added
- A new message `FinishMigrationRequest` is added
- A new message `SelfManagedSource` is added
- A new message `MigrationConfig` is added
- A new message `AutomatedBackupConfig` is added
- A new message `BackupCollection` is added
- A new resource_definition `memorystore.googleapis.com/BackupCollection` is added
- A new message `Backup` is added
- A new resource_definition `memorystore.googleapis.com/Backup` is added
- A new message `BackupFile` is added
- A new message `CrossInstanceReplicationConfig` is added
- A new message `TokenAuthUser` is added
- A new resource_definition `memorystore.googleapis.com/TokenAuthUser` is added
- A new message `AuthToken` is added
- A new resource_definition `memorystore.googleapis.com/AuthToken` is added
- A new message `MaintenancePolicy` is added
- A new message `WeeklyMaintenanceWindow` is added
- A new message `MaintenanceSchedule` is added
- A new message `PscAttachmentDetail` is added
- A new field `port` is added to message `.google.cloud.memorystore.v1beta.PscConnection`
- A new message `RescheduleMaintenanceRequest` is added
- A new message `ListBackupCollectionsRequest` is added
- A new message `ListBackupCollectionsResponse` is added
- A new message `GetBackupCollectionRequest` is added
- A new message `ListBackupsRequest` is added
- A new message `ListBackupsResponse` is added
- A new message `GetBackupRequest` is added
- A new message `DeleteBackupRequest` is added
- A new message `ExportBackupRequest` is added
- A new message `BackupInstanceRequest` is added
- A new message `ListTokenAuthUsersRequest` is added
- A new message `ListTokenAuthUsersResponse` is added
- A new message `GetTokenAuthUserRequest` is added
- A new message `ListAuthTokensRequest` is added
- A new message `ListAuthTokensResponse` is added
- A new message `GetAuthTokenRequest` is added
- A new message `AddTokenAuthUserRequest` is added
- A new message `DeleteTokenAuthUserRequest` is added
- A new message `AddAuthTokenRequest` is added
- A new message `DeleteAuthTokenRequest` is added
- A new message `EncryptionInfo` is added

### Bug fixes

- Changed field behavior for an existing field `psc_connection_id` in message `.google.cloud.memorystore.v1beta.PscConnection`

### Documentation improvements

- A comment for field `psc_auto_connection` in message `.google.cloud.memorystore.v1beta.Instance` is changed
- A comment for field `discovery_endpoints` in message `.google.cloud.memorystore.v1beta.Instance` is changed
- A comment for field `node_type` in message `.google.cloud.memorystore.v1beta.Instance` is changed
- A comment for field `engine_version` in message `.google.cloud.memorystore.v1beta.Instance` is changed
- A comment for field `psc_auto_connections` in message `.google.cloud.memorystore.v1beta.Instance` is changed
- A comment for field `mode` in message `.google.cloud.memorystore.v1beta.Instance` is changed
- A comment for field `port` in message `.google.cloud.memorystore.v1beta.PscAutoConnection` is changed
- A comment for field `network` in message `.google.cloud.memorystore.v1beta.PscAutoConnection` is changed
- A comment for field `psc_connection_id` in message `.google.cloud.memorystore.v1beta.PscConnection` is changed
- A comment for field `network` in message `.google.cloud.memorystore.v1beta.PscConnection` is changed
- A comment for field `network` in message `.google.cloud.memorystore.v1beta.DiscoveryEndpoint` is changed
- A comment for message `ListInstancesRequest` is changed
- A comment for message `ListInstancesResponse` is changed
- A comment for message `GetInstanceRequest` is changed
- A comment for message `GetCertificateAuthorityRequest` is changed
- A comment for message `GetSharedRegionalCertificateAuthorityRequest` is changed

## Version 1.0.0-beta05, released 2026-05-04

### New features

- [Memorystore for Valkey] Updating new node types added

## Version 1.0.0-beta04, released 2026-04-06

### New features

- [Memorystore for Valkey] Add support for Flexible CA feature

## Version 1.0.0-beta03, released 2025-11-05

### New features

- Update dependencies

## Version 1.0.0-beta02, released 2025-02-10

### New features

- Add Instance.Mode.CLUSTER_DISABLED value, and deprecate STANDALONE ([commit b45c1eb](https://github.com/googleapis/google-cloud-dotnet/commit/b45c1ebab5e23ce42da1d384b11f56f1dd8c3632))

### Documentation improvements

- A comment for enum value `STANDALONE` in enum `Mode` is changed ([commit b45c1eb](https://github.com/googleapis/google-cloud-dotnet/commit/b45c1ebab5e23ce42da1d384b11f56f1dd8c3632))

## Version 1.0.0-beta01, released 2025-01-23

Initial release.
