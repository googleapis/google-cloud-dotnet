# Version history

## Version 2.0.0-beta08, released 2025-05-22

### New features

- A new field `use_streaming_engine_resource_based_billing` is added to message `.google.dataflow.v1beta3.Environment`
- A new field `streaming_mode` is added to message `.google.dataflow.v1beta3.Environment`
- A new message `DataSamplingConfig` is added
- A new field `data_sampling` is added to message `.google.dataflow.v1beta3.DebugOptions`
- A new enum `StreamingMode` is added
- A new method_signature `job,update_mask` is added to method `UpdateJob` in service `JobsV1Beta3`
- A new field `runtime_updatable_params` is added to message `.google.dataflow.v1beta3.Job`
- A new field `satisfies_pzi` is added to message `.google.dataflow.v1beta3.Job`
- A new field `service_resources` is added to message `.google.dataflow.v1beta3.Job`
- A new message `ServiceResources` is added
- A new message `RuntimeUpdatableParams` is added
- A new field `bugs` is added to message `.google.dataflow.v1beta3.SdkVersion`
- A new message `SdkBug` is added
- A new field `user_display_properties` is added to message `.google.dataflow.v1beta3.JobMetadata`
- A new field `step_names_hash` is added to message `.google.dataflow.v1beta3.PipelineDescription`
- A new field `update_mask` is added to message `.google.dataflow.v1beta3.UpdateJobRequest`
- A new field `name` is added to message `.google.dataflow.v1beta3.ListJobsRequest`
- A new field `trie` is added to message `.google.dataflow.v1beta3.MetricUpdate`
- A new message `StragglerInfo` is added
- A new message `StreamingStragglerInfo` is added
- A new message `Straggler` is added
- A new message `HotKeyDebuggingInfo` is added
- A new message `StragglerSummary` is added
- A new field `straggler_summary` is added to message `.google.dataflow.v1beta3.StageSummary`
- A new field `straggler_info` is added to message `.google.dataflow.v1beta3.WorkItemDetails`
- A new field `dynamic_destinations` is added to message `.google.dataflow.v1beta3.PubsubLocation`
- A new field `image_repository_username_secret_id` is added to message `.google.dataflow.v1beta3.ContainerSpec`
- A new field `image_repository_password_secret_id` is added to message `.google.dataflow.v1beta3.ContainerSpec`
- A new field `image_repository_cert_path` is added to message `.google.dataflow.v1beta3.ContainerSpec`
- A new field `enable_launcher_vm_serial_port_logging` is added to message `.google.dataflow.v1beta3.FlexTemplateRuntimeEnvironment`
- A new field `streaming_mode` is added to message `.google.dataflow.v1beta3.FlexTemplateRuntimeEnvironment`
- A new field `disk_size_gb` is added to message `.google.dataflow.v1beta3.RuntimeEnvironment`
- A new field `streaming_mode` is added to message `.google.dataflow.v1beta3.RuntimeEnvironment`
- A new message `ParameterMetadataEnumOption` is added
- A new field `group_name` is added to message `.google.dataflow.v1beta3.ParameterMetadata`
- A new field `parent_name` is added to message `.google.dataflow.v1beta3.ParameterMetadata`
- A new field `parent_trigger_values` is added to message `.google.dataflow.v1beta3.ParameterMetadata`
- A new field `enum_options` is added to message `.google.dataflow.v1beta3.ParameterMetadata`
- A new field `default_value` is added to message `.google.dataflow.v1beta3.ParameterMetadata`
- A new field `hidden_ui` is added to message `.google.dataflow.v1beta3.ParameterMetadata`
- A new field `streaming` is added to message `.google.dataflow.v1beta3.TemplateMetadata`
- A new field `supports_at_least_once` is added to message `.google.dataflow.v1beta3.TemplateMetadata`
- A new field `supports_exactly_once` is added to message `.google.dataflow.v1beta3.TemplateMetadata`
- A new field `default_streaming_mode` is added to message `.google.dataflow.v1beta3.TemplateMetadata`
- A new value `GO` is added to enum `Language`
- A new value `BIGQUERY_TABLE` is added to enum `ParameterType`
- A new value `JAVASCRIPT_UDF_FILE` is added to enum `ParameterType`
- A new value `SERVICE_ACCOUNT` is added to enum `ParameterType`
- A new value `MACHINE_TYPE` is added to enum `ParameterType`
- A new value `KMS_KEY_NAME` is added to enum `ParameterType`
- A new value `WORKER_REGION` is added to enum `ParameterType`
- A new value `WORKER_ZONE` is added to enum `ParameterType`
- A new value `BOOLEAN` is added to enum `ParameterType`
- A new value `ENUM` is added to enum `ParameterType`
- A new value `NUMBER` is added to enum `ParameterType`
- A new value `KAFKA_TOPIC` is added to enum `ParameterType`
- A new value `KAFKA_READ_TOPIC` is added to enum `ParameterType`
- A new value `KAFKA_WRITE_TOPIC` is added to enum `ParameterType`

### Bug fixes

- An existing oauth_scope `https://www.googleapis.com/auth/compute.readonly` is removed from service `JobsV1Beta3`
- An existing oauth_scope `https://www.googleapis.com/auth/userinfo.email` is removed from service `JobsV1Beta3`
- An existing oauth_scope `https://www.googleapis.com/auth/compute.readonly` is removed from service `MessagesV1Beta3`
- An existing oauth_scope `https://www.googleapis.com/auth/userinfo.email` is removed from service `MessagesV1Beta3`
- An existing oauth_scope `https://www.googleapis.com/auth/compute.readonly` is removed from service `MetricsV1Beta3`
- An existing oauth_scope `https://www.googleapis.com/auth/userinfo.email` is removed from service `MetricsV1Beta3`
- An existing oauth_scope `https://www.googleapis.com/auth/compute.readonly` is removed from service `SnapshotsV1Beta3`
- An existing oauth_scope `https://www.googleapis.com/auth/userinfo.email` is removed from service `SnapshotsV1Beta3`
- An existing oauth_scope `https://www.googleapis.com/auth/compute.readonly` is removed from service `TemplatesService`
- An existing oauth_scope `https://www.googleapis.com/auth/userinfo.email` is removed from service `TemplatesService`
- An existing oauth_scope `https://www.googleapis.com/auth/compute.readonly` is removed from service `FlexTemplatesService`
- An existing oauth_scope `https://www.googleapis.com/auth/userinfo.email` is removed from service `FlexTemplatesService

### Documentation improvements

- A comment for field `service_options` in message `.google.dataflow.v1beta3.Environment` is changed
- A comment for field `service_kms_key_name` in message `.google.dataflow.v1beta3.Environment` is changed
- A comment for field `dataset` in message `.google.dataflow.v1beta3.Environment` is changed
- A comment for field `service_account_email` in message `.google.dataflow.v1beta3.Environment` is changed
- A comment for field `flex_resource_scheduling_goal` in message `.google.dataflow.v1beta3.Environment` is changed
- A comment for field `worker_region` in message `.google.dataflow.v1beta3.Environment` is changed
- A comment for field `worker_zone` in message `.google.dataflow.v1beta3.Environment` is changed
- A comment for field `debug_options` in message `.google.dataflow.v1beta3.Environment` is changed
- A comment for enum `WorkerIPAddressConfiguration` is changed
- A comment for message `SdkHarnessContainerImage` is changed
- A comment for field `capabilities` in message `.google.dataflow.v1beta3.SdkHarnessContainerImage` is changed
- A comment for field `enable_hot_key_logging` in message `.google.dataflow.v1beta3.DebugOptions` is changed
- A comment for method `CreateJob` in service `JobsV1Beta3` is changed
- A comment for method `ListJobs` in service `JobsV1Beta3` is changed
- A comment for method `AggregatedListJobs` in service `JobsV1Beta3` is changed
- A comment for message `Job` is changed
- A comment for field `id` in message `.google.dataflow.v1beta3.Job` is changed
- A comment for field `project_id` in message `.google.dataflow.v1beta3.Job` is changed
- A comment for field `name` in message `.google.dataflow.v1beta3.Job` is changed
- A comment for field `type` in message `.google.dataflow.v1beta3.Job` is changed
- A comment for field `environment` in message `.google.dataflow.v1beta3.Job` is changed
- A comment for field `current_state` in message `.google.dataflow.v1beta3.Job` is changed
- A comment for field `requested_state` in message `.google.dataflow.v1beta3.Job` is changed
- A comment for field `transform_name_mapping` in message `.google.dataflow.v1beta3.Job` is changed
- A comment for field `location` in message `.google.dataflow.v1beta3.Job` is changed
- A comment for message `Step` is changed
- A comment for enum `JobState` is changed
- A comment for message `JobExecutionStageInfo` is changed
- A comment for enum value `JOB_VIEW_ALL` in enum `JobView` is changed
- A comment for message `MetricUpdate` is changed
- A comment for field `set` in message `.google.dataflow.v1beta3.MetricUpdate` is changed
- A comment for message `JobMetrics` is changed
- A comment for method `CreateJobFromTemplate` in service `TemplatesService` is changed
- A comment for method `LaunchTemplate` in service `TemplatesService` is changed
- A comment for method `GetTemplate` in service `TemplatesService` is changed
- A comment for service `FlexTemplatesService` is changed
- A comment for field `dump_heap_on_oom` in message `.google.dataflow.v1beta3.FlexTemplateRuntimeEnvironment` is changed
- A comment for field `save_heap_dumps_to_gcs_path` in message `.google.dataflow.v1beta3.FlexTemplateRuntimeEnvironment` is changed
- A comment for field `num_workers` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `max_workers` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `zone` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `service_account_email` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `temp_location` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `bypass_temp_dir_validation` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `machine_type` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `additional_experiments` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `network` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `subnetwork` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `additional_user_labels` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `kms_key_name` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `ip_configuration` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `worker_region` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `worker_zone` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for field `enable_streaming_engine` in message `.google.dataflow.v1beta3.RuntimeEnvironment` is changed
- A comment for message `LaunchTemplateParameters` is changed
- A comment for field `job_name` in message `.google.dataflow.v1beta3.LaunchTemplateParameters` is changed
- A comment for field `gcs_path` in message `.google.dataflow.v1beta3.LaunchTemplateRequest` is changed
- A comment for field `dynamic_template` in message `.google.dataflow.v1beta3.LaunchTemplateRequest` is changed
- A comment for field `launch_parameters` in message `.google.dataflow.v1beta3.LaunchTemplateRequest` is changed
- A comment for message `DynamicTemplateLaunchParams` is changed
- A comment for field `gcs_path` in message `.google.dataflow.v1beta3.DynamicTemplateLaunchParams` is changed

## Version 2.0.0-beta07, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-beta06, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-beta05, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.0.0-beta04, released 2023-01-30

No API surface changes; just dependency updates. However, the
dependency update to GAX 4.3.1 fixes [issue
9396](https://github.com/googleapis/google-cloud-dotnet/issues/9396).

## Version 2.0.0-beta03, released 2023-01-17

### New features

- Enable REST transport in C# ([commit cdb518c](https://github.com/googleapis/google-cloud-dotnet/commit/cdb518c3524106ea73f0e546557a0180589ca3b0))

## Version 2.0.0-beta02, released 2022-07-11

### Documentation improvements

- Corrected the Dataflow job name regex ([commit 7501e60](https://github.com/googleapis/google-cloud-dotnet/commit/7501e6036aad008e6021fd7968730223a3bb6bc3))

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
## Version 1.0.0-beta03, released 2022-03-28

### Bug fixes

- Added google.api.http annotations to RPCs. Fixes [issue 7038](https://github.com/googleapis/google-cloud-dotnet/issues/7038). ([commit 7e6edad](https://github.com/googleapis/google-cloud-dotnet/commit/7e6edad1653324684e07186c859ee4b7c41ebea5))

### New features

- Add the ability to plumb environment capabilities through v1beta3 protos. ([commit f703fba](https://github.com/googleapis/google-cloud-dotnet/commit/f703fba5ac47cef0badc2248c5a41088ca49dd5e))
- New parameters in FlexTemplateRuntimeEnvironment ([commit 7e6edad](https://github.com/googleapis/google-cloud-dotnet/commit/7e6edad1653324684e07186c859ee4b7c41ebea5))

## Version 1.0.0-beta02, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta01, released 2021-06-23

Initial release.
