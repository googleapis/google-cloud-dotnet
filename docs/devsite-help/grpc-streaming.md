# Streaming RPCs

[gRPC](https://grpc.io) supports *streaming RPCs* as well as the more common
*unary* RPCs. The four different kinds of RPC are:

- *Unary*: one request, one response
- *Server-streaming*: one request, a stream of responses
- *Client-streaming*: a stream of requests, one response at the end
- *Bidirectional-streaming* (also known as *bidi-streaming* for short):
  a stream of requests and a stream of responses

More details of the underlying concepts can be found in the
[gRPC core concepts](https://grpc.io/docs/what-is-grpc/core-concepts/)
documentation. This page is focused on how streaming RPCs are used
within Google Cloud Libraries for .NET, and specifically the libraries
where we expect customers to use those RPCs directly. (The libraries
for Firestore, Spanner, Pub/Sub and Bigtable have code wrapping the streaming
RPCs to expose higher-level abstractions.)

Note that this page does not cover client-streaming, as we do not currently
publish any libraries with client-streaming RPCs. A new section will be added
if and when we publish such a library.

## Server-streaming RPCs

A server-streaming RPC starts with a single request, and then the server
sends responses over time, which are read asynchronously. The server indicates
when it has finished sending responses, and the stream completes.

In the Google Cloud Libraries for .NET, an ongoing server-streaming call
is represented by the base class `ServerStreamingBase<TResponse>`, with a
separate derived class for each RPC. For example, in the client library for the
[BigQuery Storage API](https://cloud.google.com/bigquery/docs/reference/storage),
the [BigQueryReadClient.ReadRows](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.BigQuery.Storage.V1/latest/Google.Cloud.BigQuery.Storage.V1.BigQueryReadClient#Google_Cloud_BigQuery_Storage_V1_BigQueryReadClient_ReadRows_Google_Cloud_BigQuery_Storage_V1_ReadRowsRequest_Google_Api_Gax_Grpc_CallSettings_) method returns a [BigQueryReadClient.ReadRowsStream](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.BigQuery.Storage.V1/latest/Google.Cloud.BigQuery.Storage.V1.BigQueryReadClient.ReadRowsStream).

`ServerStreamingBase<TResponse>` has three important aspects:

- It provides a `GetResponseStream()` method to return a conveniently-wrapped
  `IAsyncEnumerable<TResponse>` in the form of `AsyncResponseStream<TResponse>`.
- It exposes the underlying gRPC call via the `GrpcCall` property (in case you
  need access to any of the underlying details).
- It implements `IDisposable`, and will dispose of the underlying gRPC call
  when it's disposed.

The typical usage pattern for a server-streaming call is to keep the call itself
in a variable with a `using` statement to dispose of it automatically, call
`GetResponseStream()` to access the stream of responses, and iterate over them
using an `await foreach` loop.

The sample below demonstrates this for `BigQueryReadClient.ReadRows`; it deliberately
doesn't go into the detail of how the query is set up or how the responses are processed,
as those are API-specific and unrelated to stream usage.

[!code-cs[](../examples/help.Streaming.txt#ServerStreaming)]

## Bidirectional-streaming RPCs

A bidirectional-streaming RPC is started without a client-side request, as clients
can send requests as and when they wish to. Similarly, the server provides a stream
of responses. The request and response streams often involve some sort of "conversation"
where one client request triggers one or more server responses, but they're treated
as separate streams - it would be entirely possible for an API to be designed so that
the client makes all its requests, then the server makes a series of responses, for example.

APIs using bidirectional-streaming calls vary significantly, and you should consult the
API documentation for details. One common pattern is for the *first* client request to
contain some initialization data (for example, the name of a data store to write to) and
subsequent requests are slightly different. Again, consult the API-specific documentation
for details.

In the Google Cloud Libraries for .NET, an ongoing bidirectional-streaming call
is represented by the base class `BidirectionalStreamingBase<TRequest, TResponse>`, with a
separate derived class for each RPC. For example, in the client library for the
[BigQuery Storage API](https://cloud.google.com/bigquery/docs/reference/storage),
the [BigQueryWriteClient.AppendRows](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.BigQuery.Storage.V1/latest/Google.Cloud.BigQuery.Storage.V1.BigQueryWriteClient#Google_Cloud_BigQuery_Storage_V1_BigQueryWriteClient_AppendRows_Google_Api_Gax_Grpc_CallSettings_Google_Api_Gax_Grpc_BidirectionalStreamingSettings_) method returns a [BigQueryWriteClient.AppendRowsStream](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.BigQuery.Storage.V1/latest/Google.Cloud.BigQuery.Storage.V1.BigQueryWriteClient.AppendRowsStream).

`BidirectionalStreamingBase<TRequest, TResponse>` has all the aspects of `ServerStreamingBase<TResponse>` described above, but with additional methods related to the client's request stream:

- `WriteAsync` and `TryWriteAsync` send a request.
- `CompleteAsync` and `TryCompleteAsync` are called by the client to indicate that it has
  finished sending requests.

The requests are stored in a buffer until they can be sent; the buffer capacity can
be specified in the `BidirectionalStreamingSettings` passed into the initial call.

The difference between the methods with a `Try` prefix and those without is about error
handling:

- A call to `WriteAsync` will throw an exception if the client stream has already been
  completed, or if the buffer is full. A call to `TryWriteAsync` in the same failure
  scenarios will return a null `Task` to indicate failure instead.
- A call to `CompleteAsync` will throw an exception if the client stream has already been
  completed. A call to `TryCompleteAsync` will return a null `Task` to indicate failure
  instead.

In most cases, it's more appropriate to use `WriteAsync` and `CompleteAsync`; the `Try` variants
are provided for situations where you may have multiple threads sending requests and potentially
completing the stream.

Unlike the "raw" gRPC stub, users do not need to ensure that only a single request is in-flight
at a time: the buffer takes care of handling multiple requests, so long as the buffer capacity
is not exceeded. The tasks returned by the `TryWrite`/`Write` methods complete when the request has been
written to the underlying stream. The tasks returned by the `TryComplete`/`Complete` methods
complete when the stream has actually been marked as completed. (This only occurs when all the
buffered requests have been written to the stream.)

It's important to complete the request stream, in order to complete the call cleanly.

The sample below demonstrates the use of bidirectional streaming for
`BigQueryWriteClient.AppendRows`; it deliberately doesn't go into the detail of how the requests are
created or how the responses are handled, as those are API-specific and unrelated to stream usage.
Even the aspect of "the requests can all be created independently from the responses" is
API-specific, but the sample provides a reasonably common pattern.

[!code-cs[](../examples/help.Streaming.txt#BidirectionalStreaming)]

## Disposal

While unary RPCs require no special handling, streaming RPC calls *must* be disposed to
avoid resource leaks. The types representing the calls returned by the initial method call
(e.g. `ReadRowsStream` and `AppendRowsStream`) implement `IDisposable`, and should be handled
with a `using` statement where possible. (In more complex scenarios where the call needs to be
preserved across multiple methods, it should be disposed directly at the end.)

Additionally, users should *attempt* to read all the responses from both server-streaming
and bidirectional-streaming calls, unless they have particular reasons not to do so. Disposing
of the call before all the responses have been read effectively aborts the call, which may have
performance implications depending on the exact timing involved. On the other hand, there
can be a performance impact of continuing to read responses (e.g. for a long-running query)
after you've received all the data you're actually interested in. It's all API-specific, but as
a general rule it's better to read the responses where you can do so. See the
[Microsoft gRPC documentation](https://learn.microsoft.com/en-us/aspnet/core/grpc/client?view=aspnetcore-7.0#bi-directional-streaming-call) for more details on this.
