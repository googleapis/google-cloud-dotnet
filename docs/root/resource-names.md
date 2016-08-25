# Resource names

## Concepts

Many Google Cloud Platform APIs deal with multiple resources. Historically there
have been many different approaches to identifying these resources, but new APIs
are coalescing around the idea of a single *resource name* which uniquely identifies
that resource within an API.

A resource name is a path-like structure, typically alternating between fixed collection
names and an identifier within that collection. Throughout this page, we will use
the example of the [Google Cloud Pub/Sub API](https://cloud.google.com/pubsub/overview),
which is exposed by the [Google.Pubsub.V1 NuGet package](https://www.nuget.org/packages/Google.Pubsub.V1).

In Cloud Pub/Sub, a publisher creates a *topic* within a *project*, and a subscriber creates
a *subscription* to that topic, also within a project. (The topic and subscription may be in different projects.)
It is possible to list the topics or subscriptions within a project.

To make everything concrete, we'll consider three resources:

- Project: `projects/petstore`
- Topic: `projects/petstore/topics/offers`
- Subscription: `projects/petstore_web/subscriptions/pet_offers`

(We've deliberately used a different project in the subscription to highlight that they don't have to be the same.)

The names above are the ones you would see and use in the Pub/Sub API. For example, to list all the topics
in the `projects/petstore` project, you would use the [PublisherClient.ListTopics](Google.Pubsub.V1/api/Google.Pubsub.V1.PublisherClient.html#Google_Pubsub_V1_PublisherClient_ListTopics_System_String_System_String_System_Nullable_System_Int32__Google_Api_Gax_CallSettings_) method:

[!code-cs[](obj/snippets/Google.Cloud.Docs.ResourceName.txt#ListTopics)]

Using a single string as a resource name makes many things simple - such as referring to a resource in a logging or monitoring API.
However, there are times when an application would more naturally consider *resource IDs* - the parts within an resource name that vary.

For example, within our topic resource name (`projects/petstore/topics/offers`) there are two resource IDs:

- The project ID (`petstore`)
- The topic ID (`offers`)

We can't tell you when your application will need to use resource IDs and when it will need to use resource names, but we'd recommend
using the terms "name" and "ID" in a manner consistent with the API terminology. The more you can use resource names in your code, the
less parsing and formatting you'll need to perform, of course.

You should not perform the formatting and parsing yourself, as it is error-prone and tedious. Instead, use the functionality
provided by the class libraries, as described below.

## Formatting a resource name from resource IDs

For each resource used by a particular API client, a static format method is generated. For example, the [PublisherClient](Google.Pubsub.V1/api/Google.Pubsub.V1.PublisherClient.html) class has two format methods:

- [FormatProjectName(string)](Google.Pubsub.V1/api/Google.Pubsub.V1.PublisherClient.html#Google_Pubsub_V1_PublisherClient_FormatProjectName_System_String_)
- [FormatTopicName(string, string)](Google.Pubsub.V1/api/Google.Pubsub.V1.PublisherClient.html#Google_Pubsub_V1_PublisherClient_FormatTopicName_System_String_System_String_)

Likewise, the [SubscriberClient](Google.Pubsub.V1/api/Google.Pubsub.V1.SubscriberClient.html) class has three methods:
- [FormatProjectName(string)](Google.Pubsub.V1/api/Google.Pubsub.V1.SubscriberClient.html#Google_Pubsub_V1_SubscriberClient_FormatProjectName_System_String_)
- [FormatTopicName(string, string)](Google.Pubsub.V1/api/Google.Pubsub.V1.SubscriberClient.html#Google_Pubsub_V1_SubscriberClient_FormatTopicName_System_String_System_String_)
- [FormatSubscriptionName(string, string)](Google.Pubsub.V1/api/Google.Pubsub.V1.SubscriberClient.html#Google_Pubsub_V1_SubscriberClient_FormatSubscriptionName_System_String_System_String_)

(A publisher never needs to format a subscription name, whereas a subscriber *does* need to format a topic name in order to
create a subscription.)

Each format method has one parameter for each resource ID present in the resource name, in the order in which they appear in the resource name.

Here's an example of formatting the resource name for our `offers` topic:

[!code-cs[](obj/snippets/Google.Cloud.Docs.ResourceName.txt#FormatResourceName)]

## Parsing resource IDs from a resource name

As well as the format methods, a static property is provided for each resource, of type
[PathTemplate](obj/api/Google.Api.Gax.PathTemplate.yml). This can be used to parse a resource name (as a string)
into a [ResourceName](obj/api/Google.Api.Gax.ResourceName.yml) object. The resource IDs can then be extracted from
that object either by index or by name. The names of the resource IDs match the names of the parameters in the corresponding
`Format` methods.

The [PublisherClient](Google.Pubsub.V1/api/Google.Pubsub.V1.PublisherClient.html) class has two template properties:

- [ProjectTemplate](Google.Pubsub.V1/api/Google.Pubsub.V1.PublisherClient.html#Google_Pubsub_V1_PublisherClient_ProjectTemplate)
- [TopicTemplate](Google.Pubsub.V1/api/Google.Pubsub.V1.PublisherClient.html#Google_Pubsub_V1_PublisherClient_TopicTemplate)

Likewise, the [SubscriberClient](Google.Pubsub.V1/api/Google.Pubsub.V1.SubscriberClient.html) class has three properties:
- [ProjectTemplate](Google.Pubsub.V1/api/Google.Pubsub.V1.SubscriberClient.html#Google_Pubsub_V1_SubscriberClient_ProjectTemplate)
- [TopicTemplate](Google.Pubsub.V1/api/Google.Pubsub.V1.SubscriberClient.html#Google_Pubsub_V1_SubscriberClient_TopicTemplate)
- [SubscriptionTemplate](Google.Pubsub.V1/api/Google.Pubsub.V1.SubscriberClient.html#Google_Pubsub_V1_SubscriberClient_SubscriptionTemplate)

Example of extracting resource IDs by index:

[!code-cs[](obj/snippets/Google.Cloud.Docs.ResourceName.txt#ParseResourceName_Index)]

Example of extracting resource IDs by name:

[!code-cs[](obj/snippets/Google.Cloud.Docs.ResourceName.txt#ParseResourceName_Name)]
