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

using Google.Cloud.Tools.Common;
using Google.Cloud.Tools.SourceManipulation;
using System.IO;

namespace Google.Cloud.Language.V1.FixGeneratedCode
{
    /// <summary>
    /// Applies fixes to the generated Language code.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var layout = DirectoryLayout.ForApi("Google.Cloud.Language.V1");

            // We have manually-written versions of AnalyzeEntities, AnalyzeEntitySentiment, AnalyzeSyntax and AnnotateText
            // which accept a document and automatically request UTF-16. Currently the generated methods will just omit the
            // encoding, which means no offsets are returned. At some point the service may heuristically determine that it
            // should use UTF-16, at which point we can remove the manual code - but until then, we remove the generated code.
            SourceFile.Load(Path.Combine(layout.SourceDirectory, "Google.Cloud.Language.V1", "LanguageServiceClient.g.cs"))
                .RemoveMethod("LanguageServiceClient", "AnalyzeEntitiesAsync", "Document", "CallSettings")
                .RemoveMethod("LanguageServiceClient", "AnalyzeEntitiesAsync", "Document", "CancellationToken")
                .RemoveMethod("LanguageServiceClient", "AnalyzeEntities", "Document", "CallSettings")
                .RemoveMethod("LanguageServiceClient", "AnalyzeEntitySentimentAsync", "Document", "CallSettings")
                .RemoveMethod("LanguageServiceClient", "AnalyzeEntitySentimentAsync", "Document", "CancellationToken")
                .RemoveMethod("LanguageServiceClient", "AnalyzeEntitySentiment", "Document", "CallSettings")
                .RemoveMethod("LanguageServiceClient", "AnalyzeSyntaxAsync", "Document", "CallSettings")
                .RemoveMethod("LanguageServiceClient", "AnalyzeSyntaxAsync", "Document", "CancellationToken")
                .RemoveMethod("LanguageServiceClient", "AnalyzeSyntax", "Document", "CallSettings")
                .RemoveMethod("LanguageServiceClient", "AnnotateTextAsync", "Document", "Features", "CallSettings")
                .RemoveMethod("LanguageServiceClient", "AnnotateTextAsync", "Document", "Features", "CancellationToken")
                .RemoveMethod("LanguageServiceClient", "AnnotateText", "Document", "Features", "CallSettings")
                .Save();
        }
    }
}
