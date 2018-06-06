{{title}}

`Google.Cloud.Logging.NLog` is a .NET client library to integrate  [Google Stackdriver
Logging](https://cloud.google.com/logging/) with
[NLog](http://nlog-project.org/).

{{installation}}

Install the `Google.Cloud.Logging.NLog` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

{{auth}}

# Getting started

## Console app

Create an `nlog` configuration file (`nlog.xml`):

[!code-xml[](obj/snippets/Google.Cloud.Logging.NLog.GoogleStackdriverTarget.txt#nlog_template)]

Edit the file replacing `PROJECT_ID` with your Google Cloud Project
ID, and `LOG_ID` with an identifier for your application.

Use this file to configure `nlog` and then log as normal:

[!code-cs[](obj/snippets/Google.Cloud.Logging.NLog.GoogleStackdriverTarget.txt.txt#Overview)]

If executing on [Google App Engine (GAE)](https://cloud.google.com/appengine/),
[Google Kubernetes Engine (GKE)](https://cloud.google.com/kubernetes-engine/),
or [Google Compute Engine (GCE)](https://cloud.google.com/compute/),
then the `projectId="PROJECT_ID"` configuration setting can be omitted; it will be auto-detected from the platform at run-time.
