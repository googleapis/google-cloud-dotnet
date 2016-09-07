# Google.Datastore.V1Beta3

`Google.Datastore.V1Beta3` is a .NET client library for [Google
Cloud Datastore](https://cloud.google.com/datastore/docs/concepts/overview).

# Please update to Google.Datastore.V1

> **The Google.Datastore.V1Beta3 library has been superceded by
> [Google.Datastore.V1](../Google.Datastore.V1/index.html). No
> further changes will be performed on the V1Beta3 library; please
> update to V1.**

# Installation

Install the `Google.Datastore.V1Beta3` package from NuGet. Add it to
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

The [DatastoreDb](obj/api/Google.Datastore.V1Beta3.DatastoreDb.yml)
class is provided as a wrapper for
[DatastoreClient](obj/api/Google.Datastore.V1Beta3.DatastoreClient.yml),
simplifying operations considerably by assuming all operations act
on the same partition, and providing page streaming operations on
structured query results.

Several custom conversions, additional constructors,
factory methods (particularly on [Filter](obj/api/Google.Datastore.V1Beta3.Filter.yml)
are provided to simplify working with the protobuf messages.

# Sample code

Inserting data:

[!code-cs[](obj/snippets/Google.Datastore.V1Beta3.DatastoreDb.txt#InsertOverview)]

Querying data:

[!code-cs[](obj/snippets/Google.Datastore.V1Beta3.DatastoreDb.txt#QueryOverview)]
