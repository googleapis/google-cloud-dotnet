# Version history

## Version 2.4.0, released 2025-11-03

### New features

- Update dependencies

## Version 2.3.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.2.0, released 2024-03-25

### New features

This library now targets netstandard2.0 instead of netstandard2.1.
This should be compatible with existing libraries that depend on it,
but will allow new libraries to also target netstandard2.0.

## Version 2.1.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.0.0, released 2022-06-07

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code.The changes that aren't specific to any given API are [described in the Google Cloud
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

## Version 1.0.0, released 2022-01-19

No API surface changes; just dependency updates.

## Version 1.0.0-beta01, released 2021-11-08

Initial release.
