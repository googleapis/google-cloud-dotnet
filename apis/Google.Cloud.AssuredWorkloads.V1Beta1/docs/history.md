# Version history

## Version 2.0.0-beta04, released 2022-09-05

### New features

- Add compliant_but_disallowed_services field to the v1beta1 Workload proto ([commit b632564](https://github.com/googleapis/google-cloud-dotnet/commit/b63256454b6baf3b7e879508b441d305250c5a9b))
- Updated v1beta1 analyzeWorkloadMove documentation ([commit 80d91f3](https://github.com/googleapis/google-cloud-dotnet/commit/80d91f38efd947425ce6f785d523857e16fbf1eb))

## Version 2.0.0-beta03, released 2022-07-25

### New features

- Updated the method signature of analyzeWorkloadMove for v1beta API to accept project as source. AnalyzeWorkloadMove now also returns information about org policy differences between the project and target folder ([commit 31b0016](https://github.com/googleapis/google-cloud-dotnet/commit/31b0016e71d85303ccdc14de2ddef571082de875))

## Version 2.0.0-beta02, released 2022-07-11

### New features

- ITAR June Preview Launch ([commit ba28a2b](https://github.com/googleapis/google-cloud-dotnet/commit/ba28a2b7bddc1a2195492181ae9041839c6f58db))
- **BREAKING CHANGE** Removed _v1beta1 suffix from proto file names ([commit dc3a4e7](https://github.com/googleapis/google-cloud-dotnet/commit/dc3a4e7e6ffaea438a1999cbb625579ac817272f))

### Breaking changes

- Proto file name is changed from assuredworkloads_v1beta1.proto to assuredworkloads.proto ([commit dc3a4e7](https://github.com/googleapis/google-cloud-dotnet/commit/dc3a4e7e6ffaea438a1999cbb625579ac817272f))

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


## Version 1.0.0-beta08, released 2022-01-17

### New features

- EU Regions and Support With Sovereign Controls ([commit 0e8c59f](https://github.com/googleapis/google-cloud-dotnet/commit/0e8c59f05a08b1dbf518900bffc0e1f83894aaa2))

## Version 1.0.0-beta07, released 2021-09-24

- [Commit aff9821](https://github.com/googleapis/google-cloud-dotnet/commit/aff9821):
  - feat: Add Canada Regions And Support compliance regime
  - fix: ResourceType CONSUMER_PROJECT is deprecated
  - feat: ResourceType CONSUMER_FOLDER and KEYRING are added
  - feat: display_name is added to ResourceSettings
  - fix: billing_account is now optional in Workload
  - feat: resource_settings is added to CreateWorkloadOperationMetadata

## Version 1.0.0-beta06, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta05, released 2021-08-10

- [Commit 28a4164](https://github.com/googleapis/google-cloud-dotnet/commit/28a4164): feat: Add EU Regions And Support compliance regime

## Version 1.0.0-beta04, released 2021-04-28

- [Commit 4593a55](https://github.com/googleapis/google-cloud-dotnet/commit/4593a55): feat: add HIPAA and HITRUST compliance regimes
- [Commit af0c533](https://github.com/googleapis/google-cloud-dotnet/commit/af0c533): feat: Add 'resource_settings' field to provide custom properties (ids) for the provisioned projects.

## Version 1.0.0-beta03, released 2021-02-05

- [Commit 319d7b1](https://github.com/googleapis/google-cloud-dotnet/commit/319d7b1): feat: updated google.cloud.assuredworkloads.v1beta1.AssuredWorkloadsService service. Clients can now create workloads with US_REGIONAL_ACCESS compliance regime

## Version 1.0.0-beta02, released 2020-11-18

- [Commit 342a932](https://github.com/googleapis/google-cloud-dotnet/commit/342a932): feat: Clients can now specify the 'provisioned_resources_parent' for the provisioned projects.
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

## Version 1.0.0-beta01, released 2020-09-16

First beta release.
