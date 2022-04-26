# Version history

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
