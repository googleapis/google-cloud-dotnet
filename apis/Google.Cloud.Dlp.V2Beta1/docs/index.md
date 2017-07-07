# Google.Cloud.Dlp.V2Beta1

`Google.Cloud.Dlp.V2Beta1` is a .NET client library for the [Google
Cloud Data Loss Prevention API](https://cloud.google.com/dlp/).

# Installation

Install the `Google.Cloud.Dlp.V2Beta1` package from NuGet. Add it to
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

# Getting started

All operations are performed through
[DlpServiceClient](obj/api/Google.Cloud.Dlp.V2Beta1.DlpServiceClient.yml).

# Sample code

## Redact information in plain text

[!code-cs[](obj/snippets/Google.Cloud.Dlp.V2Beta1.DlpServiceClient.txt#Intro)]
