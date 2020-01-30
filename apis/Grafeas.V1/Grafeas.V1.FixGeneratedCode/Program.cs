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
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.IO;
using System.Linq;

namespace Grafeas.V1.FixGeneratedCode
{
    /// <summary>
    /// Applies fixes to the Grafeas API, as it's unlike most of our APIs.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var layout = DirectoryLayout.ForApi("Grafeas.V1");

            SourceFile.Load(Path.Combine(layout.SourceDirectory, "Grafeas.V1", "GrafeasClient.g.cs"))
                .RemoveProperty("GrafeasClient", "DefaultEndpoint")
                .RemoveProperty("GrafeasClient", "ChannelPool")
                .RemoveMethod("GrafeasClient", "CreateAsync", "CancellationToken")
                .RemoveMethod("GrafeasClient", "Create")
                .RemoveMethod("GrafeasClient", "ShutdownDefaultChannelsAsync")
                .RemoveMethod("GrafeasClientBuilder", "GetDefaultEndpoint")
                .RemoveMethod("GrafeasClientBuilder", "GetChannelPool")
                .Save();

            SourceFile.Load(Path.Combine(layout.SourceDirectory, "Grafeas.V1.Snippets", "GrafeasClientSnippets.g.cs"))
                .Rewrite(new SnippetRewriter())
                .Save();
        }

        /// <summary>
        /// The snippets expect to be able to call GrafeasClient.Create or CreateAsync with no arguments.
        /// Instead, we introduce a local channel variable before the snippet starts, and use that to create the client.
        /// We only initialize the channel with a null reference, but this code is never executed anyway; it just needs to compile.
        /// </summary>
        private class SnippetRewriter : CSharpSyntaxRewriter
        {
            private readonly StatementSyntax _channelDeclaration;
            private readonly StatementSyntax _clientCreation;

            public SnippetRewriter() : base(false)
            {
                _channelDeclaration = SyntaxFactory.ParseStatement("string endpoint = \"\";")
                    // TODO: Potentially format the node automatically instead of hard-coding whitespace.
                    .WithLeadingTrivia(SyntaxFactory.Whitespace("            "))
                    // By using the native linebreak format, we avoid generating whitespace-only git changes.
                    .WithTrailingTrivia(SyntaxFactory.Whitespace(Environment.NewLine));
                _clientCreation = SyntaxFactory.ParseStatement("GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();");
            }

            public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                var body = node.Body;
                if (body == null)
                {
                    return node;
                }
                
                var oldClientDeclaration = body.Statements.FirstOrDefault(
                    st => st is LocalDeclarationStatementSyntax ldss && ldss.Declaration.Variables.Any(v => v.Identifier.Text == "grafeasClient"));
                if (oldClientDeclaration == null)
                {
                    return node;
                }
                var statements = body.Statements
                    .Replace(oldClientDeclaration, _clientCreation.WithTriviaFrom(oldClientDeclaration))
                    .Prepend(_channelDeclaration);
                return node.WithBody(body.WithStatements(new SyntaxList<StatementSyntax>(statements)));
            }
        }
    }
}
