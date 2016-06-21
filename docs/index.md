# Introduction

This is preliminary documentation for the Google Cloud APIs
repository.

# Installation

All APIs are available as NuGet packages. Add the relevant package
to your project in the normal way (for example by right-clicking on
the project in Visual Studio and choosing "Manage NuGet
Packages..."). Please ensure you enable pre-release packages (for
example, in the Visual Studio NuGet user interface, check the "Include
prerelease" box).

Beta APIs are available
from [nuget.org](https://nuget.org) and can be installed by most
users without reconfiguring their build environment at all. There is
no guarantee that the API surface will stay stable between beta and
full release, but we have high confidence that the libraries work
and are usable.

Alpha APIs are available from Google's [public myget
feed](https://www.myget.org/gallery/google-dotnet-public), which you
will need to configure within your build system. These APIs are even
more likely to have significant surface changes over time, and may
fail or have usability issues. Still, if you would like to
experiment with them, we would welcome your feedback.

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth login
```

At this point, you are now authenticated to make calls to Pub/Sub
and other Google Cloud services.

# Google.Pubsub.V1 ([NuGet](https://www.nuget.org/packages/Google.Pubsub.V1)) (beta)

A library for working with [Cloud Pub/Sub](https://cloud.google.com/pubsub/).

[PublisherClient](obj/api/Google.Pubsub.V1.PublisherClient.yml) and
[SubscriberClient](obj/api/Google.Pubsub.V1.SubscriberClient.yml)
provide a general-purpose abstraction over raw the RPC API, providing
features such as page streaming to make client code cleaner and
simpler.

## Sample code

[!code-cs[](obj/snippets/Google.Pubsub.V1.SubscriberClient.txt#Overview)]

# Google.Storage.V1 ([NuGet](https://www.nuget.org/packages/Google.Storage.V1)) (beta)

A wrapper library over
[Google.Apis.Storage.v1](https://www.nuget.org/packages/Google.Apis.Storage.v1/)
for working with [Google Cloud Storage](https://cloud.google.com/storage/).

Common operations are exposed via the
[StorageClient](obj/api/Google.Storage.V1.StorageClient.yml) class.

## Sample code

[!code-cs[](obj/snippets/Google.Storage.V1.StorageClient.txt#Overview)]

# Google.Datastore.V1Beta3 (alpha)

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

# Google.Logging.V2 (alpha)

A library for working with [Stackdriver Logging](https://cloud.google.com/logging/).

(Depends on `Google.Logging.Type` for version-agnostic types.)

See [LoggingServiceV2Client](obj/api/Google.Logging.V2.LoggingServiceV2Client.yml)
for details.

# Google.Bigquery.V2 (alpha)

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
