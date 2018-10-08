# Version history

# 2.0.0 (in progress; latest release 2.0.0-beta04 on 2018-10-08)

New features:

- Batch query support
- Connection string option to enable `SpannerDataReader.GetSchemaTable()`
  to return schema information
- DML and PDML support
  
Breaking changes:

- Null values are returned as `DBNull.Value` by default rather
  than the CLR default value for the type. Array and struct elements
  use a null value where feasible, but throw `InvalidCastException`
  when requested to be converted to a non-nullable value type. The
  1.0 behavior can be requested using the `UseClrDefaultForNull`
  [connection string option](connection_string.md).
- `Hashtable` is no longer used as a default type for
  struct values. It can still be specified explicitly.
  The new default is `Dictionary<string, object>`.

# 1.0.0, 2017-12-05

Initial release.
