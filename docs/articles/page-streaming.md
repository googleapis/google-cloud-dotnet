# Page streaming

## Introduction

Many Google APIs expose operations to list resources, possibly
filtering them. Often, there may be many, many matching resources,
so the results are returned one "page" at a time. Each request can
specify a *page token* which identifies the start of the page of
resluts to return, and each response specifies a *next page token*
to use in the subsequent request. If the end of the logical result
list has been reached, the next page token is not specified.

In addition to the resources in the page, a list response can
include extra information such as the total size of the list,
or perhaps the cost of performing the query.

The code required to iterate over all the results in a list is not
difficult, but it is tedious and error-prone, so the C# client
libraries have abstracted this away.

Operations listing resources synchronously return an
`IPagedEnumerable<TResponse, TResource>`, and operations listing
resources asynchronously return an `IPagedAsyncEnumerable<TResponse,
TResource>`. These are equivalent other than their asynchrony, so
this document focuses on the synchronous version for simplicity.

## `IPagedEnumerable<TResponse, TResource>`

Let's look at the generic type parameters first. The `TResponse` is
the API response type for the list operation, and the `TResource` is
the type of the resource being listed. In the Pub/Sub API for
example, the `ListTopics` operation accepts a `ListTopicsRequest`
and returns a `ListTopicsResponse` containing a set of `Topic`
resources - so the method to list topics with page streaming returns
an `IPagedEnumerable<ListTopicsResponse, Topic>`.

`IPagedEnumerable<TResponse, TResource>` implements
`IEnumerable<TResource>`.  If you simply iterate over it, you will
retrieve one resource at a time. The implementation will make API
calls as it needs to, retrieving a page at a time and then returning
the resources as the caller requests them.

TODO(jonskeet): Complete this, talking about `AsPages` etc.

## Use cases

### Iterate over all resources, ignoring pagination

### Iterate over all resources, remembering page tokens

### Obtain a single page of results

If you want to make exactly one API call, as if you were using the
underlying API, you can call the page-streaming method and simply
use the `First()` method from LINQ.

### Display results in fixed-sized pages

This is typically useful in web applications.
