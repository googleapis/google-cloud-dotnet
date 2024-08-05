# Version history

## Version 1.0.0-beta05, released 2024-08-05

### New features

- Add file_stripe_level and directory_stripe_level fields to Instance ([commit 1c3d418](https://github.com/googleapis/google-cloud-dotnet/commit/1c3d4184644c42787fe2bff86b8ae395d3562142))

## Version 1.0.0-beta04, released 2024-07-08

### New features

- Add iam.googleapis.com/ServiceAccount resource definition ([commit 30a556d](https://github.com/googleapis/google-cloud-dotnet/commit/30a556d14d92f990dde82de69600515cf0ce18d8))
- Adding Import/Export BYOSA to the export Data request ([commit 30a556d](https://github.com/googleapis/google-cloud-dotnet/commit/30a556d14d92f990dde82de69600515cf0ce18d8))
- Adding Import/Export BYOSA to the import Data request ([commit 30a556d](https://github.com/googleapis/google-cloud-dotnet/commit/30a556d14d92f990dde82de69600515cf0ce18d8))

## Version 1.0.0-beta03, released 2024-05-17

### Bug fixes

- **BREAKING CHANGE** An existing field `create_time` is removed from message `.google.cloud.parallelstore.v1beta.TransferOperationMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- **BREAKING CHANGE** An existing field `end_time` is removed from message `.google.cloud.parallelstore.v1beta.TransferOperationMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- **BREAKING CHANGE** An existing field `source` is removed from message `.google.cloud.parallelstore.v1beta.TransferOperationMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- **BREAKING CHANGE** An existing field `destination` is removed from message `.google.cloud.parallelstore.v1beta.TransferOperationMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))

### New features

- A new field `create_time` is added to message `.google.cloud.parallelstore.v1beta.ImportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `end_time` is added to message `.google.cloud.parallelstore.v1beta.ImportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `target` is added to message `.google.cloud.parallelstore.v1beta.ImportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `verb` is added to message `.google.cloud.parallelstore.v1beta.ImportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `status_message` is added to message `.google.cloud.parallelstore.v1beta.ImportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `requested_cancellation` is added to message `.google.cloud.parallelstore.v1beta.ImportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `api_version` is added to message `.google.cloud.parallelstore.v1beta.ImportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `create_time` is added to message `.google.cloud.parallelstore.v1beta.ExportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `end_time` is added to message `.google.cloud.parallelstore.v1beta.ExportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `target` is added to message `.google.cloud.parallelstore.v1beta.ExportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `verb` is added to message `.google.cloud.parallelstore.v1beta.ExportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `status_message` is added to message `.google.cloud.parallelstore.v1beta.ExportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `requested_cancellation` is added to message `.google.cloud.parallelstore.v1beta.ExportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `api_version` is added to message `.google.cloud.parallelstore.v1beta.ExportDataMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `source_parallelstore` is added to message `.google.cloud.parallelstore.v1beta.TransferOperationMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `source_gcs_bucket` is added to message `.google.cloud.parallelstore.v1beta.TransferOperationMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `destination_gcs_bucket` is added to message `.google.cloud.parallelstore.v1beta.TransferOperationMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A new field `destination_parallelstore` is added to message `.google.cloud.parallelstore.v1beta.TransferOperationMetadata` ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))

### Documentation improvements

- A comment for field `counters` in message `.google.cloud.parallelstore.v1beta.TransferOperationMetadata` is changed ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))
- A comment for field `transfer_type` in message `.google.cloud.parallelstore.v1beta.TransferOperationMetadata` is changed ([commit a59f288](https://github.com/googleapis/google-cloud-dotnet/commit/a59f288c10ca3111a8bd7ce733aa68d726b32e0d))

## Version 1.0.0-beta02, released 2024-05-08

### New features

- Add ImportData and ExportData RPCs ([commit aded486](https://github.com/googleapis/google-cloud-dotnet/commit/aded48685ab1ba8ad1fc117ed4f66ef7561356ec))
- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

### Documentation improvements

- Fix typo in Instance.reserved_ip_range field doc ([commit aded486](https://github.com/googleapis/google-cloud-dotnet/commit/aded48685ab1ba8ad1fc117ed4f66ef7561356ec))

## Version 1.0.0-beta01, released 2024-04-18

Initial release.
