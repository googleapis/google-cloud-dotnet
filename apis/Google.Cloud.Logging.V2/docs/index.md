{{title}}

{{description}}

{{version}}

Integration with [log4net](https://logging.apache.org/log4net/) is provided by
the [Google.Cloud.Logging.Log4Net](../Google.Cloud.Logging.Log4Net/index.html) package.

{{installation}}

If you wish to use the log4net integration, install the
`Google.Cloud.Logging.Log4Net` package in the same way.

{{auth}}

# Support from third party libraries

The [Logary](https://github.com/logary/logary) logging library has a target
supporting Google Stackdriver logging. Install the [NuGet
package](https://www.nuget.org/packages/Logary.Targets.Stackdriver)
and follow the [instructions on the project
homepage](https://github.com/logary/logary#stackdriver-target-alpha-level).

[Serilog](https://serilog.net/) has a sink output to Google Stackdriver Logging. Install the [NuGet package](https://www.nuget.org/packages/Serilog.Sinks.GoogleCloudLogging/) `Serilog.Sinks.GoogleCloudLogging` and [configure options](https://github.com/manigandham/serilog-sinks-googlecloudlogging).

# Raw RPC API

If required, this package provides a low-level abstraciton over the
raw RPC API.

{{client-classes}}

{{client-construction}}
