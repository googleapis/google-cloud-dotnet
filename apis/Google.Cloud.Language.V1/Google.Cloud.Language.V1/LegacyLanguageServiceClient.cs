// Copyright 2016 Google Inc. All Rights Reserved.
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using System;

namespace Google.Cloud.Language.V1
{
    // Legacy methods accepting Nullable<EncodingType> parameters.

    public partial class LanguageServiceClient
    {
        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate sentence offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual AnalyzeSentimentResponse AnalyzeSentiment(Document document, EncodingType? encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSentiment(new AnalyzeSentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType ?? EncodingType.None,
            }, callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate sentence offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(Document document, EncodingType? encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSentimentAsync(new AnalyzeSentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType ?? EncodingType.None,
            }, callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate sentence offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(Document document, EncodingType? encodingType, st::CancellationToken cancellationToken) =>
            AnalyzeSentimentAsync(document, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual AnalyzeEntitiesResponse AnalyzeEntities(Document document, EncodingType? encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeEntities(new AnalyzeEntitiesRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType ?? EncodingType.None,
            }, callSettings);

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(Document document, EncodingType? encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeEntitiesAsync(new AnalyzeEntitiesRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType ?? EncodingType.None,
            }, callSettings);

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(Document document, EncodingType? encodingType, st::CancellationToken cancellationToken) =>
            AnalyzeEntitiesAsync(document, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual AnalyzeEntitySentimentResponse AnalyzeEntitySentiment(Document document, EncodingType? encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeEntitySentiment(new AnalyzeEntitySentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType ?? EncodingType.None,
            }, callSettings);

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual stt::Task<AnalyzeEntitySentimentResponse> AnalyzeEntitySentimentAsync(Document document, EncodingType? encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeEntitySentimentAsync(new AnalyzeEntitySentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType ?? EncodingType.None,
            }, callSettings);

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual stt::Task<AnalyzeEntitySentimentResponse> AnalyzeEntitySentimentAsync(Document document, EncodingType? encodingType, st::CancellationToken cancellationToken) =>
            AnalyzeEntitySentimentAsync(document, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual AnalyzeSyntaxResponse AnalyzeSyntax(Document document, EncodingType? encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSyntax(new AnalyzeSyntaxRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType ?? EncodingType.None,
            }, callSettings);

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual stt::Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(Document document, EncodingType? encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSyntaxAsync(new AnalyzeSyntaxRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType ?? EncodingType.None,
            }, callSettings);

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual stt::Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(Document document, EncodingType? encodingType, st::CancellationToken cancellationToken) =>
            AnalyzeSyntaxAsync(document, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment,
        /// analyzeEntities, and analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="features">
        /// The enabled features.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual AnnotateTextResponse AnnotateText(Document document, AnnotateTextRequest.Types.Features features, EncodingType? encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateText(new AnnotateTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                Features = gax::GaxPreconditions.CheckNotNull(features, nameof(features)),
                EncodingType = encodingType ?? EncodingType.None,
            }, callSettings);

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment,
        /// analyzeEntities, and analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="features">
        /// The enabled features.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual stt::Task<AnnotateTextResponse> AnnotateTextAsync(Document document, AnnotateTextRequest.Types.Features features, EncodingType? encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateTextAsync(new AnnotateTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                Features = gax::GaxPreconditions.CheckNotNull(features, nameof(features)),
                EncodingType = encodingType ?? EncodingType.None,
            }, callSettings);

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment,
        /// analyzeEntities, and analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="features">
        /// The enabled features.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [Obsolete("This method is obsolete, and will be removed in the next major version. Please use the overload accepting a non-nullable EncodingType.")]
        public virtual stt::Task<AnnotateTextResponse> AnnotateTextAsync(Document document, AnnotateTextRequest.Types.Features features, EncodingType? encodingType, st::CancellationToken cancellationToken) =>
            AnnotateTextAsync(document, features, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }
}
