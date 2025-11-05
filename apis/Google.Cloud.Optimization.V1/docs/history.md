# Version history

## Version 2.7.0, released 2025-11-05

### New features

- Update dependencies

## Version 2.6.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.5.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.4.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.3.0, released 2023-10-30

### New features

- Added the route modifiers ([commit a7431da](https://github.com/googleapis/google-cloud-dotnet/commit/a7431dad485ead7d2e60dbcd4cff258d0898611f))

## Version 2.2.0, released 2023-09-11

### New features

- Added support for walking mode and cost_per_kilometer_below_soft_max ([commit ad1f21c](https://github.com/googleapis/google-cloud-dotnet/commit/ad1f21c26a890aa20f68e8521b2746a8427996cb))

### Documentation improvements

- Minor formatting fix ([commit 0a0b732](https://github.com/googleapis/google-cloud-dotnet/commit/0a0b732a4e07f18f70085b524af978cbf79a2a57))
- Minor formatting ([commit 0d3ca27](https://github.com/googleapis/google-cloud-dotnet/commit/0d3ca27514dd40c9f0325692508c991b3eeeb350))
- Clarification for deprecated fields ([commit 4a99682](https://github.com/googleapis/google-cloud-dotnet/commit/4a99682d647b486f3eca9154452779a693565f16))

## Version 2.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

### Documentation improvements

- Fix minor docstring formatting ([commit dd7d952](https://github.com/googleapis/google-cloud-dotnet/commit/dd7d952d23d4fb91815edcbca9f15e6462158b23))

## Version 2.0.0, released 2022-09-15

No API surface changes; just dependency updates and promotion to GA.

## Version 2.0.0-beta01, released 2022-06-09

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

## Version 1.0.0-beta01, released 2022-05-13

Initial release.
