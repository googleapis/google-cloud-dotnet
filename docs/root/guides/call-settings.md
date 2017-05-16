# Call settings

## Introduction

All client libraries wrapping gRPC-based APIs (see the [API layers](api-layers.md) article)
allow customization of RPC calls by using
[CallSettings](../obj/api/Google.Api.Gax.Grpc.CallSettings.yml). If `CallSettings` are
not specified sensible defaults are automatically provided.
See the [CallSettings documentation](../obj/api/Google.Api.Gax.Grpc.CallSettings.yml)
for descriptions of the available properties.

The underlying gRPC API uses
[CallOptions](http://www.grpc.io/grpc/csharp/html/T_Grpc_Core_CallOptions.htm),
which provides a slightly reduced feature set compared to `CallSettings`.
Client libraries automatically construct a `CallOptions` from `Callsettings`
to `CallOptions` as required.

There are three distinct places where `CallSettings` may optionally be provided:

* When calling an RPC method *(highest priority)*.
* Client-wide when creating a client object (for example, using
[PublisherClient.Create()](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.PublisherClient.html#Google_Cloud_PubSub_V1_PublisherClient_Create_Google_Api_Gax_ServiceEndpoint_Google_Cloud_PubSub_V1_PublisherSettings_)).
* Per-RPC-method when creating a client object *(lowest priority)*.

It's important to understand exactly which properties of which `CallSettings` will be used during an RPC invocation.
The three `CallSettings` objects are merged into a single effective `CallSettings`.
Each property is merged separately: the highest priority non-`null` value for each
property is used.

The client-wide `CallSettings` is higher-priority than per-RPC-method `CallSettings`
because it is often useful to be able to easily specify common properties to use
for all RPC invocations. For example, a common set of
[headers](../obj/api/Google.Api.Gax.Grpc.CallSettings.yml#Google_Api_Gax_Grpc_CallSettings_Headers);
or a common
[deadline](../obj/api/Google.Api.Gax.Grpc.CallSettings.yml#Google_Api_Gax_Grpc_CallSettings_Timing)
for multiple RPC invocations.

## Examples

### Per-RPC (highest priority)

[!code-cs[](../obj/snippets/Google.Cloud.Docs.CallSettings.txt#PerRpc)]

### Client configuration; client-wide

[!code-cs[](../obj/snippets/Google.Cloud.Docs.CallSettings.txt#ClientWide)]

### Client configuration; per-RPC-method (lowest priority)

[!code-cs[](../obj/snippets/Google.Cloud.Docs.CallSettings.txt#ClientPerMethod)]

### Multiple `Callsettings` specified

[!code-cs[](../obj/snippets/Google.Cloud.Docs.CallSettings.txt#Overrides)]

## Defaults

By default there is a per-RPC-method client configuration that specifies a sensible
retry policy for every method. See, for example,
[PublisherSettings.CreateTopicSettings](../Google.Cloud.PubSub.V1/api/Google.Cloud.PubSub.V1.PublisherSettings.html#Google_Cloud_PubSub_V1_PublisherSettings_CreateTopicSettings)

## Timing settings

The timing settings for an RPC are specified using [CallTiming](../obj/api/Google.Api.Gax.Grpc.CallTiming.yml).
This is either a simple [Expiration](../obj/api/Google.Api.Gax.Expiration.yml),
or a [RetrySettings](../obj/api/Google.Api.Gax.Grpc.RetrySettings.yml). `RetrySettings` uses an `Expiration` as well,
so let's look at `Expiration` first.

### Expiration

An expiration specifies the latest point at which you're willing for an operation to complete. It can be either
a *timeout* (relative to the start time, e.g. "it can't take more than 5 seconds") or a *deadline* (which is
absolute, e.g. "it must finish by 2016-12-07 14:55:00Z"). You create an `Expiration` by specifying that timeout
or deadline, with the `Expiration.FromTimeout(TimeSpan)` and `Expiration.FromDeadline(DateTime)` methods.
Alternatively, you can use `Expiration.None`, which is an infinite timeout. A timeout is always relative to the
start of an operation, not the time the expiration is created. So for example, if you create an expiration of
5 seconds, you can use that as often as you like, and it will always mean that the operation you're applying
the expiration to has 5 seconds to complete.

Note that deadline expirations are most commonly used when the same deadline is passed to multiple calls:
if you have to perform 5 different RPCs, and you know your total work needs to finish at a particular
point but you don't care how those 5 RPCs use up your time budget between them, passing in the same
deadline to all 5 works well. This is restricted to one unit of work, however - you'd need to calculate a new
deadline for the next unit of work, whereas a relative timeout may be valid for all calls. You should think
carefully about your own requirements - and please file a feature request if we don't provide enough functionality
for you to meet them.

### RetrySettings

Retry is inherently complicated. There will be potentially multiple RPCs made, each with its own expiration, some
back-off between RPCs, and the situations under which it's reasonable to retry. The [RetrySettings](../obj/api/Google.Api.Gax.Grpc.RetrySettings.yml) exposes this via the following properties (all set by the constructor):

- `TimeoutBackoff`: how the expiration for each individual RPC varies
  (for example, the first RPC might have a timeout
  of 1s, then the second RPC might have 2s etc)
- `RetryBackoff`: how the *delay* between each failed RPC varies
  (for example, we might wait for 0.5s after the first RPC, then 0.75s after the second, etc)
- `RetryFilter`: a predicate which is consulted after each failed RPC to see whether that failure
  suggests we should retry. For example, we might retry on timeouts but not on a "resource not found" failure.
- `TotalExpiration`: the overall expiration for the whole operation. For example, we might allow multiple RPCs
  to attempt an operation, but the whole operation must have completed within 10 seconds or we'll fail with a timeout.
- `DelayJitter`: This allows the precise amount of delay (broadly specified by `RetryBackoff`) to vary randomly
  a little. This avoids multiple clients accidentally synchronizing their retries and periodically hitting
  a service very hard. This is exposed for testability, but is unlikely to need tweaking in production use.

 `TimeoutBackoff` and `RetryBackoff` are both expressed in terms of a [BackoffSettings](../obj/api/Google.Api.Gax.Grpc.BackoffSettings.yml), which consists of an initial timeout, a maximum timeout, and a multiplier.
 The multiplier is applied to the "current" timeout to determine the "next" timeout, capped at the maximum.

 All of this is probably best demonstrated with a worked example. Consider the following settings:

 [!code-cs[](../obj/snippets/Google.Cloud.Docs.CallSettings.txt#RetrySettingsTiming)]

 Here we're using the default RPC filter and jitter for simplicity. Suppose we have a server which returns a
 "not found" error (which is retriable) after 2 seconds each time we make an RPC. The timing with the above settings looks like this (assuming there's no actual jitter):

 - t=0s: Send RPC 1, timeout=4s (the inital value in `timeoutBackoff)
 - t=2s: RPC 1 completes with "not found": we need to retry. Delay for 1s (the initial value in `retryBackoff`)
 - t=3s: Send RPC 2, timeout=6s (1.5x the previous timeout backoff)
 - t=5s: RPC 2 completes with "not found": we need to retry. Delay for 2s (doubling the previous retry backoff)
 - t=7s: Send RPC 3, timeout=9s (1.5x the previous timeout backoff)
 - t=9s: RPC 3 completes with "not found": we need to retry. Delay for 4s (doubling the previous retry backoff)
 - t=13s: Send RPC 4, timeout=10s (1.5x the previous timeout backoff, but capped at 10s)
 - t=15s: RPC 4 completes with "not found": we need to retry. Delay for 5s (doubling the previous retry backoff, but capped at 5s)
 - t=20s: Send RPC 5, timeout=10s (we've hit the timeout backoff cap)
 - t=22s: RPC 5 completes with "not found": we need to retry. Delay for 5s (we've hit the retry backoff cap)
 - t=27s: Send RPC 6, timeout=**3s** (it would be 10s, but we know our overall expiration is 30s, so it's limited by that)
 - t=29s: RPC 6 completes with "not found": we *would* delay by 5s and retry, but with an overall expiration of 30s, we know
   we won't complete in time, so immediately throw an exception

 Currently there's no simple way of limiting to a *number* of retries - it's only governed by time. We'll consider adding
 a count limit in a future version.
