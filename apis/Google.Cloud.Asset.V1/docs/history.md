# Version history

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
