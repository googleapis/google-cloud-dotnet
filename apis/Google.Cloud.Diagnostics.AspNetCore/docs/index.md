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

# Error Reporting

## Registering Error Reporting

{{sample:ErrorReporting.ReportUnhandledExceptions}}

## Log Exceptions

{{sample:ErrorReporting.LogExceptions}}

# Logging

## Initializing Logging

{{sample:Logging.RegisterGoogleLogger}}

## Initializing Logging (ASP.NET Core 2.0+)

{{sample:Logging.RegisterGoogleLogger2}}

## Log

{{sample:Logging.UseGoogleLogger}}

## Troubleshooting Logging

Sometimes it is neccessary to diagnose log operations. It might be that logging is failing or that
we simply cannot find where the logs are being stored in GCP. What follows are a couple of code samples
that can be useful to find out what might be wrong with logging operations.

### Propagating Exceptions

By default the Google Logger won't propagate any exceptions thrown during logging. This is to protect the
application from crashing if logging is not possible. But logging is an important aspect of most applications
so at times we need to know if it's failing and why. The following examples show how to configure Google Logger
so that it propagates exceptions thrown during logging.

#### Propagating Exceptions

{{sample:Logging.RegisterGoogleLoggerPropagateExceptions}}

#### Propagating Exceptions (ASP.NET Core 2.0+)

{{sample:Logging.RegisterGoogleLoggerPropagateExceptions2}}

### Finding out the URL where logs are written

Depending on where your code is running and the options you provided for creating a Google Logger,
it might be hard to find your logs in the GCP Console. We have provided a way for you to obtain the URL
where your logs can be found.

As the following code samples show, you only need to pass a `System.IO.TextWriter` as part of the options
when creating a Google Logger. Whenever a Google Logger is created, the URL where its logs can be found
will be written to the given text writer.

Please note that since this is a Google Logger diagnostics feature, we don't respect settings for exception
handling, i.e. we propogate any exception thrown while writing the URL to the given text writer so you know
what might be happening. This feature should only be activated as a one off, if you are having trouble trying
to find your logs in the GCP Console, and not as a permanent feature in production code. To deactivate this feature
simply stop passing a `System.IO.TextWriter` as part of the options when creating a Google Logger.

#### Finding out the UR: where logs are written

{{sample:Logging.RegisterGoogleLoggerWriteUrl}}

#### Finding out the UR: where logs are written (ASP.NET Core 2.0+)

{{sample:Logging.RegisterGoogleLoggerWriteUrl2}}

# Tracing

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

## Trace Outgoing HTTP Requests (all platforms)

{{sample:Trace.TraceOutgoing}}

## Trace Outgoing HTTP Requests (recommended for ASP.NET Core 2.0 upwards)

The [recommended way of creating HttpClient](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-2.1) in ASP.NET Core 2.0 and upwards is to use the 
`System.Net.Http.IHttpClientFactory` defined in the Microsoft.Extensions.Http package.
The following example demonstrates how to register and use an HttpClient using Google Trace so that it traces
outgoing requests.

### Configuration

{{sample:Trace.ConfigureHttpClient}}

### Usage

{{sample:Trace.TraceOutgoingClientFactory}}
