// Copyright 2019 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax.Rest;
using Google.Apis.Translate.v2;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Translation.V2
{
    /// <summary>
    /// A builder for <see cref="AdvancedTranslationClient"/>, allowing simple client customization.
    /// </summary>
    public sealed class AdvancedTranslationClientBuilder : ClientBuilderBase<AdvancedTranslationClient>
    {
        /// <summary>
        /// The translation model to use.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Creates a new builder with default settings.
        /// </summary>
        public AdvancedTranslationClientBuilder()
        {
            UseJwtAccessWithScopes = true;
        }

        /// <inheritdoc />
        public override AdvancedTranslationClient Build()
        {
            Validate();
            var initializer = CreateServiceInitializer();
            var service = new TranslateService(initializer);
            return new AdvancedTranslationClientImpl(service, Model);
        }

        /// <inheritdoc />
        public override async Task<AdvancedTranslationClient> BuildAsync(CancellationToken cancellationToken = default)
        {
            Validate();
            var initializer = await CreateServiceInitializerAsync(cancellationToken).ConfigureAwait(false);
            var service = new TranslateService(initializer);
            return new AdvancedTranslationClientImpl(service, Model);
        }

        /// <inheritdoc />
        protected override string GetDefaultApplicationName() => AdvancedTranslationClientImpl.ApplicationName;

        /// <inheritdoc />
        protected override ScopedCredentialProvider GetScopedCredentialProvider() => TranslationClient.ScopedCredentialProvider;
    }
}
