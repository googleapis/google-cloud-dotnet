# Google Cloud .NET Client
.NET idiomatic client libraries for [Google Cloud Platform][cloud-platform] services.

[![Build Status](https://travis-ci.org/GoogleCloudPlatform/gcloud-dotnet.svg?branch=master)](https://travis-ci.org/GoogleCloudPlatform/gcloud-dotnet)

* [Homepage][language-landing-dotnet]
* [API Documentation][api-reference-dotnet]

This client supports the following Google Cloud Platform services:

* [Google BigQuery](#google-bigquery)
* [Google Cloud Datastore](#google-cloud-datastore)
* [Google Cloud Storage](#google-cloud-storage)
* [Google Cloud Pub/Sub](#google-cloud-pubsub)
* [Google Cloud Logging](#google-cloud-logging-beta)

> Note: This client is a work-in-progress, and may occasionally
> make backwards-incompatible changes. The layout of the repository
> is likely to change, and names (of everything - assemblies,
> namespaces, types, members...) should be regarded as provisional.

If you need support for other Google APIs, check out the [Google .NET API Client library][google-api-dotnet-client].

## Example Applications

* [getting-started-dotnet] - A [quickstart and tutorial][language-landing-dotnet] that demonstrates how to build a complete web application using Cloud Datastore, Cloud Storage, and Cloud Pub/Sub and deploy it to Google App Engine or Google Compute Engine.

## Requirements

In order to build the code in this repository, you will need
to [install DNVM][dnvm]. You do not need DNVM to use the code,
provided as NuGet packages.

Most projects in this repository require [gRPC], which has a
component written in native code. Using that component from DNX
currently [requires a workaround][grpc-workaround]; on Windows please run `fix_dnx_grpc.bat`
before running any gRPC code.

## Authentication

First, ensure that the necessary Google Cloud APIs are enabled for your project and that you've downladed the right set of keys (if it applies to you) as explained in the [authentication document][gcloud-common-authentication] shared by all the gcloud language libraries.

Next, choose a method for authenticating API requests from within your project:

1. When using `gcloud-dotnet` libraries from within Compute/App Engine, no additional authentication steps are necessary.
2. When using `gcloud-dotnet` libraries elsewhere, there are two options:
    * Define the environment variable GOOGLE_APPLICATION_CREDENTIALS to be the location of the key.  For example:
    ```bash
    set GOOGLE_APPLICATION_CREDENTIALS=/path/to/my/key.json
    ``` 
    * If running locally for development/testing, you can use use Google Cloud SDK.  Download the SDK if you haven't already, then login using the SDK (`gcloud auth login` in command line).

`gcloud-dotnet` looks for credentials in the following order, stopping once it finds credentials:

1. Credentials supplied when building the service options
2. App Engine credentials
3. Key file pointed to by the GOOGLE_APPLICATION_CREDENTIALS environment variable
4. Google Cloud SDK credentials
5. Compute Engine credentials

## Contributing

Contributions to this library are always welcome and highly encouraged.

See [CONTRIBUTING] for more information on how to get started.

## Versioning

These libraries follow [Semantic Versioning](http://semver.org/).

Anything with a major version of zero (``0.y.z``) should not be
considered stable - anything may change at any time.

## License

Apache 2.0 - See [LICENSE] for more information.


[CONTRIBUTING]:https://github.com/GoogleCloudPlatform/gcloud-dotnet/blob/master/CONTRIBUTING.md
[LICENSE]: https://github.com/GoogleCloudPlatform/gcloud-dotnet/blob/master/LICENSE
[cloud-platform]: https://cloud.google.com/
[language-landing-dotnet]: https://cloud.google.com/dotnet/
[api-reference-dotnet]: http://googlecloudplatform.github.io/gcloud-dotnet/
[google-api-dotnet-client]: https://github.com/google/google-api-dotnet-client
[getting-started-dotnet]: https://github.com/GoogleCloudPlatform/getting-started-dotnet/
[gcloud-common-authentication]: https://github.com/GoogleCloudPlatform/gcloud-common/blob/master/authentication/readme.md#authentication
[dnvm]: http://docs.asp.net/en/latest/getting-started/index.html
[gRPC]: http://grpc.io
[grpc-workaround]: https://github.com/grpc/grpc/issues/4872
