# Version history

## Version 1.0.0-alpha12, released 2025-06-13

### New features

- Instance.ActivationPolicy field
- Cluster.DenyMaintenancePeriod field
- InstanceNetworkConfig.network output field
- InstanceNetworkConfig.allocated_ip_range_override field
- Backup.create_completion_time output field

### Documentation improvements

- A comment for field `earliest_restorable_time`
- A comment for field `status` in message `PscAutoConnectionConfig`

## Version 1.0.0-alpha11, released 2025-05-14

### New features

- Sync AlloyDB API changes from HEAD to stable
- Add new CSQL API for supporting Cluster creation from Cloud SQL
- Add new methods for exporting, importing and upgrade Cluster operations
- Add new fields to support observability configurations, machine types and PSC related configs
- Add CloudSQL support for RestoreCluster operation
- Add new fields and methods to the AlloyDB API
- Improve documentation of existing API fields
- Add GCA Entitlement type
- Add fields to PscInstanceConfig
- Add recommended_value and scope field to SupportedDatabaseFlags
- Make user optional in ExecuteSql API
- Add Import and Export functionalities
- Add machine_type field to instance config
- Add a new GCAEntitlement field in Gemini config
- Add the GCAInstanceConfig field in instance
- A new service `AlloyDBCSQLAdmin` is added
- A new message `RestoreFromCloudSQLRequest` is added
- A new enum `GCAEntitlementType` is added
- A new message `GCAInstanceConfig` is added
- A new field `machine_type` is added to message `.google.cloud.alloydb.v1alpha.Instance`
- A new field `assistive_experiences_enabled` is added to message `.google.cloud.alloydb.v1alpha.Instance`
- A new message `PscAutoConnectionConfig` is added
- A new field `psc_auto_connections` is added to message `.google.cloud.alloydb.v1alpha.Instance`
- A new field `gca_config` is added to message `.google.cloud.alloydb.v1alpha.Instance`
- A new enum `Scope` is added
- A new field `recommended_string_value` is added to message `.google.cloud.alloydb.v1alpha.SupportedDatabaseFlag`
- A new field `recommended_integer_value` is added to message `.google.cloud.alloydb.v1alpha.SupportedDatabaseFlag`
- A new field `scope` is added to message `.google.cloud.alloydb.v1alpha.SupportedDatabaseFlag`
- A new method `ExportCluster` is added to service `AlloyDBAdmin`
- A new method `ImportCluster` is added to service `AlloyDBAdmin`
- A new message `GcsDestination` is added
- A new message `ExportClusterRequest` is added
- A new message `ExportClusterResponse` is added
- A new message `ImportClusterRequest` is added
- A new message `ImportClusterResponse` is added
- A new field `scope` is added to message `.google.cloud.alloydb.v1alpha.ListSupportedDatabaseFlagsRequest`

### Documentation improvements

- A comment for field `encryption_config` in message `.google.cloud.alloydb.v1.AutomatedBackupPolicy` is changed
- A comment for field `encryption_config` in message `.google.cloud.alloydb.v1.ContinuousBackupConfig` is changed
- A comment for message `Instance` is changed
- A comment for field `zone_id` in message `.google.cloud.alloydb.v1.Instance` is changed
- A comment for field `id` in message `.google.cloud.alloydb.v1.Instance` is changed
- A comment for field `ip` in message `.google.cloud.alloydb.v1.Instance` is changed
- A comment for field `state` in message `.google.cloud.alloydb.v1.Instance` is changed
- A comment for field `database_flags` in message `.google.cloud.alloydb.v1.Instance` is changed
- A comment for field `user` in message `.google.cloud.alloydb.v1.ExecuteSqlRequest` is changed
- A comment for field `use_metadata_exchange` in message `.google.cloud.alloydb.v1.GenerateClientCertificateRequest` is changed
- A comment for field `requested_cancellation` in message `.google.cloud.alloydb.v1.OperationMetadata` is changed
- A comment for field `encryption_config` in message `.google.cloud.alloydb.v1beta.AutomatedBackupPolicy` is changed
- A comment for field `encryption_config` in message `.google.cloud.alloydb.v1beta.ContinuousBackupConfig` is changed
- A comment for message `Instance` is changed
- A comment for field `track_wait_event_types` in message `.google.cloud.alloydb.v1beta.Instance` is changed
- A comment for field `user` in message `.google.cloud.alloydb.v1beta.ExecuteSqlRequest` is changed
- A comment for field `use_metadata_exchange` in message `.google.cloud.alloydb.v1beta.GenerateClientCertificateRequest` is changed
- A comment for field `encryption_config` in message `.google.cloud.alloydb.v1alpha.AutomatedBackupPolicy` is changed
- A comment for field `encryption_config` in message `.google.cloud.alloydb.v1alpha.ContinuousBackupConfig` is changed
- A comment for message `Instance` is changed
- A comment for field `zone_id` in message `.google.cloud.alloydb.v1alpha.Instance` is changed
- A comment for field `id` in message `.google.cloud.alloydb.v1alpha.Instance` is changed
- A comment for field `ip` in message `.google.cloud.alloydb.v1alpha.Instance` is changed
- A comment for field `state` in message `.google.cloud.alloydb.v1alpha.Instance` is changed
- A comment for field `track_wait_event_types` in message `.google.cloud.alloydb.v1alpha.Instance` is changed
- A comment for field `database_flags` in message `.google.cloud.alloydb.v1alpha.Instance` is changed
- A comment for field `user` in message `.google.cloud.alloydb.v1alpha.ExecuteSqlRequest` is changed
- A comment for field `use_metadata_exchange` in message `.google.cloud.alloydb.v1alpha.GenerateClientCertificateRequest` is changed
- A comment for field `requested_cancellation` in message `.google.cloud.alloydb.v1alpha.OperationMetadata` is changed

## Version 1.0.0-alpha10, released 2024-11-18

### Bug fixes

- **BREAKING CHANGE** Deprecated various PSC instance configuration fields ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))

### New features

- Add new PSC instance configuration setting and output the PSC DNS name ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))
- Add new API to upgrade a cluster ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))
- Add new API to execute SQL statements ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))
- Add new cluster and instance level configurations to interact with Gemini ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))
- Add support for Free Trials ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))
- Add support to schedule maintenance ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))
- Additional field to set tags on a backup or cluster ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))
- Add more observability options on the Instance level ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))
- Add new API to perform a promotion or switchover on secondary instances ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))
- Add new CloudSQL backup resource ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))
- Support for obtaining the public ip addresses of an instance and enabling outbound public ip ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))
- Add optional field to keep extra roles on a user if it already exists ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))

### Documentation improvements

- Various typo fixes, correcting the formatting, and clarifications on the request_id and validate_only fields in API requests and on the page_size when listing the database ([commit dcf6b0d](https://github.com/googleapis/google-cloud-dotnet/commit/dcf6b0d4a8d7fcf440e0e44c84d5d4bed8a26d1f))

## Version 1.0.0-alpha09, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 1.0.0-alpha08, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-alpha07, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.0.0-alpha06, released 2024-02-27

### New features

- Support for obtaining the public IP address of an Instance ([commit 984260f](https://github.com/googleapis/google-cloud-dotnet/commit/984260f6f5ae6810095e86938cf65a0a780a1a20))
- Support for getting PSC DNS name from the GetConnectionInfo API ([commit 984260f](https://github.com/googleapis/google-cloud-dotnet/commit/984260f6f5ae6810095e86938cf65a0a780a1a20))

## Version 1.0.0-alpha05, released 2024-01-08

### New features

- Added PSC config, PSC interface config, PSC instance config ([commit 838504a](https://github.com/googleapis/google-cloud-dotnet/commit/838504a48905157e2ae8acfd328ed948b3f974b8))
- Added two boolean fields satisfies_pzi and satisfies_pzs ([commit 838504a](https://github.com/googleapis/google-cloud-dotnet/commit/838504a48905157e2ae8acfd328ed948b3f974b8))
- Added instance network config ([commit 838504a](https://github.com/googleapis/google-cloud-dotnet/commit/838504a48905157e2ae8acfd328ed948b3f974b8))
- Added ListDatabases API and Database object ([commit 838504a](https://github.com/googleapis/google-cloud-dotnet/commit/838504a48905157e2ae8acfd328ed948b3f974b8))
- Changed field network in NetworkConfig from required to optional ([commit 838504a](https://github.com/googleapis/google-cloud-dotnet/commit/838504a48905157e2ae8acfd328ed948b3f974b8))

### Documentation improvements

- Clarified read pool config is for read pool type instances ([commit 838504a](https://github.com/googleapis/google-cloud-dotnet/commit/838504a48905157e2ae8acfd328ed948b3f974b8))

## Version 1.0.0-alpha04, released 2023-09-25

### New features

- Added enum value for PG15 ([commit 92f51da](https://github.com/googleapis/google-cloud-dotnet/commit/92f51da889998ff8160a5bd778ff07d89d01f636))
- Deprecate network field in favor of network_config.network ([commit 92f51da](https://github.com/googleapis/google-cloud-dotnet/commit/92f51da889998ff8160a5bd778ff07d89d01f636))
- Added ClientConnectionConfig ([commit 92f51da](https://github.com/googleapis/google-cloud-dotnet/commit/92f51da889998ff8160a5bd778ff07d89d01f636))
- Added DatabaseVersion ([commit 92f51da](https://github.com/googleapis/google-cloud-dotnet/commit/92f51da889998ff8160a5bd778ff07d89d01f636))

## Version 1.0.0-alpha03, released 2023-07-25

### New features

- Add metadata exchange support for AlloyDB connectors ([commit 5bd7231](https://github.com/googleapis/google-cloud-dotnet/commit/5bd723164f63b63d9bd260ffd7a77b5ab29a1ac8))
- Adds metadata field describing an AlloyDB backup's quantity based retention ([commit 5bd7231](https://github.com/googleapis/google-cloud-dotnet/commit/5bd723164f63b63d9bd260ffd7a77b5ab29a1ac8))

## Version 1.0.0-alpha02, released 2023-06-20

### Bug fixes

- Deprecated SSL modes SSL_MODE_ALLOW, SSL_MODE_REQUIRE, SSL_MODE_VERIFY_CA ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))

### New features

- Added ClusterView supporting more granular view of continuous backups ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))
- Added new SSL modes ALLOW_UNENCRYPTED_AND_ENCRYPTED, ENCRYPTED_ONLY ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))
- Added users API ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))
- Added fault injection API ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))
- Added instance update policy ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))
- Added cluster network config ([commit 027919d](https://github.com/googleapis/google-cloud-dotnet/commit/027919d2b913857478708237864a70ac3ba92195))

### Documentation improvements

- Minor formatting in description of AvailabilityType ([commit 324516f](https://github.com/googleapis/google-cloud-dotnet/commit/324516f3b1e3284afeb1f18f265a89c592aea2ff))

## Version 1.0.0-alpha01, released 2023-03-01

Initial release.


