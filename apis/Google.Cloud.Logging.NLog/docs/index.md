{{title}}

`Google.Cloud.Logging.NLog` is a .NET client library to integrate [Google Stackdriver
Logging](https://cloud.google.com/logging/) with [NLog](http://nlog-project.org/).

{{version}}

{{installation}}

{{auth}}

## Getting started

## Console app

Create an `nlog` configuration file (`nlog.xml`):

[!code-xml[](obj/snippets/Google.Cloud.Logging.NLog.GoogleStackdriverTarget.txt#nlog_template)]

Edit the file replacing `PROJECT_ID` with your Google Cloud Project
ID, and `LOG_ID` with an identifier for your application.

Use this file to configure `nlog` and then log as normal:

{{sample:GoogleStackdriverTarget.Overview}}

If executing on [Google App Engine (GAE)](https://cloud.google.com/appengine/),
[Google Kubernetes Engine (GKE)](https://cloud.google.com/kubernetes-engine/),
or [Google Compute Engine (GCE)](https://cloud.google.com/compute/),
then the `projectId="PROJECT_ID"` configuration setting can be omitted; it will be auto-detected from the platform at run-time.

## Configuration options

- `ProjectId` - Google Cloud project ID where logs will be sent to. Can be omitted if executing on on [Google App Engine (GAE)](https://cloud.google.com/appengine/) or [Google Compute Engine (GCE)](https://cloud.google.com/compute/)
- `LogId` - Name of log under the resource type (Default = "Default")
- `DisableResourceTypeDetection` - Defaults to false. Setting this to true disables automatic resource type detection based on platform detection.
- `ResourceType` - Resource type for logs. Must be one of the supported types listed in the [cloud logging documentation](https://cloud.google.com/logging/docs/api/v2/resource-list). This is not needed if resource type detection is successful. If resource type detection fails or is disabled, and this is not set, the resource type in log entries is set to "global".
- `ResourceLabel` - Used to specify extra labels as shown in the [Monitoring Resource Types](https://cloud.google.com/logging/docs/api/v2/resource-list) list.
- `ContextProperty` - Allows custom labels to be added to the log entries as extra metadata.
- `CredentialFile` - Credentials using a JSON file, instead of using the application default credentials
- `CredentialJson` - Credentials using raw JSON input, instead of using the application default credentials
- `IncludeCallSite` - Include `LogEntrySourceLocation` extracted from NLog callsite. (This only includes the function name.)
- `IncludeCallSiteStackTrace` - Include `LogEntrySourceLocation` extracted from NLog callsite. (This also includes file name and line number.)
- `IncludeEventProperties` - Includes structured logging properties from NLog `LogEventInfo.Properties`.
- `IncludeMdlc` - Include async thread context properties from NLog MappedDiagnosticsLogicalContext
- `SendJsonPayload` - Use the `jsonPayload` property in log entries instead of `textPayload`. When this is enabled, properties are set within the payload instead of as custom labels
- `ServiceContextName` - Configures the "service" in "serviceContext" when sending a JSON payload. (Defaults to the `AppDomain.FriendlyName` of the running code.)
- `ServiceContextVersion` - Configures the "version" in "serviceContext" when sending a JSON payload. (Defaults to the `FileVersion` of the entry assembly.)
- `EnableJsonLayout` - Uses NLog's native JSON layout to format JSON payloads, completely replacing the default layout.
- `JsonConverter` or `JsonConverterTypeName`/`JsonConverterMethodName` - Configures a custom conversion for individual values within a JSON payload.
- `TraceId` - The trace ID to associate to log entries. Ex: `06796866738c859f2f19b7cfb3214824`. See [Google Logging V2 LogEntry reference docs](https://cloud.google.com/logging/docs/reference/v2/rpc/google.logging.v2#google.logging.v2.LogEntry) for more information.
- `SpanId` - The span ID within the trace associated with the log entry. Trace API v2 uses a 16-character hexadecimal encoding of an 8-byte array, ex: `000000000000004a`.  See [Google Logging V2 LogEntry reference docs](https://cloud.google.com/logging/docs/reference/v2/rpc/google.logging.v2#google.logging.v2.LogEntry) for more information.
- `TraceSampled` - The sampling decision of the trace associated with the log entry.  See [Google Logging V2 LogEntry reference docs](https://cloud.google.com/logging/docs/reference/v2/rpc/google.logging.v2#google.logging.v2.LogEntry) for more information.

## Sending JsonPayload

Enabling `SendJsonPayload` will capture structured logging properties in JSON format (instead of saving them as resource labels).

[!code-xml[](obj/snippets/Google.Cloud.Logging.NLog.GoogleStackdriverTarget.txt#nlog_jsonPayload)]

## Custom JsonPayload

Enabling `EnableJsonLayout` will override the standard JSON format, and instead depend on the output from NLog JsonLayout. This will completely replace the JSON payload, but has a performance penalty because of additional parsing.

[!code-xml[](obj/snippets/Google.Cloud.Logging.NLog.GoogleStackdriverTarget.txt#nlog_jsonTemplate)]
