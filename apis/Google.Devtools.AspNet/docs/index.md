# Google.Devtools.AspNet

`Google.Devtools.AspNet` is an ASP.NET instrumentation library for Google Stackdriver.
It allows for simple integration of Stackdriver into ASP.NET applications with minimal code changes.

`Google.Devtools.AspNet` currently supports Stackdriver Error Reporting and Stackdriver Trace.

# Installation

Install the `Google.Devtools.AspNet` package from NuGet. Add it to
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
> gcloud auth login
```

# Getting started

## Registering Error Reporting

[!code-cs[](obj/snippets/Google.Devtools.AspNet.AspNet.txt#RegisterExceptionLogger)]

## Initializing Tracing

[!code-cs[](obj/snippets/Google.Devtools.AspNet.AspNet.txt#InitializeTrace)]

## Manual Tracing

[!code-cs[](obj/snippets/Google.Devtools.AspNet.AspNet.txt#UseTracer)]
