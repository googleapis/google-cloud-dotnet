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

using Google.Api.Gax.Grpc;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;

namespace Google.Cloud.Language.V1
{
    public partial class LanguageServiceClient
    {
        /// <summary>
        /// Analyzes the entities in the given document, specifying an <see cref="EncodingType"/> of
        /// UTF-16 for offsets.
        /// </summary>
        /// <remarks>
        /// This method simply calls <see cref="AnalyzeEntities(Document, EncodingType?, CallSettings)"/>,
        /// passing an <see cref="EncodingType"/> of UTF-16. This is the encoding used internally by
        /// .NET strings, so the offsets returned by the analysis will be suitable for use in calls
        /// such as <see cref="string.Substring(int, int)"/>.
        /// </remarks>
        /// <param name="document">The document to analyze.</param>
        /// <param name="callSettings">The call settings to apply to the RPC, if any.</param>
        /// <returns>The result of the entity analysis.</returns>
        public virtual AnalyzeEntitiesResponse AnalyzeEntities(
            Document document,
            CallSettings callSettings = null) =>
            AnalyzeEntities(document, EncodingType.Utf16, callSettings);

        /// <summary>
        /// Analyzes the entities in the given document asynchronously, specifying an <see cref="EncodingType"/> of
        /// UTF-16 for offsets.
        /// </summary>
        /// <remarks>
        /// This method simply calls <see cref="AnalyzeEntitiesAsync(Document, EncodingType?, CancellationToken)"/>,
        /// passing an <see cref="EncodingType"/> of UTF-16. This is the encoding used internally by
        /// .NET strings, so the offsets returned by the analysis will be suitable for use in calls
        /// such as <see cref="string.Substring(int, int)"/>.
        /// </remarks>
        /// <param name="document">The document to analyze.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the entity analysis response.</returns>
        public virtual Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(
            Document document,
            CancellationToken cancellationToken) =>
            AnalyzeEntitiesAsync(document, EncodingType.Utf16, cancellationToken);

        /// <summary>
        /// Analyzes the entities in the given document asynchronously, specifying an <see cref="EncodingType"/> of
        /// UTF-16 for offsets.
        /// </summary>
        /// <remarks>
        /// This method simply calls <see cref="AnalyzeEntitiesAsync(Document, EncodingType?, CallSettings)"/>,
        /// passing an <see cref="EncodingType"/> of UTF-16. This is the encoding used internally by
        /// .NET strings, so the offsets returned by the analysis will be suitable for use in calls
        /// such as <see cref="string.Substring(int, int)"/>.
        /// </remarks>
        /// <param name="document">The document to analyze.</param>
        /// <param name="callSettings">The call settings to apply to the RPC, if any.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the entity analysis response.</returns>
        public virtual Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(
            Document document,
            CallSettings callSettings = null) =>
            AnalyzeEntitiesAsync(document, EncodingType.Utf16, callSettings);

        /// <summary>
        /// Analyzes the syntax in the given document, specifying an <see cref="EncodingType"/> of
        /// UTF-16 for offsets.
        /// </summary>
        /// <remarks>
        /// This method simply calls <see cref="AnalyzeSyntax(Document, EncodingType?, CallSettings)"/>,
        /// passing an <see cref="EncodingType"/> of UTF-16. This is the encoding used internally by
        /// .NET strings, so the offsets returned by the analysis will be suitable for use in calls
        /// such as <see cref="string.Substring(int, int)"/>.
        /// </remarks>
        /// <param name="document">The document to analyze.</param>
        /// <param name="callSettings">The call settings to apply to the RPC, if any.</param>
        /// <returns>The result of the entity analysis.</returns>
        public virtual AnalyzeSyntaxResponse AnalyzeSyntax(
            Document document,
            CallSettings callSettings = null) =>
            AnalyzeSyntax(document, EncodingType.Utf16, callSettings);

        /// <summary>
        /// Analyzes the syntax in the given document asynchronously, specifying an <see cref="EncodingType"/> of
        /// UTF-16 for offsets.
        /// </summary>
        /// <remarks>
        /// This method simply calls <see cref="AnalyzeSyntaxAsync(Document, EncodingType?, CancellationToken)"/>,
        /// passing an <see cref="EncodingType"/> of UTF-16. This is the encoding used internally by
        /// .NET strings, so the offsets returned by the analysis will be suitable for use in calls
        /// such as <see cref="string.Substring(int, int)"/>.
        /// </remarks>
        /// <param name="document">The document to analyze.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the entity analysis response.</returns>
        public virtual Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(
            Document document,
            CancellationToken cancellationToken) =>
            AnalyzeSyntaxAsync(document, EncodingType.Utf16, cancellationToken);

        /// <summary>
        /// Analyzes the syntax in the given document asynchronously, specifying an <see cref="EncodingType"/> of
        /// UTF-16 for offsets.
        /// </summary>
        /// <remarks>
        /// This method simply calls <see cref="AnalyzeSyntaxAsync(Document, EncodingType?, CallSettings)"/>,
        /// passing an <see cref="EncodingType"/> of UTF-16. This is the encoding used internally by
        /// .NET strings, so the offsets returned by the analysis will be suitable for use in calls
        /// such as <see cref="string.Substring(int, int)"/>.
        /// </remarks>
        /// <param name="document">The document to analyze.</param>
        /// <param name="callSettings">The call settings to apply to the RPC, if any.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the entity analysis response.</returns>
        public virtual Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(
            Document document,
            CallSettings callSettings = null) =>
            AnalyzeSyntaxAsync(document, EncodingType.Utf16, callSettings);

        /// <summary>
        /// Annotates the given document, specifying an <see cref="EncodingType"/> of
        /// UTF-16 for offsets.
        /// </summary>
        /// <remarks>
        /// This method simply calls <see cref="AnnotateText(Document, Features, EncodingType?, CallSettings)"/>,
        /// passing an <see cref="EncodingType"/> of UTF-16. This is the encoding used internally by
        /// .NET strings, so the offsets returned by the analysis will be suitable for use in calls
        /// such as <see cref="string.Substring(int, int)"/>.
        /// </remarks>
        /// <param name="document">The document to annotate.</param>
        /// <param name="features">The analysis features to enable.</param>
        /// <param name="callSettings">The call settings to apply to the RPC, if any.</param>
        /// <returns>The result of the text analysis.</returns>
        public virtual AnnotateTextResponse AnnotateText(
            Document document,
            Features features,
            CallSettings callSettings = null) =>
            AnnotateText(document, features, EncodingType.Utf16, callSettings);

        /// <summary>
        /// Annotates the given document, specifying an <see cref="EncodingType"/> of
        /// UTF-16 for offsets.
        /// </summary>
        /// <remarks>
        /// This method simply calls <see cref="AnnotateTextAsync(Document, Features, EncodingType?, CancellationToken)"/>,
        /// passing an <see cref="EncodingType"/> of UTF-16. This is the encoding used internally by
        /// .NET strings, so the offsets returned by the analysis will be suitable for use in calls
        /// such as <see cref="string.Substring(int, int)"/>.
        /// </remarks>
        /// <param name="document">The document to annotate.</param>
        /// <param name="features">The analysis features to enable.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the text analysis response.</returns>
        public virtual Task<AnnotateTextResponse> AnnotateTextAsync(
            Document document,
            Features features,
            CancellationToken cancellationToken) =>
            AnnotateTextAsync(document, features, EncodingType.Utf16, cancellationToken);

        /// <summary>
        /// Annotates the given document, specifying an <see cref="EncodingType"/> of
        /// UTF-16 for offsets.
        /// </summary>
        /// <remarks>
        /// This method simply calls <see cref="AnnotateTextAsync(Document, Features, EncodingType?, CallSettings)"/>,
        /// passing an <see cref="EncodingType"/> of UTF-16. This is the encoding used internally by
        /// .NET strings, so the offsets returned by the analysis will be suitable for use in calls
        /// such as <see cref="string.Substring(int, int)"/>.
        /// </remarks>
        /// <param name="document">The document to annotate.</param>
        /// <param name="features">The analysis features to enable.</param>
        /// <param name="callSettings">The call settings to apply to the RPC, if any.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the text analysis response.</returns>
        public virtual Task<AnnotateTextResponse> AnnotateTextAsync(
            Document document,
            Features features,
            CallSettings callSettings = null) =>
            AnnotateTextAsync(document, features, EncodingType.Utf16, callSettings);

        // TODO: An AnalyzeSyntax method that just calls AnnotateText with the ExtractSyntax feature?
    }
}
