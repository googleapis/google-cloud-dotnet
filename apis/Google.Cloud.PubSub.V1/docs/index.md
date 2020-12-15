{{title}}

{{description}}

{{version}}

# Class renaming in [v1.0.0-beta16](https://www.nuget.org/packages/Google.Cloud.PubSub.V1/1.0.0-beta16)

The following classes have been renamed when moving from version 1.0.0-beta15 to 1.0.0-beta16:

* `SimplePublisher` is now named [PublisherClient](obj/api/Google.Cloud.PubSub.V1.PublisherClient.yml)
* `SimpleSubscriber` is now named [SubscriberClient](obj/api/Google.Cloud.PubSub.V1.SubscriberClient.yml)
* `PublisherClient` is now named [PublisherServiceApiClient](obj/api/Google.Cloud.PubSub.V1.PublisherServiceApiClient.yml)
  * `PublisherSettings` is now named `PublisherServiceApiSettings`
* `SubscriberClient` is now named [SubscriberServiceApiClient](obj/api/Google.Cloud.PubSub.V1.SubscriberServiceApiClient.yml)
  * `SubscriberSettings` is now named `SubscriberServiceApiSettings`

{{installation}}

{{auth}}

# Getting started

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

# Sample code

Using [PublisherClient](obj/api/Google.Cloud.PubSub.V1.PublisherClient.yml) and [SubscriberClient](obj/api/Google.Cloud.PubSub.V1.SubscriberClient.yml) for message publishing and subscribing:

{{sample:SubscriberServiceApiClient.SimpleOverview}}

Using [PublisherServiceApiClient](obj/api/Google.Cloud.PubSub.V1.PublisherServiceApiClient.yml) and
[SubscriberServiceApiClient](obj/api/Google.Cloud.PubSub.V1.SubscriberServiceApiClient.yml) only:

{{sample:SubscriberServiceApiClient.Overview}}

# Using the emulator

To connect to a [Pub/Sub
Emulator](https://cloud.google.com/pubsub/docs/emulator), set the
`EmulatorDetection` property in the appropriate class depending on
which client type you are constructing:

- `PublisherClient.ClientCreationSettings` (for `PublisherClient`)
- `SubscriberClient.ClientCreationSettings` (for `SubscriberClient`)
- `PublisherServiceApiClientBuilder` (for `PublisherServiceApiClient`)
- `SubscriberServiceApiClientBuilder` (for `SubscriberServiceApiClient`)

See the [FAQ
entry](https://googleapis.github.io/google-cloud-dotnet/docs/faq.html#how-can-i-use-emulators)
for more details.
