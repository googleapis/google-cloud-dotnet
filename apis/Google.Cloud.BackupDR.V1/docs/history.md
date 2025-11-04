# Version history

## Version 2.2.0, released 2025-07-28

### New features

- Add support for Cloud SQL backup and restore
- Add support for GCE Disk backup and restore
- Add BackupPlanRevision resource and associated RPCs
- Add DataSourceReference resource and associated RPCs
- Add Update RPCs for BackupPlan and BackupPlanAssociation
- Add FetchBackupPlanAssociationsForResourceType RPC
- Add new states to resources (UPDATING, UPLOADING)
- Add ON_DEMAND_OPERATIONAL backup type
- Change BackupRule.standard_schedule to be OPTIONAL

### Documentation improvements

- A comment for field disks in message .google.cloud.backupdr.v1.ComputeInstanceRestoreProperties is changed
- A comment for field network_interfaces in message .google.cloud.backupdr.v1.ComputeInstanceRestoreProperties is changed
- A comment for field resource_policies in message .google.cloud.backupdr.v1.ComputeInstanceRestoreProperties is changed
- A comment for field resource_type in message .google.cloud.backupdr.v1.BackupPlanAssociation is changed
- A comment for field resource in message .google.cloud.backupdr.v1.BackupPlanAssociation is changed
- A comment for field resource_type in message .google.cloud.backupdr.v1.BackupPlan is changed
- A comment for field backup_retention_days in message .google.cloud.backupdr.v1.BackupRule is changed
- A comment for field hourly_frequency in message .google.cloud.backupdr.v1.StandardSchedule is changed

## Version 2.1.0, released 2025-01-13

### Bug fixes

- Update field behavior of `resource_type` field in message `BackupPlanAssociation` to `REQUIRED` ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))

(This was already the effective behavior.)

### New features

- Add InitializeServiceAPI ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- Update field behavior of `networks` field in message `ManagementServer` to `OPTIONAL` ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- Add enum to Backup Vault Access Restriction field ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- `ignore_backup_plan_references` added to the DeleteBackupVaultRequest ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))

### Documentation improvements

- A comment for field `networks` in message `.google.cloud.backupdr.v1.ManagementServer` is changed ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- A comment for field `requested_cancellation` in message `.google.cloud.backupdr.v1.OperationMetadata` is changed ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- A comment for field `resource_type` in message `.google.cloud.backupdr.v1.BackupPlan` is changed ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- A comment for field `backup_retention_days` in message `.google.cloud.backupdr.v1.BackupRule` is changed ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- A comment for field `resource_type` in message `.google.cloud.backupdr.v1.BackupPlanAssociation` is changed ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- A comment for field `data_source` in message `.google.cloud.backupdr.v1.BackupPlanAssociation` is changed ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- A comment for field `rule_id` in message `.google.cloud.backupdr.v1.RuleConfigInfo` is changed ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- A comment for field `last_backup_error` in message `.google.cloud.backupdr.v1.RuleConfigInfo` is changed ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- A comment for enum value `ACCESS_RESTRICTION_UNSPECIFIED` in enum `AccessRestriction` is changed ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- A comment for field `uid` in message `.google.cloud.backupdr.v1.BackupVault` is changed ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))
- A comment for field `access_restriction` in message `.google.cloud.backupdr.v1.BackupVault` is changed ([commit 5eabb2d](https://github.com/googleapis/google-cloud-dotnet/commit/5eabb2d57f883a54d351b7223d20afa5162da248))

## Version 2.0.0, released 2024-10-14

### Bug fixes

- **BREAKING CHANGE** Remove visibility of unneeded TestIamPermissions RPC ([commit 553e7b0](https://github.com/googleapis/google-cloud-dotnet/commit/553e7b098875151e4dd7d8afbf20a708064fc645))
- **BREAKING CHANGE** Remove visibility of unneeded InitiateBackup RPC ([commit 553e7b0](https://github.com/googleapis/google-cloud-dotnet/commit/553e7b098875151e4dd7d8afbf20a708064fc645))
- **BREAKING CHANGE** Remove visibility of unneeded AbandonBackup RPC ([commit 553e7b0](https://github.com/googleapis/google-cloud-dotnet/commit/553e7b098875151e4dd7d8afbf20a708064fc645))
- **BREAKING CHANGE** Remove visibility of unneeded FinalizeBackup RPC ([commit 553e7b0](https://github.com/googleapis/google-cloud-dotnet/commit/553e7b098875151e4dd7d8afbf20a708064fc645))
- **BREAKING CHANGE** Remove visibility of unneeded RemoveDataSource RPC ([commit 553e7b0](https://github.com/googleapis/google-cloud-dotnet/commit/553e7b098875151e4dd7d8afbf20a708064fc645))
- **BREAKING CHANGE** Remove visibility of unneeded SetInternalStatus RPC ([commit 553e7b0](https://github.com/googleapis/google-cloud-dotnet/commit/553e7b098875151e4dd7d8afbf20a708064fc645))

## Version 1.2.0, released 2024-09-26

### New features

- Client library for the backupvault api is added ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- Add backupplan proto ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- Add backupplanassociation proto ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- Add backupvault_ba proto ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- Add backupvault_gce proto ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))

### Documentation improvements

- A comment for field `oauth2_client_id` in message `.google.cloud.backupdr.v1.ManagementServer` is changed ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- A comment for field `parent` in message `.google.cloud.backupdr.v1.ListManagementServersRequest` is changed ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- A comment for field `management_servers` in message `.google.cloud.backupdr.v1.ListManagementServersResponse` is changed ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- A comment for field `name` in message `.google.cloud.backupdr.v1.GetManagementServerRequest` is changed ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- A comment for field `parent` in message `.google.cloud.backupdr.v1.CreateManagementServerRequest` is changed ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- A comment for field `requested_cancellation` in message `.google.cloud.backupdr.v1.OperationMetadata` is changed ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))

## Version 1.1.0, released 2024-06-24

### New features

- A new field `satisfies_pzs` is added ([commit 401cd38](https://github.com/googleapis/google-cloud-dotnet/commit/401cd38b79392a8e702bdd7718e99d69e26b5a8f))
- A new field `satisfies_pzi` is added ([commit 401cd38](https://github.com/googleapis/google-cloud-dotnet/commit/401cd38b79392a8e702bdd7718e99d69e26b5a8f))
- Updated documentation URI ([commit 401cd38](https://github.com/googleapis/google-cloud-dotnet/commit/401cd38b79392a8e702bdd7718e99d69e26b5a8f))
## Version 1.0.0, released 2024-05-24

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta02, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta01, released 2024-04-18

Initial release.
