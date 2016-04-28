# Introduction

This is preliminary documentation for the Google Cloud APIs
repository.

# Beta APIs

These APIs are available from [nuget.org](https://nuget.org) and can
be installed by most users without reconfiguring their build
environment at all. There is no guarantee that the API surface will
stay stable between beta and full release, but we have high confidence
that the libraries work and are usable.

## Google.Storage.V1 ([NuGet](https://www.nuget.org/packages/Google.Storage.V1))

A wrapper library over
[Google.Apis.Storage.v1](https://www.nuget.org/packages/Google.Apis.Storage.v1/)
for working with [Google Cloud Storage](https://cloud.google.com/storage/).

Common operations are exposed via the
[`StorageClient`](obj/api/Google.Storage.V1.StorageClient.yml) class.

# Alpha APIs

These APIs are available from Google's [public myget
feed](https://www.myget.org/gallery/google-dotnet-public),
which you will need to configure within your build system.

These APIs are even more likely to have significant surface
changes over time, and may fail or have usability issues. Still, if
you would like to experiment with them, we would welcome your
feedback.

## Google.Pubsub.V1

A library for working with [Cloud Pub/sub](https://cloud.google.com/pubsub/).

The API operates at three abstractions:

- `SimplePubsub` (coming soon) is a simplified API making common
scenarios extremely straightforward.
- [`PublisherClient`](obj/api/Google.Pubsub.V1.PublisherClient.yml) and
[`SubscriberClient`](obj/api/Google.Pubsub.V1.SubscriberClient.yml)
provide a general-purpose abstraction over raw the RPC API, providing
features such as page streaming to make client code cleaner and
simpler.
- [`IPublisherClient`](obj/api/Google.Pubsub.V1.Publisher.IPublisherClient.yml)
and [`ISubscriberClient`](obj/api/Google.Pubsub.V1.Subscriber.ISubscriberClient.yml)
expose the raw RPC API. Most clients will never need to use this
abstraction, but it provides the most flexibility for via specific
scenarios.

Each abstraction is built over the lower-level one, and client code
can mix and match abstractions very easily: you may be able to use
`SimplePubsub` for most of your code, dropping down to
`PublisherClient` and `SubscriberClient` occasionally, for example.

## Google.Datastore.V1Beta3

A library for working with [Cloud Datastore](https://cloud.google.com/datastore/).

Sample code:

```csharp
var client = DatastoreClient.Create();

var projectId = ...;
var partitionId = new PartitionId { ProjectId = projectId };
var entity = new Entity
{
    Key = new Key { PartitionId = partitionId, Path = { new PathElement { Kind = "message" } } },
    ["created"] = DateTime.UtcNow,
    ["text"] = "Text of the message"
};
var transaction = client.BeginTransaction(projectId).Transaction;
var commitResponse = client.Commit(projectId, Mode.TRANSACTIONAL, transaction, new[] { entity.ToInsert() });
var insertedKey = commitResponse.MutationResults[0].Key;
```

See [`DatastoreClient`](obj/api/Google.Datastore.V1Beta3.DatastoreClient.yml)
for details. Note that custom conversions are provided to make
working with the [`Value`](obj/api/Google.Datastore.V1Beta3.Value.yml) type much
simpler than it would otherwise be.

## Google.Logging.V2

A library for working with [Stackdriver Logging](https://cloud.google.com/logging/).

(Depends on `Google.Logging.Type` for version-agnostic types.)

See [`LoggingServiceV2Client`](obj/api/Google.Logging.V2.LoggingServiceV2Client.yml)
for details.

## Google.Bigquery.V2

A wrapper library over
[Google.Apis.Bigquery.v1](https://www.nuget.org/packages/Google.Apis.Bigquery.v2/)
for working with [Google BigQuery](https://cloud.google.com/bigquery/)

Common operations are exposed via the
[`BigqueryClient`](obj/api/Google.Bigquery.V2.BigqueryClient.yml)
class, and additional wrapper classes are present to make operations
with datasets, tables and query results simpler.

Query example:

```csharp
var client = BigqueryClient.Create("YOUR PROJECT ID");
var table = client.GetTable("bigquery-public-data", "samples", "shakespeare");

var sql = $"SELECT TOP(corpus, 10) as title, COUNT(*) as unique_words FROM {table}";
var query = client.ExecuteQuery(sql);

foreach (var row in rows)
{
    Console.WriteLine($"{row["title"]}: {row:["unique_words"]}");
}
```

Data insertion example:

```csharp
var client = BigqueryClient.Create("YOUR PROJECT ID");

// Create the dataset if it doesn't exist.
var dataset = client.GetOrCreateDataset("mydata");

// Create the table if it doesn't exist.
var table = dataset.GetOrCreateTable("scores", new SchemaBuilder
    {
        { "player", SchemaFieldType.String },
        { "gameStarted", SchemaFieldType.Timestamp },
        { "score", SchemaFieldType.Integer }
    }.Build());

// Insert a single row. There are many other ways of inserting
// data into a table.
table.InsertRow(new Dictionary<string, object> {
    { "player", "Bob" },
    { "score", 85 },
    { "gameStarted", new DateTime(2000, 1, 14, 10, 30, 0, DateTimeKind.Utc) }
});
```

