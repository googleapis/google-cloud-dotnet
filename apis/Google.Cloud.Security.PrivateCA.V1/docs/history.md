# Version history

## Version 3.3.0, released 2023-04-12

### New features

- Added ignore_dependent_resources to DeleteCaPoolRequest, DeleteCertificateAuthorityRequest, DisableCertificateAuthorityRequest ([commit ca8e6ba](https://github.com/googleapis/google-cloud-dotnet/commit/ca8e6babb24933c41c4b546965de8b88350a178c))

## Version 3.2.0, released 2023-02-22

### New features

- Add X.509 Name Constraints support ([commit c8464c9](https://github.com/googleapis/google-cloud-dotnet/commit/c8464c97d205d49bd267aeff3aad64165f7d89dd))

## Version 3.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit f6a1c3e](https://github.com/googleapis/google-cloud-dotnet/commit/f6a1c3e8930f0e8209a079352765be3bb9039be2))

## Version 3.0.0, released 2022-06-08

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


## Version 2.3.0, released 2022-03-14

### New features

- Add `skip_grace_period` flag to DeleteCertificateAuthority API ([commit d0de3d1](https://github.com/googleapis/google-cloud-dotnet/commit/d0de3d167a94360d35b5a01185749ba735c1cf26))

## Version 2.2.0, released 2022-02-22

### New features

- Add IAM and Location mixins to Google.Cloud.Security.PrivateCA.V1 ([commit d2ea336](https://github.com/googleapis/google-cloud-dotnet/commit/d2ea3361882a5be55cccde97fba443490b8052dd))

### Documentation improvements

- Mark CaPool.lifetime as IMMUTABLE ([commit 0139338](https://github.com/googleapis/google-cloud-dotnet/commit/01393381b9badc4e9e6c36bbe85dc8c74a9c2fdf))
- Add format requirements on `custom_sans` ([commit 0139338](https://github.com/googleapis/google-cloud-dotnet/commit/01393381b9badc4e9e6c36bbe85dc8c74a9c2fdf))

## Version 2.1.0, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.0.0, released 2021-07-16

- [Commit f09fdff](https://github.com/googleapis/google-cloud-dotnet/commit/f09fdff): fix!: mark some bools as optional, correct response type of DeleteCaPool

This is a new major version as the change in response type for
`DeleteCaPool` is a breaking change. Customers using the 1.x libraries
are encouraged to upgrade, as attempting to obtain the result of the
operation created by the `DeleteCaPool` RPC will throw an exception
at execution time.

## Version 1.0.0, released 2021-06-28

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2021-06-08

Initial release.
