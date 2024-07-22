# Version history

## Version 2.19.0, released 2024-07-22

### New features

- Added support for new custom target type and deploy policy platform logs ([commit 50b0fe6](https://github.com/googleapis/google-cloud-dotnet/commit/50b0fe6c19d49962cea3f0bea359ee40d4575281))
- Added support for deploy policies ([commit dd03c4a](https://github.com/googleapis/google-cloud-dotnet/commit/dd03c4ae63b9339d53b7815707e25731a0dce83f))
- Added support for configuring a proxy_url to a Kubernetes server ([commit dd03c4a](https://github.com/googleapis/google-cloud-dotnet/commit/dd03c4ae63b9339d53b7815707e25731a0dce83f))

### Documentation improvements

- Small Cloud Deploy API documentation updates ([commit 50b0fe6](https://github.com/googleapis/google-cloud-dotnet/commit/50b0fe6c19d49962cea3f0bea359ee40d4575281))
- Small corrections to Cloud Deploy API documentation ([commit dd03c4a](https://github.com/googleapis/google-cloud-dotnet/commit/dd03c4ae63b9339d53b7815707e25731a0dce83f))

## Version 2.18.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.17.0, released 2024-05-17

### New features

- Add Skaffold verbose support to Execution Environment properties ([commit a99ed3a](https://github.com/googleapis/google-cloud-dotnet/commit/a99ed3a3ac5036094ba7a7b8452c1ae4d8ae1a56))

## Version 2.16.0, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

### Documentation improvements

- Small corrections to Cloud Deploy API documentation ([commit b2e5459](https://github.com/googleapis/google-cloud-dotnet/commit/b2e54591eb14e8ea6ad017e8f9593bc4bda0baf8))

## Version 2.15.0, released 2024-04-22

### New features

- Add Skaffold remote config support for GCB repos ([commit 153861e](https://github.com/googleapis/google-cloud-dotnet/commit/153861ed8a5c405967a43dd1e0c91aaa2a658780))

### Documentation improvements

- Clarified related comments ([commit 153861e](https://github.com/googleapis/google-cloud-dotnet/commit/153861ed8a5c405967a43dd1e0c91aaa2a658780))

## Version 2.14.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.13.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.12.0, released 2024-01-16

### New features

- Add stable cutback duration configuration to the k8s gateway service mesh deployment strategy. This allows configuring the amount of time to migrate traffic back to the original Service in the stable phase ([commit 86ff329](https://github.com/googleapis/google-cloud-dotnet/commit/86ff329170bcede92ce7e5e9c9eb29b802e13e0f))
- Updated logging protos with new fields ([commit 86ff329](https://github.com/googleapis/google-cloud-dotnet/commit/86ff329170bcede92ce7e5e9c9eb29b802e13e0f))

### Documentation improvements

- Fixed a number of comments ([commit 86ff329](https://github.com/googleapis/google-cloud-dotnet/commit/86ff329170bcede92ce7e5e9c9eb29b802e13e0f))

## Version 2.11.0, released 2023-12-04

### New features

- Add custom target type support ([commit 70af9a8](https://github.com/googleapis/google-cloud-dotnet/commit/70af9a8e2539e7f0fc7fb203cf9e0100888c4805))
- Add revision tagging for one of the Cloud Run deployment strategies ([commit 70af9a8](https://github.com/googleapis/google-cloud-dotnet/commit/70af9a8e2539e7f0fc7fb203cf9e0100888c4805))

### Documentation improvements

- Fixed a number of comments. ([commit 70af9a8](https://github.com/googleapis/google-cloud-dotnet/commit/70af9a8e2539e7f0fc7fb203cf9e0100888c4805))

## Version 2.10.0, released 2023-11-07

### New features

- Add Automation API and Rollback API ([commit 3d46ee1](https://github.com/googleapis/google-cloud-dotnet/commit/3d46ee1790e0e402d6c053fe58dc04f2cdfc1ac7))

### Documentation improvements

- Small documentation updates ([commit 3d46ee1](https://github.com/googleapis/google-cloud-dotnet/commit/3d46ee1790e0e402d6c053fe58dc04f2cdfc1ac7))

## Version 2.9.0, released 2023-10-30

### New features

- Added platform log RolloutUpdateEvent ([commit 13c15ec](https://github.com/googleapis/google-cloud-dotnet/commit/13c15ec88b53fa95cc4cb4732d21f5b9be443ba9))

## Version 2.8.0, released 2023-08-04

### New features

- Added support for predeploy and postdeploy actions ([commit 4023fa4](https://github.com/googleapis/google-cloud-dotnet/commit/4023fa4d8fb3b5fdaffb698b5f1a1687dfaf53d3))

### Documentation improvements

- Small documentation updates ([commit 36b0942](https://github.com/googleapis/google-cloud-dotnet/commit/36b094211c9288e882cc0444ab0b8d8dac41fc10))

## Version 2.7.0, released 2023-07-13

### New features

- Added support routeUpdateWaitTime field for Deployment Strategies ([commit 783acf4](https://github.com/googleapis/google-cloud-dotnet/commit/783acf4ab45ca43006ebdd21d510f9121f2610e7))

## Version 2.6.0, released 2023-06-27

### New features

- Add deploy parameters for cloud deploy ([commit 09b648f](https://github.com/googleapis/google-cloud-dotnet/commit/09b648f9964573de91bb23b2da17d788174b3242))

## Version 2.5.0, released 2023-06-20

### New features

- Add support for disabling Pod overprovisioning in the progressive deployment strategy configuration for a Kubernetes Target ([commit c1fc355](https://github.com/googleapis/google-cloud-dotnet/commit/c1fc355a5c2f9253d6f7d29a8ad03914cfe7c2c7))

## Version 2.4.0, released 2023-05-03

### New features

- Added support for DeployArtifacts ([commit d5c8fa7](https://github.com/googleapis/google-cloud-dotnet/commit/d5c8fa778b717a5567859c8013f03cfcdb438f17))
- Added support for in cluster verification ([commit d5c8fa7](https://github.com/googleapis/google-cloud-dotnet/commit/d5c8fa778b717a5567859c8013f03cfcdb438f17))

## Version 2.3.0, released 2023-03-27

### New features

- Added supported for Cloud Deploy Progressive Deployment Strategy ([commit 1b6adf3](https://github.com/googleapis/google-cloud-dotnet/commit/1b6adf30328422af2ebbf0a20d9b583d845a4915))

### Deprecations

- TYPE_RENDER_STATUSES_CHANGE is deprecated, use RELEASE_RENDER log type instead ([commit 1b6adf3](https://github.com/googleapis/google-cloud-dotnet/commit/1b6adf30328422af2ebbf0a20d9b583d845a4915))

## Version 2.2.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 2.1.0, released 2022-10-03

### New features

- Publish new JobRun resource and associated methods for Google Cloud Deploy ([commit a8b0725](https://github.com/googleapis/google-cloud-dotnet/commit/a8b0725c866b5e0942c78646cb6eb690b81fb5c0))

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


## Version 1.1.0, released 2022-04-26

### New features

- Add support for Anthos worker pool. ([commit 456b719](https://github.com/googleapis/google-cloud-dotnet/commit/456b71950b4e34b14de76a63effd2fa5e5d92ff9))

### Documentation improvements

- Cloud Deploy API Platform Logging documentation ([commit 456b719](https://github.com/googleapis/google-cloud-dotnet/commit/456b71950b4e34b14de76a63effd2fa5e5d92ff9))

## Version 1.0.0, released 2022-01-25

No API surface changes; just dependency updates and promotion to 1.0.0.

## Version 1.0.0-beta02, released 2021-12-07

- [Commit 1c771ae](https://github.com/googleapis/google-cloud-dotnet/commit/1c771ae): docs: fix docstring formatting
## Version 1.0.0-beta01, released 2021-09-23

Initial release.
