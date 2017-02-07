# Google.Cloud.Diagnostics.AspNet

`Google.Cloud.Diagnostics.AspNet` is an ASP.NET instrumentation library for Google Stackdriver.
It allows for simple integration of Stackdriver into ASP.NET applications with minimal code changes.

`Google.Cloud.Diagnostics.AspNet` currently supports Stackdriver Error Reporting and Stackdriver Trace.

# Installation

Install the `Google.Cloud.Diagnostics.AspNet` package from NuGet. Add it to your project in the normal way
(for example by right-clicking on the project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the Visual Studio NuGet user interface,
check the "Include prerelease" box).

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth application-default login
```

# Getting started

## Registering Error Reporting (Web Api)

Reports error events to the Stackdriver Error Reporting API via the Stackdriver Logging API (default
and suggested method).  For more information see
["Formatting Log Error Messages"](https://cloud.google.com/error-reporting/docs/formatting-error-messages).
[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#RegisterExceptionLoggerWebApi)]

Error events can be reported directly to the Stackdriver Error Reporting API. However, it requires enabling
the [Stackdriver Error Reporting API](https://console.cloud.google.com/apis/api/clouderrorreporting.googleapis.com/overview).
[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#RegisterExceptionLoggerWebApiErrorReportingApi)]

## Registering Error Reporting (MVC)

Reports error events to the Stackdriver Error Reporting API via the Stackdriver Logging API (default
and suggested method).  For more information see
["Formatting Log Error Messages"](https://cloud.google.com/error-reporting/docs/formatting-error-messages).
[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#RegisterExceptionLoggerMvc)]

Error events can be reported directly to the Stackdriver Error Reporting API. However, it requires enabling
the [Stackdriver Error Reporting API](https://console.cloud.google.com/apis/api/clouderrorreporting.googleapis.com/overview).
[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#RegisterExceptionLoggerMvcErrorReportingApi)]

## Initializing Tracing

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#InitializeTrace)]

## Trace Outgoing HTTP Requests

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#TraceOutgoing)]

## Manual Tracing

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#UseTracer)]
