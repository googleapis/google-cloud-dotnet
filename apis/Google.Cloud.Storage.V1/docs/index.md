{{title}}

{{description}}
It wraps the `Google.Apis.Storage.v1` generated library, providing a higher-level API to make it easier to use.

{{version}}

{{installation}}

{{auth}}

## Getting started

Common operations are exposed via the
[StorageClient](obj/api/Google.Cloud.Storage.V1.StorageClient.yml) class.

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
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/cleanup.html#rest-based-apis)
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

### Signing URLs without a service account credential file

If you need to sign URLs but don't have a full service account
credential file (with private keys) available, you can create a
`UrlSigner.IBlobSigner` implementation to perform the signing part.
The most common implementation of this is likely to be to use the
IAM service to perform the signing, with the
[Google.Apis.Iam.v1](https://www.nuget.org/packages/Google.Apis.Iam.v1/)
package. Here's a sample implementation:

{{sample:UrlSigner.IamServiceBlobSigner}}

(We may make this available in its own package at some point in the
future.)

To make use of this, the account making the request needs the
`iam.serviceAccounts.signBlob` permission, which is usually granted
via the "Service Account Token Creator" role.

Here's an example showing how you could use this to sign a
URL on behalf of the default Compute Engine credential on an
instance. (This example will only work when running on Google Cloud
Platform, as it relies on information from the metadata server.) If
you want to use a different service account, you could include the
account ID as part of your application configuration.

{{sample:UrlSigner.IamServiceBlobSignerUsage}}

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
