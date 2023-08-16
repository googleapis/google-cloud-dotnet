# Version history

## Version 2.5.0, released 2023-08-16

### New features

- Add new enum values for network firewall policies to API ([commit afe1ef0](https://github.com/googleapis/google-cloud-dotnet/commit/afe1ef01835f2cf1013235530e6bdb17f1a50cc7))
- Add fields related to Google services to API ([commit d9335c6](https://github.com/googleapis/google-cloud-dotnet/commit/d9335c6b61c775c2a02f5fbd198a65a3d2466f4e))
- Add fields related to PBR and NCC routes to API ([commit 6aeae60](https://github.com/googleapis/google-cloud-dotnet/commit/6aeae60337721dcd53545c3a03ba884d2cb3e25e))
- Add new abort and drop causes to API ([commit 193519f](https://github.com/googleapis/google-cloud-dotnet/commit/193519f300eb174a6e6ba10a3581e0752c29d7d3))
- Add fields related to load balancers to API ([commit 41b656d](https://github.com/googleapis/google-cloud-dotnet/commit/41b656d83ed1fee5688871111bb6e7b828552f4b))
- Add dynamic probing fields to v1 API ([commit a9b44ac](https://github.com/googleapis/google-cloud-dotnet/commit/a9b44acc0e99e478e601a754ebffef4036697c3a))
## Version 2.4.0, released 2023-06-27

### New features

- Add forwarding_rule field to Connectivity Test Endpoint proto ([commit 73e23cb](https://github.com/googleapis/google-cloud-dotnet/commit/73e23cbd9816fb4b1f1d4ede8d011f9393974225))

### Documentation improvements

- Update comments in Connectivity Test protos ([commit 874831c](https://github.com/googleapis/google-cloud-dotnet/commit/874831c081fd3f713e108d9ec3835f9f5dfa7cf9))

## Version 2.3.0, released 2023-01-18

### New features

- Enable REST transport in C# ([commit 0f8560c](https://github.com/googleapis/google-cloud-dotnet/commit/0f8560c840725bf41bc060c8beecafc7d99f38eb))

## Version 2.2.0, released 2022-07-25

### New features

- Add new abort cause and new route next hop type ([commit 315900f](https://github.com/googleapis/google-cloud-dotnet/commit/315900f5725c85be5c1279cc6f40e6f28d8d3297))

## Version 2.1.0, released 2022-07-11

### New features

- Introduce a projects_missing_permissions field in the AbortInfo structure ([commit 6f1a4bd](https://github.com/googleapis/google-cloud-dotnet/commit/6f1a4bdf27f364ce96cb71954926e5ce0dc01e00))

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


## Version 1.1.0, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-08-05

No API surface changes; just promotion to GA.

## Version 1.0.0-beta01, released 2021-07-05

Initial release.
