# Version history

## Version 2.7.0, released 2024-09-16

### New features

- An optional field `security_posture_config` in message `.google.cloud.gkemulticloud.v1.AttachedCluster` is added ([commit d8adaac](https://github.com/googleapis/google-cloud-dotnet/commit/d8adaac06030ce3fb83da05f4f0931111d3e56b7))
- An optional field `kubelet_config` in message `.google.cloud.gkemulticloud.v1.AwsNodePool` is added ([commit d8adaac](https://github.com/googleapis/google-cloud-dotnet/commit/d8adaac06030ce3fb83da05f4f0931111d3e56b7))

## Version 2.6.0, released 2024-05-14

### New features

- Option to ignore_errors while deleting Azure clusters / nodepools ([commit 564312f](https://github.com/googleapis/google-cloud-dotnet/commit/564312fafe111033b4f45180097c60ac02f5ddf4))
- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.5.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.4.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.3.0, released 2024-01-08

### New features

- Added proxy support for Attached Clusters ([commit 39eb8f0](https://github.com/googleapis/google-cloud-dotnet/commit/39eb8f0e301aa1be2a771c3301689079bae230ba))
- Added Binary Authorization support which is a deploy-time security control that ensures only trusted container images are deployed ([commit 39eb8f0](https://github.com/googleapis/google-cloud-dotnet/commit/39eb8f0e301aa1be2a771c3301689079bae230ba))
- Added support for a new admin-groups flag in the create and update APIs ([commit 39eb8f0](https://github.com/googleapis/google-cloud-dotnet/commit/39eb8f0e301aa1be2a771c3301689079bae230ba))
- Added Surge Update and Rollback support for AWS Node Pools ([commit 39eb8f0](https://github.com/googleapis/google-cloud-dotnet/commit/39eb8f0e301aa1be2a771c3301689079bae230ba))
- Added support for per-node-pool subnet security group rules for AWS Node Pools ([commit 39eb8f0](https://github.com/googleapis/google-cloud-dotnet/commit/39eb8f0e301aa1be2a771c3301689079bae230ba))
- Added support for EC2 Spot instance types for AWS Node Pools ([commit 39eb8f0](https://github.com/googleapis/google-cloud-dotnet/commit/39eb8f0e301aa1be2a771c3301689079bae230ba))
- Added force-deletion support for AWS Clusters & Node Pools ([commit 39eb8f0](https://github.com/googleapis/google-cloud-dotnet/commit/39eb8f0e301aa1be2a771c3301689079bae230ba))
- Expanded Kubernetes version info ([commit 39eb8f0](https://github.com/googleapis/google-cloud-dotnet/commit/39eb8f0e301aa1be2a771c3301689079bae230ba))

### Documentation improvements

- Updated comments of existing fields ([commit 39eb8f0](https://github.com/googleapis/google-cloud-dotnet/commit/39eb8f0e301aa1be2a771c3301689079bae230ba))

## Version 2.2.0, released 2023-02-08

### New features

- Added support for Azure workload identity federation ([commit 7286a94](https://github.com/googleapis/google-cloud-dotnet/commit/7286a9405ef61e850ee6d6c9efcc22decee49ee3))
- Added `reconciling` and `update_time` output fields to Azure Client resource. ([commit 7286a94](https://github.com/googleapis/google-cloud-dotnet/commit/7286a9405ef61e850ee6d6c9efcc22decee49ee3))

## Version 2.1.0, released 2023-01-16

### New features

- Support AttachedClusters ([commit aee0849](https://github.com/googleapis/google-cloud-dotnet/commit/aee0849f0679a9557375d70887436926f6ec1c16))
- Add errors output fields for cluster and nodepool resources ([commit aee0849](https://github.com/googleapis/google-cloud-dotnet/commit/aee0849f0679a9557375d70887436926f6ec1c16))
- Add AWS Autoscaling Group metrics collection for AWS nodepools ([commit aee0849](https://github.com/googleapis/google-cloud-dotnet/commit/aee0849f0679a9557375d70887436926f6ec1c16))
- Add monitoring config ([commit aee0849](https://github.com/googleapis/google-cloud-dotnet/commit/aee0849f0679a9557375d70887436926f6ec1c16))

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

## Version 1.0.0-beta01, released 2022-05-12

Initial release.
