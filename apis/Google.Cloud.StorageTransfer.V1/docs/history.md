# Version history

## Version 2.7.0, released 2024-09-09

### New features

- Add HDFS configuration ([commit 5c69ed3](https://github.com/googleapis/google-cloud-dotnet/commit/5c69ed3b8486cabbec36853f4489d3b8d77a93a6))
- Add GCS Managed Folders ([commit 5c69ed3](https://github.com/googleapis/google-cloud-dotnet/commit/5c69ed3b8486cabbec36853f4489d3b8d77a93a6))
- Add S3 Managed Private Network ([commit 5c69ed3](https://github.com/googleapis/google-cloud-dotnet/commit/5c69ed3b8486cabbec36853f4489d3b8d77a93a6))
- Add S3 Cloudfront Domain ([commit 5c69ed3](https://github.com/googleapis/google-cloud-dotnet/commit/5c69ed3b8486cabbec36853f4489d3b8d77a93a6))

## Version 2.6.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.5.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.4.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 2.3.0, released 2023-06-27

### New features

- Add event driven transfer configuration ([commit 218b433](https://github.com/googleapis/google-cloud-dotnet/commit/218b4337b70dd78b804137fea48998890382686b))

## Version 2.2.0, released 2023-01-16

### New features

- Enable REST transport in C# ([commit a6c4606](https://github.com/googleapis/google-cloud-dotnet/commit/a6c46063bd961a9dadc728a780d66de772f28e71))

## Version 2.1.0, released 2022-09-15

### New features

- Add default retry configuration ([commit 97a6f02](https://github.com/googleapis/google-cloud-dotnet/commit/97a6f0222a3cfbb3748248e1d840a0a449d8530b))
- Add DeleteTransferJob operation ([commit 97a6f02](https://github.com/googleapis/google-cloud-dotnet/commit/97a6f0222a3cfbb3748248e1d840a0a449d8530b))
- Add AWS S3 compatible data source ([commit 97a6f02](https://github.com/googleapis/google-cloud-dotnet/commit/97a6f0222a3cfbb3748248e1d840a0a449d8530b))

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


## Version 1.2.0, released 2022-04-26

### New features

- Add support for Agent Pools ([commit 28de985](https://github.com/googleapis/google-cloud-dotnet/commit/28de9858c6895e242f93b915e5a51637b8d1fdf5))
- Add support for transfers between file systems ([commit 28de985](https://github.com/googleapis/google-cloud-dotnet/commit/28de9858c6895e242f93b915e5a51637b8d1fdf5))
- Add support for metadata preservation ([commit 28de985](https://github.com/googleapis/google-cloud-dotnet/commit/28de9858c6895e242f93b915e5a51637b8d1fdf5))
- Add support for transferring a specific list of objects (manifest) ([commit 28de985](https://github.com/googleapis/google-cloud-dotnet/commit/28de9858c6895e242f93b915e5a51637b8d1fdf5))
- Add support for Cloud Logging ([commit 28de985](https://github.com/googleapis/google-cloud-dotnet/commit/28de9858c6895e242f93b915e5a51637b8d1fdf5))

## Version 1.1.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-08-16

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2021-07-23

Initial release.
