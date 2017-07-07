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

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Immutable;
using System.Composition;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.Analyzers
{
    /// <summary>
    /// Code fix provider for the <see cref="MissingCopyrightNoticeAnalyzer"/>.
    /// </summary>
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(MissingCopyrightNoticeCodeFixProvider)), Shared]
    public class MissingCopyrightNoticeCodeFixProvider : CodeFixProvider
    {
        private const string TitleApache = "Insert Apache license";
        private const string TitleBsd = "Insert BSD license";

        public bool IsTesting { get; set; }

        private string YearString { get => IsTesting ? "1234" : DateTime.Now.ToString("yyyy"); }

        public sealed override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(MissingCopyrightNoticeAnalyzer.DiagnosticId); }
        }

        public sealed override FixAllProvider GetFixAllProvider()
        {
            return WellKnownFixAllProviders.BatchFixer;
        }

        public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            var document = context.Document;
            var rootNode = await document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);

            context.RegisterCodeFix(
                CodeAction.Create(
                    title: TitleApache,
                    createChangedDocument: c => Task.FromResult(
                        AddCopyrightToDocument(document, rootNode, MissingCopyrightNoticeAnalyzer.CopyrightApacheTemplate)),
                    equivalenceKey: TitleApache),
                context.Diagnostics);

            context.RegisterCodeFix(
                CodeAction.Create(
                    title: TitleBsd,
                    createChangedDocument: c => Task.FromResult(
                        AddCopyrightToDocument(document, rootNode, MissingCopyrightNoticeAnalyzer.CopyrightBsdTemplate)),
                    equivalenceKey: TitleBsd),
                context.Diagnostics);
        }

        private Document AddCopyrightToDocument(Document document, SyntaxNode rootNode, string copyrightTemplate) =>
            document.WithSyntaxRoot(
                rootNode.WithLeadingTrivia(rootNode.GetLeadingTrivia().InsertRange(
                    0,
                    SyntaxFactory.ParseLeadingTrivia(CreateCopyrightNotice(copyrightTemplate)))));

        private string CreateCopyrightNotice(string copyrightTemplate) =>
            copyrightTemplate.Replace("____", YearString) + Environment.NewLine + Environment.NewLine;
    }
}
