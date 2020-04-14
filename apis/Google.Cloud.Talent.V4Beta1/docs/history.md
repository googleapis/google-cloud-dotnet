# Version history

# Version 2.0.0-beta03, released 2020-04-14

- [Commit 28bdca8](https://github.com/googleapis/google-cloud-dotnet/commit/28bdca8): Fix (breaking change): reorder Company and Job resources in talent API to be consistent with old gapic config.

Note that this breaking change was expected, and was performed to
improve the experience moving forward. (As part of a beta API,
periodic breaking changes are somewhat expected.)

# Version 2.0.0-beta02, released 2020-03-19

- [Commit aadcdb6](https://github.com/googleapis/google-cloud-dotnet/commit/aadcdb6): This removes the TenantOrProject resource, so is a breaking change. This "fake" resource predates the ability to refer to multiple parent resources.

The mitigation for the breaking change is typically just to replace
uses of `TenantOrProjectName` with `TenantName` or `ProjectName`.

# Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

(This API has changed significantly over time, and the history before this point is tricky to backfill.)

# Version 1.0.0-beta09, released 2019-12-10

# Version 1.0.0-beta08, released 2019-11-11

# Version 1.0.0-beta07, released 2019-09-17

# Version 1.0.0-beta06, released 2019-07-30

# Version 1.0.0-beta05, released 2019-06-05

# Version 1.0.0-beta04, released 2019-05-01

# Version 1.0.0-beta03, released 2019-04-03

# Version 1.0.0-beta02, released 2019-02-26

# Version 1.0.0-beta01, released 2019-02-20

Initial beta release.
