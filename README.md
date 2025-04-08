# Google Cloud Libraries for .NET
.NET idiomatic client libraries for [Google Cloud Platform](https://cloud.google.com/) services.

[![GitHub Actions status](https://img.shields.io/github/actions/workflow/status/googleapis/google-cloud-dotnet/build-push.yml?branch=main)](https://github.com/googleapis/google-cloud-dotnet/actions/workflows/build-push.yml)

* [Homepage](https://cloud.google.com/dotnet/)
* [API Documentation](https://cloud.google.com/dotnet/docs/reference/)

# Available APIs

This repository contains code for the following client libraries.
Each package name links to the documentation for that package.

| Package | Latest version | Description |
|---------|----------------|-------------|
| [Google.Cloud.Parallelstore.V1Beta](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Parallelstore.V1Beta/latest) | [![NuGet](https://img.shields.io/nuget/v/Google.Cloud.Parallelstore.V1Beta)](https://nuget.org/packages/Google.Cloud.Parallelstore.V1Beta) | [Parallelstore](http://cloud/parallelstore?hl=en) |

If you need support for other Google APIs, check out the
[Google .NET API Client library](https://github.com/google/google-api-dotnet-client)

## Example Applications

* [getting-started-dotnet](https://github.com/GoogleCloudPlatform/getting-started-dotnet/) -
  A [quickstart and tutorial](https://cloud.google.com/dotnet/) that demonstrates how to build a complete web 
  application using Cloud Datastore, Cloud Storage, and Cloud Pub/Sub and deploy it to Google Compute Engine.

## Specifying a Project ID

Most Google Cloud Libraries for .NET require a project ID. If you
don't remember yours (or haven't created a project yet), navigate to
the [Google Developers Console](https://console.developers.google.com/project) to view
your project ID (or create a new project and then get the ID). Once
done, record the value and make sure to pass it as a parameter to
the methods that require it.

## Authentication

Every API call needs to be authenticated. In order to successfully
make a call, first ensure that the necessary [Google Cloud
APIs](https://console.developers.google.com/apis/library/) are enabled for your project and that
you've downloaded the right set of keys (if it applies to you) as
explained in the [authentication documentation](https://cloud.google.com/docs/authentication).

Next, choose a method for authenticating API requests from within your project:

1. When using `google-cloud-dotnet` libraries from within Compute/App Engine, no additional authentication steps are necessary.
2. When using `google-cloud-dotnet` libraries elsewhere, you can do one of the following:
    * Define the environment variable GOOGLE_APPLICATION_CREDENTIALS to be the location of the key.  For example:

      ```
      set GOOGLE_APPLICATION_CREDENTIALS=/path/to/my/key.json
      ``` 
    * If running locally for development/testing, you can authenticate using the [Google Cloud SDK](https://cloud.google.com/sdk/).
      Download the SDK if you haven't already, then login by running the following in the command line:

      ```
      gcloud auth application-default login
      ```

## Supported platforms

See the [Supported Platforms
documentation](https://cloud.google.com/dotnet/docs/reference/help/platforms)
for details on where the Google Cloud Libraries for .NET are
supported.

## Versioning

The Google Cloud Client Libraries for .NET follow [Semantic Versioning](http://semver.org/).

The version number in the package *name* (and .NET namespace)
represents the version of the underlying API; the version number for
the package itself indicates the status of the client library.

See the [Versioning
documentation](https://cloud.google.com/dotnet/docs/reference/help/versioning)
for more details.

## License

Apache 2.0 - See [LICENSE](./LICENSE) for more information.
