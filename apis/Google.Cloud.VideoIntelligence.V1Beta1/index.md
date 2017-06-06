# Google.Cloud.VideoIntelligence.V1Beta1

`Google.Cloud.VideoIntelligence.V1Beta1` is a .NET client library for the [Google
Cloud Video Intelligence API](https://cloud.google.com/video-intelligence/docs/).

# Installation

Install the `Google.Cloud.VideoIntelligence.V1Beta1` package from NuGet. Add it to
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

The client class is
[VideoIntelligenceServiceClient](obj/api/Google.Cloud.VideoIntelligence.V1Beta1.VideoIntelligenceServiceClient.yml).
Create an instance using the static `Create` method, optionally
specifying a service endpoint and settings. Then use the
`AnnotateVideo` and `AnnotateVideoAsync` methods to perform video
analysis.
