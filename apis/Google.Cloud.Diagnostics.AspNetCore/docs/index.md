{{title}}

`Google.Cloud.Diagnostics.AspNetCore` is an ASP.NET Core instrumentation library for Google Stackdriver.
It allows for simple integration of Stackdriver into ASP.NET applications with minimal code changes.

`Google.Cloud.Diagnostics.AspNetCore` currently supports Stackdriver Error Reporting, Stackdriver Logging
and Stackdriver Trace.

{{installation}}

{{auth}}

# Getting started

## Registering Error Reporting

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#ReportUnandledExceptions)]

## Log Exceptions

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#LogExceptions)]

## Initializing Logging

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#RegisterGoogleLogger)]

## Log

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#UseGoogleLogger)]

## Initializing Tracing

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#RegisterGoogleTracer)]

## Tracing in MVC Controllers

To use the `IManagedTracer` in MVC controllers you can either inject the singleton instance of 
`IManagedTracer` into the controller's constructor (see `SampleConstructorController`) or you
can in inject the `IManagedTracer` into the action method using the `[FromServices]` attribute
(see `SampleMethodController`).

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#TraceMVCConstructor)]

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#TraceMVCMethod)]

## Manual Tracing

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#UseTracer)]

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#UseTracerRunIn)]

## Trace Outgoing HTTP Requests

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNetCore.AspNetCore.txt#TraceOutgoing)]
