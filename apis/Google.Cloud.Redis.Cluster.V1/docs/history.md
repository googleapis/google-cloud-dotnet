# Version history

## Version 1.4.0, released 2025-01-27

### Bug fixes

- Changed field behavior for an existing field `psc_connection_id` in message `.google.cloud.redis.cluster.v1beta1.PscConnection` ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- Changed field behavior for an existing field `address` in message `.google.cloud.redis.cluster.v1beta1.PscConnection` ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- Changed field behavior for an existing field `forwarding_rule` in message `.google.cloud.redis.cluster.v1beta1.PscConnection` ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- Changed field behavior for an existing field `network` in message `.google.cloud.redis.cluster.v1beta1.PscConnection` ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))

### New features

- [Memorystore for Redis Cluster] Added support for maintenance window and rescheduling maintenance ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- [Memorystore for Redis Cluster] Added support for Backups and Backup Collections ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- [Memorystore for Redis Cluster] Added support for Multiple VPCs ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- [Memorystore for Redis Cluster] Added support for Cross Cluster Replication ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- [Memorystore for Redis Cluster] Added support for CMEK ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- New REQUIRED field `service_attachment` in message `.google.cloud.redis.cluster.v1beta1.PscConnection` ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))

### Documentation improvements

- A comment for enum value `NODE_TYPE_UNSPECIFIED` in enum `NodeType` is changed ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- A comment for field `name` in message `.google.cloud.redis.cluster.v1beta1.Cluster` is changed ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- A comment for field `shard_count` in message `.google.cloud.redis.cluster.v1beta1.Cluster` is changed ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- A comment for field `psc_configs` in message `.google.cloud.redis.cluster.v1beta1.Cluster` is changed ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- A comment for field `psc_connections` in message `.google.cloud.redis.cluster.v1beta1.Cluster` is changed ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- A comment for field `psc_connection_id` in message `.google.cloud.redis.cluster.v1beta1.PscConnection` is changed ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- A comment for field `address` in message `.google.cloud.redis.cluster.v1beta1.PscConnection` is changed ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- A comment for field `forwarding_rule` in message `.google.cloud.redis.cluster.v1beta1.PscConnection` is changed ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- A comment for field `project_id` in message `.google.cloud.redis.cluster.v1beta1.PscConnection` is changed ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- A comment for field `network` in message `.google.cloud.redis.cluster.v1beta1.PscConnection` is changed ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))
- A comment for enum value `ALWAYS` in enum `AppendFsync` is changed ([commit 2a8e11c](https://github.com/googleapis/google-cloud-dotnet/commit/2a8e11cd93533b6f8c34072cc44ac1cfc68c8936))

## Version 1.3.0, released 2024-06-10

### New features

- [Memorystore for Redis Cluster] Add support for different node types ([commit 536acb5](https://github.com/googleapis/google-cloud-dotnet/commit/536acb56ba7e3f849aedba247d604707fcf841db))
- [Memorystore for Redis Cluster] Add persistence support ([commit 536acb5](https://github.com/googleapis/google-cloud-dotnet/commit/536acb56ba7e3f849aedba247d604707fcf841db))
- [Memorystore for Redis Cluster] Get details of certificate authority from redis cluster ([commit 536acb5](https://github.com/googleapis/google-cloud-dotnet/commit/536acb56ba7e3f849aedba247d604707fcf841db))

### Documentation improvements

- [Memorystore for Redis Cluster] size_gb field shows the size of the cluster rounded up to the next integer, precise_size_gb field will show the exact size of the cluster ([commit 536acb5](https://github.com/googleapis/google-cloud-dotnet/commit/536acb56ba7e3f849aedba247d604707fcf841db))

## Version 1.2.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.1.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.0.0, released 2024-03-12

No API surface changes; just promotion to GA.

## Version 1.0.0-beta02, released 2024-02-29

No API surface changes; just dependency updates.

## Version 1.0.0-beta01, released 2023-10-31

Initial release.
