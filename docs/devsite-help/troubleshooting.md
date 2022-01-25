# Frequently Asked Questions

## How can I trace gRPC issues?

> Note: this guidance only applies when using Grpc.Core, which is currently the
> default gRPC implementation. We intend to update this documentation with
> respect to Grpc.Net.Client before adopting that as the default implementation.

For libraries that use gRPC, it can be very useful to hook into the
gRPC logging framework. There are two aspects to this:

- Setting environment variables
- Directing logs

The environment variables affecting gRPC are [listed in the gRPC
repository](https://github.com/grpc/grpc/blob/master/doc/environment_variables.md).
The important ones for diagnostics are `GRPC_TRACE` and
`GRPC_VERBOSITY`. For example, you might want to start off with
`GRPC_TRACE=all` and `GRPC_VERBOSITY=DEBUG` which will dump a *lot*
of information, then tweak them to reduce this to only useful
data... or start with one kind of tracing (e.g.
`GRPC_TRACE=call_error`) and add more as required.

By default, the gRPC logs will not be displayed anywhere. The
simplest way of seeing gRPC logs in many cases will be to send them
to the console:

```csharp
using Grpc.Core;
using Grpc.Core.Logging;
...
// Call this before you do any gRPC work
GrpcEnvironment.SetLogger(new ConsoleLogger());
```

Other `ILogger` implementations are available, or you can implement
it yourself to integrate with other systems - see the
[Grpc.Core.Logging](https://github.com/grpc/grpc/tree/master/src/csharp/Grpc.Core/Logging)
namespace for details.

## How can I trace requests and responses in REST-based APIs?

For libraries that use HTTP1.1 and REST, it can be useful to perfom request and response
logging. There are two aspects to this:

- Registering a global logger
- Configuring the events to log in a specific service

The underlying service is available via the `Service` property in each `XyzClient` class. Within
that service, you need to configure the `HttpClient`'s message handler. As a complete example,
here's a call to the Translation API, listing all the available languages, and logging the request
headers and the response body:

[!code-cs[](../examples/help.Faq.txt#RestLogging)]

To log *all* events from the message handler, you can set the `LogEvents` property to
`~LogEventType.None`.



## Why aren't the gRPC native libraries being found?

The native libraries that gRPC relies on are present in
[Grpc.Core](https://www.nuget.org/packages/Grpc.Core/),
and the NuGet package has targets to copy them to appropriate output
directories. However, due to the way NuGet dependencies are
generated with .NET Core, you may find that with transitive
dependencies, the targets aren't executed.

We've set up our client libraries (e.g. `Google.Cloud.Datastore.V1`)
so that if you directly depend on any of them, everything should
work - but if your application only has transitive dependencies, you
could run into errors like this:

```text
Unhandled Exception: System.IO.FileNotFoundException:
  Error loading native library. Not found in any of the possible locations: [...]
   at Grpc.Core.Internal.UnmanagedLibrary.FirstValidLibraryPath(String[] libraryPathAlternatives)
   at Grpc.Core.Internal.UnmanagedLibrary..ctor(String[] libraryPathAlternatives)
   at Grpc.Core.Internal.NativeExtension.Load()
   at Grpc.Core.Internal.NativeExtension..ctor()
   at Grpc.Core.Internal.NativeExtension.Get()
   at Grpc.Core.GrpcEnvironment.GrpcNativeInit()
   at Grpc.Core.GrpcEnvironment..ctor()
   ...
```

In that case, the simplest fix is to add a direct dependency to
`Grpc.Core` from your application, which will ensure that the
native libraries are copied appropriately.

## How can I modify repeated fields and maps in protobuf messages?

The generated C# code for protobuf messages makes simple properties
read/write, but repeated fields and map fields are read-only. That
doesn't stop you from populating them, though: it just means you
can't change the property to refer to a *different* list or map.

Typically you'll populate this using a *collection initializer*
nested within an *object initializer*. As an example, let's look at
how we might create a `BatchAnnotateImagesRequest` message in the
Vision API. (This is just an easy-to-understand example; the
Google.Cloud.Vision.V1 package provides helper methods to avoid you
having to create batches yourself in most cases.)

The protobuf description looks like this:

```proto
// Multiple image annotation requests are batched into a single service call.
message BatchAnnotateImagesRequest {
  // Individual image annotation requests for this batch.
  repeated AnnotateImageRequest requests = 1;
}
```

In the generated C# code, the `Requests` property of
`BatchAnnotateImagesRequest` is read-only, but you can populate it
with a collection initializer:

[!code-cs[](../examples/help.Faq.txt#ProtoRepeatedField1)]

You don't *have* to use a collection initializer though, and
sometimes it would be inconvenient to do so. It's perfectly valid to
add to the repeated field after other initialization:

[!code-cs[](../examples/help.Faq.txt#ProtoRepeatedField2)]

Finally, it's worth being aware that `RepeatedField<T>` has an `Add`
overload accepting an `IEnumerable<T>`. This allows you to use a
collection initializer to copy items out of another collection, or a
LINQ query result:

[!code-cs[](../examples/help.Faq.txt#ProtoRepeatedField3)]

Likewise for map fields (which are significantly less common) you
can use collection initializers, or (from C# 6 onwards) the indexer
syntax within an object initializer. As an example of this, let's
consider the Scheduler V1 API, which contains a message like this:

```proto
message HttpTarget {
  // Other fields omitted

  // The user can specify HTTP request headers to send with the job's
  // HTTP request. (Further documentation omitted here.)
  map<string, string> headers = 3;
}
```

Again, the `Headers` property in the generated message is read-only,
but you can populate it with a collection initializer:

[!code-cs[](../examples/help.Faq.txt#ProtoMap1)]

Or an indexer in an object initializer:

[!code-cs[](../examples/help.Faq.txt#ProtoMap2)]

Or modify it after other initialization steps:

[!code-cs[](../examples/help.Faq.txt#ProtoMap3)]

## Why is System.EntryPointNotFoundException being thrown?

While there are various *potential* causes for this, the most likely
cause is that you have a dependency on Grpc.Core 2.x, but you're
still depending on Google Cloud libraries that depend on Grpc.Core
1.x.

We have now released client libraries (some of them still in beta,
but most GA) which use GAX 3.x, which depends on Grpc.Core 2.x. If
you update to the latest version of the client library, that should
fix the issue.
