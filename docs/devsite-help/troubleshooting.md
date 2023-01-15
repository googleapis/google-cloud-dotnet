# Troubleshooting

See the [support page](support.md) for suggestions about how to ask for more help
if the sections below don't cover your question.

## How can I trace gRPC issues?

When working with libraries that use gRPC, you need to be aware of which gRPC
implementation you're using in order to enable logging.

For libraries released from June 2022 onwards, the default gRPC implementation is Grpc.Net.Client
in environments where that works (in particular .NET Core 3.1 and .NET 5 and higher). The
older Grpc.Core implementation is used in those .NET Framework environments where Grpc.Net.Client
isn't available. See the [transports documentation](transports.md) for more information about
gRPC implementation selection.

### Client-level logging

The [client builder used to configure clients](client-configuration.md) has a `Logger` property
which logs trace-level messages. This only provides basic information on when API calls start, end,
or are retried, but that can still be useful for diagnostic purposes.

The logger will automatically be configured if you use dependency injection to configure the client.
If you wish to log manually, you can create a logger factory and then a logger explicitly:

```csharp
var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole().SetMinimumLevel(LogLevel.Trace));
var client = new ExampleClientBuilder
{
    Logger = loggerFactory.CreateLogger("ExampleClient")
}.Build();
```

Adding this code into the [getting started Translation sample code](getting-started.md) produces output such as this:

```text
trce: TranslationClient[0]
      Starting synchronous API call to TranslateText.
trce: TranslationClient[0]
      Call completed to TranslateText.
```

### Transport logging with Grpc.Net.Client

The `GrpcChannelOptions` class in Grpc.Net.Client has a `LoggerFactory` property that can be set
to log debug and trace messages. If you're configuring clients via dependency injection, then simply calling
`AddGrpcNetClientAdapter()` on the service collection will ensure that the client is constructed with the loggers
from the resulting service provider. For example, to make a `ExampleClient` available to dependency
injection with logging configured automatically, you might use:

```csharp
builder.Services
    .AddGrpcNetClientAdapter()
    .AddExampleClient();
```

If you're not using dependency injection, it's still reasonably straightforward to create a logger factory
and configure a client to use it:

```csharp
var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole().SetMinimumLevel(LogLevel.Debug));
var grpcAdapter = GrpcNetClientAdapter.Default
    .WithAdditionalOptions(options => options.LoggerFactory = loggerFactory);

var client = new ExampleClientBuilder
{
    GrpcAdapter = grpcAdapter
}.Build();
```

Note that however the logger is set up, it needs to be configured with a minimum log level of debug or trace
in order to be useful.

Adding this code into the [getting started Translation sample code](getting-started.md) produces output such as this:

```text
dbug: Grpc.Net.Client.Internal.GrpcCall[1]
      Starting gRPC call. Method type: 'Unary', URI: 'https://translate.googleapis.com/google.cloud.translation.v3.TranslationService/TranslateText'.
dbug: Grpc.Net.Client.Balancer.Subchannel[1]
      Subchannel id '1' created with addresses: translate.googleapis.com:443

... (more output) ...

dbug: Grpc.Net.Client.Internal.GrpcCall[18]
      Sending message.
dbug: Grpc.Net.Client.Internal.GrpcCall[13]
      Reading message.
dbug: Grpc.Net.Client.Internal.GrpcCall[4]
      Finished gRPC call.
```

With a minimum log level of Trace, there's considerably more output.

### Transport logging with Grpc.Core

There are two aspects to configuring logging with Grpc.Core.

- Setting environment variables
- Directing logs

The environment variables affecting gRPC are [listed in the gRPC
repository](https://github.com/grpc/grpc/blob/master/doc/environment_variables.md).
The important ones for diagnostics are `GRPC_TRACE` and
`GRPC_VERBOSITY`. For example, you might want to start off with
`GRPC_TRACE=all` and `GRPC_VERBOSITY=debug` which will dump a *lot*
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

Adding this code into the [getting started Translation sample code](getting-started.md),
using `GRPC_VERBOSITY=info` and `GRPC_TRACE=all` produces output starting with lines such as this:

```text
D1128 12:45:03.460271 Grpc.Core.Internal.UnmanagedLibrary Attempting to load native library "C:\Users\[...]\GettingStarted\bin\Debug\net48\grpc_csharp_ext.x64.dll"
D1128 12:45:03.549778 Grpc.Core.Internal.NativeExtension gRPC native library loaded successfully.
I1128 12:45:03.564911 0 ..\..\..\src\core\lib\iomgr\timer_manager.cc:88: Spawn timer thread
I1128 12:45:03.564911 0 ..\..\..\src\core\lib\surface\init.cc:196: grpc_init(void)
```

## How can I trace requests and responses in REST-based APIs?

For libraries that use HTTP1.1 and REST (Google.Cloud.Storage.V1, Google.Cloud.BigQuery.V2, Google.Cloud.Translation.V2),
it can be useful to perfom request and response logging. There are two aspects to this:

- Registering a global logger
- Configuring the events to log in a specific service

The underlying service is available via the `Service` property in each `XyzClient` class. Within
that service, you need to configure the `HttpClient`'s message handler. As a complete example,
here's a call to the Translation API, listing all the available languages, and logging the request
headers and the response body:

[!code-cs[](../examples/help.Faq.txt#RestLogging)]

To log *all* events from the message handler, you can set the `LogEvents` property to
`~LogEventType.None`.

The above sample code produces output such as this:

```text
D2022-11-28 12:50:31.615723 Google.Apis.Auth.OAuth2.DefaultCredentialProvider Loading Credential from file [...]
D2022-11-28 12:50:31.991560 Google.Apis.Auth.OAuth2.ServiceCredential Token has expired, trying to get a new one.
D2022-11-28 12:50:32.024800 Google.Apis.Auth.OAuth2.ServiceCredential Request a new access token. Assertion data is: [...]
D2022-11-28 12:50:32.027101 Google.Apis.Http.ConfigurableMessageHandler Request[00000001] (triesRemaining=3) URI: 'https://oauth2.googleapis.com/token'
D2022-11-28 12:50:32.351707 Google.Apis.Http.ConfigurableMessageHandler Response[00000001] Response status: OK 'OK'
I2022-11-28 12:50:32.360147 Google.Apis.Auth.OAuth2.ServiceCredential New access token was received successfully
D2022-11-28 12:50:32.366091 Google.Apis.Http.ConfigurableMessageHandler Request[00000001] Headers:
  [User-Agent] 'gcloud-dotnet/3.1.0; google-api-dotnet-client/1.57.0.0; (gzip)'
  [x-goog-api-client] 'gl-dotnet/7.0.0 gccl/3.1.0 gax/4.0.0 gdcl/1.57.0.875'
  [Authorization] 'Bearer [...]'
D2022-11-28 12:50:32.463410 Google.Apis.Http.ConfigurableMessageHandler Response[00000001] Body: '{.  "data": {.    "languages": [ { ... }, { ... }, ... ] }'
```

## How can I debug into the libraries?

The NuGet packages for the libraries contain the PDB files
and SourceLink information required to enable a rich debugging experience,
but in many build scenarios the PDB files are not automatically copied.
If you need to debug into the library code itself (whether for the
API-specific library or support libraries such as Google.Apis.Auth,
Google.Protobuf or Google.Api.Gax.Grpc), set the
`CopyDebugSymbolFilesFromPackages` build property to `true`, for example
by adding the element below to a `<PropertyGroup>` element in your project file:

```xml
<CopyDebugSymbolFilesFromPackages>true</CopyDebugSymbolFilesFromPackages>
```

Note that this requires the .NET 7 SDK (even if you have a different target
for your application), and you should have the "Enable Just My Code" checkbox
in Visual Studio *unchecked*.

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

This information is now in the [protocol buffers guide](protobuf.md#repeated-fields-and-maps); this section has been
retained for the sake of existing links.

## How can I get ErrorInfo from RpcException?

`ErrorInfo` in `RpcException` provides a consistent and human readable error details.
It contains three major fields - reason, domain and metadata described as below:

- `Reason`: the proximate cause of the error. This is a stable unique identifier for this
   type of error within the domain, and can be used to programmatically determine
   how to handle the error.
- `Domain`: the logical grouping to which the error belongs. The error domain
   is typically the registered service name of the tool or product that
   generates the error. Example: "pubsub.googleapis.com". If the error 
   is generated by some common infrastructure, the error domain will be 
   a globally unique value that identifies the infrastructure. 
   For Google API infrastructure, the error domain is "googleapis.com".
- `Metadata`: additional structured details about the error.

```csharp
using Google.Api.Gax.Grpc;
try
{
    // Code that can throw the RpcException.
}
catch (RpcException ex)
{
    if (ex.GetErrorInfo() is ErrorInfo errorInfo)
    {
        var domain = errorInfo.Domain;
        var reason = errorInfo.Reason;
        var metadata = errorInfo.Metadata;
        // Use the domain, reason and metadata of ErrorInfo, e.g. for logging or taking remedial action.
    }
    else
    {
        // Use RpcException's other properties (e.g. Status and Message) to handle the exception appropriately.
    }
}
```
