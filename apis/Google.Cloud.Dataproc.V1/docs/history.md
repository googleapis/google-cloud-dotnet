# Version history

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
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

Additional changes:

- [Commit a629906](https://github.com/googleapis/google-cloud-dotnet/commit/a629906): Adds AutoscalingPolicyClient.

## Version 1.1.0, released 2019-12-09

- [Commit 4e38a24](https://github.com/googleapis/google-cloud-dotnet/commit/4e38a24): Autoscaling and security configuration
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Add resource name format methods

## Version 1.0.0, released 2019-07-10

Initial GA release.
