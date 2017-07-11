{{title}}

{{description}}

{{installation}}

{{auth}}

# Getting started

All operations are performed through
[LanguageServiceClient](obj/api/Google.Cloud.Language.V1.LanguageServiceClient.yml).

All the methods on the client require a
[Document](obj/api/Google.Cloud.Language.V1.Document.yml) to
analyze. The Document class provides convenient factory methods
[Document.FromPlainText](obj/api/Google.Cloud.Language.V1.Document.yml#Google_Cloud_Language_V1_Document_FromPlainText_System_String_System_String_)
and [Document.FromHtml](obj/api/Google.Cloud.Language.V1.Document.yml#Google_Cloud_Language_V1_Document_FromHtml_System_String_System_String_)
to construct instances from text available in your application, or
you can specify a Google Cloud Storage URI.

# Sample code

## Analyze sentiment in a document

[!code-cs[](obj/snippets/Google.Cloud.Language.V1.LanguageServiceClient.txt#AnalyzeSentiment)]

## Analyze entities in a document

[!code-cs[](obj/snippets/Google.Cloud.Language.V1.LanguageServiceClient.txt#AnalyzeEntities)]

## Analyze syntax in a document

[!code-cs[](obj/snippets/Google.Cloud.Language.V1.LanguageServiceClient.txt#AnalyzeSyntax)]

## Multiple operations: analyze syntax and entities

[!code-cs[](obj/snippets/Google.Cloud.Language.V1.LanguageServiceClient.txt#AnnotateText)]
