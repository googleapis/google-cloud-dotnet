# Version history

## Version 2.13.0, released 2024-11-18

### New features

- A new field `feature_online_store_spec` is added to message `.google.cloud.datacatalog.v1.Entry` ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A new value `GENIE` is added to enum `ModelSourceType` ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A new value `CUSTOM_TEXT_EMBEDDING` is added to enum `ModelSourceType` ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A new value `MARKETPLACE` is added to enum `ModelSourceType` ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A new message `FeatureOnlineStoreSpec` is added ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A new value `FEATURE_ONLINE_STORE` is added to enum `EntryType` ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A new value `FEATURE_VIEW` is added to enum `EntryType` ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A new value `FEATURE_GROUP` is added to enum `EntryType` ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A new enum `DataplexTransferStatus` is added ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A new field `dataplex_transfer_status` is added to message `.google.cloud.datacatalog.v1.TagTemplate` ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))

### Documentation improvements

- A comment for field `name` in message `.google.cloud.datacatalog.v1.Entry` is changed ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A comment for field `name` in message `.google.cloud.datacatalog.v1.EntryGroup` is changed ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A comment for field `name` in message `.google.cloud.datacatalog.v1.Tag` is changed ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A comment for field `name` in message `.google.cloud.datacatalog.v1.TagTemplate` is changed ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))
- A comment for field `name` in message `.google.cloud.datacatalog.v1.TagTemplateField` is changed ([commit 7df11e5](https://github.com/googleapis/google-cloud-dotnet/commit/7df11e5255541ed1d824b768452ce634cac5b81f))

## Version 2.12.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.11.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.10.0, released 2024-03-21

### New features

- Add RANGE type to Data Catalog ([commit e436bee](https://github.com/googleapis/google-cloud-dotnet/commit/e436bee75f303e206ee364c63aa7ef85c51ad50a))

## Version 2.9.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.8.0, released 2024-01-16

### Bug fixes

- Change field behavior of the property "name" to IDENTIFIER ([commit 093f27c](https://github.com/googleapis/google-cloud-dotnet/commit/093f27c1285516f85ebb81be4c10753deefd42d4))

## Version 2.7.0, released 2023-10-02

### New features

- Enable Vertex AI Ingestion on DataPlex ([commit af6cde6](https://github.com/googleapis/google-cloud-dotnet/commit/af6cde6b66d1a9054bc2353cd9a01105de6f36ee))

### Documentation improvements

- Fix typo ([commit 3924eff](https://github.com/googleapis/google-cloud-dotnet/commit/3924eff8ce3cd348873825d667b537da884c8f4a))

## Version 2.6.0, released 2023-08-04

### New features

- Add support for admin_search in SearchCatalog() API method ([commit 725097f](https://github.com/googleapis/google-cloud-dotnet/commit/725097f63070b90a2af5cf8947e2666b91782110))

## Version 2.5.0, released 2023-07-13

### New features

- Added rpc RenameTagTemplateFieldEnumValue ([commit 3840102](https://github.com/googleapis/google-cloud-dotnet/commit/3840102cdac33930dee4c73ab098b5c5d09839bc))
- Returning approximate total size for SearchCatalog ([commit 3840102](https://github.com/googleapis/google-cloud-dotnet/commit/3840102cdac33930dee4c73ab098b5c5d09839bc))
- Returning unreachable locations for SearchCatalog ([commit 3840102](https://github.com/googleapis/google-cloud-dotnet/commit/3840102cdac33930dee4c73ab098b5c5d09839bc))
- Added Entry.usage_signal ([commit 3840102](https://github.com/googleapis/google-cloud-dotnet/commit/3840102cdac33930dee4c73ab098b5c5d09839bc))

### Documentation improvements

- Update docs of SearchCatalogRequest message ([commit 3840102](https://github.com/googleapis/google-cloud-dotnet/commit/3840102cdac33930dee4c73ab098b5c5d09839bc))

## Version 2.4.0, released 2023-06-05

### New features

- Add support for entries associated with Spanner and ClougBigTable ([commit 065b49c](https://github.com/googleapis/google-cloud-dotnet/commit/065b49c46d85cf2a0bbb517f32274669d7eac4d0))
- Expand SearchCatalogResponse with totalSize ([commit 065b49c](https://github.com/googleapis/google-cloud-dotnet/commit/065b49c46d85cf2a0bbb517f32274669d7eac4d0))
- Modify documentation for FQN support ([commit 065b49c](https://github.com/googleapis/google-cloud-dotnet/commit/065b49c46d85cf2a0bbb517f32274669d7eac4d0))
- Extend ImportApiRequest with jobId parameter ([commit 065b49c](https://github.com/googleapis/google-cloud-dotnet/commit/065b49c46d85cf2a0bbb517f32274669d7eac4d0))

## Version 2.3.0, released 2023-03-20

### New features

- Add support for new ImportEntries() API, including format of the dump ([commit 2628c55](https://github.com/googleapis/google-cloud-dotnet/commit/2628c5527cfedb6b775e3858a1ce38aad7920d72))
- Add support for entries associated with Looker and CloudSQL ([commit 2628c55](https://github.com/googleapis/google-cloud-dotnet/commit/2628c5527cfedb6b775e3858a1ce38aad7920d72))
- Add support for a ReconcileTags() API method ([commit 2628c55](https://github.com/googleapis/google-cloud-dotnet/commit/2628c5527cfedb6b775e3858a1ce38aad7920d72))

## Version 2.2.0, released 2023-01-16

### New features

- Enable REST transport in C# ([commit a6c4606](https://github.com/googleapis/google-cloud-dotnet/commit/a6c46063bd961a9dadc728a780d66de772f28e71))

### Documentation improvements

- Documentation updates ([commit 14ebfe2](https://github.com/googleapis/google-cloud-dotnet/commit/14ebfe2436b9885370d7347e381c750150ed4db3))

## Version 2.1.0, released 2022-08-02

### Bug fixes

- **BREAKING CHANGE** Fix datacatalog resource name config ([commit 0c58375](https://github.com/googleapis/google-cloud-dotnet/commit/0c58375c78330939465587655212289d608ef3ea))

This breaking change affects the `CreateTag` and `ListEntryGroups`
operations. In both cases, the resource name type being used was
inappropriate, and would have led to invalid requests. As these
methods could not have been used successfully in their current form,
we're releasing this bug fix as a minor version bump instead of a
major one.

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


## Version 1.8.0, released 2022-04-26

### New features

- Added Dataplex specific fields ([commit f445d27](https://github.com/googleapis/google-cloud-dotnet/commit/f445d27d4a4171c8149ed4d930594ffae8b427c4))

### Documentation improvements

- Update taxonomy display_name comment ([commit f445d27](https://github.com/googleapis/google-cloud-dotnet/commit/f445d27d4a4171c8149ed4d930594ffae8b427c4))

## Version 1.7.0, released 2022-02-14

### New features

- Add methods and messages related to starring feature ([commit 14939ee](https://github.com/googleapis/google-cloud-dotnet/commit/14939ee37813ffdb51f6cd77acefa884960e0f05))
- Add methods and messages related to business context feature ([commit 14939ee](https://github.com/googleapis/google-cloud-dotnet/commit/14939ee37813ffdb51f6cd77acefa884960e0f05))

### Documentation improvements

- Updates copyright message ([commit 14939ee](https://github.com/googleapis/google-cloud-dotnet/commit/14939ee37813ffdb51f6cd77acefa884960e0f05))

## Version 1.6.0, released 2021-11-10

- [Commit ceba2bb](https://github.com/googleapis/google-cloud-dotnet/commit/ceba2bb): docs: Improved formatting
- [Commit 355a879](https://github.com/googleapis/google-cloud-dotnet/commit/355a879):
  - feat: Added BigQueryDateShardedSpec.latest_shard_resource field
  - feat: Added SearchCatalogResult.display_name field
  - feat: Added SearchCatalogResult.description field

## Version 1.5.0, released 2021-09-24

- [Commit 4d51dc2](https://github.com/googleapis/google-cloud-dotnet/commit/4d51dc2): build: change links to make them absolute

## Version 1.4.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.3.0, released 2021-08-10

- [Commit 2fc3992](https://github.com/googleapis/google-cloud-dotnet/commit/2fc3992):
  - feat: Added support for BigQuery connections entries
  - feat: Added support for BigQuery routines entries
  - feat: Added usage_signal field
  - feat: Added labels field
  - feat: Added ReplaceTaxonomy in Policy Tag Manager Serialization API
  - feat: Added support for public tag templates
  - feat: Added support for rich text tags
  - docs: Documentation improvements

## Version 1.2.0, released 2021-05-05

- [Commit 29c9961](https://github.com/googleapis/google-cloud-dotnet/commit/29c9961): docs: reformat comments in PolicyTagManager definition
- [Commit afadcef](https://github.com/googleapis/google-cloud-dotnet/commit/afadcef):
  - feat: Policy Tag Manager v1 API service
  - feat: new RenameTagTemplateFieldEnumValue API
  - feat: adding fully_qualified_name in lookup and search
  - feat: added DATAPROC_METASTORE integrated system along with new entry types: DATABASE and SERVICE
  - docs: Documentation improvements

## Version 1.1.0, released 2020-10-14

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit c189d65](https://github.com/googleapis/google-cloud-dotnet/commit/c189d65): docs: change relative URLs to absolute URLs to fix broken links.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit f4abc66](https://github.com/googleapis/google-cloud-dotnet/commit/f4abc66): feat: Add IAM method signatures ([issue 4953](https://github.com/googleapis/google-cloud-dotnet/issues/4953))
- [Commit 8271758](https://github.com/googleapis/google-cloud-dotnet/commit/8271758): docs: fixes to comments. ([issue 4865](https://github.com/googleapis/google-cloud-dotnet/issues/4865))
- [Commit 615c494](https://github.com/googleapis/google-cloud-dotnet/commit/615c494):
  - docs: fixed documentation links. ([issue 4858](https://github.com/googleapis/google-cloud-dotnet/issues/4858))
  - feat: search catalog support for restricted locations, and reporting unreachable locations

## Version 1.0.0, released 2020-04-08

No API surface changes since 1.0.0-beta01.

## Version 1.0.0-beta01, released 2020-03-27

Initial beta release.


