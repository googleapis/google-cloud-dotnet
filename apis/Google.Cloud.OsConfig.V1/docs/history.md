# Version history

## Version 2.6.0, released 2025-11-03

### New features

- Update dependencies

## Version 2.5.0, released 2025-08-12

### New features

- Add highest_upgradable_cve_severity field to Vulnerability report

### Documentation improvements

- A comment for field `update_time` in message `.google.cloud.osconfig.v1.VulnerabilityReport` is changed
- A comment for field `filter` in message `.google.cloud.osconfig.v1.ListVulnerabilityReportsRequest` is changed

## Version 2.4.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.3.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.2.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

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


## Version 1.8.0, released 2022-02-14

### Bug fixes

- Fix description of an interpreter field, validate if the field is not unspecified ([commit ddc399b](https://github.com/googleapis/google-cloud-dotnet/commit/ddc399bcb2411cb5629f49a669b638570574603c))

### New features

- Update osconfig v1 protos ([commit 3bac0d0](https://github.com/googleapis/google-cloud-dotnet/commit/3bac0d0f26d4aa438afdf9e28d71f4e2271ff08f))

## Version 1.7.0, released 2021-11-18

- [Commit aaeed36](https://github.com/googleapis/google-cloud-dotnet/commit/aaeed36): feat: Add details of items affected by a vulnerability

## Version 1.6.0, released 2021-11-10

- [Commit 8f1e976](https://github.com/googleapis/google-cloud-dotnet/commit/8f1e976): feat: OSConfig: add OS policy assignment rpcs

## Version 1.5.0, released 2021-10-20

- [Commit 5cd7c96](https://github.com/googleapis/google-cloud-dotnet/commit/5cd7c96): feat: Update osconfig v1 and v1alpha RecurringSchedule.Frequency with DAILY frequency

## Version 1.4.0, released 2021-09-24

- [Commit 7a79d5a](https://github.com/googleapis/google-cloud-dotnet/commit/7a79d5a): feat: add OSConfigZonalService API
- [Commit 0cc5d6f](https://github.com/googleapis/google-cloud-dotnet/commit/0cc5d6f): feat: Update osconfig v1 and v1alpha with WindowsApplication
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.3.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 1.2.0, released 2020-11-17

- [Commit 696b75f](https://github.com/googleapis/google-cloud-dotnet/commit/696b75f):
  - feat: Added PatchRollout feature to PatchDeployments
  - feat: Added Inventory proto definitions for VM Manager Inventory.

## Version 1.1.0, released 2020-10-23

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit ae62c19](https://github.com/googleapis/google-cloud-dotnet/commit/ae62c19): docs: Fix several broken links in reference documentation

## Version 1.0.0, released 2020-06-10

- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): Regenerate all clients with more explicit documentation
- [Commit 0dd211a](https://github.com/googleapis/google-cloud-dotnet/commit/0dd211a): Updated documentation for OS Config V1 OsConfigService
- [Commit 81fc39c](https://github.com/googleapis/google-cloud-dotnet/commit/81fc39c): Adding retry policy for OS Config V1 OsConfigService

## Version 1.0.0-beta01, released 2020-04-08

Initial beta release.


