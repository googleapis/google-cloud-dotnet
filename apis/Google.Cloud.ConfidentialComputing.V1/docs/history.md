# Version history

## Version 1.7.0, released 2024-12-06

### New features

- Add a token_type options proto to allow for customization of specific token types. Added the first token type option to hold principal tag token options ([commit 4bf271b](https://github.com/googleapis/google-cloud-dotnet/commit/4bf271b8ae073fb8915a01e4f58be3647a20a49a))

## Version 1.6.0, released 2024-07-22

### New features

- Add a new field `tee_attestation` to `VerifyAttestationRequest` message proto for SEV SNP and TDX attestations ([commit b087c55](https://github.com/googleapis/google-cloud-dotnet/commit/b087c557e634a648a2ecfdf9340309334697f8de))

## Version 1.5.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.4.0, released 2024-03-27

### New features

- Add additional `TokenType` options (`TOKEN_TYPE_PKI` and `TOKEN_TYPE_LIMITED_AWS`) ([commit 5d1d8fe](https://github.com/googleapis/google-cloud-dotnet/commit/5d1d8fe7295eeb162356566e737d784c10e5da85))

## Version 1.3.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.2.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 1.1.0, released 2023-11-13

### New features

- Add a new field `token_type` to `TokenOptions` message proto ([commit e15fa62](https://github.com/googleapis/google-cloud-dotnet/commit/e15fa62d37e78fb4d17f9431af1453836bb58d4f))

## Version 1.0.0, released 2023-11-01

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta04, released 2023-08-16

### New features

- Add a new field `partial_errors` to `VerifyAttestationResponse` proto ([commit ce8f831](https://github.com/googleapis/google-cloud-dotnet/commit/ce8f831ef4bb474edba185294920dbe3fed2b14a))

## Version 1.0.0-beta03, released 2023-08-07

### New features

- Mark all fields `Optional` for `ContainerImageSignagure` proto ([commit 99f3e64](https://github.com/googleapis/google-cloud-dotnet/commit/99f3e6426111bcf0def62f479c2c6d9b04d42ba9))

## Version 1.0.0-beta02, released 2023-08-04

### New features

- Added support for signed container image and custom audience and nonce requests ([commit 8a1370f](https://github.com/googleapis/google-cloud-dotnet/commit/8a1370f5f2731fc5b80a9a4b9b81f831da158886))

## Version 1.0.0-beta01, released 2023-04-19

Initial release.
