# Version history

# Version 2.0.0, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

# Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

Additional breaking changes not covered in the guide:

- Legacy methods accepting nullable EncodingType parameters have been removed

# Version 1.4.0, released 2019-12-09

- [Commit 699db57](https://github.com/googleapis/google-cloud-dotnet/commit/699db57): Some retry settings are now obsolete, and will be removed in the next major version
- Methods accepting `Nullable<EncodingType>` parameters are now obsolete, and will be removed in the next major version.
  (Equivalent methods with non-nullable parameters have been added.)

# Version 1.3.0, released 2019-07-10

- More entity `Type` enum values
- Added more sentiment analysis method overloads

# Version 1.2.0, released 2019-02-05

- Added async methods that accept requests (as well as the other signatures)

# Version 1.1.0, released 2017-11-14

- New feature: text classification

# Version 1.0.0, released 2017-09-19

Initial GA release.
