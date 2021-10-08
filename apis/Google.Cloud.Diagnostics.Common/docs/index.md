{{title}}

`Google.Cloud.Diagnostics.Common` is a .NET Core instrumentation library for Google Logging,
Error Reporting and Tracing. It allows for simple integration of Google observability components into .NET Standard 2.0+ applications
with minimal custom code.

[`Google.Cloud.Diagnostics.AspNetCore`](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Diagnostics.AspNetCore/latest) and
[`Google.Cloud.Diagnostics.AspNetCore3`](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Diagnostics.AspNetCore3/latest)
are the recommended instrumentation libraries if you are writing ASP.NET Core 2.1 or ASP.NET Core 3.1+ applications respectively.

{{version}}

{{installation}}

{{auth}}

See [API Permissions for `entries.write`](https://cloud.google.com/logging/docs/access-control#api-permissions)
for the permissions needed for Logging and Error Reporting.

See [API Permissions for PatchTraces](https://cloud.google.com/trace/docs/iam#api_permissions)
for the permissions needed for Tracing.

> **Note**  
> The `Google.Cloud.Diagnostics.Common` package attempts to collect the filename and line number when
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
> Bellow you'll find examples of how to configure the buffers.
> Here you can read more about [CPU allocation in Google Cloud Run](https://cloud.google.com/run/docs/tips/general#background-activity).

> **Note**
> Using `Google.Cloud.Diagnostics.Common` for non ASP.NET Core applications relies heavily on
> .NET's Dependency Injection mechanism.
> You can read more about .NET dependency injection in non ASP.NET Core applications in the
> [Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage).

# Error reporting

The error reporting component allows you to create error reports from exceptions thrown in your application.

## Configuration

The first step is to configure the error reporting component for dependency injection.

{{sample:ErrorReporting.Configure}}

And then start the host. This will probably be done in your `Main` method.

{{sample:ErrorReporting.Start}}

## Logging exceptions

Now you can log exceptions whenever they are thrown. Meaningful error reports will be created and sent to
Google Cloud Error Reporting.

{{sample:ErrorReporting.LogException}}

# Tracing

## Configuration

The first step is to configure the tracing component for dependency injection.

{{sample:Trace.Configure}}

And then start the host. This will probably be done in your `Main` method.

{{sample:Trace.Start}}

## Starting a trace

How to start a trace will depend on how you want to trace, and what type of application you want to trace.

- You want to trace all activity of your application in one trace (within potentially different spans). This
is best suited for scheduled services or user facing applications (like desktop applications) where you want
to have one trace per usage session.
- Your application is a service reacting to requests/events (for instance it's a subscriber on a publisher/subscriber
architectured system). You want a trace per request/event; the trace may have even be initialized by the emitter of
said request/event.

### One trace per usage session

If you want to have one trace per usage session, then right after starting the host, probably on your `Main` method
you would create the trace.

{{sample:Trace.SingleContext}}

Note that when you create the tracing context, you don't need to specify trace ID or span ID (although you may),
`Google.Cloud.Diagnostics.Common` will create a trace ID for you. Each span you create will be created with it's own
span ID.

Note that you should specify `true` for the `shouldTrace`parameter to make sure tha tracing happens regardless
of tracing rates/qps, etc.

### One trace per request/event

If your application reacts to requests/events, then on the method that receives each of those (your listener method)
you need to extract the trace context information from the request and ser it on the tracer.

{{sample.Trace.IncomingContext}}

Note that we can't go into detail here as to how extract trace context information from a request/event, as that's
dependent on the emitter of said request/event.

If the emitter of requests/events is not attaching trace context information, then you can start your own
trace for each request/event. On your listener method, you would have code similar to the one in the
[One trace per usage sesion](### One trace per usage session). But consider in this case not forcing the trace,
instead specify `null` for the `shouldTrace` parameter. The tracer will decide whether to trace each request based
on tracing rates/qps, etc.

## Starting a span

For any traces to be sent to Google Cloud Trace, a span needs to be started.

{{sample.Trace.Trace}}

Or alternatively, using the `RunInSpan` methods.

{{sample.Trace.RunInSpan}}

## Troubleshooting Tracing

Failures in tracing are most easily diagnosed by removing buffering and propagating exceptions immediately.

{{sample:Trace.Troubleshooting}}

These options may be specified wherever you are configuring tracing.

## Trace Outgoing HTTP Requests

If your application itself performs HTTP requests to other services you may want to propagate trace context information.
The [recommended way of creating `HttpClient`](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-3.1)
in .NET Standard 2.0+ and upwards is to use the `System.Net.Http.IHttpClientFactory` defined in the
`Microsoft.Extensions.Http` package.
The following example demonstrates how to register and use an `HttpClient` using Google Trace so that it propagates trace
context information for outgoing requests.

### Configuration

{{sample:Trace.ConfigureHttpClient}}

### Usage

{{sample:Trace.TraceOutgoingClientFactory}}

### Custom trace context for outgoing HTTP requests

If you configure the trace component for outgoing requests, it will, by default, set on them
[Google's own trace header](https://cloud.google.com/trace/docs/setup#force-trace).
If you want to propagate trace context information in a format other than Google's trace header, you can use dependency
injection to register an action `System.Action<System.Net.Http.HttpRequestMessage, Google.Cloud.Diagnostics.Common.ITraceContext>`
that will be used to set trace context information on outgoing HTTP requests. A few things to notice:

- The format in which you propagate trace context information to external requests doesn't have to be the same as
the format in which trace context information is received by your application.

- The trace context information propagated to outgoing requests will be the information available at the time the 
request is made, which may or may not be the same as the information you received. For instance, your code may have
created several trace spans before making the outgoing request, in which case the span ID that will be propagated
is the one of the innermost span that remains open at the moment of sending the outgoing request.

Here's an example of how your configuration may look like. You then use `System.Net.Http.IHttpClientFactory` as shown
in [Usage](### Usage).

Note that the following is for demonstration purposes only. We assume that trace context information contains a trace ID only
that is propagated in a `custom_trace_id` header. This is of no use in the real world.

{{sample:Trace.CustomConfigureHttpClient}}

