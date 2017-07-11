{{title}}

`Google.Cloud.Diagnostics.AspNet` is an ASP.NET instrumentation library for Google Stackdriver.
It allows for simple integration of Stackdriver into ASP.NET applications with minimal code changes.

`Google.Cloud.Diagnostics.AspNet` currently supports Stackdriver Error Reporting and Stackdriver Trace.

{{installation}}

{{auth}}

# Getting started

## Registering Error Reporting (Web Api)

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#RegisterExceptionLoggerWebApi)]

## Registering Error Reporting (MVC)

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#RegisterExceptionLoggerMvc)]

## Log Exceptions

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#LogExceptions)]

## Initializing Tracing

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#InitializeTrace)]

## Trace Outgoing HTTP Requests

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#TraceOutgoing)]

## Manual Tracing

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#UseTracer)]

[!code-cs[](obj/snippets/Google.Cloud.Diagnostics.AspNet.AspNet.txt#UseTracerRunIn)]
