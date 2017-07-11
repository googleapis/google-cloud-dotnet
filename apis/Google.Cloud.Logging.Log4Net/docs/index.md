{{title}}

`Google.Cloud.Logging.Log4Net` is a .NET client library to integrate  [Google Stackdriver
Logging](https://cloud.google.com/logging/) with
[log4net](https://logging.apache.org/log4net/).

{{installation}}

Install the `Google.Cloud.Logging.Log4Net` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

{{auth}}

# Getting started

See the [readme](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/blob/master/apis/Google.Cloud.Logging.Log4Net/Google.Cloud.Logging.Log4Net/readme.md) for all GoogleStackdriverAppender configuration options.

## ASP.NET

Add the log4net section to the `Web.config` file:

[!code-xml[](obj/snippets/Google.Cloud.Logging.Log4Net.GoogleStackdriverAppender.txt#log4net_aspnet_template)]

Edit the file replacing `PROJECT_ID` with your Google Cloud Project
ID, and `LOG_ID` with an identifier for your application.

[!code-cs[](obj/snippets/Google.Cloud.Logging.Log4Net.GoogleStackdriverAppender.txt#Overview_AspNet)]

If executing on [Google App Engine (GAE)](https://cloud.google.com/appengine/) or [Google Compute Engine (GCE)](https://cloud.google.com/compute/), then the `<projectId value="PROJECT_ID" />` configuration setting can be omitted; it will be auto-detected from the platform at run-time.

## Console app

Create a `log4net` configuration file (`log4net.xml`):

[!code-xml[](obj/snippets/Google.Cloud.Logging.Log4Net.GoogleStackdriverAppender.txt#log4net_template)]

Edit the file replacing `PROJECT_ID` with your Google Cloud Project
ID, and `LOG_ID` with an identifier for your application.

Use this
file to configure `log4net` and then log as normal:

[!code-cs[](obj/snippets/Google.Cloud.Logging.Log4Net.GoogleStackdriverAppender.txt#Overview)]

If executing on [Google App Engine (GAE)](https://cloud.google.com/appengine/) or [Google Compute Engine (GCE)](https://cloud.google.com/compute/), then the `<projectId value="PROJECT_ID" />` configuration setting can be omitted; it will be auto-detected from the platform at run-time.
