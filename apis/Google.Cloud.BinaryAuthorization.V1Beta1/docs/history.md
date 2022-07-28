# Version history

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


