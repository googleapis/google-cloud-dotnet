# Google.Devtools.Clouderrorreporting.V1Beta1

`Google.Devtools.Clouderrorreporting.V1Beta1` is a .NET client
library for the [Stackdriver Error Reporting
API](https://cloud.google.com/error-reporting/).

# Installation

Install the `Google.Devtools.Clouderrorreporting.V1Beta1` package from our
[early access MyGet
feed](https://www.myget.org/gallery/google-dotnet-public).
First onfigure your environment to include the appropriate NuGet feed
URL:

- NuGet v2: `https://www.myget.org/F/google-dotnet-public/`
- NuGet v3: `https://www.myget.org/F/google-dotnet-public/api/v3/index.json`

Next, add the package to your project in the normal way (for example
by right-clicking on the project in Visual Studio and choosing
"Manage NuGet Packages..."). Please ensure you enable pre-release
packages (for example, in the Visual Studio NuGet user interface,
check the "Include prerelease" box).

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth login
```

# Getting started

There are three client classes to be aware of:

- [ErrorGroupServiceClient](obj/api/Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroupServiceClient.yml)
- [ErrorStatsServiceClient](obj/api/Google.Devtools.Clouderrorreporting.V1Beta1.ErrorStatsServiceClient.yml)
- [ReportErrorsServiceClient](obj/api/Google.Devtools.Clouderrorreporting.V1Beta1.ReportErrorsServiceClient.yml)

In each case, create an instance using the static `Create` method,
optionally specifying a service endpoint and settings.

# Sample code

## Report an error

[!code-cs[](obj/snippets/Google.Devtools.Clouderrorreporting.V1Beta1.ReportErrorsServiceClient.txt#ReportErrorEvent)]

## List error groups with statistics

[!code-cs[](obj/snippets/Google.Devtools.Clouderrorreporting.V1Beta1.ErrorStatsServiceClient.txt#ListGroupStats)]
