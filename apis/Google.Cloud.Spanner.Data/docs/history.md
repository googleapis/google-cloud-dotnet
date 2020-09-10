# Version history

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
