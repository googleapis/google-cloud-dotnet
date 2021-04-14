# Version history

# Version 1.0.0-alpha05, released 2021-04-14

- [Commit 6904fb8](https://github.com/googleapis/google-cloud-dotnet/commit/6904fb8): fix: add `https://www.googleapis.com/auth/analytics.edit` OAuth2 scope to the list of acceptable scopes for all read only methods of the Admin API docs: update the documentation of the `update_mask` field used by Update() methods

# Version 1.0.0-alpha04, released 2021-02-05

- [Commit 3a758af](https://github.com/googleapis/google-cloud-dotnet/commit/3a758af):
  - fix!: remove unused fields from `EnhancedMeasurementSettings`
  - fix!: `update_mask` field is required for all Update operations
  - feat: add pagination support for `ListFirebaseLinks` operation
  - fix!: rename `country_code` field to `region_code` in `Account`
  - fix!: rename `url_query_parameter` field to `uri_query_parameter` in `EnhancedMeasurementSettings`
  - fix!: remove `parent` field from `GoogleAdsLink` ([issue 5841](https://github.com/googleapis/google-cloud-dotnet/issues/5841))
- [Commit 99b6d03](https://github.com/googleapis/google-cloud-dotnet/commit/99b6d03): docs: put markdown table in a codeblock
- [Commit 4f5c935](https://github.com/googleapis/google-cloud-dotnet/commit/4f5c935): feat: Add global site tag name

# Version 1.0.0-alpha03, released 2020-11-19

- [Commit 766a6d0](https://github.com/googleapis/google-cloud-dotnet/commit/766a6d0):
  - fix: 'requests' field of CreateUserLink, UpdateUserLink, DeleteUserLink methods is now required
  - docs: minor documentation updates

# Version 1.0.0-alpha02, released 2020-11-05

- [Commit 667e40f](https://github.com/googleapis/google-cloud-dotnet/commit/667e40f): docs: renamed App + Web to Google Analytics 4 (GA4) in public documentation
- [Commit 7824ab2](https://github.com/googleapis/google-cloud-dotnet/commit/7824ab2): feat: added ListAccountSummaries method ([issue 5441](https://github.com/googleapis/google-cloud-dotnet/issues/5441))
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

# Version 1.0.0-alpha01, released 2020-07-14

Initial alpha release.


