# Version history

# Version 4.3.0-beta04, released 2021-10-12

- [Commit 03eb674](https://github.com/googleapis/google-cloud-dotnet/commit/03eb674):
  - refactor: Add better extension methods for Google Diagnostics.
   - Make more of the old code obsolete.
   - Delete in XML docs samples that quickly get outdated. We have snippets.
- [Commit 53aa57a](https://github.com/googleapis/google-cloud-dotnet/commit/53aa57a):
  - refactor: Add better extension methods for Diagnostics Logging.
    - Make more of the old code obsolete.
    - Fix naming conflicts between Common and AspNetCore*.
    - Move non ASP.NET core tests to Common.
    - Delete in XML docs samples that quickly get outdated. We have snippets.
- [Commit 037af1a](https://github.com/googleapis/google-cloud-dotnet/commit/037af1a):
  - refactor: Add better extension methods for Diagnostics Error Reporting.
  - Make more of the old code obsolete.
  - Delete in XML docs samples that quickly get outdated. We have snippets.
- [Commit 1a5ef87](https://github.com/googleapis/google-cloud-dotnet/commit/1a5ef87):
  - refactor: Add better extension methods for Diagnostics Tracing.
  - Make more of the old code obsolete.
  - Fix naming conflicts between Common and AspNetCore*.
  - Move non ASP.NET core snippets to Common.
  - Delete in XML docs samples that quickly get outdated. We have snippets.

# Version 4.3.0-beta03, released 2021-07-22

No API surface changes; just publishing docs from 4.3.0-beta02.

# Version 4.3.0-beta02, released 2021-07-22

- [Commit c682904](https://github.com/googleapis/google-cloud-dotnet/commit/c682904):
  - feat: Adds trace context information to error log entries.
  - Closes [issue 5360](https://github.com/googleapis/google-cloud-dotnet/issues/5360)
- [Commit 1245ded](https://github.com/googleapis/google-cloud-dotnet/commit/1245ded): fix: Fully qualifies all alternative types/members for obsolete ones. Fixes [issue 6672](https://github.com/googleapis/google-cloud-dotnet/issues/6672)

# Version 4.3.0-beta01, released 2021-06-24

- [Commit 60e8cd8](https://github.com/googleapis/google-cloud-dotnet/commit/60e8cd8):
  - feat: Copies GoogleLogger to Common. This allows easier use of GoogleLogger in non ASP.NET Core applications.
  - Towards [issue 6367](https://github.com/googleapis/google-cloud-dotnet/issues/6367)
  - Replicate LoggerOptions in Common, and have AspNetCore\*.LoggerOptions be just a wrapper of Common.LoggerOptions.
  - Copies ILogEntryLabelProvider to Common and marks the one in AspNetCore* Obsolete.
  - Makes AspNetCore*.IExternalTraceProvider obsolete. It can now be replaced by Common.ITraceContext.
- [Commit 32cb606](https://github.com/googleapis/google-cloud-dotnet/commit/32cb606):
  - feat: Allows per log entry labels.
  - Closes [issue 5313](https://github.com/googleapis/google-cloud-dotnet/issues/5313)
  - Closes [issue 5929](https://github.com/googleapis/google-cloud-dotnet/issues/5929)
- [Commit c8e9a48](https://github.com/googleapis/google-cloud-dotnet/commit/c8e9a48):
  - refactor: Makes GoogleLoggerScope extendable.
    Moves GoogleLoggerScope to Diagnostics.Common.
    In preparation for allowing LogEntry augmentation and making it easier to use Google logging from non ASP.NET Core apps.
    Towards [issue 5313](https://github.com/googleapis/google-cloud-dotnet/issues/5313), [issue 5360](https://github.com/googleapis/google-cloud-dotnet/issues/5360), [issue 5929](https://github.com/googleapis/google-cloud-dotnet/issues/5929) and [issue 6367](https://github.com/googleapis/google-cloud-dotnet/issues/6367)
- [Commit 7f5f89e](https://github.com/googleapis/google-cloud-dotnet/commit/7f5f89e):
  - docs: Change Stackdriver to Google Cloud, and fix some typos, including in test code.
- [Commit c4c9cd5](https://github.com/googleapis/google-cloud-dotnet/commit/c4c9cd5):
  - feat: Makes it easier to use tracing from non ASP.NET Core applications
    Closes [issue 5897](https://github.com/googleapis/google-cloud-dotnet/issues/5897)
    Towards [issue 6367](https://github.com/googleapis/google-cloud-dotnet/issues/6367)
- [Commit b35b9ea](https://github.com/googleapis/google-cloud-dotnet/commit/b35b9ea):
  - feat: Decouples Diagnostics tracing from Google's trace header. Towards [issue 5360](https://github.com/googleapis/google-cloud-dotnet/issues/5360) and [issue 5897](https://github.com/googleapis/google-cloud-dotnet/issues/5897)
- [Commit 0c00d2c](https://github.com/googleapis/google-cloud-dotnet/commit/0c00d2c):
  - refactor: Remove unnecesary service provider extension method. There's an equivalent method offered by Microsoft.Extensions.DependencyInjection so we don't need our own.
- [Commit bb0c7b2](https://github.com/googleapis/google-cloud-dotnet/commit/bb0c7b2):
  - refactor: Remove unnecesary interface IManagedTracerFactory. It's an internal interface that we don't use anywhere. We can always add it back in if we need it at some point.
- [Commit 8ef3983](https://github.com/googleapis/google-cloud-dotnet/commit/8ef3983):
  - fix: X-Cloud-Trace-Context trace mask values should be 0-1. See https://cloud.google.com/trace/docs/setup#force-trace

Note: changing a generic type parameter constraint in
`LabelProviderExtensions` is notionally a breaking change, but due
to how it will be used, we don't expect it to actually break any customers.

# Version 4.2.0, released 2020-12-07

No API changes since 4.2.0-beta02; just a stable release of the changes since 4.1.0.

# Version 4.2.0-beta02, released 2020-10-12

- [Commit 1cd4ee6](https://github.com/googleapis/google-cloud-dotnet/commit/1cd4ee6): build: Removes ASP.NET Core unused dependencies from Diagnostics* packages. Towards [issue 4750](https://github.com/googleapis/google-cloud-dotnet/issues/4750).

# Version 4.2.0-beta01, released 2020-09-29

- [Commit 5710321](https://github.com/googleapis/google-cloud-dotnet/commit/5710321): feat: Adds GoogleTraceProvider to be used by Logging when Tracing is not configured. Closes [issue 5359](https://github.com/googleapis/google-cloud-dotnet/issues/5359).
- [Commit f46b1c6](https://github.com/googleapis/google-cloud-dotnet/commit/f46b1c6): fix: Corrects Span ID format for adding to Log Entries. Fixes [issue 5358](https://github.com/googleapis/google-cloud-dotnet/issues/5358).
- [Commit 924c503](https://github.com/googleapis/google-cloud-dotnet/commit/924c503): docs: Adds documentation about environments that limit background activities. Closes [issue 5275](https://github.com/googleapis/google-cloud-dotnet/issues/5275).
- [Commit 7480149](https://github.com/googleapis/google-cloud-dotnet/commit/7480149): fix: Sets LogEntry.TraceSampled to true if tracing information is adding to the entry. Fixes [issue 5307](https://github.com/googleapis/google-cloud-dotnet/issues/5307).

# Version 4.1.0, released 2020-08-18

No changes compared with 4.1.0-beta01

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
