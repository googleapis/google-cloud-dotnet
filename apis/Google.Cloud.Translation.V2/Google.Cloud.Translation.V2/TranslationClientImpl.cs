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
using Google.Api.Gax.Rest;
using Google.Apis.Translate.v2;
using Google.Apis.Util;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Translate.v2.TranslationsResource;
using static Google.Apis.Translate.v2.TranslationsResource.ListRequest;

namespace Google.Cloud.Translation.V2
{
    /// <summary>
    /// Wrapper around <see cref="TranslateService"/> to provide simpler operations.
    /// </summary>
    /// <remarks>
    /// This is the "default" implementation of <see cref="TranslationClient"/>. Most client code
    /// should refer to <see cref="TranslationClient"/>, creating instances with
    /// <see cref="TranslationClient.Create(Apis.Auth.OAuth2.GoogleCredential, TranslationModel)"/>,
    /// <see cref="TranslationClient.CreateAsync(Apis.Auth.OAuth2.GoogleCredential, TranslationModel)"/> and
    /// <see cref="TranslationClient.CreateFromApiKey(string, TranslationModel)"/>.
    /// The constructor of this class is public for the sake of constructor-based dependency injection.
    /// </remarks>
    public sealed class TranslationClientImpl : TranslationClient
    {
        private static readonly object _applicationNameLock = new object();
        private static string _applicationName = UserAgentHelper.GetDefaultUserAgent(typeof(TranslationClient));

        /// <summary>
        /// The default application name used when creating a <see cref="TranslateService"/>.
        /// Defaults to "google-cloud-dotnet"; must not be null.
        /// </summary>
        /// <remarks>
        /// Most applications will never want to set this, which is why it's in this class rather than
        /// <see cref="TranslationClient"/>.
        /// </remarks>
        public static string ApplicationName
        {
            get
            {
                lock (_applicationNameLock)
                {
                    return _applicationName;
                }
            }
            set
            {
                GaxPreconditions.CheckNotNull(value, nameof(value));
                lock (_applicationNameLock)
                {
                    _applicationName = value;
                }
            }
        }

        /// <inheritdoc />
        public override TranslateService Service { get; }

        /// <inheritdoc />
        public override TranslationModel DefaultModel { get; }

        /// <summary>
        /// Constructs a new client wrapping the given <see cref="TranslateService"/>.
        /// </summary>
        /// <param name="service">The service to wrap. Must not be null.</param>
        /// <param name="model">The default translation model to use. Defaults to <see cref="TranslationModel.Base"/>.</param>
        public TranslationClientImpl(TranslateService service, TranslationModel model = TranslationModel.Base)
        {
            Service = GaxPreconditions.CheckNotNull(service, nameof(service));
            TranslationModels.ValidateModel(model);
            DefaultModel = model;
        }

        /// <inheritdoc />
        public override TranslationResult TranslateText(string text, string targetLanguage, string sourceLanguage = null, TranslationModel? model = null)
        {
            var request = Service.Translations.List(new Repeatable<string>(new[] { text }), targetLanguage);
            ModifyRequest(request, sourceLanguage, FormatEnum.Text, model);
            var result = request.Execute().Translations[0];
            return new TranslationResult(result, text, sourceLanguage, targetLanguage);
        }

        /// <inheritdoc />
        public override TranslationResult TranslateHtml(string text, string targetLanguage, string sourceLanguage = null, TranslationModel? model = null)
        {
            var request = Service.Translations.List(new Repeatable<string>(new[] { text }), targetLanguage);
            ModifyRequest(request, sourceLanguage, FormatEnum.Html, model);
            var result = request.Execute().Translations[0];
            return new TranslationResult(result, text, sourceLanguage, targetLanguage);
        }

        /// <inheritdoc />
        public override IList<TranslationResult> TranslateText(IEnumerable<string> textItems, string targetLanguage, string sourceLanguage = null, TranslationModel? model = null)
        {
            // Evaluate once so we can zip suitably.
            List<string> items = textItems.ToList();
            var request = Service.Translations.List(new Repeatable<string>(items), targetLanguage);
            ModifyRequest(request, sourceLanguage, FormatEnum.Text, model);
            return request.Execute().Translations
                .Zip(items, (result, item) => new TranslationResult(result, item, sourceLanguage, targetLanguage))
                .ToList();
        }

        /// <inheritdoc />
        public override IList<TranslationResult> TranslateHtml(IEnumerable<string> htmlItems, string targetLanguage, string sourceLanguage = null, TranslationModel? model = null)
        {
            // Evaluate once so we can zip suitably.
            List<string> items = htmlItems.ToList();
            var request = Service.Translations.List(new Repeatable<string>(items), targetLanguage);
            ModifyRequest(request, sourceLanguage, FormatEnum.Html, model);
            return request.Execute().Translations
                .Zip(items, (result, item) => new TranslationResult(result, item, sourceLanguage, targetLanguage))
                .ToList();
        }

        /// <inheritdoc />
        public override IList<Detection> DetectLanguage(string text)
        {
            var request = Service.Detections.List(new Repeatable<string>(new[] { text }));
            var result = request.Execute().Detections[0];
            return result.Select(Detection.FromResource).ToList();
        }

        /// <inheritdoc />
        public override IList<Language> ListLanguages(string target = null)
        {
            var request = Service.Languages.List();
            request.Target = target;
            return request.Execute().Languages.Select(Language.FromResource).ToList();
        }

        /// <inheritdoc />
        public override async Task<TranslationResult> TranslateTextAsync(string text, string targetLanguage, string sourceLanguage = null,
            TranslationModel? model = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = Service.Translations.List(new Repeatable<string>(new[] { text }), targetLanguage);
            ModifyRequest(request, sourceLanguage, FormatEnum.Text, model);
            var result = (await request.ExecuteAsync(cancellationToken).ConfigureAwait(false)).Translations[0];
            return new TranslationResult(result, text, sourceLanguage, targetLanguage);
        }

        /// <inheritdoc />
        public override async Task<TranslationResult> TranslateHtmlAsync(string text, string targetLanguage, string sourceLanguage = null,
            TranslationModel? model = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = Service.Translations.List(new Repeatable<string>(new[] { text }), targetLanguage);
            ModifyRequest(request, sourceLanguage, FormatEnum.Html, model);
            var result = (await request.ExecuteAsync(cancellationToken).ConfigureAwait(false)).Translations[0];
            return new TranslationResult(result, text, sourceLanguage, targetLanguage);
        }

        /// <inheritdoc />
        public override async Task<IList<TranslationResult>> TranslateTextAsync(IEnumerable<string> textItems, string targetLanguage, string sourceLanguage = null,
            TranslationModel? model = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Evaluate once so we can zip suitably.
            List<string> items = textItems.ToList();
            var request = Service.Translations.List(new Repeatable<string>(items), targetLanguage);
            ModifyRequest(request, sourceLanguage, FormatEnum.Text, model);
            return (await request.ExecuteAsync(cancellationToken).ConfigureAwait(false)).Translations
                .Zip(items, (result, item) => new TranslationResult(result, item, sourceLanguage, targetLanguage))
                .ToList();
        }

        /// <inheritdoc />
        public override async Task<IList<TranslationResult>> TranslateHtmlAsync(IEnumerable<string> htmlItems, string targetLanguage, string sourceLanguage = null,
            TranslationModel? model = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // Evaluate once so we can zip suitably.
            List<string> items = htmlItems.ToList();
            var request = Service.Translations.List(new Repeatable<string>(items), targetLanguage);
            ModifyRequest(request, sourceLanguage, FormatEnum.Html, model);
            return (await request.ExecuteAsync(cancellationToken).ConfigureAwait(false)).Translations
                .Zip(items, (result, item) => new TranslationResult(result, item, sourceLanguage, targetLanguage))
                .ToList();
        }

        /// <inheritdoc />
        public override async Task<IList<Detection>> DetectLanguageAsync(string text, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = Service.Detections.List(new Repeatable<string>(new[] { text }));
            var result = (await request.ExecuteAsync(cancellationToken).ConfigureAwait(false)).Detections[0];
            return result.Select(Detection.FromResource).ToList();
        }

        /// <inheritdoc />
        public override async Task<IList<Language>> ListLanguagesAsync(string target = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = Service.Languages.List();
            request.Target = target;
            return (await request.ExecuteAsync(cancellationToken).ConfigureAwait(false)).Languages.Select(Language.FromResource).ToList();
        }

        private void ModifyRequest(ListRequest request, string sourceLanguage, FormatEnum format, TranslationModel? model)
        {
            request.Source = sourceLanguage;
            request.Format = format;
            var effectiveModel = model ?? DefaultModel;
            TranslationModels.ValidateModel(effectiveModel);
            // Never explicitly request the base model.
            request.Model = effectiveModel == TranslationModel.Base ? null : effectiveModel.ToApiName();
        }      
    }
}
