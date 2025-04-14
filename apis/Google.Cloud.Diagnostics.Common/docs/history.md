# Version history

## Version 5.3.0, released 2025-04-14

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit cba7759](https://github.com/googleapis/google-cloud-dotnet/commit/cba77591907c4a4594a184466534ee9e258bb5ef))
- Remove unnecessary net462 target from Google.Cloud.Diagnostics.Common. ([commit 4a7ba3e](https://github.com/googleapis/google-cloud-dotnet/commit/4a7ba3ef66af9702ea3f583bc247a6a1e02a0339))

## Version 5.2.0, released 2024-03-05

No API surface changes; just dependency updates.

## Version 5.1.0, released 2023-02-08

### New features

- Allow handling of timer thread exceptions in timed buffers. ([commit 957f4b4](https://github.com/googleapis/google-cloud-dotnet/commit/957f4b43914a8063a8af1fa6013f3533f1712da1))
- Adds a ProviderAlias attribute to GoogleLoggerProvider ([commit a6f9e7c](https://github.com/googleapis/google-cloud-dotnet/commit/a6f9e7c5e76813874a07f449f0333beeebe89aa7))

## Version 5.0.0, released 2022-06-09

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
documentation](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax4).
We don't anticipate any changes to most customer code, but please [file a
GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if you run into problems.

The most important change in this release is the use of the Grpc.Net.Client package
for gRPC communication, instead of Grpc.Core. When using .NET Core 3.1 or .NET 5.0+
this should lead to a smaller installation footprint and greater compatibility (e.g.
with Apple M1 chips). Any significant change in a core component comes with the risk
of incompatibility, however - so again, please let us know if you encounter any
issues.

## Breaking changes

Previously deprecated members have been removed. This reduces
confusion, where there were previously multiple similarly-named
classes and methods due to moving functionality into the common
package.

Additionally, `ErrorReportingOptions.CreateInstance` has been renamed to just `Create` for consistency. ([commit 610320e](https://github.com/googleapis/google-cloud-dotnet/commit/610320e5663d44ceba44480de242870832765e10))

## Version 4.4.0, released 2022-01-17

### Bug fixes

- Adds AddGoogleDiagnostics empty overload. ([commit d5c3963](https://github.com/googleapis/google-cloud-dotnet/commit/d5c396346dae01654d869f3cf82fcf71e2483b1f))
 - To avoid ambiguity, which results in a compiler error, when not specifying any of the optional parameters for the other overloads.
 - Fixes [issue 7633](https://github.com/googleapis/google-cloud-dotnet/issues/7633)
- Use service version instead of name ([commit 437e6c4](https://github.com/googleapis/google-cloud-dotnet/commit/437e6c418146ff2b529dfb612dc5b284cf5427d9))

### New features

- Custom labels for outgoing traces. ([commit d8d213c](https://github.com/googleapis/google-cloud-dotnet/commit/d8d213ce0d2c42b62c6935de3f00db4162b85fe9))
 - Closes [issue 7430](https://github.com/googleapis/google-cloud-dotnet/issues/7430)

## Version 4.3.1, released 2021-11-09

- [Commit b1318ac](https://github.com/googleapis/google-cloud-dotnet/commit/b1318ac):
  - fix: Respects the service client set through error reporting options.
  - Adds missing tests for all options.
  - Closes [issue 7448](https://github.com/googleapis/google-cloud-dotnet/issues/7448)

## Version 4.3.0, released 2021-11-01

No API surface changes; just releasing a stable version.

## Version 4.3.0-beta08, released 2021-10-25

Version 4.3.0-beta07 was not released because of CI errors.
This version also contains the changes described for the unreleased version 4.3.0-beta07.

- [Commit 99307c0](https://github.com/googleapis/google-cloud-dotnet/commit/99307c0):
  - tests: Always reset the trace rate limiter before registering Diagnostics services.
  - Else, services are registered with the existing trace rate limiter which migh make tests flaky.
  - This is probably part of the reason of some long standing test flakiness in tracing.
  - Note that this only affects tests, as on production code rate limiting is determined by configuration options.
- [Commit f77f48b](https://github.com/googleapis/google-cloud-dotnet/commit/f77f48b):
  - fix: Skip DI scope validation for the trace context provider.
  - Logging may happen outside a scope, i.e. a web server starting where each request is a scope.
  - The trace context provider is by defintion scoped.
  - When logging outside a scope we simply don't add trace information to the log entry.
  - As extra info:
  - Scope validation is only enabled by default on a development environment.
  - Diagnostics, by default, ignores logging exceptions.
  - To reproduce the issue this commit fixes both scope validation and Diagnostis exception propagation needed to be enabled.

## Version 4.3.0-beta07, released 2021-10-20

- [Commit 6e34e22](https://github.com/googleapis/google-cloud-dotnet/commit/6e34e22): refactor: Fully standardize error reporting options.

## Version 4.3.0-beta06, released 2021-10-13

Versions 4.3.0-beta04 and 4.3.0-beta05 were not released because of CI errors.
This version contains all changes described for the unreleased version 4.3.0-beta04.

## Version 4.3.0-beta05, released 2021-10-13

Version 4.3.0-beta04 was not released because of a CI error.
This version contains all changes described for the unreleased version 4.3.0-beta04.

## Version 4.3.0-beta04, released 2021-10-12

- [Commit 6c3117a](https://github.com/googleapis/google-cloud-dotnet/commit/6c3117a): process: Add the correct license header.
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

## Version 4.3.0-beta03, released 2021-07-22

No API surface changes; just publishing docs from 4.3.0-beta02.

## Version 4.3.0-beta02, released 2021-07-22

- [Commit c682904](https://github.com/googleapis/google-cloud-dotnet/commit/c682904):
  - feat: Adds trace context information to error log entries.
  - Closes [issue 5360](https://github.com/googleapis/google-cloud-dotnet/issues/5360)
- [Commit 1245ded](https://github.com/googleapis/google-cloud-dotnet/commit/1245ded): fix: Fully qualifies all alternative types/members for obsolete ones. Fixes [issue 6672](https://github.com/googleapis/google-cloud-dotnet/issues/6672)

## Version 4.3.0-beta01, released 2021-06-24

Note: Starting from this version, this package will be augmented so that it can be used for loggin, tracing and error reporting
to Google Cloud in non ASP.NET Core applications.
[Google.Cloud.Diagnostics.AspNetCore](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Diagnostics.AspNetCore/latest) and
[Google.Cloud.Diagnostics.AspNetCore3](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Diagnostics.AspNetCore3/latest) continue
to be the recommended packages for using in ASP.NET Core and ASP.NET Core 3 or later applications, respectively.


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

## Version 4.2.0, released 2020-12-07 and earlier

This package is not usually intended for direct consumption; it's a
dependency of other packages. The release histories of those
higher-level packages are more useful:

- [Google.Cloud.Diagnostics.AspNetCore](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Diagnostics.AspNetCore/latest/history)
- [Google.Cloud.Diagnostics.AspNetCore3](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Diagnostics.AspNetCore3/latest/history)
- [Google.Cloud.Diagnostics.AspNet](https://googleapis.dev/dotnet/Google.Cloud.Diagnostics.AspNet/latest/history.html)
