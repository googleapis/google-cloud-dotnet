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

A library for working with [Google Cloud Pub/sub](https://cloud.google.com/pubsub/).

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
