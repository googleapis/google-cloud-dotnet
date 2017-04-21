// Copyright 2017 Google Inc. All Rights Reserved.
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
using Google.Apis.Services;
using Google.Apis.Translate.v2;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Translation.V2
{
    /// <summary>
    /// Abstract class providing operations for Google Cloud Translation.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This abstract class is provided to enable testability while permitting
    /// additional operations to be added in the future. See <see cref="Create(GoogleCredential, TranslationModel)"/>,
    /// <see cref="CreateAsync(GoogleCredential, TranslationModel)"/> and
    /// <see cref="CreateFromApiKey(string, TranslationModel)"/> to construct instances; alternatively, you can
    /// construct a <see cref="TranslationClientImpl"/> directly from a <see cref="TranslateService"/>.
    /// </para>
    /// <para>
    /// All instance methods declared in this class are virtual, with an implementation which simply
    /// throws <see cref="NotImplementedException"/>. All these methods are overridden in <see cref="TranslationClientImpl"/>.
    /// </para>
    /// </remarks>
    public abstract class TranslationClient
    {
        private static readonly ScopedCredentialProvider _credentialProvider =
            new ScopedCredentialProvider(new[] { TranslateService.Scope.CloudPlatform });

        /// <summary>
        /// The underlying translation service object used by this client.
        /// </summary>
        /// <remarks>
        /// The <see cref="TranslationClient"/> class only provides convenience operations built on top of
        /// an existing service object. Any more complex operations which are not supported by this wrapper may wish
        /// to use the same service object as the wrapper, in order to take advantage of its configuration (for authentication,
        /// application naming etc).
        /// </remarks>
        public virtual TranslateService Service { get { throw new NotImplementedException(); } }

        /// <summary>
        /// The default translation model used by this client.
        /// </summary>
        /// <remarks>
        /// Each <c>Translate</c> method has an optional parameter to override this.
        /// </remarks>
        public virtual TranslationModel DefaultModel { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Translates a single item of text synchronously.
        /// </summary>
        /// <remarks>
        /// This implementation simply delegates to <see cref="TranslateText(IEnumerable{string}, string, string, TranslationModel?)"/>
        /// </remarks>
        /// <param name="text">The text to translate.</param>
        /// <param name="targetLanguage">The code for the language to translate into. Must not be null.</param>
        /// <param name="sourceLanguage">The code for the language to translate from. May be null, in which case the server
        /// will detect the source language.</param>
        /// <param name="model">The model to request for translation. May be null, in which case <see cref="DefaultModel"/> is
        /// used.</param>
        /// <returns>The translation of <paramref name="text"/>.</returns>
        public virtual TranslationResult TranslateText(
            string text, string targetLanguage, string sourceLanguage = null, TranslationModel? model = null) =>
            TranslateText(
                new[] { GaxPreconditions.CheckNotNull(text, nameof(text)) },
                targetLanguage,
                sourceLanguage,
                model)[0];

        /// <summary>
        /// Translates a single item of HTML synchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This implementation simply delegates to <see cref="TranslateHtml(IEnumerable{string}, string, string, TranslationModel?)"/>
        /// </para>
        /// <para>
        /// See the [Translation API documentation](https://cloud.google.com/translate/markup) for more details
        /// on how to translate HTML and the terms of service.
        /// </para>
        /// </remarks>
        /// <param name="html">The HTML to translate.</param>
        /// <param name="targetLanguage">The code for the language to translate into. Must not be null.</param>
        /// <param name="sourceLanguage">The code for the language to translate from. May be null, in which case the server
        /// will detect the source language.</param>
        /// <param name="model">The model to request for translation. May be null, in which case <see cref="DefaultModel"/> is
        /// used.</param>
        /// <returns>The translation of <paramref name="html"/>.</returns>
        public virtual TranslationResult TranslateHtml(
            string html, string targetLanguage, string sourceLanguage = null, TranslationModel? model = null) =>
            TranslateHtml(
                new[] { GaxPreconditions.CheckNotNull(html, nameof(html)) },
                targetLanguage,
                sourceLanguage,
                model)[0];

        /// <summary>
        /// Translates multiple items of text synchronously.
        /// </summary>
        /// <param name="textItems">The text strings to translate. Must not be null or contain null elements.</param>
        /// <param name="targetLanguage">The code for the language to translate into. Must not be null.</param>
        /// <param name="sourceLanguage">The code for the language to translate from. May be null, in which case the server
        /// will detect the source language.</param>
        /// <param name="model">The model to request for translation. May be null, in which case <see cref="DefaultModel"/> is
        /// used.</param>
        /// <returns>A list of translations. This will be the same size as <paramref name="textItems"/>, in the same order.</returns>
        public virtual IList<TranslationResult> TranslateText(IEnumerable<string> textItems, string targetLanguage, string sourceLanguage = null, TranslationModel? model = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Translates multiple items of HTML synchronously.
        /// </summary>
        /// <remarks>
        /// See the [Translation API documentation](https://cloud.google.com/translate/markup) for more details
        /// on how to translate HTML and the terms of service.
        /// </remarks>
        /// <param name="htmlItems">The HTML strings to translate. Must not be null or contain null elements.</param>
        /// <param name="targetLanguage">The code for the language to translate into. Must not be null.</param>
        /// <param name="sourceLanguage">The code for the language to translate from. May be null, in which case the server
        /// will detect the source language.</param>
        /// <param name="model">The model to request for translation. May be null, in which case <see cref="DefaultModel"/> is
        /// used.</param>
        /// <returns>A list of translations. This will be the same size as <paramref name="htmlItems"/>, in the same order.</returns>
        public virtual IList<TranslationResult> TranslateHtml(IEnumerable<string> htmlItems, string targetLanguage, string sourceLanguage = null, TranslationModel? model = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Detects the language of the specified text synchronously.
        /// </summary>
        /// <remarks>This implementation simply delegates to <see cref="DetectLanguages(IEnumerable{string})"/>.</remarks>
        /// <param name="text">The text to detect the language of. Must not be null.</param>
        /// <returns>The most likely detected language.</returns>
        public virtual Detection DetectLanguage(string text) =>
            DetectLanguages(new[] { GaxPreconditions.CheckNotNull(text, nameof(text)) })[0];

        /// <summary>
        /// Detects the languages of the specified text items synchronously.
        /// </summary>
        /// <param name="textItems">The text items to detect the language of. Must not be null or contain null elements.</param>
        /// <returns>A list of detected languages. This will be the same size as <paramref name="textItems"/>, in the same order.</returns>
        public virtual IList<Detection> DetectLanguages(IEnumerable<string> textItems)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the language supported by the Translate API synchronously.
        /// </summary>
        /// <param name="target">The target language in which to return the language names in the results,
        /// for display purposes. May be null, in which case only the language codes are returned.</param>
        /// <returns>A list of supported languages.</returns>
        public virtual IList<Language> ListLanguages(string target = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Translates a single item of text asynchronously.
        /// </summary>
        /// <remarks>
        /// This implementation simply delegates to <see cref="TranslateTextAsync(IEnumerable{string}, string, string, TranslationModel?, CancellationToken)"/>
        /// </remarks>
        /// <param name="text">The text to translate. Must not be null.</param>
        /// <param name="targetLanguage">The code for the language to translate into. Must not be null.</param>
        /// <param name="sourceLanguage">The code for the language to translate from. May be null, in which case the server
        /// will detect the source language.</param>
        /// <param name="model">The model to request for translation. May be null, in which case <see cref="DefaultModel"/> is
        /// used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>The translation of <paramref name="text"/>.</returns>
        public virtual async Task<TranslationResult> TranslateTextAsync(string text, string targetLanguage, string sourceLanguage = null,
            TranslationModel? model = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            (await TranslateTextAsync(
                new[] { GaxPreconditions.CheckNotNull(text, nameof(text)) },
                targetLanguage,
                sourceLanguage,
                model,
                cancellationToken).ConfigureAwait(false))[0];

        /// <summary>
        /// Translates a single item of HTML asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This implementation simply delegates to <see cref="TranslateHtmlAsync(IEnumerable{string}, string, string, TranslationModel?, CancellationToken)"/>
        /// </para>
        /// <para>
        /// See the [Translation API documentation](https://cloud.google.com/translate/markup) for more details
        /// on how to translate HTML and the terms of service.
        /// </para>
        /// </remarks>
        /// <param name="html">The HTML to translate. Must not be null.</param>
        /// <param name="targetLanguage">The code for the language to translate into. Must not be null.</param>
        /// <param name="sourceLanguage">The code for the language to translate from. May be null, in which case the server
        /// will detect the source language.</param>
        /// <param name="model">The model to request for translation. May be null, in which case <see cref="DefaultModel"/> is
        /// used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>The translation of <paramref name="html"/>.</returns>
        public virtual async Task<TranslationResult> TranslateHtmlAsync(string html, string targetLanguage, string sourceLanguage = null,
            TranslationModel? model = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            (await TranslateHtmlAsync(
                new[] { GaxPreconditions.CheckNotNull(html, nameof(html)) },
                targetLanguage,
                sourceLanguage,
                model,
                cancellationToken).ConfigureAwait(false))[0];

        /// <summary>
        /// Translates multiple items of text asynchronously.
        /// </summary>
        /// <param name="textItems">The text strings to translate. Must not be null or contain null elements.</param>
        /// <param name="targetLanguage">The code for the language to translate into. Must not be null.</param>
        /// <param name="sourceLanguage">The code for the language to translate from. May be null, in which case the server
        /// will detect the source language.</param>
        /// <param name="model">The model to request for translation. May be null, in which case <see cref="DefaultModel"/> is
        /// used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A list of translations. This will be the same size as <paramref name="textItems"/>, in the same order.</returns>
        public virtual Task<IList<TranslationResult>> TranslateTextAsync(IEnumerable<string> textItems, string targetLanguage, string sourceLanguage = null,
            TranslationModel? model = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Translates multiple items of HTML asynchronously.
        /// </summary>
        /// <remarks>
        /// See the [Translation API documentation](https://cloud.google.com/translate/markup) for more details
        /// on how to translate HTML and the terms of service.
        /// </remarks>
        /// <param name="htmlItems">The HTML strings to translate. Must not be null or contain null elements.</param>
        /// <param name="targetLanguage">The code for the language to translate into. Must not be null.</param>
        /// <param name="sourceLanguage">The code for the language to translate from. May be null, in which case the server
        /// will detect the source language.</param>
        /// <param name="model">The model to request for translation. May be null, in which case <see cref="DefaultModel"/> is
        /// used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A list of translations. This will be the same size as <paramref name="htmlItems"/>, in the same order.</returns>
        public virtual Task<IList<TranslationResult>> TranslateHtmlAsync(IEnumerable<string> htmlItems, string targetLanguage, string sourceLanguage = null,
            TranslationModel? model = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Detects the language of the specified text asynchronously.
        /// </summary>
        /// <remarks>This implementation simply delegates to <see cref="DetectLanguagesAsync(IEnumerable{string}, CancellationToken)"/>.</remarks>
        /// <param name="text">The text to detect the language of. Must not be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>The most likely detected language.</returns>
        public virtual async Task<Detection> DetectLanguageAsync(string text, CancellationToken cancellationToken = default(CancellationToken)) =>
            (await DetectLanguagesAsync(new[] { GaxPreconditions.CheckNotNull(text, nameof(text)) }, cancellationToken)
            .ConfigureAwait(false))[0];

        /// <summary>
        /// Detects the languages of the specified text items asynchronously.
        /// </summary>
        /// <param name="textItems">The text items to detect the language of. Must not be null or contain null elements.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A list of detected languages. This will be the same size as <paramref name="textItems"/>, in the same order.</returns>
        public virtual Task<IList<Detection>> DetectLanguagesAsync(IEnumerable<string> textItems, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the language supported by the Translate API asynchronously.
        /// </summary>
        /// <param name="target">The target language in which to return the language names in the results,
        /// for display purposes. May be null, in which case only the language codes are returned.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A list of supported languages.</returns>
        public virtual Task<IList<Language>> ListLanguagesAsync(string target = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously creates a <see cref="TranslationClient"/>, using application default credentials if
        /// no credentials are specified.
        /// </summary>
        /// <remarks>
        /// The credentials are scoped as necessary.
        /// </remarks>
        /// <param name="credential">Optional <see cref="GoogleCredential"/>.</param>
        /// <param name="model">The default translation model to use. Defaults to <see cref="TranslationModel.ServiceDefault"/>.</param>
        /// <returns>The task representing the created <see cref="TranslationClient"/>.</returns>
        public static async Task<TranslationClient> CreateAsync(GoogleCredential credential = null, TranslationModel model = TranslationModel.ServiceDefault)
        {
            var scopedCredentials = await _credentialProvider.GetCredentialsAsync(credential).ConfigureAwait(false);
            return CreateImpl(scopedCredentials, null, model);
        }

        /// <summary>
        /// Creates a <see cref="TranslationClient"/> from an API key instead of using OAuth2 credentials.
        /// </summary>
        /// <remarks>
        /// You are encouraged to use OAuth2 credentials where possible. This method is primarily provided to make the transition
        /// from using API keys to OAuth2 credentials straightforward.
        /// </remarks>
        /// <param name="apiKey">API key to use. Must not be null.</param>
        /// <param name="model">The default translation model to use. Defaults to <see cref="TranslationModel.ServiceDefault"/>.</param>
        /// <returns>The created <see cref="TranslationClient"/>.</returns>
        public static TranslationClient CreateFromApiKey(string apiKey, TranslationModel model = TranslationModel.ServiceDefault)
        {
            GaxPreconditions.CheckNotNull(apiKey, nameof(apiKey));
            return CreateImpl(null, apiKey, model);
        }

        /// <summary>
        /// Synchronously creates a <see cref="TranslationClient"/>, using application default credentials if
        /// no credentials are specified.
        /// </summary>
        /// <remarks>
        /// The credentials are scoped as necessary.
        /// </remarks>
        /// <param name="credential">Optional <see cref="GoogleCredential"/>.</param>
        /// <param name="model">The default translation model to use. Defaults to <see cref="TranslationModel.ServiceDefault"/>.</param>
        /// <returns>The created <see cref="TranslationClient"/>.</returns>
        public static TranslationClient Create(GoogleCredential credential = null, TranslationModel model = TranslationModel.ServiceDefault)
        {
            var scopedCredentials = _credentialProvider.GetCredentials(credential);
            return CreateImpl(scopedCredentials, null, model);
        }

        private static TranslationClient CreateImpl(GoogleCredential scopedCredentials, string apiKey, TranslationModel model)
        {
            var service = new TranslateService(new BaseClientService.Initializer
            {
                HttpClientInitializer = scopedCredentials,
                ApplicationName = TranslationClientImpl.ApplicationName,
                ApiKey = apiKey
            });

            return new TranslationClientImpl(service, model);
        }
    }
}
