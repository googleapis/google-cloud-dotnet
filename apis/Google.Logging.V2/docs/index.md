# Google.Logging.V2

`Google.Logging.V2` is a .NET client library for [Google Stackdriver
Logging](https://cloud.google.com/logging/). Integration with
[log4net](https://logging.apache.org/log4net/) is provided by
the `Google.Logging.Log4Net` package.

# Installation

Install the `Google.Logging.V2` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

If you wish to use the log4net integration, install the
`Google.Logging.Log4Net` package in the same way.

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth login
```

# Getting started (log4net)

First create a `log4net` configuration file (`log4net.xml`) as below:

[!code-xml[](obj/snippets/Google.Logging.Log4Net.GoogleStackdriverAppender.txt#log4net_template)]

Edit the file replacing `PROJECT_ID` with your Google Cloud Project
ID, and `LOG_ID` with an identifier for your application. Use this
file to configure `log4net` and then log as normal.

[!code-cs[](obj/snippets/Google.Logging.Log4Net.GoogleStackdriverAppender.txt#Overview)]

See the
[readme](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/blob/master/src/Google.Logging.Log4Net/readme.md)
for details on all the configuration options.

(Depends on `Google.Logging.Type` for version-agnostic types.)

# Raw RPC API

If required,
[LoggingServiceV2Client](obj/api/Google.Logging.V2.LoggingServiceV2Client.yml)
provides a low-level abstraction over the raw RPC API.
