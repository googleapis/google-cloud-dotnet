# Google.Cloud.Logging.Console

`Google.Cloud.Logging.Console` is a package providing a [custom
console
formatter](https://docs.microsoft.com/en-us/dotnet/core/extensions/console-log-formatter)
designed to be used with [Cloud Logging](https://cloud.google.com/logging/docs).

{{installation}}

## Registering the formatter

After installing the NuGet package, the formatter can be installed
using the `AddGoogleCloudConsole` extension method:

```csharp
using Google.Cloud.Logging.Console;
...
var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddGoogleCloudConsole();
```

Additional options can be provided either in appsettings.json or in
the extension method call. For example, to enable scopes to be
logged, you could change the above code to:


```csharp
using Google.Cloud.Logging.Console;
...
var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddGoogleCloudConsole(options => options.IncludeScopes = true);
```

## Log trace correlation

The console formatter supports Google Cloud Trace and log correlation. This means that
if the application using the console formatter is running in Google Cloud and exports traces
to Google Cloud Trace, the trace context information, if available, can be included in the log entry.

It is important to note that the console formatter does not start, modify or persist the trace information in any way.
It only includes the available trace context information in the log entry for correlation.

To enable log trace correlation, set the `TraceGoogleCloudProjectId` property of the formatter options
to the ID of the Google Cloud Project where trace data is being written to Google Cloud Trace.
This property is optional, and if not set, the trace context information will not be
included in the log entry. It has no effect on where log entries are written to or
whether trace information is exported to Google Cloud Trace or to which Google Cloud Project traces are exported to.

Note that when application runs in Google Cloud, for instance in Google Cloud Run,
trace information is automatically collected and exported by the runtime.

If the application is responsible for initiating the traces, it is application's responsibility to ensure
that the traces are exported to Google Cloud Trace, in the same Google Cloud Project as specified in the console formatter options.

The code to enable log trace correlation is shown below:

```csharp
using Google.Cloud.Logging.Console;
...
var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddGoogleCloudConsole(options => options.TraceGoogleCloudProjectId = "google-project-id");
```

## Formatter output

The formatter writes JSON entries in the format expected by Cloud
Logging. In particular, it uses the following JSON property names:

- `message`: the formatted log message
- `severity`: the log entry severity
- `category`: the logger category
- `exception`: the exception stack trace, if any
- `format_parameters`: the format parameters for the message, if any
- `scopes`: the scope information for the log entry, if the
  `IncludeScopes` option is enabled and there is scope information
  available

No timestamp is included in the JSON, as this is automatically
picked up by the logging agent.

Most log entry severity mappings are obvious, but the ASP.NET Core
`LogLevel.Trace` level maps to `DEBUG` in Cloud Logging.

When viewing the log entries in the Logs Explorer, the severity is
shown in the root of the entry. Other aspects are within the
`jsonPayload` property.
