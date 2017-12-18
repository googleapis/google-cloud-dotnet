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

using System;
using System.Linq.Expressions;
using Google.Api.Gax;
using Microsoft.EntityFrameworkCore.Query.Expressions;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Remotion.Linq.Clauses.Expressions;

namespace Microsoft.EntityFrameworkCore.Query.Sql.Internal
{
    /// <summary>
    /// </summary>
    public class SpannerQuerySqlGenerator : DefaultQuerySqlGenerator
    {
        /// <summary>
        /// </summary>
        /// <param name="dependencies"></param>
        /// <param name="selectExpression"></param>
        public SpannerQuerySqlGenerator(
            QuerySqlGeneratorDependencies dependencies,
            SelectExpression selectExpression)
            : base(dependencies, selectExpression)
        {
        }

        /// <inheritdoc />
        protected override string GenerateOperator(Expression expression)
            => expression.NodeType == ExpressionType.Add
               && expression.Type == typeof(string)
                ? " || "
                : base.GenerateOperator(expression);

        /// <inheritdoc />
        public override Expression VisitAlias(AliasExpression aliasExpression)
        {
            var validatedAlias = SpannerQueryCompilationContext.GetValidSymbol(aliasExpression.Alias);
            return base.VisitAlias(validatedAlias != aliasExpression.Alias 
                ? new AliasExpression(validatedAlias, aliasExpression.Expression)
                : aliasExpression);
        }

        /// <inheritdoc />
        public override Expression VisitSqlFunction(SqlFunctionExpression sqlFunctionExpression)
        {
            switch (sqlFunctionExpression.FunctionName)
            {
                case "CAST":
                {
                    Sql.Append(sqlFunctionExpression.FunctionName);
                    Sql.Append("(");

                    Visit(sqlFunctionExpression.Arguments[0]);

                    Sql.Append(" AS ");

                    Visit(sqlFunctionExpression.Arguments[1]);

                    Sql.Append(")");

                    return sqlFunctionExpression;
                }
                case "EXTRACT":
                {
                    Sql.Append(sqlFunctionExpression.FunctionName);
                    Sql.Append("(");

                    Visit(sqlFunctionExpression.Arguments[0]);

                    Sql.Append(" FROM ");

                    Visit(sqlFunctionExpression.Arguments[1]);

                    Sql.Append(")");

                    return sqlFunctionExpression;
                }
            }

            return base.VisitSqlFunction(sqlFunctionExpression);
        }

        /// <inheritdoc />
        protected override void GenerateTop(SelectExpression selectExpression)
        {
        }

        /// <inheritdoc />
        protected override void GenerateLimitOffset(SelectExpression selectExpression)
        {
            GaxPreconditions.CheckNotNull(selectExpression, nameof(selectExpression));

            if (selectExpression.Limit != null)
            {
                Sql.AppendLine().Append("LIMIT ");
                Visit(selectExpression.Limit);
            }
            else if (selectExpression.Offset != null)
            {
                // Cloud Spanner requires limit if offset is specified.
                Sql.AppendLine().Append($"LIMIT {int.MaxValue}");
            }

            if (selectExpression.Offset == null)
            {
                return;
            }
            Sql.Append(" OFFSET ");
            Visit(selectExpression.Offset);
        }

        private void VisitNumericOperand(Expression expression)
        {
            if (expression.Type == typeof(bool))
            {
                Sql.Append("CAST(");
                Visit(expression);
                Sql.Append(" AS INT64)");
            }
            else
            {
                Visit(expression);
            }
        }

        private void VisitBoolOperand(Expression expression)
        {
            if (expression.Type != typeof(bool))
            {
                Sql.Append("CAST(");
                Visit(expression);
                Sql.Append(" AS BOOL)");
            }
            else
            {
                Visit(expression);
            }
        }

        private void BeginNumericReturnCast(BinaryExpression expression)
        {
            if (expression.Type == typeof(bool))
            {
                Sql.Append("CAST(");
            }
        }

        private void EndNumericReturnCast(BinaryExpression expression)
        {
            if (expression.Type == typeof(bool))
            {
                Sql.Append(" AS BOOL)");
            }
        }

        /// <inheritdoc />
        protected override Expression VisitBinary(BinaryExpression binaryExpression)
        {
            GaxPreconditions.CheckNotNull(binaryExpression, nameof(binaryExpression));

            switch (binaryExpression.NodeType)
            {
                case ExpressionType.Add:
                {
                    if (binaryExpression.Type == typeof(string))
                    {
                        Sql.Append("CONCAT(");
                        Visit(binaryExpression.Left);
                        Sql.Append(", ");
                        Visit(binaryExpression.Right);
                        Sql.Append(")");

                        return binaryExpression;
                    }
                    break;
                }
                case ExpressionType.And:
                {
                    BeginNumericReturnCast(binaryExpression);
                    Sql.Append("(");
                    VisitNumericOperand(binaryExpression.Left);
                    Sql.Append(" & ");
                    VisitNumericOperand(binaryExpression.Right);
                    Sql.Append(")");
                    EndNumericReturnCast(binaryExpression);

                    return binaryExpression;
                }
                case ExpressionType.Or:
                {
                    BeginNumericReturnCast(binaryExpression);
                    Sql.Append("(");
                    VisitNumericOperand(binaryExpression.Left);
                    Sql.Append(" | ");
                    VisitNumericOperand(binaryExpression.Right);
                    Sql.Append(")");
                    EndNumericReturnCast(binaryExpression);

                    return binaryExpression;
                }
                case ExpressionType.ExclusiveOr:
                {
                    BeginNumericReturnCast(binaryExpression);
                    Sql.Append("(");
                    VisitNumericOperand(binaryExpression.Left);
                    Sql.Append(" ^ ");
                    VisitNumericOperand(binaryExpression.Right);
                    Sql.Append(")");
                    EndNumericReturnCast(binaryExpression);

                    return binaryExpression;
                }
                case ExpressionType.LeftShift:
                {
                    BeginNumericReturnCast(binaryExpression);
                    Sql.Append("(");
                    VisitNumericOperand(binaryExpression.Left);
                    Sql.Append(" << ");
                    VisitNumericOperand(binaryExpression.Right);
                    Sql.Append(")");
                    EndNumericReturnCast(binaryExpression);

                    return binaryExpression;
                }
                case ExpressionType.RightShift:
                {
                    BeginNumericReturnCast(binaryExpression);
                    Sql.Append("(");
                    VisitNumericOperand(binaryExpression.Left);
                    Sql.Append(" >> ");
                    VisitNumericOperand(binaryExpression.Right);
                    Sql.Append(")");
                    EndNumericReturnCast(binaryExpression);

                    return binaryExpression;
                }
                case ExpressionType.Modulo:
                {
                    BeginNumericReturnCast(binaryExpression);
                    Sql.Append("MOD(");
                    VisitNumericOperand(binaryExpression.Left);
                    Sql.Append(", ");
                    VisitNumericOperand(binaryExpression.Right);
                    Sql.Append(")");
                    EndNumericReturnCast(binaryExpression);

                    return binaryExpression;
                }
//                case ExpressionType.Equal:
//                case ExpressionType.NotEqual:
//                {
//                    //if one side is bool, we force both to bool due
//                    //to expectations that "1" is true.
//                    if (binaryExpression.Left.Type != typeof(bool)
//                        && binaryExpression.Right.Type != typeof(bool))
//                    {
//                        return base.VisitBinary(binaryExpression);
//                    }
//                    // one or both sides are bool, so we may be forced
//                    // to CAST.
//                    VisitBoolOperand(binaryExpression.Left);
//                    Sql.Append(" = ");
//                    VisitBoolOperand(binaryExpression.Right);
//                    return binaryExpression;
//                }
            }

            return base.VisitBinary(binaryExpression);
        }
        /// <summary>
        ///     The default true literal SQL.
        /// </summary>
        protected override string TypedTrueLiteral => "TRUE";

        /// <summary>
        ///     The default false literal SQL.
        /// </summary>
        protected override string TypedFalseLiteral => "FALSE";
    }
}