# Version history

# Version 2.4.0, released 2021-06-22

- [Commit 10470bb](https://github.com/googleapis/google-cloud-dotnet/commit/10470bb): feat: support for NodeAutoprovisioning ImageType

# Version 2.3.0, released 2021-05-25

- [Commit 3717e0d](https://github.com/googleapis/google-cloud-dotnet/commit/3717e0d): Regenerate all APIs with generator change for deprecation

# Version 2.2.0, released 2020-11-19

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

# Version 2.1.0, released 2020-10-14

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs with out retry
- [Commit fba52f0](https://github.com/googleapis/google-cloud-dotnet/commit/fba52f0): docs: Fixed broken links in the reference documentation
- [Commit 81c1d97](https://github.com/googleapis/google-cloud-dotnet/commit/81c1d97): docs: fix a broken link in the docs.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit dfe20a4](https://github.com/googleapis/google-cloud-dotnet/commit/dfe20a4): docs: display resource name patterns in code font.

# Version 2.0.0, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

# Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

# Version 1.1.0, released 2019-12-09

- Some retry settings are now obsolete, and will be removed in the next major version
- Added support for many cluster options
- Added ListUsableSubnetworks methods

# Version 1.0.0, released 2019-07-10

Initial GA release.
