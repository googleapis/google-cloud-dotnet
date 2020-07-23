# Google.Cloud.Logging.Console

This directory is highly experimental, and the package may well be
renamed before release.

It contains a console formatter which formats log entries as JSON
using the properties expected by Google Cloud Logging. This provides
a very lightweight (and non-invasive) way of getting a great logging
experience when running ASP.NET Core (or any other framework that
integrates with Microsoft.Extensions.Logging) on Google Cloud
Platform.

The Google.Cloud.Logging.Console.SampleApp directory contains a
vanilla ASP.NET Core web site used for testing the formatter. This
directory may well be removed later. The [Dockerfile](Dockerfile)
in *this* directory is used to deploy the sample app on Cloud Run,
using commands like the following:

```sh
gcloud builds submit --tag gcr.io/$GOOGLE_CLOUD_PROJECT/console-formatter
gcloud run deploy --platform managed --image gcr.io/$GOOGLE_CLOUD_PROJECT/console-formatter
```
