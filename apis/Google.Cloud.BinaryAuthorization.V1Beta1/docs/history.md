# Version history

## Version 2.0.0-beta09, released 2025-11-05

### New features

- Update dependencies

## Version 2.0.0-beta08, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-beta07, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-beta06, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.0.0-beta05, released 2023-12-04

### New features

- Add container_name, container_type fields to Continuous Validation Logs ([commit 38aeca4](https://github.com/googleapis/google-cloud-dotnet/commit/38aeca45b2cfd63ffb1dff7af40b36b324334ebe))

## Version 2.0.0-beta04, released 2023-08-16

### Bug fixes

- **BREAKING CHANGE** Remove unused unsupported_policy_event event_type from ContinuousValidationPodEvent ([commit 84043b5](https://github.com/googleapis/google-cloud-dotnet/commit/84043b5f6a260678e2c3fdb6dde2ac56ba64b81b))

### New features

- Adds support for check-based platform policy evaluation to Binary Authorization Continuous Validation logs ([commit 84043b5](https://github.com/googleapis/google-cloud-dotnet/commit/84043b5f6a260678e2c3fdb6dde2ac56ba64b81b))
- Adds support for communicating configuration issues that prevent Continuous Validation from monitoring pods ([commit 84043b5](https://github.com/googleapis/google-cloud-dotnet/commit/84043b5f6a260678e2c3fdb6dde2ac56ba64b81b))

## Version 2.0.0-beta03, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 2.0.0-beta02, released 2022-07-11

### New features

- Adds a pod_namespace field to pod events created by Continuous Validation, to distinguish pods with the same name that run in different namespaces ([commit fd6408b](https://github.com/googleapis/google-cloud-dotnet/commit/fd6408b674f330694f87d105a233c5ddf5e508d8))

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
## Version 1.0.0-beta05, released 2021-11-10

- [Commit b85ccc6](https://github.com/googleapis/google-cloud-dotnet/commit/b85ccc6):
  - feat: add new admission rule types to Policy
  - feat: update SignatureAlgorithm enum to match algorithm names in KMS
  - feat: add SystemPolicyV1Beta1 service

## Version 1.0.0-beta04, released 2021-09-23

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs
- [Commit e711ab9](https://github.com/googleapis/google-cloud-dotnet/commit/e711ab9): docs: Replace "global policy" with "system policy" in Binary Authorization documentation

## Version 1.0.0-beta03, released 2021-06-22

- [Commit 9e5abc8](https://github.com/googleapis/google-cloud-dotnet/commit/9e5abc8): feat: Publish Binary Authorization ContinuousValidationEvent proto. This is used in the new [Continuous Validation](https://cloud.google.com/binary-authorization/docs/overview-cv) feature

## Version 1.0.0-beta02, released 2021-04-29

- [Commit e94047c](https://github.com/googleapis/google-cloud-dotnet/commit/e94047c): docs: Replace "whitelist" with "allowlist" in generated documentation

## Version 1.0.0-beta01, released 2020-11-05

Intial beta release.


