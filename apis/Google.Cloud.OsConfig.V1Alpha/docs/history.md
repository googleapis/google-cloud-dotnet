# Version history

## Version 2.0.0-alpha07, released 2025-11-06

### New features

- Update dependencies

## Version 2.0.0-alpha06, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.0.0-alpha05, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-alpha04, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-alpha03, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.0.0-alpha02, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

## Version 2.0.0-alpha01, released 2022-06-08

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


## Version 1.0.0-alpha04, released 2022-02-14

### Bug fixes

- Fix description of an interpreter field, validate if the field is not unspecified ([commit 5383e6f](https://github.com/googleapis/google-cloud-dotnet/commit/5383e6fac5edde770d475cabd458b3ae89689524))
## Version 1.0.0-alpha03, released 2021-09-24

- [Commit c38ba1f](https://github.com/googleapis/google-cloud-dotnet/commit/c38ba1f): feat: Update osconfig v1 and v1alpha with WindowsApplication
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-alpha02, released 2021-06-22

- [Commit bf2ca0a](https://github.com/googleapis/google-cloud-dotnet/commit/bf2ca0a): feat: OSConfig: add ExecResourceOutput and per step error message.

## Version 1.0.0-alpha01, released 2021-05-12

First (alpha) release.


