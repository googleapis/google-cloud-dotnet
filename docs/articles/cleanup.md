# Unmanaged resource clean-up

TL;DR: gRPC uses the concept of a *channel* between your application
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
`PublisherClient.ShutDownDefaultChannelsAsync()` and
`SubscriberClient.ShutDownDefaultChannelsAsync()`.)

TODO(jonskeet): More details.
