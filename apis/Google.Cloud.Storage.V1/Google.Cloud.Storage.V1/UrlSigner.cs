// Copyright 2015 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Http;
using System;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Class which helps create signed URLs which can be used to provide limited access to specific buckets and objects
    /// to anyone in possession of the URL, regardless of whether they have a Google account.
    /// </summary>
    /// <remarks>
    /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
    /// </remarks>
    public sealed partial class UrlSigner
    {
        private static readonly ISigner s_v2Signer = new V2Signer();
        private static readonly ISigner s_v4Signer = new V4Signer();

        private const string GoogHeaderPrefix = "x-goog-";

        private const string CredentialsDefaultAlgorithm = "GOOG4-RSA-SHA256";

        /// <summary>
        /// Gets a special HTTP method which can be used to create a signed URL for initiating a resumable upload.
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls#signing-resumable for more information.
        /// </summary>
        /// <remarks>
        /// Note: When using the RESUMABLE method to create a signed URL, a URL will actually be signed for the POST method with a header of
        /// 'x-goog-resumable:start'. The caller must perform a POST request with this URL and specify the 'x-goog-resumable:start' header as
        /// well or signature validation will fail.
        /// </remarks>
        public static HttpMethod ResumableHttpMethod { get; } = new HttpMethod("RESUMABLE");

        private static readonly DateTimeOffset UnixEpoch = new DateTimeOffset(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc), TimeSpan.Zero);

        private readonly BlobSignerProvider _blobSignerProvider;
        private readonly IClock _clock;
        private readonly DefaultOptionsOverrides _defaultOptionsOverrides;

        private UrlSigner(BlobSignerProvider blobSignerProvider, IClock clock, DefaultOptionsOverrides defaultOptionsOverrides)
        {
            _blobSignerProvider = blobSignerProvider;
            _clock = clock;
            _defaultOptionsOverrides = defaultOptionsOverrides;
        }

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a service account.
        /// </summary>
        /// <param name="credential">The credential for the a service account. Must not be null.</param>
        /// <remarks>
        /// Signing happens locally using the private key included on the service account credential.
        /// </remarks>
        public static UrlSigner FromCredential(ServiceAccountCredential credential) =>
            FromBlobSigner(new CredentialBlobSigner(GaxPreconditions.CheckNotNull(credential, nameof(credential)), credential.Id, CredentialsDefaultAlgorithm));

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for an impersonated credential.
        /// Signing is done by the impersonated service account.
        /// </summary>
        /// <param name="credential">The impersonated credential. Must not be null.</param>
        /// <remarks>
        /// A request to the IAM API is executed for signing which increases latency
        /// as compared with <see cref="FromCredential(ServiceAccountCredential)"/>
        /// and that counts towards IAM API quoata consumption.
        /// </remarks>
        public static UrlSigner FromCredential(ImpersonatedCredential credential) =>
            FromBlobSigner(new CredentialBlobSigner(GaxPreconditions.CheckNotNull(credential, nameof(credential)), credential.TargetPrincipal, CredentialsDefaultAlgorithm));

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a compute credential.
        /// </summary>
        /// <param name="credential">The compute credential. Must not be null.</param>
        /// <remarks>
        /// <para>
        /// A request to the IAM API is executed for signing which increases latency
        /// as compared with <see cref="FromCredential(ServiceAccountCredential)"/>
        /// and that counts towards IAM API quoata consumption.
        /// </para>
        /// <para>
        /// The first time a compute credential is used for signing, a request to the
        /// metadata server is executed, to obtain the associated service account ID,
        /// which may increase latency of the overall signing request.
        /// </para>
        /// </remarks>
        public static UrlSigner FromCredential(ComputeCredential credential)
        {
            GaxPreconditions.CheckNotNull(credential, nameof(credential));
            return FromBlobSignerAsyncProvider(async () => new CredentialBlobSigner(
                credential,
                await credential.GetDefaultServiceAccountEmailAsync().ConfigureAwait(false),
                CredentialsDefaultAlgorithm));
        }

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a Google credential if
        /// the wrapped credential type is supported for signing. In that case, this method
        /// relies on the appropiate UrlSigner.FromCredential overload.
        /// </summary>
        /// <param name="credential">
        /// The Google credential. Must not be null.
        /// Must wrap a credential currently supported for signing.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// The credential wrapped by the Google credential is not currently supported for signing.
        /// </exception>
        /// <remarks>
        /// Please see the specific UrlSigner.FromCredential overloads for more information.
        /// </remarks>
        public static UrlSigner FromCredential(GoogleCredential credential) =>
            GaxPreconditions.CheckNotNull(credential, nameof(credential)).UnderlyingCredential switch
            {
                ServiceAccountCredential sa => FromCredential(sa),
                ImpersonatedCredential imp => FromCredential(imp),
                ComputeCredential comp => FromCredential(comp),
                _ => throw new InvalidOperationException($"The credential type {credential.UnderlyingCredential.GetType()} is not supported for signing.")
            };

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instace for a <see cref="IHttpExecuteInterceptor"/> if
        /// the <paramref name="credential"/> is of a type supported for signing.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// The type of <paramref name="credential"/> is not supported for signing.
        /// </exception>
        internal static UrlSigner FromCredential(IHttpExecuteInterceptor credential) =>
            GaxPreconditions.CheckNotNull(credential, nameof(credential)) switch
            {
                GoogleCredential gc => FromCredential(gc),
                ServiceAccountCredential sa => FromCredential(sa),
                ImpersonatedCredential imp => FromCredential(imp),
                ComputeCredential comp => FromCredential(comp),
                IBlobSigner blobSigner => FromBlobSigner(blobSigner),
                _ => throw new InvalidOperationException($"The type {credential.GetType()} is not supported for signing.")
            };

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance from the JSON configuration file of a Google credential.
        /// See <see cref="FromCredential(GoogleCredential)"/> for more information about supported credential types.
        /// </summary>
        /// <remarks>
        /// Important: If you accept a credential configuration (credential JSON/File/Stream) from an external source
        /// for authentication to Google Cloud, you must validate it before providing it to any Google API or library.
        /// Providing an unvalidated credential configuration to Google APIs can compromise the security of your
        /// systems and data. For more information, refer to
        /// <see href="https://cloud.google.com/docs/authentication/external/externally-sourced-credentials">Validate credential configurations from external sources</see>.
        /// </remarks>
        [Obsolete("This method is being deprecated because of a potential security risk. Instead use one of the FromCredential methods.")]
        public static UrlSigner FromCredentialFile(string credentialFilePath) =>
            FromCredential(GoogleCredential.FromFile(credentialFilePath));

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance from the JSON configuration file of a Google credential,
        /// which is read asyncrhonously.
        /// See <see cref="FromCredential(GoogleCredential)"/> for more information about supported credential types.
        /// </summary>
        /// <remarks>
        /// Important: If you accept a credential configuration (credential JSON/File/Stream) from an external source
        /// for authentication to Google Cloud, you must validate it before providing it to any Google API or library.
        /// Providing an unvalidated credential configuration to Google APIs can compromise the security of your
        /// systems and data. For more information, refer to
        /// <see href="https://cloud.google.com/docs/authentication/external/externally-sourced-credentials">Validate credential configurations from external sources</see>.
        /// </remarks>
        [Obsolete("This method is being deprecated because of a potential security risk. Instead use one of the FromCredential methods.")]
        public static async Task<UrlSigner> FromCredentialFileAsync(string credentialFilePath, CancellationToken cancellationToken = default) =>
            FromCredential(await GoogleCredential.FromFileAsync(credentialFilePath, cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance from a Stream containing the JSON configuration file of a Google Credential.
        /// See <see cref="FromCredential(GoogleCredential)"/> for more information about supported credential types.
        /// </summary>
        /// <remarks>
        /// Important: If you accept a credential configuration (credential JSON/File/Stream) from an external source
        /// for authentication to Google Cloud, you must validate it before providing it to any Google API or library.
        /// Providing an unvalidated credential configuration to Google APIs can compromise the security of your
        /// systems and data. For more information, refer to
        /// <see href="https://cloud.google.com/docs/authentication/external/externally-sourced-credentials">Validate credential configurations from external sources</see>.
        /// </remarks>
        [Obsolete("This method is being deprecated because of a potential security risk. Instead use one of the FromCredential methods.")]
        public static UrlSigner FromCredentialStream(Stream credentialData) =>
            FromCredential(GoogleCredential.FromStream(GaxPreconditions.CheckNotNull(credentialData, nameof(credentialData))));

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance from a Stream containing the JSON configuration file of a Google Credential.
        /// The data is read asynchronously.
        /// See <see cref="FromCredential(GoogleCredential)"/> for more information about supported credential types.
        /// </summary>
        /// <remarks>
        /// Important: If you accept a credential configuration (credential JSON/File/Stream) from an external source
        /// for authentication to Google Cloud, you must validate it before providing it to any Google API or library.
        /// Providing an unvalidated credential configuration to Google APIs can compromise the security of your
        /// systems and data. For more information, refer to
        /// <see href="https://cloud.google.com/docs/authentication/external/externally-sourced-credentials">Validate credential configurations from external sources</see>.
        /// </remarks>
        [Obsolete("This method is being deprecated because of a potential security risk. Instead use one of the FromCredential methods.")]
        public static async Task<UrlSigner> FromCredentialStreamAsync(Stream credentialData, CancellationToken cancellationToken = default) =>
            FromCredential(await GoogleCredential.FromStreamAsync(GaxPreconditions.CheckNotNull(credentialData, nameof(credentialData)), cancellationToken).ConfigureAwait(false));

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a service account.
        /// </summary>
        /// <param name="credentialFilePath">The path to the JSON key file for a service account. Must not be null.</param>
        /// <exception cref="InvalidOperationException">
        /// The <paramref name="credentialFilePath"/> does not refer to a valid JSON service account key file.
        /// </exception>
        [Obsolete("Use FromCredentialFile(string) which is equivalent.")]
        public static UrlSigner FromServiceAccountPath(string credentialFilePath) => FromCredentialFile(credentialFilePath);

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a service account.
        /// </summary>
        /// <param name="credentialData">The stream from which to read the JSON key data for a service account. Must not be null.</param>
        /// <exception cref="InvalidOperationException">
        /// The <paramref name="credentialData"/> does not contain valid JSON service account key data.
        /// </exception>
        [Obsolete("Use FromCredentialStream(Stream) which is equivalent.")]
        public static UrlSigner FromServiceAccountData(Stream credentialData) => FromCredentialStream(credentialData);

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a service account.
        /// </summary>
        /// <param name="credential">The credential for the a service account. Must not be null.</param>
        [Obsolete("Use FromCredential(ServiceAccountCredential) which is equivalent.")]
        public static UrlSigner FromServiceAccountCredential(ServiceAccountCredential credential) => FromCredential(credential);

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a custom blob signer.
        /// </summary>
        /// <param name="signer">The blob signer to use. Must not be null.</param>
        /// <returns>A new <see cref="UrlSigner"/> using the specified blob signer.</returns>
        public static UrlSigner FromBlobSigner(IBlobSigner signer) =>
            new UrlSigner(new BlobSignerProvider(signer), SystemClock.Instance, null);

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a custom blob signer obtained
        /// from the given blob signer provider.
        /// Note the provider will be only called once, and the returned blob signer will be reused
        /// for subsequent signing operations with this URL signer.
        /// </summary>
        /// <param name="signerAsyncProvider">
        /// The blob signer async provider to use. Must not be null.
        /// When called, must not return a null reference or a task which completes with a null result.
        /// </param>
        /// <returns>A new <see cref="UrlSigner"/> that will use a blob signer obtained from the specified provider function.</returns>
        private static UrlSigner FromBlobSignerAsyncProvider(Func<Task<IBlobSigner>> signerAsyncProvider) =>
            new UrlSigner(new BlobSignerProvider(signerAsyncProvider), SystemClock.Instance, null);

        /// <summary>
        /// Only available for testing purposes, this allows the clock used for signature generation to be replaced.
        /// </summary>
        internal UrlSigner WithClock(IClock clock) => new UrlSigner(_blobSignerProvider, clock, _defaultOptionsOverrides);

        /// <summary>
        /// Returns a URL signer identical to this one, except for the default options overrides used for signing.
        /// </summary>
        internal UrlSigner WithDefaultOptionsOverride(DefaultOptionsOverrides optionsOverrides) =>
            new UrlSigner(_blobSignerProvider, _clock, optionsOverrides);

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
        /// </para>
        /// <para>
        /// Note that when GET is specified as the <paramref name="httpMethod"/> (or it is null, in which case GET is
        /// used), both GET and HEAD requests can be made with the created signed URL.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. May be null, in which case the signed URL
        /// will refer to the bucket instead of an object.</param>
        /// <param name="duration">The length of time for which the signed URL should remain usable.</param>
        /// <param name="httpMethod">The HTTP request method for which the signed URL is allowed to be used. May be null,
        /// in which case GET will be used.</param>
        /// <param name="signingVersion">The signing version to use to generate the signed URL. May be null, in which case
        /// <see cref="SigningVersion.Default"/> will be used.</param>
        /// <returns>The signed URL which can be used to provide access to a bucket or object for a limited amount of time.</returns>
        public string Sign(string bucket, string objectName, TimeSpan duration, HttpMethod httpMethod = null, SigningVersion? signingVersion = null)
        {
            var template = RequestTemplate
                .FromBucket(bucket)
                .WithObjectName(objectName)
                .WithHttpMethod(httpMethod);
            var options = Options.FromDuration(duration);
            if (signingVersion.HasValue)
            {
                options = options.WithSigningVersion(signingVersion.Value);
            }
            return Sign(template, options);
        }

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
        /// </para>
        /// </remarks>
        /// <param name="requestTemplate">The request template that will be used to generate the signed URL for. Must not be null.</param>
        /// <param name="options">The options used to generate the signed URL. Must not be null.</param>
        /// <returns>
        /// The signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public string Sign(RequestTemplate requestTemplate, Options options) =>
            GetEffectiveSigner(GaxPreconditions.CheckNotNull(options, nameof(options)).SigningVersion).Sign(
                GaxPreconditions.CheckNotNull(requestTemplate, nameof(requestTemplate)), options.WithDefaultOptionsOverrides(_defaultOptionsOverrides), _blobSignerProvider, _clock);

        /// <summary>
        /// Signs the given post policy. The result can be used to make form posting requests matching the conditions
        /// set in the post policy.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Signing post policies is not supported by <see cref="SigningVersion.V2"/>. A <see cref="NotSupportedException"/>
        /// will be thrown if an attempt is made to sign a post policy using <see cref="SigningVersion.V2"/>.
        /// </para>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/storage/docs/xml-api/post-object for more information on signed post policies.
        /// </para>
        /// </remarks>
        /// <param name="postPolicy">The post policy to signed and that will be enforced when making the post request.
        /// Must not be null.</param>
        /// <param name="options">The options used to generate the signed post policy. Must not be null.</param>
        /// <returns>The signed post policy, which contains all the fields that should be including in the form to post.</returns>
        public SignedPostPolicy Sign(PostPolicy postPolicy, Options options) =>
            GetEffectiveSigner(GaxPreconditions.CheckNotNull(options, nameof(options)).SigningVersion).Sign(
                GaxPreconditions.CheckNotNull(postPolicy, nameof(postPolicy)), options.WithDefaultOptionsOverrides(_defaultOptionsOverrides), _blobSignerProvider, _clock);

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
        /// </para>
        /// <para>
        /// Note that when GET is specified as the <paramref name="httpMethod"/> (or it is null, in which case GET is
        /// used), both GET and HEAD requests can be made with the created signed URL.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. May be null, in which case the signed URL
        /// will refer to the bucket instead of an object.</param>
        /// <param name="duration">The length of time for which the signed URL should remain usable.</param>
        /// <param name="httpMethod">The HTTP request method for which the signed URL is allowed to be used. May be null,
        /// in which case GET will be used.</param>
        /// <param name="signingVersion">The signing version to use to generate the signed URL. May be null, in which case
        /// <see cref="SigningVersion.Default"/> will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns> A task representing the asynchronous operation, with a result returning the
        /// signed URL which can be used to provide access to a bucket or object for a limited amount of time.</returns>
        public async Task<string> SignAsync(string bucket, string objectName, TimeSpan duration, HttpMethod httpMethod = null, SigningVersion? signingVersion = null, CancellationToken cancellationToken = default)
        {
            var template = RequestTemplate
                .FromBucket(bucket)
                .WithObjectName(objectName)
                .WithHttpMethod(httpMethod);
            var options = Options.FromDuration(duration);
            if (signingVersion.HasValue)
            {
                options = options.WithSigningVersion(signingVersion.Value);
            }
            return await SignAsync(template, options, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Asynchronously creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
        /// </para>
        /// </remarks>
        /// <param name="requestTemplate">The request template that will be used to generate the signed URL for. Must not be null.</param>
        /// <param name="options">The options used to generate the signed URL. Must not be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task representing the asynchronous operation, with a result returning the
        /// signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public Task<string> SignAsync(RequestTemplate requestTemplate, Options options, CancellationToken cancellationToken = default) =>
            GetEffectiveSigner(GaxPreconditions.CheckNotNull(options, nameof(options)).SigningVersion).SignAsync(
                GaxPreconditions.CheckNotNull(requestTemplate, nameof(requestTemplate)), options.WithDefaultOptionsOverrides(_defaultOptionsOverrides), _blobSignerProvider, _clock, cancellationToken);

        /// <summary>
        /// Signs the given post policy. The result can be used to make form posting requests matching the conditions
        /// set in the post policy.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Signing post policies is not supported by <see cref="SigningVersion.V2"/>. A <see cref="NotSupportedException"/>
        /// will be thrown if an attempt is made to sign a post policy using <see cref="SigningVersion.V2"/>.
        /// </para>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/storage/docs/xml-api/post-object for more information on signed post policies.
        /// </para>
        /// </remarks>
        /// <param name="postPolicy">The post policy to signed and that will be enforced when making the post request.
        /// Most not be null.</param>
        /// <param name="options">The options used to generate the signed post policy. Must not be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>The signed post policy, which contains all the fields that should be including in the form to post.</returns>
        public Task<SignedPostPolicy> SignAsync(PostPolicy postPolicy, Options options, CancellationToken cancellationToken = default) =>
            GetEffectiveSigner(GaxPreconditions.CheckNotNull(options, nameof(options)).SigningVersion).SignAsync(
                GaxPreconditions.CheckNotNull(postPolicy, nameof(postPolicy)), options.WithDefaultOptionsOverrides(_defaultOptionsOverrides), _blobSignerProvider, _clock, cancellationToken);

        private ISigner GetEffectiveSigner(SigningVersion signingVersion) =>
            signingVersion switch
            {
                SigningVersion.Default => s_v4Signer,
                SigningVersion.V2 => s_v2Signer,
                SigningVersion.V4 => s_v4Signer,
                // We really shouldn't get here, as we validate any user-specified signing version.
                _ => throw new InvalidOperationException($"Invalid signing version: {signingVersion}")
            };

        private static readonly Regex s_newlineRegex = new Regex(@"\r?\n", RegexOptions.Compiled);
        private static readonly Regex s_tabRegex = new Regex(@"\t+", RegexOptions.Compiled);
        private static readonly Regex s_whitespaceRegex = new Regex(@"\s+", RegexOptions.Compiled);

        /// <summary>
        /// Prepares a header value for signing, trimming both ends and collapsing internal whitespace.
        /// </summary>
        internal static string PrepareHeaderValue(string value, bool collapseTabs)
        {
            // Remove leading/trailing whitespace
            value = value.Trim();

            if (collapseTabs)
            {
                // Replaces all consecutive tabs by a space.
                // If consecutive spaces result out of this, then the next line will
                // collapse all the spaces.
                value = s_tabRegex.Replace(value, " ");
            }

            // Collapse whitespace runs: only keep the last character
            value = s_whitespaceRegex.Replace(value, match => match.Value[match.Value.Length - 1].ToString());

            // Remove newlines
            value = s_newlineRegex.Replace(value, "");

            return value;
        }

    }
}
