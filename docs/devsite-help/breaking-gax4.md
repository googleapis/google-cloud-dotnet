# Breaking changes (June 2022)

Prior to June 2022, all API client libraries targeted GAX
(Google.Api.Gax and related packages) version 3.x (or older).

[GAX v4.0.0](https://github.com/googleapis/gax-dotnet/releases/tag/Google.Api.Gax-4.0.0)
was released on June 6th 2022, with various breaking changes.
Most of these are *theoretical* breaking changes in that they won't
affect most users; they're changes to API surfaces which are usually only
referenced by generated code. (The generators have been changed to take this into
account, of course.)

That said, there are *some* breaking changes to be aware of that are more likely
to affect users, as described below. If you encounter an issue which isn't
covered below or in the library-specific version history, please
[file a GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose).

## Platform support

GAX v4 targets .NET Standard 2.1 and .NET 4.6.2.
(For reference, GAX v3 supported .NET Standard 2.0 and .NET 4.6.1.)

This means that if you want to use the API libraries targeting GAX
v3, you need to be using .NET Core 3.1 or .NET 4.6.2, or a higher
version of either of these.

## Change of gRPC default implementation

Where available, GAX v4 uses Grpc.Net.Client rather than Grpc.Core as the implementation for gRPC.
For most customers this is entirely transparent, but if you have set any environment variables that
are specific to Grpc.Core (e.g. `GRPC_PROXY`), you may need to *either* force the use of Grpc.Core,
*or* make other code changes to obtain the same result. (The details will depend on exactly what
environment variables are set and why.)

For more information about the rules determining which gRPC implementation is used,
see the [transport selection documentation](transports.md).

## Obsolete members

Obsolete members of libraries have been removed, unless they are part of the API
surface the library exposes.

## IAM methods

Some libraries (e.g. PubSub) included IAM methods directly within the client surface.
These are now exposed via a separate client, accessed via the `IAMPolicyClient` property
of the "main" API client. For example, a previous call of `client.GetIamPolicy(name)`
should be changed to `client.IAMPolicyClient.GetIamPolicy(name)`.

## Client implementation constructors

The client libraries for the gRPC-based APIs have always split the client classes into an abstract base class (e.g. `ExampleClient`)
and a concrete derived class (e.g. `ExampleClientImpl`). While most users won't need to construct
these implementation classes directly (instead using the static `ExampleClient.Create()` method or
`ExampleClientBuilder.Build()`), they're public and have public constructors to support edge cases.

In the GAX v3 generation of libraries, the constructor signature was:

```csharp
public ExampleClientImpl(Example.ExampleClient grpcClient, ExampleSettings settings)
```

(`Example.ExampleClient` is the generated low-level gRPC stub.)

In GAX v4, the constructor also accepts a logger:

```csharp
public ExampleClientImpl(Example.ExampleClient grpcClient, ExampleSettings settings, ILogger logger)
```

The logger may be null, so it's easy to change any code that called the old signature - but it's still a breaking change.