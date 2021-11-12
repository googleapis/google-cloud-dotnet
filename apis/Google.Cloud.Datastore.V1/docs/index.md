{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

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

## Support for emulator detection

As of 2.2.0-beta02 and 2.2.0, the library has support for detecting the
emulator via environment variables, if requested. This is configured
via `DatastoreDbBuilder`, which can also be used to configure custom
credentials easily.

The following code creates a `DatastoreDb` which will use the
emulator when the environment variables are present, but will
otherwise connect to the production environment.

{{sample:DatastoreDb.EmulatorDetection}}

See the
[EmulatorDetection](obj/api/Google.Cloud.Datastore.V1.EmulatorDetection.yml)
enum for details of the other possible values.

# Sample code

## Inserting data

{{sample:DatastoreDb.InsertOverview}}

## Querying data

{{sample:DatastoreDb.QueryOverview}}

When a query contains a projection, any timestamp fields will be
returned using integer values. Use the
`Value.ToDateTimeFromProjection` and
`Value.ToDateTimeOffsetFromProjection` methods to convert
either integer or timestamp values to `DateTime` or `DateTimeOffset`.

Lots more samples:
[github.com/googleapis/dotnet-docs-samples](https://github.com/GoogleCloudPlatform/dotnet-docs-samples/tree/master/datastore/api)
