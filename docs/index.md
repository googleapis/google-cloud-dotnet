# Introduction

This is preliminary documentation for the Google Cloud APIs
repository.

# Installation

All APIs are available as NuGet packages. Add the relevant package
to your project in the normal way (for example by right-clicking on
the project in Visual Studio and choosing "Manage NuGet
Packages..."). For beta packages, please ensure you enable
pre-release packages (for example, in the Visual Studio NuGet user
interface, check the "Include prerelease" box).

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth login
```

At this point, you are now authenticated to make calls to Pub/Sub
and other Google Cloud services.

# Google.Pubsub.V1 (beta)

[(Available on nuget.org)](https://www.nuget.org/packages/Google.Pubsub.V1)

A library for working with [Cloud Pub/Sub](https://cloud.google.com/pubsub/).

[PublisherClient](obj/api/Google.Pubsub.V1.PublisherClient.yml) and
[SubscriberClient](obj/api/Google.Pubsub.V1.SubscriberClient.yml)
provide a general-purpose abstraction over raw the RPC API, providing
features such as page streaming to make client code cleaner and
simpler.

## Sample code

[!code-cs[](obj/snippets/Google.Pubsub.V1.SubscriberClient.txt#Overview)]

# Google.Storage.V1 (beta)

[(Available on nuget.org)](https://www.nuget.org/packages/Google.Storage.V1)

A wrapper library over
[Google.Apis.Storage.v1](https://www.nuget.org/packages/Google.Apis.Storage.v1/)
for working with [Google Cloud Storage](https://cloud.google.com/storage/).

Common operations are exposed via the
[StorageClient](obj/api/Google.Storage.V1.StorageClient.yml) class.

## Sample code

[!code-cs[](obj/snippets/Google.Storage.V1.StorageClient.txt#Overview)]

# Google.Datastore.V1Beta3 (beta)

[(Available on nuget.org)](https://www.nuget.org/packages/Google.Datastore.V1Beta3)

A library for working with [Cloud Datastore](https://cloud.google.com/datastore/).

The [DatastoreDb](obj/api/Google.Datastore.V1Beta3.DatastoreDb.yml)
class is provided as a wrapper for
[DatastoreClient](obj/api/Google.Datastore.V1Beta3.DatastoreClient.yml),
simplifying operations considerably by assuming all operations act
on the same partition, and providing page streaming operations on
structured query results.

Several custom conversions, additional constructors,
factory methods (particularly on [Filter](obj/api/Google.Datastore.V1Beta3.Filter.yml)
are provided to simplify working with the protobuf messages.

## Sample code

Inserting data:

[!code-cs[](obj/snippets/Google.Datastore.V1Beta3.DatastoreDb.txt#InsertOverview)]

Querying data:

[!code-cs[](obj/snippets/Google.Datastore.V1Beta3.DatastoreDb.txt#QueryOverview)]

# Google.Logging.V2 (beta)

A library for working with [Google Stackdriver Logging](https://cloud.google.com/logging/).

## Log4net integration - Google.Logging.Log4Net (beta)

[(Available on nuget.org)](https://www.nuget.org/packages/Google.Logging.Log4Net)

[GoogleStackDriverAppender](obj/api/Google.Logging.Log4Net.GoogleStackdriverAppender.yml)
provides a [log4net](https://logging.apache.org/log4net/) appender to log messages
to Google Stackdriver Logging.

### Sample code

Simple logging:

First create a `log4net` configuration file (`log4net.xml`) as below:

[!code-xml[](obj/snippets/Google.Logging.Log4Net.GoogleStackdriverAppender.txt#log4net_template)]

Edit the file replacing `PROJECT_ID` with your Google Cloud Project
ID, and `LOG_ID` with an identifier for your application. Use this
file to configure `log4net` and then log as normal.

[!code-cs[](obj/snippets/Google.Logging.Log4Net.GoogleStackdriverAppender.txt#Overview)]

See the
[readme](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/blob/master/src/Google.Logging.Log4Net/readme.md)
for details on all the configuration options.

## Basic logging library (beta)

[(Available on nuget.org)](https://www.nuget.org/packages/Google.Logging.V2)

(Depends on `Google.Logging.Type` for version-agnostic types.)

If required,
[LoggingServiceV2Client](obj/api/Google.Logging.V2.LoggingServiceV2Client.yml)
provides a low-level abstraction over the raw RPC API.

# Google.Bigquery.V2 (beta)

[(Available on nuget.org)](https://www.nuget.org/packages/Google.Bigquery.V2)

A wrapper library over
[Google.Apis.Bigquery.v1](https://www.nuget.org/packages/Google.Apis.Bigquery.v2/)
for working with [Google BigQuery](https://cloud.google.com/bigquery/)

Common operations are exposed via the
[BigqueryClient](obj/api/Google.Bigquery.V2.BigqueryClient.yml)
class, and additional wrapper classes are present to make operations
with datasets, tables and query results simpler.

## Sample code

Querying:

[!code-cs[](obj/snippets/Google.Bigquery.V2.BigqueryClient.txt#QueryOverview)]

Data insertion:

[!code-cs[](obj/snippets/Google.Bigquery.V2.BigqueryClient.txt#InsertOverview)]
