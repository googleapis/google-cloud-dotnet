# Version history

## Version 2.5.0, released 2025-11-06

### New features

- Update dependencies

## Version 2.4.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.3.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.2.0, released 2024-02-29

### Documentation improvements

- Update docs to existing services ([commit 68f3129](https://github.com/googleapis/google-cloud-dotnet/commit/68f312905d3b1716c50a24247b80f73a37a212b4))

## Version 2.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit f6a1c3e](https://github.com/googleapis/google-cloud-dotnet/commit/f6a1c3e8930f0e8209a079352765be3bb9039be2))

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


## Version 1.5.0, released 2022-04-26

### Documentation improvements

- Fix broken links ([commit c6cef48](https://github.com/googleapis/google-cloud-dotnet/commit/c6cef48acd6124c4a724695e501f2b6943233021))
- Fix remaining broken links ([commit 129c7cb](https://github.com/googleapis/google-cloud-dotnet/commit/129c7cbad009a12a5fc9273d6bb9e34e280c0dd7))
## Version 1.4.0, released 2022-02-15

### Bug fixes

- **BREAKING CHANGE** Remove EnableService and DisableService RPC methods and related protos from service management API ([commit d5cb1ab](https://github.com/googleapis/google-cloud-dotnet/commit/d5cb1abcd3ed51c1b1d22b622900fac9caf727ca))

The breaking change here reflects the actual API; the `EnableService` and `DisableService` RPCs have not been available for some time. In other words, this change will not break any customer who isn't already broken in terms of making RPCs. (It may break mock/fake test code which expects those RPCs to still be available, however.)

## Version 1.3.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.2.0, released 2021-06-22

- [Commit 3717e0d](https://github.com/googleapis/google-cloud-dotnet/commit/3717e0d): Regenerate all APIs with generator change for deprecation

## Version 1.1.0, released 2021-04-29

No API surface changes; minor update due to dependencies

## Version 1.0.0, released 2020-11-18

First GA release.

- [Commit 7b21712](https://github.com/googleapis/google-cloud-dotnet/commit/7b21712): chore: Set namespaces for Ruby clients

## Version 1.0.0-beta01, released 2020-10-15

Initial beta release.


