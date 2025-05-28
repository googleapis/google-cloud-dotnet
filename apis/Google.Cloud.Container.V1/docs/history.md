# Version history

## Version 3.34.0, released 2025-05-28

### New features

- Add topology_manager in NodeKubeletConfig
- Add image_gc_low_threshold_percent in NodeKubeletConfig
- Add image_gc_high_threshold_percent in NodeKubeletConfig
- Add image_minimum_gc_age in NodeKubeletConfig
- Add image_maximum_gc_age in NodeKubeletConfig
- Add container_log_max_size in NodeKubeletConfig
- Add container_log_max_files in NodeKubeletConfig
- Add allowed_unsafe_sysctls in NodeKubeletConfig
- Add max_run_duration in NodeConfig
- Add flex_start in NodeConfig
- Add performance_monitoring_unit in AdvancedMachineFeatures
- Add high_scale_checkpointing_config in AddonsConfig
- Add alpha_cluster_feature_gates in Cluster
- Add pod_autoscaling in Cluster
- Add desired_pod_autoscaling in ClusterUpdate
- Add desired_disable_l4_lb_firewall_reconciliation in ClusterUpdate
- Add desired_anonymous_authentication_config in ClusterUpdate
- Add max_run_duration in UpdateNodePoolRequest
- Add flex_start in UpdateNodePoolRequest
- Add NODE_SERVICE_ACCOUNT_MISSING_PERMISSIONS in StatusCondition.Code
- Add disable_l4_lb_firewall_reconciliation in NetworkConfig
- Add UPGRADE_INFO_EVENT in NotificationConfig.EventType
- Add confidential_instance_type in ConfidentialNodes
- Add event_type in UpgradeInfoEvent
- Add standard_support_end_time in UpgradeInfoEvent
- Add extended_support_end_time in UpgradeInfoEvent
- Add mitigated_versions in SecurityBulletinEvent
- Add autopilot_compatibility_auditing_enabled in WorkloadPolicyConfig
- Add KCP_HPA in LoggingComponentConfig.Component
- Add JOBSET in MonitoringComponentConfig.Component
- Add auto_monitoring_config in ManagedPrometheusConfig
- Add data_cache_count in EphemeralStorageLocalSsdConfig
- Add FetchClusterUpgradeInfoRequest
- Add ClusterUpgradeInfo
- Add UpgradeDetails
- Add FetchNodePoolUpgradeInfoRequest
- Add NodePoolUpgradeInfo

### Documentation improvements

- Minor documentation updates
- Broken (or ambiguous) markdown link

## Version 3.33.0, released 2024-11-18

### New features

- Add LocalSsdEncryptionMode in NodeConfig ([commit c51e9ee](https://github.com/googleapis/google-cloud-dotnet/commit/c51e9eef33ccad6b436c839c85ba2d9e220f6ce0))
- Add LinuxNodeConfig in NodePoolAutoConfig ([commit c51e9ee](https://github.com/googleapis/google-cloud-dotnet/commit/c51e9eef33ccad6b436c839c85ba2d9e220f6ce0))
- Add DesiredEnterpriseConfig proto message ([commit c51e9ee](https://github.com/googleapis/google-cloud-dotnet/commit/c51e9eef33ccad6b436c839c85ba2d9e220f6ce0))
- Add desired_enterprise_config,desired_node_pool_auto_config_linux_node_config to ClusterUpdate. ([commit c51e9ee](https://github.com/googleapis/google-cloud-dotnet/commit/c51e9eef33ccad6b436c839c85ba2d9e220f6ce0))
- Add UpgradeInfoEvent proto message ([commit c51e9ee](https://github.com/googleapis/google-cloud-dotnet/commit/c51e9eef33ccad6b436c839c85ba2d9e220f6ce0))
- Add desired_tier to EnterpriseConfig. ([commit c51e9ee](https://github.com/googleapis/google-cloud-dotnet/commit/c51e9eef33ccad6b436c839c85ba2d9e220f6ce0))

### Documentation improvements

- Minor documentation updates ([commit c51e9ee](https://github.com/googleapis/google-cloud-dotnet/commit/c51e9eef33ccad6b436c839c85ba2d9e220f6ce0))

## Version 3.32.0, released 2024-10-14

### New features

- Add an effective_cgroup_mode field in node config ([commit e84c6d7](https://github.com/googleapis/google-cloud-dotnet/commit/e84c6d77e282a2286b373eb88288d501e8f2517c))
- Add storage pools field to NodePool API ([commit e84c6d7](https://github.com/googleapis/google-cloud-dotnet/commit/e84c6d77e282a2286b373eb88288d501e8f2517c))
- Add ControlPlaneEndpointsConfig message to consolidate control plane isolation options ([commit e84c6d7](https://github.com/googleapis/google-cloud-dotnet/commit/e84c6d77e282a2286b373eb88288d501e8f2517c))
- Add DNSEndpointConfig for new DNS-based control plane access ([commit e84c6d7](https://github.com/googleapis/google-cloud-dotnet/commit/e84c6d77e282a2286b373eb88288d501e8f2517c))
- Add API to enable/disable secret manager csi component on GKE clusters ([commit e84c6d7](https://github.com/googleapis/google-cloud-dotnet/commit/e84c6d77e282a2286b373eb88288d501e8f2517c))
- Add CompliancePosture field for configuration of GKE Compliance Posture product ([commit e84c6d7](https://github.com/googleapis/google-cloud-dotnet/commit/e84c6d77e282a2286b373eb88288d501e8f2517c))
- Add RBACBindingConfig to API ([commit e84c6d7](https://github.com/googleapis/google-cloud-dotnet/commit/e84c6d77e282a2286b373eb88288d501e8f2517c))
- Add CompliancePosture field for configuration of GKE Compliance Posture product ([commit e84c6d7](https://github.com/googleapis/google-cloud-dotnet/commit/e84c6d77e282a2286b373eb88288d501e8f2517c))
- Add KCP_SSHD and KCP_CONNECTION to the supported values for the --logging flag for the create and update cluster commands ([commit e84c6d7](https://github.com/googleapis/google-cloud-dotnet/commit/e84c6d77e282a2286b373eb88288d501e8f2517c))
- Surface upgrade_target_version in GetServerConfig for all supported release channels ([commit e84c6d7](https://github.com/googleapis/google-cloud-dotnet/commit/e84c6d77e282a2286b373eb88288d501e8f2517c))
- Added support for Parallelstore CSI Driver ([commit e84c6d7](https://github.com/googleapis/google-cloud-dotnet/commit/e84c6d77e282a2286b373eb88288d501e8f2517c))

### Documentation improvements

- Minor documentation updates ([commit e84c6d7](https://github.com/googleapis/google-cloud-dotnet/commit/e84c6d77e282a2286b373eb88288d501e8f2517c))

## Version 3.31.0, released 2024-09-09

### New features

- Add ReleaseChannel EXTENDED value ([commit 4224abe](https://github.com/googleapis/google-cloud-dotnet/commit/4224abe8f61f1a0d8cf154b15841f4190099f7da))

### Documentation improvements

- Minor updates to reference documentation ([commit 863421b](https://github.com/googleapis/google-cloud-dotnet/commit/863421b016199052dae2363577079bb5cadf09c2))

## Version 3.30.0, released 2024-07-22

### Bug fixes

- Deprecate "EXPERIMENTAL" option for Gateway API (this value has never been supported) ([commit 5b1d67c](https://github.com/googleapis/google-cloud-dotnet/commit/5b1d67c6816af885dbfe25073209c070e1667db1))

### New features

- Support for Ray Clusters ([commit 6f0ee61](https://github.com/googleapis/google-cloud-dotnet/commit/6f0ee612c091c819c8313fc1b7ac2724fd416885))
- Add DCGM enum in monitoring config ([commit 5b1d67c](https://github.com/googleapis/google-cloud-dotnet/commit/5b1d67c6816af885dbfe25073209c070e1667db1))

### Documentation improvements

- Trivial updates ([commit 6f0ee61](https://github.com/googleapis/google-cloud-dotnet/commit/6f0ee612c091c819c8313fc1b7ac2724fd416885))

## Version 3.29.0, released 2024-06-24

### New features

- Enable REST transport for google/container/v1 ([commit 198c8c6](https://github.com/googleapis/google-cloud-dotnet/commit/198c8c65d3b7142ddacf671789521c37f62dd721))

## Version 3.28.0, released 2024-06-10

### New features

- A new message `HugepagesConfig` is added ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `hugepages` is added to message `.google.container.v1.LinuxNodeConfig` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `containerd_config` is added to message `.google.container.v1.NodeConfig` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `enable_nested_virtualization` is added to message `.google.container.v1.AdvancedMachineFeatures` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new message `ContainerdConfig` is added ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `satisfies_pzs` is added to message `.google.container.v1.Cluster` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `satisfies_pzi` is added to message `.google.container.v1.Cluster` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new value `ENTERPRISE` is added to enum `Mode` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `node_kubelet_config` is added to message `.google.container.v1.NodePoolAutoConfig` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `containerd_config` is added to message `.google.container.v1.NodeConfigDefaults` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `node_kubelet_config` is added to message `.google.container.v1.NodeConfigDefaults` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `desired_containerd_config` is added to message `.google.container.v1.ClusterUpdate` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `desired_node_kubelet_config` is added to message `.google.container.v1.ClusterUpdate` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `desired_node_pool_auto_config_kubelet_config` is added to message `.google.container.v1.ClusterUpdate` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `accelerators` is added to message `.google.container.v1.UpdateNodePoolRequest` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `containerd_config` is added to message `.google.container.v1.UpdateNodePoolRequest` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new value `MPS` is added to enum `GPUSharingStrategy` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new field `additive_vpc_scope_dns_domain` is added to message `.google.container.v1.DNSConfig` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new value `CADVISOR` is added to enum `Component` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new value `KUBELET` is added to enum `Component` ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A new method_signature `parent` is added to method `ListOperations` in service `ClusterManager` ([commit caf8bb6](https://github.com/googleapis/google-cloud-dotnet/commit/caf8bb6d68e4edda758a38e9970558f6e5a27225))

### Documentation improvements

- A comment for field `desired_private_cluster_config` in message `.google.container.v1.ClusterUpdate` is changed ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))
- A comment for field `in_transit_encryption_config` in message `.google.container.v1.NetworkConfig` is changed ([commit ea40436](https://github.com/googleapis/google-cloud-dotnet/commit/ea40436c66cc0917dd68e8a61f967dadbf689001))

## Version 3.27.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 3.26.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.25.0, released 2024-03-27

### New features

- Add several fields to manage state of database encryption update ([commit 98c684c](https://github.com/googleapis/google-cloud-dotnet/commit/98c684ca1ae5cbf12945d64ff884139755c6df77))

## Version 3.24.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))
- Add optional secondary_boot_disk_update_strategy field to NodePool API ([commit 0ad229c](https://github.com/googleapis/google-cloud-dotnet/commit/0ad229ca2762b397839871dbc12762e86a338a7b))
- Allow existing clusters to enable multi-networking ([commit 0ad229c](https://github.com/googleapis/google-cloud-dotnet/commit/0ad229ca2762b397839871dbc12762e86a338a7b))

## Version 3.23.0, released 2024-03-21

### New features

- Add API to enable/disable secret manager csi component on GKE clusters ([commit caeb6be](https://github.com/googleapis/google-cloud-dotnet/commit/caeb6be38fa69608c26e48a91bc9e0884a21b4a6))
- Add secondary boot disks field to NodePool API ([commit a48dfdc](https://github.com/googleapis/google-cloud-dotnet/commit/a48dfdcfbe195846f236a3f562551180ad708cd5))

## Version 3.22.0, released 2024-02-27

### New features

- Add API to enable Provisioning Request API on existing nodepools ([commit 01d881e](https://github.com/googleapis/google-cloud-dotnet/commit/01d881eabb489af5bdb0f0fa88da1b11827000ea))
- Promoted enable_confidential_storage to GA (behind allowlist) ([commit 01d881e](https://github.com/googleapis/google-cloud-dotnet/commit/01d881eabb489af5bdb0f0fa88da1b11827000ea))

## Version 3.21.0, released 2024-02-08

### New features

- Added configuration for the StatefulHA addon to the AddonsConfig ([commit 8372d78](https://github.com/googleapis/google-cloud-dotnet/commit/8372d78ce1752529bcb1e98a6a9f801f20f18929))
- Add fields desired_in_transit_encryption_config and in_transit_encryption_config ([commit 3995d17](https://github.com/googleapis/google-cloud-dotnet/commit/3995d1733e2d50c0a72826988b3f102e8b9c41ba))

### Documentation improvements

- Remove Not GA comments for GetOpenIDConfig and GetJSONWebKeys in v1alpha1/v1beta1/v1 ([commit 3995d17](https://github.com/googleapis/google-cloud-dotnet/commit/3995d1733e2d50c0a72826988b3f102e8b9c41ba))

## Version 3.20.0, released 2023-12-04

### New features

- Add enable_relay field to advanced_datapath_observability_config ([commit f986a27](https://github.com/googleapis/google-cloud-dotnet/commit/f986a278ad02e845461a3e4ce3a117ccde289cf1))
- Enable Enterprise Flag to allow configuring Advanced Vuln Insights ([commit f986a27](https://github.com/googleapis/google-cloud-dotnet/commit/f986a278ad02e845461a3e4ce3a117ccde289cf1))
- Add Provisioning Request API ([commit be2bfbd](https://github.com/googleapis/google-cloud-dotnet/commit/be2bfbdffcd33b0c045ffe3f7edd9bb25b33a69d))

## Version 3.19.0, released 2023-11-07

### New features

- Added EnterpriseConfig ([commit 1b8f34d](https://github.com/googleapis/google-cloud-dotnet/commit/1b8f34d75719dd07a01fd491bbd586074399b168))
- Add a new cluster field for the cluster tier of GKE clusters ([commit 1b8f34d](https://github.com/googleapis/google-cloud-dotnet/commit/1b8f34d75719dd07a01fd491bbd586074399b168))
- Add ResourceManagerTags API to attach tags on the underlying Compute Engine VMs of GKE Nodes which can be used to selectively enforce Cloud Firewall network firewall policies ([commit bae6344](https://github.com/googleapis/google-cloud-dotnet/commit/bae634446d206a97a5c25801c938427ffc963175))
- Add CompleteConvertToAutopilot API to commit Autopilot conversion operation ([commit bae6344](https://github.com/googleapis/google-cloud-dotnet/commit/bae634446d206a97a5c25801c938427ffc963175))

### Documentation improvements

- Updated comments ([commit bae6344](https://github.com/googleapis/google-cloud-dotnet/commit/bae634446d206a97a5c25801c938427ffc963175))

## Version 3.18.0, released 2023-09-04

### New features

- Add support for NodeConfig Update ([commit d5f12a7](https://github.com/googleapis/google-cloud-dotnet/commit/d5f12a7b8d70a2d7cbcef3a349c44e77751b58e6))
- Publicize tpu topology in v1 API ([commit d5f12a7](https://github.com/googleapis/google-cloud-dotnet/commit/d5f12a7b8d70a2d7cbcef3a349c44e77751b58e6))

## Version 3.17.0, released 2023-08-16

### New features

- Add APIs for GKE OOTB metrics packages ([commit 9af1a07](https://github.com/googleapis/google-cloud-dotnet/commit/9af1a07147666f6638e74b948ec8fbeae2016dfd))

## Version 3.16.0, released 2023-08-04

### New features

- Add Multi-networking API ([commit 2f08555](https://github.com/googleapis/google-cloud-dotnet/commit/2f0855553815527f505e11e48f5bb354b28ae7ce))
- Add policy_name to PlacementPolicy message within a node pool ([commit 2f08555](https://github.com/googleapis/google-cloud-dotnet/commit/2f0855553815527f505e11e48f5bb354b28ae7ce))

## Version 3.15.0, released 2023-07-13

### New features

- Add advanced_datapath_observability_config to monitoring_config ([commit 00a826c](https://github.com/googleapis/google-cloud-dotnet/commit/00a826c3d23b9312dc5ca83ee8feae666d3958be))
- Add a Pod IP Utilization API ([commit 00a826c](https://github.com/googleapis/google-cloud-dotnet/commit/00a826c3d23b9312dc5ca83ee8feae666d3958be))
- Add `KUBE_DNS` option to `DNSConfig.cluster_dns` ([commit 2d109b3](https://github.com/googleapis/google-cloud-dotnet/commit/2d109b3edbdda52bd356775ebabdf9edb9291e93))
- Add Tier 1 cluster-level API network_performance_config ([commit 2d109b3](https://github.com/googleapis/google-cloud-dotnet/commit/2d109b3edbdda52bd356775ebabdf9edb9291e93))

## Version 3.14.0, released 2023-06-20

### New features

- Add API for GPU driver installation config ([commit 4d795dd](https://github.com/googleapis/google-cloud-dotnet/commit/4d795dd1790399b7860b481cc66f66b8a7db80e8))
- Add SecurityPostureConfig API field to allow customers to enable GKE Security Posture capabilities for their clusters ([commit 4d795dd](https://github.com/googleapis/google-cloud-dotnet/commit/4d795dd1790399b7860b481cc66f66b8a7db80e8))
- Add workloadPolicyConfig API field to allow customer enable NET_ADMIN capability for their autopilot clusters ([commit 4d795dd](https://github.com/googleapis/google-cloud-dotnet/commit/4d795dd1790399b7860b481cc66f66b8a7db80e8))
- Add a API field to enable FQDN Network Policy on clusters ([commit a694180](https://github.com/googleapis/google-cloud-dotnet/commit/a694180792ddf8433c67d830e90c204f0422d8ba))
- Turn on public visibility for best effort provision ([commit a694180](https://github.com/googleapis/google-cloud-dotnet/commit/a694180792ddf8433c67d830e90c204f0422d8ba))
- Add CheckAutopilotCompatibility API to get autopilot compatibility issues for a given standard cluster ([commit a694180](https://github.com/googleapis/google-cloud-dotnet/commit/a694180792ddf8433c67d830e90c204f0422d8ba))

## Version 3.13.0, released 2023-06-05

### New features

- Add SoleTenantConfig API ([commit bdcd865](https://github.com/googleapis/google-cloud-dotnet/commit/bdcd8652db405d069f3541d15ae0c07f451ead90))

### Documentation improvements

- Clarified release channel defaulting behavior for create cluster requests when release channel is unspecified ([commit 8f6305d](https://github.com/googleapis/google-cloud-dotnet/commit/8f6305d0207d7b6119b1eaa28473b68f43ef34a9))

## Version 3.12.0, released 2023-05-11

### New features

- Support fleet registration via cluster update ([commit 05ac8bc](https://github.com/googleapis/google-cloud-dotnet/commit/05ac8bccb4f3cf68327f7e2c84d83321f71edd76))

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
