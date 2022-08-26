# Version history

## Version 2.3.0, released 2022-08-26

### New features

- Add read_mask to ListPipelineJobsRequest in aiplatform v1 pipeline_service ([commit 099522b](https://github.com/googleapis/google-cloud-dotnet/commit/099522b4f29dc941b522f23d9c32aadf6b4b7d63))
- Add input_artifacts to PipelineJob.runtime_config in aiplatform v1 pipeline_job ([commit 099522b](https://github.com/googleapis/google-cloud-dotnet/commit/099522b4f29dc941b522f23d9c32aadf6b4b7d63))
- Add UpsertDatapoints and RemoveDatapoints rpcs to IndexService in aiplatform v1 index_service.proto ([commit 592d099](https://github.com/googleapis/google-cloud-dotnet/commit/592d0997fa583f3741b60490fdd4cb131e5ac100))

## Version 2.2.0, released 2022-08-04

### New features

- Making network arg optional in aiplatform v1 custom_job.proto ([commit fbae4d8](https://github.com/googleapis/google-cloud-dotnet/commit/fbae4d8e9d39732ee2c570126f055171256121ba))
- Added SHARED_RESOURCES enum to aiplatform v1 model.proto ([commit fbae4d8](https://github.com/googleapis/google-cloud-dotnet/commit/fbae4d8e9d39732ee2c570126f055171256121ba))

### Documentation improvements

- Doc edits to aiplatform v1 dataset_service.proto, job_service.proto, model_service.proto, pipeline_service.proto, saved_query.proto, study.proto, types.proto ([commit fbae4d8](https://github.com/googleapis/google-cloud-dotnet/commit/fbae4d8e9d39732ee2c570126f055171256121ba))

## Version 2.1.0, released 2022-07-11

### New features

- Add ListSavedQueries rpc to aiplatform v1 dataset_service.proto ([commit 0ac2a25](https://github.com/googleapis/google-cloud-dotnet/commit/0ac2a258631c1925ae90cac40d4a371be3eebf13))
- Add saved_query.proto to aiplatform v1 ([commit 0ac2a25](https://github.com/googleapis/google-cloud-dotnet/commit/0ac2a258631c1925ae90cac40d4a371be3eebf13))
- Add saved_query_id to InputDataConfig in aiplatform v1 training_pipeline.proto ([commit 0ac2a25](https://github.com/googleapis/google-cloud-dotnet/commit/0ac2a258631c1925ae90cac40d4a371be3eebf13))
- Add BatchImportModelEvaluationSlices API in aiplatform v1 model_service.proto ([commit f742d07](https://github.com/googleapis/google-cloud-dotnet/commit/f742d07982cab375c0e81478f473e8e393c985dd))
- Add model_version_id to BatchPredictionJob in aiplatform v1 batch_prediction_job.proto ([commit 2b4568a](https://github.com/googleapis/google-cloud-dotnet/commit/2b4568ab92390c4e8bfaed567dcc831fe59d6641))
- Add model_version_id to DeployedModel in aiplatform v1 endpoint.proto ([commit 2b4568a](https://github.com/googleapis/google-cloud-dotnet/commit/2b4568ab92390c4e8bfaed567dcc831fe59d6641))
- Add model_version_id to PredictResponse in aiplatform v1 prediction_service.proto ([commit 2b4568a](https://github.com/googleapis/google-cloud-dotnet/commit/2b4568ab92390c4e8bfaed567dcc831fe59d6641))
- Add model_version_id to UploadModelResponse in aiplatform v1 model_service.proto ([commit c85aa57](https://github.com/googleapis/google-cloud-dotnet/commit/c85aa57f26f70d7fdb6877b4fa7a58f3bdf864fd))
- Add default_skew_threshold to TrainingPredictionSkewDetectionConfig in aiplatform v1beta1, v1 model_monitoring.proto ([commit 5e87a0c](https://github.com/googleapis/google-cloud-dotnet/commit/5e87a0c5da96ffa7bb5b9526d4b982705831c1a2))
- Add default_drift_threshold to PredictionDriftDetectionConfig in aiplatform v1beta1, v1 model_monitoring.proto ([commit 5e87a0c](https://github.com/googleapis/google-cloud-dotnet/commit/5e87a0c5da96ffa7bb5b9526d4b982705831c1a2))
- Add successful_forecast_point_count to CompletionStats in aiplatform v1 completion_stats.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add neighbors to Explanation in aiplatform v1 explanation.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add examples_override to ExplanationSpecOverride in aiplatform v1 explanation.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add version_id, version_aliases, version_create_time, version_update_time, and version_description to aiplatform v1 model.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add ModelVersion CRUD methods in aiplatform v1 model_service.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add model_id and parent_model to TrainingPipeline in aiplatform v1 training_pipeline.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))

## Version 2.0.0, released 2022-06-08

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

### New features also in this release

- Add monitor_window to ModelDeploymentMonitoringScheduleConfig proto in aiplatform v1/v1beta1 model_deployment_monitoring_job.proto ([commit 4a6d865](https://github.com/googleapis/google-cloud-dotnet/commit/4a6d865f55d52f480e4d5f792d0ff3bf0b68b620))
- Add failure_policy to PipelineJob in aiplatform v1 & v1beta1 pipeline_job.proto ([commit 660482a](https://github.com/googleapis/google-cloud-dotnet/commit/660482a467778c562889b98c382edfaded70446c))
- Add latent_space_source to ExplanationMetadata in aiplatform v1 explanation_metadata.proto ([commit ce1e55d](https://github.com/googleapis/google-cloud-dotnet/commit/ce1e55d51e8e8837f572b470001a6772db87ddab))
- Add scaling to OnlineServingConfig in aiplatform v1 featurestore.proto ([commit ce1e55d](https://github.com/googleapis/google-cloud-dotnet/commit/ce1e55d51e8e8837f572b470001a6772db87ddab))
- Add template_metadata to PipelineJob in aiplatform v1 pipeline_job.proto ([commit ce1e55d](https://github.com/googleapis/google-cloud-dotnet/commit/ce1e55d51e8e8837f572b470001a6772db87ddab))

## Version 1.8.0, released 2022-05-24

### New features

- Add display_name and metadata to ModelEvaluation in aiplatform model_evaluation.proto ([commit f3160c5](https://github.com/googleapis/google-cloud-dotnet/commit/f3160c58825803c39dcd24d73777caebd5d49481))
## Version 1.7.0, released 2022-04-26

### New features

- Add reserved_ip_ranges to CustomJobSpec in aiplatform v1 custom_job.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
- Add nfs_mounts to WorkPoolSpec in aiplatform v1 custom_job.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
- Add JOB_STATE_UPDATING to JobState in aiplatform v1 job_state.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
- Add MfsMount in aiplatform v1 machine_resources.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
- Add ConvexAutomatedStoppingSpec to StudySpec in aiplatform v1 study.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
## Version 1.6.0, released 2022-04-04

### New features

- Add ImportModelEvaluation in aiplatform v1 model_service.proto ([commit 9406420](https://github.com/googleapis/google-cloud-dotnet/commit/940642037b4217cf427e3042bf0e7de74abe1d37))
- Add data_item_schema_uri, annotation_schema_uri, explanation_specs to ModelEvaluationExplanationSpec in aiplatform v1 model_evaluation.proto ([commit 9406420](https://github.com/googleapis/google-cloud-dotnet/commit/940642037b4217cf427e3042bf0e7de74abe1d37))
- Add ImportModelEvaluation in aiplatform v1beta1 model_service.proto ([commit 9406420](https://github.com/googleapis/google-cloud-dotnet/commit/940642037b4217cf427e3042bf0e7de74abe1d37))

## Version 1.5.0, released 2022-03-14

### New features

- Add monitoring_config to EntityType in aiplatform v1 entity_type.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add disable_monitoring to Feature in aiplatform v1 feature.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add monitoring_stats_anomalies to Feature in aiplatform v1 feature.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add staleness_days to SnapshotAnalysis in aiplatform v1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add import_features_analysis to FeaturestoreMonitoringConfig in aiplatform v1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add numerical_threshold_config to FeaturestoreMonitoringConfig in aiplatform v1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add categorical_threshold_config to FeaturestoreMonitoringConfig in aiplatform v1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add objective to MonitoringStatsSpec in aiplatform v1 featurestore_service.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add disable_monitoring to Feature in aiplatform v1beta1 feature.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add monitoring_stats_anomalies to Feature in aiplatform v1beta1 feature.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add staleness_days to SnapshotAnalysis in aiplatform v1beta1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add import_features_analysis to FeaturestoreMonitoringConfig in aiplatform v1beta1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add numerical_threshold_config to FeaturestoreMonitoringConfig in aiplatform v1beta1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add categorical_threshold_config to FeaturestoreMonitoringConfig in aiplatform v1beta1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add objective to MonitoringStatsSpec in aiplatform v1beta1 featurestore_service.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add PredictRequestResponseLoggingConfig to Endpoint in aiplatform v1 endpoint.proto ([commit a3d6d2b](https://github.com/googleapis/google-cloud-dotnet/commit/a3d6d2b7af22f4a19e78435512861b6dab0b1a7d))

## Version 1.4.0, released 2022-02-28

### New features

- Add TPU_V2 & TPU_V3 values to AcceleratorType in aiplatform v1/v1beta1 accelerator_type.proto ([commit 354f7fd](https://github.com/googleapis/google-cloud-dotnet/commit/354f7fd84ba22d2eef391d63e633ef836bea54e9))

### Documentation improvements

- Fix misformatted field description ([commit 95bf8b9](https://github.com/googleapis/google-cloud-dotnet/commit/95bf8b971a5ebaf3e9c57b69139e6a3b2b69ce32))

## Version 1.3.0, released 2022-02-07

### New features

- Add dedicated_resources to DeployedIndex message in aiplatform v1 index_endpoint.proto ([commit 6be632d](https://github.com/googleapis/google-cloud-dotnet/commit/6be632d58049af3165675d56db2837c7d6b78a81))

## Version 1.2.0, released 2022-01-17

### New features

- Add enable_private_service_connect field to Endpoint ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add id field to DeployedModel ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add service_attachment field to PrivateEndpoints ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add endpoint_id to CreateEndpointRequest and method signature to CreateEndpoint ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add method signature to CreateFeatureStore, CreateEntityType, CreateFeature ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add network and enable_private_service_connect to IndexEndpoint ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add service_attachment to IndexPrivateEndpoints ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add stratified_split field to training_pipeline InputDataConfig ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))

## Version 1.1.0, released 2021-11-18

- [Commit 0d5a6b7](https://github.com/googleapis/google-cloud-dotnet/commit/0d5a6b7):
  - feat:Tensorboard v1 protos release
  - feat:Exposing a field for v1 CustomJob-Tensorboard integration.

## Version 1.0.0, released 2021-11-10

- [Commit 68f7900](https://github.com/googleapis/google-cloud-dotnet/commit/68f7900): feat: Adds support for `google.protobuf.Value` pipeline parameters in the `parameter_values` field

First GA release. Note that the dependencies on Google.Cloud.AutoML.V1 and Google.Cloud.DataLabeling.V1Beta1 have been removed in this release.

## Version 1.0.0-beta05, released 2021-10-20

- [Commit 43bcfc3](https://github.com/googleapis/google-cloud-dotnet/commit/43bcfc3):
  - feat: add featurestore service to aiplatform v1
  - feat: add metadata service to aiplatform v1
  - docs: fix typo in alert.proto

## Version 1.0.0-beta04, released 2021-09-24

- [Commit 656f5ca](https://github.com/googleapis/google-cloud-dotnet/commit/656f5ca): feat: add Vizier service to aiplatform v1
- [Commit cd4557f](https://github.com/googleapis/google-cloud-dotnet/commit/cd4557f): feat: add XAI, model monitoring, and index services to aiplatform v1

## Version 1.0.0-beta03, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta02, released 2021-08-09

- [Commit b950563](https://github.com/googleapis/google-cloud-dotnet/commit/b950563): feat!: Removes breaking change from v1 version of AI Platform protos
- [Commit 8ecff2b](https://github.com/googleapis/google-cloud-dotnet/commit/8ecff2b): feat!: Removes AcceleratorType.TPU_V2 and TPU_V3 constants feat: Adds AcceleratorType.NVIDIA_TESLA_A100 constant feat: Adds BigQuery output table field to batch prediction job output config feat: Adds JobState.JOB_STATE_EXPIRED constant feat: Adds AutoscalingMetricSpec message feat: Adds PipelineService methods: CreatePipelineJob, GetPipelineJob, ListPipelineJobs, DeletePipelineJobs, CancelPipelineJobs feat: Adds fields to Study message
- [Commit 50afb69](https://github.com/googleapis/google-cloud-dotnet/commit/50afb69): fix: Explicitly use Google.Protobuf.WellKnownTypes.Value in ValueConverter
- [Commit b123458](https://github.com/googleapis/google-cloud-dotnet/commit/b123458):
  - feat: Adds additional_experiments field to AutoMlTablesInputs
  - feat: Adds two new ModelType constants for Video Action Recognition training jobs

## Version 1.0.0-beta01, released 2021-06-28

Initial release.
