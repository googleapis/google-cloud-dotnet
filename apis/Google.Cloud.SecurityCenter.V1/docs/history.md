# Version history

# Version 2.6.0, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

# Version 2.5.0, released 2021-08-10

- [Commit f8b1856](https://github.com/googleapis/google-cloud-dotnet/commit/f8b1856):
  - feat: add finding_class and indicator fields in Finding

# Version 2.4.0, released 2021-06-22

- [Commit 16f75f9](https://github.com/googleapis/google-cloud-dotnet/commit/16f75f9): docs: update currently supported Finding filter fields.

# Version 2.3.0, released 2021-05-26

- [Commit 6b46c80](https://github.com/googleapis/google-cloud-dotnet/commit/6b46c80): feat: add canonical_name and folder fields

# Version 2.2.0, released 2021-02-08

- [Commit d6c34ac](https://github.com/googleapis/google-cloud-dotnet/commit/d6c34ac):
  - feat: added field severity to findings in v1 API
  - Clients will now see a new field, severity, on findings. They will also be able to filter and group by severity on ListFinding and GroupFinding API calls.

# Version 2.1.0, released 2020-11-10

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 3cc0bc8](https://github.com/googleapis/google-cloud-dotnet/commit/3cc0bc8): docs: Clarified that event_time can also be considered as the "update time" for a Finding. It also captures when a Finding was updated. The previous wording could've been interpreted as only the creation time.
- [Commit ccb9c33](https://github.com/googleapis/google-cloud-dotnet/commit/ccb9c33): fix: correct securitycenter grpc_service_configs
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit d545bad](https://github.com/googleapis/google-cloud-dotnet/commit/d545bad): Specify allowed fields for UpdateNotificationConfig
- [Commit 4c52b95](https://github.com/googleapis/google-cloud-dotnet/commit/4c52b95): feat: Add Resource to the v1 NotificationMessage, which contains resource-related fields associated to the Finding notification. docs: Adjusted wording from Cloud SCC to Security Command Center, and updated filtering docs for List APIs.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

# Version 2.0.0, released 2020-03-19

No API surface changes compared with 2.0.0-beta02, just dependency
and implementation changes.

# Version 2.0.0-beta02, released 2020-03-12

- [Commit 8da93ef](https://github.com/googleapis/google-cloud-dotnet/commit/8da93ef): Adds support for notifications.
- [Commit 11173de](https://github.com/googleapis/google-cloud-dotnet/commit/11173de): Amended retry configuration

# Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

# Version 1.1.0, released 2019-12-10

- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Add format methods to all resource name types

# Version 1.0.0, released 2019-07-10

Initial GA release.
