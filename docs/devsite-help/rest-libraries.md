# HTTP/1.1 + REST libraries

As described in the [library types page](library-types.md), the
HTTP/1.1 + REST libraries are API-specific libraries with source code in
the [google-api-dotnet-client repository](https://github.com/googleapis/google-api-dotnet-client),
generated from [Discovery documents](https://developers.google.com/discovery/v1/getting_started)
instead of API protobuf representations. API calls are made over HTTP/1.1 with
JSON content.

These libraries depend heavily on the support libraries of Google.Apis and
Google.Apis.Core, which have their source code in the same repository.

These libraries are still supported and automatically updated as the API
surfaces change, but the underlying code and generator is not being actively worked
on, and only high-impact feature requests are considered.

Some features are not as discoverable as we'd like them to be; this page
describes the use of these features.

## Service object reuse

Service client classes (e.g. `DriveService`) are thread-safe and reusable.
Typically your application should create a single instance and use it for all operations.

By default, every instantiation of a service client class creates a new instance of
[HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient),
and creating many of these is, in general, a bad idea. See, for example,
[this post](https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/) for why.

Sometimes it *is* required to create an instance per request. In this case make sure
your code calls `Dispose` on each instance when it has finished with it.
This will call `Dispose` on the `HttpClient`.

### GoogleWebAuthorizationBroker

[GoogleWebAuthorizationBroker](https://github.com/googleapis/google-api-dotnet-client/blob/main/Src/Support/Google.Apis.Auth/OAuth2/GoogleWebAuthorizationBroker.cs) requires interaction with the end-user, so can only be used in client-side code.

OAuth authentication requires the end-user to interact with a web browser, which can only be done client-side.

It is possible to use OAuth authentication for end users in a web application, but not using
`GoogleWebAuthorizationBroker`. For these purposes, you can use one of the ASP.NET integration packages
we provide, such as [`Google.Apis.Auth.AspNetCore3`](https://www.nuget.org/packages/Google.Apis.Auth.AspNetCore3).

You can find general information about Google APIs and OAuth 2.0 in 
[Using OAuth 2.0 to Access Google APIs](https://developers.google.com/identity/protocols/oauth2)
and about integration with .NET client libraries in the [.NET guide for OAuth 2.0 and
Google APIs](https://developers.google.com/api-client-library/dotnet/guide/aaa_oauth).

## Specifying a retry policy

By default, clients will only retry requests which result in an HTTP 503 response. These are retried with exponential backoff, starting with 250ms and doubling on each retry, for a maximum of 3 attempts.
Retry policies can be configured on a per-client basis, as shown below:

```csharp
using Google.Apis.Drive.v3;
using Google.Apis.Http;
using Google.Apis.Util;
using System.Net;

BackOffHandler handler = new BackOffHandler(new BackOffHandler.Initializer(new ExponentialBackOff())
{
    HandleUnsuccessfulResponseFunc = response => response.StatusCode == HttpStatusCode.InternalServerError,
    HandleExceptionFunc = exception => exception is HttpRequestException
});

DriveService service = new DriveService(new Google.Apis.Services.BaseClientService.Initializer
{
    // Prevent the default retry handling from also retrying failures.
    DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.None,
    ...
});

service.HttpClient.MessageHandler.NumTries = 5;
service.HttpClient.MessageHandler.AddExceptionHandler(handler);
service.HttpClient.MessageHandler.AddUnsuccessfulResponseHandler(handler);
```

## Integration with IHttpClientFactory

For historical reasons, there are two (incompatible) `IHttpClientFactory` interfaces:

- [`Google.Apis.Http.IHttpClientFactory`](https://github.com/googleapis/google-api-dotnet-client/blob/main/Src/Support/Google.Apis.Core/Http/IHttpClientFactory.cs) in the REST support library
- [`System.Net.Http.IHttpClientFactory`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.ihttpclientfactory) in .NET

The .NET interface is widely used, and supported in the community with projects such as
[Polly](https://github.com/App-vNext/Polly). Unfortunately, the REST support library predates this
interface and it can't be directly retro-fitted without breaking changes.

The `HttpClientFromMessageHandlerFactory` provides a bridge between the two interfaces. Integration is still
relatively complex, but the [integration test for this class](https://github.com/googleapis/google-api-dotnet-client/blob/main/Src/Support/IntegrationTests/HttpClientFromMessageHandlerFactoryTests.cs)
serves as a living example.

## GoogleApiHttpBody properties

Some libraries (e.g. Cloud Machine Learning Engine) require un-typed
JSON to be passed through to the server, ignoring the strongly-typed
generated code. This un-typed JSON is represented via the `GoogleApiHttpBody`
type, usually for a property called `HttpBody`.

Setting the data in this property directly does not work as
expected. The workaround is to use the service `HttpClient` directly. For example:

```csharp
DemoService service = new DemoService(...);

// The JSON we want in our HTTP request body
string json = "{ \"property\": 5 }";

// Create an empty body part for the request
DemoRequestBody emptyBody = new DemoRequestBody { HttpBody = new GoogleApiHttpBody() };

// Create the service request as normal
DemoRequest demoRequest = service.Demo(emptyBody);

// Prepare to send the request using the service HttpClient directly
Uri uri = demoRequest.CreateRequest().RequestUri;
HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

// Execute the request
HttpResponseMessage response = await service.HttpClient.PostAsync(uri, content);

// Check the response status-code, to see if the request completed successfully.
// If so, then JSON response data can now be read directly from the response
response.EnsureSuccessStatusCode();
```

See issue [#1068](https://github.com/googleapis/google-api-dotnet-client/issues/1068) for more details.

## DateTime/DateTimeOffset properties

Resource properties specified with the "date-time" format in Discovery document are generated as three
properties in the C# code. For a property named `timestamp` in the Discovery document,
the generated properties are:

```csharp
public string TimestampRaw { get; set; }
[Obsolete]
public DateTime Timestamp { get; set; }
public DateTimeOffset TimestampDateTimeOffset { get; set; }
```

The three properties are all implemented in terms of the "raw" property, which is just a plain string. When fetching the properties with types `DateTime` or `DateTimeOffset`, the raw string is parsed to the appropriate type. When setting the properties, the raw string is obtained by formatting the value.

The `DateTime`-based property is obsolete as its parsing code has some undesirable behavior, including 
conversion to local time whereas the underlying value is always expressed in UTC. This behavior can't be
changed without breaking backward compatibility, so instead the `DateTimeOffset`-based property was
introduced. We recommend migrating code using the `DateTime`-based property to the new property to avoid
this behavior. Likewise, code using the raw string property in order to work around the `DateTime` behavior
can now migrate to use the new property (avoiding code clutter) - but it's fine to continue using the raw
property for other reasons, such as to log the precise payload.

## Object/DateTimeOffset properties

Resource properties specified with the "google-datetime" format in Discovery document are also generated as three properties in the C# code. For a property named `timestamp` in the Discovery document,
the generated properties are:

```csharp
public string TimestampRaw { get; set; }
[Obsolete]
public object Timestamp { get; set; }
public DateTimeOffset TimestampDateTimeOffset { get; set; }
```

This situation is more complex than the "date-time" scenario above, as one property has a type of just
`object`, preventing proxying all properties through just the raw string property.
The generated code maintains backward compatibility with early versions which *only* contained the
`object`-typed property as far as possible, but we recommend that all existing code using that property
now migrates to use the `DateTimeOffset`-based property if possible, or the raw string property otherwise.
