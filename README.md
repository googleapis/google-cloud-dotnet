# Google Cloud Libraries for .NET
.NET idiomatic client libraries for [Google Cloud Platform](https://cloud.google.com/) services.

[![Travis build Status](https://travis-ci.org/GoogleCloudPlatform/google-cloud-dotnet.svg?branch=master)](https://travis-ci.org/GoogleCloudPlatform/google-cloud-dotnet)
[![Appveyor build status](https://ci.appveyor.com/api/projects/status/d25hbwksdu6y9v5t?svg=true)](https://ci.appveyor.com/project/GoogleCloudPlatform/google-cloud-dotnet)
[![Coverage Status](https://codecov.io/gh/GoogleCloudPlatform/google-cloud-dotnet/branch/master/graph/badge.svg)](https://codecov.io/gh/GoogleCloudPlatform/google-cloud-dotnet)

* [Homepage](https://cloud.google.com/dotnet/)
* [API Documentation](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/)

The following libraries are available at a [GA](#versioning) quality level:

* [Google BigQuery](https://cloud.google.com/bigquery/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.BigQuery.V2/) (GA)
* [Google Cloud Datastore](https://cloud.google.com/datastore/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Datastore.V1/) (GA)
* Google Cloud Diagnostics for ASP.NET - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Diagnostics.AspNet/) (GA)
* Google Cloud Diagnostics for ASP.NET Core - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Diagnostics.AspNetCore/) (GA)
* [Google Stackdriver Logging](https://cloud.google.com/logging/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Logging.V2/) (GA)
  * Integration with Log4Net is provided via [Google.Cloud.Logging.Log4Net](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Logging.Log4Net/) (GA)
* [Google Cloud Natural Language](https://cloud.google.com/natural-language/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Language.V1/) (GA)
* [Stackdriver Monitoring](https://cloud.google.com/monitoring/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Monitoring.V3/) (GA)
* [Google Cloud Speech](https://cloud.google.com/speech/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Speech.V1/) (GA)
* [Google Cloud Storage](https://cloud.google.com/storage/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Storage.V1/) (GA)
* [Stackdriver Trace v1](https://cloud.google.com/trace/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Trace.V1/) (GA)
* [Google Cloud Translation](https://cloud.google.com/translate/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Translation.V2/) (GA)
* [Google Cloud Video Intelligence](https://cloud.google.com/video-intelligence/) - [API docs](https://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.VideoIntelligence.V1/) (GA)
* [Google Cloud Vision](https://cloud.google.com/vision/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Vision.V1/) (GA)
  * Additionally, the following libraries are available for access to beta API functionality:
    * [Google.Cloud.Vision.V1P1Beta1](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Vision.V1P1Beta1/)
    * [Google.Cloud.Vision.V1P2Beta1](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Vision.V1P2Beta1/)
* [Google Cloud Spanner](https://cloud.google.com/spanner/): four packages are available, all GA:
  * [Google.Cloud.Spanner.Data](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Spanner.Data/): ADO.NET provider for Google Cloud Spanner (recommended)
  * [Google.Cloud.Spanner.V1](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Spanner.V1/): Low-level access to Spanner API
  * [Google.Cloud.Spanner.Admin.Database.V1](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Spanner.Admin.Database.V1/): Database administration API
  * [Google.Cloud.Spanner.Admin.Instance.V1](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Spanner.Admin.Instance.V1/): Instance administration API

The following libraries are available at a [beta](#versioning) quality level:

* [Google BigQuery Data Transfer](https://cloud.google.com/bigquery/transfer/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.BigQuery.DataTransfer.V1/) (beta)
* [Google Kubernetes Engine](https://cloud.google.com/kubernetes-engine/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Container.V1) (beta)
* [Google Cloud Dataproc](https://cloud.google.com/dataproc/) - [API docs](https://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Dataproc.V1/) (beta)
* [Google Cloud Debugger](https://cloud.google.com/debugger/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Debugger.V2) (beta)
* [Dialogflow Enterprise Edition](https://cloud.google.com/dialogflow-enterprise/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Dialogflow.V2) (beta)
* [Google Cloud Data Loss Prevention](https://cloud.google.com/dlp/)
  * [V2 API docs](https://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Dlp.V2/) (beta)
  * The Google.Cloud.Dlp.V2Beta1 package has now been deprecated, and is unlisted on nuget.org.
    Please update to Google.Cloud.Dlp.V2.
* [Stackdriver Error Reporting](https://cloud.google.com/error-reporting/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.ErrorReporting.V1Beta1/) (beta)
* [Google Cloud Firestore](https://cloud.google.com/firestore/): two packages are available, both beta:
  * [Google.Cloud.Firestore](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Firestore/): High-level client library for Google Cloud Firestore (recommended)
  * [Google.Cloud.Firestore.V1Beta1](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Firestore.V1Beta1/): Low-level access to Firestore API
* [Google Stackdriver Logging](https://cloud.google.com/logging/)
  * Integration with NLog is provided via [Google.Cloud.Logging.NLog](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Logging.NLog/) (beta)
* [Google OS Login](https://cloud.google.com/compute/docs/instances/managing-instance-access) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.OsLogin.V1/) (beta)
* [Google Cloud Pub/Sub](https://cloud.google.com/pubsub/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.PubSub.V1/) (beta)
* [Google Cloud Memorystore for Redis](https://cloud.google.com/memorystore/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Redis.V1Beta1/) (beta)
* [Stackdriver Trace v2](https://cloud.google.com/trace/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Trace.V2/) (beta)

The following libraries are available at an [alpha](#versioning) quality level:

* [Google Cloud Bigtable](https://cloud.google.com/bigtable/) - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Bigtable.V2/) (alpha)
  * Also the Bigtable admin API - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Bigtable.Admin.V2/) (alpha)
* Google Cloud Metadata - [API docs](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Metadata.V1) (alpha)

See the [API documentation](http://googlecloudplatform.github.io/google-cloud-dotnet/docs/) for details of the status
of each library.

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
      gcloud auth application-default login
      ```

## Supported platforms

See the [Supported Platforms
documentation](https://googlecloudplatform.github.io/google-cloud-dotnet/docs/guides/platforms.html)
for details on where the Google Cloud Libraries for .NET are
supported.

## Contributing

Contributions to this library are always welcome and highly encouraged.

See [CONTRIBUTING.md](./CONTRIBUTING.md) for more information on how to get started.

## Versioning

The Google Cloud Client Libraries for .NET follow [Semantic Versioning](http://semver.org/).

The version number in the package *name* (and .NET namespace)
represents the version of the underlying API; the version number for
the package itself indicates the status of the client library, according to
the following quality levels:

**GA**: Libraries defined at a GA (General Availability) quality level are
expected to be stable: breaking API changes will not be made without a new major
release.

**Beta**: Libraries defined at a Beta quality level are expected to
be stable and working, but the API surface is still under active
development. We encourage you to experiment with these libraries, but
expect breaking changes in future versions. There may still be
issues, but we have a fairly high degree of confidence.

**Alpha**: Libraries defined at an Alpha quality level are still
experimental. They may have significant issues, and the API surface
will almost certainly change before a final release. We encourage
experimentation with these libraries on test projects, but strongly
discourage you from using them in a production environment.

## License

Apache 2.0 - See [LICENSE](./LICENSE) for more information.
