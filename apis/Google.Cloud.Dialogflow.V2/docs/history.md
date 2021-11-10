# Version history

# Version 3.7.0, released 2021-11-10

- [Commit 6699f2e](https://github.com/googleapis/google-cloud-dotnet/commit/6699f2e): feat: added support to configure security settings, language code and time zone on conversation profile
- [Commit dd18efd](https://github.com/googleapis/google-cloud-dotnet/commit/dd18efd):
  - docs: clarified meaning of the legacy editions
  - docs: clarified semantic of the streaming APIs

# Version 3.6.0, released 2021-10-12

- [Commit 03f91a3](https://github.com/googleapis/google-cloud-dotnet/commit/03f91a3): docs: recommend AnalyzeContent for future users

# Version 3.5.0, released 2021-09-23

- [Commit 6687459](https://github.com/googleapis/google-cloud-dotnet/commit/6687459): docs: clarified some LRO types
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs
- [Commit 0c649d8](https://github.com/googleapis/google-cloud-dotnet/commit/0c649d8): feat: expose `Locations` service to get/list avaliable locations of Dialogflow products; fixed some API annotations

# Version 3.4.0, released 2021-08-10

- [Commit 5dba1ca](https://github.com/googleapis/google-cloud-dotnet/commit/5dba1ca):
  - fix: fix validation result docs
  - feat: add language code to streaming recognition result
  - docs: update environment docs
- [Commit 281077c](https://github.com/googleapis/google-cloud-dotnet/commit/281077c): docs: fix typos

# Version 3.3.0, released 2021-06-22

- [Commit c135978](https://github.com/googleapis/google-cloud-dotnet/commit/c135978): docs: added notes to train agent prior to sending queries fix: added resource reference to agent_version
- [Commit 6567bfc](https://github.com/googleapis/google-cloud-dotnet/commit/6567bfc): feat: added Automated agent reply type and allow cancellation flag for partial response feature.
- [Commit b270512](https://github.com/googleapis/google-cloud-dotnet/commit/b270512): feat: added a field in the query result to indicate whether slot filling is cancelled.
- [Commit fe36e1e](https://github.com/googleapis/google-cloud-dotnet/commit/fe36e1e): feat: added location-aware HTTP path binding for ListIntents
- [Commit b782110](https://github.com/googleapis/google-cloud-dotnet/commit/b782110): fix: removed incorrect resource annotation for UpdateEnvironmentRequest.
- [Commit 88a63a8](https://github.com/googleapis/google-cloud-dotnet/commit/88a63a8):
  - feat: added more Environment RPCs
  - feat: added Versions service
  - feat: added Fulfillment service
  - feat: added TextToSpeechSettings.
  - feat: added location in some resource patterns.

# Version 3.2.0, released 2021-04-29

- [Commit ae565e2](https://github.com/googleapis/google-cloud-dotnet/commit/ae565e2): feat: expose MP3_64_KBPS and MULAW for output audio encodings.
- [Commit a6aa034](https://github.com/googleapis/google-cloud-dotnet/commit/a6aa034):
  - docs: fix link for version and environment in participant doc.
  - fix: Add all missing regional HTTP bindings in DF API.
- [Commit 79f24ea](https://github.com/googleapis/google-cloud-dotnet/commit/79f24ea): feat: Add CCAI API
- [Commit 14e6a6c](https://github.com/googleapis/google-cloud-dotnet/commit/14e6a6c):
  - feat: add additional_bindings to Dialogflow v2 ListIntents API
  - docs: update copyrights and session docs
- [Commit 6e5f4f6](https://github.com/googleapis/google-cloud-dotnet/commit/6e5f4f6): docs: update comments on parameters and validation result.
- [Commit 9900407](https://github.com/googleapis/google-cloud-dotnet/commit/9900407):
  - feat: allowed custom to specify webhook headers through query parameters
  - docs: suggested to always use version for production traffic when calling DetectIntent, mark match_mode in Agent message as deprecated

# Version 3.1.0, released 2020-10-16

- [Commit 079e919](https://github.com/googleapis/google-cloud-dotnet/commit/079e919): docs: fixed link from SentimentAnalysisResult
- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 0cdabf1](https://github.com/googleapis/google-cloud-dotnet/commit/0cdabf1): docs: wording updates for tiers.
- [Commit ebd848c](https://github.com/googleapis/google-cloud-dotnet/commit/ebd848c): docs: more detailed docs on APIs such as Environment, Intents, Sessions.
- [Commit c552537](https://github.com/googleapis/google-cloud-dotnet/commit/c552537): docs: Regenerate Dialogflow V2 with cleaner docs
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 34c92e6](https://github.com/googleapis/google-cloud-dotnet/commit/34c92e6):
  - fix: Update grpc config for retry mechanism.
  - docs: Update ImportAgent/ExportAgent external documentation.
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 2bac8ab](https://github.com/googleapis/google-cloud-dotnet/commit/2bac8ab): docs: cleaned docs for the Agents service and resource.

# Version 3.0.0, released 2020-06-03

Documentation changes only since 3.0.0-beta02:

- [Commit 4181b4f](https://github.com/googleapis/google-cloud-dotnet/commit/4181b4f): docs: Comment updates only
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit b3e7794](https://github.com/googleapis/google-cloud-dotnet/commit/b3e7794): docs: minor comments change.

As noted in the 3.0.0-beta01 history, 3.0.0 is a breaking change compared with 2.0.0 due to resource names being corrected.

# Version 3.0.0-beta02, released 2020-05-05

- [Commit 610cf69](https://github.com/googleapis/google-cloud-dotnet/commit/610cf69):
  - feat: Publish ListEnvironments
  - docs: Clarify WebhookResponse fields
- [Commit f2f7630](https://github.com/googleapis/google-cloud-dotnet/commit/f2f7630): docs: Update comments on Contexts and Sessions resources.

# Version 3.0.0-beta01, released 2020-04-06

- [Commit 5a41fb5](https://github.com/googleapis/google-cloud-dotnet/commit/5a41fb5):
  - Change `parent` field's resource_reference to specify child_type instead of type per client library generation requirement;
  - Change Session with its child resource pattern to support both projects/{project}/agent/sessions/{session} and projects/{project}/agent/environments/{environment}/users/{user}/sessions/{session};
    - Additionally, the location-based pattern has been removed
  - Fix `method_signature`
  - Regular documentation update

This is a breaking change in terms of resource names, which weren't
correctly defined in the API before. We will release a new GA
version once we're satisfied that no further breaking changes will
be required.

# Version 2.0.0, released 2020-03-18

- [Commit a19ee13](https://github.com/googleapis/google-cloud-dotnet/commit/a19ee13):
  - Adds AgentsClient.GetValidationResult RPC with associated types
  - Adds DetectIntentRequest.OutputAudioConfigMask

# Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

# Version 1.2.0, released 2019-12-10

- [Commit 532f28b](https://github.com/googleapis/google-cloud-dotnet/commit/532f28b): Multiple new features:
  - Intent.BrowseCarouselCard
  - Intent.MediaContent
  - Intent.TableCard
- [Commit c8a6431](https://github.com/googleapis/google-cloud-dotnet/commit/c8a6431): Added ListSelect.Subtitle

# Version 1.1.0, released 2019-10-02

- [Commit 40e45db](https://github.com/googleapis/google-cloud-dotnet/commit/40e45db): Added WebhookResponse.SessionEntityTypes
- [Commit d314680](https://github.com/googleapis/google-cloud-dotnet/commit/d314680): Added EntityType.EnableFuzzyExtraction
- [Commit 85b53eb](https://github.com/googleapis/google-cloud-dotnet/commit/85b53eb): Added StreamingDetectIntentRequest.SingleUtterence
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Added Format method to all resource name types

# Version 1.0.0, released 2019-07-10

Initial GA release.
