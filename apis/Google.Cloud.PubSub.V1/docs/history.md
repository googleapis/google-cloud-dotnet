# Version history

## Version 3.1.0, released 2022-07-27

### New features

- Add SubscriberClientBuilder ([commit 5f830ac](https://github.com/googleapis/google-cloud-dotnet/commit/5f830acefb771d7a7f0c3f86fc7e71e5b482596e))
- Add PublisherClientBuilder ([commit 09eeaa9](https://github.com/googleapis/google-cloud-dotnet/commit/09eeaa97a1ee617caf1d4b75f0ab97dcc14f1233))

## Version 3.0.0, released 2022-06-29

No API surface changes since 3.0.0-beta01. (See 3.0.0-beta01 release notes for details.)

## Version 3.0.0-beta01, released 2022-06-09

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

## Version 2.10.0, released 2022-05-24

### New features

- Add BigQuery configuration for subscriptions ([commit 93ceda9](https://github.com/googleapis/google-cloud-dotnet/commit/93ceda926233c79d836e1ee2806fce4d29b88a54))

## Version 2.9.0, released 2022-04-04

### Bug fixes

- Increased grpc.max_metadata_size value to 4 M.B. in PublisherClient ([commit a29a5f3](https://github.com/googleapis/google-cloud-dotnet/commit/a29a5f3e89b3be037c64ab2b74ff44199d88cff5))
- Ignore exceptions during Ack/ModifyAckDeadline in SubscriberClient ([commit f36fd61](https://github.com/googleapis/google-cloud-dotnet/commit/f36fd619f2ce50425fda5fb9f19f6ada48fb6f40))

## Version 2.8.0, released 2022-03-22

### Bug fixes

- Increased grpc.max_metadata_size value to 4 M.B. This fixes an issue in SubscriberClient with exactly-once delivery. ([commit e78afdf](https://github.com/googleapis/google-cloud-dotnet/commit/e78afdf41474e38a266a46cb6ae0489ec56a5266))

### New features

- Add IAM mixin to Google.Cloud.PubSub.V1 ([commit fda5e80](https://github.com/googleapis/google-cloud-dotnet/commit/fda5e8020f015dd10f69ffb48f9f751792650015))
- Add exactly once delivery flag ([commit fa0b21c](https://github.com/googleapis/google-cloud-dotnet/commit/fa0b21cba4a3cda5284d1a3b8d324b6f124be541) and [commit e7b592b](https://github.com/googleapis/google-cloud-dotnet/commit/e7b592b4d4b8ec244df4d5439e9ff5337da917a0))
  - This is *only* for the generated code; SubscriberClient has no support yet

## Version 2.7.0, released 2021-09-23

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs
- [Commit 4cc3e58](https://github.com/googleapis/google-cloud-dotnet/commit/4cc3e58): feat: Add topic retention options

## Version 2.6.0, released 2021-08-10

- [Commit 61c5c17](https://github.com/googleapis/google-cloud-dotnet/commit/61c5c17): chore: Remove unused fields in PublisherClient
- [Commit c75f979](https://github.com/googleapis/google-cloud-dotnet/commit/c75f979): Update PubSub ConfigureAwait warning disablement
- [Commit 5fede56](https://github.com/googleapis/google-cloud-dotnet/commit/5fede56): feat: Add method signature for Subscriber.Pull without the deprecated return_immediately field.
- [Commit 887ec05](https://github.com/googleapis/google-cloud-dotnet/commit/887ec05): feat: Adding subscription properties to streaming pull response in third party pubsub.proto.

## Version 2.5.0, released 2021-05-26

- [Commit 3717e0d](https://github.com/googleapis/google-cloud-dotnet/commit/3717e0d): Regenerate all APIs with generator change for deprecation
- [Commit 5022a1e](https://github.com/googleapis/google-cloud-dotnet/commit/5022a1e): Use CopySettingsForEmulator in PubSub clients
- [Commit 8e6076e](https://github.com/googleapis/google-cloud-dotnet/commit/8e6076e): docs: Remove experimental note for schema APIs

## Version 2.4.0, released 2021-02-24

- [Commit a43730c](https://github.com/googleapis/google-cloud-dotnet/commit/a43730c): fix: PublisherClient required credentials even when using the emulator. Fixes [issue 5973](https://github.com/googleapis/google-cloud-dotnet/issues/5973)
- [Commit 071ea6f](https://github.com/googleapis/google-cloud-dotnet/commit/071ea6f): Add sync Create() method to PublisherClient and SubscriberClient ([issue 5895](https://github.com/googleapis/google-cloud-dotnet/issues/5895))

## Version 2.3.0, released 2021-01-25

- [Commit 68db70f](https://github.com/googleapis/google-cloud-dotnet/commit/68db70f): fix: Fix error where the lease-extension-delay could be negative. Fixes [issue 5866](https://github.com/googleapis/google-cloud-dotnet/issues/5866)
- [Commit d856a51](https://github.com/googleapis/google-cloud-dotnet/commit/d856a51): feat: add schema service
- [Commit 66574a8](https://github.com/googleapis/google-cloud-dotnet/commit/66574a8): feat: Provide emulator detection in PublisherClient/SubscriberClient

## Version 2.2.0, released 2020-12-02

- [Commit 0ce91bb](https://github.com/googleapis/google-cloud-dotnet/commit/0ce91bb): feat: Enable server side flow control by default with the option to turn it off (see below)
- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

As of this release, flow control settings are enforced at the client
and are also sent to the Cloud Pub/Sub server but not enforced on
the server side yet. Server side flow control is on track to be
enabled by the 2nd week of December 2020. Users that face issues
with server side flow control can disable it by setting
`SubscriberClient.Settings.UseLegacyFlowControl`# to `true` which
will result in the enforcement of client side flow control only.

## Version 2.1.0, released 2020-08-03

- [Commit 330b04e](https://github.com/googleapis/google-cloud-dotnet/commit/330b04e): Fix: PubSub methods will now be retried appropriately. Fixes [issue 5225](https://github.com/googleapis/google-cloud-dotnet/issues/5225)
- [Commit 0cd128c](https://github.com/googleapis/google-cloud-dotnet/commit/0cd128c): docs: Remove experimental warning for ordering keys properties. ([issue 5219](https://github.com/googleapis/google-cloud-dotnet/issues/5219))
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 6165e07](https://github.com/googleapis/google-cloud-dotnet/commit/6165e07): feat: Add support for server-side streaming pull flow control ([issue 5119](https://github.com/googleapis/google-cloud-dotnet/issues/5119))
- [Commit 2c5f3c1](https://github.com/googleapis/google-cloud-dotnet/commit/2c5f3c1): feat: Add flow control settings for StreamingPullRequest to pubsub.proto
- [Commit b5500f5](https://github.com/googleapis/google-cloud-dotnet/commit/b5500f5): docs: Add a link to Pub/Sub filtering language public documentation to pubsub.proto
- [Commit ac924f2](https://github.com/googleapis/google-cloud-dotnet/commit/ac924f2): feat: Add "detached" bool to Subscription
- [Commit f3eeca0](https://github.com/googleapis/google-cloud-dotnet/commit/f3eeca0): docs: Add comment for MessageStoragePolicy message
- [Commit 1dae64f](https://github.com/googleapis/google-cloud-dotnet/commit/1dae64f): fix: Use correct resource type for DetachSubscriptionRequest
- [Commit 5f5b8aa](https://github.com/googleapis/google-cloud-dotnet/commit/5f5b8aa): feat: DetachSubscription RPC
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 777b926](https://github.com/googleapis/google-cloud-dotnet/commit/777b926): docs: Removing the experimental tag from dead letter policy related fields.
- [Commit 8cd3929](https://github.com/googleapis/google-cloud-dotnet/commit/8cd3929): docs: Removing experimental tag from DeadLetterPolicy for Cloud Pub/Sub.

## Version 2.0.0, released 2020-04-09

- [Commit 26de65c](https://github.com/googleapis/google-cloud-dotnet/commit/26de65c): Fix: Fix comment around default AckDeadline
- [Commit b872180](https://github.com/googleapis/google-cloud-dotnet/commit/b872180): docs: treat a dummy example URL as a string literal instead of a link
- [Commit ab949d1](https://github.com/googleapis/google-cloud-dotnet/commit/ab949d1): Feature: experimental Subscription.Filter property

First GA release targeting GAX 3.0.0.

## Version 2.0.0-beta02, released 2020-03-18

- [Commit 2096b6d](https://github.com/googleapis/google-cloud-dotnet/commit/2096b6d): Feature: Subscription.RetryPolicy
- [Commit e4226b7](https://github.com/googleapis/google-cloud-dotnet/commit/e4226b7):
  - Regenerate Google.Cloud.PubSub.V1 ([issue 4515](https://github.com/googleapis/google-cloud-dotnet/issues/4515))
  - PullRequest.ReturnImmediately is now obsolete
  - ListTopicSnapshots methods have new overloads accepting a topic name
  - GetSnapshot methods have new overloads accepting a snapshot name

Additionally, dependencies have been updated to target GAX 3.0.0.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

Additional significant changes in this release:

- [Commit 173b019](https://github.com/googleapis/google-cloud-dotnet/commit/173b019): Dead-letter queue support in subscriber client

## Version 1.2.0-beta01, released 2020-01-06

- [Commit d859592](https://github.com/googleapis/google-cloud-dotnet/commit/d859592): Fully enable ordering-keys ([issue 3921](https://github.com/googleapis/google-cloud-dotnet/issues/3921))
- [Commit e13ab00](https://github.com/googleapis/google-cloud-dotnet/commit/e13ab00): Update default settings; add maximum total lease extension ([issue 3920](https://github.com/googleapis/google-cloud-dotnet/issues/3920))

## Version 1.1.0, released 2019-12-10

Note that support is present in the code for ordering keys, but it's currently disabled; it will be enabled in a future release.

- [Commit 5742d91](https://github.com/googleapis/google-cloud-dotnet/commit/5742d91): Adds ReceivedMessage.DeliveryAttempt
- [Commit 1784804](https://github.com/googleapis/google-cloud-dotnet/commit/1784804): Adds dead letter policy
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Add format method for all resource name types
- [Commit c3af927](https://github.com/googleapis/google-cloud-dotnet/commit/c3af927): Fix error in handling non-ordered batch errors ([issue 3133](https://github.com/googleapis/google-cloud-dotnet/issues/3133))
- [Commit 7f24b13](https://github.com/googleapis/google-cloud-dotnet/commit/7f24b13): Minor fix for memory leak risk ([issue 3120](https://github.com/googleapis/google-cloud-dotnet/issues/3120))
- [Commit afa4a96](https://github.com/googleapis/google-cloud-dotnet/commit/afa4a96): Pubsub client ordering-keys ([issue 3099](https://github.com/googleapis/google-cloud-dotnet/issues/3099))
- [Commit ee5c7dc](https://github.com/googleapis/google-cloud-dotnet/commit/ee5c7dc): Add client builders for simplified configuration
- [Commit 0609777](https://github.com/googleapis/google-cloud-dotnet/commit/0609777): Dispose correctly, and properly ignore cancellation ([issue 3083](https://github.com/googleapis/google-cloud-dotnet/issues/3083))
- [Commit 397623e](https://github.com/googleapis/google-cloud-dotnet/commit/397623e): Adds KMS support
- [Commit 1424e89](https://github.com/googleapis/google-cloud-dotnet/commit/1424e89): Adds method overloads accepting strings for methods accepting resource names
- [Commit ddc2de2](https://github.com/googleapis/google-cloud-dotnet/commit/ddc2de2): Adds ordering keys in the underlying API, but no specific support
- [Commit 5a18d38](https://github.com/googleapis/google-cloud-dotnet/commit/5a18d38): Adds OidcToken and AuthenticationMethod
- [Commit e664cad](https://github.com/googleapis/google-cloud-dotnet/commit/e664cad): Create pubsub channels with correct unique-per-channel id ([issue 2798](https://github.com/googleapis/google-cloud-dotnet/issues/2798))
- [Commit 61cd808](https://github.com/googleapis/google-cloud-dotnet/commit/61cd808): Avoid unobserved InvalidOperationException in AsyncSingleRecvQueue ([issue 2785](https://github.com/googleapis/google-cloud-dotnet/issues/2785)). Fixes [issue 2763](https://github.com/googleapis/google-cloud-dotnet/issues/2763)
- [Commit 1d0c50c](https://github.com/googleapis/google-cloud-dotnet/commit/1d0c50c): Adds ExpirationPolicy

## Version 1.0.0, released 2018-10-08

Initial GA release.
