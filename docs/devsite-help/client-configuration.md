# Client configuration

Every client has a corresponding builder class (e.g. `ExampleClientBuilder`) with `Build` and `BuildAsync`
methods.

The builder allows you to customize various aspects of the client, most notably credentials. For example,
if you load JSON containing the relevant credentials to use, you might construct a client with:

```csharp
var client = new ExampleClientBuilder
{
    JsonCredentials = json
}.Build();
```

Clients can also be configured via dependency injection, but that's just a (very) convenient approach to using the
builder: everything can be configured via the builder. See the [client lifecycle documentation](client-lifecycle.md)
for more details of the options around *where* to configure the client; this page focuses on *what* can
be configured.

Note that the options below are the ones supported by gRPC-based APIs. The `Google.Cloud.Storage.V1`, `Google.Cloud.BigQuery.V2`
and `Google.Cloud.Translation.V2` libraries support builders as well, but with fewer options.

## Specifying credentials

The following properties are used for specifying and configuring which credentials a client
uses to authenticate and authorize requests. When no properties are set,
[application default credentials](https://cloud.google.com/docs/authentication/production#automatically) are used.

### CredentialsPath, JsonCredentials or GoogleCredential

These three (mutually-exclusive) properties represent different ways of providing a `GoogleCredential`. Specifying
`CredentialsPath` or `JsonCredentials` is equivalent to specifying the result of `GoogleCredential.FromFile` or
`GoogleCredential.FromJson` for the `GoogleCredential` property.

### Scopes, UseJwtAccessWithScopes and QuotaProject

When application default credentials are used, or a `GoogleCredential` is specified explicitly,
these three properties can provide extra information for the credentials. By default, the credential is scoped
with the default scopes for the client being constructed (e.g. `ExampleClient.DefaultScopes`). In some cases you
may wish to specify more fine-grained scopes instead using the `Scopes` property.

The `UseJwtAccessWithScopes` property controls whether service account credentials request an OAuth2 token, or whether they create
a self-signed JWT using the secret within the credential, where feasible. By default this is `true`.

The `QuotaProject` controls which Google Cloud project is used to account for or bill the requests made by the client.

### ChannelCredentials, Credential or TokenAccessMethod

These three properties (which are mutually-exclusive, along with any of the `GoogleCredential` properties)
represent "raw" credentials which are used exactly as they are provided, without
applying any additional options such as scopes or a quota project. These are the most low-level
properties, and are rarely as useful as the ones above.

## gRPC configuration

### GrpcAdapter

The `GrpcAdapter` property configures which gRPC implementation is used. It is almost always safe to leave this unspecified,
using the default selection algorithm. See the [transports documentation](transports.md) for more details.

### GrpcChannelOptions

Not to be confused with `Grpc.Net.Client.GrpcChannelOptions`, the `Google.Api.Gax.Grpc.GrpcChannelOptions` class provides
an implementation-agnostic way of configuring aspects such as the maximum size of requests that can be sent. The default
options are appropriate for most scenarios. Any options provided here are layered over the default options rather than
replacing them entirely.

### CallInvoker

This is the lowest level of configuration: when a `CallInvoker` is specified, none of the above properties are
used at all. This is rarely used outside low-level testing.

## Miscellaneous configuration

### Endpoint

This is used to configure which server to send requests to. This is primarily used for APIs that support regional endpoints.
For example, in the [Google.Cloud.AIPlatform.V1 API](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.AIPlatform.V1/latest)
you might configure a client like this:

```csharp
string region = "us-central1";
var client = new DatasetServiceClientBuilder
{
    Endpoint = $"{region}-aiplatform.googleapis.com"
}.Build();
```

### Logger

When specified, this allows the client to log trace messages at the start and end of API calls. This
does *not* provide transport-level gRPC logging. See the [troubleshooting documentation](troubleshooting.md)
for more details of configuring logging.

### UserAgent

The user agent sent in the headers for each request can be customized with this property.

### EmulatorDetection (for APIs that support it)

Some APIs (such as Pub/Sub and Spanner) support emulators. The `EmulatorDetection` property is used
to specify whether to connect to an emulator if the appropriate environment variables are set. See
the [emulator support documentation](emulators.md) for more details.

## API-specific settings

Each client class has a corresponding `Settings` class (so `ExampleClient` would have an `ExampleSettings` class).
This is used to provide API-wide and method-specific [call settings](call-settings.md) to be applied by default
on every call made via the client, for example to configure retry timings. If this property is not set,
the default settings configured for the client are applied.
