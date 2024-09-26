# Version history

## Version 2.7.0, released 2024-09-26

### New features

- Support adding constraints to new method types REMOVE_GRANTS and GOVERN_TAGS ([commit f49e16e](https://github.com/googleapis/google-cloud-dotnet/commit/f49e16e0aff289c5d4932bd6b503ac5e1cf739c8))

## Version 2.6.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.5.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.4.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.3.0, released 2024-01-08

### New features

- Add custom constraints CRUD APIs, proper etag support in Org Policy Update/Delete API ([commit 258a6d5](https://github.com/googleapis/google-cloud-dotnet/commit/258a6d53808c793c4c1883da808c75a9ddc39b35))

### Documentation improvements

- Updated comments ([commit 258a6d5](https://github.com/googleapis/google-cloud-dotnet/commit/258a6d53808c793c4c1883da808c75a9ddc39b35))

## Version 2.2.0, released 2023-01-19

### New features

- Support for OrgPolicy dry runs ([commit edfcb7b](https://github.com/googleapis/google-cloud-dotnet/commit/edfcb7b10fc124d1847e4208a68e7aa9b084c547))

## Version 2.1.0, released 2023-01-18

### New features

- Enable REST transport in C# ([commit 0f8560c](https://github.com/googleapis/google-cloud-dotnet/commit/0f8560c840725bf41bc060c8beecafc7d99f38eb))

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
## Version 1.2.0, released 2022-02-22

### Deprecation

- Deprecates AlternativePolicySpec ([commit 6b3d63e](https://github.com/googleapis/google-cloud-dotnet/commit/6b3d63e5837e1f09a1cd67a162b95e1d55ec0a95))

## Version 1.1.0, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-03-10

No API surface change since 1.0.0-beta01.

## Version 1.0.0-beta01, released 2021-02-09

Initial release.
