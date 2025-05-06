# Version history

## Version 1.0.0-beta03, released 2025-05-06

### New features

- A new resource_definition `cloudkms.googleapis.com/CryptoKey` is added
- A new method `RescheduleMaintenance` is added to service `Memorystore`
- A new method `ListBackupCollections` is added to service `Memorystore`
- A new method `GetBackupCollection` is added to service `Memorystore`
- A new method `ListBackups` is added to service `Memorystore`
- A new method `GetBackup` is added to service `Memorystore`
- A new method `DeleteBackup` is added to service `Memorystore`
- A new method `ExportBackup` is added to service `Memorystore`
- A new method `BackupInstance` is added to service `Memorystore`
- A new field `target_engine_version` is added to message `.google.cloud.memorystore.v1.Instance`
- A new field `target_node_type` is added to message `.google.cloud.memorystore.v1.Instance`
- A new message `GcsBackupSource` is added
- A new message `ManagedBackupSource` is added
- A new field `gcs_source` is added to message `.google.cloud.memorystore.v1.Instance`
- A new field `managed_backup_source` is added to message `.google.cloud.memorystore.v1.Instance`
- A new field `psc_attachment_details` is added to message `.google.cloud.memorystore.v1.Instance`
- A new field `ondemand_maintenance` is added to message `.google.cloud.memorystore.v1.Instance`
- A new field `maintenance_policy` is added to message `.google.cloud.memorystore.v1.Instance`
- A new field `maintenance_schedule` is added to message `.google.cloud.memorystore.v1.Instance`
- A new field `cross_instance_replication_config` is added to message `.google.cloud.memorystore.v1.Instance`
- A new field `async_instance_endpoints_deletion_enabled` is added to message `.google.cloud.memorystore.v1.Instance`
- A new field `backup_collection` is added to message `.google.cloud.memorystore.v1.Instance`
- A new field `automated_backup_config` is added to message `.google.cloud.memorystore.v1.Instance`
- A new message `AutomatedBackupConfig` is added
- A new message `BackupCollection` is added
- A new resource_definition `memorystore.googleapis.com/BackupCollection` is added
- A new message `Backup` is added
- A new resource_definition `memorystore.googleapis.com/Backup` is added
- A new message `BackupFile` is added
- A new message `CrossInstanceReplicationConfig` is added
- A new message `MaintenancePolicy` is added
- A new message `WeeklyMaintenanceWindow` is added
- A new message `MaintenanceSchedule` is added
- A new message `PscAttachmentDetail` is added
- A new field `port` is added to message `.google.cloud.memorystore.v1.PscConnection`
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

### Documentation improvements

- A comment for field `psc_auto_connection` in message `.google.cloud.memorystore.v1.Instance` is changed
- A comment for field `discovery_endpoints` in message `.google.cloud.memorystore.v1.Instance` is changed
- A comment for field `node_type` in message `.google.cloud.memorystore.v1.Instance` is changed
- A comment for field `engine_version` in message `.google.cloud.memorystore.v1.Instance` is changed
- A comment for field `psc_auto_connections` in message `.google.cloud.memorystore.v1.Instance` is changed
- A comment for field `port` in message `.google.cloud.memorystore.v1.PscAutoConnection` is changed
- A comment for field `psc_connection_id` in message `.google.cloud.memorystore.v1.PscConnection` is changed

## Version 1.0.0-beta02, released 2025-02-10

### New features

- Add Instance.Mode.CLUSTER_DISABLED value, and deprecate STANDALONE ([commit 27fb9d0](https://github.com/googleapis/google-cloud-dotnet/commit/27fb9d000e95b30c40356da91445b030cb8a0c41))

### Documentation improvements

- A comment for enum value `STANDALONE` in enum `Mode` is changed ([commit 27fb9d0](https://github.com/googleapis/google-cloud-dotnet/commit/27fb9d000e95b30c40356da91445b030cb8a0c41))

## Version 1.0.0-beta01, released 2025-01-23

Initial release.
