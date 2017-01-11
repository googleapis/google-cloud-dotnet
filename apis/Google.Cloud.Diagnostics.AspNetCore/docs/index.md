# Google.Cloud.Diagnostics.AspNetCore

`Google.Cloud.Diagnostics.AspNetCore` is an ASP.NET Core instrumentation library for Google Stackdriver.
It allows for simple integration of Stackdriver into ASP.NET applications with minimal code changes.

`Google.Cloud.Diagnostics.AspNetCore` currently supports Stackdriver Error Reporting and Stackdriver Logging.

# Installation

Install the `Google.Cloud.Diagnostics.AspNetCore` package from our
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
> gcloud auth application-default login
```

# Getting started

## Registering Error Reporting

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#ReportUnandledExceptions)]

## Initializing Logging

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#RegisterGoogleLogger)]

## Log

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#UseGoogleLogger)]