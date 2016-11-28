# Google Cloud Logging Log4Net appender

## Example use in a console app

Create an appender with the following XML configuration:
``` xml
<?xml version="1.0" encoding="utf-8" ?>
<log4net>
  <appender name="CloudLogger" type="Google.Logging.Log4Net.GoogleStackdriverAppender,Google.Logging.Log4Net">
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
Then log away!
``` csharp
using log4net;

ILog log = LogManager.GetLogger(typeof(Program));
log.Info("An exciting log entry!");
```

## Custom configuration

Within an appender the following options are available:

``` xml
<projectId value="<your project ID>"/>
```
Must be present. The project ID given must be the ID of a project that already exists on [Google Cloud Platform](https://cloud.google.com/).

``` xml
<logId value="<your log ID>"/>
```
Must be present. The log ID given is any string that is recorded as the name of the log, which can be used for simple filtering.

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

``` xml
<customLabel>
  <key value="<your key>"/>
  <value value="<your value>"/>
</customLabel>
```
Allows custom labels to be added to the metadata of log entries.

``` xml
<resourceType value="<your resource type>"/>
```
Allows the [Monitored resources](https://cloud.google.com/logging/docs/api/ref_v2beta1/rest/v2beta1/MonitoredResource) resource type to be changed. This defaults to `global`.
*(TODO: If resource type isn't global then it's currently impossible to set any monitored-resource labels which will be required, so this setting is essentially useless at the moment)*

So, for example, a complete configuration might look like this:
``` xml
<?xml version="1.0" encoding="utf-8" ?>
<log4net>
  <appender name="CloudLogger" type="Google.Logging.Log4Net.GoogleStackdriverAppender,Google.Logging.Log4Net">
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
...is appreciated - please let me know what doesn't work, or what else would be useful :)
