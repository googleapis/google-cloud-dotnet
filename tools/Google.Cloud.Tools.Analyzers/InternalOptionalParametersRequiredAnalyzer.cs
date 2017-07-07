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
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Semantics;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Google.Cloud.Tools.Analyzers
{
    /// <summary>
    /// Warns about omitted default arguments for calls to externally visible methods which are defined within the same assembly,
    /// but only when there is a suitable local variable or parameter available in scope which can be used for the argument.
    /// </summary>
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class InternalOptionalParametersRequiredAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "GCP0001";
        private const string Category = "Usage";

        private static readonly LocalizableString Title = "Publicly optional parameter omitted in internal call";
        private static readonly LocalizableString MessageFormat = "The parameter '{0}' should be specified, possibly with the local '{1}'";
        private static readonly LocalizableString Description = "Publicly optional parameters should be specified on internal calls.";
        private static DiagnosticDescriptor Rule =
            new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Warning, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.EnableConcurrentExecution();
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics);
            context.RegisterOperationAction(AnalyzeInvocation, OperationKind.InvocationExpression);
        }

        private static void AnalyzeInvocation(OperationAnalysisContext context)
        {
            // Only perform the check on calls to externally visible methods which are defined within the same assembly.
            var invocation = (IInvocationExpression)context.Operation;
            if (invocation.Syntax is InvocationExpressionSyntax invocationExpression &&
                invocation.TargetMethod?.IsExternallyVisible() == true &&
                context.Compilation.Assembly == invocation.TargetMethod.ContainingAssembly)
            {
                var semanticModel = context.Compilation.GetSemanticModel(context.Operation.Syntax.SyntaxTree);
                var variablesInScope = GetVariablesInScope(context.Operation.Syntax, semanticModel);

                foreach (var arg in invocation.ArgumentsInParameterOrder)
                {
                    if (arg.ArgumentKind != ArgumentKind.DefaultValue || arg.Parameter == null)
                    {
                        continue;
                    }

                    var preferredVariable = TryGetVariableForArgument(arg.Parameter, context.Compilation, variablesInScope);
                    if (preferredVariable == null)
                    {
                        continue;
                    }

                    context.ReportDiagnostic(
                        Diagnostic.Create(
                            Rule,
                            invocationExpression.ArgumentList.GetLocation(),
                            arg.Parameter.Name,
                            preferredVariable.Name));
                }
            }
        }

        internal static IEnumerable<ISymbol> GetVariablesInScope(SyntaxNode syntaxNode, SemanticModel semanticModel) =>
            from symbol in semanticModel.LookupSymbols(syntaxNode.SpanStart)
            where symbol.Kind == SymbolKind.Local || symbol.Kind == SymbolKind.Parameter
            select symbol;

        internal static ISymbol TryGetVariableForArgument(
            IParameterSymbol parameter, Compilation compilation, IEnumerable<ISymbol> variablesInScope)
        {
            var parameterType = parameter.Type;
            var convertibleVariables = variablesInScope.Where(
                symbol => compilation.ClassifyConversion(symbol.GetVariableType(), parameterType).IsImplicit).ToList();
            if (convertibleVariables.Count == 0)
            {
                return null;
            }

            var nameMatch = convertibleVariables.FirstOrDefault(
                symbol => symbol.Name.Equals(parameter.Name, StringComparison.OrdinalIgnoreCase));

            // If the parameter's type is String or any primitive type, only show the diagnostic when there is
            // some variable with the same (case-insensitive) name as the argument. Strings are too common, for
            // example, to assume that any string in scope should be supplied for a default parameter.
            if ((parameterType.SpecialType == SpecialType.System_String || parameterType.IsPrimitive()) &&
                nameMatch == null)
            {
                return null;
            }

            // Report the missing argument with a suggested variable to be used. Prefer one with a name matching
            // the missing parameter's name if available.
            return nameMatch ?? convertibleVariables[0];
        }
    }
}
