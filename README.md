# Google Cloud Libraries for .NET
.NET idiomatic client libraries for [Google Cloud Platform](https://cloud.google.com/) services.

[![Travis build Status](https://travis-ci.org/GoogleCloudPlatform/google-cloud-dotnet.svg?branch=master)](https://travis-ci.org/GoogleCloudPlatform/google-cloud-dotnet)
[![Appveyor build status](https://ci.appveyor.com/api/projects/status/d25hbwksdu6y9v5t?svg=true)](https://ci.appveyor.com/project/GoogleCloudPlatform/google-cloud-dotnet)
[![Coverage Status](https://coveralls.io/repos/github/GoogleCloudPlatform/google-cloud-dotnet/badge.svg)](https://coveralls.io/github/GoogleCloudPlatform/google-cloud-dotnet)

* [Homepage](https://cloud.google.com/dotnet/)
* [API Documentation](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/)


The Google Cloud Libraries for .NET support the following Google Cloud Platform services:

* [Google BigQuery](https://cloud.google.com/bigquery/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Bigquery.V2/)
* [Google Cloud Datastore](https://cloud.google.com/datastore/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Datastore.V1/)
* [Stackdriver Logging](https://cloud.google.com/logging/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Logging.V2/)
* Google Cloud Metadata - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Metadata.V1)
* [Google Cloud Pub/Sub](https://cloud.google.com/pubsub/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Pubsub.V1/)
* [Google Cloud Storage](https://cloud.google.com/storage/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Storage.V1/)
* [Google Cloud Vision](https://cloud.google.com/vision/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Vision.V1/)
* [Google Cloud Natural Language](https://cloud.google.com/natural-language/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Language.V1Beta1/)
* [Google Cloud Speech](https://cloud.google.com/speech/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Speech.V1Beta1/)
* [Stackdriver Monitoring](https://cloud.google.com/monitoring/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Monitoring.V3/)
* [Stackdriver Error Reporting](https://cloud.google.com/error-reporting/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Devtools.Clouderrorreporting.V1Beta1/)
* [Stackdriver Trace](https://cloud.google.com/trace/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Devtools.Cloudtrace.V1/)

> Note: This client is a work-in-progress, and may occasionally
> make backwards-incompatible changes.

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
explained in the [authentication
document](https://github.com/GoogleCloudPlatform/gcloud-common/blob/master/authentication/readme.md#authentication).

Next, choose a method for authenticating API requests from within your project:

1. When using `google-cloud-dotnet` libraries from within Compute/App Engine, no additional authentication steps are necessary.
2. When using `google-cloud-dotnet` libraries elsewhere, you can do one of the following:
    * Define the environment variable GOOGLE_APPLICATION_CREDENTIALS to be the location of the key.  For example:

      ```
      set GOOGLE_APPLICATION_CREDENTIALS=/path/to/my/key.json
      ``` 
    * If running locally for development/testing, you can authenticate using the [Google Cloud SDK)(https://cloud.google.com/sdk/).
      Download the SDK if you haven't already, then login by running the following in the command line:

      ```
      gcloud auth login
      ```

## Contributing

Contributions to this library are always welcome and highly encouraged.

See [CONTRIBUTING.md](./CONTRIBUTING.md) for more information on how to get started.

## Versioning

The Google Cloud Client Libraries for .NET follow [Semantic Versioning](http://semver.org/).

Anything with a major version of zero (`0.y.z`) should not be
considered stable - anything may change at any time.

Anything with a suffix after the three numbers (such as `1.0.0-beta01`) is expected to work,
but further API changes may occur before the next stable release.

## License

Apache 2.0 - See [LICENSE](./LICENSE) for more information.
