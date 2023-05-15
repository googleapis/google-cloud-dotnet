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

The console formatter supports [log correlation](https://cloud.google.com/logging/docs/view/correlate-logs) and
[Google Cloud Trace log integration](https://cloud.google.com/trace/docs/trace-log-integration) via trace IDs.
This requires a number of conditions to be met:

- Your application needs to be exporting log entries to Google Cloud Logging via an agent that reads from stdout.
  This happens automatically when running on Google Cloud, and is presumably the reason you're using this
  console formatter.
- Your application needs to be exporting traces to Google Cloud Trace. This could be performed automatically
  by the runtime, or via explicit code or instrumentation. Google Cloud runtimes export some traces automatically.
  (For example, Cloud Run will [export traces for received requests](https://cloud.google.com/run/docs/trace)
  by default, but you would need to export traces for any additional information.)
  Please refer to the documentation for the runtime you're using for more details.
- When writing a server application, the current .NET [Activity]
  (https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.activity)
  needs to be initialized with the trace context included in the current request. ASP.NET Core does this for you
  automatically based on HTTP headers. Alternatively, if your application is starting traces itself (for example,
  if it's responding to Pub/Sub messages instead of HTTP requests), it needs
  to initialize the current Activity explicitly, as described in the [Distributed Tracing guide]
  (https://learn.microsoft.com/en-us/dotnet/core/diagnostics/distributed-tracing).
- The console formatter needs to be configured with the Google Cloud Project ID
  where the traces are beeing exported to. When running in Google Cloud, that's usually the same project in which the
  code is running.

Configuring the formatter involves specifying the `TraceGoogleCloudProjectId` properties in the
`GoogleCloudConsoleFormatterOptions` used to create the formatter, as shown below:

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
