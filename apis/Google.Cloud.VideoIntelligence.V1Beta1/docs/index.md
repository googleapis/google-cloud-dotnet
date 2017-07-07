# Google.Cloud.VideoIntelligence.V1Beta1

`Google.Cloud.VideoIntelligence.V1Beta1` is a .NET client library for the [Google
Cloud Video Intelligence API](https://cloud.google.com/video-intelligence).

# Installation

Install the `Google.Cloud.VideoIntelligence.V1Beta1` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

# Authentication

When running on Google Cloud Platform, no action needs to be taken to authenticate.

Otherwise, the simplest way of authenticating your API calls is to
[download a service account JSON file](https://developers.google.com/identity/protocols/OAuth2ServiceAccount),
then set the `GOOGLE_APPLICATION_CREDENTIALS` environment variable to refer to it. The
credentials will automatically be used to authenticate.

Note that the default credentials obtained by running `gcloud auth application-default login` from the Cloud SDK
are not suitable for use with this API. (They will work initially, but implicitly have a very
small request quota.)

# Getting started

All operations are performed through
[VideoIntelligenceServiceClient](obj/api/Google.Cloud.VideoIntelligence.V1Beta1.VideoIntelligenceServiceClient.yml).

Perform an initial call to `AnnotateVideo` or `AnnotateVideoAsync`.
This will return a long-running operation, which you can poll to
check for completion and the results.

# Sample code

## Annotate labels within a video

[!code-cs[](obj/snippets/Google.Cloud.VideoIntelligence.V1Beta1.VideoIntelligenceServiceClient.txt#AnnotateVideo)]

