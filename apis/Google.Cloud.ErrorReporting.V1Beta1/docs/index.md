{{title}}

{{description}}

Support for automatic error reporting can be found in the
[`Google.Cloud.Diagnostics.AspNet`](../Google.Cloud.Diagnostics.AspNet/index.html)
NuGet package.

{{installation}}

{{auth}}

# Getting started

There are three client classes to be aware of:

- [ErrorGroupServiceClient](obj/api/Google.Cloud.ErrorReporting.V1Beta1.ErrorGroupServiceClient.yml)
- [ErrorStatsServiceClient](obj/api/Google.Cloud.ErrorReporting.V1Beta1.ErrorStatsServiceClient.yml)
- [ReportErrorsServiceClient](obj/api/Google.Cloud.ErrorReporting.V1Beta1.ReportErrorsServiceClient.yml)

In each case, create an instance using the static `Create` method,
optionally specifying a service endpoint and settings.

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

[!code-cs[](../Google.Cloud.Diagnostics.AspNetCore/obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#ReportUnandledExceptions)]

## Report an error

[!code-cs[](obj/snippets/Google.Cloud.ErrorReporting.V1Beta1.ReportErrorsServiceClient.txt#ReportErrorEvent)]

## List error groups with statistics

[!code-cs[](obj/snippets/Google.Cloud.ErrorReporting.V1Beta1.ErrorStatsServiceClient.txt#ListGroupStats)]
