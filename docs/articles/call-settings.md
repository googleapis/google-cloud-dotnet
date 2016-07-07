# Call settings

## Introduction

All C# [gRPC](http://www.grpc.io/) APIs allow customization of RPC calls by using [CallSettings](../obj/api/Google.Api.Gax.CallSettings.yml). If `CallSettings` are not specified sensible defaults are automatically provided.

There are three distinct places where `CallSettings` may optionally be provided:

* When calling an RPC method *(highest priority)*.
* Client-wide when creating a gRPC client.
* Per-RPC-method when creating a gRPC client *(lowest priority)*.

It's important to understand exactly *which* properties of which `CallSettings` will be used during an RPC invocation.

The highest-priority non-`null` property is selected from each non-`null` `CallSettings` provided. Each property is selected individually.

## Examples

### Per-RPC (highest priority)

[!code-cs[](../obj/snippets/Google.Pubsub.V1.PublisherClient.txt#CallSettings_PerRpc)]

### Client configuration; client-wide

[!code-cs[](../obj/snippets/Google.Pubsub.V1.PublisherClient.txt#CallSettings_ClientWide)]

### Client configuration; per-RPC-method (lowest priority)

[!code-cs[](../obj/snippets/Google.Pubsub.V1.PublisherClient.txt#CallSettings_ClientPerMethod)]

### Multiple `Callsettings` specified

[!code-cs[](../obj/snippets/Google.Pubsub.V1.PublisherClient.txt#CallSettings_Overrides)]

## Defaults

By default there is a per-RPC-method client configuration that specifies a sensible retry policy for every method. See, for example, [PublisherSettings.CreateTopicSettings](../obj/api/Google.Pubsub.V1.PublisherSettings.html#Google_Pubsub_V1_PublisherSettings_CreateTopicSettings)
