# Introduction

This is preliminary documentation for the Google Cloud APIs
repository.

## Google.Storage.V1

A wrapper library over
[Google.Apis.Storage.v1](https://www.nuget.org/packages/Google.Apis.Storage.v1/)
for working with [Google Cloud Storage](https://cloud.google.com/storage/)

Common operations are exposed via the
[`StorageClient`](obj/api/Google.Storage.V1.StorageClient.yml) class.

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
