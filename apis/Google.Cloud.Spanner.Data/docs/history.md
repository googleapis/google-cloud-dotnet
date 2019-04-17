# Version history

# 2.0.0 (in progress; latest release 2.0.0-beta08 on 2019-03-07)

New features:

- Batch query support
- Connection string option to enable `SpannerDataReader.GetSchemaTable()`
  to return schema information
- DML and PDML support
- Batch DML support
  
Breaking changes:

- Many aspects of configuration. Please refer to the [configuration guide](configuration.md),
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

# 1.0.0, 2017-12-05

Initial release.
