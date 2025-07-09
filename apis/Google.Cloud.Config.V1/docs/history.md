# Version history

## Version 1.8.0, released 2025-07-09

### New features

- Added resource change and drift details for the preview

### Documentation improvements

- A comment for field `name` in message `.google.cloud.config.v1.Deployment` is changed
- A comment for field `labels` in message `.google.cloud.config.v1.Deployment` is changed
- A comment for field `input_values` in message `.google.cloud.config.v1.TerraformBlueprint` is changed
- A comment for field `input_value` in message `.google.cloud.config.v1.TerraformVariable` is changed
- A comment for field `error` in message `.google.cloud.config.v1.TerraformError` is changed
- A comment for field `annotations` in message `.google.cloud.config.v1.Preview` is changed
- A comment for field `page_size` in message `.google.cloud.config.v1.ListTerraformVersionsRequest` is changed
- A comment for field `page_token` in message `.google.cloud.config.v1.ListTerraformVersionsRequest` is changed

## Version 1.7.0, released 2025-01-13

### New features

- Specify retry configuration ([commit 37e089e](https://github.com/googleapis/google-cloud-dotnet/commit/37e089ea191718875a26126e3e572264a7ff244c))

## Version 1.6.0, released 2024-12-12

### Bug fixes

- Changed field behavior for an existing field `service_account` in message `.google.cloud.config.v1.Deployment` ([commit 57c3817](https://github.com/googleapis/google-cloud-dotnet/commit/57c3817524f12a40c5756fa6820df75c5a92a90f))
- Changed field behavior for an existing field `service_account` in message `.google.cloud.config.v1.Preview` ([commit 57c3817](https://github.com/googleapis/google-cloud-dotnet/commit/57c3817524f12a40c5756fa6820df75c5a92a90f))

### New features

- Added annotations ([commit 57c3817](https://github.com/googleapis/google-cloud-dotnet/commit/57c3817524f12a40c5756fa6820df75c5a92a90f))

### Documentation improvements

- Service Account is a required field ([commit 57c3817](https://github.com/googleapis/google-cloud-dotnet/commit/57c3817524f12a40c5756fa6820df75c5a92a90f))

## Version 1.5.0, released 2024-04-29

### New features

- Infrastructure manager supports 1.2.3, 1.3.10, 1.4.7, 1.5.7 versions of Terraform when creating a preview of a deployment ([commit 6bc09e9](https://github.com/googleapis/google-cloud-dotnet/commit/6bc09e9f58284ac8a8c7ed69970e1f86de16b447))
- Annotations are now supported to help client tools identify deployments during automation ([commit 6bc09e9](https://github.com/googleapis/google-cloud-dotnet/commit/6bc09e9f58284ac8a8c7ed69970e1f86de16b447))

## Version 1.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.3.0, released 2024-03-21

### New features

- Infrastructure Manager supports the deployment of infrastructure from Terraform configurations in a private Git repository ([commit 647e24d](https://github.com/googleapis/google-cloud-dotnet/commit/647e24d9395300fd1ed5d9d5fa7abf7ac507ea01))
- Infrastructure Manager can validate and enforce quota limits, preventing infrastructure that exceeds quota limits from being deployed ([commit 647e24d](https://github.com/googleapis/google-cloud-dotnet/commit/647e24d9395300fd1ed5d9d5fa7abf7ac507ea01))
- Infrastructure manager supports the following versions of Terraform when creating a deployment: Terraform version 1.2.3, 1.3.10, 1.4.7, 1.5.7 ([commit 647e24d](https://github.com/googleapis/google-cloud-dotnet/commit/647e24d9395300fd1ed5d9d5fa7abf7ac507ea01))

### Documentation improvements

- A comment for field `page_size` in message `.google.cloud.config.v1.ListDeploymentsRequest` is changed ([commit 647e24d](https://github.com/googleapis/google-cloud-dotnet/commit/647e24d9395300fd1ed5d9d5fa7abf7ac507ea01))
- A comment for field `page_size` in message `.google.cloud.config.v1.ListRevisionsRequest` is changed ([commit 647e24d](https://github.com/googleapis/google-cloud-dotnet/commit/647e24d9395300fd1ed5d9d5fa7abf7ac507ea01))
- A comment for field `page_size` in message `.google.cloud.config.v1.ListResourcesRequest` is changed ([commit 647e24d](https://github.com/googleapis/google-cloud-dotnet/commit/647e24d9395300fd1ed5d9d5fa7abf7ac507ea01))
- A comment for field `service_account` in message `.google.cloud.config.v1.Preview` is changed ([commit 647e24d](https://github.com/googleapis/google-cloud-dotnet/commit/647e24d9395300fd1ed5d9d5fa7abf7ac507ea01))
- A comment for field `page_size` in message `.google.cloud.config.v1.ListPreviewsRequest` is changed ([commit 647e24d](https://github.com/googleapis/google-cloud-dotnet/commit/647e24d9395300fd1ed5d9d5fa7abf7ac507ea01))

## Version 1.2.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 1.1.0, released 2024-01-16

### New features

- Added Terraform Plan ([commit 99a1ff8](https://github.com/googleapis/google-cloud-dotnet/commit/99a1ff8251389867da1c31bd91e525408b69a6a3))

## Version 1.0.0, released 2023-11-01

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta02, released 2023-09-25

### Bug fixes

- Change the config service's Ruby namespace to avoid a collision with a base class in the Ruby client platform ([commit be2b45d](https://github.com/googleapis/google-cloud-dotnet/commit/be2b45d71ea18d2614a2ff555160ee2d1a507c1d))

## Version 1.0.0-beta01, released 2023-08-15

Initial release.
