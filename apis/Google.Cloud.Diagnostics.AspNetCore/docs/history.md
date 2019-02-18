# Version history

# 3.0.0-beta08, 2019-02-18

New features since 2.0.0:

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

# 2.0.0, 2017-11-27

New features since 1.0.0:

- Make Google Project ID optional when creating a Google Logger.
- Support for recommended way of adding logging providers in ASP.NET Core 2.0
- Support for .Net Framework 4.6.

# 1.0.0, 2017-08-25

Initial Release
