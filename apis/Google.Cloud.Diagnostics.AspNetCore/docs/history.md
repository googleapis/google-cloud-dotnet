# Version history

# Version 4.1.0-beta01, released 2020-08-03

- [Commit 587cafd](https://github.com/googleapis/google-cloud-dotnet/commit/587cafd): Makes Tracing rate limiter treat overflow values as always/never trace.
- [Commit b6dcc51](https://github.com/googleapis/google-cloud-dotnet/commit/b6dcc51):
  - Adds external trace context support for log entries.
  -   * Fixes [issue 5044](https://github.com/googleapis/google-cloud-dotnet/issues/5044)
  - Stops explicitly looking at Google trace header for trace information to include in log entries.
  -   * Looking at Google trace header for trace information can now be achieved by either:
  -     * Activating the Diagnostics Tracing component of this library.
  -     * Implementing an external trace provider to do so.
- [Commit 20601d4](https://github.com/googleapis/google-cloud-dotnet/commit/20601d4):
  - Associates logs to the correct trace/span if there is one.
  -   * Fixes [issue 5190](https://github.com/googleapis/google-cloud-dotnet/issues/5190)
- [Commit 1509482](https://github.com/googleapis/google-cloud-dotnet/commit/1509482): Fixes [issue 5028](https://github.com/googleapis/google-cloud-dotnet/issues/5028): Adds options to specify service context values for GoogleLogger.

# Version 4.0.0, released 2020-03-18

No API surface changes compared with 4.0.0-beta02, just dependency
and implementation changes.

# Version 4.0.0-beta02, released 2020-03-10

- [Commit 5bc0cf5](https://github.com/googleapis/google-cloud-dotnet/commit/5bc0cf5): GoogleExceptionLogger accepts null HttpContext.

# Version 4.0.0-beta01, released 2020-02-19

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

There are no direct API surface changes in *this* package, but the
changes in dependencies can still cause breaking changes.

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
