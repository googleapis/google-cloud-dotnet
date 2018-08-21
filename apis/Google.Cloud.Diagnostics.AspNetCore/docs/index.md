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

The easiest way to initialize Google Diagnostics services in ASP.NET Core 2.0 or higher
is using the `UseGoogleDiagnostics` extentension method on `IWebHostBuilder`. This configures
Logging, Tracing and Error Reporting middleware.

If your application is runnng on GAE you don't need to provide a value for `ProjectID`, `Service`
and `Version` since they can be automatically obtained by the `UseGoogleDiagnostics` method. The
values used will be the ones associated with the running application.

If your application is running on GKE or GCE you don't need to provide a value for `ProjectID`
since it can be automatically determined by the `UseGoogleDiagnostics` method. It will be the
`ProjectID` of the Google Cloud Project where the application is running. You do need to
provide values for `Service` and `Version`, with which to identify the running application.

If your application is running outside of GCP, including when it runs locally, then you'll need to
provide the `ProjectID` of the Google Cloud Project in which to store the diagnostic information
as well as the `Service` and `Version` with which to identify your application.

{{sample:Diagnostics.UseGoogleDiagnostics}}

You can still initialize the separate components using the extension methods below. This can be useful
if you only need to use some of the components or, for instance, if you need to access the `Configuration`
property on the `Startup` class to obtain values for `ProjectID`, `Service` or `Version`.

## Registering Error Reporting

{{sample:ErrorReporting.ReportUnhandledExceptions}}

## Log Exceptions

{{sample:ErrorReporting.LogExceptions}}

## Initializing Logging

{{sample:Logging.RegisterGoogleLogger}}

## Initializing Logging (ASP.NET Core 2.0+)

{{sample:Logging.RegisterGoogleLogger2}}

## Log

{{sample:Logging.UseGoogleLogger}}

## Initializing Tracing

{{sample:Trace.RegisterGoogleTracer}}

## Tracing in MVC Controllers

To use the `IManagedTracer` in MVC controllers you can either inject the singleton instance of 
`IManagedTracer` into the controller's constructor (see `TraceSamplesConstructorController`) or you
can in inject the `IManagedTracer` into the action method using the `[FromServices]` attribute
(see `TraceSamplesMethodController`).

{{sample:Trace.TraceMVCConstructor}}

{{sample:Trace.TraceMVCMethod}}

## Manual Tracing

{{sample:Trace.UseTracer}}

{{sample:Trace.UseTracerRunIn}}

## Trace Outgoing HTTP Requests

{{sample:Trace.TraceOutgoing}}
