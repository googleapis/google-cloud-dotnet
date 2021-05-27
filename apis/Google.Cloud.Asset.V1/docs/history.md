# Version history

# Version 2.8.0, released 2021-05-27

- [Commit 2722d51](https://github.com/googleapis/google-cloud-dotnet/commit/2722d51):
  - feat: add Cloud Asset List API
  - feat: add access time as condition context in request and evaluation value in response for Cloud Asset AnalyzeIamPolicy API
  - feat: add more info in response for Cloud Asset SearchAllResources API

# Version 2.7.0, released 2021-04-29

- [Commit cb59fb9](https://github.com/googleapis/google-cloud-dotnet/commit/cb59fb9): chore: fix typo 'partion_key' in comments

Note: even though there are no API surface changes, this is a minor
version bump due to dependency changes

# Version 2.6.0, released 2020-11-17

- [Commit 3733849](https://github.com/googleapis/google-cloud-dotnet/commit/3733849): feat: added support OSInventory in Assets. docs: updated existing docs.
- [Commit c42363f](https://github.com/googleapis/google-cloud-dotnet/commit/c42363f): feat: add AnalyzeIamPolicy and AnalyzeIamPolicyLongrunning RPCs

# Version 2.5.0, released 2020-09-28

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): feat: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6eed2d8](https://github.com/googleapis/google-cloud-dotnet/commit/6eed2d8): feat: Added support for per type and partition export for Cloud Asset API

# Version 2.4.0, released 2020-09-15

- [Commit c9ca107](https://github.com/googleapis/google-cloud-dotnet/commit/c9ca107): Remove AnalyzeIamPolicy and ExportIamPolicyAnalysis RPCs

BREAKING CHANGE: The change here effectively reverts part of [commit 8ef5dc2](https://github.com/googleapis/google-cloud-dotnet/commit/8ef5dc2),
so removes part of the public API.

We have taken the decision to publish this as a minor version rather than going to version 3.0, as we don't expect customers to be affected by the nature of the breaking change:

- The affected version (2.3.0) has been delisted, and had only been installed by a small number of customers, as reported on NuGet
- This version *is* compatible with 2.2.0 and earlier versions
- The accidentally-included new APIs were not enabled server-side, so customers could not have started relying on the server implementation yet

We apologise for any confusion this causes.

# Version 2.3.0, released 2020-08-25 (then delisted 2020-09-14)

- [Commit 8ef5dc2](https://github.com/googleapis/google-cloud-dotnet/commit/8ef5dc2): feat: add AnalyzeIamPolicy and ExportIamPolicyAnalysis RPCs
- [Commit e7b75e6](https://github.com/googleapis/google-cloud-dotnet/commit/e7b75e6): feat: added support OutputResult in ExportAssetsResponse.
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): Adds service comments in client documentation
- [Commit 5b06141](https://github.com/googleapis/google-cloud-dotnet/commit/5b06141): fix: add missing RPCs to grpc_service_config
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): Enables RPCs without retries to still have timeouts specified.

# Version 2.2.0, released 2020-06-17

- [Commit 46ae081](https://github.com/googleapis/google-cloud-dotnet/commit/46ae081):
  - feat: added support for condition in Feed
  - docs: updated existing docs.
 
Clients can now specify conditions in Asset Feed. For details, see https://cloud.google.com/asset-inventory/docs/monitoring-asset-changes.

# Version 2.1.0, released 2020-06-02

- [Commit 89ca277](https://github.com/googleapis/google-cloud-dotnet/commit/89ca277): docs: Properly format literal strings.
- [Commit 372df03](https://github.com/googleapis/google-cloud-dotnet/commit/372df03): feat: add SearchAllResources and SearchAllIamPolicies RPCs ([issue 4974](https://github.com/googleapis/google-cloud-dotnet/issues/4974))
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

# Version 2.0.0, released 2020-04-08

No API surface changes since 2.0.0-beta03.

# Version 2.0.0-beta03, released 2020-03-30

- [Commit 4a5abd3](https://github.com/googleapis/google-cloud-dotnet/commit/4a5abd3): Feature: support for AccessContextPolicy, AccessLevel, ServicePerimeter and OrgPolicy

This is the first release that depends on the
Google.Cloud.OrgPolicy.V1, Google.Identity.AccessContextManager.Type
and Google.Identity.AccessContextManager.V1 packages.

# Version 2.0.0-beta02, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

# Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

Additional breaking changes not covered in the guide:

- `BatchGetAssetsHistoryRequest` and `ExportAssetsRequest` now express the parent resource as `IResourceName` rather than `ProjectName`.

# Version 1.1.0, released 2019-12-09

- [Commit 4f2ccbe](https://github.com/googleapis/google-cloud-dotnet/commit/4f2ccbe): Real-time feed support
- [Commit f4e3eaf](https://github.com/googleapis/google-cloud-dotnet/commit/f4e3eaf):
  - BigQuery output support
  - Storage URI prefix support
  - Added ContentType.OrgPolicy and ContentType.AccessPolicy

# Version 1.0.0, released 2019-07-10

Initial release.
