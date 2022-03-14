# Version history

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
