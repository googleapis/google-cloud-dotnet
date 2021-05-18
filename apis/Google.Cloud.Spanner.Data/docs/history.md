# Version history

# Version 3.8.0, released 2021-05-18

- [Commit a334723](https://github.com/googleapis/google-cloud-dotnet/commit/a334723): feat: add option to return read timestamp
- [Commit fbcacf0](https://github.com/googleapis/google-cloud-dotnet/commit/fbcacf0): fix: Use CopySettingsForEmulator in Spanner clients
- [Commit 4371842](https://github.com/googleapis/google-cloud-dotnet/commit/4371842): feat: add `progress` field to `UpdateDatabaseDdlMetadata`
- [Commit 5eef4b4](https://github.com/googleapis/google-cloud-dotnet/commit/5eef4b4): feat: add `progress` field to `UpdateDatabaseDdlMetadata`
- [Commit 9f5f0aa](https://github.com/googleapis/google-cloud-dotnet/commit/9f5f0aa): fix: Regenerate server-streaming calls with Google request params

# Version 3.7.0, released 2021-04-01

- [Commit 63f54b5](https://github.com/googleapis/google-cloud-dotnet/commit/63f54b5): feat: add support for request and transaction tagging
- [Commit a7d1b22](https://github.com/googleapis/google-cloud-dotnet/commit/a7d1b22): feat: add support for RPC priority
- [Commit b40ca4e](https://github.com/googleapis/google-cloud-dotnet/commit/b40ca4e): feat: add tagging request options (proto)
- [Commit ec9fd53](https://github.com/googleapis/google-cloud-dotnet/commit/ec9fd53): feat: add RPC Priority request options (proto)

# Version 3.6.0, released 2021-03-17

- [Commit 69c83e4](https://github.com/googleapis/google-cloud-dotnet/commit/69c83e4):
  - fix: retry errors in stream until timeout ([issue 6013](https://github.com/googleapis/google-cloud-dotnet/issues/6013))
  - Also fixes [issue 5977](https://github.com/googleapis/google-cloud-dotnet/issues/5977)
- [Commit fa5641d](https://github.com/googleapis/google-cloud-dotnet/commit/fa5641d): fix: retry consecutive retryable errors in sql stream. Fixes [issue 5977](https://github.com/googleapis/google-cloud-dotnet/issues/5977)
- [Commit a86b6ea](https://github.com/googleapis/google-cloud-dotnet/commit/a86b6ea): feat: add `optimizer_statistics_package` field in `QueryOptions`
- [Commit ef02e74](https://github.com/googleapis/google-cloud-dotnet/commit/ef02e74): feat: add CMEK fields to backup and database

# Version 3.5.0, released 2021-02-08

- [Commit d5abc62](https://github.com/googleapis/google-cloud-dotnet/commit/d5abc62): feat: add Point In Time Recovery (PITR) support
- [Commit 65f6e7b](https://github.com/googleapis/google-cloud-dotnet/commit/65f6e7b):
  - feat: log CommitStats if requested by the client application ([issue 5506](https://github.com/googleapis/google-cloud-dotnet/issues/5506))
- [Commit 8562ced](https://github.com/googleapis/google-cloud-dotnet/commit/8562ced): fix: use null instead of empty array + integration test
- [Commit 0343ff8](https://github.com/googleapis/google-cloud-dotnet/commit/0343ff8):
  - fix: parse WITH command as SELECT. Fixes [issue 5857](https://github.com/googleapis/google-cloud-dotnet/issues/5857)
- [Commit 4866adf](https://github.com/googleapis/google-cloud-dotnet/commit/4866adf): fix: NUMERIC is missing default mapping
- [Commit a223bd0](https://github.com/googleapis/google-cloud-dotnet/commit/a223bd0): fix: local date could lead to wrong date in database

# Version 3.4.0, released 2020-12-14

- [Commit 9fb3e43](https://github.com/googleapis/google-cloud-dotnet/commit/9fb3e43): feat: Database Admin: Adds UpdateDatabaseDdlMetadata.Throttled to indicate when a DDL operation is throttled due to resource constraints.

# Version 3.3.0, released 2020-10-01

- [Commit 9d984c8](https://github.com/googleapis/google-cloud-dotnet/commit/9d984c8): fix: Trust SpannerClientCreationOptions to connect to the emulator. Fixes [issue 5362](https://github.com/googleapis/google-cloud-dotnet/issues/5362).

# Version 3.2.0, released 2020-09-10

- [Commit 0272d4e](https://github.com/googleapis/google-cloud-dotnet/commit/0272d4e): fix: retry PDML on EOS on DATA error ([issue 5238](https://github.com/googleapis/google-cloud-dotnet/issues/5238))
- [Commit b43315c](https://github.com/googleapis/google-cloud-dotnet/commit/b43315c): feat: add NUMERIC support ([issue 5057](https://github.com/googleapis/google-cloud-dotnet/issues/5057))

# Version 3.1.0, released 2020-07-14

- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): Regenerate all APIs with service comments in client documentation
- [Commit 2db277b](https://github.com/googleapis/google-cloud-dotnet/commit/2db277b):
  - Improvements to GetOrdinal behavior
  - Fixes [issue 5114](https://github.com/googleapis/google-cloud-dotnet/issues/5114)
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): Regenerate APIs with timeouts for RPCs that don't have retries

# Version 3.1.0-beta01, released 2020-06-16

- [Commit 5b07f5a](https://github.com/googleapis/google-cloud-dotnet/commit/5b07f5a): fix: Roll back uncommitted (and not-rolled-back) read/write transactions on session release
- [Commit 7de296c](https://github.com/googleapis/google-cloud-dotnet/commit/7de296c): fix: Workaround for emulator bug of not populating ExecuteBatchDmlResponse.status
- [Commit a4455b9](https://github.com/googleapis/google-cloud-dotnet/commit/a4455b9): feat: Spanner emulator support in Google.Cloud.Spanner.Data
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): fix: Regenerate all clients with more explicit documentation
- [Commit 0b01e4b](https://github.com/googleapis/google-cloud-dotnet/commit/0b01e4b): feat: add support for spanner emulator detection in clients ([issue 4928](https://github.com/googleapis/google-cloud-dotnet/issues/4928))

Note that while the `SpannerNumeric` type has been added to the Google.Cloud.Spanner.V1 library, it is not currently integrated with the rest of the code, and should be ignored at this time.

# Version 3.0.0, released 2020-04-15

GA release targeting GAX 3.0.0. No new features compared with
3.0.0-beta02, other than small resource name improvements for backups.

# Version 3.0.0-beta02, released 2020-03-18

- [Commit c5090d1](https://github.com/googleapis/google-cloud-dotnet/commit/c5090d1):
  - feat: Adds the ability to set QueryOptions when running Cloud Spanner queries.
- [Commit 36f1e1e](https://github.com/googleapis/google-cloud-dotnet/commit/36f1e1e): Apply gccl header for Spanner clients in Google.Cloud.Spanner.Data
- [Commit f21fd27](https://github.com/googleapis/google-cloud-dotnet/commit/f21fd27):
  - feat: Backup support in Database Admin API
  - feat: List operations RPC in Database Admin API

This release depends on the GA version of GAX 3.0.

# Version 3.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

# Version 2.1.0, released 2019-12-12

- [Commit 0740a76](https://github.com/googleapis/google-cloud-dotnet/commit/0740a76): Adds support for retriable transactions
- Transparent support for batch creation of sessions (to make session creation more efficient)

# Version 2.0.0, released 2019-06-03

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

# Version 1.0.0, released 2017-12-05

Initial release.
