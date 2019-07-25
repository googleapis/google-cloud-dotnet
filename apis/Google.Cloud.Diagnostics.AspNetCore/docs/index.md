{{title}}

`Google.Cloud.Diagnostics.AspNetCore` is an ASP.NET Core instrumentation library for Google Stackdriver.
It allows for simple integration of Stackdriver into ASP.NET applications with minimal code changes.

This package supports Stackdriver Error Reporting, Stackdriver
Logging and Stackdriver Trace, and integrates with ASP.NET Core 2.1
(which is the long-term support release of ASP.NET Core 2.x) and above.

{{version}}

{{installation}}

{{auth}}

# Note
The Google.Cloud.Diagnostics.AspNetCore package attempts to collect the filename and line number when
entries are collected. However, to be able to collect this information PDBs must be included with
the deployed code.

# Getting started

## Initializing Google Diagnostics

The easiest way to initialize Google Diagnostics services is using
the `UseGoogleDiagnostics` extentension method on `IWebHostBuilder`.
This configures Logging, Tracing and Error Reporting middleware.

If your application is runnng on Google App Engine, Google
Kubernetes Engine, Google Cloud Run or Google Compute Engine, you
don't need to provide a value for `ProjectID`, `Service` and
`Version` since they can be automatically obtained by the
`UseGoogleDiagnostics` method as far as they make sense for the
environment. (Not every environment has the concept of a "service"
or "version".) The values used will be the ones associated with the running application.

If your application is running outside of GCP, including when it
runs locally, then you'll need to provide the `ProjectID` of the
Google Cloud Project in which to store the diagnostic information as
well as the `Service` and `Version` with which to identify your
application.

{{sample:Diagnostics.UseGoogleDiagnostics}}

You can still initialize the separate components using the extension
methods below. This can be useful if you only need to use some of
the components or, for instance, if you need to access the
`Configuration` property on the `Startup` class to obtain values for
`ProjectID`, `Service` or `Version`.

Optional parameters on `UseGoogleDiagnostics` are also available to
specify options for each of the components (logging, tracing and
error reporting). This is typically useful for diagnosing problems,
as described below

# Error Reporting

## Registering Error Reporting

{{sample:ErrorReporting.ReportUnhandledExceptions}}

## Log Exceptions

{{sample:ErrorReporting.LogExceptions}}

# Logging

## Initializing Logging

Logging can be initialized using `ConfigureServices` when
constructing a `WebHostBuilder()`:

{{sample:Logging.RegisterGoogleLogger2}}

Or using `ConfigureLogging` when constructing a `WebHostBuilder()`:

{{sample:Logging.RegisterGoogleLogger3}}

Note that this approach does not support custom services (such as
log entry label providers) being used as the service provider is
not available within `ConfigureLogging`.

Alternatively, logging can be configured within the application's
`ConfigureServices` method:

{{sample:Logging.RegisterGoogleLogger}}

## Log

{{sample:Logging.UseGoogleLogger}}

## Troubleshooting Logging

Sometimes it is neccessary to diagnose log operations. It might be that logging is failing or that
we simply cannot find where the logs are being stored in GCP. What follows are a couple of code samples
that can be useful to find out what might be wrong with logging operations.

### Propagating Exceptions

By default the Google Logger won't propagate any exceptions thrown during logging. This is to protect the
application from crashing if logging is not possible. But logging is an important aspect of most applications
so at times we need to know if it's failing and why. The following
example shows how to configure Google Logger so that it propagates exceptions thrown during logging.

{{sample:Logging.RegisterGoogleLoggerPropagateExceptions}}

The same `LoggerOptions` can be specified in any of the other ways
of registering logging.

### Finding out the URL where logs are written

Depending on where your code is running and the options you provided
for creating a Google Logger, it might be hard to find your logs in
the GCP Console. We have provided a way for you to obtain the URL
where your logs can be found.

As the following code sample shows, you only need to pass a
`System.IO.TextWriter` (typically `Console.Out` or `Console.Error`)
as part of the options when registering logging. When the
`GoogleLoggerProvider` is initialized, the URL where its logs can be
found will be written to the given text writer.

{{sample:Logging.RegisterGoogleLoggerWriteUrl}}

Please note that since this is a Google Logger diagnostics feature,
we don't respect settings for exception handling, i.e. we propagate
any exception thrown while writing the URL to the given text writer
so you know what might be happening. This feature should only be
activated as a one off, if you are having trouble trying to find
your logs in the GCP Console, and not as a permanent feature in
production code. To deactivate this feature simply stop passing a
`System.IO.TextWriter` as part of the options when creating a Google
Logger.

# Tracing

## Initializing Tracing

{{sample:Trace.RegisterGoogleTracer}}

## Troubleshooting Tracing

Just as with logging, trace is most easily diagnosed by removing
buffering and propagating exceptions immediately.

{{sample:Trace.Troubleshooting}}

The options can be specified wherever you are configuring tracing.

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

## Trace Outgoing HTTP Requests (recommended)

The [recommended way of creating HttpClient](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-2.1) in ASP.NET Core 2.0 and upwards is to use the
`System.Net.Http.IHttpClientFactory` defined in the Microsoft.Extensions.Http package.
The following example demonstrates how to register and use an HttpClient using Google Trace so that it traces
outgoing requests.

### Configuration

{{sample:Trace.ConfigureHttpClient}}

### Usage

{{sample:Trace.TraceOutgoingClientFactory}}

## Trace Outgoing HTTP Requests (alternative)

Alternatively, if you need to construct `HttpClient` objects manually,
`TraceHeaderPropagatingHandler` can be used to propagate trace
headers:

{{sample:Trace.TraceOutgoing}}

