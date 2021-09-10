# Requested enhancements backlog

This file is used to keep track of feature requests that we *may*
want to come back to at some point, but aren't on our immediate
radar. Using this single document is simpler than keeping all the
corresponding issues open, but we'll reopen the issue if we revisit
the request and want to put work into it.


## Firestore: Make ValueSerializer public

- Issue: [#1818](https://github.com/googleapis/google-cloud-dotnet/issues/1709)
- Status: For consideration when everything is very stable. Making
  something part of the public API is a big decision.

## Static code analysis

- Issue: [#1709](https://github.com/googleapis/google-cloud-dotnet/issues/1709)
- Status: Further investigation required. We already have
  some analysis in the form of custom Roslyn analyzers.

## Provide F# samples

- Issue: [#682](https://github.com/googleapis/google-cloud-dotnet/issues/682)
- Status: "Nice to have" but significant investment in terms of
  infrastructure/planning.

## Diagnostics: Detect dev/non-dev environment

- Issue: [#829](https://github.com/googleapis/google-cloud-dotnet/issues/829)
- Status: More consideration and customer feedback required.

## BigQuery: Allow Struct parameters to be specified

- Issue: [#500](https://github.com/googleapis/google-cloud-dotnet/issues/500)
- Status: No customer requests for this yet; can implement when
  required.

## Storage: Better handling of compressed objects when compression is disabled

- Issue: [#1784](https://github.com/googleapis/google-cloud-dotnet/issues/1784)
- Issue: [#7154](https://github.com/googleapis/google-cloud-dotnet/issues/7154)
- Status: All possible options need server changes in some form or other.

## Diagnostics: Log exceptions thrown in TimedBuffer

- Issue: [#2182](https://github.com/googleapis/google-cloud-dotnet/issues/2182)
- Status: We don't have a good solution for where to log these. Won't affect clients directly.

## Diagnostics: Create an unmanaged tracer in Google.Cloud.Diagnostic.Common

- Issue: [#2166](https://github.com/googleapis/google-cloud-dotnet/issues/2166)
- Status: We haven't received interest for this feature.

## Diagnostics: Expose Tracing, Error Reporting and Logging common parts in a consumable way.

- Issue: [#2164](https://github.com/googleapis/google-cloud-dotnet/issues/2164)
- Status: This might not be a good idea, especially with OpenCensus integration coming up.

## Diagnostics: Including information stored in System.Exception.Data in the Stackdriver Error Reporting entry.

- Issue: [#2738](https://github.com/googleapis/google-cloud-dotnet/issues/2738)
- Status: The original requester never confirmed whether our approach solved their use case or not.

## Firestore: Expose sufficient state to manually restart a Listen operation

- Issue: [#2513](https://github.com/googleapis/google-cloud-dotnet/issues/2513)
- Status: Waiting for more users to request this, so we can gather suitable requirements.

## Diagnostics: Refactor buffering strategies so that they can be easily combined.

- Issue: [#2163](https://github.com/googleapis/google-cloud-dotnet/issues/2163)
- Status: Waiting for demand on this. To be reconsidered if we decide to merge the existing Diagnostics libraries into one

## Diagnostics: Make it easy to not use Stackdriver diagnostics in development

- Issue: [#3335](https://github.com/googleapis/google-cloud-dotnet/issues/3335)
- Status: Waiting for demand on this. We have some ideas, but little *customer* input.

## Diagnostics: Associate trace information to log entries even if the trace is not sampled.

- Issue: [#5384](https://github.com/googleapis/google-cloud-dotnet/issues/5384)
- Status: Semantic breaking change. To be considered for a major version if and when we plan for one.

## Log4Net: Provide an opt in mechanism to remove `(null)` valued labels, which come from unset properties.

- Issue: [#5325](https://github.com/googleapis/google-cloud-dotnet/issues/5325)
- Status: Waiting for more demand on this so we can have better requirements.

