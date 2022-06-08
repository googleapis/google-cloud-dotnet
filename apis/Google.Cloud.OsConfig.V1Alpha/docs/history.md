# Version history

## Version 2.0.0-alpha01, released 2022-06-08

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


## Version 1.0.0-alpha04, released 2022-02-14

### Bug fixes

- Fix description of an interpreter field, validate if the field is not unspecified ([commit 5383e6f](https://github.com/googleapis/google-cloud-dotnet/commit/5383e6fac5edde770d475cabd458b3ae89689524))
## Version 1.0.0-alpha03, released 2021-09-24

- [Commit c38ba1f](https://github.com/googleapis/google-cloud-dotnet/commit/c38ba1f): feat: Update osconfig v1 and v1alpha with WindowsApplication
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-alpha02, released 2021-06-22

- [Commit bf2ca0a](https://github.com/googleapis/google-cloud-dotnet/commit/bf2ca0a): feat: OSConfig: add ExecResourceOutput and per step error message.

## Version 1.0.0-alpha01, released 2021-05-12

First (alpha) release.


