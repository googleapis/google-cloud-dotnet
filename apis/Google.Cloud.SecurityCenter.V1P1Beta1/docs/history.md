# Version history

## Version 3.0.0-beta06, released 2025-11-06

### New features

- Update dependencies

## Version 3.0.0-beta05, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.0.0-beta04, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))
## Version 3.0.0-beta03, released 2024-02-29

No API surface changes; just dependency updates.

## Version 3.0.0-beta02, released 2023-01-19

### New features

- Enable REST transport in C# ([commit f6a1c3e](https://github.com/googleapis/google-cloud-dotnet/commit/f6a1c3e8930f0e8209a079352765be3bb9039be2))

## Version 3.0.0-beta01, released 2022-06-08

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


## Version 2.0.0-beta07, released 2021-12-07

- [Commit 8598bf5](https://github.com/googleapis/google-cloud-dotnet/commit/8598bf5): docs: fix docstring formatting
## Version 2.0.0-beta06, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.0.0-beta05, released 2021-05-26

- [Commit 3dfe0cf](https://github.com/googleapis/google-cloud-dotnet/commit/3dfe0cf): feat: add canonical_name and folder fields

## Version 2.0.0-beta04, released 2020-11-18

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 28fa21a](https://github.com/googleapis/google-cloud-dotnet/commit/28fa21a): docs: updated description of finding severity field
- [Commit 6696f32](https://github.com/googleapis/google-cloud-dotnet/commit/6696f32): docs: Clarified that event_time can also be considered as the "update time" for a Finding. It also captures when a Finding was updated. The previous wording could've been interpreted as only the creation time.

## Version 2.0.0-beta03, released 2020-08-17

- [Commit 95b05fe](https://github.com/googleapis/google-cloud-dotnet/commit/95b05fe):
  - feat: Added field severity to findings
  Clients will now see a new field, severity, on findings.
  They will also be able to filter and group by severity on ListFinding and GroupFinding API calls.
- [Commit 2f4a2c6](https://github.com/googleapis/google-cloud-dotnet/commit/2f4a2c6):
  - fix: Correct securitycenter grpc_service_configs
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3):
  - Includes service comments in client documentation.
  The comments are included as they are, on a "remarks" section both in the
  abstract base class and the concrete implementation.
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1):
  - Enables RPCs without retries to still have timeouts specified.
- [Commit 2c1b17e](https://github.com/googleapis/google-cloud-dotnet/commit/2c1b17e):
  - Specify allowed fields for UpdateNotificationConfig
- [Commit b6d323c](https://github.com/googleapis/google-cloud-dotnet/commit/b6d323c):
  - fix!: Fix the version casing in the C# namespace option
  BREAKING CHANGE: This would break any C# code already generated,
  but this file is very new, so is unlikely to break anyone.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573):
  - Adds more explicit documentation
- [Commit 0dfc53b](https://github.com/googleapis/google-cloud-dotnet/commit/0dfc53b):
  - docs: fix broken link to policy reference documentation.

## Version 2.0.0-beta02, released 2020-03-19

- [Commit 8746b2d](https://github.com/googleapis/google-cloud-dotnet/commit/8746b2d): Amended retry configuration

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0-beta01, released 2020-02-07

Initial beta release.
