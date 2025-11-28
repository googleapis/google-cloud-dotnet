# Version history

## Version 2.0.0-beta09, released 2025-11-05

### New features

- Update dependencies

## Version 2.0.0-beta08, released 2025-09-16

### New features

- Add `k8s_git_version` field

### Documentation improvements

- Correct comment for `k8s_version` field

## Version 2.0.0-beta07, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-beta06, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-beta05, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.0.0-beta04, released 2023-05-03

### New features

- Add `monitoring_config` field ([commit 2177d00](https://github.com/googleapis/google-cloud-dotnet/commit/2177d0090b863648fd7add7a5eb7167e65a02972))
- Add `force` on `DeleteMembershipRequest` ([commit 2177d00](https://github.com/googleapis/google-cloud-dotnet/commit/2177d0090b863648fd7add7a5eb7167e65a02972))

### Documentation improvements

- Update API annotation ([commit 2177d00](https://github.com/googleapis/google-cloud-dotnet/commit/2177d0090b863648fd7add7a5eb7167e65a02972))

## Version 2.0.0-beta03, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

## Version 2.0.0-beta02, released 2022-07-11

### New features

- Add ClusterType field in MembershipEndpoint.OnPremCluster ([commit 4bde0d7](https://github.com/googleapis/google-cloud-dotnet/commit/4bde0d72a70a5a63ea5329659048933b13491f58))

## Version 2.0.0-beta01, released 2022-06-08

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

### New features

- Add EdgeCluster as a new membershipEndpoint type ([commit d4f5e63](https://github.com/googleapis/google-cloud-dotnet/commit/d4f5e636b90f2bf01f1ee45d54e2ecf513976b2e))
- Add ApplianceCluster as a new membershipEndpoint type ([commit d4f5e63](https://github.com/googleapis/google-cloud-dotnet/commit/d4f5e636b90f2bf01f1ee45d54e2ecf513976b2e))
- Add API annotations ([commit d4f5e63](https://github.com/googleapis/google-cloud-dotnet/commit/d4f5e636b90f2bf01f1ee45d54e2ecf513976b2e))

### Documentation improvements

- Minor changes on code and doc format ([commit d4f5e63](https://github.com/googleapis/google-cloud-dotnet/commit/d4f5e636b90f2bf01f1ee45d54e2ecf513976b2e))

## Version 1.0.0-beta04, released 2022-02-28

### New features

- Added support for k8s_version field ([commit 38e1e18](https://github.com/googleapis/google-cloud-dotnet/commit/38e1e18e562490fc3b68d55f64c816421ed40a5c))

### Documentation improvements

- K8s_version field is not part of resource_options struct ([commit 38e1e18](https://github.com/googleapis/google-cloud-dotnet/commit/38e1e18e562490fc3b68d55f64c816421ed40a5c))
## Version 1.0.0-beta03, released 2021-09-23

- [Commit 1d19cbd](https://github.com/googleapis/google-cloud-dotnet/commit/1d19cbd):
  - feat: Add request_id under `DeleteMembershipRequest` and `UpdateMembershipRequest`
  - feat: Add `OnPremCluster` and `MultiCloudCluster` as `GkeCluster` equivalent field
  - fix!: Move `GkeCluster` under oneof
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta02, released 2021-04-29

- [Commit a204405](https://github.com/googleapis/google-cloud-dotnet/commit/a204405): chore: Use correct markdown for code block
- [Commit aea1356](https://github.com/googleapis/google-cloud-dotnet/commit/aea1356): feat: Update Membership API v1beta1 proto

## Version 1.0.0-beta01, released 2021-01-25

Initial release.
