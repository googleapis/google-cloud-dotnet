# Version history

## Version 5.16.0, released 2024-10-21

### New features

- Add `ProvisioningModelMix` to support mixing of spot and standard instances for secondary workers ([commit dde1a4f](https://github.com/googleapis/google-cloud-dotnet/commit/dde1a4f656d818f682687266ab7519eb484a0d45))
- Add support for configuration of bootdisk IOPS and throughput when bootdisk is a hyperdisk ([commit dde1a4f](https://github.com/googleapis/google-cloud-dotnet/commit/dde1a4f656d818f682687266ab7519eb484a0d45))

## Version 5.15.0, released 2024-09-26

### New features

- Add support for Spark Connect sessions in Dataproc Serverless for Spark ([commit 2a56544](https://github.com/googleapis/google-cloud-dotnet/commit/2a5654405a1350a08e95dde23c034ca49a3f19b5))

### Documentation improvements

- Update docs for `filter` field in `ListSessionsRequest` ([commit 2a56544](https://github.com/googleapis/google-cloud-dotnet/commit/2a5654405a1350a08e95dde23c034ca49a3f19b5))

## Version 5.14.0, released 2024-09-16

### New features

- Add resource reference for KMS keys and fix comments ([commit 2a39cfd](https://github.com/googleapis/google-cloud-dotnet/commit/2a39cfd6e0994f9aeeec70fae4af878d22a29d09))
- Add support for new Dataproc features ([commit 2a8cd75](https://github.com/googleapis/google-cloud-dotnet/commit/2a8cd7532c01b59e5f62dfe7655a991dab958181))
- Add support for new Dataproc features ([commit 25f2519](https://github.com/googleapis/google-cloud-dotnet/commit/25f2519badff8e1691db0efc8af634102493b2e8))

## Version 5.13.0, released 2024-09-09

### New features

- Add optional parameters (tarball-access) in DiagnoseClusterRequest ([commit 8e5af66](https://github.com/googleapis/google-cloud-dotnet/commit/8e5af666cfaf9193af598b9d4f05a8650433c1f5))

## Version 5.12.0, released 2024-07-08

### New features

- Add the cohort and auto tuning configuration to the batch's RuntimeConfig ([commit b5e041d](https://github.com/googleapis/google-cloud-dotnet/commit/b5e041d1f859a5d14601e4f37c1f4b7b8bf0fa15))

## Version 5.11.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 5.10.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 5.9.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 5.8.0, released 2023-11-07

### New features

- Support required_registration_fraction for secondary workers ([commit cccf5b6](https://github.com/googleapis/google-cloud-dotnet/commit/cccf5b636972ff9efa55d5af9032db957957f3a7))

## Version 5.7.0, released 2023-09-18

### New features

- Add optional parameters (tarball_gcs_dir, diagnosis_interval, jobs, yarn_application_ids) in DiagnoseClusterRequest ([commit adf57b2](https://github.com/googleapis/google-cloud-dotnet/commit/adf57b2465aec1a9c6d5d11559dc8ba34cdc45bb))

## Version 5.6.0, released 2023-08-23

### New features

- Support min_num_instances for primary worker and InstanceFlexibilityPolicy for secondary worker ([commit 1783572](https://github.com/googleapis/google-cloud-dotnet/commit/1783572f62de9ed84cb7b0bc44993d39f7cb30ce))

### Documentation improvements

- Minor formatting ([commit 5a4054c](https://github.com/googleapis/google-cloud-dotnet/commit/5a4054c983789e87cee928cf31fdc61483cecd29))

## Version 5.5.0, released 2023-03-20

### New features

- Add support for new Dataproc features ([commit 07761d3](https://github.com/googleapis/google-cloud-dotnet/commit/07761d32cd00a39cde860d3b4727c554c71946df))

## Version 5.4.0, released 2023-01-19

### New features

- Add SPOT to Preemptibility enum ([commit dc383fa](https://github.com/googleapis/google-cloud-dotnet/commit/dc383fa02bda1ba57739aa3a1e1df1204949e366))

## Version 5.3.0, released 2023-01-16

### New features

- Enable REST transport in C# ([commit a6c4606](https://github.com/googleapis/google-cloud-dotnet/commit/a6c46063bd961a9dadc728a780d66de772f28e71))

## Version 5.2.0, released 2022-12-14

### New features

- Added node groups API protos ([commit f56258b](https://github.com/googleapis/google-cloud-dotnet/commit/f56258b097d221feb3e7ee533acf2fff4d8cbfc1))

## Version 5.1.0, released 2022-10-03

### New features

- Add support for Dataproc metric configuration ([commit 3267b4f](https://github.com/googleapis/google-cloud-dotnet/commit/3267b4f1faa7c15ff21ef0708f3636e48283ca3d))

## Version 5.0.0, released 2022-06-08

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


## Version 4.0.0, released 2022-02-17

### New features

- Add support for Virtual Dataproc cluster running on GKE cluster ([commit 462556b](https://github.com/googleapis/google-cloud-dotnet/commit/462556ba2b46bd840da1198fe0bd4bfba6b13af1))

### Breaking changes

- ClusterConfig.GkeClusterConfig has been removed
- GkeClusterConfig.NamespacedGkeDeploymentTarget has been removed
  (along with the corresponding nested type)

## Version 3.4.0, released 2022-01-17

### New features

- Spark runtime versioning for Spark batches ([commit b6189ae](https://github.com/googleapis/google-cloud-dotnet/commit/b6189aeaa81e283d7eb9d0cd1652f5b594db2d0a))
- Custom image containers for Spark batches ([commit b6189ae](https://github.com/googleapis/google-cloud-dotnet/commit/b6189aeaa81e283d7eb9d0cd1652f5b594db2d0a))
- Auto-diagnostic of failed Spark batches ([commit b6189ae](https://github.com/googleapis/google-cloud-dotnet/commit/b6189aeaa81e283d7eb9d0cd1652f5b594db2d0a))
- Local SSD NVME interface support for GCE clusters ([commit b6189ae](https://github.com/googleapis/google-cloud-dotnet/commit/b6189aeaa81e283d7eb9d0cd1652f5b594db2d0a))
## Version 3.3.0, released 2021-10-14

- [Commit 7c1e526](https://github.com/googleapis/google-cloud-dotnet/commit/7c1e526): feat: add Dataproc Serverless for Spark Batches API

## Version 3.2.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 3.1.0, released 2021-04-29

- [Commit d429843](https://github.com/googleapis/google-cloud-dotnet/commit/d429843):
  - feat: The new start and stop cluster methods.
  - feat: The ability to specify a metastore config in a cluster.
  - feat: The ability to specify a (BETA) GKE cluster when creating a Dataproc cluster.
  - feat: The ability to configure the behavior for private IPv6 cluster networking.
  - feat: The ability to specify node affinity groups for clusters.
  - feat: The ability to specify shielded VM configurations for clusters.
  - feat: Support for service-account based secure multi-tenancy.
  - feat: The ability to specify cluster labels for picking which cluster should run a job.
  - feat: Components for DOCKER, DRUID, FLINK, HBASE, RANGER, and SOLR
  - feat: The ability to specify a DAG timeout for workflows.

## Version 3.0.0, released 2020-11-17

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit baae3ab](https://github.com/googleapis/google-cloud-dotnet/commit/baae3ab): docs: change relative URLs to absolute URLs to fix broken links.
- [Commit 0ceb9e8](https://github.com/googleapis/google-cloud-dotnet/commit/0ceb9e8): feat: Additional fields for the `ClusterConfig` and `InstanceGroupConfig` messages.
- [Commit 9724a7a](https://github.com/googleapis/google-cloud-dotnet/commit/9724a7a): fix!: fix LRO annotations for method `DiagnoseCluster`.
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit bdd321b](https://github.com/googleapis/google-cloud-dotnet/commit/bdd321b): docs: change relative URLs to absolute URLs to fix broken links.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

Please note the breaking change compared with 2.1.0, in terms of long-running operation response/metadata types.

## Version 2.1.0, released 2020-05-04

- [Commit cdd7342](https://github.com/googleapis/google-cloud-dotnet/commit/cdd7342): docs: change relative URLs to absolute URLs to fix broken links.
- [Commit e644610](https://github.com/googleapis/google-cloud-dotnet/commit/e644610):
  - Adds Dataproc Jobs.SubmitJobAsOperation RPC
  - Adds SparkR and Presto job types to WorkflowTemplates
  - Adds new Optional Components
  - Clarifies usage of some APIs 
- [Commit edebc2b](https://github.com/googleapis/google-cloud-dotnet/commit/edebc2b): fix Dataproc: add missing `REQUIRED` annotation.
- [Commit bd045c2](https://github.com/googleapis/google-cloud-dotnet/commit/bd045c2): Adds resource name overloads for autoscaling policy operations

## Version 2.0.0, released 2020-03-17

- [Commit c120b77](https://github.com/googleapis/google-cloud-dotnet/commit/c120b77):
  - Feature: SparkR and Presto job support
  - Feature: Lifecycle config support
  - Feature: Reservation affinity support
- [Commit 5ae3789](https://github.com/googleapis/google-cloud-dotnet/commit/5ae3789): Breaking changes around resource names, due to removing RegionOrLocationName

Note that the breaking change here was expected;
RegionOrLocationName didn't represent the name of a real resource,
and we now have better options for handling parents of resources with multiple patterns.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

Additional changes:

- [Commit a629906](https://github.com/googleapis/google-cloud-dotnet/commit/a629906): Adds AutoscalingPolicyClient.

## Version 1.1.0, released 2019-12-09

- [Commit 4e38a24](https://github.com/googleapis/google-cloud-dotnet/commit/4e38a24): Autoscaling and security configuration
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Add resource name format methods

## Version 1.0.0, released 2019-07-10

Initial GA release.
