# Version history

## Version 2.6.0, released 2025-11-05

### New features

- Update dependencies

### Documentation improvements

- Fix broken link in comment for field `OperationMetadata.requested_cancellation`

## Version 2.5.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.3.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.2.0, released 2023-09-04

## Breaking change

The resource annotation for `CreateConnectionProfileRequest.Parent`
has changed from referring to a `ConnectionProfileName` to a
`LocationName`.
This means
`CreateConnectionProfileRequest.ParentAsConnectionProfileName` has
been removed, and
`CreateConnectionProfileRequest.ParentAsLocationName` has replaced it.

Although this is clearly a breaking change (as removing a public
property always is), we have not taken a major version bump as any
customers whose source code is broken by this would already have
been broken when making a request. Customers whose code is already
working will not be affected.

### New features

- Adding GenerateTcpProxyScript API ([commit 8c998c6](https://github.com/googleapis/google-cloud-dotnet/commit/8c998c684d4cb839a9fc6452b1046235bef8599e))
- Add MappingRule resource and CRUD operations ([commit 8c998c6](https://github.com/googleapis/google-cloud-dotnet/commit/8c998c684d4cb839a9fc6452b1046235bef8599e))
- Support for PostgreSQL 15 ([commit 8c998c6](https://github.com/googleapis/google-cloud-dotnet/commit/8c998c684d4cb839a9fc6452b1046235bef8599e))
- Add support for CloudSQL editions ([commit 8c998c6](https://github.com/googleapis/google-cloud-dotnet/commit/8c998c684d4cb839a9fc6452b1046235bef8599e))
- Add support for VLDB migrations ([commit 8c998c6](https://github.com/googleapis/google-cloud-dotnet/commit/8c998c684d4cb839a9fc6452b1046235bef8599e))
- Add SSL config to Oracle Connection Profile ([commit 8c998c6](https://github.com/googleapis/google-cloud-dotnet/commit/8c998c684d4cb839a9fc6452b1046235bef8599e))
- Change CreateConnectionProfileRequest resource reference ([commit 8c998c6](https://github.com/googleapis/google-cloud-dotnet/commit/8c998c684d4cb839a9fc6452b1046235bef8599e))
- Change ImportMappingRulesRequest and DescribeDatabaseEntitiesRequest fields to required ([commit 8c998c6](https://github.com/googleapis/google-cloud-dotnet/commit/8c998c684d4cb839a9fc6452b1046235bef8599e))

## Version 2.1.0, released 2023-05-26

### New features

- Add Oracle to PostgreSQL migration APIs ([commit fcf9391](https://github.com/googleapis/google-cloud-dotnet/commit/fcf93912233be05f0f170eb3472ca3a23f8d0815))

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


## Version 1.2.0, released 2021-10-12

- [Commit 8e7d0f8](https://github.com/googleapis/google-cloud-dotnet/commit/8e7d0f8): docs: Fix NOT_STARTED state documentation in MigrationJob resource

## Version 1.1.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-06-16

- [Commit 5be25f6](https://github.com/googleapis/google-cloud-dotnet/commit/5be25f6): docs: update link in comments

Other than the comment change shown above, this is just a dependency
update and promotion to GA.

## Version 1.0.0-beta01, released 2021-05-11

Initial release.
