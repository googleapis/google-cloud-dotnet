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

The server supports four URLs:

- `/simple` logs a simple informational message
- `/complex` logs a message containing a parameter
- `/error` throws a very simple exception which is logged as an error
- `/scopes` logs a message in a nested scope
- `/deep-exception` throws an exception with a non-trivial stack trace
- `/nested-exception` throws an exception containing another one
- `/async-exception` throws an exception from an async method (which
  calls other async methods)

