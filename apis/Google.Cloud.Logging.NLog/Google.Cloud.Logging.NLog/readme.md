# Google Cloud Logging NLog target

`Google.Cloud.Logging.NLog` is a .NET client library to integrate [Google Stackdriver Logging](https://cloud.google.com/logging/)
with [NLog](https://github.com/NLog/NLog).

## Installation

Install the `Google.Cloud.Logging.NLog` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

## Getting started

This library uses the [Google-Cloud-Dotnet](https://googleapis.github.io/google-cloud-dotnet/) libraries which authenticate
using the default service account on the machine. This is automatic on GCE VMs or you can use the [gcloud](https://cloud.google.com/sdk/) SDK
to authenticate yourself. The service account must have the [Logs Writer](https://cloud.google.com/logging/docs/access-control) permission to send logs.

When using default options, logs will appear under these filter settings in the GCP Console.

## Target Options

* **ProjectId** - Google Cloud project ID where logs will be sent to. Can be omitted if executing on on [Google App Engine (GAE)](https://cloud.google.com/appengine/) or [Google Compute Engine (GCE)](https://cloud.google.com/compute/)
* **ResourceType** - Resource type for logs (Default = "global"). Must be one of the supported types listed in the [cloud logging documentation](https://cloud.google.com/logging/docs/api/v2/resource-list).
* **LogId** - Name of log under the resource type (Default = "Default")
* **DisableResourceTypeDetection** - Defaults to false. Setting this to true disables automatic resourceType setting based on platform detection.
* **ResourceLabel** - If resourceType has been manually set, then resourceLabel is used to specify extra labels as shown in the [Monitoring Resource Types](https://cloud.google.com/logging/docs/api/v2/resource-list) list.
* **ContextProperty** - Allows custom labels to be added to the log entries as extra metadata.
* **CredentialFile** - Credentials using a JSON file, instead of using the default credentials (GOOGLE_APPLICATION_CREDENTIALS)
* **CredentialJson** - Credentials using raw JSON input, instead of using the default credentials (GOOGLE_APPLICATION_CREDENTIALS)
* **IncludeCallSite** - Include LogEntrySourceLocation extracted from NLog callsite (Only include function name)
* **IncludeCallSiteStackTrace** - Include LogEntrySourceLocation extracted from NLog callsite (Also include filename and linenumber)
* **IncludeEventProperties** - Includes structured logging properties from NLog LogEventInfo.Properties
* **IncludeMdlc** - Include async thread context properties from NLog MappedDiagnosticsLogicalContext
* **SendJsonPayload** - Instead of sending properties as custom labels, then they are sent as Json-Properties in JsonPayload (without TextPayload)
* **ServiceContextName** - Configures the "service" in "serviceContext" when SendJsonPayload = true (Default = AppDomain FriendlyName)
* **ServiceContextVersion** - Configures the "version" in "serviceContext" when SendJsonPayload = true (Default = Entry Assembly FileVersion)

```xml
<extensions>
	<add assembly="Google.Cloud.Logging.NLog" />
</extensions>
<targets>
  <target type="GoogleStackdriver"
          name="String"
          projectId="your project ID"
          logId="your log ID"
          layout="Layout">
    <resourcelabel name="String" layout="Layout" /><!-- repeated -->
    <contextproperty name="String" layout="Layout" /><!-- repeated -->
  </target>
</targets>
```
