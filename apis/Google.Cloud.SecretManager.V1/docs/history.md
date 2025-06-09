# Version history

## Version 2.6.0, released 2025-06-09

### New features

- Update secret manager protos for tags

### Documentation improvements

- Updated comment for `customer_managed_encryption` in message `.google.cloud.secretmanager.v1.Secret`
- Updated comment for `scheduled_destroy_time` in message `.google.cloud.secretmanager.v1.SecretVersion`
- Updated comment for `customer_managed_encryption` in message `.google.cloud.secretmanager.v1.SecretVersion`
- Updated comment for `Replication`
- Updated comment for `name` in message `.google.cloud.secretmanager.v1.Topic`

## Version 2.5.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.4.0, released 2024-04-22

### New features

- Add Secret Version Delayed Destroy changes for client libraries ([commit 88109d4](https://github.com/googleapis/google-cloud-dotnet/commit/88109d4ef7e80a8b3aca73c85594b069b555583e))

### Documentation improvements

- Users can now enable secret version delayed destruction ([commit 88109d4](https://github.com/googleapis/google-cloud-dotnet/commit/88109d4ef7e80a8b3aca73c85594b069b555583e))

## Version 2.3.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.2.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 2.1.0, released 2023-01-11

### New features

- Update public API to include annotation support ([commit 0ff9d08](https://github.com/googleapis/google-cloud-dotnet/commit/0ff9d08c8f593ffb75bf20b0d95245f21a29710f))
- Enable REST transport in selected APIs. Set GrpcAdapter=RestGrpcAdapter.Default in the client builder to use this transport

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


## Version 1.9.0, released 2022-04-26

### New features

- Added support for accessing secret versions by alias ([commit 5102b66](https://github.com/googleapis/google-cloud-dotnet/commit/5102b66e3843295b60aa3c89e74999da46bd8e15))
## Version 1.8.0, released 2022-02-07

### New features

- Users can now use checksums for data integrity assurance when adding and accessing SecretVersions ([commit 58ebe8d](https://github.com/googleapis/google-cloud-dotnet/commit/58ebe8d7bb4137d0983cf5319f7f1266dd42147a))
## Version 1.7.0, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.6.0, released 2021-08-10

- [Commit 9bd536a](https://github.com/googleapis/google-cloud-dotnet/commit/9bd536a): feat: In Secret Manager, users can now use filter to customize the output of ListSecrets/ListSecretVersions calls
- [Commit edf114d](https://github.com/googleapis/google-cloud-dotnet/commit/edf114d):
  - feat: Tune Secret Manager auto retry parameters
  - UNKNOWN removed from retryable errors per AIP-194. Added RESOURCE_EXHAUSTED with adjusted parameters for better performance with spikes of AccessSecretVersion requests at or near quota limits.

## Version 1.5.0, released 2021-06-22

- [Commit fbd2e65](https://github.com/googleapis/google-cloud-dotnet/commit/fbd2e65): - feat: Etags - users can now use etags for optimistic concurrency control when modifying Secret or SecretVersion.

## Version 1.4.0, released 2021-05-05

- [Commit 5e2fe40](https://github.com/googleapis/google-cloud-dotnet/commit/5e2fe40): feat: Rotation for Secrets
- [Commit 28c6ac6](https://github.com/googleapis/google-cloud-dotnet/commit/28c6ac6): feat: added topic field to Secret

## Version 1.3.0, released 2021-01-20

- [Commit 9bd5f77](https://github.com/googleapis/google-cloud-dotnet/commit/9bd5f77): feat: added expire_time and ttl fields to Secret

## Version 1.2.0, released 2020-11-09

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

## Version 1.1.0, released 2020-09-10

- [Commit 45c0cff](https://github.com/googleapis/google-cloud-dotnet/commit/45c0cff): New feature: customer managed encryption keys
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): Regenerate all APIs with generator changes for timeouts
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): Regenerate all clients with more explicit documentation
- [Commit 028f418](https://github.com/googleapis/google-cloud-dotnet/commit/028f418): Update to SecretManager documentation
- [Commit 617763f](https://github.com/googleapis/google-cloud-dotnet/commit/617763f): Document Secret ID character limitations

## Version 1.0.0, released 2020-03-19

No API surface changes compared with 1.0.0-beta01, just dependency
and implementation changes.

This is the first GA release for this API.

## Version 1.0.0-beta01, released 2020-02-26

Initial beta release.
