# Google.Cloud.Trace.V1

`Google.Cloud.Trace.V1` is a .NET client
library for the [Stackdriver Trace
API](https://cloud.google.com/trace/).

# Installation

Install the `Google.Cloud.Trace.V1` package from our
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

The main entry point for the API is [TraceServiceClient](obj/api/Google.Cloud.Trace.V1.TraceServiceClient.yml).
Create an instance using the static `Create` method, optionally specifying a service endpoint and settings.

# Sample code

## List traces

[!code-cs[](obj/snippets/Google.Cloud.Trace.V1.TraceServiceClient.txt#ListTraces)]
