{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

[PublisherServiceApiClient](obj/api/Google.Cloud.PubSub.V1.PublisherServiceApiClient.yml) and
[SubscriberServiceApiClient](obj/api/Google.Cloud.PubSub.V1.SubscriberServiceApiClient.yml)
provide a general-purpose abstraction over raw the RPC API, providing
features such as page streaming to make client code cleaner and
simpler.

[PublisherClient](obj/api/Google.Cloud.PubSub.V1.PublisherClient.yml) and [SubscriberClient](obj/api/Google.Cloud.PubSub.V1.SubscriberClient.yml) provide simpler APIs for message publishing and subscribing. These classes offer considerably higher performance and simplicity, especially when working with higher message throughput.

Note that both `PublisherClient` and `SubscriberClient` expect to
execute in an environment with continuous processing and continuous
network access to the Pub/Sub API. In environments such as Cloud Run
or Cloud Functions, where servers do not use any CPU between requests,
the `PublisherServiceApiClient` and `SubscriberServiceApiClient` classes
should be used instead.

## Sample code

Using [PublisherClient](obj/api/Google.Cloud.PubSub.V1.PublisherClient.yml) and [SubscriberClient](obj/api/Google.Cloud.PubSub.V1.SubscriberClient.yml) for message publishing and subscribing:

{{sample:SubscriberServiceApiClient.SimpleOverview}}

Using [PublisherServiceApiClient](obj/api/Google.Cloud.PubSub.V1.PublisherServiceApiClient.yml) and
[SubscriberServiceApiClient](obj/api/Google.Cloud.PubSub.V1.SubscriberServiceApiClient.yml) only:

{{sample:SubscriberServiceApiClient.Overview}}

## Performance considerations and default settings

`PublisherClient` and `SubscriberClient` are optimized for high-throughput high-performance scenarios,
and default settings have been chosen with this in mind;
however, note that these classes are also well suited to use cases where performance is not a major
consideration.

By default multiple gRPC channels are created on client startup, with the channel count defaulting to
the CPU processor count as returned by `Environment.ProcessorCount`. This is to allow greater bandwidth
than a single gRPC channel can support; the processor count is a pragmatic choice to approximately
scale maximum throughput performance by potential machine workload.

When using multiple clients on a machine with a high processor count, this may cause problems
with TCP connection exhaustion. Set the relevant builder `ClientCount` property to a low value
(`1` is suitable for low or moderate throughput requirements) to mitigate this.

## Coding considerations

`PublisherClient` and `SubscriberClient` are expensive to create, so when regularly publishing or
subscribing to the same topic or subscription then a singleton client instance should be created and
used for the lifetime of the application.

Both synchronous `Create(...)` and asynchronous `CreateAsync(...)` methods are provided, but note that
when using default credentials on Google Compute Engine (GCE) then a network request may need to be made
to retrieve credentials from the GCE Metadata Server.

The overloads for `Create` and `CreateAsync` accepting just a topic or subscription name use default
settings for everything else, and are the most convenient approach for creating clients when the defaults
are acceptable. For further customization (e.g. to set different credentials, or a different client count)
we recommend using `PublisherClientBuilder` and `SubscriberClientBuilder` for consistency with other
APIs, and for maximum flexibility. There are overloads of `Create` and `CreateAsync` accepting
publisher/subscriber-specific `ClientCreationSettings`, but these are legacy methods from versions where
the builders did not exist. They are likely to be removed in future major versions.

When publishing, the `Task` returned by the various `Publish(...)` methods will complete only
when the message has been sent to the PubSub server, so should generally not be `await`ed directly
otherwise performance will suffer. This returned `Task` may be ignored if the publisher does not need
to be know whether the message was successfully published or not. The `Task` completes successfully
when the message has been published to the server; or faults if there was an error publishing.

When subscribing, an instance of `SubscriberClient` can only have `StartAsync(...)` called on it once.
Once `StopAsync(...)` has been called to shutdown the client, then a new client must be created to
restart listening for messages with `StartAsync(...)` again. Due to the expense of creating a client
instance, it is recommended that a singleton client per topic is used for the lifetime of the
application.

## Dependency Injection

Both `PublisherClient` and `SubscriberClient` can be easily integrated with the [dependency injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)
container provided by the [Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/) package.
The `Google.Cloud.PubSub.V1` package provides extension methods to register the clients with the dependency
injection container in the `Microsoft.Extensions.DependencyInjection` namespace.

Please refer to the Google Cloud .NET libraries general purpose
[dependency injection documentation](client-lifecycle.md#dependency-injection-in-high-load-at-startup-environments)
for a workaround on a known issue that may lead to thread starvation and high latency.

### PublisherClient

To register a singleton `PublisherClient` instance with default settings in the `IServiceCollection`, use the
`AddPublisherClient` extension method as shown below:

{{sample:PublisherClient.AddPublisherClient}}

There is an overload of the `AddPublisherClient` method that takes `Action<PublisherClientBuilder>` as a parameter
and can be used to add the customized `PublisherClient` singleton instance as shown below:

{{sample:PublisherClient.AddCustomizedPublisherClient}}

A similar overload of the `AddPublisherClient` method takes
`Action<IServiceProvider, PublisherClientBuilder>` as a parameter
and can be used to add the customized `PublisherClient` singleton
instance based on other information provided by the DI container, as
shown below:

{{sample:PublisherClient.AddCustomizedPublisherClientWithProvider}}

The registered `PublisherClient` can then be used like any other service registered with the dependency injection container. For instance, in a `MyService` class that is itself registered with the dependency injection container,
the `PublisherClient` can be passed as a constructor parameter.
See [dependency injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection) for more information.

Below code shows the registration of `MyService` class with the dependency injection container:

{{sample:PublisherClient.AddPublisherClientAndService}}

The `PublisherClient` can then be used in the `MyService` class as shown below:

{{sample:PublisherClient.UsePublisherClient}}

When the application exits, the `DisposeAsync` method of the `PublisherClient` will be invoked by the dependency injection container to gracefully shut down the client. See
[Disposing of the publisher and subscriber clients](#disposing-of-the-publisher-and-subscriber-clients) for more information about what happens when disposing the `PublisherClient`.

### SubscriberClient

To register a singleton `SubscriberClient` instance with default settings in the `IServiceCollection`, use the
`AddSubscriberClient` extension method as shown below:

{{sample:SubscriberClient.AddSubscriberClient}}

There is an overload of the `AddSubscriberClient` method that takes `Action<SubscriberClientBuilder>` as a parameter
and can be used to add the customized `SubscriberClient` singleton instance as shown below:

{{sample:SubscriberClient.AddCustomizedSubscriberClient}}

A similar overload of the `AddSubscriberClient` method takes
`Action<IServiceProvider, SubscriberClientBuilder>` as a parameter
and can be used to add the customized `SubscriberClient` singleton
instance based on other information provided by the DI container, as
shown below:

{{sample:SubscriberClient.AddCustomizedSubscriberClientWithProvider}}

Registering the `SubscriberClient` doesn't automatically start the client. It needs to be started explicitly by calling the `StartAsync` method.
The `SubscriberClient` is a long-running client and so it may be useful to use
it in a background service. The background service can use the `SubscriberClient`
registered with the dependency injection container and handle the messages in the background.

The background services can be registered with the dependency injection container
using the [`AddHostedService`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicecollectionhostedserviceextensions.addhostedservice?view=dotnet-plat-ext-6.0) extension method as shown below:

{{sample:SubscriberClient.AddHostedService}}

Here `SubscriberService` is the class that implements `BackgroundService` and uses the `SubscriberClient`
registered with the dependency injection container to handle the messages. Once the background service is registered,
it will be automatically started when the application starts and stopped when the application exits.
A sample implementation of `SubscriberService` is shown below:

{{sample:SubscriberClient.UseSubscriberClient}}

During application shutdown, the `StopAsync` method of the `SubscriberService` is invoked by the dependency injection container, which in turn calls
the `StopAsync` method of the `SubscriberClient` to gracefully shut down the client.

Below is an example implementation of a console application that utilizes the dependency injection container and the `SubscriberService` to handle messages:

{{sample:SubscriberClient.UseSubscriberServiceInConsoleApp}}

## Subscriber shutdown

When shutting down a `SubscriberClient`, two different shutdown flows are available via the `StopAsync(SubscriberShutdownSetting, TimeSpan?, CancellationToken)` method:

- **NackImmediately**: This immediately stops streaming new messages and then actively sends "Nack" (Negative Acknowledgement) responses for any messages that have been received but have not yet finished being handled. This allows those messages to be quickly redelivered to other active subscribers.
- **WaitForProcessing**: This immediately stops streaming new messages from the server but continues to process all messages that have already been received. If processing does not complete 30s before the specified timeout, the client will switch to NackImmediately to release any remaining messages.

By default, a 1-hour timeout is used for the shutdown process, which can be customized as needed. When the timeout is reached or if the `CancellationToken` is invoked this will trigger an immediate hard stop, aborting all outstanding tasks.

## Disposing of the publisher and subscriber clients

Both `PublisherClient` and `SubscriberClient` implement the `IAsyncDisposable` interface,
allowing for asynchronous resource cleanup.

For the `PublisherClient`, when the `DisposeAsync` method is called, it asynchronously waits for the time interval
specified in the `PublisherClient.Settings.DisposeTimeout` property for the `PublisherClient` to send any pending messages before aborting
the clean shutdown process, that may leave some locally queued messages unsent. The time interval can be customized
by setting the `PublisherClient.Settings.DisposeTimeout` property. If no value is specified, the default value of 5 seconds is used.

For the `SubscriberClient`, when the `DisposeAsync` method is called, it asynchronously waits for the time interval
specified in the `SubscriberClient.Settings.DisposeTimeout` property for the `SubscriberClient` to acknowledge the handled messages before aborting the
the clean stop process, that may leave some handled messages un-acknowledged. The time interval can be customized
by setting the `SubscriberClient.Settings.DisposeTimeout` property. If no value is specified, the default value of 5 seconds is used.

Please note that when working with the dependency injection container, if the timeout interval specified in the properties above is greater than the default value,
the dependency injection container must be configured to have a timeout greater than or equal to this time. Failure to do so may result in the abrupt termination of the client shutdown process.

See [HostOptions.ShutdownTimeout](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-6.0#shutdowntimeout) for configuring the shutdown timeout in ASP.NET Core applications.

See [Host shutdown](https://learn.microsoft.com/en-us/dotnet/core/extensions/generic-host#host-shutdown) for configuring the shutdown timeout period for console or desktop applications
leveraging the [.NET Generic Host](https://learn.microsoft.com/en-us/dotnet/core/extensions/generic-host).

## Using the emulator

To connect to a [Pub/Sub
Emulator](https://cloud.google.com/pubsub/docs/emulator), set the
`EmulatorDetection` property in the appropriate class depending on
which client type you are constructing:

- `PublisherClientBuilder` (for `PublisherClient`)
- `SubscriberClientBuilder` (for `SubscriberClient`)
- `PublisherServiceApiClientBuilder` (for `PublisherServiceApiClient`)
- `SubscriberServiceApiClientBuilder` (for `SubscriberServiceApiClient`)

`SubscriberClient` example:

{{sample:SubscriberClient.Emulator}}

`SubscriberServiceApiClientBuilder` example:

{{sample:SubscriberServiceApiClient.Emulator}}

See the [help
article](https://cloud.google.com/dotnet/docs/reference/help/emulators)
for more details about emulator support in the .NET Google Cloud client libraries.
