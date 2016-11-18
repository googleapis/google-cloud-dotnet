# Google.Monitoring.V3

`Google.Monitoring.V3` is a .NET client library for the [Google
Monitoring API](https://cloud.google.com/monitoring/api/v3/).

# Installation

Install the `Google.Monitoring.V3` package from our
[early access MyGet
feed](https://www.myget.org/gallery/google-dotnet-public).
First configure your environment to include the appropriate NuGet feed
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

- [AgentTranslationServiceClient](obj/api/Google.Monitoring.V3.AgentTranslationServiceClient.yml)
- [GroupServiceClient](obj/api/Google.Monitoring.V3.GroupServiceClient.yml)
- [MetricServiceClient](obj/api/Google.Monitoring.V3.MetricServiceClient.yml)

In each case, create an instance using the static `Create` method,
optionally specifying a service endpoint and settings.

# Sample code

## List metric descriptors

[!code-cs[](obj/snippets/Google.Monitoring.V3.MetricServiceClient.txt#ListMetricDescriptors)]
