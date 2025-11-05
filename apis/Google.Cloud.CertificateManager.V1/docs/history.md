# Version history

## Version 2.9.0, released 2025-11-05

### New features

- Update dependencies

## Version 2.8.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.7.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.6.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.5.0, released 2024-03-21

### New features

- Added Trust Configs and DnsAuthorization.Type to Certificate Manager ([commit ac4eb8a](https://github.com/googleapis/google-cloud-dotnet/commit/ac4eb8a1afb11a6885101a658e5b0094192c6e03))

## Version 2.4.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.3.0, released 2023-03-06

### Bug fixes

- Workaround crashes in gRPC for C++ ([commit edf4bda](https://github.com/googleapis/google-cloud-dotnet/commit/edf4bda298867ba6bfce2927e14732f90260e65e))

### Documentation improvements

- Corrected information about the limit of certificates that can be attached to a Certificate Map Entry ([commit 7219d64](https://github.com/googleapis/google-cloud-dotnet/commit/7219d645951e1c29a9f73376de8c1a3e39cf1737))

## Version 2.2.0, released 2023-01-18

### New features

- Enable REST transport in C# ([commit 0f8560c](https://github.com/googleapis/google-cloud-dotnet/commit/0f8560c840725bf41bc060c8beecafc7d99f38eb))

## Version 2.1.0, released 2022-10-06

### New features

- Added support for Private Trust to Certificate Manager API ([commit 9722cb7](https://github.com/googleapis/google-cloud-dotnet/commit/9722cb7981d69eda8f759a01b0fd72dbd9c28819))

### Documentation improvements

- See https://cloud.google.com/certificate-manager/docs/deploy-google-managed-cas ([commit 9722cb7](https://github.com/googleapis/google-cloud-dotnet/commit/9722cb7981d69eda8f759a01b0fd72dbd9c28819))

## Version 2.0.0, released 2022-09-15

No API surface changes; just dependency updates and promotion to GA.

## Version 2.0.0-beta02, released 2022-07-11

### Bug fixes

- **BREAKING CHANGE** Removed resource definition of Compute API resources and incorrect resource references that used them ([commit 0fff1eb](https://github.com/googleapis/google-cloud-dotnet/commit/0fff1ebe5d0be93eeb28fc8dd750f0fd2f77d3b7))

## Version 2.0.0-beta01, released 2022-06-09

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

## Version 1.0.0-beta02, released 2022-04-26

### Bug fixes

- **BREAKING CHANGE** Updated resource patterns to comply with https://google.aip.dev/123#annotating-resource-types ([commit 9f116f5](https://github.com/googleapis/google-cloud-dotnet/commit/9f116f5f55837084d0f197c1f90e6b42e86c7848))

### Documentation improvements

- Fix docstring formatting ([commit 3fa70c6](https://github.com/googleapis/google-cloud-dotnet/commit/3fa70c68e03ef44c94748a31ef4d2f1e37a33ddd))
## Version 1.0.0-beta01, released 2022-02-09

Initial release.
