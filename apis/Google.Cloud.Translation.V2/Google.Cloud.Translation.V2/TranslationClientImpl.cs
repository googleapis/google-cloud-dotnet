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
using Google.Apis.Translate.v2.Data;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        private static Action<HttpRequestMessage> _versionHeaderAction = UserAgentHelper.CreateRequestModifier(typeof(TranslationClient));

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
        /// <param name="model">The default translation model to use. Defaults to <see cref="TranslationModel.ServiceDefault"/>.</param>
        public TranslationClientImpl(TranslateService service, TranslationModel model = TranslationModel.ServiceDefault)
        {
            Service = GaxPreconditions.CheckNotNull(service, nameof(service));
            TranslationModels.ValidateModel(model);
            DefaultModel = model;
        }

        /// <inheritdoc />
        public override IList<TranslationResult> TranslateText(IEnumerable<string> textItems, string targetLanguage, string sourceLanguage = null, TranslationModel? model = null)
        {
            var items = ConvertToListAndCheckNoNullElements(textItems, nameof(textItems));
            GaxPreconditions.CheckNotNull(targetLanguage, nameof(targetLanguage));
            var request = Service.Translations.List(new Repeatable<string>(items), targetLanguage);
            ModifyRequest(request, sourceLanguage, FormatEnum.Text, model);
            return UnpackTranslationResponse(items, sourceLanguage, targetLanguage, request.Execute());
        }

        /// <inheritdoc />
        public override IList<TranslationResult> TranslateHtml(IEnumerable<string> htmlItems, string targetLanguage, string sourceLanguage = null, TranslationModel? model = null)
        {
            var items = ConvertToListAndCheckNoNullElements(htmlItems, nameof(htmlItems));
            GaxPreconditions.CheckNotNull(targetLanguage, nameof(targetLanguage));
            var request = Service.Translations.List(new Repeatable<string>(items), targetLanguage);
            ModifyRequest(request, sourceLanguage, FormatEnum.Html, model);
            return UnpackTranslationResponse(items, sourceLanguage, targetLanguage, request.Execute());
        }

        /// <inheritdoc />
        public override IList<Detection> DetectLanguages(IEnumerable<string> textItems)
        {
            var items = ConvertToListAndCheckNoNullElements(textItems, nameof(textItems));
            var request = Service.Detections.List(new Repeatable<string>(items));
            request.ModifyRequest += _versionHeaderAction;
            return UnpackDetectResponse(items, request.Execute());
        }

        /// <inheritdoc />
        public override IList<Language> ListLanguages(string target = null, TranslationModel? model = null)
        {
            var request = Service.Languages.List();
            request.ModifyRequest += _versionHeaderAction;
            request.Target = target;
            request.Model = GetEffectiveModelName(model);
            return request.Execute().Languages.Select(Language.FromResource).ToList();
        }

        /// <inheritdoc />
        public override async Task<IList<TranslationResult>> TranslateTextAsync(IEnumerable<string> textItems, string targetLanguage, string sourceLanguage = null,
            TranslationModel? model = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var items = ConvertToListAndCheckNoNullElements(textItems, nameof(textItems));
            GaxPreconditions.CheckNotNull(targetLanguage, nameof(targetLanguage));
            var request = Service.Translations.List(new Repeatable<string>(items), targetLanguage);
            ModifyRequest(request, sourceLanguage, FormatEnum.Text, model);
            var response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return UnpackTranslationResponse(items, sourceLanguage, targetLanguage, response);
        }

        /// <inheritdoc />
        public override async Task<IList<TranslationResult>> TranslateHtmlAsync(IEnumerable<string> htmlItems, string targetLanguage, string sourceLanguage = null,
            TranslationModel? model = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var items = ConvertToListAndCheckNoNullElements(htmlItems, nameof(htmlItems));
            GaxPreconditions.CheckNotNull(targetLanguage, nameof(targetLanguage));
            var request = Service.Translations.List(new Repeatable<string>(items), targetLanguage);
            ModifyRequest(request, sourceLanguage, FormatEnum.Html, model);
            var response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return UnpackTranslationResponse(items, sourceLanguage, targetLanguage, response);
        }

        /// <inheritdoc />
        public override async Task<IList<Detection>> DetectLanguagesAsync(IEnumerable<string> textItems, CancellationToken cancellationToken = default(CancellationToken))
        {
            var items = ConvertToListAndCheckNoNullElements(textItems, nameof(textItems));
            var request = Service.Detections.List(new Repeatable<string>(items));
            request.ModifyRequest += _versionHeaderAction;
            var response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return UnpackDetectResponse(items, response);
        }

        /// <inheritdoc />
        public override async Task<IList<Language>> ListLanguagesAsync(string target = null, TranslationModel? model = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = Service.Languages.List();
            request.ModifyRequest += _versionHeaderAction;
            request.Target = target;
            request.Model = GetEffectiveModelName(model);
            return (await request.ExecuteAsync(cancellationToken).ConfigureAwait(false)).Languages.Select(Language.FromResource).ToList();
        }

        private static List<string> ConvertToListAndCheckNoNullElements(IEnumerable<string> source, string paramName)
        {
            GaxPreconditions.CheckNotNull(source, paramName);
            var ret = source.ToList();
            GaxPreconditions.CheckArgument(!ret.Contains(null), paramName, "Null elements are not permitted");
            return ret;
        }

        private static IList<TranslationResult> UnpackTranslationResponse(
            List<string> inputs, string sourceLanguage, string targetLanguage, TranslationsListResponse response)
        {
            var translations = response.Translations;
            if (inputs.Count != translations.Count)
            {
                throw new InvalidOperationException($"Expected {inputs.Count} translation results; got {translations.Count}");
            }
            return inputs.Zip(translations, (input, translation) => new TranslationResult(translation, input, sourceLanguage, targetLanguage))
                .ToList();
        }

        private static IList<Detection> UnpackDetectResponse(List<string> inputs, DetectionsListResponse response)
        {
            var detections = response.Detections;
            if (inputs.Count != detections.Count)
            {
                throw new InvalidOperationException($"Expected {inputs.Count} detection results; got {detections.Count}");
            }
            var firstInvalid = detections.FirstOrDefault(list => list.Count != 1);
            if (firstInvalid != null)
            {
                throw new InvalidOperationException($"Unexpected detection result: {firstInvalid.Count} items");
            }                
            return inputs.Zip(detections, (input, resourceList) => new Detection(input, resourceList[0]))
                .ToList();
        }

        private void ModifyRequest(ListRequest request, string sourceLanguage, FormatEnum format, TranslationModel? model)
        {
            request.ModifyRequest += _versionHeaderAction;
            request.Source = sourceLanguage;
            request.Format = format;
            request.Model = GetEffectiveModelName(model);
        }

        private string GetEffectiveModelName(TranslationModel? model)
        {
            var effectiveModel = model ?? DefaultModel;
            TranslationModels.ValidateModel(effectiveModel);
            return effectiveModel.ToApiName();
        }
    }
}
