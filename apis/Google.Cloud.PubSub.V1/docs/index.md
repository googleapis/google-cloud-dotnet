{{title}}

{{description}}

{{installation}}

{{auth}}

# Getting started

[PublisherClient](obj/api/Google.Cloud.PubSub.V1.PublisherClient.yml) and
[SubscriberClient](obj/api/Google.Cloud.PubSub.V1.SubscriberClient.yml)
provide a general-purpose abstraction over raw the RPC API, providing
features such as page streaming to make client code cleaner and
simpler.

[SimplePublisher](obj/api/Google.Cloud.PubSub.V1.SimplePublisher.yml) and [SimpleSubscriber](obj/api/Google.Cloud.PubSub.V1.SimpleSubscriber.yml) provide simpler APIs for message publishing and subscribing. These classes offer considerably higher performance and simplicity, especially when working with higher message throughput.

# Sample code

Using [SimplePublisher](obj/api/Google.Cloud.PubSub.V1.SimplePublisher.yml) and [SimpleSubscriber](obj/api/Google.Cloud.PubSub.V1.SimpleSubscriber.yml) for message publishing and subscribing:

[!code-cs[](obj/snippets/Google.Cloud.PubSub.V1.SubscriberClient.txt#SimpleOverview)]

Using [PublisherClient](obj/api/Google.Cloud.PubSub.V1.PublisherClient.yml) and
[SubscriberClient](obj/api/Google.Cloud.PubSub.V1.SubscriberClient.yml) only:

[!code-cs[](obj/snippets/Google.Cloud.PubSub.V1.SubscriberClient.txt#Overview)]
