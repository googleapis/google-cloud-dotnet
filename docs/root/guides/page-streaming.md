
# Page streaming

## Introduction

Many Google APIs expose operations to list resources, possibly
filtering them. Often, there may be many, many matching resources,
so the results are returned one "page" at a time. Each request can
specify a *page token* which identifies the start of the page of
results to return, and each response specifies a *next page token*
to use in the subsequent request. If the end of the logical result
list has been reached, the next page token is not specified.

In addition to the resources in the page, a list response can
include extra information such as the total size of the list,
or perhaps the cost of performing the query.

The code required to iterate over all the results in a list is not
difficult, but it is tedious and error-prone, so the C# client
libraries have abstracted this away.

Operations listing resources synchronously return a
[PagedEnumerable&lt;TResponse, TResource&gt;](../obj/api/Google.Api.Gax.PagedEnumerable-2.yml), and operations listing
resources asynchronously return a
[PagedAsyncEnumerable&lt;TResponse, TResource&gt;](../obj/api/Google.Api.Gax.PagedAsyncEnumerable-2.yml).
These are equivalent other than their asynchrony, so
this document focuses on the synchronous version for simplicity.

## `PagedEnumerable<TResponse, TResource>`

Let's look at the generic type parameters first. The `TResponse` is
the API response type for the list operation, and the `TResource` is
the type of the resource being listed. In the Pub/Sub API for
example, the `ListTopics` operation accepts a `ListTopicsRequest`
and returns a `ListTopicsResponse` containing a set of `Topic`
resources - so the [PublisherClient.ListTopics](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.PublisherClient.html#Google_Cloud_PubSub_V1_PublisherClient_ListTopics_Google_Cloud_PubSub_V1_ProjectName_String_System_Nullable_System_Int32__Google_Api_Gax_CallSettings_)
method returns a `PagedEnumerable<ListTopicsResponse, Topic>`.

`PagedEnumerable<TResponse, TResource>` implements
`IEnumerable<TResource>`.  If you simply iterate over it, you will
retrieve one resource at a time. The implementation will make API
calls as it needs to, retrieving a page at a time and then returning
the resources as the caller requests them.

## `AsRawResponses`

For more advanced scenarios, however, your application may need access
to the raw responses returned by the API instead. The
[PagedEnumerable&lt;TResponse, TResource&gt;.AsRawResponses()](../obj/api/Google.Api.Gax.PagedEnumerable-2.yml#Google_Api_Gax_PagedEnumerable_2_AsRawResponses)
method returns an `IEnumerable<TResponse>`, so you can iterate over the responses easily. Each
response provides access to the individual resources within the page, and some APIs may
provide additional information such as the time taken for the request or the total number of
results across all pages. As you iterate over the pages, API requests are made
transparently, propagating the page token from one response to the next request.

## `ReadPage`

`PagedEnumerable<TResponse, TResource>` also has a 
[ReadPage(int)](../obj/api/Google.Api.Gax.PagedEnumerable-2.yml#Google_Api_Gax_PagedEnumerable_2_ReadPage_System_Int32_)
method to cater for web applications which require precise page sizes.

Although APIs generally allow the application to specify the page size to return, this
is an upper limit rather than a hard requirement. It's possible for an API to return fewer results,
even if more are available - for example, if the server notices that it is close to reaching the specified
RPC deadline. While that's fine for many batch scenarios, it isn't ideal if the results are being presented to users,
where typically you want to provide the exact same number of results per page.

The `ReadPage` method makes multiple API requests if necessary, in order to "fill" a page (of a specified size)
until it reaches the end of the resources being listed. The return value is a
[Page&lt;TResource&gt;](../obj/api/Google.Api.Gax.Page-1.yml#Google_Api_Gax_Page_1) which provides the items
within each page, along with the page token used to retrieve the next page. (This would typically be used in a "next page" link
in the web results.)

## Use case sample code

### Iterate over all resources, ignoring pagination

[!code-cs[](../obj/snippets/Google.Cloud.Docs.PageStreaming.txt#AllResources)]

### Iterate over all responses, remembering page tokens

[!code-cs[](../obj/snippets/Google.Cloud.Docs.PageStreaming.txt#Responses)]

### Obtain a single "natural" page of results

[!code-cs[](../obj/snippets/Google.Cloud.Docs.PageStreaming.txt#SingleResponse)]

### Display the next fixed-sized page of results

This is typically used in web applications; it will only display a less-than-full
page if it reaches the end of the data.

[!code-cs[](../obj/snippets/Google.Cloud.Docs.PageStreaming.txt#ReadPage)]

## Feedback

What other use cases should we consider? Does this meet your current needs?
Please [raise an issue on github](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/new)
to provide feedback.