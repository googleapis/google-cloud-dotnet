{{title}}

{{description}}
It wraps the `Google.Apis.Bigquery.v2` generated library, providing a higher-level API to make it easier to use.

{{version}}

{{installation}}

{{auth}}

## Getting started

Common operations are exposed via the
[BigQueryClient](obj/api/Google.Cloud.BigQuery.V2.BigQueryClient.yml)
class, and additional wrapper classes are present to make operations
with datasets, tables and query results simpler.

## Client life-cycle management

In many cases you don't need to worry about disposing of
`BigQueryClient` objects, and can create them reasonably freely -
but be aware that this *can* causes issues with memory and network
connection usage. We advise you to reuse a single client object if
possible; if your architecture requires you to frequently create new
client objects, please dispose of them to help with timely resource
clean-up. See [the resource clean-up guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/cleanup.html#rest-based-apis) for more
details.

## Sample code

## Querying

{{sample:BigQueryClient.QueryOverview}}

## Parameterized queries

Queries can be provided with parameters, either using names (the
default):

{{sample:BigQueryClient.ParameterizedQueryNamedParameters}}

Or using positional parameters:

{{sample:BigQueryClient.ParameterizedQueryPositionalParameters}}

## Using legacy SQL

By default, [BigQueryClient](obj/api/Google.Cloud.BigQuery.V2.BigQueryClient.yml)
uses [Standard SQL](https://cloud.google.com/bigquery/sql-reference/). To
use [Legacy SQL](https://cloud.google.com/bigquery/query-reference),
simply set `UseLegacySql` to true in the query options, and make
sure that you use the legacy format for the table name, as shown
below.

{{sample:BigQueryClient.LegacySql}}

## Wildcard queries

[Wildcard queries](https://cloud.google.com/bigquery/docs/querying-wildcard-tables) can be used
to query multiple tables at the same time.
Wildcard table names only work in queries written using Standard SQL, so make sure to use the
standard format for the table name as shown below.

{{sample:BigQueryClient.WildcardQuery}}

## Data insertion

{{sample:BigQueryClient.InsertOverview}}

## DML

BigQuery supports
[DML](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-manipulation-language).

Suppose we have a high score table, and we realize that on one day
we accidentally recorded incorrect scores: each player was only
awarded half the score they actually earned. We can update the data
afterwards using DML:

{{sample:BigQueryClient.DmlSample}}

### Important note on the result returned by DML operations (in version 1.3.0)

In version 1.3.0, iterating over the results of a `BigQueryResults` object returned
from a DML operation will iterate over the entire table modified by
that operation. This is a side-effect of the way the underlying API
is called, but it's rarely useful to iterate over the results. The
`NumDmlAffectedRows` property of the results object is useful,
however, in determining how many rows were modified.

From version 1.4.0-beta01 onwards, the `BigQueryResults` object
returned from a DML operation returns no rows, but
`NumDmlAffectedRows` still returns the number of affected rows.

## Creating a table partitioned by time

{{sample:BigQueryClient.CreatePartitionedTable}}

## Querying an external data source

As [described in the
documentation](https://cloud.google.com/bigquery/external-data-sources),
BigQuery can query some external data sources. The sample code below
demonstrates querying a CSV file stored in Google Cloud Storage.

{{sample:BigQueryClient.ExternalCsv}}
