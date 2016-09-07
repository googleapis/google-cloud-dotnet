# Call settings

## Introduction

All client libraries wrapping gRPC-based APIs (see the [API layers](api-layers.md) article)
allow customization of RPC calls by using
[CallSettings](obj/api/Google.Api.Gax.CallSettings.yml). If `CallSettings` are
not specified sensible defaults are automatically provided.
See the [CallSettings documentation](obj/api/Google.Api.Gax.CallSettings.yml)
for descriptions of the available properties.

The underlying gRPC API uses
[CallOptions](http://www.grpc.io/grpc/csharp/html/T_Grpc_Core_CallOptions.htm),
which provides a slightly reduced feature set compared to `CallSettings`.
Client libraries automatically construct a `CallOptions` from `Callsettings`
to `CallOptions` as required.

There are three distinct places where `CallSettings` may optionally be provided:

* When calling an RPC method *(highest priority)*.
* Client-wide when creating a client object (for example, using
[PublisherClient.Create()](Google.Pubsub.V1/api/Google.Pubsub.V1.PublisherClient.html#Google_Pubsub_V1_PublisherClient_Create_Google_Api_Gax_ServiceEndpoint_Google_Pubsub_V1_PublisherSettings_)).
* Per-RPC-method when creating a client object *(lowest priority)*.

It's important to understand exactly which properties of which `CallSettings` will be used during an RPC invocation.
The three `CallSettings` objects are merged into a single effective `CallSettings`.
Each property is merged separately: the highest priority non-`null` value for each
property is used.

The client-wide `CallSettings` is higher-priority than per-RPC-method `CallSettings`
because it is often useful to be able to easily specify common properties to use
for all RPC invocations. For example, a common set of
[headers](obj/api/Google.Api.Gax.CallSettings.yml#Google_Api_Gax_CallSettings_Headers);
or a common
[deadline](obj/api/Google.Api.Gax.CallSettings.yml#Google_Api_Gax_CallSettings_Timing)
for multiple RPC invocations.

## Examples

### Per-RPC (highest priority)

[!code-cs[](obj/snippets/Google.Cloud.Docs.CallSettings.txt#PerRpc)]

### Client configuration; client-wide

[!code-cs[](obj/snippets/Google.Cloud.Docs.CallSettings.txt#ClientWide)]

### Client configuration; per-RPC-method (lowest priority)

[!code-cs[](obj/snippets/Google.Cloud.Docs.CallSettings.txt#ClientPerMethod)]

### Multiple `Callsettings` specified

[!code-cs[](obj/snippets/Google.Cloud.Docs.CallSettings.txt#Overrides)]

## Defaults

By default there is a per-RPC-method client configuration that specifies a sensible
retry policy for every method. See, for example,
[PublisherSettings.CreateTopicSettings](Google.Pubsub.V1/api/Google.Pubsub.V1.PublisherSettings.html#Google_Pubsub_V1_PublisherSettings_CreateTopicSettings)
