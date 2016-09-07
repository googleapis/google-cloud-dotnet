# Google.Pubsub.V1

`Google.Pubsub.V1` is a .NET client library for [Cloud
Pub/Sub](https://cloud.google.com/pubsub/).

# Installation

Install the `Google.Pubsub.V1` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth login
```

# Getting started

[PublisherClient](obj/api/Google.Pubsub.V1.PublisherClient.yml) and
[SubscriberClient](obj/api/Google.Pubsub.V1.SubscriberClient.yml)
provide a general-purpose abstraction over raw the RPC API, providing
features such as page streaming to make client code cleaner and
simpler.

# Sample code

[!code-cs[](obj/snippets/Google.Pubsub.V1.SubscriberClient.txt#Overview)]
