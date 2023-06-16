# Legacy HTTP/1.1 + REST libraries

As described in the [library types page](library-types.md), the legacy
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
describes some

## Credentials and authentication

## Service object reuse

### GoogleWebAuthorizationBroker

## Specifying a retry policy

## Integration with IHttpClientFactory

## GoogleApiHttpBody properties

## DateTime/DateTimeOffset properties

## Object/DateTimeOffset properties ("google-datetime")

