# Requested enhancements backlog

This file is used to keep track of feature requests that we *may*
want to come back to at some point, but aren't on our immediate
radar. Using this single document is simpler than keeping all the
corresponding issues open, but we'll reopen the issue if we revisit
the request and want to put work into it.


## Write correlation-id with log entry metadata

- Issue: [#1038](https://github.com/googleapis/google-cloud-dotnet/issues/1038)
- Status: Further investigation and more details required.

## Make ValueSerializer public (Firestore)

- Issue: [#1818](https://github.com/googleapis/google-cloud-dotnet/issues/1709)
- Status: For consideration when everything is very stable. Making
  something part of the public API is a big decision.

## Static code analysis

- Issue: [#1709](https://github.com/googleapis/google-cloud-dotnet/issues/1709)
- Status: Further investigation required. We already have
  some analysis in the form of custom Roslyn analyzers.
  
## Storage client-side encryption

- Issue: [#1451](https://github.com/googleapis/google-cloud-dotnet/issues/1451)
- Status: More details required.
  
## Provide F# samples

- Issue: [#682](https://github.com/googleapis/google-cloud-dotnet/issues/682)
- Status: "Nice to have" but significant investment in terms of
  infrastructure/planning.

## Detect dev/non-dev environment in diagnostic libraries

- Issue: [#829](https://github.com/googleapis/google-cloud-dotnet/issues/829)
- Status: More consideration and customer feedback required.

## Dispose of ErrorReportingExceptionFilter

- Issue: [#803](https://github.com/googleapis/google-cloud-dotnet/issues/803)
- Status: Resources are alive as long as the application is anyway.

## Allow BigQuery Struct parameters to be specified

- Issue: [#500](https://github.com/googleapis/google-cloud-dotnet/issues/500)
- Status: No customer requests for this yet; can implement when
  reqiured.

## Improve handling of Markdown from protos

- Issue: [#110](https://github.com/googleapis/google-cloud-dotnet/issues/110)
- Status: Ideally, protoc should do this. Massive work item, no
  funding right now.

## Better handling of compressed Storage objects when compression is disabled

- Issue: [#1784](https://github.com/googleapis/google-cloud-dotnet/issues/1784)
- Status: Both proposed options need server changes in some form or other.

## Log exceptions thrown in TimedBuffer

- Issue: [#2182](https://github.com/googleapis/google-cloud-dotnet/issues/2182)
- Status: We don't have a good solution for where to log these. Won't affect clients directly.

## Create an unmanaged tracer in Google.Cloud.Diagnostic.Common

- Issue: [#2166](https://github.com/googleapis/google-cloud-dotnet/issues/2166)
- Status: We haven't received intereset for this feature.

## Expose Tracing, Error Reporting and Logging common parts in a consumable way.

- Issue: [#2164](https://github.com/googleapis/google-cloud-dotnet/issues/2164)
- Status: This might not be a good idea, especially with OpenCensus integration coming up.

## Including information stored in System.Exception.Data in the Stackdriver Error Reporting entry.

- Issue: [#2738](https://github.com/googleapis/google-cloud-dotnet/issues/2738)
- Status: The original requester never confirmed whether our approach solved their use case or not.

# Firestore: Expose sufficient state to manually restart a Listen operation

- Issue: [#2513](https://github.com/googleapis/google-cloud-dotnet/issues/2513)
- Status: Waiting for more user to request this, so we can gather suitable requirements.
