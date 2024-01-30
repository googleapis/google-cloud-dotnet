{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

{{client-classes}}

{{client-construction}}

### Creating a Document

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
library can be configured to use an API key instead of any other
credentials, by setting the `ApiKey` property in the client builder,
as shown below.

{{sample:LanguageServiceClient.ApiKey}}
