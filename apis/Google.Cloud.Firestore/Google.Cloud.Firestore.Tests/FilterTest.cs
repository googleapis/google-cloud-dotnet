// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using System;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;
using StructuredQuery = Google.Cloud.Firestore.V1.StructuredQuery;
using ProtoFilter = Google.Cloud.Firestore.V1.StructuredQuery.Types.Filter;
using ProtoCompositeFilter = Google.Cloud.Firestore.V1.StructuredQuery.Types.CompositeFilter;

namespace Google.Cloud.Firestore.Tests;

public class FilterTest
{
    private static readonly FirestoreDb s_db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());

    private static Query GetEmptyQuery() => s_db.Collection("col");

    // Individual filter methods, for coverage and to guard against copy/paste errors
    private static FieldReference GetField(string path) => new FieldReference { FieldPath = path };
    private static ProtoFilter GetFilter(UnaryFilter filter) => new ProtoFilter { UnaryFilter = filter };
    private static ProtoFilter GetFilter(FieldFilter filter) => new ProtoFilter { FieldFilter = filter };

    private static ProtoFilter GetCompositeAndFilter(params ProtoFilter[] filters) =>
        new ProtoFilter { CompositeFilter = new ProtoCompositeFilter { Op = ProtoCompositeFilter.Types.Operator.And, Filters = { filters } } };

    private static ProtoFilter GetCompositeOrFilter(params ProtoFilter[] filters) =>
        new ProtoFilter { CompositeFilter = new ProtoCompositeFilter { Op = ProtoCompositeFilter.Types.Operator.Or, Filters = { filters } } };

    [Fact]
    public void Where_EqualTo_String()
    {
        var query = GetEmptyQuery().Where(Filter.EqualTo("a.b", "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_UnserializableFilter()
    {
        // No serialization check when the filter is created.
        var filter = Filter.EqualTo("a.b", typeof(Filter));
        // When used as part of a query, we check that it can be serialized in that context.
        Assert.Throws<ArgumentException>(() => GetEmptyQuery().Where(filter));
    }

    [Fact]
    public void Where_EqualTo_FieldPath()
    {
        var query = GetEmptyQuery().Where(Filter.EqualTo(new FieldPath("a", "b"), "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_NotEqualTo_String()
    {
        var query = GetEmptyQuery().Where(Filter.NotEqualTo("a.b", "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.NotEqual, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_NotEqualTo_FieldPath()
    {
        var query = GetEmptyQuery().Where(Filter.NotEqualTo(new FieldPath("a", "b"), "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.NotEqual, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_LessThan_String()
    {
        var query = GetEmptyQuery().Where(Filter.LessThan("a.b", "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.LessThan, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_LessThan_FieldPath()
    {
        var query = GetEmptyQuery().Where(Filter.LessThan(new FieldPath("a", "b"), "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.LessThan, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_LessThanOrEqualTo_String()
    {
        var query = GetEmptyQuery().Where(Filter.LessThanOrEqualTo("a.b", "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.LessThanOrEqual, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_LessThanOrEqualTo_FieldPath()
    {
        var query = GetEmptyQuery().Where(Filter.LessThanOrEqualTo(new FieldPath("a", "b"), "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.LessThanOrEqual, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_ArrayContains_String()
    {
        var query = GetEmptyQuery().Where(Filter.ArrayContains("a.b", "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.ArrayContains, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_ArrayContains_FieldPath()
    {
        var query = GetEmptyQuery().Where(Filter.ArrayContains(new FieldPath("a", "b"), "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.ArrayContains, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_GreaterThan_String()
    {
        var query = GetEmptyQuery().Where(Filter.GreaterThan("a.b", "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.GreaterThan, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_GreaterThan_FieldPath()
    {
        var query = GetEmptyQuery().Where(Filter.GreaterThan(new FieldPath("a", "b"), "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.GreaterThan, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_GreaterThanOrEqualTo_String()
    {
        var query = GetEmptyQuery().Where(Filter.GreaterThanOrEqualTo("a.b", "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.GreaterThanOrEqual, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_GreaterThanOrEqualTo_FieldPath()
    {
        var query = GetEmptyQuery().Where(Filter.GreaterThanOrEqualTo(new FieldPath("a", "b"), "x"));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.GreaterThanOrEqual, Value = CreateValue("x") }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Theory]
    [InlineData(double.NaN)]
    [InlineData(float.NaN)]
    public void Where_SingleNaNFilter(object value)
    {
        var query = GetEmptyQuery().Where(Filter.EqualTo("a.b", value));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new UnaryFilter { Field = GetField("a.b"), Op = UnaryFilter.Types.Operator.IsNan }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_SingleNullFilter()
    {
        var query = GetEmptyQuery().Where(Filter.EqualTo("a.b", null));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new UnaryFilter { Field = GetField("a.b"), Op = UnaryFilter.Types.Operator.IsNull }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Theory]
    [InlineData(double.NaN)]
    [InlineData(float.NaN)]
    public void Where_NotSingleNaNFilter(object value)
    {
        var query = GetEmptyQuery().Where(Filter.NotEqualTo("a.b", value));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new UnaryFilter { Field = GetField("a.b"), Op = UnaryFilter.Types.Operator.IsNotNan }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_NotSingleNullFilter()
    {
        var query = GetEmptyQuery().Where(Filter.NotEqualTo("a.b", null));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new UnaryFilter { Field = GetField("a.b"), Op = UnaryFilter.Types.Operator.IsNotNull }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_CompositeFilter()
    {
        var query = GetEmptyQuery()
            .Where(Filter.And(Filter.GreaterThanOrEqualTo("a", "x"),
                              Filter.EqualTo("b", "y"),
                              Filter.EqualTo("c", "z")
                              )
                   );
        var expected = new StructuredQuery
        {
            Where = GetCompositeAndFilter(
                GetFilter(new FieldFilter { Field = GetField("a"), Op = FieldFilter.Types.Operator.GreaterThanOrEqual, Value = CreateValue("x") }),
                GetFilter(new FieldFilter { Field = GetField("b"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("y") }),
                GetFilter(new FieldFilter { Field = GetField("c"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("z") })
            ),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void NestedCompositeQuery()
    {
        var query = GetEmptyQuery().Where(
            Filter.Or(Filter.GreaterThanOrEqualTo("a", "x"),
                      Filter.And(Filter.EqualTo("b", "y"),
                                 Filter.EqualTo("c", "z"))));

        var protoFilter = GetCompositeOrFilter(
            GetFilter(new FieldFilter { Field = GetField("a"), Op = FieldFilter.Types.Operator.GreaterThanOrEqual, Value = CreateValue("x") }),
            GetCompositeAndFilter(
                GetFilter(new FieldFilter { Field = GetField("b"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("y") }),
                GetFilter(new FieldFilter { Field = GetField("c"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("z") })));

        var expected = new StructuredQuery
        {
            Where = protoFilter,
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void CombineQueryWithFilters()
    {
        var query = GetEmptyQuery().WhereEqualTo("a.b", "x").Where(Filter.EqualTo("a.c", "y"));
        var expected = new StructuredQuery
        {
            Where = GetCompositeAndFilter(
                GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("x") }),
                GetFilter(new FieldFilter { Field = GetField("a.c"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("y") })
            ),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void WhereIn_String()
    {
        var query = GetEmptyQuery().Where(Filter.InArray("a.b", new[] { 10, 20 }));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.In, Value = CreateArray(CreateValue(10), CreateValue(20)) }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void WhereIn_FieldPath()
    {
        var query = GetEmptyQuery().Where(Filter.InArray(new FieldPath("a", "b"), new[] { 10, 20 }));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.In, Value = CreateArray(CreateValue(10), CreateValue(20)) }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void WhereNotIn_String()
    {
        var query = GetEmptyQuery().Where(Filter.NotInArray("a.b", new[] { 10, 20 }));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.NotIn, Value = CreateArray(CreateValue(10), CreateValue(20)) }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void WhereNotIn_FieldPath()
    {
        var query = GetEmptyQuery().Where(Filter.NotInArray(new FieldPath("a", "b"), new[] { 10, 20 }));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.NotIn, Value = CreateArray(CreateValue(10), CreateValue(20)) }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    // See comments in WhereIn for details.
    [Fact]
    public void WhereIn_StringPath_StringValueThrows()
    {
        var empty = GetEmptyQuery();
        Assert.Throws<ArgumentException>(() => empty.Where(Filter.InArray("a.b", "value")));
    }

    [Fact]
    public void WhereIn_FieldPath_StringValueThrows()
    {
        var empty = GetEmptyQuery();
        Assert.Throws<ArgumentException>(() => empty.Where(Filter.InArray(new FieldPath("a", "b"), "value")));
    }

    [Fact]
    public void WhereIn_StringPath_NullValueThrows()
    {
        var empty = GetEmptyQuery();
        Assert.Throws<ArgumentNullException>(() => empty.Where(Filter.InArray("a.b", null)));
    }

    [Fact]
    public void WhereIn_FieldPath_NullValueThrows()
    {
        var empty = GetEmptyQuery();
        Assert.Throws<ArgumentNullException>(() => empty.Where(Filter.InArray(new FieldPath("a", "b"), null)));
    }

    [Fact]
    public void WhereNotIn_StringPath_StringValueThrows()
    {
        var empty = GetEmptyQuery();
        Assert.Throws<ArgumentException>(() => empty.Where(Filter.NotInArray("a.b", "value")));
    }

    [Fact]
    public void WhereNotIn_FieldPath_StringValueThrows()
    {
        var empty = GetEmptyQuery();
        Assert.Throws<ArgumentException>(() => empty.Where(Filter.NotInArray(new FieldPath("a", "b"), "value")));
    }

    [Fact]
    public void WhereNotIn_StringPath_NullValueThrows()
    {
        var empty = GetEmptyQuery();
        Assert.Throws<ArgumentNullException>(() => empty.Where(Filter.NotInArray("a.b", null)));
    }

    [Fact]
    public void WhereNotIn_FieldPath_NullValueThrows()
    {
        var empty = GetEmptyQuery();
        Assert.Throws<ArgumentNullException>(() => empty.Where(Filter.NotInArray(new FieldPath("a", "b"), null)));
    }

    [Fact]
    public void WhereArrayContainsAny_String()
    {
        var query = GetEmptyQuery().Where(Filter.ArrayContainsAny("a.b", new[] { 10, 20 }));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.ArrayContainsAny, Value = CreateArray(CreateValue(10), CreateValue(20)) }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void WhereArrayContainsAny_FieldPath()
    {
        var query = GetEmptyQuery().Where(Filter.ArrayContainsAny(new FieldPath("a", "b"), new[] { 10, 20 }));
        var expected = new StructuredQuery
        {
            Where = GetFilter(new FieldFilter { Field = GetField("a.b"), Op = FieldFilter.Types.Operator.ArrayContainsAny, Value = CreateArray(CreateValue(10), CreateValue(20)) }),
            From = { new CollectionSelector { CollectionId = "col" } }
        };
        Assert.Equal(expected, query.ToStructuredQuery());
    }

    [Fact]
    public void Where_FiltersThatProhibitNullValue()
    {
        // Just for operations which prohibit them
        var query = GetEmptyQuery();
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.LessThan("a.b", null)));
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.LessThanOrEqualTo("a.b", null)));
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.GreaterThan("a.b", null)));
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.GreaterThanOrEqualTo("a.b", null)));
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.ArrayContains("a.b", null)));
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.InArray("a.b", null)));
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.ArrayContainsAny("a.b", null)));

        var fieldPath = new FieldPath("a", "b");
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.LessThan(fieldPath, null)));
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.LessThanOrEqualTo(fieldPath, null)));
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.GreaterThan(fieldPath, null)));
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.GreaterThanOrEqualTo(fieldPath, null)));
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.ArrayContains(fieldPath, null)));
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.InArray(fieldPath, null)));
        Assert.ThrowsAny<ArgumentException>(() => query.Where(Filter.ArrayContainsAny(fieldPath, null)));
    }
}
