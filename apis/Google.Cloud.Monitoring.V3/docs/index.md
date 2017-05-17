# Google.Cloud.Monitoring.V3

`Google.Cloud.Monitoring.V3` is a .NET client library for the [Google
Monitoring API](https://cloud.google.com/monitoring/api/v3/).

# Installation

Install the `Google.Cloud.Monitoring.V3` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth application-default login
```

# Getting started

There are two client classes to be aware of:

- [GroupServiceClient](obj/api/Google.Cloud.Monitoring.V3.GroupServiceClient.yml)
- [MetricServiceClient](obj/api/Google.Cloud.Monitoring.V3.MetricServiceClient.yml)

In each case, create an instance using the static `Create` method,
optionally specifying a service endpoint and settings.

# Sample code

## List metric descriptors

[!code-cs[](obj/snippets/Google.Cloud.Monitoring.V3.MetricServiceClient.txt#ListMetricDescriptors)]

## List groups

[!code-cs[](obj/snippets/Google.Cloud.Monitoring.V3.GroupServiceClient.txt#ListGroups)]
