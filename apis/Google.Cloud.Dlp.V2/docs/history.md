# Version history

# Version 3.0.0, released 2020-06-01

- [Commit dee878e](https://github.com/googleapis/google-cloud-dotnet/commit/dee878e): Fix routing by including location resource names
- [Commit 363bfe4](https://github.com/googleapis/google-cloud-dotnet/commit/363bfe4):
  - feat: Release new file type enums and new MetadataLocation proto
  - chore: Rename InspectFindingName to FindingName (due to resource name changes)

Both of these changes are breaking, hence the major version bump.

# Version 2.0.0, released 2020-04-08

No API surface changes since 2.0.0-beta03.

# Version 2.0.0-beta03, released 2020-03-26

- [Commit 0490888](https://github.com/googleapis/google-cloud-dotnet/commit/0490888):
  - Feature: Adds fields to Finding
  - Feature: Support for hybrid jobs

# Version 2.0.0-beta02, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

# Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

# Version 1.1.0, released 2019-12-11

- [Commit 484e335](https://github.com/googleapis/google-cloud-dotnet/commit/484e335): Adds LocationId to multiple messages in preparation for regionalization
- [Commit 8dd3a37](https://github.com/googleapis/google-cloud-dotnet/commit/8dd3a37): Added "publish to Stackdriver" functionality.
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Added Format method to all resource name classes

# Version 1.0.0, released 2019-07-10

Initial GA release.
