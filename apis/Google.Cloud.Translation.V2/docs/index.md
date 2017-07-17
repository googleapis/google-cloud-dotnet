{{title}}

{{description}}
It wraps the `Google.Apis.Translate.v2` generated library, providing a higher-level API to make it easier to use.

{{installation}}

{{auth}}

Alternatively, you can create a client using an API key. This is primarily
supported to enable smooth migration from earlier client libraries; using
OAuth2 as above is the preferred authentication mechanism.

# Getting started

Common operations are exposed via the
[TranslationClient](obj/api/Google.Cloud.Translation.V2.TranslationClient.yml) and 
[AdvancedTranslationClient](obj/api/Google.Cloud.Translation.V2.AdvancedTranslationClient.yml) classes.

# Sample code

## Translating a single item of text

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.TranslationClient.txt#TranslateText)]

## Translating a single item of HTML

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.TranslationClient.txt#TranslateHtml)]

## Translating multiple items of text

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.TranslationClient.txt#TranslateTextMultiple)]

## Translating multiple items of HTML

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.TranslationClient.txt#TranslateHtmlMultiple)]

## Specifying a translation model

The Translation API is implemented by multiple underlying models.
At the time of writing, one model is available in addition to "base": Neural Machine Translation (NMT).
If you don't explicitly specify a model to use, the service will pick one.

See the [API release notes](https://cloud.google.com/translate/release-notes) for on-going changes and new models.

Both client classes allow models to be specified, but in different ways. In each case, the model can be specified
when creating the client, or on a per-request basis. The difference is that `TranslationClient` uses the `TranslationModel`
enum, making it simple to specify commonly-used models, whereas `AdvancedTranslationClient` just uses strings for the models.

For example, using a `TranslationClient`-wide model:

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.TranslationClient.txt#TranslateTextBaseDefaultModel)]

`TranslationClient` specifying a model for a single operation:

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.TranslationClient.txt#TranslateTextBaseOverrideModel)]

Using an `AdvancedTranslationClient`-wide model:

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.AdvancedTranslationClient.txt#TranslateTextBaseDefaultModel)]

`AdvancedTranslationClient` specifying a model for a single operation:

[!code-cs[](obj/snippets/Google.Cloud.Translation.V2.AdvancedTranslationClient.txt#TranslateTextBaseOverrideModel)]
