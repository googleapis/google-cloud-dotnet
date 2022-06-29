# Transport selection

Note: this page is only relevant to gRPC-based packages.
The purely-rest-based packages of Google.Cloud.Storage.V1,
Google.Cloud.BigQuery.V2 and Google.Cloud.Translation.V2 do not
have the concept of transport selection.

This page is relevant to any package with a dependency on Google.Api.Gax.Grpc,
including transitive dependencies. (For example, Google.Cloud.Firestore depends
on Google.Cloud.Firestore.V1 which depends on Google.Api.Gax.Grpc).

The client libraries are based on API definitions expressed in
[Protocol Buffers](https://developers.google.com/protocol-buffers).
The API definitions themselves are [available on GitHub](https://github.com/googleapis/googleapis).

Most APIs can be accessed via two different transports:

- HTTP/1.1 with JSON requests and responses. This is also known as the REST transport.
  (We make no claims that it's fully RESTful, but it's intended to be "somewhat REST-like".)
- HTTP/2.0 with protobuf binary requests and responses. This is also known as the gRPC
  transport.

Within the Google Cloud .NET client libraries, the transport and implementation choice are
represetned by the `GrpcAdapter` type. There are currently three implementations:

- `GrpcNetClientAdapter` (based on the Grpc.Net.Client package)
- `GrpcCoreAdapter` (based on the Grpc.Core package)
- `RestGrpcAdapter` (implemented within Google.Api.Gax.Grpc)

Although "REST gRPC adapter" sounds like a contradiction in terms, this is an implementation of the gRPC API
in Grpc.Core.Api (and in particular its `ChannelBase` and `CallInvoker` aspects) that communicates using HTTP/1.1 and JSON.
Using the gRPC API as a common abstraction allows most code to be transport-agnostic.

As of June 2022, the Google.Cloud.Compute.V1 package *only* supports the REST transport, and all other
packages *only* support the gRPC transport. Over time we expect more packages to support the REST
transport, which may be useful in situations where HTTP/2.0 is not fully supported on customer networks.
(For example, we sometimes see proxies which don't fully support it.)

In many situations, application code does not need to customize the choice of gRPC adapter at all.
However, it can provide additional control, and the remainder of this page documents the ways in which the
gRPC adapter can be specified and customized.

## Default selection

By default - e.g. just using `ExampleClient.Create()` - the selection process is as follows:

- Does the package support the gRPC transport? If so:
  - Is the `GRPC_DEFAULT_ADAPTER_OVERRIDE` environment variable set? If so, use the adapter based on the value:
    - A value of `Grpc.Net.Client` will use `GrpcNetClientAdapter`
    - A value of `Grpc.Core` will use `GrpcCoreAdapter`
    - An empty value is ignored
    - Any other value will cause an exception
  - Does constructing a `Grpc.Net.Client.GrpcChannel` succeed? If so, use `GrpcNetClientAdapter`
  - Otherwise, use `GrpcCoreAdapter`
- Otherwise, use `RestGrpcAdapter`

## Specifying an implementation in code

If you explicitly want to specify a `GrpcAdapter` in code, there are two options.

Firstly, you can specify the adapter directly via the `GrpcAdapter` property in the client builder. For example:

```csharp
ExampleClient client = new ExampleClientBuilder
{
    GrpcAdapter = GrpcNetClientAdapter.Default
}.Build();
```

Alternatively, if you're using dependency injection using `Microsoft.Extensions.DependencyInjection`,
you can register the `GrpcAdapter` in the service collection. That will then be used by any clients
created via that service collection, as described in the [client lifecycle documentation](client-lifecycle.md).

You can register the adapter directly, or use the following extension methods in `GaxGrpcServiceCollectionExtensions`:

- `AddGrpcNetClientAdapter` (with an optional `Action<IServiceProvider, Grpc.Net.Client.GrpcChannelOptions>` for additional configuration)
- `AddGrpcCoreAdapter`
- `AddRestGrpcAdapter`

The `AddGrpcNetClientAdapter` configures dependency injection to pass the service provider to `GrpcChannelOptions`,
which in turn means that other dependencies (such as logging and `HttpClient`) can be obtained in a consistent way.
As such, when using dependency injection to construct clients (and where Grpc.Net.Client works - see below),
we recommend using the extension method rather than just relying on the default selection process
(which doesn't have access to dependency injection, and so can't configure logging etc).

## Notes on using Grpc.Net.Client

*In general*, Grpc.Net.Client works on .NET Core 3.1 and higher (including .NET 5+) but does not work on .NET Framework.
Additional steps can be taken to enable it in .NET Framework, based on the availability of `WinHttpClientHandler`
and Windows updates. See [the Microsoft
documentation](https://docs.microsoft.com/en-us/aspnet/core/grpc/supported-platforms?view=aspnetcore-6.0#net-grpc-client-requirements) for more details.

Google.Api.Gax.Grpc already depends on Grpc.Net.Client, so no additional dependencies are required.

## Notes on using Grpc.Core

Grpc.Core is an older implementation of the gRPC protocols for .NET, based on native code.
The package is [in maintenance mode](https://grpc.io/blog/grpc-csharp-future/), and is supported
primarily for the sake of .NET Framework workloads. Where possible, we recommend using Grpc.Net.Client instead.

The Grpc.Core package is relatively large (around 17MB as of version 2.46.3), and as it is not required
in modern environments (and not even in .NET Framework environments in some cases) there is no dependency
on it in Google.Api.Gax.Grpc. Instead, the `GrpcCoreAdapter` attempts to use reflection in order to initialize
it. If the `Grpc.Core` package is not installed, this will fail at execution time.

Each of the Google Cloud Libraries for .NET has a *conditional* dependency on Grpc.Core: the `net462` target
depends on Grpc.Core, but the `netstandard2.1` target does not. The intention of this is to allow *most*
applications to work out of the box with a simple dependency on the required client library package, but without
additional unnecessary dependencies.
