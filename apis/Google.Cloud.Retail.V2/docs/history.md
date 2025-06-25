# Version history

## Version 2.14.0, released 2025-06-25

### New features

- Add a user_attributes field in SearchRequest that can be used for personalization
- Add a model_scores field in SearchResponse.results to expose model quality signals

## Version 2.13.0, released 2025-05-06

### New features

- add language_code, region_code and place_id to SearchRequest
- add pin_control_metadata to SearchResponse

### Documentation improvements

- keep the API doc up-to-date with recent changes

## Version 2.12.0, released 2024-10-14

### New features

- Add conversational search ([commit df83180](https://github.com/googleapis/google-cloud-dotnet/commit/df83180ce586294c17b53889a19c1257acfaf310))
- Add tile navigation ([commit df83180](https://github.com/googleapis/google-cloud-dotnet/commit/df83180ce586294c17b53889a19c1257acfaf310))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit df83180](https://github.com/googleapis/google-cloud-dotnet/commit/df83180ce586294c17b53889a19c1257acfaf310))

## Version 2.11.0, released 2024-06-10

### New features

- Support merged facets ([commit 6bce4f1](https://github.com/googleapis/google-cloud-dotnet/commit/6bce4f1fa34ff5213b37719114859bf802efc20f))
- Add product purge API ([commit 6bce4f1](https://github.com/googleapis/google-cloud-dotnet/commit/6bce4f1fa34ff5213b37719114859bf802efc20f))
- Add page_categories to control condition ([commit 6bce4f1](https://github.com/googleapis/google-cloud-dotnet/commit/6bce4f1fa34ff5213b37719114859bf802efc20f))
- Support attribute suggestion in autocomplete ([commit 6bce4f1](https://github.com/googleapis/google-cloud-dotnet/commit/6bce4f1fa34ff5213b37719114859bf802efc20f))
- Support frequent bought together model config ([commit 6bce4f1](https://github.com/googleapis/google-cloud-dotnet/commit/6bce4f1fa34ff5213b37719114859bf802efc20f))
- Allow to skip denylist postfiltering in recommendations ([commit 6bce4f1](https://github.com/googleapis/google-cloud-dotnet/commit/6bce4f1fa34ff5213b37719114859bf802efc20f))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit 6bce4f1](https://github.com/googleapis/google-cloud-dotnet/commit/6bce4f1fa34ff5213b37719114859bf802efc20f))

## Version 2.10.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.9.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.8.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.7.0, released 2024-03-13

No API surface changes; just dependency updates.

## Version 2.6.0, released 2024-02-09

### New features

- Add analytics service ([commit b0ce542](https://github.com/googleapis/google-cloud-dotnet/commit/b0ce542a6a76c172106f485baa007f2f514e5b04))

## Version 2.5.0, released 2023-04-12

### New features

- Add model service ([commit a54f6b9](https://github.com/googleapis/google-cloud-dotnet/commit/a54f6b9df485ca95e3ca210e613f8792e69f4014))
- Support per-entity search and autocomplete ([commit a54f6b9](https://github.com/googleapis/google-cloud-dotnet/commit/a54f6b9df485ca95e3ca210e613f8792e69f4014))
- Support new filter syntax for recommendation ([commit a54f6b9](https://github.com/googleapis/google-cloud-dotnet/commit/a54f6b9df485ca95e3ca210e613f8792e69f4014))
- Expose A/B experiment info in search response ([commit a54f6b9](https://github.com/googleapis/google-cloud-dotnet/commit/a54f6b9df485ca95e3ca210e613f8792e69f4014))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit a54f6b9](https://github.com/googleapis/google-cloud-dotnet/commit/a54f6b9df485ca95e3ca210e613f8792e69f4014))

## Version 2.4.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 31e55cd](https://github.com/googleapis/google-cloud-dotnet/commit/31e55cdbafe12bfae68e28a75a1b75ceb445684f))

## Version 2.3.0, released 2023-01-16

### New features

- Support async write mode for WriteUserEvent API ([commit 300746b](https://github.com/googleapis/google-cloud-dotnet/commit/300746b0cf87e9d1f2ad54836d1c6320c87de2c8))
- Support collect GA4 event format with prebuilt whistle rule ([commit 300746b](https://github.com/googleapis/google-cloud-dotnet/commit/300746b0cf87e9d1f2ad54836d1c6320c87de2c8))
- Support exact searchable and retrievable in catalog attribute config ([commit 300746b](https://github.com/googleapis/google-cloud-dotnet/commit/300746b0cf87e9d1f2ad54836d1c6320c87de2c8))
- Deprecate retrievable_fields in product attribute ([commit 300746b](https://github.com/googleapis/google-cloud-dotnet/commit/300746b0cf87e9d1f2ad54836d1c6320c87de2c8))
- Support diversity type in serving config ([commit 300746b](https://github.com/googleapis/google-cloud-dotnet/commit/300746b0cf87e9d1f2ad54836d1c6320c87de2c8))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit 300746b](https://github.com/googleapis/google-cloud-dotnet/commit/300746b0cf87e9d1f2ad54836d1c6320c87de2c8))

## Version 2.2.0, released 2022-08-26

### New features

- Release Control and ServingConfig serivces to v2 version ([commit 9b81234](https://github.com/googleapis/google-cloud-dotnet/commit/9b81234dbc18271c2bb690e2a35e9b09ffb9fb04))
- Release AttributesConfig APIs to v2 version ([commit 9b81234](https://github.com/googleapis/google-cloud-dotnet/commit/9b81234dbc18271c2bb690e2a35e9b09ffb9fb04))
- Release CompletionConfig APIs to v2 version ([commit 9b81234](https://github.com/googleapis/google-cloud-dotnet/commit/9b81234dbc18271c2bb690e2a35e9b09ffb9fb04))
- Add local inventories info to the Product resource ([commit 9b81234](https://github.com/googleapis/google-cloud-dotnet/commit/9b81234dbc18271c2bb690e2a35e9b09ffb9fb04))

### Documentation improvements

- Improved documentation for Fullfillment and Inventory API in ProductService ([commit 9b81234](https://github.com/googleapis/google-cloud-dotnet/commit/9b81234dbc18271c2bb690e2a35e9b09ffb9fb04))
- Minor documentation format and typo fixes ([commit 9b81234](https://github.com/googleapis/google-cloud-dotnet/commit/9b81234dbc18271c2bb690e2a35e9b09ffb9fb04))

## Version 2.1.0, released 2022-08-04

### New features

- Support case insensitive match on search facets ([commit 10c0429](https://github.com/googleapis/google-cloud-dotnet/commit/10c0429387e35ac500c1947dee81b3b25327e99c))
- Allow to return min/max values on search numeric facets ([commit 10c0429](https://github.com/googleapis/google-cloud-dotnet/commit/10c0429387e35ac500c1947dee81b3b25327e99c))
- Allow to use serving configs as an alias of placements ([commit 10c0429](https://github.com/googleapis/google-cloud-dotnet/commit/10c0429387e35ac500c1947dee81b3b25327e99c))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit 10c0429](https://github.com/googleapis/google-cloud-dotnet/commit/10c0429387e35ac500c1947dee81b3b25327e99c))

## Version 2.0.0, released 2022-06-08

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
documentation](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax4).
We don't anticipate any changes to most customer code, but please [file a
GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if you run into problems.

The most important change in this release is the use of the Grpc.Net.Client package
for gRPC communication, instead of Grpc.Core. When using .NET Core 3.1 or .NET 5.0+
this should lead to a smaller installation footprint and greater compatibility (e.g.
with Apple M1 chips). Any significant change in a core component comes with the risk
of incompatibility, however - so again, please let us know if you encounter any
issues.

### New features

- Allow users to disable spell check in search requests ([commit 5631878](https://github.com/googleapis/google-cloud-dotnet/commit/5631878839c3cf45e9075636e498ffa16f9463cf))
- Allow users to add labels in search requests ([commit 5631878](https://github.com/googleapis/google-cloud-dotnet/commit/5631878839c3cf45e9075636e498ffa16f9463cf))

### Documentation improvements

- Deprecate indexable/searchable on the product level custom attributes ([commit 5631878](https://github.com/googleapis/google-cloud-dotnet/commit/5631878839c3cf45e9075636e498ffa16f9463cf))
- Keep the API doc up-to-date with recent changes ([commit 5631878](https://github.com/googleapis/google-cloud-dotnet/commit/5631878839c3cf45e9075636e498ffa16f9463cf))

## Version 1.6.0, released 2022-04-04

### New features

- Add new AddLocalInventories and RemoveLocalInventories APIs ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Users cannot switch to empty default branch unless force override ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Allow search users to skip validation for invalid boost specs ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Support search personalization ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Search returns applied control ids in the response ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))

### Documentation improvements

- Users can self enroll retail search feature on cloud console ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Suggest search users not to send IP and use hashed user id ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Deprecate request_id in ImportProductsRequest ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Deprecate search dynamic_facet_spec and suggest to config on cloud console ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))
- Keep the API doc up-to-date with recent changes ([commit 0af0e7a](https://github.com/googleapis/google-cloud-dotnet/commit/0af0e7ab415cdb807645c0f30121011fb289352f))

## Version 1.5.0, released 2021-12-07

- [Commit 2925818](https://github.com/googleapis/google-cloud-dotnet/commit/2925818):
  - docs: Keep the API doc up-to-date
  - feat: update grpc service config settings to reflect correct API deadlines
- [Commit deb7506](https://github.com/googleapis/google-cloud-dotnet/commit/deb7506): docs: fix docstring formatting
## Version 1.4.0, released 2021-10-20

- [Commit 3c5e164](https://github.com/googleapis/google-cloud-dotnet/commit/3c5e164):
  - docs: Keep the API doc up-to-date
  - feat: add search mode to search request. If not specified, a single search request triggers both product search and faceted search.
  - feat: update grpc service config settings to reflect correct API deadlines

## Version 1.3.0, released 2021-09-23

- [Commit 672325d](https://github.com/googleapis/google-cloud-dotnet/commit/672325d):
  - docs: Keep the API doc up-to-date
  - feat: update grpc service config settings to reflect correct API deadlines
  - chore: remove relative private links from search service comments to prevent crashing client lib generation tool
- [Commit 51b50d0](https://github.com/googleapis/google-cloud-dotnet/commit/51b50d0): docs: Keep the API doc up-to-date
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.2.0, released 2021-08-10

- [Commit 130477c](https://github.com/googleapis/google-cloud-dotnet/commit/130477c): docs(retail): Quote several literal expressions for better rendering
- [Commit e5f12af](https://github.com/googleapis/google-cloud-dotnet/commit/e5f12af): docs: Remove HTML tags from Cloud Retail API library docs
- [Commit 30871b2](https://github.com/googleapis/google-cloud-dotnet/commit/30871b2): docs: remove remaining private links
- [Commit 360c029](https://github.com/googleapis/google-cloud-dotnet/commit/360c029): feat: Add restricted Retail Search features for Retail API v2.

## Version 1.1.0, released 2021-04-29

- [Commit 91fa8df](https://github.com/googleapis/google-cloud-dotnet/commit/91fa8df): docs: Put resource paths in code spans and use absolute URLs

Note: no API surface changes, but still a minor version bump due to dependency updates.

## Version 1.0.0, released 2021-01-20

No API changes since 1.0.0-beta01.

## Version 1.0.0-beta01, released 2020-12-15

Initial release, for customers in the early access programme.
