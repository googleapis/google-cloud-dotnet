# Version history

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
