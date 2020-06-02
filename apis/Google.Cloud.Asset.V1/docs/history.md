# Version history

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
