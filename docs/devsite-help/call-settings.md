# Call settings

## Introduction

All client libraries wrapping gRPC-based APIs (see the [API layers](api-layers.md) article)
allow customization of RPC calls by using
[CallSettings](xref:Google.Api.Gax.Grpc.CallSettings). If `CallSettings` are
not specified sensible defaults are automatically provided.
See the [CallSettings documentation](xref:Google.Api.Gax.Grpc.CallSettings)
for descriptions of the available properties.

The underlying gRPC API uses
[CallOptions](http://www.grpc.io/grpc/csharp/html/T_Grpc_Core_CallOptions.htm),
which provides a slightly reduced feature set compared to `CallSettings`.
Client libraries automatically construct a `CallOptions` from `CallSettings`
as required.

There are three distinct places where `CallSettings` may optionally be provided:

* When calling an RPC method *(highest priority)*.
* Client-wide when creating a client object (for example, using
[PublisherServiceApiClient.Create()](xref:Google.Cloud.PubSub.V1.PublisherServiceApiClient#Google_Cloud_PubSub_V1_PublisherServiceApiClient_Create_Google_Api_Gax_ServiceEndpoint_Google_Cloud_PubSub_V1_PublisherServiceApiSettings_)).
* Per-RPC-method when creating a client object *(lowest priority)*.

It's important to understand exactly which properties of which `CallSettings` will be used during an RPC invocation.
The three `CallSettings` objects are merged into a single effective `CallSettings`.
Each property is merged separately: the highest priority non-`null` value for each
property is used.

The client-wide `CallSettings` is higher-priority than per-RPC-method `CallSettings`
because it is often useful to be able to easily specify common properties to use
for all RPC invocations. For example, a common set of
[headers](xref:Google.Api.Gax.Grpc.CallSettings#Google_Api_Gax_Grpc_CallSettings_HeaderMutation);
or a common
[expiration (deadline)](xref:Google.Api.Gax.Grpc.CallSettings#Google_Api_Gax_Grpc_CallSettings_Expiration)
for multiple RPC invocations.

## Examples

### Per-RPC (highest priority)

[!code-cs[](../examples/help.CallSettings.txt#PerRpc)]

### Client configuration; client-wide

[!code-cs[](../examples/help.CallSettings.txt#ClientWide)]

### Client configuration; per-RPC-method (lowest priority)

[!code-cs[](../examples/help.CallSettings.txt#ClientPerMethod)]

### Multiple `Callsettings` specified

[!code-cs[](../examples/help.CallSettings.txt#Overrides)]

## Defaults

By default there is a per-RPC-method client configuration that specifies a sensible
retry policy for every method. See, for example,
[PublisherServiceApiSettings.CreateTopicSettings](xref:Google.Cloud.PubSub.V1.PublisherServiceApiSettings#Google_Cloud_PubSub_V1_PublisherServiceApiSettings_CreateTopicSettings).

## Expiration

CallSettings has an [Expiration](xref:Google.Api.Gax.Grpc.CallSettings#Google_Api_Gax_Grpc_CallSettings_Expiration) property,
of type [Expiration](xref:Google.Api.Gax.Expiration) which defines when an operation will fail due to timing out.
This can be either a *timeout* (relative to the start time, e.g. "it can't take more than 5 seconds") or a *deadline* (which is
absolute, e.g. "it must finish by 2016-12-07 14:55:00Z"). You create an `Expiration` by specifying that timeout
or deadline, with the [Expiration.FromTimeout(TimeSpan)](xref:Google.Api.Gax.Expiration#Google_Api_Gax_Expiration_FromTimeout_System_TimeSpan_)
and [Expiration.FromDeadline(DateTime)](xref:Google.Api.Gax.Expiration#Google_Api_Gax_Expiration_FromDeadline_System_DateTime_) methods.
Alternatively, you can use [Expiration.None](xref:Google.Api.Gax.Expiration#Google_Api_Gax_Expiration_None), which is an infinite timeout.

A timeout is always relative to the
start of an operation, not the time the expiration is created. So for example, if you create an expiration of
5 seconds, you can use that as often as you like, and it will always mean that the operation you're applying
the expiration to has 5 seconds to complete.

Note that deadline expirations are most commonly used when the same deadline is passed to multiple calls:
if you have to perform 5 different operations, and you know your total work needs to finish at a particular
point but you don't care how those 5 operations use up your time budget between them, passing in the same
deadline to all 5 works well. This is restricted to one unit of work, however - you'd need to calculate a new
deadline for the next unit of work, whereas a relative timeout may be valid for all calls. You should think
carefully about your own requirements - and please file a feature request if we don't provide enough functionality
for you to meet them.

Note that the expiration applies to the operation as a whole. This might involve making multiple RPCs, due to retry
which is discussed below.

### Retry

The client libraries can transparently retry operations if it is deemed safe to do so (typically read operations),
based on the [CallSettings.Retry](xref:Google.Api.Gax.Grpc.CallSettings#Google_Api_Gax_Grpc_CallSettings_Retry) property,
of type [RetrySettings](xref:Google.Api.Gax.Grpc.RetrySettings).

RetrySettings configure three aspects of retry:

- When retry can be attempted, which is conditional on the exception thrown by a failed attempt
- A maximum number of attempts to perform
- How long to wait between retries (the backoff)

The first two of these, represented by the `RetryFilter`
and `MaxAttempts` properties, are reasonably simple.

The backoff between retries is more complex. It consists of:

- An initial backoff to be used after the first attempt
- A multiplier for the backoff (e.g. 2.0 to double the backoff each time, or 1.0 for a constant backoff)
- A maximum backoff
- A jitter to apply to each backoff to determine the actual amount of time to delay. This avoids multiple client
  accidentally synchronizing their retries and periodically hitting
  a service very hard. This is exposed for testability, but is unlikely to need tweaking in production use.

`RetrySettings` instances are created through two factory methods:

- [RetrySettings.FromConstantBackoff](xref:Google.Api.Gax.Grpc.RetrySettings#Google_Api_Gax_Grpc_RetrySettings_FromConstantBackoff_System_Int32_System_TimeSpan_System_Predicate_System_Exception__Google_Api_Gax_Grpc_RetrySettings_IJitter_) which uses a multiplier of 1 and no maximum (because it's constant)
- [RetrySettings.FromExponentialBackoff](xref:Google.Api.Gax.Grpc.RetrySettings#Google_Api_Gax_Grpc_RetrySettings_FromExponentialBackoff_System_Int32_System_TimeSpan_System_TimeSpan_System_Double_System_Predicate_System_Exception__Google_Api_Gax_Grpc_RetrySettings_IJitter_) which allows every aspect to be specified
