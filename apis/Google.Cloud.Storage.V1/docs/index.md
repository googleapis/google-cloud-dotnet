{{title}}

{{description}}
It wraps the `Google.Apis.Storage.v1` generated library, providing a higher-level API to make it easier to use.

{{version}}

{{installation}}

{{auth}}

## Getting started

Common operations are exposed via the
[StorageClient](obj/api/Google.Cloud.Storage.V1.StorageClient.yml) class.

## Error responses

All errors reported by the underlying API (including precondition
failures) are propagated as exceptions of type
[`GoogleApiException`](https://cloud.google.com/dotnet/docs/reference/Google.Apis/latest/Google.GoogleApiException).
See the [Cloud Storage API status and error codes
documentation](https://cloud.google.com/storage/docs/json_api/v1/status-codes)
for details of the HTTP status codes used.

## Client life-cycle management

In many cases you don't need to worry about disposing of
`StorageClient` objects, and can create them reasonably freely -
but be aware that this *can* causes issues with memory and network
connection usage. We advise you to reuse a single client object if possible.
`StorageClient` is thread-safe, so in most cases a single object is
the simplest option.

If your architecture requires you to frequently create new client
objects, please dispose of them to help with timely resource
clean-up. See [the resource clean-up
guide](https://cloud.google.com/dotnet/docs/reference/help/cleanup#rest-based-apis)
for more details.

## Sample code

{{sample:StorageClient.Overview}}

## Signed URLs

Signed URLs can be created to provide limited access to specific buckets and
objects to anyone in possession of the URL, regardless of whether they have
a Google account.

For example, Signed URLs can be created to provide read-only access to
existing objects:

{{sample:UrlSigner.SignedURLGet}}

Or write-only access to put specific object content into a bucket:

{{sample:UrlSigner.SignedURLPut}}

### Supported credential types for URL signing

`Google.Apis.Auth.OAuth2.ServiceAccountCredential`, `Google.Apis.Auth.OAuth2.ComputeCredential`
and `Google.Apis.Auth.OAuth2.ImpersonatedCredential` are all supported credentials from
which you can build a `UrlSigner` by calling the appropiate `UrlSigner.FromCredential`
method overload. `Google.Apis.Auth.OAuth2.GoogleCredential` is also supported as long as the
underlying credential is one of the supported specific types. The following example demonstrates
how to explicitly use a Compute credential for URL signing.

{{sample:UrlSigner.ComputeSignedURLGet}}

When using a `UrlSigner` it's worth being aware of the underlying synchronous/asynchronous nature
of the signing operations depending on the credential type the signer was created from. If you used
a service account credential, signing happens locally and the signing operation is synchronous.
But if you use an impersonated credential or a Compute credential, then a request to the IAM API
is made for signing and the operation is asynchronous. In this case, you can still use the
synchronous versions of the signing methods but they will block until the asynchronous operation
has completed, which could lead to deadlocks. In general, if you are unsure of which credential
was used to create a given URL signer, it is safer to use the asynchronous signing methods.

### HMAC Signed URLs

If you have access to an HMAC key, you can also sign URLs, even if you
don't have access to a service account private key. See the
[HMAC Keys documentation](https://cloud.google.com/storage/docs/authentication/hmackeys)
and the [Signing documentation](https://cloud.google.com/storage/docs/authentication/signatures#overview)
for more details. Below you can find an example on how to create
HMAC signed URLs using this library:

{{sample:UrlSigner.HmacSignedURLGet}}

### Signing URLs with a custom blob signer

If you need to sign URLs but none of the supported signer options
apply to your use case, you can create a `UrlSigner.IBlobSigner`
implementation to perform the signing part. Use the
`UrlSigner.FromBlobSigner(UrlSigner.IBlobSigner)` method to obtain
a URL signer that uses your custom signer implementation.

### Specifying the signing version

(V4 signing is currently beta functionality.)

Google Cloud Storage supports two signing process versions: V2 and V4.
Currently the default is V2, although in the future the library may
be updated to use V4 by default.

To specify the URL signing versioning, use the
[UrlSigner.Options.WithSigningVersion](obj/api/Google.Cloud.Storage.V1.UrlSigner.Options.yml#Google_Cloud_Storage_V1_UrlSigner_Options_WithSigningVersion_Google_Cloud_Storage_V1_SigningVersion_)
method, specifying the signing version you wish to use. This does
not change the UrlSigner it is called on; it returns a new UrlSigner
that uses the specified version.

Note that V4 signing is restricted to generating URLs that are valid
for at most 7 days.

{{sample:UrlSigner.WithSigningVersion}}

## Uploading objects by using HTML forms

In some cases, you might need to allow your users to upload objects via HTML forms.
You can create signed POST policies that specify what is and is not allowed in such
scenarios.
You can read the [Policy Document](https://cloud.google.com/storage/docs/authentication/signatures#policy-document)
documentation to get more information on how a POST policy document should be built.
You can read the [POST object](https://cloud.google.com/storage/docs/xml-api/post-object)
documentation to get more details on how the forms should be built.

Below you will find some samples on how to create a signed POST policy.

Simplest approach, where you restrict the upload to a specific bucket and a 
specific object name.

{{sample:UrlSigner.PostPolicySimple}}

Enforce how browser's cache will treat the uploaded object.

{{sample:UrlSigner.PostPolicyCacheControl}}

You can also set starts-with conditions for some form elements. This means that the
posting form should contain that element with a value that matches the condition.

{{sample:UrlSigner.PostPolicyAcl}}

Tell the server which HTTP status code you want it to return on succes.

{{sample:UrlSigner.PostPolicySuccessStatus}}

## Upload URIs

In some cases, it may not make sense for client applications to have permissions
to begin an upload for an object, but an authenticated service may choose to grant
this ability for individual uploads. Signed URLs are one option for this. Another
option is for the service to start a resumable upload session, but instead of
performing the upload, sending the resulting upload URI to the client application
so it can perform the upload instead. Unlike sessions initiated with a signed URL,
a pre-initated upload session will force the client application to upload through
the region in which the session began, which will likely be close to the service,
and not necessarily the client.

{{sample:StorageClient.UploadObjectWithSessionUri}}

## Customer-supplied encryption keys

Storage objects are always stored encrypted, but if you wish to
specify your own encryption key instead of using the server-supplied
one, you can do so either for all operations with a particular
`StorageClient` or on individual ones.

{{sample:StorageClient.CustomerSuppliedEncryptionKeys}}

## Change notification via Google Cloud Pub/Sub

You can configure a bucket to send a change notification to a
[Google Cloud Pub/Sub](https://cloud.google.com/pubsub/) topic
when changes occur. The sample below shows how to create a Pub/Sub
topic, set its permissions so that the change notifications can be
published to it, and then create the notification configuration on a
bucket. You'll need to add a dependency on the
`Google.Cloud.PubSub.V1` NuGet package to create the topic and
manage its permissions.

{{sample:StorageClient.NotificationsOverview}}
