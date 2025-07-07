# Version history

## Version 3.27.0, released 2025-07-07

### New features

- Add MessageTransformationFailureReason to IngestionFailureEvent

### Documentation improvements

- Document that the `acknowledge_confirmation` and `modify_ack_deadline_confirmation` fields in message `.google.pubsub.v1.StreamingPullResponse` are not guaranteed to be populated

## Version 3.26.0, released 2025-06-17

### Bug fixes

- Change HandleAck retry behavior to check metadata before the exception code

## Version 3.25.0, released 2025-06-16

### New features

- Add SchemaViolationReason to IngestionFailureEvent
- Generate renamed go pubsub admin clients

### Bug fixes

- Forget ordering keys that have no pending messages.

### Documentation improvements

- Standardize spelling of "acknowledgment" in Pub/Sub protos

## Version 3.24.0, released 2025-03-31

### Documentation improvements

- Update documentation for JavaScriptUDF to indicate that the `message_id` metadata field is optional instead of required ([commit 8127313](https://github.com/googleapis/google-cloud-dotnet/commit/8127313c8128619f5526c37b578a17b37bac0f1d))
## Version 3.23.0, released 2025-03-14

### New features

- Add more logs on subscriber pull stream retries ([commit ff5a39b](https://github.com/googleapis/google-cloud-dotnet/commit/ff5a39b9ccc431059a63aa475b1d4f231cb19752))

## Version 3.22.0, released 2025-03-10

### New features

- Deprecate `enabled` field for message transforms and add `disabled` field ([commit d75a0b0](https://github.com/googleapis/google-cloud-dotnet/commit/d75a0b0413aef83a015e6f8dcd87f47d9b3530a7))

### Documentation improvements

- Deprecate `enabled` field for message transforms and add `disabled` field ([commit d75a0b0](https://github.com/googleapis/google-cloud-dotnet/commit/d75a0b0413aef83a015e6f8dcd87f47d9b3530a7))
- A comment for field `code` in message `.google.pubsub.v1.JavaScriptUDF` is changed ([commit e82746a](https://github.com/googleapis/google-cloud-dotnet/commit/e82746acd04df7a91742fd9b77a8b327e6995368))

## Version 3.21.0, released 2025-02-03

### New features

- Add support for message transforms to Topic and Subscription ([commit 97502ea](https://github.com/googleapis/google-cloud-dotnet/commit/97502ea06aaea8de9b80ac62fb9f3f1635d3fc49))

### Documentation improvements

- Fix link for AnalyticsHubSubscriptionInfo ([commit 97502ea](https://github.com/googleapis/google-cloud-dotnet/commit/97502ea06aaea8de9b80ac62fb9f3f1635d3fc49))

## Version 3.20.0, released 2025-01-13

### New features

- Add Kafka-based sources to IngestionDataSourceSettings proto and IngestionFailureEvent proto ([commit 9324e45](https://github.com/googleapis/google-cloud-dotnet/commit/9324e45437b5ac8b7e972edaaa183a366f7d4600))

## Version 3.19.0, released 2024-10-24

### Bug fixes

- Do not throw if a subscriber is disposed before being started ([commit 04b8d8a](https://github.com/googleapis/google-cloud-dotnet/commit/04b8d8abe0da0c5dbd6a6d1ea8a81aa116d1114f))

### New features

- Add IngestionFailureEvent to the external proto ([commit a51bbfd](https://github.com/googleapis/google-cloud-dotnet/commit/a51bbfd7d3c5130b77d0e2a3007e1edb5c27955c))
- Support connection sharing across gRPC channels ([commit 2e16e74](https://github.com/googleapis/google-cloud-dotnet/commit/2e16e743de7bf60afe462692bdbc444f4dcd9ee8))

## Version 3.18.0, released 2024-09-26

No API surface changes; just dependency updates.

## Version 3.17.0, released 2024-09-26

### New features

- Add ingestion Cloud Storage fields and Platform Logging fields to Topic ([commit 5098b56](https://github.com/googleapis/google-cloud-dotnet/commit/5098b5604184c78fac6ba0161a7e081d530f8dd3))
- Return listing information for subscriptions created via Analytics Hub ([commit ce5de77](https://github.com/googleapis/google-cloud-dotnet/commit/ce5de77b8f709c832d824bc739a68182183bec84))

### Documentation improvements

- Update documentation for 31 day subscription message retention ([commit 950f588](https://github.com/googleapis/google-cloud-dotnet/commit/950f5886f0486b86a899a7fe4aaa8b86979b2b89))

## Version 3.16.0, released 2024-07-22

### New features

- Add max messages batching for Cloud Storage subscriptions ([commit 953eefe](https://github.com/googleapis/google-cloud-dotnet/commit/953eefe3499b9a380264d936678f2a073102aac2))

## Version 3.15.0, released 2024-06-24

### New features

- Add use_topic_schema for Cloud Storage Subscriptions ([commit d557116](https://github.com/googleapis/google-cloud-dotnet/commit/d557116c5844dc4fdd4da4637d7713b325d7dfe7))

## Version 3.14.0, released 2024-05-31

### Bug fixes

- Fix possible race condition when restarting the stream ([commit 4410bb1](https://github.com/googleapis/google-cloud-dotnet/commit/4410bb1052c4d03a27387dbcc0d15f140c74da87))

### New features

- Add service_account_email for export subscriptions ([commit f73410e](https://github.com/googleapis/google-cloud-dotnet/commit/f73410e22786bb596defd10d0df9a6ed0d76fe95))
- Make StreamingPull fail after 100 consecutive failures ([commit d9d658b](https://github.com/googleapis/google-cloud-dotnet/commit/d9d658b61ed72dfbb6d37596763db1e44dc7ba34))
- Improve Pub/Sub streaming pull retries ([commit 8537ed4](https://github.com/googleapis/google-cloud-dotnet/commit/8537ed42202121ed6e6108ded101c9d4f59324aa))

The last two of these features can cause user-visible changes. In particular:

- Persistently-failing streaming pulls will eventually cause a SubscriberClient to fail
- Authentication-based failures (e.g. using an expired service account) will now cause a SubscriberClient to fail
- SubscriberClient will retry immediately after a streaming pull stream is terminated server-side, if the pull was active for 45 seconds or more before being terminated. This should improve responsiveness in some situations.

All of these changes should be "net positive", but if they cause any issues, please file a bug.

## Version 3.13.0, released 2024-05-17

### New features

- Improve SubscriberClient logging ([commit a9896c9](https://github.com/googleapis/google-cloud-dotnet/commit/a9896c96a54649be3460025f64c962fb0ad8db93))
- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.12.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))
- Add custom datetime format for Cloud Storage subscriptions ([commit cb33d77](https://github.com/googleapis/google-cloud-dotnet/commit/cb33d7762a0fb1dff89edfcaf751478119ae4801))

## Version 3.11.0, released 2024-03-25

### New features

- Added TopicName and SubsciptionName resolution from container as an extension point. ([issue 12215](https://github.com/googleapis/google-cloud-dotnet/issues/12215)) ([commit 73c457d](https://github.com/googleapis/google-cloud-dotnet/commit/73c457d2f8f915656d9c14eaeb594c189072f4a7))

## Version 3.10.1, released 2024-03-19

### New features

- Add initial logging to PublisherClient and SubscriberClient ([commit 931bd76](https://github.com/googleapis/google-cloud-dotnet/commit/931bd762983688864b5f7fb22bdda6c563435d46))

## Version 3.10.0, released 2024-03-05

### Documentation improvements

- Small fix in Pub/Sub ingestion comments ([commit 663a29c](https://github.com/googleapis/google-cloud-dotnet/commit/663a29c5ad9fc8c8dc6942540e35b60c4d8c2f36))

## Version 3.10.0-beta01, released 2024-02-09

### New features

- Add enforce_in_transit fields and optional annotations ([commit 43c6cd3](https://github.com/googleapis/google-cloud-dotnet/commit/43c6cd3d59c575deed21a1b9de81de66ed6eeee1))
- Add `ingestion_data_source_settings` field to `Topic` ([commit 06f6c30](https://github.com/googleapis/google-cloud-dotnet/commit/06f6c303967d7c433041f7f8c659fe85285eaded))

## Version 3.9.1, released 2024-01-03

### Bug fixes

- Use message ordering enabled property that comes with streaming pull responses so that messages are only delivered to the callback one at a time in order when ordering is actually enabled ([commit 3f8f8a2](https://github.com/googleapis/google-cloud-dotnet/commit/3f8f8a26587dd329cf2a90c6b9952a8ce5fff7f4))

## Version 3.9.0, released 2023-12-04

### New features

- Add `use_table_schema` field to BigQueryConfig ([commit c489a15](https://github.com/googleapis/google-cloud-dotnet/commit/c489a154b2e51add4442b2f9ba9ec6198df0bcee))

## Version 3.8.0, released 2023-11-03

### Bug fixes

- Set x-goog-request-params for streaming pull requests from SubscriberClient ([commit 7b6ec74](https://github.com/googleapis/google-cloud-dotnet/commit/7b6ec741956745af04950cd60a2eb83270f6136c))

### Documentation improvements

- Modified some descriptions ([commit 1dd516c](https://github.com/googleapis/google-cloud-dotnet/commit/1dd516c0c949db896d898808457a4b1e97013499))

## Version 3.7.0, released 2023-09-06

### Bug fixes

- Make retry policy back off more aggressively for RPCs that retry RESOURCE_EXHAUSTD ([commit c5e2b5f](https://github.com/googleapis/google-cloud-dotnet/commit/c5e2b5f81844f6a126c9b5cbe90f8690fad6827f))

### Documentation improvements

- Clarified where ordering_key will be written if write_metadata is set ([commit 2436db1](https://github.com/googleapis/google-cloud-dotnet/commit/2436db17387e39b5e378188fa70c34480d2436b7))
- Tightened requirements on cloud storage subscription filename suffixes ([commit f4d7887](https://github.com/googleapis/google-cloud-dotnet/commit/f4d78878946ab94b60197c245ecf2b34ccec735b))

## Version 3.6.0, released 2023-06-12

### Bug fixes

- Correct the auto-extend lease interval for exactly-once delivery. ([commit c33999d](https://github.com/googleapis/google-cloud-dotnet/commit/c33999d4bed6d7777bd1d1e4bc019d67448ce844))
- Dispose the pull stream. ([commit 3518402](https://github.com/googleapis/google-cloud-dotnet/commit/351840238416353db7a87431ac2f8687537c9352))

### New features

- Add push config wrapper fields ([commit 1cdef74](https://github.com/googleapis/google-cloud-dotnet/commit/1cdef749b46a406e6abea44001db68b9276c338d))
- Add support for Publisher Compression. ([commit e684e05](https://github.com/googleapis/google-cloud-dotnet/commit/e684e05a21cd47042f05b4f4662611e13632bef9))

### Documentation improvements

- Clarify the use of FlowControlSettings in SusbcriberClient. ([commit 7081baf](https://github.com/googleapis/google-cloud-dotnet/commit/7081baf1a5b95aaaa09d513fe380208f8e039c57))

## Version 3.6.0-beta01, released 2023-05-16

Note that this is a beta release as the deadlock workaround for
[issue](https://github.com/googleapis/google-cloud-dotnet/issues/10318) is far
from ideal. We'll create a new GA release when Grpc.Net.Client has been fixed.

### Bug fixes

- Add missing field when creating a SubscriberClient.Settings from another. ([commit 204866c](https://github.com/googleapis/google-cloud-dotnet/commit/204866c229146f888644b30b08b3de150428e9e7))
- Temporary patch for PubSub Subscriber deadlock issue. ([commit d965b93](https://github.com/googleapis/google-cloud-dotnet/commit/d965b9333d819ba3b764b5f62b2ea790504f6e4e))

### New features

- Add cloud storage subscription fields ([commit b3b6104](https://github.com/googleapis/google-cloud-dotnet/commit/b3b6104c8aa408c2df1e1dfe0ecbb06bd4761705))

## Version 3.5.1, released 2023-05-05

### Bug fixes

- Dispose channel on PublisherClient/SubscriberClient shutdown. Fixes [#10304](https://github.com/googleapis/google-cloud-dotnet/issues/10304) ([commit d38ab04](https://github.com/googleapis/google-cloud-dotnet/commit/d38ab04a077662748b5d7725d80ab132899c2996))

## Version 3.5.0, released 2023-04-19

### New features

- Reliability improvements in exactly-once delivery. ([commit 27b2430](https://github.com/googleapis/google-cloud-dotnet/commit/27b2430894ddd1f857ad49a5945282670760fa56))

## Version 3.4.0, released 2023-03-08

### Bug fixes

- Ack/ModAck failures in non exactly once delivery flow should not be retried ([commit a0da1f5](https://github.com/googleapis/google-cloud-dotnet/commit/a0da1f50b682c0c6f2670c85ca6d0356187988be))

### New features

- Make INTERNAL a retryable error for Pull ([commit ad9963e](https://github.com/googleapis/google-cloud-dotnet/commit/ad9963ed3b4620fe205d58a8fbab90b4a3ab443f))
- Add temporary_failed_ack_ids to ModifyAckDeadlineConfirmation ([commit 55fef61](https://github.com/googleapis/google-cloud-dotnet/commit/55fef61f57d98bb450d8f6a85a6d42a5e7d9ac56))
- Add google.api.method.signature to update methods ([commit cf2f61a](https://github.com/googleapis/google-cloud-dotnet/commit/cf2f61aed8aa14479e85edda1e50d23d178e55b9))
- Implemented IAsyncDisposable in PublisherClient and SubscriberClient ([commit 2ae9ab7](https://github.com/googleapis/google-cloud-dotnet/commit/2ae9ab78d14bede0542274f03dd439c95564db55))
- Added IServiceCollection extension methods for PublisherClient and SubscriberClient ([commit fe942e0](https://github.com/googleapis/google-cloud-dotnet/commit/fe942e04efbec32afa3d45e48bf6d9bf2cbf186d))

### Documentation improvements

- Add x-ref for ordering messages ([commit 16a4ddc](https://github.com/googleapis/google-cloud-dotnet/commit/16a4ddc83ed06eda2956b3c5e7e865183289efe3))
- Clarify subscription expiration policy ([commit 16a4ddc](https://github.com/googleapis/google-cloud-dotnet/commit/16a4ddc83ed06eda2956b3c5e7e865183289efe3))
- Clarify BigQueryConfig PERMISSION_DENIED state ([commit 78feab7](https://github.com/googleapis/google-cloud-dotnet/commit/78feab77bc9b3f29a5d2409556c65dffc626b4ca))
- Clarify subscription description ([commit 5d43a47](https://github.com/googleapis/google-cloud-dotnet/commit/5d43a47d1e985fd500518af652a33046f88b7d32))
- Replacing HTML code with Markdown ([commit f9467b0](https://github.com/googleapis/google-cloud-dotnet/commit/f9467b0ef8da529c323f2edab5592083f9b8278f))
- Fix PullResponse description ([commit f9467b0](https://github.com/googleapis/google-cloud-dotnet/commit/f9467b0ef8da529c323f2edab5592083f9b8278f))
- Fix Pull description ([commit f9467b0](https://github.com/googleapis/google-cloud-dotnet/commit/f9467b0ef8da529c323f2edab5592083f9b8278f))
- Update Pub/Sub topic retention limit from 7 days to 31 days ([commit 7281474](https://github.com/googleapis/google-cloud-dotnet/commit/7281474046db813b4f93d2c7449b803eb6ee287d))
- Mark revision_id in CommitSchemaRevisionRequest deprecated ([commit 2a9ddbb](https://github.com/googleapis/google-cloud-dotnet/commit/2a9ddbb360a92a6b9736c6d87f732bf91d4be2b7))

## Version 3.3.0, released 2023-01-19

### New features

- Add schema evolution methods and fields ([commit 4003c4d](https://github.com/googleapis/google-cloud-dotnet/commit/4003c4d2446ff7f36ca573405d169b4d610a63cc))

## Version 3.2.0, released 2022-08-26

### New features

- Exactly once delivery ([commit e93c4d3](https://github.com/googleapis/google-cloud-dotnet/commit/e93c4d38bd93f2ff0547022a77578f10b0abd884))
- Add support for exactly once subscription ([commit 46d8b0d](https://github.com/googleapis/google-cloud-dotnet/commit/46d8b0d0581c9098b1e756663c59856430106634))

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
`SubscriberClient.Settings.UseLegacyFlowControl` to `true` which
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
