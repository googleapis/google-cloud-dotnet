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
using System;
using System.Collections.Generic;
using System.Linq;

using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Cloud.Bigtable.V2.GenerateClient
{
    /// <summary>
    /// Internal helpers and extension methods which allow for a fluent style of code generation.
    /// </summary>
    internal static class RoslynHelpers
    {
        internal static IEnumerable<ArgumentSyntax> AddArgument(this IEnumerable<ArgumentSyntax> arguments, ExpressionSyntax additionalArgument) =>
            arguments.Concat(Enumerable.Repeat(SyntaxFactory.Argument(additionalArgument), 1));

        internal static BinaryExpressionSyntax And(this ExpressionSyntax left, ExpressionSyntax right) =>
            BinaryExpression(SyntaxKind.LogicalAndExpression, left, right);

        internal static ArgumentSyntax Argument(SyntaxToken identifier) =>
            SyntaxFactory.Argument(IdentifierName(identifier));

        internal static IEnumerable<ArgumentSyntax> AsArguments(this ParameterListSyntax parameterList) =>
            parameterList.Parameters.Select(parameter => Argument(parameter.Identifier));

        internal static AssignmentExpressionSyntax AssignFrom(this ExpressionSyntax left, string right) =>
            left.AssignFrom(IdentifierName(right));

        internal static AssignmentExpressionSyntax AssignFrom(this ExpressionSyntax left, ExpressionSyntax right) =>
            AssignmentExpression(SyntaxKind.SimpleAssignmentExpression, left, right);

        internal static QualifiedCrefSyntax CrefMember(this TypeSyntax type, string name) =>
            QualifiedCref(type.WithoutTrivia(), NameMemberCref(ParseTypeName(name)));

        internal static BinaryExpressionSyntax EqualTo(this ExpressionSyntax left, ExpressionSyntax right) =>
            BinaryExpression(SyntaxKind.EqualsExpression, left, right);

        internal static IfStatementSyntax If(ExpressionSyntax condition, params StatementSyntax[] statements) =>
            IfStatement(condition, Block(statements));

        internal static InvocationExpressionSyntax Invoke(this ExpressionSyntax expression) =>
            InvocationExpression(expression);

        internal static InvocationExpressionSyntax Invoke(this MethodDeclarationSyntax method, params ExpressionSyntax[] argumentExpressions) =>
            method.Invoke(argumentExpressions.Select(argumentExpression => SyntaxFactory.Argument(argumentExpression)));

        internal static InvocationExpressionSyntax Invoke(this MethodDeclarationSyntax method, IEnumerable<ArgumentSyntax> arguments) =>
            IdentifierName(method.Identifier).Invoke(arguments);

        internal static InvocationExpressionSyntax Invoke(this ExpressionSyntax expression, params ExpressionSyntax[] argumentExpressions) =>
            expression.Invoke(argumentExpressions.Select(argumentExpression => SyntaxFactory.Argument(argumentExpression)));

        internal static InvocationExpressionSyntax Invoke(this ExpressionSyntax expression, params ArgumentSyntax[] arguments) =>
            expression.Invoke((IEnumerable<ArgumentSyntax>)arguments);

        internal static InvocationExpressionSyntax Invoke(this ExpressionSyntax expression, IEnumerable<ArgumentSyntax> arguments) =>
            InvocationExpression(expression, ArgumentList(SeparatedList(arguments)));

        internal static ParenthesizedLambdaExpressionSyntax Lambda(ExpressionSyntax expression) =>
            ParenthesizedLambdaExpression(expression);

        internal static MemberAccessExpressionSyntax Member(this SyntaxToken identifier, string name) =>
            IdentifierName(identifier).Member(name);

        internal static MemberAccessExpressionSyntax Member(this ExpressionSyntax expression, string name) =>
            MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, expression, IdentifierName(name));

        internal static MemberAccessExpressionSyntax Member(this ExpressionSyntax expression, SyntaxToken name) =>
            MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, expression, IdentifierName(name));

        internal static ObjectCreationExpressionSyntax New(this TypeSyntax type, params ExpressionSyntax[] argumentExpressions) =>
            type.New(argumentExpressions.Select(expression => SyntaxFactory.Argument(expression)));

        internal static ObjectCreationExpressionSyntax New(this TypeSyntax type, IEnumerable<ArgumentSyntax> arguments) =>
            ObjectCreationExpression(type, ArgumentList(SeparatedList(arguments)), initializer: null);

        internal static BinaryExpressionSyntax NotEqualTo(this ExpressionSyntax left, ExpressionSyntax right) =>
            BinaryExpression(SyntaxKind.NotEqualsExpression, left, right);

        internal static LiteralExpressionSyntax Null() =>
            LiteralExpression(SyntaxKind.NullLiteralExpression);

        internal static AliasQualifiedNameSyntax Of(this AliasQualifiedNameSyntax typeName, params TypeSyntax[] typeArguments) =>
            typeName.WithName((SimpleNameSyntax)typeName.Name.Of(typeArguments));

        internal static QualifiedNameSyntax Of(this QualifiedNameSyntax typeName, params TypeSyntax[] typeArguments) =>
            typeName.WithRight((SimpleNameSyntax)typeName.Right.Of(typeArguments));

        internal static GenericNameSyntax Of(this GenericNameSyntax typeName, params TypeSyntax[] typeArguments) =>
            typeName.WithTypeArgumentList(TypeArgumentList(SeparatedList(typeArguments)));

        internal static GenericNameSyntax Of(this IdentifierNameSyntax typeName, params TypeSyntax[] typeArguments) =>
            GenericName(typeName.Identifier).Of(typeArguments);

        internal static NameSyntax Of(this NameSyntax typeName, params TypeSyntax[] typeArguments)
        {
            switch (typeName)
            {
                case AliasQualifiedNameSyntax aliasQualifiedName:
                    return aliasQualifiedName.Of(typeArguments);
                case QualifiedNameSyntax qualifiedName:
                    return qualifiedName.Of(typeArguments);
                case IdentifierNameSyntax identifierName:
                    return identifierName.Of(typeArguments);
                case GenericNameSyntax genericName:
                    return genericName.Of(typeArguments);
                default:
                    throw new ArgumentException();
            }
        }

        internal static XmlEmptyElementSyntax SeeTag(CrefSyntax cref) =>
            XmlEmptyElement("see").AddAttributes(XmlCrefAttribute(cref));

        internal static NameSyntax Task() => ParseName("stt::Task");

        internal static MethodDeclarationSyntax ToAsync(this MethodDeclarationSyntax method) =>
            method.WithReturnType(Task().Of(method.ReturnType)).WithIdentifier(Identifier(method.Identifier.ToString() + "Async"));

        internal static ExpressionStatementSyntax ToStatement(this ExpressionSyntax expression) =>
            ExpressionStatement(expression);

        internal static MethodDeclarationSyntax WithBodySafe(this MethodDeclarationSyntax method, ExpressionSyntax expressionBody) =>
            method.WithBody(null).WithExpressionBody(ArrowExpressionClause(expressionBody)).WithSemicolonToken(Token(SyntaxKind.SemicolonToken));

        internal static MethodDeclarationSyntax WithBodySafe(this MethodDeclarationSyntax method, BlockSyntax body) =>
            method.WithExpressionBody(null).WithSemicolonToken(Token(SyntaxKind.None)).WithBody(body);

        internal static LiteralExpressionSyntax Zero() =>
            LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(0));
    }
}
