{{title}}

{{description}}

# Important: features may change

As suggested by the name of this package, this contains experimental
features. The namespace of all the types in this package is the
same as the namespace of the types in the stable
`Google.Cloud.Language.V1` package; the expectation is that users
will only use this package if they wish to use experimental
features. You should *not* depend on both this package and the
non-experimental one.

Code which worked with the non-experimental package should be valid
for the experimental package. As new features become mature and the API
is stabled, the non-experimental package will gain those features...
but there may be changes to experimental features either between
versions of the experimental package or as the features move into
the non-experimental package.

This package will *always* be a prerelease package, to make this
potential API instability clear.

Note: the very existence of this package is also somewhat unstable.
We are still experimenting with the best way of giving early access
to new API features.

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

## Analyze entities and associated sentiment in a document

[!code-cs[](obj/snippets/Google.Cloud.Language.V1.LanguageServiceClient.txt#AnalyzeEntitySentiment)]

## Analyze syntax in a document

[!code-cs[](obj/snippets/Google.Cloud.Language.V1.LanguageServiceClient.txt#AnalyzeSyntax)]

## Multiple operations: analyze syntax and entities

[!code-cs[](obj/snippets/Google.Cloud.Language.V1.LanguageServiceClient.txt#AnnotateText)]
