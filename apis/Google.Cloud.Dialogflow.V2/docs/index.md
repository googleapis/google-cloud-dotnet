{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

{{client-classes}}

{{client-construction}}

# Implementing a web hook

You don't *need* this package in order to implement a webhook as a
[Dialogflow fulfillment](https://dialogflow.com/docs/fulfillment).
You can accept a JSON request dynamically and respond to it with
JSON, for example using `JObject` from Json.NET.

This package allows you to work with a more statically-typed view of
the request and response using the Protocol Buffers representation
of `WebhookRequest` and `WebhookResponse`, however. In order to do
this, you **must** use the JSON parser and formatted provided for
Protocol Buffers. You will run into problems if you use Json.NET or
similar general-purpose JSON libraries, as they don't know the
details of Protocol Buffer JSON representations.

Additionally, it's worth configuring the Protocol Buffer JSON parser
to ignore unknown fields. This means your webhook won't break if
additional fields are added to `WebhookRequest` in the future.

Please refer to the [fulfillment
documentation](https://dialogflow.com/docs/fulfillment) for more
details around authentication, and the schema of requests and
responses.

The samples below provide a starting point for ASP.NET Core and
ASP.NET. Note that by default, ASP.NET Core 3.x does not allow
synchronous IO, and the Google.Protobuf library does not yet support
asynchronous parsing from a reader, so you need to asynchronously
read the JSON directly as a string first, then parse the string.
It's likely that in the future, Google.Protobuf will allow
asynchronous parsing.

### Web hook template code for ASP.NET Core (asynchronous-only)

{{sample:AgentsClient.WebhookAsync}}

### Web hook template code for ASP.NET Core (synchronous parsing)

{{sample:AgentsClient.Webhook}}

### Web hook template code for ASP.NET (classic) Web API

{{sample:AgentsClient.WebApiWebhook}}
