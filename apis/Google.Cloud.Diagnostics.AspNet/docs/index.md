{{title}}

`Google.Cloud.Diagnostics.AspNet` is an ASP.NET instrumentation library for Google Stackdriver.
It allows for simple integration of Stackdriver into ASP.NET applications with minimal code changes.

`Google.Cloud.Diagnostics.AspNet` currently supports Stackdriver Error Reporting and Stackdriver Trace.

{{version}}

{{installation}}

{{auth}}

# Note
The Google.Cloud.Diagnostics.AspNet package attempts to collect the filename and line number when
entries are collected.  However, to be able to collect this information PDBs must be included with
the deployed code.

# Getting started

## Registering Error Reporting (Web Api)

{{sample:ErrorReporting.RegisterExceptionLoggerWebApi}}

## Log Exceptions (Web Api)

{{sample:ErrorReporting.LogExceptionsWebApi}}

## Registering Error Reporting (MVC)

{{sample:AspNet.RegisterExceptionLoggerMvc}}

## Log Exceptions (MVC)

{{sample:AspNet.LogExceptionsMVC}}

## Initializing Tracing

{{sample:AspNet.InitializeTrace}}

## Trace Outgoing HTTP Requests

{{sample:AspNet.TraceOutgoing}}

## Manual Tracing

{{sample:AspNet.UseTracer}}

{{sample:AspNet.UseTracerRunIn}}
