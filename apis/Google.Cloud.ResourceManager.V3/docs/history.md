# Version history

## Version 2.6.0, released 2025-11-06

### New features

- Update dependencies

## Version 2.5.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.3.0, released 2024-02-29

### Documentation improvements

- Update formatting for `Purpose` class documentation ([commit 162977d](https://github.com/googleapis/google-cloud-dotnet/commit/162977db9e125b809c8758ef7a176d36717ca166))
- Add documentation for additional acceptable formats for `namespaced_tag_key` and `namespaced_tag_value`in `EffectiveTag`, `parent` in `ListTagKeysRequest`, `parent` in `TagKey`, and `namespaced_name` in `TagValue` ([commit 162977d](https://github.com/googleapis/google-cloud-dotnet/commit/162977db9e125b809c8758ef7a176d36717ca166))
- Update the table format in SearchProjects docs ([commit 6e0900b](https://github.com/googleapis/google-cloud-dotnet/commit/6e0900b77422408914a86baeae4d672168c1173f))

## Version 2.2.0, released 2023-04-21

### New features

- Add TagHolds, GetNamespacedTagKey, and GetNamespacedTagValue APIs. Adds support for project parented tags ([commit debfa3e](https://github.com/googleapis/google-cloud-dotnet/commit/debfa3ec0e61495e9001a76da7fc8dd09d082675))

## Version 2.1.0, released 2023-01-18

### New features

- Enable REST transport in C# ([commit 0f8560c](https://github.com/googleapis/google-cloud-dotnet/commit/0f8560c840725bf41bc060c8beecafc7d99f38eb))

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


## Version 1.2.0, released 2021-12-07

- [Commit 1964fe9](https://github.com/googleapis/google-cloud-dotnet/commit/1964fe9): docs: fix docstring formatting
- [Commit 5adca20](https://github.com/googleapis/google-cloud-dotnet/commit/5adca20): docs: fix docstring formatting
## Version 1.1.0, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-07-19

No API changes - just promotion to GA.

## Version 1.0.0-beta01, released 2021-06-28

Initial release.
