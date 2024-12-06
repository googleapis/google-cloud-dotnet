# Version history

## Version 2.8.0, released 2024-12-06

### New features

- A new method `RunStream` is added to service `Datastream` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `sql_server_rdbms` is added to message `.google.cloud.datastream.v1.DiscoverConnectionProfileRequest` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `sql_server_rdbms` is added to message `.google.cloud.datastream.v1.DiscoverConnectionProfileResponse` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `RunStreamRequest` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `oracle_ssl_config` is added to message `.google.cloud.datastream.v1.OracleProfile` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `oracle_asm_config` is added to message `.google.cloud.datastream.v1.OracleProfile` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `secret_manager_stored_password` is added to message `.google.cloud.datastream.v1.OracleProfile` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `OracleAsmConfig` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `SqlServerProfile` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `OracleSslConfig` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `sql_server_profile` is added to message `.google.cloud.datastream.v1.ConnectionProfile` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `LogMiner` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `BinaryLogParser` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `log_miner` is added to message `.google.cloud.datastream.v1.OracleSourceConfig` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `binary_log_parser` is added to message `.google.cloud.datastream.v1.OracleSourceConfig` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `SqlServerColumn` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `SqlServerTable` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `SqlServerSchema` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `SqlServerRdbms` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `SqlServerSourceConfig` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `SqlServerTransactionLogs` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `SqlServerChangeTables` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `BinaryLogPosition` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `Gtid` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `binary_log_position` is added to message `.google.cloud.datastream.v1.MysqlSourceConfig` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `gtid` is added to message `.google.cloud.datastream.v1.MysqlSourceConfig` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `sql_server_source_config` is added to message `.google.cloud.datastream.v1.SourceConfig` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `AppendOnly` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `Merge` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `merge` is added to message `.google.cloud.datastream.v1.BigQueryDestinationConfig` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `append_only` is added to message `.google.cloud.datastream.v1.BigQueryDestinationConfig` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `sql_server_excluded_objects` is added to message `.google.cloud.datastream.v1.Stream` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `last_recovery_time` is added to message `.google.cloud.datastream.v1.Stream` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `SqlServerObjectIdentifier` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new field `sql_server_identifier` is added to message `.google.cloud.datastream.v1.SourceObjectIdentifier` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new value `WARNING` is added to enum `State` ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `CdcStrategy` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `SqlServerLsnPosition` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `OracleScnPosition` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A new message `MysqlLogPosition` is added ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))

### Documentation improvements

- A comment for field `requested_cancellation` in message `.google.cloud.datastream.v1.OperationMetadata` is changed ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A comment for message `OracleProfile` is changed ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A comment for field `password` in message `.google.cloud.datastream.v1.OracleProfile` is changed ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A comment for message `MysqlProfile` is changed ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A comment for field `password` in message `.google.cloud.datastream.v1.MysqlProfile` is changed ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A comment for field `password` in message `.google.cloud.datastream.v1.PostgresqlProfile` is changed ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A comment for field `stream_large_objects` in message `.google.cloud.datastream.v1.OracleSourceConfig` is changed ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A comment for field `dataset_id` in message `.google.cloud.datastream.v1.BigQueryDestinationConfig` is changed ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A comment for field `state` in message `.google.cloud.datastream.v1.BackfillJob` is changed ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))
- A comment for field `state` in message `.google.cloud.datastream.v1.Validation` is changed ([commit 2ff6786](https://github.com/googleapis/google-cloud-dotnet/commit/2ff67860f6818465bcacacddefc2238f9fc5ac6b))

## Version 2.7.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.6.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.5.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.4.0, released 2023-08-04

### New features

- Add precision and scale to MysqlColumn ([commit 0612a03](https://github.com/googleapis/google-cloud-dotnet/commit/0612a03dc591591ff48726846d054fd334f79d97))

## Version 2.3.0, released 2023-05-11

### New features

- Max concurrent backfill tasks ([commit 00b27cd](https://github.com/googleapis/google-cloud-dotnet/commit/00b27cd014e844024d19572ab585bd3cc705ffad))

## Version 2.2.0, released 2023-01-18

### New features

- Enable REST transport in C# ([commit 0f8560c](https://github.com/googleapis/google-cloud-dotnet/commit/0f8560c840725bf41bc060c8beecafc7d99f38eb))

## Version 2.1.0, released 2022-08-26

### New features

- Added support for BigQuery destination and PostgreSQL source types ([commit 675d15d](https://github.com/googleapis/google-cloud-dotnet/commit/675d15ddd7a0ff36cfdd35e2f1257669a25a464f))

## Version 2.0.0, released 2022-06-08

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


## Version 1.0.0, released 2022-03-14

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta02, released 2022-02-22

### New features

- Add Location mixin to Google.Cloud.Datastream.V1 ([commit 26dccaf](https://github.com/googleapis/google-cloud-dotnet/commit/26dccafc5c62d97d72e428b324d32727e6056327))

## Version 1.0.0-beta01, released 2022-02-07

Initial release.
