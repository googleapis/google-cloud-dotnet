{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

[PublisherServiceApiClient](obj/api/Google.Cloud.PubSub.V1.PublisherServiceApiClient.yml) and
[SubscriberServiceApiClient](obj/api/Google.Cloud.PubSub.V1.SubscriberServiceApiClient.yml)
provide a general-purpose abstraction over raw the RPC API, providing
features such as page streaming to make client code cleaner and
simpler.

[PublisherClient](obj/api/Google.Cloud.PubSub.V1.PublisherClient.yml) and [SubscriberClient](obj/api/Google.Cloud.PubSub.V1.SubscriberClient.yml) provide simpler APIs for message publishing and subscribing. These classes offer considerably higher performance and simplicity, especially when working with higher message throughput.

Note that both `PublisherClient` and `SubscriberClient` expect to
execute in an environment with continuous processing and continuous
network access to the Pub/Sub API. In environments such as Cloud Run
or Cloud Functions, where servers do not use any CPU between requests,
the `PublisherServiceApiClient` and `SubscriberServiceApiClient` classes
should be used instead.

## Sample code

Using [PublisherClient](obj/api/Google.Cloud.PubSub.V1.PublisherClient.yml) and [SubscriberClient](obj/api/Google.Cloud.PubSub.V1.SubscriberClient.yml) for message publishing and subscribing:

{{sample:SubscriberServiceApiClient.SimpleOverview}}

Using [PublisherServiceApiClient](obj/api/Google.Cloud.PubSub.V1.PublisherServiceApiClient.yml) and
[SubscriberServiceApiClient](obj/api/Google.Cloud.PubSub.V1.SubscriberServiceApiClient.yml) only:

{{sample:SubscriberServiceApiClient.Overview}}

## Performance considerations and default settings

`PublisherClient` and `SubscriberClient` are optimized for high-throughput high-performance scenarios,
and default settings have been chosen with this in mind;
however, note that these classes are also well suited to use cases where performance is not a major
consideration.

By default multiple gRPC channels are created on client startup, with the channel count defaulting to
the CPU processor count as returned by `Environment.ProcessorCount`. This is to allow greater bandwidth
than a single gRPC channel can support; the processor count is a pragmatic choice to approximately
scale maximum throughput performance by potential machine workload.

When using multiple clients on a machine with a high processor count, this may cause problems
with TCP connection exhaustion. Set the relevant `ClientCreationSettings.ClientCount` to a low value
(`1` is suitable for low or moderate throughput requirements) to mitigate this.

## Coding considerations

`PublisherClient` and `SubscriberClient` are expensive to create, so when regularly publishing or
subscribing to the same topic or subscription then a singleton client instance should be created and
used for the lifetime of the application.

Both synchronous `Create(...)` and asynchronous `CreateAsync(...)` methods are provided, but note that
when using default credentials on Google Compute Engine (GCE) then a network request may need to be made
to retrieve credentials from the GCE Metadata Server.

When publishing, the `Task` returned by the various `Publish(...)` methods will complete only
when the message has been sent to the PubSub server, so should generally not be `await`ed directly
otherwise performance will suffer. This returned `Task` may be ignored if the publisher does not need
to be know whether the message was successfully published or not. The `Task` completes successfully
when the message has been published to the server; or faults if there was an error publishing.

When subscribing, an instance of `SubscriberClient` can only have `StartAsync(...)` called on it once.
Once `StopAsync(...)` has been called to shutdown the client, then a new client must be created to
restart listening for messages with `StartAsync(...)` again. Due to the expense of creating a client
instance, it is recommended that a singleton client per topic is used for the lifetime of the
application.

## Using the emulator

To connect to a [Pub/Sub
Emulator](https://cloud.google.com/pubsub/docs/emulator), set the
`EmulatorDetection` property in the appropriate class depending on
which client type you are constructing:

- `PublisherClient.ClientCreationSettings` (for `PublisherClient`)
- `SubscriberClient.ClientCreationSettings` (for `SubscriberClient`)
- `PublisherServiceApiClientBuilder` (for `PublisherServiceApiClient`)
- `SubscriberServiceApiClientBuilder` (for `SubscriberServiceApiClient`)

`SubscriberClient` example:

{{sample:SubscriberClient.Emulator}}

`SubscriberServiceApiClientBuilder` example:

{{sample:SubscriberServiceApiClient.Emulator}}

See the [help
article](https://cloud.google.com/dotnet/docs/reference/help/emulators)
for more details about emulator support in the .NET Google Cloud client libraries.
