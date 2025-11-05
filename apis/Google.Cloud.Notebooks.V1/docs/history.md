# Version history

## Version 2.6.0, released 2025-11-05

### New features

- Update dependencies

## Version 2.5.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.3.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.2.0, released 2023-01-11

This is primarily a promotion of the previous beta, which includes REST transport support.

### Documentation improvements

- Minor formatting fixes to reference documentation ([commit 78da228](https://github.com/googleapis/google-cloud-dotnet/commit/78da2288332c56179993cc9b0647d91924a19b57))

## Version 2.2.0-beta01, released 2022-12-08

### New features

- Enable REST transport in selected APIs. Set GrpcAdapter=RestGrpcAdapter.Default in the client builder to use this transport ([commit 5008946](https://github.com/googleapis/google-cloud-dotnet/commit/500894667ba84ecc3d8e3e4ebc09ac0cd597100b))

## Version 2.1.0, released 2022-12-01

### Bug fixes

- Deprecate AcceleratorType.NVIDIA_TESLA_K80 ([commit 61da370](https://github.com/googleapis/google-cloud-dotnet/commit/61da370e5246d6611c6ba8db6f09fc9cb80e273f))

### New features

- Added UpdateRuntime, UpgradeRuntime, DiagnoseRuntime, DiagnoseInstance to v1 API ([commit 61da370](https://github.com/googleapis/google-cloud-dotnet/commit/61da370e5246d6611c6ba8db6f09fc9cb80e273f))
- Add Instance.reservation_affinity, nic_type, can_ip_forward to v1beta1 API ([commit 61da370](https://github.com/googleapis/google-cloud-dotnet/commit/61da370e5246d6611c6ba8db6f09fc9cb80e273f))
- Add IsInstanceUpgradeableResponse.upgrade_image to v1beta1 API ([commit 61da370](https://github.com/googleapis/google-cloud-dotnet/commit/61da370e5246d6611c6ba8db6f09fc9cb80e273f))
- Added Location and IAM methods ([commit 61da370](https://github.com/googleapis/google-cloud-dotnet/commit/61da370e5246d6611c6ba8db6f09fc9cb80e273f))

### Documentation improvements

- [Google.Cloud.Notebooks.V1] fix minor docstring formatting ([issue 9367](https://github.com/googleapis/google-cloud-dotnet/issues/9367)) ([commit 0e93ecb](https://github.com/googleapis/google-cloud-dotnet/commit/0e93ecbe710810fd4c7c7b629a4f23f007dbcc57))

## Version 2.0.0, released 2022-09-15

No API surface changes; just dependency updates and promotion to GA.

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

## Version 1.0.0-beta04, released 2022-05-24

### Documentation improvements

- Modifies the project ID pattern in comment for Workbench environment ([commit 9f67d86](https://github.com/googleapis/google-cloud-dotnet/commit/9f67d8655c028fcde14849d480b53e3d26873caf))

## Version 1.0.0-beta03, released 2022-04-26

### New features

- Update Notebooks API for clients libraries ([commit bfb3a24](https://github.com/googleapis/google-cloud-dotnet/commit/bfb3a2492df98b5a42b9aceb1ea04c67dae043c3))

## Version 1.0.0-beta02, released 2021-12-07

- [Commit 2460a97](https://github.com/googleapis/google-cloud-dotnet/commit/2460a97):
  - docs: fix typos and docstring formatting

## Version 1.0.0-beta01, released 2021-10-11

Initial release.
