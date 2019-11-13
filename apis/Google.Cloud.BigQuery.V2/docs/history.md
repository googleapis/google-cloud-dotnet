# Version history

# 1.4.0-beta06, 2019-11-13

Changes since 1.3.0:

- Loosen the restriction on JobConfigurationQuery.DestinationTable not being null.
- Provide option for using Avro logical types for load/extract.
- Adds creation time filtering to BigQuery job listing.
- Client builder.
- Implement support for BigQuery GEOGRAPHY type.
- netstandard2.0 target
- Reimplemented query handling using GetQueryResults RPC instead of ListRows,
  resulting in a performance improvement

# 1.3.0, 2019-02-07

New features since 1.2.0:

- Support for table clustering in `CreateTableOptions`
- Nullable row count properties (`SafeTotalRows` and `NumDmlAffectedRows`) in `BigQueryResults`
- Support for the `NUMERIC` type via `BigQueryNumeric`
- Support for a projection to be specified when listing jobs
- Support for time-based partitioning in load and query jobs
- Support for time-based partitioning by a specific field
- Support for SchemaUpdateOptions for load and query jobs
- Support for Parquet load jobs
- Support for ORC load jobs
- Support for job labels
- Support for supplying page tokens to all list operations
- Public constructors for BigQueryTable etc, for improved testability

# 1.2.0, 2018-04-09

New features since 1.1.0:

- Support for geo-regionalization for data sets and jobs

# 1.1.0, 2018-03-06

New features since 1.0.0:

- Support for [customer managed encryption](https://cloud.google.com/bigquery/docs/customer-managed-encryption)
  (Cloud KMS)

# 1.0.0, 2017-12-07

Initial release.
