# Google.Cloud.Logging.Console

`Google.Cloud.Logging.Console` is a package providing a [custom
console
formatter](https://docs.microsoft.com/en-us/dotnet/core/extensions/console-log-formatter)
designed to be used with [Cloud Logging](https://cloud.google.com/logging/docs).

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
