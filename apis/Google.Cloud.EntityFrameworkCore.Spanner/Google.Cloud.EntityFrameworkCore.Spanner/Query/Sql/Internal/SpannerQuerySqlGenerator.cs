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

using System.Linq.Expressions;
using Google.Api.Gax;
using Microsoft.EntityFrameworkCore.Query.Expressions;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;

namespace Microsoft.EntityFrameworkCore.Query.Sql.Internal
{
    /// <summary>
    /// This is internal functionality and not intended for public use.
    /// </summary>
    public class SpannerQuerySqlGenerator : DefaultQuerySqlGenerator
    {
        //Note: This class is the main class that can be used to diagnose the generated
        // SQL for spanner queries.  Override the VisitX and GenerateX to see how the SQL is
        // being constructed base on the Sql Linq Expression tree.
        // To debug how the expression tree is being constructed/modified, you should look at
        // expression translators (methodcall and member translators).

        /// <summary>
        /// This is internal functionality and not intended for public use.
        /// </summary>
        public SpannerQuerySqlGenerator(
            QuerySqlGeneratorDependencies dependencies,
            SelectExpression selectExpression)
            : base(dependencies, selectExpression)
        {
        }

        /// <summary>
        /// The default true literal SQL.
        /// </summary>
        protected override string TypedTrueLiteral => "TRUE";

        /// <summary>
        /// The default false literal SQL.
        /// </summary>
        protected override string TypedFalseLiteral => "FALSE";

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

                    Sql.Append(" FROM CAST(");

                    Visit(sqlFunctionExpression.Arguments[1]);

                    Sql.Append(" AS TIMESTAMP) AT TIME ZONE '+0')");

                    return sqlFunctionExpression;
                }
                case "LN":
                case "LOG":
                case "LOG10":
                    //Since spanner does not attempt any short circuit eval,
                    //we make these methods return NaN instead of throw
                    //Otherwise, where clauses such as WHERE x > 0 AND LN(x) < [foo]
                    //will throws because the protection of "x > 0" does not stop LN(0)
                    //from being evaluated.
                    Sql.Append("IF(");
                    Visit(sqlFunctionExpression.Arguments[0]);
                    Sql.Append("<=0, CAST('NaN' AS FLOAT64), ");

                    base.VisitSqlFunction(sqlFunctionExpression);

                    Sql.Append(")");
                    return sqlFunctionExpression;
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
            }

            return base.VisitBinary(binaryExpression);
        }
    }
}