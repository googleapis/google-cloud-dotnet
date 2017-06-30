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
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Semantics;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.Analyzers
{
    /// <summary>
    /// Code fix provider for the <see cref="InternalOptionalParametersRequiredAnalyzer"/>.
    /// </summary>
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(InternalOptionalParametersRequiredCodeFixProvider)), Shared]
    public class InternalOptionalParametersRequiredCodeFixProvider : CodeFixProvider
    {
        private const string Title = "Insert optional arguments";

        public sealed override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(InternalOptionalParametersRequiredAnalyzer.DiagnosticId); }
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

            var argumentListExpression =
                root.FindToken(context.Span.Start).Parent.AncestorsAndSelf().OfType<ArgumentListSyntax>().FirstOrDefault();
            if (argumentListExpression == null)
            {
                return;
            }

            if (!(semanticModel.GetOperation(argumentListExpression, context.CancellationToken) is IInvocationExpression invocation))
            {
                return;
            }

            var variablesInScope =
                InternalOptionalParametersRequiredAnalyzer.GetVariablesInScope(argumentListExpression, semanticModel);

            var omittedParameterVariablePairs = new List<Tuple<string, string>>();
            bool useNamedArguments = false;
            foreach (var argument in invocation.ArgumentsInParameterOrder)
            {
                switch (argument.ArgumentKind)
                {
                    case ArgumentKind.Positional:
                        break;
                    case ArgumentKind.Named:
                        useNamedArguments = true;
                        break;
                    case ArgumentKind.DefaultValue:
                    {
                        var preferredVariable = InternalOptionalParametersRequiredAnalyzer.TryGetVariableForArgument(
                            argument.Parameter, semanticModel.Compilation, variablesInScope);
                        if (preferredVariable == null)
                        {
                            return;
                        }
                        omittedParameterVariablePairs.Add(Tuple.Create(argument.Parameter.Name, preferredVariable.Name));
                        break;
                    }
                    default:
                        return;
                }
            }

            var generator = SyntaxGenerator.GetGenerator(document);
            var newArguments = omittedParameterVariablePairs.Select(
                entry => (ArgumentSyntax)generator.Argument(
                    useNamedArguments ? entry.Item1 : null,
                    RefKind.None,
                    generator.IdentifierName(entry.Item2))).ToArray();
            var newDocument = document.WithSyntaxRoot(
                root.ReplaceNode(argumentListExpression, argumentListExpression.AddArguments(newArguments)));

            context.RegisterCodeFix(
                CodeAction.Create(
                    title: Title,
                    createChangedDocument: c => Task.FromResult(newDocument),
                    equivalenceKey: Title),
                context.Diagnostics);
        }
    }
}
