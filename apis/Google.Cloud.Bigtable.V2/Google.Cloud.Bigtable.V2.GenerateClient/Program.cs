// Copyright 2018 Google LLC
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

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using static Google.Cloud.Bigtable.V2.GenerateClient.RoslynHelpers;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Cloud.Bigtable.V2.GenerateClient
{
    class Program
    {
        private const string AppProfileIdFieldName = "_appProfileId";
        private const string AppProfileIdPropertyName = "AppProfileId";
        private const string GetClientMethodName = "GetClient";

        // TODO: Figure out how to replace the comments on BigtableClient.ReadRows describing cell chunks. Perhaps make this a
        //       dictionary that maps the custom stream name to the summary comment that should be replaced on the associated
        //       method. We can just make a custom summary then.
        private static readonly HashSet<string> s_customStreams = new HashSet<string> { "ReadRowsStream" };

        private static async Task<int> Main(string[] args)
        {
            // TODO: Figure out why `dotnet run` from generateapis.sh is sending 6 args instead of 3 as in: arg1 arg2 arg3 arg1 arg2 arg3
            if (args.Length < 3)
            {
                Console.WriteLine("Arguments: <project file> <api client name> <user client name>");
                return 1;
            }

            var projectFile = args[0];
            var apiClientName = args[1];
            var userClientName = args[2];

            var workspace = MSBuildWorkspace.Create(new Dictionary<string, string> { ["TargetFramework"] = "net45" });

            Project project;
            try
            {
                project = await workspace.OpenProjectAsync(projectFile);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Could not find project file {projectFile}");
                return 2;
            }

            var compilation = await project.GetCompilationAsync();
            var symbols = compilation.GetSymbolsWithName(name => name == apiClientName, SymbolFilter.Type).ToList();
            if (symbols.Count != 1)
            {
                Console.WriteLine($"Could not find type {apiClientName}");
                return 2;
            }

            var apiClientSymbol = (INamedTypeSymbol)symbols[0];

            // Find the API client from a generated file (there should be only one).
            var generatedApiClientSyntax = apiClientSymbol.DeclaringSyntaxReferences
                .Select(syntaxReference => syntaxReference.GetSyntax())
                .Cast<ClassDeclarationSyntax>()
                .SingleOrDefault(
                    syntax => syntax.SyntaxTree.GetRoot().GetLeadingTrivia().ToFullString().Contains("// Generated code. DO NOT EDIT!"));

            if (generatedApiClientSyntax == null)
            {
                Console.WriteLine($"Could not find an auto-generated file containing the {apiClientName} definition");
                return 3;
            }

            var syntaxTree = generatedApiClientSyntax.SyntaxTree;
            var semanticModel = compilation.GetSemanticModel(syntaxTree);
            var generator = SyntaxGenerator.GetGenerator(project.GetDocument(syntaxTree));
            var requestMethodRewriter = new RequestMethodRewriter(semanticModel);
            var requestMethodToImplRewriter = new RequestMethodToImplRewriter();

            var userClientSyntax =
                (ClassDeclarationSyntax)generator.ClassDeclaration(
                    userClientName,
                    accessibility: Accessibility.Public,
                    modifiers: DeclarationModifiers.Partial)
                    .WithLeadingTrivia(generatedApiClientSyntax.GetLeadingTrivia());
            var userClientImplSyntax =
                (ClassDeclarationSyntax)generator.ClassDeclaration(
                    userClientName + "Impl",
                    accessibility: Accessibility.Public,
                    modifiers: DeclarationModifiers.Sealed | DeclarationModifiers.Partial,
                    baseType: ParseTypeName(userClientName))
                    .WithLeadingTrivia(generatedApiClientSyntax.GetLeadingTrivia());

            // Copy the request methods from the API client with the user client. We only require these to be copied since
            // we already have handwritten flattening overloads to change ByteString to BigtableByteString.
            foreach (var methodSyntax in generatedApiClientSyntax.Members.OfType<MethodDeclarationSyntax>())
            {
                var method = semanticModel.GetDeclaredSymbol(methodSyntax);
                if (method.DeclaredAccessibility != Accessibility.Public ||
                    method.Parameters.IsEmpty)
                {
                    continue;
                }

                if (method.Parameters[0].Type.Name.EndsWith("Request"))
                {
                    var rewrittenMethod = (MethodDeclarationSyntax)requestMethodRewriter.Visit(methodSyntax);
                    userClientSyntax = userClientSyntax.AddMembers(rewrittenMethod);

                    rewrittenMethod = (MethodDeclarationSyntax)requestMethodToImplRewriter.Visit(rewrittenMethod);
                    userClientImplSyntax = userClientImplSyntax.AddMembers(rewrittenMethod);
                }
            }

            // Create a CompilationUnitSyntax from the Usings node of the original file, which will also contain the
            // copyright notice and generated code warnings in its leading trivia.
            var compilationUnit =
                CompilationUnit().WithUsings(syntaxTree.GetCompilationUnitRoot().Usings);

            // Add in the namespace with the ...Client and ...ClientImpl classes.
            compilationUnit = compilationUnit.AddMembers(
                (NamespaceDeclarationSyntax)generator.NamespaceDeclaration(
                    apiClientSymbol.ContainingNamespace.ToDisplayString(),
                    userClientSyntax,
                    userClientImplSyntax));

            // Use idiomatic formatting for the project.
            compilationUnit =
                (CompilationUnitSyntax)Formatter.Format(
                    compilationUnit,
                    workspace,
                    workspace.Options.WithChangedOption(FormattingOptions.NewLine, LanguageNames.CSharp, "\n"));

            var resultText = compilationUnit.ToFullString();

            try
            {
                var resultPath = Path.Combine(Path.GetDirectoryName(projectFile), $"{userClientName}.cs");
                File.WriteAllText(resultPath, resultText);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Could not write the auto-generated {userClientName}:\n{e}");
                return 4;
            }
            return 0;
        }

        /// <summary>
        /// Rewriter which takes a first pass at the API client's request methods to clean them up
        /// to be added to the user client.
        /// </summary>
        private class RequestMethodRewriter : CSharpSyntaxRewriter
        {
            private readonly SemanticModel _semanticModel;
            private ParameterSyntax _requestParameterSyntax;

            public RequestMethodRewriter(SemanticModel semanticModel) :
                base(visitIntoStructuredTrivia: true)
            {
                _semanticModel = semanticModel;
            }

            public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                try
                {
                    _requestParameterSyntax = node.ParameterList.Parameters[0];

                    var method = _semanticModel.GetDeclaredSymbol(node);
                    node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node);

                    // If the method's return type is defined in the underlying client's class, qualify the return type.
                    // However, if we've added a custom stream type in the main namespace and the name matches, skip the
                    // qualification: we want it to point to the custom type.
                    if (method.ReturnType.ContainingType == method.ContainingType &&
                        !s_customStreams.Contains(method.ReturnType.Name))
                    {
                        node = node.WithReturnType(
                            QualifiedName(
                                IdentifierName(method.ContainingType.Name),
                                IdentifierName(method.ReturnType.Name)));
                    }

                    return node;
                }
                finally
                {
                    _requestParameterSyntax = null;
                }
            }

            public override SyntaxNode VisitXmlElement(XmlElementSyntax node)
            {
                node = (XmlElementSyntax)base.VisitXmlElement(node);

                // Append request param tags with a note about how the AppProfileId will be added to the request object
                // if unspecified.
                if (node.StartTag.Name.LocalName.ToString() == "param" &&
                    node.StartTag.Attributes.FirstOrDefault() is XmlNameAttributeSyntax paramNameSyntax &&
                    paramNameSyntax.Identifier.ToString() == _requestParameterSyntax.Identifier.ToString())
                {
                    var content = node.Content;
                    var endingText = (XmlTextSyntax)content.Last();
                    content = content
                        .Replace(
                            endingText,
                            endingText.AddTextTokens(XmlTextLiteral("If the ")))
                        .Add(
                            SeeTag(_requestParameterSyntax.Type.CrefMember(AppProfileIdPropertyName)))
                        .Add(XmlText(
                            XmlTextLiteral(" has not been specified, it will be initialized from the value stored in the client."),
                            XmlTextNewLine("\n", continueXmlDocumentationComment: false),
                            endingText.TextTokens.Last()));
                    node = node.WithContent(content);
                }

                return node;
            }
        }

        /// <summary>
        /// Rewriter which takes a second pass at the cleaned up, user client method, to modify it
        /// slightly for the user ...ClientImpl class.
        /// </summary>
        private class RequestMethodToImplRewriter : CSharpSyntaxRewriter
        {
            public RequestMethodToImplRewriter() : base(visitIntoStructuredTrivia: true) { }

            public override SyntaxNode VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax node)
            {
                // Replace the doc comments with <inheritdoc/>
                return node.WithContent(List(
                    new XmlNodeSyntax[] {
                        XmlText(" ").WithLeadingTrivia(node.GetLeadingTrivia()),
                        XmlEmptyElement("inheritdoc"),
                        XmlText(XmlTextNewLine("\n", continueXmlDocumentationComment: false))
                    }));
            }

            public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                var parameters = node.ParameterList.Parameters;
                node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node);

                // Replace the body with something like this:
                //------------------------------------------------------------------------
                //  if (request.AppProfileId == null)
                //  {
                //      request.AppProfileId = _appProfileId;
                //  }
                //
                //  return GetClient().MethodName(request, callSettings);
                //------------------------------------------------------------------------
                var appProfileIdProperty = parameters[0].Identifier.Member(AppProfileIdPropertyName);
                var underlyingMethod = IdentifierName(GetClientMethodName).Invoke().Member(node.Identifier);
                var resultExpresion =
                    (ExpressionSyntax)underlyingMethod.Invoke(
                        parameters.Select(parameter => Argument(parameter.Identifier)));
                if (s_customStreams.Contains(node.ReturnType.ToString()))
                {
                    // If we have a custom stream for this method, wrap the underlying result stream
                    // in a constructor call for the custom stream.
                    resultExpresion = node.ReturnType.New(resultExpresion);
                }
                node = node.WithBody(Block(
                    If(appProfileIdProperty.EqualTo(Null()),
                        appProfileIdProperty.AssignFrom(AppProfileIdFieldName).ToStatement()),
                    ReturnStatement(resultExpresion)));

                return node;
            }

            public override SyntaxToken VisitToken(SyntaxToken token)
            {
                // Change the 'virtual' modifier to 'override'.
                if (token.IsKind(SyntaxKind.VirtualKeyword))
                {
                    return Token(SyntaxKind.OverrideKeyword);
                }
                return base.VisitToken(token);
            }
        }
    }
}
