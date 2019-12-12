# Version history

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
