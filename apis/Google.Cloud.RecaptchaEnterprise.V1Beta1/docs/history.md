# Version history

## Version 2.0.0-beta08, released 2025-05-09

### Bug fixes

- An existing method `UpdateVehicleLocation` is removed from service `VehicleService`
- An existing method `SearchFuzzedVehicles` is removed from service `VehicleService`
- An existing message `UpdateVehicleLocationRequest` is removed

### Documentation improvements

- Marked fields as output only
- Fix typo in FraudPrevention.DISABLE comment
- Tweak comments
- Minor wording and branding adjustments
- Fix CreateAssessmentRequest comment
- Update API title in docs overview
- Minor doc fixes

## Version 2.0.0-beta07, released 2024-04-29

### New features

- Add Fraud Prevention settings field ([commit d54c222](https://github.com/googleapis/google-cloud-dotnet/commit/d54c22206f0160a5cb1eb98d43b0d2c9740a741b))

## Version 2.0.0-beta06, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-beta05, released 2024-02-29

### Documentation improvements

- Minor comments updates ([commit 418f496](https://github.com/googleapis/google-cloud-dotnet/commit/418f496915ce5047c5044f0a6ecd43b61316ba6f))

## Version 2.0.0-beta04, released 2023-10-30

### New features

- Added FraudPreventionAssessment.behavioral_trust_verdict ([commit 3173b55](https://github.com/googleapis/google-cloud-dotnet/commit/3173b555a518bf91958a460ad0f5577fe7488595))

### Documentation improvements

- Formatting of resource names ([commit 3173b55](https://github.com/googleapis/google-cloud-dotnet/commit/3173b555a518bf91958a460ad0f5577fe7488595))

## Version 2.0.0-beta03, released 2023-03-20

### New features

- Add reCAPTCHA Enterprise Fraud Prevention API ([commit eb41a3a](https://github.com/googleapis/google-cloud-dotnet/commit/eb41a3adb0a58af0445742dc390b0da61f9b3784))

## Version 2.0.0-beta02, released 2023-01-18

### New features

- Enable REST transport in C# ([commit 0f8560c](https://github.com/googleapis/google-cloud-dotnet/commit/0f8560c840725bf41bc060c8beecafc7d99f38eb))

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
## Version 1.0.0-beta06, released 2022-05-24

### Bug fixes

- **BREAKING CHANGE** Remove key management API ([commit 388080d](https://github.com/googleapis/google-cloud-dotnet/commit/388080deee4af00ea62e2b43f115fc53becb38cb))

### New features

- Introduced Reason, PasswordLeakVerification, AccountDefenderAssessment ([commit 388080d](https://github.com/googleapis/google-cloud-dotnet/commit/388080deee4af00ea62e2b43f115fc53becb38cb))

## Version 1.0.0-beta05, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta04, released 2021-05-26

No API surface changes; just dependency updates.

## Version 1.0.0-beta03, released 2020-11-18

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit e7d1b4d](https://github.com/googleapis/google-cloud-dotnet/commit/e7d1b4d): chore: set Ruby namespace in proto options

## Version 1.0.0-beta02, released 2020-03-18

No API surface changes compared with 1.0.0-beta01, just dependency
and implementation changes

## Version 1.0.0-beta01, released 2020-02-19

Initial beta release.
