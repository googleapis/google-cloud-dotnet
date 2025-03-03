# Version history

## Version 1.0.0-beta08, released 2025-03-03

### Bug fixes

- **BREAKING CHANGE** Response type of method `CommitRepositoryChanges` is changed from `.google.protobuf.Empty` to `.google.cloud.dataform.v1beta1.CommitRepositoryChangesResponse` in service `Dataform` ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))
- **BREAKING CHANGE** Response type of method `PullGitCommits` is changed from `.google.protobuf.Empty` to `.google.cloud.dataform.v1beta1.PullGitCommitsResponse` in service `Dataform` ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))
- **BREAKING CHANGE** Response type of method `PushGitCommits` is changed from `.google.protobuf.Empty` to `.google.cloud.dataform.v1beta1.PushGitCommitsResponse` in service `Dataform` ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))
- **BREAKING CHANGE** Response type of method `CommitWorkspaceChanges` is changed from `.google.protobuf.Empty` to `.google.cloud.dataform.v1beta1.CommitWorkspaceChangesResponse` in service `Dataform` ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))
- **BREAKING CHANGE** Response type of method `ResetWorkspaceChanges` is changed from `.google.protobuf.Empty` to `.google.cloud.dataform.v1beta1.ResetWorkspaceChangesResponse` in service `Dataform` ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))
- **BREAKING CHANGE** Response type of method `RemoveDirectory` is changed from `.google.protobuf.Empty` to `.google.cloud.dataform.v1beta1.RemoveDirectoryResponse` in service `Dataform` ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))
- **BREAKING CHANGE** Response type of method `RemoveFileRequest` is changed from `.google.protobuf.Empty` to `.google.cloud.dataform.v1beta1.RemoveFileResponse` in service `Dataform` ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))
- **BREAKING CHANGE** Response type of method `CancelWorkflowInvocation` is changed from `.google.protobuf.Empty` to `.google.cloud.dataform.v1beta1.CancelWorkflowInvocationResponse` in service `Dataform` ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))
- **BREAKING CHANGE** An existing field `bigquery_action` is moved in to oneof in message `.google.cloud.dataform.v1beta1.WorkflowInvocationAction` ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))

### New features

- Added new field `internal_metadata` to all resources to export all the metadata information that is used internally to serve the resource ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))
- Returning `commit_sha` in the response of method `CommitRepositoryChanges` ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))
- Moving existing field `bigquery_action` to oneof in message `.google.cloud.dataform.v1beta1.WorkflowInvocationAction` to allow adding more actions types such as `notebook_action` ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))

### Documentation improvements

- Explained the effect of field `page_token` on the pagination in several messages ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))
- Adds known limitations on several methods such as `UpdateRepository`, `UpdateReleaseConfig` and `UpdateWorkflowConfig` ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))
- Several comments reformatted ([commit 4985789](https://github.com/googleapis/google-cloud-dotnet/commit/4985789a9865a50a2f07e24360b42ea9438a9ca5))

## Version 1.0.0-beta07, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 1.0.0-beta06, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta05, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.0.0-beta04, released 2024-02-28

No API surface changes; just dependency updates.

## Version 1.0.0-beta03, released 2023-10-30

### Bug fixes

- Rearrange several messages, thus changing field types ([commit 9d2b3d8](https://github.com/googleapis/google-cloud-dotnet/commit/9d2b3d87af20c88bce3d585098a33420aa33085d))

### New features

- Support for ReleaseConfigs ([commit 9d2b3d8](https://github.com/googleapis/google-cloud-dotnet/commit/9d2b3d87af20c88bce3d585098a33420aa33085d))
- Support for WorkflowConfigs ([commit 9d2b3d8](https://github.com/googleapis/google-cloud-dotnet/commit/9d2b3d87af20c88bce3d585098a33420aa33085d))
- Support new first-party repository methods for committing, listing/reading files, and fetching history ([commit 9d2b3d8](https://github.com/googleapis/google-cloud-dotnet/commit/9d2b3d87af20c88bce3d585098a33420aa33085d))
- Support new ComputeRepositoryAccessTokenStatus repository method ([commit 9d2b3d8](https://github.com/googleapis/google-cloud-dotnet/commit/9d2b3d87af20c88bce3d585098a33420aa33085d))
- Support SSH based git authentication configuration ([commit 9d2b3d8](https://github.com/googleapis/google-cloud-dotnet/commit/9d2b3d87af20c88bce3d585098a33420aa33085d))
- Support workspace compilation override fields ([commit 9d2b3d8](https://github.com/googleapis/google-cloud-dotnet/commit/9d2b3d87af20c88bce3d585098a33420aa33085d))
- Support NPMRC environment variables ([commit 9d2b3d8](https://github.com/googleapis/google-cloud-dotnet/commit/9d2b3d87af20c88bce3d585098a33420aa33085d))
- Support labels on repositories ([commit 9d2b3d8](https://github.com/googleapis/google-cloud-dotnet/commit/9d2b3d87af20c88bce3d585098a33420aa33085d))
- Support custom service account repository configuration ([commit 9d2b3d8](https://github.com/googleapis/google-cloud-dotnet/commit/9d2b3d87af20c88bce3d585098a33420aa33085d))

### Documentation improvements

- Several comments reformatted ([commit 9d2b3d8](https://github.com/googleapis/google-cloud-dotnet/commit/9d2b3d87af20c88bce3d585098a33420aa33085d))

## Version 1.0.0-beta02, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 31e55cd](https://github.com/googleapis/google-cloud-dotnet/commit/31e55cdbafe12bfae68e28a75a1b75ceb445684f))

## Version 1.0.0-beta01, released 2022-10-17

Initial release.
