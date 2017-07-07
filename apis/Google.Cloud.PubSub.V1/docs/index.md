# Google.Cloud.PubSub.V1

`Google.Cloud.PubSub.V1` is a .NET client library for [Cloud
Pub/Sub](https://cloud.google.com/pubsub/).

# Installation

Install the `Google.Cloud.PubSub.V1` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, to get started you can run the following command in a
Google Cloud SDK Shell:

```sh
> gcloud auth application-default login
```

That will provide [application default
credentials](https://developers.google.com/identity/protocols/application-default-credentials)
in your local environment. Be aware however that these credentials
will have a low default quota.

To move beyond initial prototyping, we encourage you to use a [service
account](https://cloud.google.com/compute/docs/access/service-accounts).
After downloading the JSON file for the service account, set the
`GOOGLE_APPLICATION_CREDENTIALS` environment variable to the file's
location, and it will be picked up by default. This is only needed
when running outside Google Cloud Platform; code running on Google
Cloud Platform will use the appropriate service account for its
hosting environment automatically.

# Getting started

[PublisherClient](obj/api/Google.Cloud.PubSub.V1.PublisherClient.yml) and
[SubscriberClient](obj/api/Google.Cloud.PubSub.V1.SubscriberClient.yml)
provide a general-purpose abstraction over raw the RPC API, providing
features such as page streaming to make client code cleaner and
simpler.

[SimplePublisher](obj/api/Google.Cloud.PubSub.V1.SimplePublisher.yml) and [SimpleSubscriber](obj/api/Google.Cloud.PubSub.V1.SimpleSubscriber.yml) provide simpler APIs for message publishing and subscribing.

# Sample code

Using [PublisherClient](obj/api/Google.Cloud.PubSub.V1.PublisherClient.yml) and
[SubscriberClient](obj/api/Google.Cloud.PubSub.V1.SubscriberClient.yml) only:

[!code-cs[](obj/snippets/Google.Cloud.PubSub.V1.SubscriberClient.txt#Overview)]

Using [SimplePublisher](obj/api/Google.Cloud.PubSub.V1.SimplePublisher.yml) and [SimpleSubscriber](obj/api/Google.Cloud.PubSub.V1.SimpleSubscriber.yml) for message publishing and subscribing:

[!code-cs[](obj/snippets/Google.Cloud.PubSub.V1.SubscriberClient.txt#SimpleOverview)]
