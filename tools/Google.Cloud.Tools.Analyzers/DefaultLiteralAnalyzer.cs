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
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Google.Cloud.Tools.Analyzers
{
    // TODO: https://github.com/dotnet/roslyn/issues/22578 is now fixed in Roslyn 2.7.0, so this can probably be removed,
    //       but leave around for now just to catch issues if an older compiler is used.
    /// <summary>
    /// Warns about default literal expressions triggering https://github.com/dotnet/roslyn/issues/22578.
    /// </summary>
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class DefaultLiteralAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "GCP0004";
        private const string Category = "Usage";

        private static readonly LocalizableString Title = "Unintended default literal value";
        private static readonly LocalizableString MessageFormat = "The default literal expression results in a zero value, not 'null' as likely intended. Use 'default({0})' instead.";
        private static readonly LocalizableString Description = "Default literal expressions for nullable types use a 0, rather than the expected null, literal value.";
        private static DiagnosticDescriptor Rule =
            new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Warning, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.EnableConcurrentExecution();
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics);
            context.RegisterSyntaxNodeAction(AnalyzeDefaultLiteral, SyntaxKind.DefaultLiteralExpression);
        }

        private static void AnalyzeDefaultLiteral(SyntaxNodeAnalysisContext context)
        {
            var parameterNode = context.Node.AncestorsAndSelf().OfType<ParameterSyntax>().FirstOrDefault();
            if (parameterNode == null)
            {
                return;
            }

            var typeInfo = context.SemanticModel.GetTypeInfo(context.Node, context.CancellationToken);            
            if (typeInfo.ConvertedType.IsNullable(out var underlyingType))
            {
                if (underlyingType.IsPrimitive() ||
                    underlyingType.BaseType?.SpecialType == SpecialType.System_Enum)
                {
                    // Check to see if https://github.com/dotnet/roslyn/issues/22578 has been fixed so we don't warn unnecessarily on parameters.
                    var parameter = context.SemanticModel.GetDeclaredSymbol(parameterNode, context.CancellationToken);
                    if (parameter.HasExplicitDefaultValue && parameter.ExplicitDefaultValue == null)
                    {
                        return;
                    }

                    context.ReportDiagnostic(
                        Diagnostic.Create(
                            Rule,
                            context.Node.GetLocation(),
                            typeInfo.ConvertedType.ToDisplayString()));
                }
            }
        }
    }
}
