# Version history

# Version 2.3.0, released 2019-12-10

- Methods accepting resource names now have equivalent string-accepting overloads
- Resource names have format methods
- Added LogMetric.CreateTime and UpdateTime properties
- New BigQueryOptions class
- Added LogSink.BigqueryOptions property
- Added LogEntry.TraceSampled and Metadata properties
- Added client builder for simplified configuration

# Version 2.2.0, released 2018-07-11

- Added method overloads accepting request objects
- Added WriteLogEntriesRequest.DryRun
- LogSink.StartTime/EndTime/OutputVersionFormat are now obsolete
- LogMetric.Version is now obsolete

# Version 2.1.0, released 2017-11-23

- Added methods and classes for exclusions
- Added LogMetric properties BucketOptions, MetricDescriptor, LabelExtractors, ValueExtractor
- Added an update mask to UpdateSink
- Added LogEntry.SpanId

# Version 2.0.0, released 2017-06-22

First GA release of 2.x with updated major dependency versions.

# Version 1.0.0, released 2017-03-30

Initial GA release.
