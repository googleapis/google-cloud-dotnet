{{title}}

`Google.Cloud.Logging.Log4Net` is a .NET client library to integrate  [Google Cloud
Logging](https://cloud.google.com/logging/) with
[log4net](https://logging.apache.org/log4net/).

{{version}}

{{installation}}

{{auth}}

## Getting started

See the [configuration guide](configuration.md) for details of all GoogleStackdriverAppender configuration options.

## ASP.NET

Add the log4net section to the `Web.config` file:

[!code-xml[](obj/snippets/Google.Cloud.Logging.Log4Net.GoogleStackdriverAppender.txt#log4net_aspnet_template)]

Edit the file replacing `PROJECT_ID` with your Google Cloud Project
ID, and `LOG_ID` with an identifier for your application.

{{sample:GoogleStackdriverAppender.Overview_AspNet}}

If executing on [Google App Engine (GAE)](https://cloud.google.com/appengine/),
[Google Kubernetes Engine (GKE)](https://cloud.google.com/kubernetes-engine/),
or [Google Compute Engine (GCE)](https://cloud.google.com/compute/),
then the `<projectId value="PROJECT_ID" />` configuration setting can be omitted; it will be auto-detected from the platform at run-time.

## Console app

Create a `log4net` configuration file (`log4net.xml`):

[!code-xml[](obj/snippets/Google.Cloud.Logging.Log4Net.GoogleStackdriverAppender.txt#log4net_template)]

Edit the file replacing `PROJECT_ID` with your Google Cloud Project
ID, and `LOG_ID` with an identifier for your application.

Use this file to configure `log4net` and then log as normal:

{{sample:GoogleStackdriverAppender.Overview}}

If executing on [Google App Engine (GAE)](https://cloud.google.com/appengine/),
[Google Kubernetes Engine (GKE)](https://cloud.google.com/kubernetes-engine/),
or [Google Compute Engine (GCE)](https://cloud.google.com/compute/),
then the `<projectId value="PROJECT_ID" />` configuration setting can be omitted; it will be auto-detected from the platform at run-time.
