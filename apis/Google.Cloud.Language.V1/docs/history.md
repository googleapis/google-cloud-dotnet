# Version history

## Version 3.8.0, released 2025-11-05

### New features

- Update dependencies

## Version 3.7.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.6.0, released 2024-04-18

No API surface changes; just promotion to GA.

## Version 3.6.0-alpha01, released 2024-03-20

Experimental release targeting netstandard2.0 instead of netstandard2.1.

## Version 3.5.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 3.4.0, released 2024-01-30

### New features

- Support API keys directly in the Language library ([commit 33aad2c](https://github.com/googleapis/google-cloud-dotnet/commit/33aad2ce86593aedf4ee4073952227bb82d35d38))

## Version 3.3.0, released 2023-05-26

### New features

- Added support for ModerateText ([commit 0af8e03](https://github.com/googleapis/google-cloud-dotnet/commit/0af8e03d9dbb5ccb1f8c72243bfa6934ed961cb0))

## Version 3.2.0, released 2023-01-16

### New features

- Enable REST transport in C# ([commit a6c4606](https://github.com/googleapis/google-cloud-dotnet/commit/a6c46063bd961a9dadc728a780d66de772f28e71))

## Version 3.1.0, released 2022-10-03

### New features

- Add support for V1 and V2 classification models for the V1 API ([commit 634b207](https://github.com/googleapis/google-cloud-dotnet/commit/634b2072cc348f300932f94bf59a4ef9c0304c70))

### Documentation improvements

- Fix docstring formatting ([commit 191e5de](https://github.com/googleapis/google-cloud-dotnet/commit/191e5de258816094a26dc2ae42c1b2a846039912))

## Version 3.0.0, released 2022-06-08

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
## Version 2.3.0, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-10-20

- [Commit fab7d7e](https://github.com/googleapis/google-cloud-dotnet/commit/fab7d7e): docs: Fix proto comments for language API inorder for docs parsing to work correctly. ([issue 5415](https://github.com/googleapis/google-cloud-dotnet/issues/5415))
- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 7a0a214](https://github.com/googleapis/google-cloud-dotnet/commit/7a0a214): docs: change relative URLs to absolute URLs to fix broken links.

## Version 2.0.0, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

Additional breaking changes not covered in the guide:

- Legacy methods accepting nullable EncodingType parameters have been removed

## Version 1.4.0, released 2019-12-09

- [Commit 699db57](https://github.com/googleapis/google-cloud-dotnet/commit/699db57): Some retry settings are now obsolete, and will be removed in the next major version
- Methods accepting `Nullable<EncodingType>` parameters are now obsolete, and will be removed in the next major version.
  (Equivalent methods with non-nullable parameters have been added.)

## Version 1.3.0, released 2019-07-10

- More entity `Type` enum values
- Added more sentiment analysis method overloads

## Version 1.2.0, released 2019-02-05

- Added async methods that accept requests (as well as the other signatures)

## Version 1.1.0, released 2017-11-14

- New feature: text classification

## Version 1.0.0, released 2017-09-19

Initial GA release.
