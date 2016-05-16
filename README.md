# Google Cloud .NET Client
.NET idiomatic client libraries for [Google Cloud Platform][cloud-platform] services.

[![Build Status](https://travis-ci.org/GoogleCloudPlatform/gcloud-dotnet.svg?branch=master)](https://travis-ci.org/GoogleCloudPlatform/gcloud-dotnet)

* [Homepage][language-landing-dotnet]
* [API Documentation][api-reference-dotnet]

This client supports the following Google Cloud Platform services:

* [Google BigQuery](#google-bigquery)
* [Google Cloud Datastore](#google-cloud-datastore)
* [Google Cloud Logging](#google-cloud-logging)
* [Google Cloud Pub/Sub](#google-cloud-pubsub)
* [Google Cloud Storage](#google-cloud-storage)

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

## Specifying a Project ID

Most `gcloud-dotnet` libraries require a project ID.  There are multiple ways to specify this project ID.

1. When using `gcloud-dotnet` libraries from within Compute/App Engine, there's no need to specify a project ID.  It is automatically inferred from the production environment.
2. When using `gcloud-dotnet` libraries elsewhere, you can do one of the following:
    * Define the environment variable GCLOUD_PROJECT to be your desired project ID. For example:

      ```bash
      set GCLOUD_PROJECT=PROJECT_ID
      ```
    * If running locally for development/testing, set the project ID using the [Google Cloud SDK][google-cloud-sdk].  Download the SDK if you haven't already, and set the project ID from the command line. For example:

      ```bash
      gcloud config set project PROJECT_ID
      ```

## Authentication
Every API call needs to be authenticated. In other to successfully make call, first ensure that the necessary Google Cloud APIs are enabled for your project and that you've downladed the right set of keys (if it applies to you) as explained in the [authentication document][gcloud-common-authentication].

Next, choose a method for authenticating API requests from within your project:

1. When using `gcloud-dotnet` libraries from within Compute/App Engine, no additional authentication steps are necessary.
2. When using `gcloud-dotnet` libraries elsewhere, you can do one of the following:
    * Define the environment variable GOOGLE_APPLICATION_CREDENTIALS to be the location of the key.  For example:

      ```bash
      set GOOGLE_APPLICATION_CREDENTIALS=/path/to/my/key.json
      ``` 
    * If running locally for development/testing, you can authenticate using the [Google Cloud SDK][google-cloud-sdk].  Download the SDK if you haven't already, then login by running the following in the command line:

      ```bash
      gcloud auth login
      ```

## Google BigQuery

- [API Reference][cloud-bigquery-ref]
- [API Overview][cloud-bigquery-docs]

The BigQuery client libary is in pre-release state and is more likely to have significant surface changes over time. Still, if you would like to experiment with them, we would welcome your feedback.

### Installation
The package is available from Google's [public MyGet feed][google-myget-feed] and can be installed in the following manner:

```sh
PM> Install-Package Google.Bigquery.V2
```

#### Example

```dotnet
using Google.Bigquery.V2;
...
```

## Google Cloud Datastore

- [API Reference][cloud-datastore-ref]
- [API Overview][cloud-datastore-docs]

The Cloud Datastore client libary is in pre-release state and is more likely to have significant surface changes over time. Still, if you would like to experiment with them, we would welcome your feedback.

### Installation
The package is available from Google's [public MyGet feed][google-myget-feed] and can be installed in the following manner:

```sh
PM> Install-Package Google.Datastore.V1Beta3
```

#### Example

```dotnet
using Google.Datastore.V1Beta3;
...
```

## Google Cloud Logging

- [API Reference][cloud-logging-ref]
- [API Overview][cloud-logging-docs]

The Cloud Logging client libary is in pre-release state and is more likely to have significant surface changes over time. Still, if you would like to experiment with them, we would welcome your feedback.

### Installation
The package is available from Google's [public MyGet feed][google-myget-feed] and can be installed in the following manner:

```sh
PM> Install-Package Google.Logging.V2
```

#### Example

```dotnet
using Google.Logging.V2;
...
```

## Google Cloud Pub/Sub

- [API Reference][cloud-pubsub-ref]
- [API Overview][cloud-pubsub-docs]

The Cloud Pub/Sub client libary is in pre-release state and is more likely to have significant surface changes over time. Still, if you would like to experiment with them, we would welcome your feedback.

### Installation
The package is available from Google's [public MyGet feed][google-myget-feed] and can be installed in the following manner:

```sh
PM> Install-Package Google.Pubsub.V1
```

#### Example

```dotnet
using Google.Pubsub.V1;
...
```

## Google Cloud Storage

- [API Reference][cloud-storage-ref]
- [API Overview][cloud-storage-docs]

The Cloud Storage client libary is in a more advanced state. However, there is no guarantee that the API surface will stay stable until we reach 1.0 - but we have high confidence that the libraries work and are usable.

### Installation
The package is available from [NuGet](https://www.nuget.org/packages/Google.Storage.V1) and can be installed in the following manner:

```sh
PM> Install-Package Google.Storage.V1 -Pre
```

#### Example

```dotnet
using Google.Storage.V1;
...
```

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
[cloud-common-authentication]: https://github.com/GoogleCloudPlatform/gcloud-common/blob/master/authentication/readme.md#authentication
[google-cloud-sdk]: https://cloud.google.com/sdk/
[google-download-sdk]: https://cloud.google.com/sdk/docs/
[google-myget-feed]: https://www.myget.org/gallery/google-dotnet-public/
[cloud-bigquery-ref]: http://googlecloudplatform.github.io/gcloud-dotnet/api/Google.Bigquery.V2.html
[cloud-datastore-ref]: http://googlecloudplatform.github.io/gcloud-dotnet/api/Google.Datastore.V1Beta3.html
[cloud-logging-ref]: http://googlecloudplatform.github.io/gcloud-dotnet/api/Google.Logging.V2.html
[cloud-pubsub-ref]: http://googlecloudplatform.github.io/gcloud-dotnet/api/Google.Pubsub.V1.html
[cloud-storage-ref]: http://googlecloudplatform.github.io/gcloud-dotnet/api/Google.Storage.V1.html
[cloud-bigquery-docs]: https://cloud.google.com/bigquery/
[cloud-datastore-docs]: https://cloud.google.com/datastore/
[cloud-logging-docs]: https://cloud.google.com/logging/
[cloud-pubsub-docs]: https://cloud.google.com/pubsub/
[cloud-storage-docs]: https://cloud.google.com/storage/
[dnvm]: http://docs.asp.net/en/latest/getting-started/index.html
[gRPC]: http://grpc.io
[grpc-workaround]: https://github.com/grpc/grpc/issues/4872
