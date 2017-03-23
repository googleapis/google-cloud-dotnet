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
using Google.Protobuf;
using Google.Protobuf.Collections;
using static Google.Cloud.Datastore.V1.PropertyOrder.Types;

namespace Google.Cloud.Datastore.V1
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
        /// Adds an entry to the list of property references.
        /// This enables repeated property reference fields (such as <see cref="Query.DistinctOn"/> 
        /// to be specified in a query with a collection initializer
        /// in C# 6 and later.
        /// </summary>
        /// <param name="propertyReferences">The collection of property references to add to. Must not be null.</param>
        /// <param name="propertyName">The property to project. Must not be null.</param>
        public static void Add(this RepeatedField<PropertyReference> propertyReferences, string propertyName)
        {
            GaxPreconditions.CheckNotNull(propertyReferences, nameof(propertyReferences));
            propertyReferences.Add(new PropertyReference(propertyName));
        }

        /// <summary>
        /// Adds an ordering by property name and direction.
        /// </summary>
        /// <param name="orderings">The ordering field to add the ordering to. Must not be null.</param>
        /// <param name="propertyName">The name of the property to order by. Must not be null.</param>
        /// <param name="direction">The direction to order by. Must be <c>Ascending</c> or <c>Descending</c>.</param>
        public static void Add(this RepeatedField<PropertyOrder> orderings, string propertyName, Direction direction)
        {
            GaxPreconditions.CheckNotNull(orderings, nameof(orderings));
            GaxPreconditions.CheckArgument(direction == Direction.Ascending || direction == Direction.Descending,
                nameof(direction), "Direction must be Ascending or Descending");
            orderings.Add(new PropertyOrder { Direction = direction, Property = new PropertyReference(propertyName) });
        }

        /// <summary>
        /// Adds an ascending ordering by property name. The ordering is implicitly ascending.
        /// </summary>
        /// <param name="orderings">The ordering field to add the ordering to. Must not be null.</param>
        /// <param name="propertyName">The name of the property to order by. Must not be null.</param>
        public static void Add(this RepeatedField<PropertyOrder> orderings, string propertyName)
        {
            GaxPreconditions.CheckNotNull(orderings, nameof(orderings));
            orderings.Add(new PropertyOrder { Direction = Direction.Ascending, Property = new PropertyReference(propertyName) });
        }

        /// <summary>
        /// Adds a GQL parameter with the specified value.
        /// </summary>
        /// <param name="parameters">The mapping of GQL query parameters to add to. Must not be null.</param>
        /// <param name="parameterName">The name of the parameter. Must not be null.</param>
        /// <param name="value">The value to add.  May be null, which indicates
        /// a value with <see cref="Value.NullValue"/> set.</param>
        public static void Add(this MapField<string, GqlQueryParameter> parameters, string parameterName, Value value)
        {
            GaxPreconditions.CheckNotNull(parameters, nameof(parameters));
            GaxPreconditions.CheckNotNull(parameterName, nameof(parameterName));
            GaxPreconditions.CheckNotNull(value, nameof(value));
            parameters.Add(parameterName, new GqlQueryParameter { Value = value ?? Value.ForNull() });
        }

        /// <summary>
        /// Adds a GQL parameter with the specified value.
        /// </summary>
        /// <param name="parameters">The list of positional GQL query parameters to add to. Must not be null.</param>
        /// <param name="value">The value to add.  May be null, which indicates
        /// a value with <see cref="Value.NullValue"/> set.</param>
        public static void Add(this RepeatedField<GqlQueryParameter> parameters, Value value)
        {
            GaxPreconditions.CheckNotNull(parameters, nameof(parameters));
            GaxPreconditions.CheckNotNull(value, nameof(value));
            parameters.Add(new GqlQueryParameter { Value = value ?? Value.ForNull() });
        }
    }
}
