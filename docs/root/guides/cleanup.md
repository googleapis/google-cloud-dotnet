# Unmanaged resource clean-up

Note: this article is only relevant to libraries which use [gRPC](http://www.grpc.io).
See the [API layers](api-layers.md) article for more details around the differences between
gRPC-based APIs and REST-based APIs.

gRPC uses the concept of a *channel* between your application
and the service implementing an API. This consists of a network
connection and some unmanaged resources which handle its status and
multiplex the requests and responses on it.

Most of the time, you don't need to worry about cleaning up the
unmanaged resources from the C# client libraries.

If you want to handle this explicitly, you can do so by creating
channels yourself and shutting them down in an orderly fashion. For
slightly less control (but a simpler life) you can let the client
libraries create channels themselves as necessary, and shut them
down explicitly using the static `ShutDownDefaultChannelsAsync`
method which each client class exposes. (For example,
[PublisherClient.ShutDownDefaultChannelsAsync()](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.PublisherClient.html#Google_Cloud_PubSub_V1_PublisherClient_ShutDownDefaultChannelsAsync) and
[SubscriberClient.ShutDownDefaultChannelsAsync()](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.SubscriberClient.html#Google_Cloud_PubSub_V1_SubscriberClient_ShutDownDefaultChannelsAsync).)

Finally, gRPC provides an environment-wide shutdown method of `GrpcEnvironment.ShutdownChannelsAsync()`.

In all of these cases, it's entirely feasible to create more channels (implicitly or explicitly)
after shutting others down... it will just require a new network connection to be opened.

If you do not shut down the channels explicitly, they will be closed automatically
when either the application domain is unloaded, or the process exits. For most applications, this is
perfectly adequate; explicit shutdown is only required when your application needs to ensure that
it has handled all requests appropriately before exiting.
