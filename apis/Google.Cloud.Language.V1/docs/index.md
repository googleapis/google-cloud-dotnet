{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

{{client-classes}}

{{client-construction}}

All the methods on the client require a
[Document](obj/api/Google.Cloud.Language.V1.Document.yml) to
analyze. The Document class provides convenient factory methods
[Document.FromPlainText](obj/api/Google.Cloud.Language.V1.Document.yml#Google_Cloud_Language_V1_Document_FromPlainText_System_String_System_String_)
and [Document.FromHtml](obj/api/Google.Cloud.Language.V1.Document.yml#Google_Cloud_Language_V1_Document_FromHtml_System_String_System_String_)
to construct instances from text available in your application, or
you can specify a Google Cloud Storage URI.

## Sample code

## Analyze sentiment in a document

{{sample:LanguageServiceClient.AnalyzeSentiment}}

## Analyze entities in a document

{{sample:LanguageServiceClient.AnalyzeEntities}}

## Analyze syntax in a document

{{sample:LanguageServiceClient.AnalyzeSyntax}}

## Multiple operations: analyze syntax and entities

{{sample:LanguageServiceClient.AnnotateText}}

## Using an API key

The Cloud Language API supports [API
keys](https://cloud.google.com/docs/authentication/api-keys) as an
alternative to regular authentication. The Google.Cloud.Language.V1
library can be configured to supply the API key in the
`X-Goog-Api-Key` header. Note that when specifying an API key, the
gRPC channel should use plain SSL without including any Cloud
authentication information, as demonstrated in the sample below.

{{sample:LanguageServiceClient.ApiKey}}
