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
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query.Expressions;

namespace Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal
{
    internal class SpannerObjectToStringTranslator : IMethodCallTranslator
    {
        private static readonly Dictionary<Type, string> s_typeMapping
            = new Dictionary<Type, string>
            {
                {typeof(int), "STRING"},
                {typeof(long), "STRING"},
                {typeof(DateTime), "STRING"},
                {typeof(bool), "STRING"},
                {typeof(byte), "STRING"},
                {typeof(byte[]), "STRING"},
                {typeof(double), "STRING"},
                {typeof(DateTimeOffset), "STRING"},
                {typeof(char), "STRING"},
                {typeof(short), "STRING"},
                {typeof(float), "STRING"},
                {typeof(decimal), "STRING"},
                {typeof(TimeSpan), "STRING"},
                {typeof(uint), "STRING"},
                {typeof(ushort), "STRING"},
                {typeof(ulong), "STRING"},
                {typeof(sbyte), "STRING"}
            };

        /// <summary>
        /// This API supports the Entity Framework Core infrastructure and is not intended to be used
        /// directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public virtual Expression Translate(MethodCallExpression methodCallExpression)
        {
            if (methodCallExpression.Method.Name == nameof(ToString)
                && methodCallExpression.Arguments.Count == 0
                && methodCallExpression.Object != null
                && s_typeMapping.TryGetValue(
                    methodCallExpression.Object.Type
                        .UnwrapNullableType()
                        .UnwrapEnumType(),
                    out var storeType))
            {
                return new SqlFunctionExpression(
                    "CAST",
                    methodCallExpression.Type,
                    new[]
                    {
                        methodCallExpression.Object,
                        new SqlFragmentExpression(storeType)
                    });
            }

            return null;
        }
    }
}