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
using System.Reflection;
using Google.Api.Gax;
using Microsoft.EntityFrameworkCore.Query.Expressions;

namespace Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal
{
    internal class SpannerLikeTranslator : IMethodCallTranslator
    {
        private static readonly MethodInfo s_like
            = typeof(DbFunctionsExtensions).GetRuntimeMethod(
                nameof(DbFunctionsExtensions.Like),
                new[] {typeof(DbFunctions), typeof(string), typeof(string)});

        private static readonly MethodInfo s_likeWithEscape
            = typeof(DbFunctionsExtensions).GetRuntimeMethod(
                nameof(DbFunctionsExtensions.Like),
                new[] {typeof(DbFunctions), typeof(string), typeof(string), typeof(string)});


        public virtual Expression Translate(MethodCallExpression methodCallExpression)
        {
            GaxPreconditions.CheckNotNull(methodCallExpression, nameof(methodCallExpression));

            if (Equals(methodCallExpression.Method, s_likeWithEscape))
            {
                return new LikeExpression(methodCallExpression.Arguments[1], methodCallExpression.Arguments[2],
                    methodCallExpression.Arguments[3]);
            }

            return Equals(methodCallExpression.Method, s_like) ? 
                new LikeExpression(methodCallExpression.Arguments[1], methodCallExpression.Arguments[2]) 
                : null;
        }
    }
}