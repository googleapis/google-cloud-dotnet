# Version history

# Version 2.4.0, released 2019-12-10

New features since 2.3.0:

- Opt-in support for V4 signing URLs
- Add `IncludeTrailingDelimiter` to `ListObjectsOptions`
- Default endpoint is now storage.googleapis.com
- Added GetBucketIamPolicyOptions.RequestedPolicyVersion in anticipation of IAM conditions
- Added StorageClientBuilder for simplified configuration
- Added support for HMAC keys associated with service accounts in GCS

# Version 2.3.0, released 2019-02-11

New features since 2.2.0:

- Support for supplying page tokens when listing buckets or objects
- Support for retention policy locking
- Deprecate URL signing without an expiry; the default is now in 2038 (the end of "Unix time in seconds")
- Allow an Origin header to be specified in UploadObjectOptions for CORS scenarios

# Version 2.2.0, released 2018-08-28

New features since 2.1.0:

- New interface `UrlSigner.IBlobSigner` for more flexibility when
  creating signed URLs
- Option to delete objects automatically when deleting a bucket
- Support for [customer-managed encryption
  keys](https://cloud.google.com/storage/docs/encryption/customer-managed-keys)

# Version 2.1.0, released 2018-01-02

New features:

- Support for [requester pays](https://cloud.google.com/storage/docs/requester-pays)
- Support for [bucket labels](https://cloud.google.com/storage/docs/using-bucket-labels)
- Support for unauthenticated access to public objects and buckets
- Support for [PubSub notifications](https://cloud.google.com/storage/docs/pubsub-notifications)
- Support upload and download hash validation, including the ability to disable it
- `StorageClient` now implements `IDisposable` to dispose the
  underlying service, where appropriate (see [the user
  guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/cleanup.html#rest-based-apis)
  for more information)

# Version 2.0.0, released 2017-06-22

Major version bump due to updating Google.Api.Gax.Rest dependency to
2.0.0, but this is unlikely to actually be a breaking change for
customers.

New features:

- Support for fetching and setting bucket IAM policies

# Version 1.0.0, released 2017-03-30

Initial release.
