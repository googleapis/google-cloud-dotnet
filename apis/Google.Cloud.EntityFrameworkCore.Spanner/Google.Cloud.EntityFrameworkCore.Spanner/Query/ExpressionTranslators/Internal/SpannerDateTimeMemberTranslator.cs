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
using System.Reflection;
using Microsoft.EntityFrameworkCore.Query.Expressions;

namespace Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal
{
    internal class SpannerDateTimeMemberTranslator : IMemberTranslator
    {
        static readonly PropertyInfo s_utcNow = typeof(DateTime).GetProperty(nameof(DateTime.UtcNow));

        public virtual Expression Translate(MemberExpression e)
        {
            if (e.Expression == null)
                return TranslateStatic(e);

            var type = e.Expression?.Type;
            if (type != typeof(DateTime))
            {
                return null;
            }

            switch (e.Member.Name)
            {
                case nameof(DateTime.Year):
                    return GetDatePartExpression(e, "YEAR");
                case nameof(DateTime.Month):
                    return GetDatePartExpression(e, "MONTH");
                case nameof(DateTime.DayOfYear):
                    return GetDatePartExpression(e, "DAYOFYEAR");
                case nameof(DateTime.Day):
                    return GetDatePartExpression(e, "DAY");
                case nameof(DateTime.Hour):
                    return GetDatePartExpression(e, "HOUR");
                case nameof(DateTime.Minute):
                    return GetDatePartExpression(e, "MINUTE");
                case nameof(DateTime.Second):
                    return GetDatePartExpression(e, "SECOND");
                case nameof(DateTime.Millisecond):
                    return GetDatePartExpression(e, "MILLISECOND");
                case nameof(DateTime.DayOfWeek):
                    return GetDatePartExpression(e, "DAYOFWEEK");
                case nameof(DateTime.Date):
                    return GetDatePartExpression(e, "DATE", typeof(DateTime));
                default:
                    return null;
            }
        }

        static Expression GetDatePartExpression(MemberExpression e, string partName, Type type = null)
            =>
                new SqlFunctionExpression(
                    functionName: "EXTRACT",
                    returnType: type ?? typeof(int),
                    arguments: new[]
                    {
                        new SqlFragmentExpression(partName),
                        e.Expression
                    });

        Expression TranslateStatic(MemberExpression e)
        {
            if (e.Member.Equals(s_utcNow))
                return new SqlFunctionExpression("CURRENT_TIMESTAMP", e.Type);
            return null;
        }
    }
}
