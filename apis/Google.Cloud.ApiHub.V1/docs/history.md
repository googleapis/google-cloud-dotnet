# Version history

## Version 1.2.0, released 2025-11-03

### New features

- Update dependencies

## Version 1.1.0, released 2025-09-16

### New features

- Introduce new services for data collection (ApiHubCollect) and curation (ApiHubCurate)
- Add full lifecycle management for API Operations within API Versions (Create, Update, Delete)
- Significantly expand Plugin and Plugin Instance management capabilities, including creation, execution, and lifecycle control
- Enable Deletion of ApiHub Instances via the Provisioning service
- Enhance list filtering options across various resources (APIs, Versions, Specs, Operations, Deployments) with support for user-defined attributes
- Add new fields and enums to resources to support richer metadata, including source tracking (SourceMetadata), plugin configurations (AuthConfig, ConfigVariable), new attributes, and additional deployment details
- Make CMEK configuration optional for ApiHub Instances, defaulting to GMEK

### Documentation improvements

- Update field descriptions, comments, and links in existing services

## Version 1.0.0, released 2024-12-05

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta02, released 2024-09-04

### Bug fixes

- **BREAKING CHANGE** Remove gRPC support for client libraries ([commit ecf9305](https://github.com/googleapis/google-cloud-dotnet/commit/ecf9305b0613fb78a8f010aa7ac58f5fed102dcc))

## Version 1.0.0-beta01, released 2024-08-07

Initial release.
