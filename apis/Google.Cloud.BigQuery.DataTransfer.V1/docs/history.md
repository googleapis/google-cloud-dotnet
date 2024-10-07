# Version history

## Version 4.10.0, released 2024-10-07

### New features

- Add scheduleOptionsV2 and Error fields for TransferConfig ([commit 963221d](https://github.com/googleapis/google-cloud-dotnet/commit/963221d3cd8cb6e5252bb59ac3f413a2d703f4bd))

### Documentation improvements

- Add a note to the CreateTransferConfigRequest and UpdateTransferConfigRequest to disable restricting service account usage ([commit e0a36f4](https://github.com/googleapis/google-cloud-dotnet/commit/e0a36f41394c369bd47d7347479bce2ced7d21a0))
- Deprecate `authorization_code` ([commit e1a80f1](https://github.com/googleapis/google-cloud-dotnet/commit/e1a80f10bd16b85f5805fa95810fb0d68196dc23))
- Update OAuth links in `CreateTransferConfigRequest` and `UpdateTransferConfigRequest` ([commit 54d1ff9](https://github.com/googleapis/google-cloud-dotnet/commit/54d1ff93df6c51050015bae58e899296ebdb8fcb))

## Version 4.9.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 4.8.0, released 2024-04-19

### Documentation improvements

- Updated comments ([commit b8e05f5](https://github.com/googleapis/google-cloud-dotnet/commit/b8e05f5d0128f956984115994083d58a142c78b6))

## Version 4.7.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 4.6.0, released 2024-02-28

### Documentation improvements

- Update unenrollDataSources API documentation ([commit 4139f3c](https://github.com/googleapis/google-cloud-dotnet/commit/4139f3c037ac0723446f602a5e167cf695857222))

## Version 4.5.0, released 2024-02-20

### New features

- Add UnenrollDataSources API which gives users a programmatic way to unenroll data sources ([commit 174b0bc](https://github.com/googleapis/google-cloud-dotnet/commit/174b0bc552a3438b586c999a5a4f8f1e57dcbc48))

### Documentation improvements

- Update transferConfig.name description to indicate that it supports both formats ([commit e821bb9](https://github.com/googleapis/google-cloud-dotnet/commit/e821bb96b2abb6b7473ada5169283e27a2e267dd))

## Version 4.4.0, released 2023-08-04

### New features

- Add EncryptionConfiguration to TransferConfig ([commit b3e6563](https://github.com/googleapis/google-cloud-dotnet/commit/b3e65636477e5b1e6940e13bcfeee7e360585fb0))
- Add List type to Data source parameter. ([commit b3e6563](https://github.com/googleapis/google-cloud-dotnet/commit/b3e65636477e5b1e6940e13bcfeee7e360585fb0))

### Documentation improvements

- Minor comment update ([commit 0736781](https://github.com/googleapis/google-cloud-dotnet/commit/0736781d303db2ef56a5365a2ff824fbde4e10fb))

## Version 4.3.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 31e55cd](https://github.com/googleapis/google-cloud-dotnet/commit/31e55cdbafe12bfae68e28a75a1b75ceb445684f))

## Version 4.2.0, released 2023-01-16

### New features

- Add location methods ([commit 3e84841](https://github.com/googleapis/google-cloud-dotnet/commit/3e848418b3e3442a7842970cf60f7ad1808a8c73))

## Version 4.1.0, released 2022-12-01

### New features

- Added Location API methods ([commit 7e0e4ab](https://github.com/googleapis/google-cloud-dotnet/commit/7e0e4ab0e3a5b6a8552078229d56c59e757f4d2c))

### Documentation improvements

- Updated comments ([commit 7e0e4ab](https://github.com/googleapis/google-cloud-dotnet/commit/7e0e4ab0e3a5b6a8552078229d56c59e757f4d2c))

## Version 4.0.0, released 2022-06-08

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
## Version 3.4.0, released 2022-04-26

No API surface changes; just dependency updates.

## Version 3.3.0, released 2022-02-07

### New features

- Add owner email to TransferConfig message ([commit 5939502](https://github.com/googleapis/google-cloud-dotnet/commit/593950270001c126abccb139dd1268997996ac10))
- Allow customer to enroll a datasource programmatically ([commit 5939502](https://github.com/googleapis/google-cloud-dotnet/commit/593950270001c126abccb139dd1268997996ac10))

### Documentation improvements

- Improvements to various message and field descriptions ([commit 5939502](https://github.com/googleapis/google-cloud-dotnet/commit/593950270001c126abccb139dd1268997996ac10))

## Version 3.2.0, released 2021-09-23

- [Commit edaadae](https://github.com/googleapis/google-cloud-dotnet/commit/edaadae): docs: Improvements to various message and field descriptions
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 3.1.0, released 2021-05-25

- [Commit 3717e0d](https://github.com/googleapis/google-cloud-dotnet/commit/3717e0d): Regenerate all APIs with generator change for deprecation

## Version 3.0.0, released 2020-09-28

- [Commit 924f350](https://github.com/googleapis/google-cloud-dotnet/commit/924f350): fix!: Remove obsolete `Datasource` code
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/924f350): chore!: Regenerate all APIs with new protoc/gRPC tooling
  - This is a subtly breaking change, as the gRPC client constructor accepting a Channel parameter has been changed to accept ChannelBase.
    We don't expect this to actually break customers, but it is definitely a binary-incompatible change.
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Regenerate all APIs with improved timeout behavior
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 0c88ce0](https://github.com/googleapis/google-cloud-dotnet/commit/0c88ce0): feat: Add a new AuthorizationType for Data Source Definition.

## Version 2.0.0, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependencies
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.1.0, released 2019-12-10

- [Commit c0001b5](https://github.com/googleapis/google-cloud-dotnet/commit/c0001b5): Adds service account, email and PubSub options.
- [Commit cc6ec31](https://github.com/googleapis/google-cloud-dotnet/commit/cc6ec31): Introduces a oneof for TransferConfig.Destination and TransferRun.Destingation.
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Adds a Format method for all resource name classes

## Version 1.0.0, released 2019-07-10

Initial GA release.
