{{title}}

{{description}}
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

# Raw RPC API

If required,
[LoggingServiceV2Client](obj/api/Google.Cloud.Logging.V2.LoggingServiceV2Client.yml)
provides a low-level abstraction over the raw RPC API.
