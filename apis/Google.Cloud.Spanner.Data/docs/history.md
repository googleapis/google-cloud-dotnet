# Version history

## Version 5.0.0, released 2025-04-16

### New features

Note: V5.0.0 contains all the new features added in previous beta versions V5.0.0-beta0x.
Here, we highlight those that introduced breaking changes with respect to previous stable versions V4.x.x.

- Transactions support SpannerTransactionCreationOptions and SpannerTransactionOptions.
  BREAKING CHANGE: SpannerConection methods that open a transaction, like BeginTransacion, Open and RunWithRetriableTransaction sets of methods now
accept both option types as parameter, while some of the previously existing methods have been deprecated and will be removed on the next major version.
- After a successfull commit or rollback, the transaction is disposed.
  BREAKING CHANGE: Attempting to use a disposed transaction will result in a client side error. See the Google.Cloud.Spanner.Data.SpannerTransaction.DisposeBehavior documentation for more information.
- Add support for FLOAT32
  BREAKING CHANGE: The default mapping for values of CLR type decimal was FLOAT64 and it is now Numeric.
The default mapping for values of CLR type float was FLOAT64 and it is now FLOAT32.
- Support inline transactions.
  BREAKING CHANGE: In supporting inline transactions the main breaking change is behavioral: transactions are not prewarmed, instead they are acquired
as needed, mainly through inlining transaction creation in the first command that attempts to use a transaction. The method
`Google.Cloud.Spanner.V1.PooledSession.WithFreshTransactionOrNewAsync` has been removed, as a transaction is not created by the session until command execution.
Use instead `Google.Cloud.Spanner.V1.PooledSession.RefreshedOrNewAsync` which returns a new PooledSession instance that either represents the same
session but with no transaction associated to it or a newly acquired session. Since transactions are not prewarmed, the session pool does not need
to distinguish between read-only and read-write session/transaction pairs. In the statistics classes that may be used for diagnostic purposes all
properties distinguishing between read-only and read-write statistics have been removed. Similarly, `Google.Cloud.Spanner.V1.SessionPoolOptions.WriteSessionsFraction`
has bee removed.
- BREAKING CHANGE: Remove Obsolete code that had been introduced before v5.0.0-beta01.

## Version 5.0.0-beta06, released 2025-04-14

### New features

- Support transaction tag through SpannerTransactionOptions. ([commit 382cdaf](https://github.com/googleapis/google-cloud-dotnet/commit/382cdafe378b20dc69fbb550eec47c35249ce038))
- Support commit priority through SpannerTransactionOptions. ([commit 12da3b6](https://github.com/googleapis/google-cloud-dotnet/commit/12da3b63ed2282a76b6369d394f89beb3a53fbc2))
- Support commit timeout through SpannerTransactionOptions. ([commit bf50e98](https://github.com/googleapis/google-cloud-dotnet/commit/bf50e98d4e7e0058a312716f14af4b5cd334b154))
- **BREAKING CHANGE** Make all transaction types support SpannerTransactionOptions ([commit 7e9f553](https://github.com/googleapis/google-cloud-dotnet/commit/7e9f553b0cd8bcfd53e456a9a6eab0e457877f35))
- Support log commit stats through SpannerTransactionOptions. ([commit d7251a3](https://github.com/googleapis/google-cloud-dotnet/commit/d7251a37adbaeeb224da97cc31385189534ad04d))
- Support transaction dispose behavior through SpannerTransactionOptions. ([commit 41e716a](https://github.com/googleapis/google-cloud-dotnet/commit/41e716a86b196c1eaf95e38845f238fc11475153))
- Add a last field in the PartialResultSet ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A new enum `IsolationLevel` is added ([commit c1059d1](https://github.com/googleapis/google-cloud-dotnet/commit/c1059d1638eeddd294d6a7fe92cb68343836b875))
- A new field `isolation_level` is added to message `.google.spanner.v1.TransactionOptions` ([commit c1059d1](https://github.com/googleapis/google-cloud-dotnet/commit/c1059d1638eeddd294d6a7fe92cb68343836b875))
- Add instance partitions field in backup proto ([commit 08930c5](https://github.com/googleapis/google-cloud-dotnet/commit/08930c554fcf973cf80a10b07b785f50bbdd574f))
- Add AddSplitPoints API ([commit adacd9b](https://github.com/googleapis/google-cloud-dotnet/commit/adacd9be4a6de29d8773132792f73c1155a5e2ae))
- Exposing InstanceType in Instance configuration (to define PROVISIONED or FREE spanner instance) ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- Exposing FreeInstanceMetadata in Instance configuration (to define the metadata related to FREE instance type) ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- Exposing storage_limit_per_processing_unit in InstanceConfig ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- Exposing QuorumType in InstanceConfig ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- Exposing FreeInstanceAvailability in InstanceConfig ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- Add UUID in Spanner TypeCode enum ([commit cacdc3b](https://github.com/googleapis/google-cloud-dotnet/commit/cacdc3b7f06949be2a642495e6b3265accfce0cf))
- Add the last statement option to ExecuteSqlRequest and ExecuteBatchDmlRequest ([commit 85f11dc](https://github.com/googleapis/google-cloud-dotnet/commit/85f11dcc5ca26b68edcf128c6f8f2f0170f24f8d))

### Documentation improvements

- A comment for field `rows` in message `.google.spanner.v1.ResultSet` is changed ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A comment for field `stats` in message `.google.spanner.v1.ResultSet` is changed ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A comment for field `precommit_token` in message `.google.spanner.v1.ResultSet` is changed ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A comment for field `values` in message `.google.spanner.v1.PartialResultSet` is changed ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A comment for field `chunked_value` in message `.google.spanner.v1.PartialResultSet` is changed ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A comment for field `stats` in message `.google.spanner.v1.PartialResultSet` is changed ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A comment for field `precommit_token` in message `.google.spanner.v1.PartialResultSet` is changed ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A comment for message `ResultSetMetadata` is changed ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A comment for field `row_type` in message `.google.spanner.v1.ResultSetMetadata` is changed ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A comment for message `ResultSetStats` is changed ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A comment for field `query_plan` in message `.google.spanner.v1.ResultSetStats` is changed ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A comment for field `row_count_lower_bound` in message `.google.spanner.v1.ResultSetStats` is changed ([commit 872c61a](https://github.com/googleapis/google-cloud-dotnet/commit/872c61a15c7152bc4db5d96176da5194175e869e))
- A comment for enum value `READ_LOCK_MODE_UNSPECIFIED` in enum `ReadLockMode` is changed ([commit c1059d1](https://github.com/googleapis/google-cloud-dotnet/commit/c1059d1638eeddd294d6a7fe92cb68343836b875))
- A comment for enum value `PESSIMISTIC` in enum `ReadLockMode` is changed ([commit c1059d1](https://github.com/googleapis/google-cloud-dotnet/commit/c1059d1638eeddd294d6a7fe92cb68343836b875))
- A comment for enum value `OPTIMISTIC` in enum `ReadLockMode` is changed ([commit c1059d1](https://github.com/googleapis/google-cloud-dotnet/commit/c1059d1638eeddd294d6a7fe92cb68343836b875))
- Fix typo timzeone -> timezone ([commit c1d4fff](https://github.com/googleapis/google-cloud-dotnet/commit/c1d4fff69ba777d2e68984bb2dfb44a16a9e84c6))
- A comment for method `ListInstanceConfigs` in service `InstanceAdmin` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for method `CreateInstanceConfig` in service `InstanceAdmin` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for method `UpdateInstanceConfig` in service `InstanceAdmin` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for method `ListInstanceConfigOperations` in service `InstanceAdmin` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for method `CreateInstance` in service `InstanceAdmin` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for method `UpdateInstance` in service `InstanceAdmin` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for method `CreateInstancePartition` in service `InstanceAdmin` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for method `UpdateInstancePartition` in service `InstanceAdmin` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for method `ListInstancePartitionOperations` in service `InstanceAdmin` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for method `MoveInstance` in service `InstanceAdmin` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `location` in message `.google.spanner.admin.instance.v1.ReplicaInfo` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for enum value `GOOGLE_MANAGED` in enum `Type` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for enum value `USER_MANAGED` in enum `Type` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `replicas` in message `.google.spanner.admin.instance.v1.InstanceConfig` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `optional_replicas` in message `.google.spanner.admin.instance.v1.InstanceConfig` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `base_config` in message `.google.spanner.admin.instance.v1.InstanceConfig` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `storage_utilization_percent` in message `.google.spanner.admin.instance.v1.AutoscalingConfig` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for enum `DefaultBackupScheduleType` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for enum value `NONE` in enum `DefaultBackupScheduleType` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for enum value `AUTOMATIC` in enum `DefaultBackupScheduleType` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `node_count` in message `.google.spanner.admin.instance.v1.Instance` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `processing_units` in message `.google.spanner.admin.instance.v1.Instance` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `default_backup_schedule_type` in message `.google.spanner.admin.instance.v1.Instance` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for message `CreateInstanceConfigRequest` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `instance_config` in message `.google.spanner.admin.instance.v1.CreateInstanceConfigRequest` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for message `UpdateInstanceConfigRequest` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for message `DeleteInstanceConfigRequest` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `filter` in message `.google.spanner.admin.instance.v1.ListInstanceConfigOperationsRequest` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `operations` in message `.google.spanner.admin.instance.v1.ListInstanceConfigOperationsResponse` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `node_count` in message `.google.spanner.admin.instance.v1.InstancePartition` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `processing_units` in message `.google.spanner.admin.instance.v1.InstancePartition` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `referencing_backups` in message `.google.spanner.admin.instance.v1.InstancePartition` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `parent` in message `.google.spanner.admin.instance.v1.ListInstancePartitionsRequest` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `unreachable` in message `.google.spanner.admin.instance.v1.ListInstancePartitionsResponse` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `filter` in message `.google.spanner.admin.instance.v1.ListInstancePartitionOperationsRequest` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `instance_partition_deadline` in message `.google.spanner.admin.instance.v1.ListInstancePartitionOperationsRequest` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))
- A comment for field `operations` in message `.google.spanner.admin.instance.v1.ListInstancePartitionOperationsResponse` is changed ([commit 1a75431](https://github.com/googleapis/google-cloud-dotnet/commit/1a754313d61d53f4518b029376e9bbde9a4c3c9f))

### Breaking changes

- All transaction types support SpannerTransactionOptions; this is breaking compared with previous betas, but not compared with previous GA.

## Version 5.0.0-beta05, released 2024-11-07

### New features

- Add support for Cloud Spanner Default Backup Schedules ([commit a456d8c](https://github.com/googleapis/google-cloud-dotnet/commit/a456d8cb3888c61360e3361bec4568c95807e312))
- Define ReplicaComputeCapacity and AsymmetricAutoscalingOption ([commit 905160d](https://github.com/googleapis/google-cloud-dotnet/commit/905160d71ca8d4eeaabd5373ec2600efcd64a108))
- Add new QueryMode enum values (WITH_STATS, WITH_PLAN_AND_STATS) ([commit 16d3bbb](https://github.com/googleapis/google-cloud-dotnet/commit/16d3bbbdce35809697b8e47338cbd3369b5f8865))
- Add INTERVAL API ([commit 9f9efe6](https://github.com/googleapis/google-cloud-dotnet/commit/9f9efe6dc4ff1ec59ac506585e26c0a40ce75552))

### Documentation improvements

- A comment for field `node_count` in message `spanner.admin.instance.v1.Instance` is changed ([commit 905160d](https://github.com/googleapis/google-cloud-dotnet/commit/905160d71ca8d4eeaabd5373ec2600efcd64a108))
- A comment for field `processing_units` in message `spanner.admin.instance.v1.Instance` is changed ([commit 905160d](https://github.com/googleapis/google-cloud-dotnet/commit/905160d71ca8d4eeaabd5373ec2600efcd64a108))
- Update comment for PROFILE QueryMode ([commit 16d3bbb](https://github.com/googleapis/google-cloud-dotnet/commit/16d3bbbdce35809697b8e47338cbd3369b5f8865))

## Version 5.0.0-beta04, released 2024-08-13

### Bug fixes

- Retriable transactions should be released after successful commit ([commit f2c7840](https://github.com/googleapis/google-cloud-dotnet/commit/f2c78404d6d1ee99bcaef082c8bf925ba98c4f47))
- Partitioned updates are only executed on an ephemeral transaction ([commit d88a807](https://github.com/googleapis/google-cloud-dotnet/commit/d88a80788f89e6d74a96c506718769c88dd1a05d))
- Timestamp bound reads and queries are only executed on an ephemeral transaction ([commit f8f8235](https://github.com/googleapis/google-cloud-dotnet/commit/f8f8235bff3ecd1e7dc063827bbf974415cee9cd))

### New features

- Add resource reference annotation to backup schedules ([commit 8403eb4](https://github.com/googleapis/google-cloud-dotnet/commit/8403eb449930743ba57bb941bf9d329ab243051e))
- Add edition field to the instance proto ([commit 2b59065](https://github.com/googleapis/google-cloud-dotnet/commit/2b590658f970c1eea63b665277fd0b42220daac1))
- **BREAKING CHANGE** Fully support SpannerTransactionCreationOptoins ([commit 34a25d3](https://github.com/googleapis/google-cloud-dotnet/commit/34a25d3ad1f828fe8a525edf65b10a0ea2b7916e))
- Support excluding a transaction from change streams ([commit 9e3ec98](https://github.com/googleapis/google-cloud-dotnet/commit/9e3ec986e54d0d0a8a74351fd671f7596437a2e0))
- Add protobuf column support for the data layer ([commit 8646000](https://github.com/googleapis/google-cloud-dotnet/commit/8646000144c4e661a4a0b0d18b16765cbd18429c))
- Add support for protobuf typed colums for DDL ([commit 551d519](https://github.com/googleapis/google-cloud-dotnet/commit/551d519f3088310272cb0380c51a0bb3f2bc1140))
- Add support for Cloud Spanner Incremental Backups ([commit aa5a584](https://github.com/googleapis/google-cloud-dotnet/commit/aa5a584c2d0b704d5c50164c3ab5e76147b9efd1))
- Add support for Cloud Spanner Scheduled Backups ([commit ac15c11](https://github.com/googleapis/google-cloud-dotnet/commit/ac15c11c2a4c1d4b77510556ff863079ac5567f0))
- **BREAKING CHANGE** Commit/Rollback releases sessions to the pool ([commit 86fa6a6](https://github.com/googleapis/google-cloud-dotnet/commit/86fa6a69c8732be25cc7c95b567ab4f358f76007))
- **BREAKING CHANGE** Support detached sessions/transactions ([commit cfa961e](https://github.com/googleapis/google-cloud-dotnet/commit/cfa961e9bf2a8987c4573afa9815d99295c6eb2c))
- Add field order_by in spanner.proto ([commit a5f7b22](https://github.com/googleapis/google-cloud-dotnet/commit/a5f7b229a89681c1a884fc8ee72d6835882353da))
- Add field lock_hint in spanner.proto ([commit a5f7b22](https://github.com/googleapis/google-cloud-dotnet/commit/a5f7b229a89681c1a884fc8ee72d6835882353da))
- Add support for multi region encryption config ([commit bb95bbf](https://github.com/googleapis/google-cloud-dotnet/commit/bb95bbf3c64499e17a4dcfc27fa6e6a789e5cb79))
- Add `RESOURCE_EXHAUSTED` to the list of retryable error codes ([commit fbb0099](https://github.com/googleapis/google-cloud-dotnet/commit/fbb0099a03371b08c194e2fada0ca63bd98fec00))
- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

### Documentation improvements

- Add an example to filter backups based on schedule name ([commit 8403eb4](https://github.com/googleapis/google-cloud-dotnet/commit/8403eb449930743ba57bb941bf9d329ab243051e))
- Clarify documentation around session acquisition vs. transaction creation ([commit 9aae25e](https://github.com/googleapis/google-cloud-dotnet/commit/9aae25e896a9034845142792de2df69e55b6105b))
- Fix linting for several doc comments ([commit bb95bbf](https://github.com/googleapis/google-cloud-dotnet/commit/bb95bbf3c64499e17a4dcfc27fa6e6a789e5cb79))

### Breaking changes

- Some SpannerConnection begin transaction methods that had only been released in beta versions of the library have been removed. ([commit 34a25d3](https://github.com/googleapis/google-cloud-dotnet/commit/34a25d3ad1f828fe8a525edf65b10a0ea2b7916e))
- The AmbientTransactionOptions class is split in SpannerTransactionCreationOptions and SpannerTransactionOptions, with all original options moving to one or the other. The SpannerConnection.Open set of methods that received an AmbientTransactionOptions before now receive one SpannerTransactionCreationOptions and one SpannerTransactionOptions. ([commit 1541b99](https://github.com/googleapis/google-cloud-dotnet/commit/1541b99ee7b835b27d9329d91a2477b8461d739a))
- After a successfull commit or rollback, the transaction is disposed and may not be used again. See the Google.Cloud.Spanner.Data.SpannerTransaction.DisposeBehavior documentation for more information. ([commit 86fa6a6](https://github.com/googleapis/google-cloud-dotnet/commit/86fa6a69c8732be25cc7c95b567ab4f358f76007))

## Version 5.0.0-beta03, released 2024-04-19

### New features

- Add support for FLOAT32 ([commit 83700dd](https://github.com/googleapis/google-cloud-dotnet/commit/83700dd7c2b05bb3b598ecb7fe43de255cd5fdc8))

### Breaking changes

- The default mapping for values of CLR type decimal was FLOAT64 and it is now Numeric. ([commit 9824a9c](https://github.com/googleapis/google-cloud-dotnet/commit/9824a9c3580e79e95a7bed5af12bcdb15ffbe4cc))
- The default mapping for values of CLR type float was FLOAT64 and it is now FLOAT32. ([commit 83700dd](https://github.com/googleapis/google-cloud-dotnet/commit/83700dd7c2b05bb3b598ecb7fe43de255cd5fdc8))
- Support for specifying a maximum commit delay was added in v5.0.0-beta02. Unfortunately properties and methods for this feature were erroneously named using "commit delay" instead of "max commit delay". All such names are being corrected in this commit. ([commit 03e66d7](https://github.com/googleapis/google-cloud-dotnet/commit/03e66d73b165fe10f945924f5e70498d378042d2))
- Remove Obsolete code that had been introduced before v5.0.0-beta01. ([commit fdc4bff](https://github.com/googleapis/google-cloud-dotnet/commit/fdc4bff6a932d39e8d6c51f9efad040e427face8))

## Version 5.0.0-beta02, released 2024-04-04

### New features

- Ambient transactions support commit delays ([commit f4b4208](https://github.com/googleapis/google-cloud-dotnet/commit/f4b4208eb3d9b1ef9ce1c984d57e920c7ce0b5f1))
- Implicit transactions support commit delay ([commit af15aaf](https://github.com/googleapis/google-cloud-dotnet/commit/af15aafce40ac46d20256cec0b47ca965c51a6e2))
- Explicit transactions support commit delays ([commit 4934cfd](https://github.com/googleapis/google-cloud-dotnet/commit/4934cfd23e0d02376a1950bd825f72e1b388fc20))
- Adding `EXPECTED_FULFILLMENT_PERIOD` to the indicate instance creation times (with `FULFILLMENT_PERIOD_NORMAL` or `FULFILLMENT_PERIOD_EXTENDED` ENUM) with the extended instance creation time triggered by On-Demand Capacity Feature ([commit 20bb7e7](https://github.com/googleapis/google-cloud-dotnet/commit/20bb7e736ffbcff1d9eb4f77cc5bea000d295fdc))
- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))
- SpannerCommand supports directed reads ([commit dfeb2c0](https://github.com/googleapis/google-cloud-dotnet/commit/dfeb2c0de7889679320ffa71ef99b114511a7fbb))
- SpannerConnection supports directed reads ([commit d7620e5](https://github.com/googleapis/google-cloud-dotnet/commit/d7620e524a3173904e4bb298615b16c2f7d13d8a))
- PooledSession supports directed reads ([commit e26c8aa](https://github.com/googleapis/google-cloud-dotnet/commit/e26c8aab85cac8ab3bd1d9c9e286b706a43a2ec4))
- Add PG.OID support ([commit 43818f3](https://github.com/googleapis/google-cloud-dotnet/commit/43818f3ccb9943ec83d84f3c300505cd58073532))
- Update TransactionOptions to include new option exclude_txn_from_change_streams ([commit 89764a0](https://github.com/googleapis/google-cloud-dotnet/commit/89764a08f8fe1133bee9f89ef6fd02b8d5ce8f1d))
- Add field for multiplexed session in spanner.proto ([commit 4bdb639](https://github.com/googleapis/google-cloud-dotnet/commit/4bdb639fe97f720a42f55305e40f6c355f109914))

### Documentation improvements

- Fix typo ([commit ce1be02](https://github.com/googleapis/google-cloud-dotnet/commit/ce1be0278bed346a12533f0f00c85588f3454136))
- Update comments ([commit 4bdb639](https://github.com/googleapis/google-cloud-dotnet/commit/4bdb639fe97f720a42f55305e40f6c355f109914))

### Other changes

- Deprecate ambient transaction creation overloads ([commit 50f5f65](https://github.com/googleapis/google-cloud-dotnet/commit/50f5f654eb122e06fc0e0c25fcd089c2bbfac681))

(This isn't a breaking change unless code is compiled with warnings as errors, but we do expect to remove these methods entirely in v6.0 of this library.)

## Version 5.0.0-beta01, released 2024-02-09

### Bug fixes

- Have SpannerTransaction check if it has been disposed before executing commands. ([commit c97a70a](https://github.com/googleapis/google-cloud-dotnet/commit/c97a70adaf559f68b7b980bd018485d99fa080a7))

### New features

- Add leader routing support. ([commit eb2157a](https://github.com/googleapis/google-cloud-dotnet/commit/eb2157ac35bff3f4424bc443b2067474755bf26c))
- Add FLOAT32 enum to TypeCode ([commit 18e6491](https://github.com/googleapis/google-cloud-dotnet/commit/18e6491b92ee1042550bb20632acf14be52e43c0))
- Add proto descriptors for proto and enum types in create/update/get database ddl requests ([commit 7085e3f](https://github.com/googleapis/google-cloud-dotnet/commit/7085e3fb785d8cd342145c716a80680ab5e1b98a))
- Add max_commit_delay API ([commit 3984609](https://github.com/googleapis/google-cloud-dotnet/commit/39846090bcb63a4608f378ab340b0384bd7d892e))
- Add proto and enum types ([commit ea75989](https://github.com/googleapis/google-cloud-dotnet/commit/ea7598963d2967bed059c897973a9e62544442d8))
- **BREAKING CHANGE** Support inline transactions. ([#11360](https://github.com/googleapis/google-cloud-dotnet/pull/11360))
- Add directed_read_option in spanner.proto ([commit 3b374e0](https://github.com/googleapis/google-cloud-dotnet/commit/3b374e03f91e267ad2ed52fdb5814d4be95c2ae6))
- Add PG.OID type cod annotation ([commit a8662dc](https://github.com/googleapis/google-cloud-dotnet/commit/a8662dc1e7153f5657f64860396d3504c14cb7a0))
- Add autoscaling config to the instance proto ([commit 07022a6](https://github.com/googleapis/google-cloud-dotnet/commit/07022a6249358c9dba35fbedebc44068e86413f0))
- Add BatchWrite API ([commit 7a127d0](https://github.com/googleapis/google-cloud-dotnet/commit/7a127d0b59cb7a86bb4b14e489ad0f1ba2b70455))

### Documentation improvements

- Update the comment regarding eligible SQL shapes for PartitionQuery ([commit 1eb3d3e](https://github.com/googleapis/google-cloud-dotnet/commit/1eb3d3eca7d973633374f4e6cd56fe4a60995a63))
- Updated comment formatting ([commit 3b374e0](https://github.com/googleapis/google-cloud-dotnet/commit/3b374e03f91e267ad2ed52fdb5814d4be95c2ae6))

BREAKING CHANGE: In supporting inline transactions the main breaking change is behavioral: transactions are not prewarmed, instead they are acquired
as needed, mainly through inlining transaction creation in the first command that attempts to use a transaction. The method
`Google.Cloud.Spanner.V1.PooledSession.WithFreshTransactionOrNewAsync` has been removed, as a transaction is not created by the session until command execution.
Use instead `Google.Cloud.Spanner.V1.PooledSession.RefreshedOrNewAsync` which returns a new PooledSession instance that either represents the same
session but with no transaction associated to it or a newly acquired session. Since transactions are not prewarmed, the session pool does not need
to distinguish between read-only and read-write session/transaction pairs. In the statistics classes that may be used for diagnostic purposes all
properties distinguishing between read-only and read-write statistics have been removed. Similarly, `Google.Cloud.Spanner.V1.SessionPoolOptions.WriteSessionsFraction`
has bee removed.

## Version 4.6.0, released 2023-06-26

### Bug fixes

- Makes transactions marked as DisposedBehaviour.Detach actually detach from the session pool. ([commit ab7526f](https://github.com/googleapis/google-cloud-dotnet/commit/ab7526f4d8fed91a5913c0558cfe2bf60516feba))
- Dispose result streams ([commit d92f88e](https://github.com/googleapis/google-cloud-dotnet/commit/d92f88e681ef91fd92d7155cadf515a0cdfbad78))

### New features

- Support `dataBoostEnabled` field in partitioned read and execute SQL operations. ([commit 25531f2](https://github.com/googleapis/google-cloud-dotnet/commit/25531f25d938b5f680059059d34a72654393c71e))
- Add DdlStatementActionInfo and add actions to UpdateDatabaseDdlMetadata ([commit 2bdd8bc](https://github.com/googleapis/google-cloud-dotnet/commit/2bdd8bc563477f49203bb78b41a744e696f40e3b))
- Add support for UpdateDatabase in Cloud Spanner ([commit 3b98d26](https://github.com/googleapis/google-cloud-dotnet/commit/3b98d2699a164b0ad4ee775c96c4c3b2b4598ecb))

### Documentation improvements

- Improvements on DataBoostEnabled docs. ([commit 5791342](https://github.com/googleapis/google-cloud-dotnet/commit/5791342c544ecb49039457e76a9220c36c9f7957))

## Version 4.5.0, released 2023-05-04

### New features

- Introduce data_boost_enabled; this is currently not exposed via Google.Cloud.Spanner.Data ([commit 983fbe6](https://github.com/googleapis/google-cloud-dotnet/commit/983fbe610e7ef79eb447d970aa28e1944feee833))

### Documentation improvements

- Formatting fix for the logging documentation

## Version 4.4.0, released 2023-03-09

### New features

- ExecuteQuery can now execute DML, returning data from affected rows ([issue 10013](https://github.com/googleapis/google-cloud-dotnet/issues/10013)) ([commit 4787593](https://github.com/googleapis/google-cloud-dotnet/commit/478759345e388cc6ce4710605736570839be224d))

## Version 4.3.0, released 2023-02-08

### New features

- Enable REST transport in C# ([commit f6a1c3e](https://github.com/googleapis/google-cloud-dotnet/commit/f6a1c3e8930f0e8209a079352765be3bb9039be2))
- Exposed RpcException property to SpannerException ([issue 9527](https://github.com/googleapis/google-cloud-dotnet/issues/9527)) ([commit 4c96a04](https://github.com/googleapis/google-cloud-dotnet/commit/4c96a040d4fb77e66368c5cb3fb786e4d97f8570))

## Version 4.2.0, released 2022-11-03

### Bug fixes

- Fix SpannerConnectionStringBuilder.ConnectionString handling of conversion options. Fixes [issue 9158](https://github.com/googleapis/google-cloud-dotnet/issues/9158) ([commit 92ba08b](https://github.com/googleapis/google-cloud-dotnet/commit/92ba08b9e7f28a7242609fd5c4d6db744ea7953a))

### New features

- Update transaction.proto to include different lock modes ([issue 9236](https://github.com/googleapis/google-cloud-dotnet/issues/9236)) ([commit 4fed510](https://github.com/googleapis/google-cloud-dotnet/commit/4fed510395e50548dc05d7198b5e09ac94860bb3))
- Add support for FGAC  in Spanner ([commit 4e7eddb](https://github.com/googleapis/google-cloud-dotnet/commit/4e7eddbc06b14e84869fc8235a4831aa594d8783))
- Update result_set.proto to return undeclared parameters in ExecuteSql API ([commit cb86746](https://github.com/googleapis/google-cloud-dotnet/commit/cb867464b49a6fcf88531667fec74409b426d8b7))
- Support dependency injection of SpannerConnection ([commit f29a7f9](https://github.com/googleapis/google-cloud-dotnet/commit/f29a7f943ebcccedea7f573e39061dd7aad36101))
- Support custom GoogleCredential in SpannerConnectionStringBuilder/SpannerConnection ([commit 898d3b3](https://github.com/googleapis/google-cloud-dotnet/commit/898d3b3937a20ac0b5c471db6044681933255283))
- Added support for JSONB type in the PostgreSQL dialect. Note that JSONB arrays are not supported server-side yet.

## Version 4.1.0, released 2022-09-20

### New features

- Add custom instance config operations ([commit 58cadb7](https://github.com/googleapis/google-cloud-dotnet/commit/58cadb75ce7df48e18fc7c26e9dbe45e0f2eb128))
- Adds auto-generated CL for googleapis for jsonb ([commit b8b8752](https://github.com/googleapis/google-cloud-dotnet/commit/b8b875219dfa03dcdee429156698194764bd6026))
- Add ListDatabaseRoles API to support role based access control ([commit 98e2aae](https://github.com/googleapis/google-cloud-dotnet/commit/98e2aae9c7fc7b8ce08ff38597baf2f4ef0d4dc3))
- Adding two new fields for Instance create_time and update_time ([commit d002223](https://github.com/googleapis/google-cloud-dotnet/commit/d00222363fbcf7bdaaa6c35b218a9757fd1ef603))

## Version 4.0.0, released 2022-06-22

First GA release of v4.0. Please see release notes for 4.0.0-beta01 and 4.0.0-beta02 for details of breaking changes since v3.x

### Bug fixes

- Fix ToDecimal truncation for SpannerNumeric. ([commit 2be4686](https://github.com/googleapis/google-cloud-dotnet/commit/2be4686f77e94f03a8198490769c40da41166ad2))
- Fixes ToDecimal truncation for PgNumeric. ([commit 3ff15fb](https://github.com/googleapis/google-cloud-dotnet/commit/3ff15fb663ec9d1f7b2b3eef796d910d8767c673))

## Version 4.0.0-beta02, released 2022-06-13

### New features

- Add connection string options support to Keys ([commit 65920aa](https://github.com/googleapis/google-cloud-dotnet/commit/65920aa1e6f44751ebe5295b99cdd63b5763a503))

BREAKING CHANGE: The Key classes (Key, KeyRange, KeySet) used to be
immutable, and support equality as well as overriding ToString. As
conversions from CLR to Spanner values now depend on the connection
string, there's now an overload for ToString accepting a
ConnectioStringBuilder, but no support for equality. We don't
anticipate this breaking customers except perhaps for testing
purposes.

## Version 4.0.0-beta01, released 2022-06-09

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

### New features

- Add an adapter for an ILogger to a Spanner Logger ([commit 5b7556b](https://github.com/googleapis/google-cloud-dotnet/commit/5b7556b84be5e708d6ae69ace2e32e2299ef2ae1))
  - This is an interim step to allow logs to be easily unified (to ILogger) before we eventually remove the Spanner internal logging system entirely.
- Use self-signed JWTs in Spanner clients ([commit d465906](https://github.com/googleapis/google-cloud-dotnet/commit/d465906a562719eb4d0ddb8574110cf47ffc71ca))
- Add Session creator role ([commit ffa9c84](https://github.com/googleapis/google-cloud-dotnet/commit/ffa9c8456626be0270836428b7ff19408e8c9d2d))
- Allow default conversions between Spanner and the CLR to be specified via connection string options

### Documentation improvements

- Clarify transaction semantics ([commit ffa9c84](https://github.com/googleapis/google-cloud-dotnet/commit/ffa9c8456626be0270836428b7ff19408e8c9d2d))

## Version 3.15.1, released 2022-05-05

### Bug fixes

- Make SpannerTransaction pick up SpannerConnection.LogCommitStats as documented. ([commit db5c55d](https://github.com/googleapis/google-cloud-dotnet/commit/db5c55d16cc4fc1dfd33db8dcb949b86861b1507))

## Version 3.15.0, released 2022-05-04

### New features

- Make ephemeral transactions retry on abort. ([commit 97faf1c](https://github.com/googleapis/google-cloud-dotnet/commit/97faf1c96266fc0e7d45706a4c29acc7d63b43ff))
- Introduced `SpannerDate` struct for date-only values. (The default type for `DATE` columns is still `DateTime`.) ([commit 4e3b94e](https://github.com/googleapis/google-cloud-dotnet/commit/4e3b94e66a2776b6eefbefb69f5e7769cff8f794))
- Introduced `PgNumeric` struct for support of the `NUMERIC` data type in the Postgres dialect. ([commit 87c3306](https://github.com/googleapis/google-cloud-dotnet/commit/87c330666cc096085f8cfa2e1e5b2cacb25e3585))

## Version 3.14.0, released 2022-03-28

### New features

- Add database dialect to Admin Database API ([commit 721f908](https://github.com/googleapis/google-cloud-dotnet/commit/721f9089a32b60f10ce480ce0addfd78d5d04205))
- Add database dialect to Spanner V1 API ([commit d345d55](https://github.com/googleapis/google-cloud-dotnet/commit/d345d5501563547779681bdbb4f8dd1556225e82))
- Add support for cross-region backup ([commit 599f0a3](https://github.com/googleapis/google-cloud-dotnet/commit/599f0a3da71552c40e8a310b364d448b08769e5f))

## Version 3.13.0, released 2021-12-01

- [Commit 02b16d7](https://github.com/googleapis/google-cloud-dotnet/commit/02b16d7): fix: clone each SpannerParameter when cloning a parameter collection
- [Commit c653720](https://github.com/googleapis/google-cloud-dotnet/commit/c653720): feat: add support for DataReader.GetBytes ([issue 7395](https://github.com/googleapis/google-cloud-dotnet/issues/7395))
- [Commit 9bc116d](https://github.com/googleapis/google-cloud-dotnet/commit/9bc116d): fix: allow setting parameter size to the same as the current value ([issue 7401](https://github.com/googleapis/google-cloud-dotnet/issues/7401))
- [Commit 0666123](https://github.com/googleapis/google-cloud-dotnet/commit/0666123): feat: Spanner Read API

## Version 3.12.0, released 2021-08-24

- [Commit 7c6a6f1](https://github.com/googleapis/google-cloud-dotnet/commit/7c6a6f1): feat: add support for JSON data type in Spanner ([issue 6390](https://github.com/googleapis/google-cloud-dotnet/issues/6390))
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs
- [Commit 61938b6](https://github.com/googleapis/google-cloud-dotnet/commit/61938b6):
  - feat(Spanner): Support comments and statement hints in untyped commands.
  - Alternative to [issue 6848](https://github.com/googleapis/google-cloud-dotnet/issues/6848)
  - Closes [issue 6847](https://github.com/googleapis/google-cloud-dotnet/issues/6847)
- [Commit d26b04c](https://github.com/googleapis/google-cloud-dotnet/commit/d26b04c): fix: address review comments
- [Commit d2025be](https://github.com/googleapis/google-cloud-dotnet/commit/d2025be): fix: use logger from SpannerSettings
- [Commit b34f6f4](https://github.com/googleapis/google-cloud-dotnet/commit/b34f6f4): cleanup: fix comment + remove unnecessary import
- [Commit fc7a41b](https://github.com/googleapis/google-cloud-dotnet/commit/fc7a41b): test: remove connectionstring tests and add settings test
- [Commit 6016ef0](https://github.com/googleapis/google-cloud-dotnet/commit/6016ef0):
  - feat: support custom SpannerSettings in SessionPoolManager
  - Support setting custom SpannerSettings when creating a SessionPoolManager.
- [Commit 0ab6b8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ab6b8b):
  - feat: allow adding an additional version header
  - Allows adding an additional version header to the connection string. This will be
  - added to the `x-goog-api-client` header that is used by the underlying Spanner client.
  - Only a fixed set of values may be set for the header (currently only 'efcore' is
  - allowed), and the property is not intended for public use.
- [Commit 250124f](https://github.com/googleapis/google-cloud-dotnet/commit/250124f):
  - fix: synchronize access to the underlying transaction for ambient transactions ([issue 6616](https://github.com/googleapis/google-cloud-dotnet/issues/6616))
  - * fix: synchronize access to the underlying transaction for ambient transactions
  - Synchronizes access to the underlying Spanner transaction to prevent
  - multiple transactions from being created if parallel commands are
  - executed on the ambient transaction.
  - * test: add integration test
  - * fix: use Lazy for initialization
  - * chore: address review comments
  - * fix: remove unnecessary read call

## Version 3.11.0, released 2021-07-09

- [Commit 9dc6f8b](https://github.com/googleapis/google-cloud-dotnet/commit/9dc6f8b): feat(spanner): add leader_options to InstanceConfig
- [Commit e59ffc5](https://github.com/googleapis/google-cloud-dotnet/commit/e59ffc5): feat(spanner): add default_leader to Database

## Version 3.10.0, released 2021-06-28

- [Commit 10c86e0](https://github.com/googleapis/google-cloud-dotnet/commit/10c86e0): feat: add JSON type (currently only in the low-level API)
- [Commit 41094ed](https://github.com/googleapis/google-cloud-dotnet/commit/41094ed): feat: add processing_units to Instance resource

## Version 3.9.0, released 2021-06-09

- [Commit 0fb438e](https://github.com/googleapis/google-cloud-dotnet/commit/0fb438e): feat: add `query_optimizer_statistics_package` support (see below)

The optimizer statistics package can be set through `QueryOptions`, which can be configured through the following mechanisms:

- At the `SpannerConnection` level.
- Through the `SPANNER_OPTIMIZER_STATISTICS_PACKAGE` environment variable.
- At a query level.

If the options are configured through multiple mechanisms then:

- Options set at an environment variable level will override options configured at the `SpannerConnection` level.
- Options set at a query-level will override options set at either the `SpannerConnection` or environment variable level.

If no options are set, the optimizer statistics package will default
to the package the database is pinned to. If the database is not
pinned to a specific package, then the Cloud Spanner backend will
use the "latest" version.

## Version 3.8.0, released 2021-05-18

- [Commit a334723](https://github.com/googleapis/google-cloud-dotnet/commit/a334723): feat: add option to return read timestamp
- [Commit fbcacf0](https://github.com/googleapis/google-cloud-dotnet/commit/fbcacf0): fix: Use CopySettingsForEmulator in Spanner clients
- [Commit 4371842](https://github.com/googleapis/google-cloud-dotnet/commit/4371842): feat: add `progress` field to `UpdateDatabaseDdlMetadata`
- [Commit 5eef4b4](https://github.com/googleapis/google-cloud-dotnet/commit/5eef4b4): feat: add `progress` field to `UpdateDatabaseDdlMetadata`
- [Commit 9f5f0aa](https://github.com/googleapis/google-cloud-dotnet/commit/9f5f0aa): fix: Regenerate server-streaming calls with Google request params

## Version 3.7.0, released 2021-04-01

- [Commit 63f54b5](https://github.com/googleapis/google-cloud-dotnet/commit/63f54b5): feat: add support for request and transaction tagging
- [Commit a7d1b22](https://github.com/googleapis/google-cloud-dotnet/commit/a7d1b22): feat: add support for RPC priority
- [Commit b40ca4e](https://github.com/googleapis/google-cloud-dotnet/commit/b40ca4e): feat: add tagging request options (proto)
- [Commit ec9fd53](https://github.com/googleapis/google-cloud-dotnet/commit/ec9fd53): feat: add RPC Priority request options (proto)

## Version 3.6.0, released 2021-03-17

- [Commit 69c83e4](https://github.com/googleapis/google-cloud-dotnet/commit/69c83e4):
  - fix: retry errors in stream until timeout ([issue 6013](https://github.com/googleapis/google-cloud-dotnet/issues/6013))
  - Also fixes [issue 5977](https://github.com/googleapis/google-cloud-dotnet/issues/5977)
- [Commit fa5641d](https://github.com/googleapis/google-cloud-dotnet/commit/fa5641d): fix: retry consecutive retryable errors in sql stream. Fixes [issue 5977](https://github.com/googleapis/google-cloud-dotnet/issues/5977)
- [Commit a86b6ea](https://github.com/googleapis/google-cloud-dotnet/commit/a86b6ea): feat: add `optimizer_statistics_package` field in `QueryOptions`
- [Commit ef02e74](https://github.com/googleapis/google-cloud-dotnet/commit/ef02e74): feat: add CMEK fields to backup and database

## Version 3.5.0, released 2021-02-08

- [Commit d5abc62](https://github.com/googleapis/google-cloud-dotnet/commit/d5abc62): feat: add Point In Time Recovery (PITR) support
- [Commit 65f6e7b](https://github.com/googleapis/google-cloud-dotnet/commit/65f6e7b):
  - feat: log CommitStats if requested by the client application ([issue 5506](https://github.com/googleapis/google-cloud-dotnet/issues/5506))
- [Commit 8562ced](https://github.com/googleapis/google-cloud-dotnet/commit/8562ced): fix: use null instead of empty array + integration test
- [Commit 0343ff8](https://github.com/googleapis/google-cloud-dotnet/commit/0343ff8):
  - fix: parse WITH command as SELECT. Fixes [issue 5857](https://github.com/googleapis/google-cloud-dotnet/issues/5857)
- [Commit 4866adf](https://github.com/googleapis/google-cloud-dotnet/commit/4866adf): fix: NUMERIC is missing default mapping
- [Commit a223bd0](https://github.com/googleapis/google-cloud-dotnet/commit/a223bd0): fix: local date could lead to wrong date in database

## Version 3.4.0, released 2020-12-14

- [Commit 9fb3e43](https://github.com/googleapis/google-cloud-dotnet/commit/9fb3e43): feat: Database Admin: Adds UpdateDatabaseDdlMetadata.Throttled to indicate when a DDL operation is throttled due to resource constraints.

## Version 3.3.0, released 2020-10-01

- [Commit 9d984c8](https://github.com/googleapis/google-cloud-dotnet/commit/9d984c8): fix: Trust SpannerClientCreationOptions to connect to the emulator. Fixes [issue 5362](https://github.com/googleapis/google-cloud-dotnet/issues/5362).

## Version 3.2.0, released 2020-09-10

- [Commit 0272d4e](https://github.com/googleapis/google-cloud-dotnet/commit/0272d4e): fix: retry PDML on EOS on DATA error ([issue 5238](https://github.com/googleapis/google-cloud-dotnet/issues/5238))
- [Commit b43315c](https://github.com/googleapis/google-cloud-dotnet/commit/b43315c): feat: add NUMERIC support ([issue 5057](https://github.com/googleapis/google-cloud-dotnet/issues/5057))

## Version 3.1.0, released 2020-07-14

- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): Regenerate all APIs with service comments in client documentation
- [Commit 2db277b](https://github.com/googleapis/google-cloud-dotnet/commit/2db277b):
  - Improvements to GetOrdinal behavior
  - Fixes [issue 5114](https://github.com/googleapis/google-cloud-dotnet/issues/5114)
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): Regenerate APIs with timeouts for RPCs that don't have retries

## Version 3.1.0-beta01, released 2020-06-16

- [Commit 5b07f5a](https://github.com/googleapis/google-cloud-dotnet/commit/5b07f5a): fix: Roll back uncommitted (and not-rolled-back) read/write transactions on session release
- [Commit 7de296c](https://github.com/googleapis/google-cloud-dotnet/commit/7de296c): fix: Workaround for emulator bug of not populating ExecuteBatchDmlResponse.status
- [Commit a4455b9](https://github.com/googleapis/google-cloud-dotnet/commit/a4455b9): feat: Spanner emulator support in Google.Cloud.Spanner.Data
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): fix: Regenerate all clients with more explicit documentation
- [Commit 0b01e4b](https://github.com/googleapis/google-cloud-dotnet/commit/0b01e4b): feat: add support for spanner emulator detection in clients ([issue 4928](https://github.com/googleapis/google-cloud-dotnet/issues/4928))

Note that while the `SpannerNumeric` type has been added to the Google.Cloud.Spanner.V1 library, it is not currently integrated with the rest of the code, and should be ignored at this time.

## Version 3.0.0, released 2020-04-15

GA release targeting GAX 3.0.0. No new features compared with
3.0.0-beta02, other than small resource name improvements for backups.

## Version 3.0.0-beta02, released 2020-03-18

- [Commit c5090d1](https://github.com/googleapis/google-cloud-dotnet/commit/c5090d1):
  - feat: Adds the ability to set QueryOptions when running Cloud Spanner queries.
- [Commit 36f1e1e](https://github.com/googleapis/google-cloud-dotnet/commit/36f1e1e): Apply gccl header for Spanner clients in Google.Cloud.Spanner.Data
- [Commit f21fd27](https://github.com/googleapis/google-cloud-dotnet/commit/f21fd27):
  - feat: Backup support in Database Admin API
  - feat: List operations RPC in Database Admin API

This release depends on the GA version of GAX 3.0.

## Version 3.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 2.1.0, released 2019-12-12

- [Commit 0740a76](https://github.com/googleapis/google-cloud-dotnet/commit/0740a76): Adds support for retriable transactions
- Transparent support for batch creation of sessions (to make session creation more efficient)

## Version 2.0.0, released 2019-06-03

New features:

- Batch query support
- Connection string option to enable `SpannerDataReader.GetSchemaTable()`
  to return schema information
- DML and PDML support
- Batch DML support
- Session label support
  
Breaking changes:

- Many aspects of configuration have changed. Please refer to the [configuration guide](configuration.md),
  [migration guide](migrating-to-2.md) and [connection string options](connection_string.md)
  for more details.
- Null values are returned as `DBNull.Value` by default rather
  than the CLR default value for the type. Array and struct elements
  use a null value where feasible, but throw `InvalidCastException`
  when requested to be converted to a non-nullable value type. The
  1.0 behavior can be requested using the `UseClrDefaultForNull` connection string option.
- `Hashtable` is no longer used as a default type for
  struct values. It can still be specified explicitly.
  The new default is `Dictionary<string, object>`.
- The libraries no longer target netstandard1.5; only netstandard2.0
  and net45 are supported

## Version 1.0.0, released 2017-12-05

Initial release.
