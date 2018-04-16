# Version history

# (Unreleased)

New features:

- Option to delete objects automatically when deleting a bucket

# 2.1.0, 2018-01-02

New features:

- Support for [requester pays](https://cloud.google.com/storage/docs/requester-pays)
- Support for [bucket labels](https://cloud.google.com/storage/docs/using-bucket-labels)
- Support for unauthenticated access to public objects and buckets
- Support for [PubSub notifications](https://cloud.google.com/storage/docs/pubsub-notifications)
- Support upload and download hash validation, including the ability to disable it
- `StorageClient` now implements `IDisposable` to dispose the
  underlying service, where appropriate (see [the user
  guide](https://googlecloudplatform.github.io/google-cloud-dotnet/docs/guides/cleanup.html#rest-based-apis)
  for more information)

# 2.0.0, 2017-06-22

Major version bump due to updating Google.Api.Gax.Rest dependency to
2.0.0, but this is unlikely to actually be a breaking change for
customers.

New features:

- Support for fetching and setting bucket IAM policies

# 1.0.0, 2017-03-30

Initial release.
