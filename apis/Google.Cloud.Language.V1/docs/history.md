# Version history

# Version 2.3.0, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

# Version 2.2.0, released 2021-05-26

No API surface changes; just dependency updates.

# Version 2.1.0, released 2020-10-20

- [Commit fab7d7e](https://github.com/googleapis/google-cloud-dotnet/commit/fab7d7e): docs: Fix proto comments for language API inorder for docs parsing to work correctly. ([issue 5415](https://github.com/googleapis/google-cloud-dotnet/issues/5415))
- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 7a0a214](https://github.com/googleapis/google-cloud-dotnet/commit/7a0a214): docs: change relative URLs to absolute URLs to fix broken links.

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
