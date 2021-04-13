# Getting started with client libraries

## Specifying credentials in client libraries

The libraries implement a *client builder* pattern to make
life considerably simpler when you wish to specify different
credentials or a different API endpoint.

The general pattern is to create a builder (using the same name as
the client type, with a suffix of `Builder`), populate any
propreties to override some aspect of the behavior, and then call
`Build`. For example:

```csharp
SpeechClient client = new SpeechClientBuilder
{
    // Populate properties here
}.Build();
```

In terms of credentials, there are four (mutually-exclusive)
properties you can use to specify credentials:

- `ChannelCredentials`: the gRPC credentials to use
- `CredentialsPath`: the path to a JSON file containing service account credentials
- `JsonCredentials`: a string (in JSON format) containing service account credentials
- `TokenAccessMethod`: a delegate used to provide access tokens

The final property is a delegate to avoid exposing a dependency on
`Google.Apis.Auth` in the API surface, but the intention of it is to
allow you to use any `ICredential` (e.g. a `GoogleCredential` or a
`UserCredential`) via a method group conversion. For example, to
create a `SpeechClient` with a `UserCredential`, you would write
code like this:

```csharp
UserCredential credential = ...;
SpeechClient client = new SpeechClientBuilder
{
    TokenAccessMethod = credential.GetAccessTokenForRequestAsync
}.Build();
```
