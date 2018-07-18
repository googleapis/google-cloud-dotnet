# Version history

# 1.3.0-beta02, 2018-07-18

New features since 1.2.0:

- Support for the `NUMERIC` type via `BigQueryNumeric`
- Support for a projection to be specified when listing jobs
- Support for time-based partitioning in load and query jobs
- Support for time-based partitioning by a specific field
- Support for SchemaUpdateOptions for load and query jobs
- Support for Parquet load jobs
- Support for job labels
- Public constructors for BigQueryTable etc, for improved testability

# 1.2.0, 2018-04-09

New features:

- Support for geo-regionalization for data sets and jobs

# 1.1.0, 2018-03-06

New features:

- Support for [customer managed encryption](https://cloud.google.com/bigquery/docs/customer-managed-encryption)
  (Cloud KMS)

# 1.0.0, 2017-12-07

Initial release.
