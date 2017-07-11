{{title}}

{{description}}
It wraps the `Google.Apis.Bigquery.v2` generated library, providing a higher-level API to make it easier to use.

{{installation}}

{{auth}}

# Getting started

Common operations are exposed via the
[BigQueryClient](obj/api/Google.Cloud.BigQuery.V2.BigQueryClient.yml)
class, and additional wrapper classes are present to make operations
with datasets, tables and query results simpler.

# Sample code

## Querying

[!code-cs[](obj/snippets/Google.Cloud.BigQuery.V2.BigQueryClient.txt#QueryOverview)]

## Parameterized queries

Queries can be provided with parameters, either using names (the
default):

[!code-cs[](obj/snippets/Google.Cloud.BigQuery.V2.BigQueryClient.txt#ParameterizedQueryNamedParameters)]

Or using positional parameters:

[!code-cs[](obj/snippets/Google.Cloud.BigQuery.V2.BigQueryClient.txt#ParameterizedQueryPositionalParameters)]

## Using legacy SQL

By default, [BigQueryClient](obj/api/Google.Cloud.BigQuery.V2.BigQueryClient.yml)
uses [Standard SQL](https://cloud.google.com/bigquery/sql-reference/). To
use [Legacy SQL](https://cloud.google.com/bigquery/query-reference),
simply set `UseLegacySql` to true in the query options, and make
sure that you use the legacy format for the table name, as shown
below.

[!code-cs[](obj/snippets/Google.Cloud.BigQuery.V2.BigQueryClient.txt#LegacySql)]

## Data insertion

[!code-cs[](obj/snippets/Google.Cloud.BigQuery.V2.BigQueryClient.txt#InsertOverview)]

## Creating a table partitioned by time

[!code-cs[](obj/snippets/Google.Cloud.BigQuery.V2.BigQueryClient.txt#CreatePartitionedTable)]

## Querying an external data source

As [described in the
documentation](https://cloud.google.com/bigquery/external-data-sources),
BigQuery can query some external data sources. The sample code below
demonstrates querying a CSV file stored in Google Cloud Storage.

[!code-cs[](obj/snippets/Google.Cloud.BigQuery.V2.BigQueryClient.txt#ExternalCsv)]
