{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

Everything starts with [FirestoreDb](obj/api/Google.Cloud.Firestore.FirestoreDb.yml).
Create an instance using the `Create` or `CreateAsync` methods, passing in your Google Cloud project ID.
The default credentials will be used to authenticate with the
server. `FirestoreDb` is thread-safe, and we recommend using a
single instance across your application where possible.

From there, you can create, fetch and modify documents, and run queries.

For customization of credentials and other settings, create a
`FirestoreDbBuilder`, set the appropriate properties, and call
`Build` to create a `FirestoreDb`.

## Conflicts with .NET 10

.NET 10 introduces the `AsyncEnumerable` class which causes
conflicts with the `System.Linq.Async` package that
Google.Cloud.Firestore depends on.

We will release a new major version with a dependency on
`System.Linq.AsyncEnumerable` instead, but within the current major
version (3.x) you can follow the workaround described on the [.NET compatibility
page](https://learn.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/10.0/asyncenumerable),
by adding a direct dependency on `System.Linq.Async` in your project
file, with `ExcludeAssets=compile`:

```xml
<PackageReference Include="System.Linq.Async" Version="6.0.3" ExcludeAssets="compile"/>
```

## Sample code

{{sample:Index.GettingStarted}}

See the [user guide](userguide.md) for more samples.

## Connecting to the emulator

To connect to the [Firestore
Emulator](https://cloud.google.com/sdk/gcloud/reference/beta/emulators/firestore/),
you need to:

- Connect to the emulator endpoint
- Use `ChannelCredentials.Insecure` as the channel credentials
- Specify an "Authorization: Bearer owner" header on each request

As of version 1.1.0-beta02, the library has support for detecting
the emulator via the environment variable and connecting to it
automatically, if requested. This is configured via
`FirestoreDbBuilder`, which can also be used to configure custom
credentials easily.

The following code creates a `FirestoreDb` which will use the
emulator when the environment variables are present, but will
otherwise connect to the production environment.

{{sample:Index.EmulatorDetection}}

See the
[EmulatorDetection property](obj/api/Google.Cloud.Firestore.FirestoreDbBuilder.yml#Google_Cloud_Firestore_FirestoreDbBuilder_EmulatorDetection)
for more details.
