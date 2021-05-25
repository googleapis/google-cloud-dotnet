# Version history

# Version 3.1.0, released 2021-05-25

- [Commit 3717e0d](https://github.com/googleapis/google-cloud-dotnet/commit/3717e0d): Regenerate all APIs with generator change for deprecation

# Version 3.0.0, released 2020-09-28

- [Commit 924f350](https://github.com/googleapis/google-cloud-dotnet/commit/924f350): fix!: Remove obsolete `Datasource` code
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/924f350): chore!: Regenerate all APIs with new protoc/gRPC tooling
  - This is a subtly breaking change, as the gRPC client constructor accepting a Channel parameter has been changed to accept ChannelBase.
    We don't expect this to actually break customers, but it is definitely a binary-incompatible change.
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Regenerate all APIs with improved timeout behavior
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 0c88ce0](https://github.com/googleapis/google-cloud-dotnet/commit/0c88ce0): feat: Add a new AuthorizationType for Data Source Definition.

# Version 2.0.0, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependencies
and implementation changes.

# Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

# Version 1.1.0, released 2019-12-10

- [Commit c0001b5](https://github.com/googleapis/google-cloud-dotnet/commit/c0001b5): Adds service account, email and PubSub options.
- [Commit cc6ec31](https://github.com/googleapis/google-cloud-dotnet/commit/cc6ec31): Introduces a oneof for TransferConfig.Destination and TransferRun.Destingation.
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Adds a Format method for all resource name classes

# Version 1.0.0, released 2019-07-10

Initial GA release.
