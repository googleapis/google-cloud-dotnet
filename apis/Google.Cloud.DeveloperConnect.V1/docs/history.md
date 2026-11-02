# Version history

## Version 1.0.0-beta04, released 2026-02-23

### New features

- Add Secure Source Manager and Generic HTTP Endpoint connection types
- Add OAuth flow RPCs (StartOAuth, FinishOAuth)
- Add Gemini Code Assist GitHub App type
- Add HTTP Proxy base URI field
- Add Deployment Events to Insights API (GetDeploymentEvent, ListDeploymentEvents)
- Add Cloud Run and App Hub Service runtimes to InsightsConfig
- Add Projects field to InsightsConfig for project tracking
- A new message `google.cloud.developerconnect.v1.GenericHTTPEndpointConfig` is added
- A new message `google.cloud.developerconnect.v1.SecureSourceManagerInstanceConfig` is added
- A new message `google.cloud.developerconnect.v1.StartOAuthRequest` is added
- A new message `google.cloud.developerconnect.v1.StartOAuthResponse` is added
- A new message `google.cloud.developerconnect.v1.FinishOAuthRequest` is added
- A new message `google.cloud.developerconnect.v1.FinishOAuthResponse` is added
- A new message `google.cloud.developerconnect.v1.insights.Projects` is added
- A new message `google.cloud.developerconnect.v1.insights.GoogleCloudRun` is added
- A new message `google.cloud.developerconnect.v1.insights.AppHubService` is added
- A new message `google.cloud.developerconnect.v1.insights.DeploymentEvent` is added
- A new message `google.cloud.developerconnect.v1.insights.GetDeploymentEventRequest` is added
- A new message `google.cloud.developerconnect.v1.insights.ListDeploymentEventsRequest` is added
- A new message `google.cloud.developerconnect.v1.insights.ListDeploymentEventsResponse` is added
- A new message `google.cloud.developerconnect.v1.insights.ArtifactDeployment` is added
- A new field `secure_source_manager_instance_config` is added to message `google.cloud.developerconnect.v1.Connection`
- A new field `http_config` is added to message `google.cloud.developerconnect.v1.Connection`
- A new field `http_proxy_base_uri` is added to message `google.cloud.developerconnect.v1.HTTPProxyConfig`
- A new enum value `GEMINI_CODE_ASSIST` is added to enum `google.cloud.developerconnect.v1.GitHubConfig.GitHubApp`
- A new field `organization` is added to message `google.cloud.developerconnect.v1.GitHubEnterpriseConfig`
- A new field `projects` is added to message `google.cloud.developerconnect.v1.insights.InsightsConfig`
- A new field `google_cloud_run` is added to message `google.cloud.developerconnect.v1.insights.RuntimeConfig`
- A new field `app_hub_service` is added to message `google.cloud.developerconnect.v1.insights.RuntimeConfig`

### Documentation improvements

- Updated comments to include regional secret patterns for SecretManager fields in `GitHubConfig`, `OAuthCredential`, `UserCredential`, `GitLabConfig`, `GitLabEnterpriseConfig`, `BitbucketDataCenterConfig`, and `BitbucketCloudConfig`
- Updated comment for `CreateGitRepositoryLink` RPC in `google.cloud.developerconnect.v1.DeveloperConnect`
- Updated description for `google.cloud.location.Locations.ListLocations` in YAML
- Corrected typos in comments for `google.cloud.developerconnect.v1.insights.InsightsConfig` and `google.cloud.developerconnect.v1.insights.ArtifactConfig`

## Version 1.0.0-beta03, released 2025-11-05

### New features

- Update dependencies

## Version 1.0.0-beta02, released 2025-06-25

### New features

- Add DCI insights config proto
- A new message `google.cloud.developerconnect.v1.AccountConnector` is added
- A new message `google.cloud.developerconnect.v1.User` is added
- A new enum `google.cloud.developerconnect.v1.SystemProvider` is added
- A new message `google.cloud.developerconnect.v1.GitProxyConfig` is added
- A new field `bitbucket_data_center_config` is added to message `google.cloud.developerconnect.v1.Connection`
- A new field `bitbucket_cloud_config` is added to message `google.cloud.developerconnect.v1.Connection`
- A new field `provider_oauth_config` is added to message `google.cloud.developerconnect.v1.AccountConnector`
- A new field `oauth_start_uri` is added to message `google.cloud.developerconnect.v1.AccountConnector`

### Documentation improvements

- A comment for field `uid` in message `.google.cloud.developerconnect.v1.Connection` is changed
- A comment for field `uid` in message `.google.cloud.developerconnect.v1.GitRepositoryLink` is changed

## Version 1.0.0-beta01, released 2025-04-24

Initial release.
