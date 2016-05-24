// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;
using Google.Protobuf.Collections;

namespace Google.Datastore.V1Beta3
{
    /// <summary>
    /// Extension methods around queries.
    /// </summary>
    public static class QueryExtensions
    {
        // TODO: Alternative would be to have an implicit conversion from string to Projection
        /// <summary>
        /// Adds a projection with the given property name to the repeated field.
        /// This enables projections to be specified in a query with a collection initializer
        /// in C# 6 and later.
        /// </summary>
        /// <param name="projections">The collection of projections to add to. Must not be null.</param>
        /// <param name="propertyName">The property to project. Must not be null.</param>
        public static void Add(this RepeatedField<Projection> projections, string propertyName)
        {
            GaxPreconditions.CheckNotNull(projections, nameof(projections));
            projections.Add(new Projection(propertyName));
        }

        /// <summary>
        /// Adds a projection with the given property name to the repeated field.
        /// This enables projections to be specified in a query with a collection initializer
        /// in C# 6 and later.
        /// </summary>
        /// <param name="kindExpressions">The collection of kind expressions to add to. Must not be null.</param>
        /// <param name="name">The name of the kind to add. Must not be null.</param>
        public static void Add(this RepeatedField<KindExpression> kindExpressions, string name)
        {
            GaxPreconditions.CheckNotNull(kindExpressions, nameof(kindExpressions));
            kindExpressions.Add(new KindExpression(name));
        }
    }
}
