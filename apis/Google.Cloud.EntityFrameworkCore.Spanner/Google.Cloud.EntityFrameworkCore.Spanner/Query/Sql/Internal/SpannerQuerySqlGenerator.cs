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
using Microsoft.EntityFrameworkCore.Storage;

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

            if (selectExpression.Offset != null)
            {
                if (selectExpression.Limit == null)
                {
                    Sql.AppendLine();
                }
                else
                {
                    Sql.Append(' ');
                }
                Sql.Append("OFFSET ");
                Visit(selectExpression.Offset);
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
                    Sql.Append("BIT_AND(");
                    Visit(binaryExpression.Left);
                    Sql.Append(", ");
                    Visit(binaryExpression.Right);
                    Sql.Append(")");

                    return binaryExpression;
                }
                case ExpressionType.Or:
                {
                    Sql.Append("BIT_OR(");
                    Visit(binaryExpression.Left);
                    Sql.Append(", ");
                    Visit(binaryExpression.Right);
                    Sql.Append(")");

                    return binaryExpression;
                    }
                case ExpressionType.Modulo:
                {
                    Sql.Append("MOD(");
                    Visit(binaryExpression.Left);
                    Sql.Append(", ");
                    Visit(binaryExpression.Right);
                    Sql.Append(")");

                    return binaryExpression;
                }
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