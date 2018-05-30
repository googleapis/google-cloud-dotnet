{{title}}

`Google.Cloud.Diagnostics.AspNetCore` is an ASP.NET Core instrumentation library for Google Stackdriver.
It allows for simple integration of Stackdriver into ASP.NET applications with minimal code changes.

`Google.Cloud.Diagnostics.AspNetCore` currently supports Stackdriver Error Reporting, Stackdriver Logging
and Stackdriver Trace.

{{version}}

{{installation}}

{{auth}}

# Note
The Google.Cloud.Diagnostics.AspNetCore package attempts to collect the filename and line number when
entries are collected. However, to be able to collect this information PDBs must be included with
the deployed code.

# Getting started

## Initializing Google Diagnostics (ASP.NET Core 2.0+)

The preferred way to initialize Google Diagnostics services in ASP.NET Core 2.0 or higher
is using the `UseGoogleDiagnostics` extentension method on `IWebHostBuilder`. This configures
Logging, Tracing and Error Reporting middleware.

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.Diagnostics.txt#UseGoogleDiagnostics)]

You can still initialize the separate components using the extension methods below.

## Registering Error Reporting

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.ErrorReporting.txt#ReportUnhandledExceptions)]

## Log Exceptions

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.ErrorReporting.txt#LogExceptions)]

## Initializing Logging

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.Logging.txt#RegisterGoogleLogger)]

## Initializing Logging (ASP.NET Core 2.0+)

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.Logging.txt#RegisterGoogleLogger2)]

## Log

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.Logging.txt#UseGoogleLogger)]

## Initializing Tracing

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.Trace.txt#RegisterGoogleTracer)]

## Tracing in MVC Controllers

To use the `IManagedTracer` in MVC controllers you can either inject the singleton instance of 
`IManagedTracer` into the controller's constructor (see `TraceSamplesConstructorController`) or you
can in inject the `IManagedTracer` into the action method using the `[FromServices]` attribute
(see `TraceSamplesMethodController`).

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.Trace.txt#TraceMVCConstructor)]

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.Trace.txt#TraceMVCMethod)]

## Manual Tracing

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.Trace.txt#UseTracer)]

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.Trace.txt#UseTracerRunIn)]

## Trace Outgoing HTTP Requests

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.Trace.txt#TraceOutgoing)]
