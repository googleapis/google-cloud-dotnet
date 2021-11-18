# Version history

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
