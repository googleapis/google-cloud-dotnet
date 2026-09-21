# Version history

## Version 1.0.0-alpha03, released 2026-09-21

### New features

- Add the `GetUserGroup`, `ListUserGroups`, `CreateUserGroup`, `UpdateUserGroup`, and `DeleteUserGroup` methods
- Add the `GetUserGroupMember`, `ListUserGroupMembers`, `CreateUserGroupMember`, `UpdateUserGroupMember`, and `DeleteUserGroupMember` methods
- Add the `GetAdminAccessBinding`, `ListAdminAccessBindings`, `CreateAdminAccessBinding`, and `UpdateAdminAccessBinding` methods
- Add the `UserGroup`, `UserGroupMember`, and `AdminAccessBinding` resources in resources.proto
- Define the `OrganizationRole` enum in resources.proto and the `UserGroupMember.MembershipRole` enum
- Add the `GetUserGroupRequest`, `ListUserGroupsRequest`, `ListUserGroupsResponse`, `CreateUserGroupRequest`, `UpdateUserGroupRequest`, and `DeleteUserGroupRequest` resources
- Add the `GetUserGroupMemberRequest`, `ListUserGroupMembersRequest`, `ListUserGroupMembersResponse`, `CreateUserGroupMemberRequest`, `UpdateUserGroupMemberRequest`, and `DeleteUserGroupMemberRequest` resources
- Add the `GetAdminAccessBindingRequest`, `ListAdminAccessBindingsRequest`, `ListAdminAccessBindingsResponse`, `CreateAdminAccessBindingRequest`, and `UpdateAdminAccessBindingRequest` resources
- Update OAuth scopes in marketingplatformadmin_v1alpha.yaml

### Documentation improvements

- Update the `GetOrganization` and `ReportPropertyUsage` method comments

## Version 1.0.0-alpha02, released 2025-11-03

### New features

- Add the `ListOrganizations`, `FindSalesPartnerManagedClients`, and `ReportPropertyUsage` methods
- Define AnalyticsServiceLevel and AnalyticsPropertyType enums in resources.proto
- Update OAuth scopes in marketingplatformadmin_v1alpha.yaml
- Add the `ListOrganizationsRequest` and `ListOrganizationsResponse` resources
- Add the `FindSalesPartnerManagedClientsRequest` and `FindSalesPartnerManagedClientsResponse` resources
- Add the `ReportPropertyUsageRequest` and `ReportPropertyUsageResponse` resources

## Version 1.0.0-alpha01, released 2024-09-19

First alpha release.


