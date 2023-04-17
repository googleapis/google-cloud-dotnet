# Google.Cloud.Logging.Console

This directory contains a console formatter which formats log
entries as JSON using the properties expected by Google Cloud
Logging. This provides a very lightweight (and non-invasive) way of
getting a great logging experience when running ASP.NET Core (or any
other framework that integrates with Microsoft.Extensions.Logging)
on Google Cloud Platform.

The SampleApp directory contains a Minimal API which can be used for
testing the formatter. The [Dockerfile](Dockerfile) in *this*
directory is used to deploy the sample app on Cloud Run, using
commands like the following:

```sh
gcloud builds submit --tag gcr.io/$GOOGLE_CLOUD_PROJECT/console-formatter
gcloud run deploy --platform managed --image gcr.io/$GOOGLE_CLOUD_PROJECT/console-formatter
```

The server supports the following URLs:

- `/simple` logs a simple informational message
- `/complex` logs a message containing a parameter
- `/error` throws a very simple exception which is logged as an error
- `/scopes` logs a message in a nested scope
- `/deep-exception` throws an exception with a non-trivial stack trace
- `/nested-exception` throws an exception containing another one
- `/async-exception` throws an exception from an async method (which
  calls other async methods)

## Log trace correlation

To see log trace correlation in action in the SampleApp deployed in Google Cloud Run,
ensure that the `TraceGoogleCloudProjectId` is set to a valid Google Cloud Project ID
where trace data is being exported to. Google Cloud Run initiates trace with the
project ID of the Google Cloud Project where the service is deployed, so this is the ID that
needs to be set. This can be done by setting the `TraceGoogleCloudProjectId`
field in [appsettings.json](SampleApp/appsettings.json) before deployment.

After deployment, try one of the supported URLs. This will generate a log entry with trace context information,
which can be seen in the [Logs Viewer](https://console.cloud.google.com/logs/viewer) in the Google Cloud Console.
