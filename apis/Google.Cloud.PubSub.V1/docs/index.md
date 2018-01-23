{{title}}

{{description}}

{{installation}}

{{auth}}

# Getting started

[PublisherServiceApiClient](obj/api/Google.Cloud.PubSub.V1.PublisherServiceApiClient.yml) and
[SubscriberServiceApiClient](obj/api/Google.Cloud.PubSub.V1.SubscriberServiceApiClient.yml)
provide a general-purpose abstraction over raw the RPC API, providing
features such as page streaming to make client code cleaner and
simpler.

[PublisherClient](obj/api/Google.Cloud.PubSub.V1.PublisherClient.yml) and [SubscriberClient](obj/api/Google.Cloud.PubSub.V1.SubscriberClient.yml) provide simpler APIs for message publishing and subscribing. These classes offer considerably higher performance and simplicity, especially when working with higher message throughput.

# Sample code

Using [PublisherClient](obj/api/Google.Cloud.PubSub.V1.PublisherClient.yml) and [SubscriberClient](obj/api/Google.Cloud.PubSub.V1.SubscriberClient.yml) for message publishing and subscribing:

[!code-cs[](obj/snippets/Google.Cloud.PubSub.V1.SubscriberServiceApiClient.txt#SimpleOverview)]

Using [PublisherServiceApiClient](obj/api/Google.Cloud.PubSub.V1.PublisherServiceApiClient.yml) and
[SubscriberServiceApiClient](obj/api/Google.Cloud.PubSub.V1.SubscriberServiceApiClient.yml) only:

[!code-cs[](obj/snippets/Google.Cloud.PubSub.V1.SubscriberServiceApiClient.txt#Overview)]
