# Google Cloud Logging Log4Net appender

## Example use in a console app

Create an appender with the following XML configuration:
``` xml
<?xml version="1.0" encoding="utf-8" ?>
<log4net>
  <appender name="CloudLogger" type="Google.Cloud.Logging.Log4Net.GoogleStackdriverAppender,Google.Cloud.Logging.Log4Net">
    <layout type="log4net.Layout.PatternLayout">
      <conversionPattern value="%-4timestamp [%thread] %-5level %logger %ndc - %message" />
    </layout>
    <projectId value="<your project ID>" />
    <logId value="<your log ID>" />
  </appender>
  <root>
    <level value="ALL" />
    <appender-ref ref="CloudLogger" />
  </root>
</log4net>
```
Save this as `log4net.xml` in your application directory.
Then load it during program startup:
``` csharp
using log4net;
using log4net.Config;

public static void Main(string[] args)
{
    XmlConfigurator.Configure("new FileInfo("log4net.xml"));
}
```
Logged items will now be sent to Google Cloud Logging:
``` csharp
using log4net;

ILog log = LogManager.GetLogger(typeof(Program));
log.Info("An exciting log entry!");
```

## Custom configuration

Within a `GoogleStackdriverAppender` the following options are available (also see [GoogleStackdriverAppender_Configuration.cs](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/blob/master/apis/Google.Cloud.Logging.V2/Google.Cloud.Logging.Log4Net/GoogleStackdriverAppender_Configuration.cs)):

### projectId

``` xml
<projectId value="<your project ID>"/>
```
Optional when running on Google App Engine (GAE) or Google Compute Engine (GCE), must be present on other platforms. The project ID given must be the ID of a project that already exists on [Google Cloud Platform](https://cloud.google.com/).

On GCE and GAE the project ID will be auto-detected from the platform.

### logId

``` xml
<logId value="<your log ID>"/>
```
Must be present. The log ID given is any string that is recorded as the name of the log, which can be used for simple filtering when viewing log entries.

### withMetaData

``` xml
<withMetaData value="<various, see below>"/>
```
By default no extra metadata is logged. `withMetaData` specifies which extra metadata to log with each log entry, and can be specified multiple times to enable multiple type of metadata:

 * `Location`: The class name, file name, and line number of the log call.
 * `Identity`: The identity of the current thread principle.
 * `ThreadName`: The name of the thread that performed the log call.
 * `UserName`: The name of the current user.
 * `Domain`: The AppDomain friendly name.
 * `LoggerName`: The name of the log4net logger that created this log entry.
 * `Label`: The name of the log4net logging level that caused this log entry (e.g. "FATAL")

### customLabel

``` xml
<customLabel>
  <key value="<your key>" />
  <value value="<your value>" />
</customLabel>
```
Allows custom labels to be added to the metadata of log entries.

### resourceType

``` xml
<resourceType value="<your resource type>"/>
```
Allows the [Monitored resources](https://cloud.google.com/logging/docs/reference/v2/rest/v2/MonitoredResource) resource type to be specified; must be set to an entry on the [Monitored Resource List](https://cloud.google.com/logging/docs/api/v2/resource-list).

If unset, the default value depends on the detected platform:

* `gae_app` on Google App Engine (GAE).
* `gce_instance` on Google Compute Engine (GCE).
* `global` on all other platforms.

(See [MonitoredResourceBuilder.cs](https://github.com/googleapis/gax-dotnet/blob/master/src/Google.Api.Gax.Grpc/MonitoredResourceBuilder.cs) for details)

### resourceLabel

``` xml
<resourceLabel>
  <key value="<key>" />
  <value value="<value>" />
</resourceLabel>
```
If `resourceType` has been manually set, then `resourceLabel` is used to specify extra labels as shown in the [Monitoring Resource Types](https://cloud.google.com/logging/docs/api/v2/resource-list#resource-types) list.

### DisableResourceTypeDetection

``` xml
<disableResourceTypeDetection value="true">
```
Defaults to `false`. Setting this to `true` disables automatic `resourceType` setting based on platform detection.

### Complete configuration example

So, for example, a complete configuration might look like this:
``` xml
<?xml version="1.0" encoding="utf-8" ?>
<log4net>
  <appender name="CloudLogger" type="Google.Cloud.Logging.Log4Net.GoogleStackdriverAppender,Google.Cloud.Logging.Log4Net">
    <layout type="log4net.Layout.PatternLayout">
      <conversionPattern value="%-4timestamp [%thread] %-5level %logger %ndc - %message" />
    </layout>
    <projectId value="myProject" />
    <logId value="myLog" />
    <withMetaData value="Location" />
    <withMetaData value="ThreadName" />
  </appender>
</log4net>
```

## Local queuing configuration

All log entries are queued locally before being sent to Google Cloud Logging.
Only in-memory queuing is currently supported. Persistent on-disk queuing is not currently implemented.

The following in-memory options are available:

``` xml
<MaxMemorySize value="<maximum number of bytes to queue>"/>
```
Restricts the amount of memory used for local queuing. If memory is exceeded then the 
oldest log entries will be discarded. A best-effort attempt will be made to log a warning
to Google Cloud Logging that some log messages have been discarded.
A value of 0 means there is no byte limit.

``` xml
<MaxMemoryCount value="<maximum count of log messages to queue"/>
```
The maximum count of log messages that be ever be concurrently locally queued. If this
maximum count is exceeded then the oldest log entries will be discarded. A best-effort
attempt will be made to log a warning to Google Cloud Logging that some log messages
have been discarded.
A value of 0 means there is no count limit.

If MaxMemorySize and MaxMemoryCount are both specified, then messages will be discarded
when the first limit is reached.

The default setting is to limit count to 1,000; with no limit on bytes.

## Feedback...
Please file github issues for bugs or questions.