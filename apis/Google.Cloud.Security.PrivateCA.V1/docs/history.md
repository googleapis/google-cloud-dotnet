# Version history

## Version 3.10.0, released 2025-07-09

### New features

- Add RDN sequence
- Add User Defined Access URLs
- Add backdate duration
- Adds tbs_certificate_digest to CertificateDescription

## Version 3.9.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 3.8.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.7.0, released 2024-04-19

### New features

- Add encoding format to `.google.cloud.security.privateca.v1.CaPool` Resource ([commit 260057c](https://github.com/googleapis/google-cloud-dotnet/commit/260057cebe44759acd64ec7780866f99bb127cea))

### Documentation improvements

- A comment for field `maximum_lifetime` in message `.google.cloud.security.privateca.v1.CaPool` is changed ([commit 260057c](https://github.com/googleapis/google-cloud-dotnet/commit/260057cebe44759acd64ec7780866f99bb127cea))
- A comment for field `maximum_lifetime` in message `.google.cloud.security.privateca.v1.CertificateTemplate` is changed ([commit 260057c](https://github.com/googleapis/google-cloud-dotnet/commit/260057cebe44759acd64ec7780866f99bb127cea))
- A comment for field `subject_key_id` in message `.google.cloud.security.privateca.v1.CertificateConfig` is changed ([commit 260057c](https://github.com/googleapis/google-cloud-dotnet/commit/260057cebe44759acd64ec7780866f99bb127cea))
- A comment for method `FetchCaCerts` in service `CertificateAuthorityService` is changed ([commit 260057c](https://github.com/googleapis/google-cloud-dotnet/commit/260057cebe44759acd64ec7780866f99bb127cea))
- A comment for field `ignore_dependent_resources` in message `.google.cloud.security.privateca.v1.DisableCertificateAuthorityRequest` is changed ([commit 260057c](https://github.com/googleapis/google-cloud-dotnet/commit/260057cebe44759acd64ec7780866f99bb127cea))
- A comment for field `ignore_dependent_resources` in message `.google.cloud.security.privateca.v1.DeleteCertificateAuthorityRequest` is changed ([commit 260057c](https://github.com/googleapis/google-cloud-dotnet/commit/260057cebe44759acd64ec7780866f99bb127cea))
- A comment for field `ignore_dependent_resources` in message `.google.cloud.security.privateca.v1.DeleteCaPoolRequest` is changed ([commit 260057c](https://github.com/googleapis/google-cloud-dotnet/commit/260057cebe44759acd64ec7780866f99bb127cea))
- A comment for field `ca_certs` in message `.google.cloud.security.privateca.v1.FetchCaCertsResponse` is changed ([commit 260057c](https://github.com/googleapis/google-cloud-dotnet/commit/260057cebe44759acd64ec7780866f99bb127cea))

## Version 3.6.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.5.0, released 2024-03-21

### New features

- Add custom subject key identifier field ([commit 647855a](https://github.com/googleapis/google-cloud-dotnet/commit/647855a2168e237aa07731c959da23e7194be189))
- Add support for fine-grained maximum certificate lifetime controls ([commit 647855a](https://github.com/googleapis/google-cloud-dotnet/commit/647855a2168e237aa07731c959da23e7194be189))

### Documentation improvements

- A comment for field `subject` in message `.google.cloud.security.privateca.v1.CertificateConfig` is changed ([commit 647855a](https://github.com/googleapis/google-cloud-dotnet/commit/647855a2168e237aa07731c959da23e7194be189))
- A comment for method `FetchCaCerts` in service `CertificateAuthorityService` is changed ([commit 647855a](https://github.com/googleapis/google-cloud-dotnet/commit/647855a2168e237aa07731c959da23e7194be189))
- A comment for field `ca_certs` in message `.google.cloud.security.privateca.v1.FetchCaCertsResponse` is changed ([commit 647855a](https://github.com/googleapis/google-cloud-dotnet/commit/647855a2168e237aa07731c959da23e7194be189))

## Version 3.4.0, released 2024-02-29

No API surface changes; just dependency updates.

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
