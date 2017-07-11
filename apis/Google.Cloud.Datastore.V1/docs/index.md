{{title}}

{{description}}

{{installation}}

{{auth}}

# Getting started

See the [Datastore Quickstart](https://cloud.google.com/datastore/docs/quickstart) for an introduction with runnable code samples.

The [DatastoreDb](obj/api/Google.Cloud.Datastore.V1.DatastoreDb.yml)
class is provided as a wrapper for
[DatastoreClient](obj/api/Google.Cloud.Datastore.V1.DatastoreClient.yml),
simplifying operations considerably by assuming all operations act
on the same partition, and providing page streaming operations on
structured query results.

Several custom conversions, additional constructors,
factory methods (particularly on [Filter](obj/api/Google.Cloud.Datastore.V1.Filter.yml)
are provided to simplify working with the protobuf messages.

# Sample code

Inserting data:

[!code-cs[](obj/snippets/Google.Cloud.Datastore.V1.DatastoreDb.txt#InsertOverview)]

Querying data:

[!code-cs[](obj/snippets/Google.Cloud.Datastore.V1.DatastoreDb.txt#QueryOverview)]

Lots more samples:
[github.com/GoogleCloudPlatform/dotnet-docs-samples](https://github.com/GoogleCloudPlatform/dotnet-docs-samples/tree/master/datastore/api)
