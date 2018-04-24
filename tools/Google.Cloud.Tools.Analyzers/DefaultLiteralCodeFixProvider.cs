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
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.Analyzers
{
    /// <summary>
    /// Code fix provider for the <see cref="DefaultLiteralAnalyzer"/>.
    /// </summary>
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(DefaultLiteralCodeFixProvider)), Shared]
    public class DefaultLiteralCodeFixProvider : CodeFixProvider
    {
        private const string Title = "Convert to default value expression";

        public sealed override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(DefaultLiteralAnalyzer.DiagnosticId); }
        }

        public sealed override FixAllProvider GetFixAllProvider()
        {
            return WellKnownFixAllProviders.BatchFixer;
        }

        public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            var document = context.Document;
            var semanticModel = await document.GetSemanticModelAsync(context.CancellationToken).ConfigureAwait(false);
            var root = await document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);
            var defaultLiteralExpression =
                root.FindToken(context.Span.Start).Parent.AncestorsAndSelf().OfType<LiteralExpressionSyntax>().FirstOrDefault();
            if (defaultLiteralExpression == null ||
                !defaultLiteralExpression.IsKind(SyntaxKind.DefaultLiteralExpression))
            {
                return;
            }

            var typeInfo = semanticModel.GetTypeInfo(defaultLiteralExpression, context.CancellationToken);
            if (typeInfo.ConvertedType.IsNullable(out _))
            {
                // Note: this should use a generator's DefaultExpression method, but for some reason, VS chokes on its result:
                //       the preview can't be displayed and choosing to apply the fix fails to do so and also wipes out the undo stack.
                var defaultExpression = SyntaxFactory.ParseExpression($"default({typeInfo.ConvertedType.ToDisplayString()})");

                var newDocument = document.WithSyntaxRoot(root.ReplaceNode(defaultLiteralExpression, defaultExpression));

                context.RegisterCodeFix(
                    CodeAction.Create(
                        title: Title,
                        createChangedDocument: c => Task.FromResult(newDocument),
                        equivalenceKey: Title),
                    context.Diagnostics);
            }        
        }
    }
}
