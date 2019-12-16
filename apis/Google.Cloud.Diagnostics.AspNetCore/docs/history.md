# Version history

# Version 3.0.0, released 2019-12-16

This is the last version of this package to depend on GAX 2.x and
Grpc.Core 1.x. We expect to release a new version depending on GAX
3.x and Grpc.Core 2.x, but without other significant changes, early in 2020.
Beyond that version, there are multiple directions this package
could take based on customer feedback, demand for an ASP.NET
package, and the progress of other diagnostic approaches.

New features since 2.0.0:

- Add ICloudTraceNameProvider to allow custom names for root trace.
- Remove service name and version requirement for error reporting.
- Upgrade to ASP.NET Core 2.1.
- Accept options for logging, tracing and error reporting on UseGoogleDiagnostics method.
- Add the ASP.NET trace identifier to trace labels.
- Extension method for IWebHostBuilder for reading monitored resource data from host builder context.
- When logging exceptions, we have stopped logging HTTP Status Code information since we were storing inconsistent values.
- Supporting the .NET Standard 2.0 `System.Net.Http.IHttpClientFactory` for creating `System.Net.Http.HttpClient` instances when tracing outgoing requests.
- Adds format parameters from all parent log scopes in a log entry.
- Out of the box log entries label providers.
- Hook to allow for custom labels to be added to log entries.
- Convenience extension method for registering Google Diagnostics in `Microsoft.AspNetCore.Hosting.IWebHostBuilder`.
- By default all log entries are stored in one single log on Stackdriver.
- Add trace IDs to log entries if they are available.
- Optionally write out log target information to a TextWriter on initialization

# Version 2.0.0, released 2017-11-27

New features since 1.0.0:

- Make Google Project ID optional when creating a Google Logger.
- Support for recommended way of adding logging providers in ASP.NET Core 2.0
- Support for .Net Framework 4.6.

# Version 1.0.0, released 2017-08-25

Initial Release
