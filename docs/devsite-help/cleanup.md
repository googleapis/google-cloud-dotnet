# Unmanaged resource clean-up

## gRPC-based APIs and channels

Clients are thread-safe, and in general we recommend using a single
instance across a whole application unless you particularly need
different settings for some clients.

gRPC uses the concept of a *channel* between your application
and the service implementing an API. This consists of a network
connection and some unmanaged resources which handle its status and
multiplex the requests and responses on it.

Most of the time, you don't need to worry about cleaning up the
unmanaged resources from the C# client libraries. If you use
multiple client instances created in an entirely-default way, a
single gRPC channel will be shared between all instances.

If you want to handle this explicitly, you can do so by creating
channels yourself and shutting them down in an orderly fashion. For
slightly less control (but a simpler life) you can let the client
libraries create channels themselves as necessary, and shut them
down explicitly using the static `ShutDownDefaultChannelsAsync`
method which each client class exposes. (For example,
[PublisherServiceApiClient.ShutDownDefaultChannelsAsync()](xref:Google.Cloud.PubSub.V1.PublisherServiceApiClient#Google_Cloud_PubSub_V1_PublisherServiceApiClient_ShutDownDefaultChannelsAsync) and
[SubscriberServiceApiClient.ShutDownDefaultChannelsAsync()](xref:Google.Cloud.PubSub.V1.SubscriberServiceApiClient#Google_Cloud_PubSub_V1_SubscriberServiceApiClient_ShutDownDefaultChannelsAsync).)

Finally, gRPC provides an environment-wide shutdown method of `GrpcEnvironment.ShutdownChannelsAsync()`.

In all of these cases, it's entirely feasible to create more channels (implicitly or explicitly)
after shutting others down... it will just require a new network connection to be opened.

If you do not shut down the channels explicitly, they will be closed automatically
when either the application domain is unloaded, or the process exits. For most applications, this is
perfectly adequate; explicit shutdown is only required when your application needs to ensure that
it has handled all requests appropriately before exiting.

For more information, see the [client lifecycle documentation](client-lifecycle.md)

## REST-based APIs

Summary: Use a single client if you can. Clients are threads-safe,
so in most situations you can use a single client for the whole
application. If you have to create multiple clients at a high
frequency, dispose of them when you're done.

Just as a reminder, Google Cloud Client Libraries for .NET has three
libraries for REST-based APIs:

- Google.Cloud.Storage.V1 (StorageClient)
- Google.Cloud.BigQuery.V2 (BigQueryClient)
- Google.Cloud.Translation.V2 (TranslationClient, AdvancedTranslationClient)

In November 2017, these client classes were changed to implement the
`IDisposable` interface. The `Dispose` method simply disposes of the
underlying service object, which in turn disposes of the underlying
`HttpClient`.

There are three broad usage scenarios to consider:

- A single long-lived client object (or perhaps a limited set,
  e.g. using different credentials) used for many operations.
- A new client used for each set of operations, e.g. a new client
  created for each incoming request on a web site, but with relatively
  low-frequency use.
- A new client created for each set of operations, with high-frequency
  use.
  
The ability to dispose of the client really only affects the last of
these scenarios. The way that `HttpClient` works has two downsides
when new clients are created frequently:

- Connections to the API server (e.g. the Storage API server) can
  take a long time to close. This can cause problems if you're running
  in an environment with a limited number of available connections.
- Buffers within `HttpClient` can consume memory for longer than is
  desirable.
  
In many cases these don't actually cause problems - if you don't
reach your connection limit, and the garbage collector is collecting
the `HttpClient` buffers fast enough to keep your memory usage low,
you're fine. Likewise if you only ever create a limited set of
client objects, you shouldn't run into issues.

In other cases, where (for whatever reason) you really want to
create a lot of client objects in quick succession, it's prudent to
dispose of the clients when you're done with them. Now that the
client classes implement `IDisposable`, you can simply use `using`
statements in the normal way.
