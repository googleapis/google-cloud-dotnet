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

- [ProjectName](xref:Google.Api.Gax.ResourceNames.ProjectName)
- [TopicName](xref:Google.Cloud.PubSub.V1.TopicName)
- [SubscriptionName](xref:Google.Cloud.PubSub.V1.SubscriptionName)

Note that `ProjectName` is a common resource name type, along with a
few others (`LocationName`, `OrganizationName`, `FolderName` and
`BillingAccountName`) present in GAX, so that the same resource name
object can be used across multiple APIs.

Constructing an instance of a resource name type from its resource
IDs is very simple: just call the constructor, or one of the factory
methods. (Some resource names have multiple patterns, and the
factory methods allow you to specify which pattern you're using).

Sometimes you may want to parse a resource name from its string form. Each resource name type has `Parse` and `TryParse`
methods to allow this. Likewise, to obtain the string representation of a resource name (for example to save it to a database)
you can just call `ToString`.

The resource name types are also used to augment the Protocol Buffer messages representing requests, responses and resources. This
takes the form of additional properties which automatically parse and format the underlying string representation. Where resources
have a `Name` property representing the string resource name, the additional property is simply the name of the type. For other
uses of resource names, the extra property is just the name of the string property with a suffix of `AsXyzName`, where `XyzName` is
the name of the generated type.

For example, [Subscription](xref:Google.Cloud.PubSub.V1.Subscription) has
a [SubscriptionName](xref:Google.Cloud.PubSub.V1.Subscription#Google_Cloud_PubSub_V1_Subscription_SubscriptionName)
property. When that property is fetched, it parses the value retrieved from the [Name](xref:Google.Cloud.PubSub.V1.Subscription#Google_Cloud_PubSub_V1_Subscription_Name) property. Likewise, when the `SubscriptionName` property is
set, the value is formatted and stored in `Name`.

## API calls

API calls where the request uses a resource name are typically mapped to use the corresponding class. For example, to list all the topics
in the `projects/petstore` project, you would use the [PublisherServiceApiClient.ListTopics](xref:Google.Cloud.PubSub.V1.PublisherServiceApiClient#Google_Pubsub_V1_PublisherServiceApiClient_ListTopics_Google_Cloud_PubSub_V1_ProjectName_System_String_System_Nullable_System_Int32__Google_Api_Gax_CallSettings_) method:

[!code-cs[](../examples/help.ResourceName.txt#ListTopics)]

Where API calls haven't been configured to use the resource name type, but instead accept a string, simply create the
resource name instance anyway, and call `ToString()` to obtain the appropriate string representation.

We can't tell you when your application will need to use resource IDs and when it will need to use resource names, but we'd recommend
using the terms "name" and "ID" in a manner consistent with the API terminology. The more you can use resource names in your code, the
less parsing and formatting you'll need to perform, of course.
