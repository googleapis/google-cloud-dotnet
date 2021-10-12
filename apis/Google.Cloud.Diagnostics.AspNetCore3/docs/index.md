{{title}}

`Google.Cloud.Diagnostics.AspNetCore3` is an ASP.NET Core instrumentation library for Google Logging,
Error Reporting and Tracing. It allows for simple integration of Google observability components into ASP.NET Core 3.1+ applications
with minimal custom code.

Note: ASP.NET Core 3.1 is the long-term support release of ASP.NET Core 3.x.

[`Google.Cloud.Diagnostics.Common`](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Diagnostics.Common/latest)
and [`Google.Cloud.Diagnostics.AspNetCore`](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Diagnostics.AspNetCore/latest)
are the recommended instrumentation libraries if you are writing non ASP.NET Core .NET Standard 2.0+ or ASP.NET Core 2.1+
applications respectively.

`Google.Cloud.Diagnostics.Common` documentation is still relevant when using `Google.Cloud.Diagnostics.AspNetCore3`,
as tracing, logging and error reporting is done in the same manner when using either of the packages.
Configuration of `Google.Cloud.Diagnostics.AspNetCore3` and some aspects related to ASP.NET Core applications
being web applications are covered in this document.

{{version}}

{{installation}}

{{auth}}

See [API Permissions for `entries.write`](https://cloud.google.com/logging/docs/access-control#api-permissions)
for the permissions needed for Logging and Error Reporting.

See [API Permissions for PatchTraces](https://cloud.google.com/trace/docs/iam#api_permissions)
for the permissions needed for Tracing.

> **Note**  
> The `Google.Cloud.Diagnostics.AspNetCore3` package attempts to collect the filename and line number when
> error entries are collected. However, to be able to collect this information PDBs must be included with
> the deployed code.

> **Note**  
> Some environments limit or disable CPU usage for background activities, while some others allow you to
> configure CPU allocation for request processing only.
> When running on environments with limited CPU for backgrounf activities, take care not to use the
> timed buffer options for any of Logging, Tracing or Error Reporting. Take into account that the timed buffer
> is used for all of these components by default so you will need to explicitly configure the buffers by using
> the `Google.Cloud.Diagnostics.Common.LoggerOptions`, `Google.Cloud.Diagnostics.Common.TraceOptions` and
> `Google.Cloud.Diagnostics.Common.ErrorReportingOptions` classes.
> Here you can read more about [CPU allocation in Google Cloud Run](https://cloud.google.com/run/docs/tips/general#background-activity).

# Getting started

The easiest way to configure Google Cloud Diagnostics is using the `AddGoogleDiagnosticsForAspNetCore`
overloaded extension method on `IServiceCollection`.
This configures the Logging, Tracing and Error Reporting components, including neccesarry middlewares.

If your application is running on Google App Engine, Google Kubernetes Engine, Google Cloud Run or 
Google Compute Engine, you don't need to provide a value for `ProjectId`, `Service` and `Version`
since they can be automatically obtained by the `AddGoogleDiagnosticsForAspNetCore` methods as far
as they make sense for the environment. (Not every environment has the concept of a "service" or
"version".) The values used will be the ones associated with the running application.

If your application is running outside of GCP, including when it runs locally, then you'll need to provide the 
`ProjectId` of the Google Cloud Project in which to store the diagnostic information as well as the `Service` and `Version`
with which to identify your application.

{{sample:Diagnostics.Configure}}

You can still initialize the separate components using the extension methods described below.
This can be useful if you only need to use some of the observability components.

Optional parameters on `AddGoogleDiagnosticsForAspNetCore` are also available to specify options for each
of the components (logging, tracing and error reporting).

# Error Reporting

The error reporting component allows you to create error reports from exceptions thrown in your application.
You can explicitly log exceptions you have caught, but the component will also log exceptions that haven't been
caught/handled by your code.

## Configuration

You only need to use the `AddGoogleErrorReportingForAspNetCore` extension method on an `IServiceCollection`.
You usually do this on the `ConfigureServices` method of your `Startup` class.

{{sample:ErrorReporting.ReportUnhandledExceptions}}

Error reports will be automatically created from uncaught exceptions and sent to Google Cloud Error Reporting.

## Log Exceptions

You can also log exceptions explicitly.

{{sample:ErrorReporting.LogExceptions}}

# Logging

Configuring and using Google Cloud Logging in ASP.NET Core 3+ applications is very similar to doing so in a
non ASP.NET Core application. See the
[`Google.Cloud.Diagnostics.Common`](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Diagnostics.Common/latest)
documentation for more information.

## Configuration

Configuration of Google Cloud Logging in ASP.NET Core 3+ applications is almost the same as for
non ASP.NET Core applications. You just build the Host as recommended for ASP.NET Core 3+ applications
instead of using the general purpose host builder.

{{sample:Logging.ConfigureAspNetCore3}}

As an alternative, you can configure logging when you are configuring services for your application. This approach is useful
if you are configuring services in a `Startup` class or similar. This alternative is used in the same way for ASP.NET Core and
non ASP.NET Core applications alike.

## Log

When logging, the main difference between ASP.NET Core and non ASP.NET Core applications is how you obtain a logger in container
activated classes, like controllers, pages, etc. Your code does not have to explicitly resolve the dependency, instead the logger
will get injected on construction.

{{sample:Logging.Logging}}

# Tracing

The tracing component allows you to trace your application and send traces to Google Cloud Trace.

## Configuration

You only need to use the `AddGoogleTraceForAspNetCore` extension method on an `IServiceCollection`.
You usually do this on the `ConfigureServices` method of your `Startup` class.

{{sample:Trace.RegisterGoogleTracer}}

## Tracing in Controllers

To use the `IManagedTracer` in controllers you can either inject the singleton instance of 
`IManagedTracer` into the controller's constructor (see `TraceSamplesConstructorController`) or you
can inject the `IManagedTracer` into the action method using the `[FromServices]` attribute
(see `TraceSamplesMethodController`).

{{sample:Trace.TraceMVCConstructor}}

{{sample:Trace.TraceMVCMethod}}

## Using Tracing with other than Google's own trace header

The `Google.Cloud.Diagnostics` packages have been coupled to
[Google's own trace header](https://cloud.google.com/trace/docs/setup#force-trace) from their
initial release up to, and including, version 4.2.0. Starting on version 4.3.0-beta01 and upwards
it is possible to consume and emit trace context information in a format other than Google's own
trace header.

The default behaviour of the libraries is still to consume and emit trace context information using
Google's trace header.

### Custom trace context for incoming HTTP requests

If the HTTP requests that your application handles contain trace context information in a custom format
you need to use dependency injection to register:

- A `Google.Cloud.Diagnostics.Common.ITraceContext`, which will probably be scoped, and that you can create
from information obtained from any other services available via dependency injection, including 
`Microsoft.AspNetCore.Http.IHttpContextAccessor`. The trace context will be obtained per request and used
as the parent context for all trace spans, either implicit or explicit, initiated from within the code handling
the request.
- A `System.Action<Micorosft.AspNetCore.Http.HttpResponse, Google.Cloud.Diagnostics.Common.ITraceContext>`
that will be used to set trace context information on the HTTP response to each request. This will be called
before returning a response with the updated (as modified by the request handling code) trace context information.

### Custom trace context for outgoing HTTP requests

See also [`Google.Cloud.Diagnostics.Common`](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Diagnostics.Common/latest)
documentation for Outgoing HTTP Requests.

If your application itself performs HTTP requests to other services and you want to propagate trace context
information in a format other than Google's trace header, you can use dependency injection to register a
`System.Action<System.Net.Http.HttpRequestMessage, Google.Cloud.Diagnostics.Common.ITraceContext>` that will be
used to set trace context information on outgoing HTTP requests. A few things to notice:

- The format in which you propagate trace context information to external requests doesn't have to be the same as
the format in which trace context information is received by your application. You might even be accepting Google's
trace header, but the service you are calling is not.
- The trace context information propagated to outgoing requests will be the information available at the time the 
request is made, which may or may not be the same as the information you received. For instance, your code may have
created several trace spans before making the outgoing request, in which case the span ID that will be propagated
is the one of the innermost span that remains open at the moment of sending the outgoing request.

### Custom trace context: example

The following is for demonstration purposes only. We assume that trace context information contains a trace ID only
that is propagated in a `custom_trace_id` header. This is of no use in the real world.

{{sample:Trace.CustomTraceContext}}

