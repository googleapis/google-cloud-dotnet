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
using System;
using System.Collections.Generic;
using static Google.Cloud.Datastore.V1.PropertyFilter.Types;

namespace Google.Cloud.Datastore.V1
{
    public partial class Filter
    {
        // TODO: Rename this? Given that this is the only combination available at the moment. Or we could make it
        // an instance method, so you'd have Filter.Equal(...).And(Filter.Equal(...))

        /// <summary>
        /// Creates a composite filter which is the logical "AND" of all the specified filters.
        /// </summary>
        /// <param name="filters">Set of filters to combine. Must not be null or empty, or contain null references.</param>
        /// <returns>A filter representing the logical "AND" of all the elements in <paramref name="filters"/>.</returns>
        public static Filter And(IEnumerable<Filter> filters)
        {

            Filter filter = new Filter
            {
                CompositeFilter = new CompositeFilter
                {
                    Op = CompositeFilter.Types.Operator.And,
                    Filters = { filters }
                }
            };
            GaxPreconditions.CheckArgument(filter.CompositeFilter.Filters.Count != 0,
                nameof(filters), "Filter collection must not be empty");
            return filter;
        }

        /// <summary>
        /// Creates a composite filter which is the logical "AND" of all the specified filters.
        /// </summary>
        /// <param name="filters">Set of filters to combine. Must not be null or empty, or contain null references.</param>
        /// <returns>A filter representing the logical "AND" of all the elements in <paramref name="filters"/>.</returns>
        public static Filter And(params Filter[] filters) => And((IEnumerable<Filter>) filters);
        
        /// <summary>
        /// Creates a filter to check that the specified property is equal to a given value.
        /// </summary>
        /// <param name="propertyName">The name of the property. Must not be null.</param>
        /// <param name="propertyValue">The value to compare against. May be null, which indicates
        /// a value with <see cref="Value.NullValue"/> set.</param>
        /// <returns>The newly created filter.</returns>
        public static Filter Equal(string propertyName, Value propertyValue) =>
            Property(propertyName, propertyValue, Operator.Equal);

        /// <summary>
        /// Creates a filter to check that the specified property is not equal to a given value.
        /// </summary>
        /// <param name="propertyName">The name of the property. Must not be null.</param>
        /// <param name="propertyValue">The value to compare against. May be null, which indicates
        /// a value with <see cref="Value.NullValue"/> set.</param>
        /// <returns>The newly created filter.</returns>
        public static Filter NotEqual(string propertyName, Value propertyValue) =>
            Property(propertyName, propertyValue, Operator.NotEqual);

        /// <summary>
        /// Creates a filter to check that the specified property is in a given array of values.
        /// </summary>
        /// <param name="value">The name of the property. Must not be null.</param>
        /// <param name="collection">The array of values to compare against. </param>
        /// <returns>The newly created filter.</returns>
        public static Filter In(string value, ArrayValue collection) =>
            Property(value, collection, Operator.In);

        /// <summary>
        /// Creates a filter to check that the specified property is not in a given array of values.
        /// </summary>
        /// <param name="value">The name of the property. Must not be null.</param>
        /// <param name="collection">The array of values to compare against. </param>
        /// <returns>The newly created filter.</returns>
        public static Filter NotIn(string value, ArrayValue collection) =>
            Property(value, collection, Operator.NotIn);

        /// <summary>
        /// Creates a filter to check that the specified property is less than a given value.
        /// </summary>
        /// <param name="propertyName">The name of the property. Must not be null.</param>
        /// <param name="propertyValue">The value to compare against. May be null, which indicates
        /// a value with <see cref="Value.NullValue"/> set.</param>
        /// <returns>The newly created filter.</returns>
        public static Filter LessThan(string propertyName, Value propertyValue) =>
            Property(propertyName, propertyValue, Operator.LessThan);

        /// <summary>
        /// Creates a filter to check that the specified property is greater than a given value.
        /// </summary>
        /// <param name="propertyName">The name of the property. Must not be null.</param>
        /// <param name="propertyValue">The value to compare against. May be null, which indicates
        /// a value with <see cref="Value.NullValue"/> set.</param>
        /// <returns>The newly created filter.</returns>
        public static Filter GreaterThan(string propertyName, Value propertyValue) =>
            Property(propertyName, propertyValue, Operator.GreaterThan);

        /// <summary>
        /// Creates a filter to check that the specified property is less than or equal to a given value.
        /// </summary>
        /// <param name="propertyName">The name of the property. Must not be null.</param>
        /// <param name="propertyValue">The value to compare against. May be null, which indicates
        /// a value with <see cref="Value.NullValue"/> set.</param>
        /// <returns>The newly created filter.</returns>
        public static Filter LessThanOrEqual(string propertyName, Value propertyValue) =>
            Property(propertyName, propertyValue, Operator.LessThanOrEqual);

        /// <summary>
        /// Creates a filter to check that the specified property is greater than or equal to a given value.
        /// </summary>
        /// <param name="propertyName">The name of the property. Must not be null.</param>
        /// <param name="propertyValue">The value to compare against. May be null, which indicates
        /// a value with <see cref="Value.NullValue"/> set.</param>
        /// <returns>The newly created filter.</returns>
        public static Filter GreaterThanOrEqual(string propertyName, Value propertyValue) =>
            Property(propertyName, propertyValue, Operator.GreaterThanOrEqual);

        /// <summary>
        /// Creates a filter to check that an entity has the specified key as an ancestor.
        /// </summary>
        /// <param name="ancestorKey">The key to check against. Must not be null.</param>
        /// <returns>The newly created filter.</returns>
        public static Filter HasAncestor(Key ancestorKey) =>
            Property(DatastoreConstants.KeyProperty, GaxPreconditions.CheckNotNull(ancestorKey, nameof(ancestorKey)), Operator.HasAncestor);

        /// <summary>
        /// Creates a filter comparing the specified property with a given value, using a specified operator.
        /// </summary>
        /// <remarks>
        /// If the operator is known in advance, methods such as <see cref="Equal"/> and <see cref="GreaterThan"/> usually
        /// allow for better readability. This method is intended for situations where the operator is only known dynamically.
        /// </remarks>
        /// <param name="propertyName">The name of the property. Must not be null.</param>
        /// <param name="propertyValue">The value to compare against. May be null, which indicates
        /// a value with <see cref="Value.NullValue"/> set.</param>
        /// <param name="op">The comparison operator to use. Must be one of the <see cref="Operator"/> values,
        /// and not <c>Unspecified</c>.</param>
        /// <returns>The newly created filter.</returns>
        public static Filter Property(string propertyName, Value propertyValue, Operator op)
        {
            GaxPreconditions.CheckArgument(Enum.IsDefined(typeof(Operator), op) && op != Operator.Unspecified,
                nameof(op), "Operator must be a defined enum value and not Unspecified");
            return new Filter
            {
                PropertyFilter = new PropertyFilter
                {
                    Op = op,
                    Property = new PropertyReference(propertyName),
                    Value = propertyValue ?? Value.ForNull(),
                }
            };
        }
    }
}
