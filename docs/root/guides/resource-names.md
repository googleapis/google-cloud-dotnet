# Resource names

## Concepts

Many Google Cloud Platform APIs deal with multiple resources. Historically there
have been many different approaches to identifying these resources, but new APIs
are coalescing around the idea of a single *resource name* which uniquely identifies
that resource within an API.

A resource name is a path-like structure, typically alternating between fixed collection
names and an identifier within that collection. Throughout this page, we will use
the example of the [Google Cloud Pub/Sub API](https://cloud.google.com/pubsub/overview),
which is exposed by the [Google.Cloud.PubSub.V1 NuGet package](https://www.nuget.org/packages/Google.Cloud.PubSub.V1).

In Cloud Pub/Sub, a publisher creates a *topic* within a *project*, and a subscriber creates
a *subscription* to that topic, also within a project. (The topic and subscription may be in different projects.)
It is possible to list the topics or subscriptions within a project.

To make everything concrete, we'll consider three resources:

- Project: `projects/petstore`
- Topic: `projects/petstore/topics/offers`
- Subscription: `projects/petstore_web/subscriptions/pet_offers`

(We've deliberately used a different project in the subscription to highlight that they don't have to be the same.)

Each resource name consistents of one or more *resource IDs* - the parts within an resource name that vary, and fixed
parts of the name, typically collection names.

For example, within our topic resource name (`projects/petstore/topics/offers`) there are two resource IDs:

- The project ID (`petstore`)
- The topic ID (`offers`)

## Generated resource name types

The full resource names above are the ones you would see and use in the underlying Pub/Sub API - just as strings. However, to
make the client libraries easier to use correctly, a class is generated for each kind of resource name. The classes
generated for the above resources are:

- [ProjectName](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.ProjectName.html)
- [TopicName](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.TopicName.html)
- [SubscriptionName](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.SubscriptionName.html)

Constructing an instance of a resource name type from its resource IDs is very simple: just call the constructor. Each
resource name type has a constructor with one parameter for each resource ID within the name.

Sometimes you may want to parse a resource name from its string form. Each resource name type has `Parse` and `TryParse`
methods to allow this. Likewise, to obtain the string representation of a resource name (for example to save it to a database)
you can just call `ToString`.

The resource name types are also used to augment the Protocol Buffer messages representing requests, responses and resources. This
takes the form of additional properties which automatically parse and format the underlying string representation. Where resources
have a `Name` property representing the string resource name, the additional property is simply the name of the type. For other
uses of resource names, the extra property is just the name of the string property with a suffix of `AsXyzName`, where `XyzName` is
the name of the generated type.

For example, [Subscription](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.Subscription.html) has
a [SubscriptionName](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.Subscription.html#Google_Cloud_PubSub_V1_Subscription_SubscriptionName)
property. When that property is fetched, it parses the value retrieved from the [Name](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.Subscription.html#Google_Cloud_PubSub_V1_Subscription_Name) property. Likewise, when the `SubscriptionName` property is
set, the value is formatted and stored in `Name`.

## API calls

API calls where the request uses a resource name are typically mapped to use the corresponding class. For example, to list all the topics
in the `projects/petstore` project, you would use the [PublisherClient.ListTopics](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.PublisherClient.html#Google_Pubsub_V1_PublisherClient_ListTopics_Google_Cloud_PubSub_V1_ProjectName_System_String_System_Nullable_System_Int32__Google_Api_Gax_CallSettings_) method:

[!code-cs[](../obj/snippets/Google.Cloud.Docs.ResourceName.txt#ListTopics)]

Where API calls haven't been configured to use the resource name type, but instead accept a string, simply create the
resource name instance anyway, and call `ToString()` to obtain the appropriate string representation.

We can't tell you when your application will need to use resource IDs and when it will need to use resource names, but we'd recommend
using the terms "name" and "ID" in a manner consistent with the API terminology. The more you can use resource names in your code, the
less parsing and formatting you'll need to perform, of course.

## "One-of" resource name types

As well as the types representing individual resource names, sometimes a message property could represent one of multiple
kinds of resource name. This could be due to multiple resource kinds being suitable for the property, or it could be due to "special"
resource names being specified in the API for unusual circumstances.

For example, a subscription refers to a topic resource name - but if the topic has been deleted, the name will be `_deleted-topic_`.
Rather than just fail to parse this, a "one-of" resource name class is generated (in this case
[TopicNameOneof](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.TopicNameOneof.html)). That is then used as the type of the
corresponding extra property ([TopicAsTopicNameOneof](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.Subscription.html#Google_Cloud_PubSub_V1_Subscription_TopicAsTopicNameOneof)) in `Subscription`.

This kind of resource name can still be parsed from a string and still be formatted with `ToString`, but can also be created
from the appropriate specific resource name types (`TopicName` and `DeletedTopicNameFixed` in this case). A nested enum and a property
of that type (`Type`) allow you to easily switch on which type of resource is actually being represented.

One-of resource name types always have a possible type of "unknown" which is used to allow for API expansion. For example,
if a resource name property can be either `projects/x` or `organizations/y` in version 1.0, a minor version update to 1.1
could add `teams/z` as a valid value. In this case, the code generated against version 1.0 would still work, using "unknown"
to represent any `teams/z` value received from the server. Code generated against version 1.1 would then have another strongly-typed
resource name type for the `teams/z` type of resource.
