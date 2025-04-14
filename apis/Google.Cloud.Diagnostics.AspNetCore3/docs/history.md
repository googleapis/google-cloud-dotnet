# Version history

## Version 5.3.0, released 2025-04-14

No API surface changes; just dependency updates.

## Version 5.2.0, released 2024-03-05

No API surface changes; just dependency updates.

## Version 5.1.0, released 2023-02-08

No API surface changes; just dependency updates.

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

## Version 4.4.0, released 2022-01-17

### Bug fixes

- Adds AddGoogleDiagnosticsForAspNetCore empty overload. ([commit 18ecd5c](https://github.com/googleapis/google-cloud-dotnet/commit/18ecd5cbc94b7cab721e2cbae39444e5ba3615fb))
 - To avoid ambiguity, which results in a compiler error, when not specifying any of the optional parameters for the other overloads.
 - Fixes [issue 7633](https://github.com/googleapis/google-cloud-dotnet/issues/7633)

## Version 4.3.1, released 2021-11-09

No API surface changes; just dependency updates.

## Version 4.3.0, released 2021-11-01

No API surface changes; just releasing a stable version.

## Version 4.3.0-beta08, released 2021-10-25

Version 4.3.0-beta07 was not released because of CI errors.

No API surface changes; just dependency updates.

## Version 4.3.0-beta07, released 2021-10-20

No API surface changes; just dependency updates.

## Version 4.3.0-beta06, released 2021-10-13

Versions 4.3.0-beta04 and 4.3.0-beta05 were not released because of CI errors.
This version contains all changes described for the unreleased version 4.3.0-beta04.

## Version 4.3.0-beta05, released 2021-10-13

Version 4.3.0-beta04 was not released because of a CI error.
This version contains all changes described for the unreleased version 4.3.0-beta04.

## Version 4.3.0-beta04, released 2021-10-12

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

## Version 4.2.0, released 2020-12-07

No API changes since 4.0.0-beta01, but this is the first stable release.

The version number is 4.2.0 to align with
Google.Cloud.Diagnostics.AspNetCore and
Google.Cloud.Diagnostics.Common.

## Version 4.0.0-beta01, released 2020-10-12

- [Commit 1cd4ee6](https://github.com/googleapis/google-cloud-dotnet/commit/1cd4ee6): feat: Adds Google.Cloud.Diagnostics.AspNetCore3 library. Towards [issue 4750](https://github.com/googleapis/google-cloud-dotnet/issues/4750).
  - Initial release of Google.Cloud.Diagnostics.AspNetCore3 which supports ASP.NET Core 3.1.
  - Main differences with respect to Google.Cloud.Diagnostics.AspNetCore:
    - Depends on Microsoft.AspNetCore.App framework instead of the Microsoft.AspNetCore* packages.
    - Microsoft.AspNetCore.Hosting.IHostingEnvironment => Microsoft.AspNetCore.Hosting.IWebHostEnvironment
