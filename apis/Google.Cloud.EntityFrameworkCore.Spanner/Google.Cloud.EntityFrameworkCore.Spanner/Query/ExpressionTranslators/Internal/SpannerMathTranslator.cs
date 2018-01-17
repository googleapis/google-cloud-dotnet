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
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Google.Api.Gax;
using Microsoft.EntityFrameworkCore.Query.Expressions;

namespace Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal
{
    internal class SpannerMathTranslator : IMethodCallTranslator
    {
        private static readonly Dictionary<MethodInfo, string> s_supportedMethodTranslations =
            new Dictionary<MethodInfo, string>
            {
                {typeof(Math).GetRuntimeMethod(nameof(Math.Abs), new[] {typeof(decimal)}), "ABS"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Abs), new[] {typeof(double)}), "ABS"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Abs), new[] {typeof(float)}), "ABS"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Abs), new[] {typeof(int)}), "ABS"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Abs), new[] {typeof(long)}), "ABS"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Abs), new[] {typeof(sbyte)}), "ABS"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Abs), new[] {typeof(short)}), "ABS"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Ceiling), new[] {typeof(decimal)}), "CEILING"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Ceiling), new[] {typeof(double)}), "CEILING"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Floor), new[] {typeof(decimal)}), "FLOOR"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Floor), new[] {typeof(double)}), "FLOOR"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Pow), new[] {typeof(double), typeof(double)}), "POWER"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Exp), new[] {typeof(double)}), "EXP"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Log10), new[] {typeof(double)}), "LOG10"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Log), new[] {typeof(double)}), "LN"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Log), new[] {typeof(double), typeof(double)}), "LOG"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Sqrt), new[] {typeof(double)}), "SQRT"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Acos), new[] {typeof(double)}), "ACOS"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Asin), new[] {typeof(double)}), "ASIN"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Atan), new[] {typeof(double)}), "ATAN"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Atan2), new[] {typeof(double), typeof(double)}), "ATAN2"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Cos), new[] {typeof(double)}), "COS"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Cosh), new[] {typeof(double)}), "COSH"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Sin), new[] {typeof(double)}), "SIN"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Sinh), new[] {typeof(double)}), "SINH"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Tan), new[] {typeof(double)}), "TAN"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Tanh), new[] {typeof(double)}), "TANH"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Sign), new[] {typeof(decimal)}), "SIGN"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Sign), new[] {typeof(double)}), "SIGN"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Sign), new[] {typeof(float)}), "SIGN"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Sign), new[] {typeof(int)}), "SIGN"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Sign), new[] {typeof(long)}), "SIGN"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Sign), new[] {typeof(sbyte)}), "SIGN"},
                {typeof(Math).GetRuntimeMethod(nameof(Math.Sign), new[] {typeof(short)}), "SIGN"},
                {typeof(double).GetRuntimeMethod(nameof(double.IsInfinity), new[] {typeof(double)}), "IS_INF"},
                {typeof(double).GetRuntimeMethod(nameof(double.IsNaN), new[] {typeof(double)}), "IS_NAN"}
            };

        private static readonly IEnumerable<MethodInfo> s_truncateMethodInfos = new[]
        {
            typeof(Math).GetRuntimeMethod(nameof(Math.Truncate), new[] {typeof(decimal)}),
            typeof(Math).GetRuntimeMethod(nameof(Math.Truncate), new[] {typeof(double)})
        };

        private static readonly IEnumerable<MethodInfo> s_roundMethodInfos = new[]
        {
            typeof(Math).GetRuntimeMethod(nameof(Math.Round), new[] {typeof(decimal)}),
            typeof(Math).GetRuntimeMethod(nameof(Math.Round), new[] {typeof(double)}),
            typeof(Math).GetRuntimeMethod(nameof(Math.Round), new[] {typeof(decimal), typeof(int)}),
            typeof(Math).GetRuntimeMethod(nameof(Math.Round), new[] {typeof(double), typeof(int)})
        };

        public virtual Expression Translate(MethodCallExpression methodCallExpression)
        {
            GaxPreconditions.CheckNotNull(methodCallExpression, nameof(methodCallExpression));

            var method = methodCallExpression.Method;
            if (s_supportedMethodTranslations.TryGetValue(method, out string sqlFunctionName))
            {
                return new SqlFunctionExpression(
                    sqlFunctionName,
                    methodCallExpression.Type,
                    methodCallExpression.Arguments);
            }

            if (s_truncateMethodInfos.Contains(method))
            {
                var firstArgument = methodCallExpression.Arguments[0];

                if (firstArgument.NodeType == ExpressionType.Convert)
                {
                    firstArgument = new ExplicitCastExpression(firstArgument, firstArgument.Type);
                }

                return new SqlFunctionExpression(
                    "TRUNC",
                    methodCallExpression.Type,
                    new[] {firstArgument});
            }

            if (s_roundMethodInfos.Contains(method))
            {
                var firstArgument = methodCallExpression.Arguments[0];

                if (firstArgument.NodeType == ExpressionType.Convert)
                {
                    firstArgument = new ExplicitCastExpression(firstArgument, firstArgument.Type);
                }

                return new SqlFunctionExpression(
                    "ROUND",
                    methodCallExpression.Type,
                    methodCallExpression.Arguments.Count == 1
                        ? new[] {firstArgument}
                        : new[] {firstArgument, methodCallExpression.Arguments[1]});
            }

            return null;
        }
    }
}