# Frequently Asked Questions

## How can I use non-default credentials for gRPC-based APIs?

The generated classes for gRPC-based APIs (such as
[PublisherClient](Google.Pubsub.V1/api/Google.Pubsub.V1.PublisherClient.html))
have `Create` overloads of this form:

```csharp
public static PublisherClient Create(ServiceEndpoint endpoint = null, PublisherSettings settings = null)

public static PublisherClient Create(Channel channel, PublisherSettings settings = null)
```

(Equivalent asynchronous overloads exist as well.)

The first of these uses the default credentials to create a channel
which is shared by all instances created in the same way, and
optionally shut down using the `ShutDownDefaultChannelsAsync` method.

The second of these never creates a new channel, and the caller is
responsible for explicit clean-up if required. See ["Unmanaged
resource clean-up"](cleanup.md) for more details on situations where
this is important.

To create a client with specific credentials, you have to create the
channel yourself, as the client doesn't expose the channel it uses.
Creating a channel is simple, once you have a `ChannelCredentials`
object, typically created using the `ToChannelCredentials` extension
method. For example, to create a channel for a specific user:

```csharp
// Make the ToChannelCredentials extension method available
using Grpc.Auth;

...

// Obtain a user's credentials in an appropriate manner for your
// application. See
// https://developers.google.com/api-client-library/dotnet/guide/aaa_oauth
UserCredential userCredential = ...;
ChannelCredentials channelCredentials = userCredential.ToChannelCredentials();
Channel channel = new Channel(PublisherClient.DefaultEndpoint, channelCredentials);
PublisherClient client = PublisherClient.Create(channel);
// Now use client, and clean up channel if and when you need to.
```

Note that it's also possible to specify credentials for an
individual RPC call. For example, you can create a channel using the
default application credentials, then specify a `CallCredentials` in
the `CallSettings` passed to a single method call. The
`ToCallCredentials()` method can be used to create a
`CallCredentials`:

```csharp
// Make the ToCallCredentials extension method available
using Grpc.Auth;

...

// Obtain a user's credentials in an appropriate manner for your
// application. See
// https://developers.google.com/api-client-library/dotnet/guide/aaa_oauth
UserCredential userCredential = ...;
CallCredentials callCredentials = userCredential.ToCallCredentials();

// Use the default application credentials for the channel.
PublisherClient client = PublisherClient.Create();
client.Publish(/* regular method arguments */,
    CallSettings.FromCallCredentials(callCredentials));
```

This approach means you don't need to worry about channel clean-up.

## How can I trace gRPC issues?

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

[!code-cs[](obj/snippets/Google.Cloud.Docs.Faq.txt#RestLogging)]

To log *all* events from the message handler, you can set the `LogEvents` property to
`~LogEventType.None`.

## How can I use emulators?

Some APIs (such as Datastore and PubSub) provide emulators in the
[Cloud SDK](https://cloud.google.com/sdk/). Client libraries in some
other languages automatically use emulators if specific environment
variables are set, but the Google Cloud Libraries for .NET do not do
this. (We are hoping to work with a more ambient emulator manager
solution which does not require environment variables, and is
therefore more amenable to IDEs such as Visual Studio.)

However, it is quite simple to manually create the appropriate
client for gRPC-based APIs, by first creating a channel and then
passing that to the static `Create` method of the relevant client
class. Note that in current emulator implementations, the channel
credentials must be set to `ChannelCredentials.Insecure`.

Example for PubSub:

[!code-cs[](obj/snippets/Google.Cloud.Docs.Faq.txt#Emulator)]
