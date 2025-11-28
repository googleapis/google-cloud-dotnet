# Version history

## Version 2.7.0, released 2025-11-05

### New features

- Update dependencies

## Version 2.6.0, released 2025-09-16

### New features

- Add `k8s_git_version` field

### Documentation improvements

- Correct comment for `k8s_version` field
- Reformat comments for several messages, including ListFeaturesRequest, CreateFeatureRequest, and OperationMetadata

## Version 2.5.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.3.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.2.0, released 2023-05-03

### New features

- Add `monitoring_config` field ([commit 5275f91](https://github.com/googleapis/google-cloud-dotnet/commit/5275f910d8883e94a433e696e1c667c6faa3582b))
- Add `cluster_missing` on `GkeResource` ([commit 5275f91](https://github.com/googleapis/google-cloud-dotnet/commit/5275f910d8883e94a433e696e1c667c6faa3582b))
- Add `google_managed` on `MembershipEndpoint` ([commit 5275f91](https://github.com/googleapis/google-cloud-dotnet/commit/5275f910d8883e94a433e696e1c667c6faa3582b))
- Add `force` on `DeleteMembershipRequest` ([commit 5275f91](https://github.com/googleapis/google-cloud-dotnet/commit/5275f910d8883e94a433e696e1c667c6faa3582b))

### Documentation improvements

- Update API annotation ([commit 5275f91](https://github.com/googleapis/google-cloud-dotnet/commit/5275f910d8883e94a433e696e1c667c6faa3582b))

## Version 2.1.0, released 2023-01-20

### New features

- Enable REST transport ([commit 46d4fe8](https://github.com/googleapis/google-cloud-dotnet/commit/46d4fe8461ac30e7666600e44e7bd16228768621))

## Version 2.0.0, released 2022-06-08

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


## Version 1.2.0, released 2022-02-07

### New features

- Add `kubernetes_resource` field ([commit d03595e](https://github.com/googleapis/google-cloud-dotnet/commit/d03595ea86e200b93c35f761a358cbf6346ebbe2))

### Documentation improvements

- Update API annotation ([commit d03595e](https://github.com/googleapis/google-cloud-dotnet/commit/d03595ea86e200b93c35f761a358cbf6346ebbe2))

## Version 1.1.0, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-08-16

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2021-07-21

Initial release.
