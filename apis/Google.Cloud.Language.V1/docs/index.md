# Google.Cloud.Language.V1

`Google.Cloud.Language.V1` is a .NET client library for the [Google
Cloud Natural Language API](https://cloud.google.com/natural-language).

# Installation

Install the `Google.Cloud.Language.V1` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

# Authentication

When running on Google Cloud Platform, no action needs to be taken to authenticate.

Otherwise, the simplest way of authenticating your API calls is to
[download a service account JSON file](https://developers.google.com/identity/protocols/OAuth2ServiceAccount),
then set the `GOOGLE_APPLICATION_CREDENTIALS` environment variable to refer to it. The
credentials will automatically be used to authenticate.

Note that the default credentials obtained by running `gcloud auth login` from the Cloud SDK
are not suitable for use with this API. (They will work initially, but implicitly have a very
small request quota.)

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
