{{title}}

{{description}}
It wraps the `Google.Apis.Translate.v2` generated library, providing a higher-level API to make it easier to use.

{{version}}

{{installation}}

{{auth}}

Alternatively, you can create a client using an API key. This is primarily
supported to enable smooth migration from earlier client libraries; using
OAuth2 as above is the preferred authentication mechanism.

## Getting started

Common operations are exposed via the
[TranslationClient](obj/api/Google.Cloud.Translation.V2.TranslationClient.yml) and 
[AdvancedTranslationClient](obj/api/Google.Cloud.Translation.V2.AdvancedTranslationClient.yml) classes.

## Client life-cycle management

In many cases you don't need to worry about disposing of
`TranslationClient` and `AdvancedTranslationClient` objects, and can create them reasonably freely -
but be aware that this *can* causes issues with memory and network
connection usage. We advise you to reuse a single client object if
possible; if your architecture requires you to frequently create new
client objects, please dispose of them to help with timely resource
clean-up. See [the resource clean-up guide](https://cloud.google.com/dotnet/docs/reference/help/cleanup#rest-based-apis) for more
details.

## Sample code

## Translating a single item of text

{{sample:TranslationClient.TranslateText}}

## Translating a single item of HTML

{{sample:TranslationClient.TranslateHtml}}

## Translating multiple items of text

{{sample:TranslationClient.TranslateTextMultiple}}

## Translating multiple items of HTML

{{sample:TranslationClient.TranslateHtmlMultiple}}

## Specifying a translation model

The Translation API is implemented by multiple underlying models.
At the time of writing, one model is available in addition to "base": Neural Machine Translation (NMT).
If you don't explicitly specify a model to use, the service will pick one.

See the [API release notes](https://cloud.google.com/translate/release-notes) for on-going changes and new models.

Both client classes allow models to be specified, but in different ways. In each case, the model can be specified
when creating the client, or on a per-request basis. The difference is that `TranslationClient` uses the `TranslationModel`
enum, making it simple to specify commonly-used models, whereas `AdvancedTranslationClient` just uses strings for the models.

For example, using a `TranslationClient`-wide model:

{{sample:TranslationClient.TranslateTextBaseDefaultModel}}

`TranslationClient` specifying a model for a single operation:

{{sample:TranslationClient.TranslateTextBaseOverrideModel}}

Using an `AdvancedTranslationClient`-wide model:

{{sample:AdvancedTranslationClient.TranslateTextBaseDefaultModel}}

`AdvancedTranslationClient` specifying a model for a single operation:

{{sample:AdvancedTranslationClient.TranslateTextBaseOverrideModel}}
