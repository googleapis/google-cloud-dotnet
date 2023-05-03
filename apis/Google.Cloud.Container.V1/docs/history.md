# Version history

## Version 3.11.0, released 2023-05-03

### New features

- Cluster resizes will now have their own operation type (RESIZE_CLUSTER) instead of reusing REPAIR_CLUSTER; they will start using this in the near future ([commit 297d5b8](https://github.com/googleapis/google-cloud-dotnet/commit/297d5b8c898aa4d65c1d5272a9f798aae2521d24))

### Documentation improvements

- Minor formatting in docstring ([commit 3439142](https://github.com/googleapis/google-cloud-dotnet/commit/34391423be1d7efaf6f1e03fe1c5788b953131a2))
- Operation.Type is now documented in detail ([commit 297d5b8](https://github.com/googleapis/google-cloud-dotnet/commit/297d5b8c898aa4d65c1d5272a9f798aae2521d24))
- Operation.self_link and Operation.target_link given examples ([commit 297d5b8](https://github.com/googleapis/google-cloud-dotnet/commit/297d5b8c898aa4d65c1d5272a9f798aae2521d24))

## Version 3.10.0, released 2023-04-19

### New features

- Add support for updating additional pod IPv4 ranges for Standard and Autopilot clusters ([commit 744f687](https://github.com/googleapis/google-cloud-dotnet/commit/744f687d8da05eed660aedeb32bb34f467ff92c1))

## Version 3.9.0, released 2023-04-12

### New features

- Add support for updating additional pod IPv4 ranges for Standard and Autopilot clusters ([commit 217853b](https://github.com/googleapis/google-cloud-dotnet/commit/217853b8b06f699c6f064aef9ea9174860ed5a96))
- Add support for disabling pod IP cidr overprovision ([commit 440c8ca](https://github.com/googleapis/google-cloud-dotnet/commit/440c8ca56d42a29dd1dd93db640e1b62e12de831))
- Add a new fleet registration feature ([commit e6be97b](https://github.com/googleapis/google-cloud-dotnet/commit/e6be97b75027d9ad2a18e836e9312b2b77ab0b09))

### Documentation improvements

- Minor typo fix ([commit 891e898](https://github.com/googleapis/google-cloud-dotnet/commit/891e89876c6b91843d35c5143e63da5101c6c530))
- Minor grammar improvements ([commit 2e674ee](https://github.com/googleapis/google-cloud-dotnet/commit/2e674ee00dc17ee64edeb9c053907fed53187a0c))
- Add clarification on whether `NodePool.version` is a required field ([commit 50c4b0f](https://github.com/googleapis/google-cloud-dotnet/commit/50c4b0fc6005d326f500023267c797dbe39aa2db))
- Clarified wording around the NodePoolUpdateStrategy default behavior ([commit beac7f8](https://github.com/googleapis/google-cloud-dotnet/commit/beac7f8fa14f7944a56bd5c99bc45740a130643b))
- Add references for available node image types ([commit beac7f8](https://github.com/googleapis/google-cloud-dotnet/commit/beac7f8fa14f7944a56bd5c99bc45740a130643b))

## Version 3.8.0, released 2023-01-18

### New features

- Add support for viewing the subnet IPv6 CIDR and services IPv6 CIDR assigned to dual stack clusters ([commit f4ea790](https://github.com/googleapis/google-cloud-dotnet/commit/f4ea7907f39cdf76b88453e23809c43f2ab0beb5))

## Version 3.7.0, released 2023-01-16

### New features

- Add etags for cluster and node pool update operations ([commit 04b4db4](https://github.com/googleapis/google-cloud-dotnet/commit/04b4db4faaeb16f14e51206aa51dd3e557a10282))
- Release GKE CloudDNS Cluster Scope ([commit 7d1eafe](https://github.com/googleapis/google-cloud-dotnet/commit/7d1eafef6b4479c9672e51498b71ce8b7218d702))
- Add WindowsNodeConfig field to v1alpha1, v1beta1, v1 ([commit 7d1eafe](https://github.com/googleapis/google-cloud-dotnet/commit/7d1eafef6b4479c9672e51498b71ce8b7218d702))
- Add EphemeralStorageLocalSsdConfig and LocalNvmeSsdBlockConfig APIs to v1alpha1, v1beta1, v1 ([commit 7d1eafe](https://github.com/googleapis/google-cloud-dotnet/commit/7d1eafef6b4479c9672e51498b71ce8b7218d702))
- Add support for specifying stack type for clusters. This will allow clusters to be created as dual stack or toggled between IPV4 and dual stack ([commit 1cb1704](https://github.com/googleapis/google-cloud-dotnet/commit/1cb170400140ed79feec2dbee05e3113d5ec4e63))

## Version 3.6.0, released 2022-12-01

### New features

- Add a FastSocket API ([commit ec6e15e](https://github.com/googleapis/google-cloud-dotnet/commit/ec6e15e877bc1bd77d2324be8180ac4e56bdfc3d))
- Add compact placement feature for node pools ([commit 89213cc](https://github.com/googleapis/google-cloud-dotnet/commit/89213cc6e3484360c45cf980087c8c33d1c0b6e6))

## Version 3.5.0, released 2022-11-10

### New features

- Add APIs for GKE Control Plane Logs ([commit 45f1266](https://github.com/googleapis/google-cloud-dotnet/commit/45f1266a6af8dc2f4247882d0815270c3a76c461))
- GKE cluster's control plan/node-pool network isolation ([commit 45f1266](https://github.com/googleapis/google-cloud-dotnet/commit/45f1266a6af8dc2f4247882d0815270c3a76c461))
- Add nodeconfig resource_labels api ([commit 45f1266](https://github.com/googleapis/google-cloud-dotnet/commit/45f1266a6af8dc2f4247882d0815270c3a76c461))
- Add API to enable GKE Gateway controller ([commit 45f1266](https://github.com/googleapis/google-cloud-dotnet/commit/45f1266a6af8dc2f4247882d0815270c3a76c461))

## Version 3.4.0, released 2022-10-17

### New features

- Launch GKE Cost Allocations configuration to the v1 GKE API ([commit c359c4a](https://github.com/googleapis/google-cloud-dotnet/commit/c359c4a17e2697da4219ef9176bd3b3b84792105))

## Version 3.3.0, released 2022-10-03

### New features

- Added High Throughput Logging API for Google Kubernetes Engine ([commit 98e2c03](https://github.com/googleapis/google-cloud-dotnet/commit/98e2c03e81607475e0988e6cdb2e8a15dc67fc53))

### Documentation improvements

- ReservationAffinity key field docs incorrect ([commit 98e2c03](https://github.com/googleapis/google-cloud-dotnet/commit/98e2c03e81607475e0988e6cdb2e8a15dc67fc53))
- Missing period in description for min CPU platform ([commit 98e2c03](https://github.com/googleapis/google-cloud-dotnet/commit/98e2c03e81607475e0988e6cdb2e8a15dc67fc53))

## Version 3.2.0, released 2022-09-05

### Documentation improvements

- BinaryAuthorization.enabled field is marked as deprecated ([commit de50331](https://github.com/googleapis/google-cloud-dotnet/commit/de503317d05e819ab1ace265afcd62911050df8e))

## Version 3.1.0, released 2022-07-11

### New features

- Add support to modify kubelet pod pid limit in node system configuration ([commit 33a4b1d](https://github.com/googleapis/google-cloud-dotnet/commit/33a4b1d21ad275e2c8dd6307493ccaa789d1f635))
- Support spot VM ([commit 33a4b1d](https://github.com/googleapis/google-cloud-dotnet/commit/33a4b1d21ad275e2c8dd6307493ccaa789d1f635))
- Support Tier 1 bandwidth ([commit 33a4b1d](https://github.com/googleapis/google-cloud-dotnet/commit/33a4b1d21ad275e2c8dd6307493ccaa789d1f635))
- Update support for node pool labels, taints and network tags ([commit 33a4b1d](https://github.com/googleapis/google-cloud-dotnet/commit/33a4b1d21ad275e2c8dd6307493ccaa789d1f635))
- Add Binauthz Evaluation mode support to GKE Classic ([commit 33a4b1d](https://github.com/googleapis/google-cloud-dotnet/commit/33a4b1d21ad275e2c8dd6307493ccaa789d1f635))
- Add GKE Identity Service ([commit 33a4b1d](https://github.com/googleapis/google-cloud-dotnet/commit/33a4b1d21ad275e2c8dd6307493ccaa789d1f635))
- Add network tags to autopilot cluster ([commit 33a4b1d](https://github.com/googleapis/google-cloud-dotnet/commit/33a4b1d21ad275e2c8dd6307493ccaa789d1f635))
- Support enabling Confidential Nodes in the node pool ([commit 33a4b1d](https://github.com/googleapis/google-cloud-dotnet/commit/33a4b1d21ad275e2c8dd6307493ccaa789d1f635))
- Support node pool blue-green upgrade ([commit 33a4b1d](https://github.com/googleapis/google-cloud-dotnet/commit/33a4b1d21ad275e2c8dd6307493ccaa789d1f635))
- Add Location Policy API ([commit 33a4b1d](https://github.com/googleapis/google-cloud-dotnet/commit/33a4b1d21ad275e2c8dd6307493ccaa789d1f635))
- Support GPU timesharing ([commit 33a4b1d](https://github.com/googleapis/google-cloud-dotnet/commit/33a4b1d21ad275e2c8dd6307493ccaa789d1f635))
- Add managed prometheus feature ([commit 33a4b1d](https://github.com/googleapis/google-cloud-dotnet/commit/33a4b1d21ad275e2c8dd6307493ccaa789d1f635))

## Version 3.0.0, released 2022-06-08

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
## Version 2.7.0, released 2022-04-04

### New features

- Multiple new messages and properties ([commit fa099d3](https://github.com/googleapis/google-cloud-dotnet/commit/fa099d3132999c8ac0fba7b55134145f725daf2c))

## Version 2.6.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.5.0, released 2021-08-10

- [Commit 28e502a](https://github.com/googleapis/google-cloud-dotnet/commit/28e502a): feat: allow updating security group on existing clusters

## Version 2.4.0, released 2021-06-22

- [Commit 10470bb](https://github.com/googleapis/google-cloud-dotnet/commit/10470bb): feat: support for NodeAutoprovisioning ImageType

## Version 2.3.0, released 2021-05-25

- [Commit 3717e0d](https://github.com/googleapis/google-cloud-dotnet/commit/3717e0d): Regenerate all APIs with generator change for deprecation

## Version 2.2.0, released 2020-11-19

- [Commit 3a8598f](https://github.com/googleapis/google-cloud-dotnet/commit/3a8598f):
  - fix: deprecate SetLocations; use UpdateCluster
  - refactor: provide name alias for GetOperation (as method signature annotation)
  - feat: support for GetJSONWebKeys
  - feat: support for Workload Identity
  - feat: support for Gvisor in nodes
  - feat: support for node reservation affinity
  - feat: support for Customer Managed Encryption in nodes
  - fix: deprecate basic auth fields (removed in 1.19 clusters)
  - feat: support for NodeLocalDNS
  - feat: support for ConfigConnector
  - feat: support for private cluster VPC peering
  - feat: support for CloudRun load balancers
  - feat: support using routes for pod IPs
  - feat: support for Shielded Nodes
  - feat: support for release channels
  - fix: deprecated Cluster/NodePool.status_message; use conditions
  - feat: support for disabling default sNAT
  - feat: operations now store more granular progress
  - feat: support for node Surge Upgrades
  - feat: support for updating node pool locations.
  - feat: support for Node Auto Provisioning
  - feat: support for specifying node disk size and type
  - docs: many minor documentation clarifications

## Version 2.1.0, released 2020-10-14

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs with out retry
- [Commit fba52f0](https://github.com/googleapis/google-cloud-dotnet/commit/fba52f0): docs: Fixed broken links in the reference documentation
- [Commit 81c1d97](https://github.com/googleapis/google-cloud-dotnet/commit/81c1d97): docs: fix a broken link in the docs.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit dfe20a4](https://github.com/googleapis/google-cloud-dotnet/commit/dfe20a4): docs: display resource name patterns in code font.

## Version 2.0.0, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.1.0, released 2019-12-09

- Some retry settings are now obsolete, and will be removed in the next major version
- Added support for many cluster options
- Added ListUsableSubnetworks methods

## Version 1.0.0, released 2019-07-10

Initial GA release.
