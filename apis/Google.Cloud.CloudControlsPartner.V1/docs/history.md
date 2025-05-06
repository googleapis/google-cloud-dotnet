# Version history

## Version 1.2.0, released 2025-05-06

### New features

- Enable partners to create, update and delete their customers
- A new field `organization_domain` is added to message `Customer`

### Documentation improvements

- Mark the enum value `EkmSolution.VIRTRU` as deprecated

## Version 1.1.0, released 2024-09-16

### New features

- Field behavior for field `customer_onboarding_state` in message `.google.cloud.cloudcontrolspartner.v1.Customer` is changed ([commit e63d70b](https://github.com/googleapis/google-cloud-dotnet/commit/e63d70bd6da943c388877d3d3b8a5166d35d6b8e))
- Field behavior for field `is_onboarded` in message `.google.cloud.cloudcontrolspartner.v1.Customer` is changed ([commit e63d70b](https://github.com/googleapis/google-cloud-dotnet/commit/e63d70bd6da943c388877d3d3b8a5166d35d6b8e))
- A new value `ACCESS_TRANSPARENCY_LOGS_SUPPORT_CASE_VIEWER` is added to enum `.google.cloud.cloudcontrolspartner.v1.PartnerPermissions.Permission` ([commit e63d70b](https://github.com/googleapis/google-cloud-dotnet/commit/e63d70bd6da943c388877d3d3b8a5166d35d6b8e))

### Documentation improvements

- A comment for field `display_name` in message `.google.cloud.cloudcontrolspartner.v1.Customer` is changed ([commit e63d70b](https://github.com/googleapis/google-cloud-dotnet/commit/e63d70bd6da943c388877d3d3b8a5166d35d6b8e))
- Mark the accessApprovalRequests.list method as deprecated ([commit 74dcad9](https://github.com/googleapis/google-cloud-dotnet/commit/74dcad9d131f9ecc63c062b3a8920aa5dab122ea))

## Version 1.0.0, released 2024-05-24

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta02, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta01, released 2024-04-18

Initial release.
