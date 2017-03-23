# Google.Cloud.Translation.V2

`Google.Cloud.Translation.V2` is a .NET client library for [Google
Cloud Translation](https://cloud.google.com/translate/). It wraps the
`Google.Apis.Translate.v2` generated library, providing a
higher-level API to make it easier to use.

# Installation

Install the `Google.Cloud.Translation.V2` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth application-default login
```

Alternatively, you can create a client using an API key. This is primarily
supported to enable smooth migration from earlier client libraries; using
OAuth2 as above is the preferred authentication mechanism.

# Getting started

Common operations are exposed via the
[TranslationClient](obj/api/Google.Cloud.Translation.V2.TranslationClient.yml) class.

# Sample code

## Translating a single item of text

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.TranslationClient.txt#TranslateText)]

## Translating a single item of HTML

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.TranslationClient.txt#TranslateHtml)]

## Translating multiple items of text

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.TranslationClient.txt#TranslateTextMultiple)]

## Translating multiple items of HTML

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.TranslationClient.txt#TranslateHtmlMultiple)]

## Using Neural Machine Translation

[Premium Edition](https://cloud.google.com/translate/docs/premium) customers may request
translations using the Neural Machine Translation model. This can either be set as the default model for a client:

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.TranslationClient.txt#TranslateTextNmtDefaultModel)]

... or it can be specified on a per-request basis:

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.TranslationClient.txt#TranslateTextNmtOverrideModel)]
