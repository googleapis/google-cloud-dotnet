# Version history

## Version 2.0.0-beta06, released 2025-11-05

### New features

- Update dependencies

## Version 2.0.0-beta05, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-beta04, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-beta03, released 2024-02-28

### Documentation improvements

- Minor formatting fixes to reference documentation ([commit cbe3cad](https://github.com/googleapis/google-cloud-dotnet/commit/cbe3cad6997d3563e7084f51ff9138aa215b0141))

## Version 2.0.0-beta02, released 2022-12-01

### Bug fixes

- Deprecate AcceleratorType.NVIDIA_TESLA_K80 ([commit 3b439c4](https://github.com/googleapis/google-cloud-dotnet/commit/3b439c4ce6af9d491356e2c6984e123df2c7eb03))

### New features

- Added UpdateRuntime, UpgradeRuntime, DiagnoseRuntime, DiagnoseInstance to v1 API ([commit 3b439c4](https://github.com/googleapis/google-cloud-dotnet/commit/3b439c4ce6af9d491356e2c6984e123df2c7eb03))
- Add Instance.reservation_affinity, nic_type, can_ip_forward to v1beta1 API ([commit 3b439c4](https://github.com/googleapis/google-cloud-dotnet/commit/3b439c4ce6af9d491356e2c6984e123df2c7eb03))
- Add IsInstanceUpgradeableResponse.upgrade_image to v1beta1 API ([commit 3b439c4](https://github.com/googleapis/google-cloud-dotnet/commit/3b439c4ce6af9d491356e2c6984e123df2c7eb03))
- Added Location and IAM methods ([commit 3b439c4](https://github.com/googleapis/google-cloud-dotnet/commit/3b439c4ce6af9d491356e2c6984e123df2c7eb03))

## Version 2.0.0-beta01, released 2022-06-08

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


## Version 1.0.0-beta04, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta03, released 2021-05-26

No API surface changes; just dependency updates.

## Version 1.0.0-beta02, released 2020-11-18

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 73b0c98](https://github.com/googleapis/google-cloud-dotnet/commit/73b0c98): feat: update third party protos with URLs and latest fields
- [Commit 9e018bf](https://github.com/googleapis/google-cloud-dotnet/commit/9e018bf): chore: Fix Ruby namespace for Cloud Notebooks V1beta1

## Version 1.0.0-beta01, released 2020-07-17

Initial beta release.


