{{title}}

{{description}}

{{version}}

{{installation}}

## Authentication

The Google Workspace Events API is intended to be used with user
credentials. Follow the [OAuth2.0 guide for the .NET client
libraries](https://developers.google.com/api-client-library/dotnet/guide/aaa_oauth)
for more details on how to obtain a `UserCredential` (specifying
appropriate scopes for the calls you wish to make) and then
construct the client using a builder to specify the credential:

```csharp
var client = new SubscriptionsServiceClientBuilder
{
    Credential = userCredential
}.Build();
```

## Getting started

{{client-classes}}
