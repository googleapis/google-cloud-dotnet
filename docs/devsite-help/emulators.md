# Emulator support

## ClientBuilder dedicated support

Some APIs (such as Datastore and PubSub) provide emulators in the
[Cloud SDK](https://cloud.google.com/sdk/). Client libraries in some
other languages automatically use emulators if specific environment
variables are set, but the Google Cloud Libraries for .NET
deliberately do not do this, to avoid accidentally using an emulator
when production was expected or vice versa.

The packages for the following APIs support emulators directly in the way described below:

- PubSub
- Firestore
- Bigtable
- Spanner
- Datastore

In these packages, the client builder type has an `EmulatorDetection`
property which can be set to one of the following values:

- `None` (the default): Ignores the presence or absence of emulator configuration.
- `ProductionOnly`: Always connects to the production servers, but
   throws an exception if an emulator configuration is detected that would suggest connecting to
   an emulator is expected.
- `EmulatorOnly`: Always connect to the emulator, throwing an exception if no emulator
   configuration is detected.
- `EmulatorOrProduction`: Connect to the emulator if an emulator configuration is detected,
  or production otherwise. This is a convenient option, but risks damage to
  production databases or running up unexpected bills if tests are accidentally
  run in production due to the emulator configuration being absent unexpectedly.
  (Using separate projects for production and testing is a best practice for
  preventing the first issue, but may be unrealistic for small or hobby projects.)

Here emulator configuration presence is usually interpreted as
"appropriate environment variables being set", but it is possible
that in the future there will be other conventions for
configuring emulators.

For example, the following code creates a PubSub `SubscriberServiceApiClient`
that will connect to the PubSub emulator if the
`PUBSUB_EMULATOR_HOST` environment variable is set, but will
otherwise connect to the production environment.

[!code-cs[](../examples/help.Emulator.txt#ClientBuilderSupport)]

Note that the PubSub `SubscriberClient` and `PublisherClient`
classes don't have builders. Instead, they have nested
`ClientCreationSettings` with emulator detection. The following code
connects to the PubSub emulator for a `SubscriberClient`:

[!code-cs[](../examples/help.Emulator.txt#SubscriberClient)]

## Manually connecting to an emulator

If you need to connect to an emulator directly (for example because
it is not yet supported in the library for the API you're using),
simply use the appropriate client builder, set the endpoint to the
host and port the emulator is listening on, and set the credentials to
to `ChannelCredentials.Insecure`.

Example for PubSub (although the techniques above are preferred):

[!code-cs[](../examples/help.Emulator.txt#ManualConnection)]

## Grpc.Net.Client and .NET Core 3.1

As of GAX v4, the default gRPC implementation (where available) is Grpc.Net.Client.
(See the [transport selection documentation](transports.md) for more details.) By default, .NET Core 3.1
does not support unencrypted HTTP/2 connections - whereas this is required for emulator
connections.

Without any additional code, .NET Core 3.1 connections to the emulator will fail
with a variety of error messages, including:

> System.Net.Sockets.SocketException (10054): An existing connection was forcibly closed by the remote host.

and

> Grpc.Core.RpcException : Status(StatusCode="Internal", Detail="Bad gRPC response. Response protocol downgraded to HTTP/1.1.")

This can easily be fixed using an [AppContext switch](https://docs.microsoft.com/en-us/dotnet/api/system.appcontext?view=net-6.0):

```csharp
AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
```

This code is deliberately *not* included in the client libraries, as it is an application-wide
switch that you should consider carefully before enabling. In most cases we expect that it's safe
and appropriate when testing an application against an emulator, but that's not a decision
that the client libraries can reasonably take for themselves.

This switch is not required when running .NET 6.
