{{title}}

{{description}}

{{version}}

Support for automatic error reporting can be found in the
[`Google.Cloud.Diagnostics.AspNet`](../Google.Cloud.Diagnostics.AspNet/index.html)
NuGet package.

{{installation}}

{{auth}}

# Getting started

{{client-classes}}

{{client-construction}}

# Sample code

## Automatic Error Reporting for ASP.NET

Using [`Google.Cloud.Diagnostics.AspNet`'s ExceptionLogger or ExceptionFilter](../Google.Cloud.Diagnostics.AspNet/index.html)
uncaught exceptions in ASP.NET applications can be automatically reported to the Stackdriver Error Reporting API.

In ASP.NET MVC:

[!code-cs[](../Google.Cloud.Diagnostics.AspNet/obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#RegisterExceptionLoggerMvc)]

In Web API:

[!code-cs[](../Google.Cloud.Diagnostics.AspNet/obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#RegisterExceptionLoggerWebApi)]

## Automatic Error Reporting for ASP.NET Core

Using [`Google.Cloud.Diagnostics.AspNetCore`'s Exception Logger Middleware](../Google.Cloud.Diagnostics.AspNetCore/index.html)
uncaught exceptions in ASP.NET Core applications can be automatically reported to the Stackdriver Error Reporting API.

[!code-cs[](../Google.Cloud.Diagnostics.AspNetCore/obj/snippets/Google.Cloud.Diagnostics.AspNetCore.ErrorReporting.txt#ReportUnhandledExceptions)]

## Report an error

[!code-cs[](obj/snippets/Google.Cloud.ErrorReporting.V1Beta1.ReportErrorsServiceClient.txt#ReportErrorEvent)]

## List error groups with statistics

[!code-cs[](obj/snippets/Google.Cloud.ErrorReporting.V1Beta1.ErrorStatsServiceClient.txt#ListGroupStats)]
