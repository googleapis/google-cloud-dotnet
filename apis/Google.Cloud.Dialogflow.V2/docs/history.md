# Version history

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
