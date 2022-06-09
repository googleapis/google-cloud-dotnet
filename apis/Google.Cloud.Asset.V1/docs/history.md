# Version history

## Version 3.0.0, released 2022-06-09

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


## Version 2.11.0, released 2022-05-24

### New features

- Add SavedQuery CURD support ([commit 75e403c](https://github.com/googleapis/google-cloud-dotnet/commit/75e403caf6aa0a79b33d4e308d0dbfa97fa80a7d))
- Add tags support ([commit 75e403c](https://github.com/googleapis/google-cloud-dotnet/commit/75e403caf6aa0a79b33d4e308d0dbfa97fa80a7d))
- Add RelatedAsset and deprecate RelatedAssets for relationship GA ([commit 75e403c](https://github.com/googleapis/google-cloud-dotnet/commit/75e403caf6aa0a79b33d4e308d0dbfa97fa80a7d))
  - The previous representation of the relationship feature is deprecated and unimplemented. The RelatedAsset message represents the new stable format.
## Version 2.10.0, released 2021-09-23

- [Commit b71303f](https://github.com/googleapis/google-cloud-dotnet/commit/b71303f): feat: Release of relationships in v1, Add content type Relationship to support relationship search
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.9.0, released 2021-08-10

- [Commit ba29ee0](https://github.com/googleapis/google-cloud-dotnet/commit/ba29ee0):
  - feat!: Change metadata field for the AnalyzeIamPolicyLongrunning.
  - feat: Add AnalyzeMove API.
  - feat: Add read_mask field for SearchAllResourcesRequest
  - feat: Add VersionedResource/AttachedResource fields for ResourceSearchResult.
- [Commit bf524b6](https://github.com/googleapis/google-cloud-dotnet/commit/bf524b6): feat: add new searchable fields (memberTypes, roles, project, folders and organization), new request fields (assetTypes and orderBy) and new response fields (assetType, folders and organization) in SearchAllIamPolicies

The metadata field change for AnalyzeIamPolicyLongrunning is
BACKWARD INCOMPATIBLE. Adding this change expands our ability to
return richer metadata information for the longrunning operation.
Due to the small usage of this API, we've contacted all the
customers to make sure they are not using the metadata field and
hence won't be broken by this change.

## Version 2.8.0, released 2021-05-27

- [Commit 2722d51](https://github.com/googleapis/google-cloud-dotnet/commit/2722d51):
  - feat: add Cloud Asset List API
  - feat: add access time as condition context in request and evaluation value in response for Cloud Asset AnalyzeIamPolicy API
  - feat: add more info in response for Cloud Asset SearchAllResources API

## Version 2.7.0, released 2021-04-29

- [Commit cb59fb9](https://github.com/googleapis/google-cloud-dotnet/commit/cb59fb9): chore: fix typo 'partion_key' in comments

Note: even though there are no API surface changes, this is a minor
version bump due to dependency changes

## Version 2.6.0, released 2020-11-17

- [Commit 3733849](https://github.com/googleapis/google-cloud-dotnet/commit/3733849): feat: added support OSInventory in Assets. docs: updated existing docs.
- [Commit c42363f](https://github.com/googleapis/google-cloud-dotnet/commit/c42363f): feat: add AnalyzeIamPolicy and AnalyzeIamPolicyLongrunning RPCs

## Version 2.5.0, released 2020-09-28

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): feat: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6eed2d8](https://github.com/googleapis/google-cloud-dotnet/commit/6eed2d8): feat: Added support for per type and partition export for Cloud Asset API

## Version 2.4.0, released 2020-09-15

- [Commit c9ca107](https://github.com/googleapis/google-cloud-dotnet/commit/c9ca107): Remove AnalyzeIamPolicy and ExportIamPolicyAnalysis RPCs

BREAKING CHANGE: The change here effectively reverts part of [commit 8ef5dc2](https://github.com/googleapis/google-cloud-dotnet/commit/8ef5dc2),
so removes part of the public API.

We have taken the decision to publish this as a minor version rather than going to version 3.0, as we don't expect customers to be affected by the nature of the breaking change:

- The affected version (2.3.0) has been delisted, and had only been installed by a small number of customers, as reported on NuGet
- This version *is* compatible with 2.2.0 and earlier versions
- The accidentally-included new APIs were not enabled server-side, so customers could not have started relying on the server implementation yet

We apologise for any confusion this causes.

## Version 2.3.0, released 2020-08-25 (then delisted 2020-09-14)

- [Commit 8ef5dc2](https://github.com/googleapis/google-cloud-dotnet/commit/8ef5dc2): feat: add AnalyzeIamPolicy and ExportIamPolicyAnalysis RPCs
- [Commit e7b75e6](https://github.com/googleapis/google-cloud-dotnet/commit/e7b75e6): feat: added support OutputResult in ExportAssetsResponse.
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): Adds service comments in client documentation
- [Commit 5b06141](https://github.com/googleapis/google-cloud-dotnet/commit/5b06141): fix: add missing RPCs to grpc_service_config
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): Enables RPCs without retries to still have timeouts specified.

## Version 2.2.0, released 2020-06-17

- [Commit 46ae081](https://github.com/googleapis/google-cloud-dotnet/commit/46ae081):
  - feat: added support for condition in Feed
  - docs: updated existing docs.
 
Clients can now specify conditions in Asset Feed. For details, see https://cloud.google.com/asset-inventory/docs/monitoring-asset-changes.

## Version 2.1.0, released 2020-06-02

- [Commit 89ca277](https://github.com/googleapis/google-cloud-dotnet/commit/89ca277): docs: Properly format literal strings.
- [Commit 372df03](https://github.com/googleapis/google-cloud-dotnet/commit/372df03): feat: add SearchAllResources and SearchAllIamPolicies RPCs ([issue 4974](https://github.com/googleapis/google-cloud-dotnet/issues/4974))
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-04-08

No API surface changes since 2.0.0-beta03.

## Version 2.0.0-beta03, released 2020-03-30

- [Commit 4a5abd3](https://github.com/googleapis/google-cloud-dotnet/commit/4a5abd3): Feature: support for AccessContextPolicy, AccessLevel, ServicePerimeter and OrgPolicy

This is the first release that depends on the
Google.Cloud.OrgPolicy.V1, Google.Identity.AccessContextManager.Type
and Google.Identity.AccessContextManager.V1 packages.

## Version 2.0.0-beta02, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

Additional breaking changes not covered in the guide:

- `BatchGetAssetsHistoryRequest` and `ExportAssetsRequest` now express the parent resource as `IResourceName` rather than `ProjectName`.

## Version 1.1.0, released 2019-12-09

- [Commit 4f2ccbe](https://github.com/googleapis/google-cloud-dotnet/commit/4f2ccbe): Real-time feed support
- [Commit f4e3eaf](https://github.com/googleapis/google-cloud-dotnet/commit/f4e3eaf):
  - BigQuery output support
  - Storage URI prefix support
  - Added ContentType.OrgPolicy and ContentType.AccessPolicy

## Version 1.0.0, released 2019-07-10

Initial release.
