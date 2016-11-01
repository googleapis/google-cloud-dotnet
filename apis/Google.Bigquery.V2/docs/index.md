# Google.Bigquery.V2

`Google.Bigquery.V2` is a .NET client library for [Google
BigQuery](https://cloud.google.com/bigquery/). It wraps the
`Google.Apis.Bigquery.v2` generated library, providing a
higher-level API to make it easier to use.

# Installation

Install the `Google.Bigquery.V2` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth login
```

# Getting started

Common operations are exposed via the
[BigqueryClient](obj/api/Google.Bigquery.V2.BigqueryClient.yml)
class, and additional wrapper classes are present to make operations
with datasets, tables and query results simpler.

# Sample code

## Querying

[!code-cs[](obj/snippets/Google.Bigquery.V2.BigqueryClient.txt#QueryOverview)]

## Parameterized queries

Queries can be provided with parameters, either using names (the
default):

[!code-cs[](obj/snippets/Google.Bigquery.V2.BigqueryClient.txt#ParameterizedQueryNamedParameters)]

Or using positional parameters:

[!code-cs[](obj/snippets/Google.Bigquery.V2.BigqueryClient.txt#ParameterizedQueryPositionalParameters)]

## Using legacy SQL

By default, [BigqueryClient](obj/api/Google.Bigquery.V2.BigqueryClient.yml)
uses [Standard SQL](https://cloud.google.com/bigquery/sql-reference/). To
use [Legacy SQL](https://cloud.google.com/bigquery/query-reference),
simply set `UseLegacySql` to true in the query options, and make
sure that you use the legacy format for the table name, as shown
below.

[!code-cs[](obj/snippets/Google.Bigquery.V2.BigqueryClient.txt#LegacySql)]

## Data insertion

[!code-cs[](obj/snippets/Google.Bigquery.V2.BigqueryClient.txt#InsertOverview)]