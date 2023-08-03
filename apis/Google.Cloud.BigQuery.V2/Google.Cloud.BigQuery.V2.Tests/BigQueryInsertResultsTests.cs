// Copyright 2020 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Apis.Bigquery.v2.Data.TableDataInsertAllResponse;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryInsertResultsTests
    {
        private readonly BigQueryClient _client;

        public BigQueryInsertResultsTests()
        {
            _client = new DerivedBigQueryClient();
        }

        public static IEnumerable<object[]> NotNullableConstructorParametersData
        {
            get
            {
                yield return new object[] { null, new InsertOptions(), new List<BigQueryInsertRow>().AsReadOnly(), new TableDataInsertAllResponse() };
                yield return new object[] { new DerivedBigQueryClient(), new InsertOptions(), null, new TableDataInsertAllResponse() };
                yield return new object[] { new DerivedBigQueryClient(), new InsertOptions(), new List<BigQueryInsertRow>().AsReadOnly(), null };
            }
        }

        [Theory]
        [MemberData(nameof(NotNullableConstructorParametersData))]
        public void Constructor_NullParameters_Fail(
            BigQueryClient client, InsertOptions options, IReadOnlyList<BigQueryInsertRow> rows, TableDataInsertAllResponse response) =>
            Assert.Throws<ArgumentNullException>(() => new BigQueryInsertResults(client, options, rows, response));

        [Fact]
        public void Constructor_NullOptions() =>
            Assert.NotNull(new BigQueryInsertResults(_client, null, new List<BigQueryInsertRow>(), new TableDataInsertAllResponse()));

        public static IEnumerable<object[]> NoErrorsData
        {
            get
            {
                yield return new object[] { new TableDataInsertAllResponse() };
                yield return new object[] { new TableDataInsertAllResponse { InsertErrors = new List<InsertErrorsData>() } };
                yield return new object[] { new TableDataInsertAllResponse { InsertErrors = new List<InsertErrorsData> { null, null, null } } };
            }
        }

        [Theory]
        [MemberData(nameof(NoErrorsData))]
        public void AllRowsInserted(TableDataInsertAllResponse response)
        {
            BigQueryInsertResults results = new BigQueryInsertResults(
                _client, 
                new InsertOptions(), 
                new List<BigQueryInsertRow> { new BigQueryInsertRow() },
                response);

            Assert.Equal(BigQueryInsertStatus.AllRowsInserted, results.Status);
            Assert.Equal(0, results.OriginalRowsWithErrors);
            Assert.Equal(1, results.InsertAttemptRowCount);
            Assert.Empty(results.Errors);
            Assert.Same(results, results.ThrowOnNoneInserted());
            Assert.Same(results, results.ThrowOnNotAllInserted());
            Assert.Same(results, results.ThrowOnAnyError());
        }

        [Fact]
        public void SomeRowsInserted()
        {
            ErrorProto row1Error1 = new ErrorProto { Location = "field_1", Reason = "reason_1", Message = "message_1" };
            ErrorProto row1Error2 = new ErrorProto { Location = "field_2", Message = "message_2" };
            InsertErrorsData row1List1 = new InsertErrorsData { Index = 1, Errors = new List<ErrorProto> { row1Error1, row1Error2 } };

            ErrorProto row5Error1 = new ErrorProto { Location = "field_3", Reason = "reason_3" };
            InsertErrorsData row5List1 = new InsertErrorsData { Index = 5, Errors = new List<ErrorProto> { row5Error1 } };

            InsertErrorsData row6List1 = new InsertErrorsData { Index = 6 };

            ErrorProto row1Error3 = new ErrorProto { Location = "field_4", Reason = "reason_4", Message = "message_4" };
            InsertErrorsData row1List2 = new InsertErrorsData { Index = 1, Errors = new List<ErrorProto> { row1Error3 } };

            TableDataInsertAllResponse response = new TableDataInsertAllResponse
            {
                InsertErrors = new List<InsertErrorsData>
                {
                    row1List1,
                    row5List1,
                    row6List1,
                    row1List2
                }
            };

            IReadOnlyList<BigQueryInsertRow> rows = Enumerable.Range(0, 8).Select(_ => new BigQueryInsertRow()).ToList().AsReadOnly();

            List<BigQueryInsertRowErrors> expectedInsertRowErrors = new List<BigQueryInsertRowErrors>
            {
                new BigQueryInsertRowErrors(rows[1], new List<InsertErrorsData> { row1List1, row1List2 }),
                new BigQueryInsertRowErrors(rows[5], new List<InsertErrorsData> { row5List1 }),
                new BigQueryInsertRowErrors(rows[6], new List<InsertErrorsData> { row6List1 }),
            };
            List<SingleError> expectedSingleErrors = expectedInsertRowErrors.SelectMany(rowError => rowError).ToList();

            BigQueryInsertResults results = new BigQueryInsertResults(
                _client,
                new InsertOptions { SkipInvalidRows = true },
                rows,
                response);

            Assert.Equal(BigQueryInsertStatus.SomeRowsInserted, results.Status);
            Assert.Equal(3, results.OriginalRowsWithErrors);
            Assert.Equal(8, results.InsertAttemptRowCount);
            AssertErrorsEqual(expectedInsertRowErrors, results);
            Assert.Same(results, results.ThrowOnNoneInserted());
            AssertException(results.ThrowOnNotAllInserted, expectedSingleErrors, BigQueryInsertStatus.SomeRowsInserted);
            AssertException(results.ThrowOnAnyError, expectedSingleErrors, BigQueryInsertStatus.SomeRowsInserted);
        }

        [Fact]
        public void NoRowsInserted_NoSkip()
        {
            ErrorProto row1Error1 = new ErrorProto { Location = "field_1", Reason = "reason_1", Message = "message_1" };
            ErrorProto row1Error2 = new ErrorProto { Location = "field_2", Message = "message_2" };
            InsertErrorsData row1List1 = new InsertErrorsData { Index = 1, Errors = new List<ErrorProto> { row1Error1, row1Error2 } };

            ErrorProto row5Error1 = new ErrorProto { Location = "field_3", Reason = "reason_3" };
            InsertErrorsData row5List1 = new InsertErrorsData { Index = 5, Errors = new List<ErrorProto> { row5Error1 } };

            InsertErrorsData row6List1 = new InsertErrorsData { Index = 6 };

            ErrorProto row1Error3 = new ErrorProto { Location = "field_4", Reason = "reason_4", Message = "message_4" };
            InsertErrorsData row1List2 = new InsertErrorsData { Index = 1, Errors = new List<ErrorProto> { row1Error3 } };

            TableDataInsertAllResponse response = new TableDataInsertAllResponse
            {
                InsertErrors = new List<InsertErrorsData>
                {
                    row1List1,
                    row5List1,
                    row6List1,
                    row1List2
                }
            };

            IReadOnlyList<BigQueryInsertRow> rows = Enumerable.Range(0, 8).Select(_ => new BigQueryInsertRow()).ToList().AsReadOnly();

            // We don't need to have errors for all rows to know that no rows were inserted.
            // If SkipInvalidRows is not set to true, then even if only one row has errors, no rows are inserted.
            List<BigQueryInsertRowErrors> expectedInsertRowErrors = new List<BigQueryInsertRowErrors>
            {
                new BigQueryInsertRowErrors(rows[1], new List<InsertErrorsData> { row1List1, row1List2 }),
                new BigQueryInsertRowErrors(rows[5], new List<InsertErrorsData> { row5List1 }),
                new BigQueryInsertRowErrors(rows[6], new List<InsertErrorsData> { row6List1 }),
            };
            List<SingleError> expectedSingleErrors = expectedInsertRowErrors.SelectMany(rowError => rowError).ToList();

            BigQueryInsertResults results = new BigQueryInsertResults(
                _client,
                new InsertOptions(),
                rows,
                response);

            Assert.Equal(BigQueryInsertStatus.NoRowsInserted, results.Status);
            Assert.Equal(3, results.OriginalRowsWithErrors);
            Assert.Equal(8, results.InsertAttemptRowCount);
            AssertErrorsEqual(expectedInsertRowErrors, results);
            AssertException(results.ThrowOnNoneInserted, expectedSingleErrors, BigQueryInsertStatus.NoRowsInserted);
            AssertException(results.ThrowOnNotAllInserted, expectedSingleErrors, BigQueryInsertStatus.NoRowsInserted);
            AssertException(results.ThrowOnAnyError, expectedSingleErrors, BigQueryInsertStatus.NoRowsInserted);
        }

        [Fact]
        public void NoRowsInserted_AllInvalid()
        {
            ErrorProto row0Error1 = new ErrorProto { Location = "field_1", Reason = "reason_1", Message = "message_1" };
            ErrorProto row0Error2 = new ErrorProto { Location = "field_2", Message = "message_2" };
            InsertErrorsData row0List1 = new InsertErrorsData { Index = 0, Errors = new List<ErrorProto> { row0Error1, row0Error2 } };

            ErrorProto row1Error1 = new ErrorProto { Location = "field_3", Reason = "reason_3" };
            InsertErrorsData row1List1 = new InsertErrorsData { Index = 1, Errors = new List<ErrorProto> { row1Error1 } };

            InsertErrorsData row2List1 = new InsertErrorsData { Index = 2 };

            ErrorProto row0Error3 = new ErrorProto { Location = "field_4", Reason = "reason_4", Message = "message_4" };
            InsertErrorsData row0List2 = new InsertErrorsData { Index = 0, Errors = new List<ErrorProto> { row0Error3 } };

            TableDataInsertAllResponse response = new TableDataInsertAllResponse
            {
                InsertErrors = new List<InsertErrorsData>
                {
                    row0List1,
                    row1List1,
                    row2List1,
                    row0List2
                }
            };

            IReadOnlyList<BigQueryInsertRow> rows = Enumerable.Range(0, 3).Select(_ => new BigQueryInsertRow()).ToList().AsReadOnly();

            List<BigQueryInsertRowErrors> expectedInsertRowErrors = new List<BigQueryInsertRowErrors>
            {
                new BigQueryInsertRowErrors(rows[0], new List<InsertErrorsData> { row0List1, row0List2 }),
                new BigQueryInsertRowErrors(rows[1], new List<InsertErrorsData> { row1List1 }),
                new BigQueryInsertRowErrors(rows[2], new List<InsertErrorsData> { row2List1 }),
            };
            List<SingleError> expectedSingleErrors = expectedInsertRowErrors.SelectMany(rowError => rowError).ToList();

            BigQueryInsertResults results = new BigQueryInsertResults(
                _client,
                new InsertOptions { SkipInvalidRows = true },
                rows,
                response);

            Assert.Equal(BigQueryInsertStatus.NoRowsInserted, results.Status);
            Assert.Equal(3, results.OriginalRowsWithErrors);
            Assert.Equal(3, results.InsertAttemptRowCount);
            AssertErrorsEqual(expectedInsertRowErrors, results);
            AssertException(results.ThrowOnNoneInserted, expectedSingleErrors, BigQueryInsertStatus.NoRowsInserted);
            AssertException(results.ThrowOnNotAllInserted, expectedSingleErrors, BigQueryInsertStatus.NoRowsInserted);
            AssertException(results.ThrowOnAnyError, expectedSingleErrors, BigQueryInsertStatus.NoRowsInserted);
        }

        [Fact]
        public void UnexpectedResponse()
        {
            ErrorProto row1Error1 = new ErrorProto { Location = "field_1", Reason = "reason_1", Message = "message_1" };
            ErrorProto row1Error2 = new ErrorProto { Location = "field_2", Message = "message_2" };
            InsertErrorsData row1List1 = new InsertErrorsData { Index = 1, Errors = new List<ErrorProto> { row1Error1, row1Error2 } };

            ErrorProto row5Error1 = new ErrorProto { Location = "field_3", Reason = "reason_3" };
            InsertErrorsData row5List1 = new InsertErrorsData { Index = 5, Errors = new List<ErrorProto> { row5Error1 } };

            InsertErrorsData row6List1 = new InsertErrorsData { Index = 6 };

            ErrorProto row1Error3 = new ErrorProto { Location = "field_4", Reason = "reason_4", Message = "message_4" };
            InsertErrorsData row1List2 = new InsertErrorsData { Index = 1, Errors = new List<ErrorProto> { row1Error3 } };

            // Row 11, which we don't have
            ErrorProto row11Error1 = new ErrorProto { Location = "field_5", Reason = "reason_5", Message = "message_5" };
            InsertErrorsData row11List1 = new InsertErrorsData { Index = 11, Errors = new List<ErrorProto> { row11Error1 } };

            // No row index specified
            ErrorProto rowNullError1 = new ErrorProto { Location = "field_6", Reason = "reason_6", Message = "message_6" };
            InsertErrorsData rowNullList1 = new InsertErrorsData { Index = null, Errors = new List<ErrorProto> { rowNullError1 } };

            TableDataInsertAllResponse response = new TableDataInsertAllResponse
            {
                InsertErrors = new List<InsertErrorsData>
                {
                    row1List1,
                    row5List1,
                    null, // Ignored
                    row6List1,
                    row11List1,
                    row1List2,
                    rowNullList1
                }
            };

            IReadOnlyList<BigQueryInsertRow> rows = Enumerable.Range(0, 8).Select(_ => new BigQueryInsertRow()).ToList().AsReadOnly();

            List<BigQueryInsertRowErrors> expectedInsertRowErrors = new List<BigQueryInsertRowErrors>
            {
                new BigQueryInsertRowErrors(rows[1], new List<InsertErrorsData> { row1List1, row1List2 }),
                new BigQueryInsertRowErrors(rows[5], new List<InsertErrorsData> { row5List1 }),
                new BigQueryInsertRowErrors(rows[6], new List<InsertErrorsData> { row6List1 }),
                new BigQueryInsertRowErrors(null, new List<InsertErrorsData> { row11List1 }),
                new BigQueryInsertRowErrors(null, new List<InsertErrorsData> { rowNullList1 }),
            };
            List<SingleError> expectedSingleErrors = expectedInsertRowErrors.SelectMany(rowError => rowError).ToList();

            BigQueryInsertResults results = new BigQueryInsertResults(
                _client,
                new InsertOptions { SkipInvalidRows = true },
                rows,
                response);

            Assert.Equal(BigQueryInsertStatus.SomeRowsInserted, results.Status);
            Assert.Equal(3, results.OriginalRowsWithErrors);
            Assert.Equal(8, results.InsertAttemptRowCount);
            AssertErrorsEqual(expectedInsertRowErrors, results);
            Assert.Same(results, results.ThrowOnNoneInserted());
            AssertException(results.ThrowOnNotAllInserted, expectedSingleErrors, BigQueryInsertStatus.SomeRowsInserted);
            AssertException(results.ThrowOnAnyError, expectedSingleErrors, BigQueryInsertStatus.SomeRowsInserted);
        }

        private void AssertException(Func<BigQueryInsertResults> throwing, List<SingleError> expectedErrors, BigQueryInsertStatus expectedStatus)
        {
            GoogleApiException exception = Assert.Throws<GoogleApiException>(throwing);
            Assert.Equal("fake_service_name", exception.ServiceName);
            Assert.Contains(expectedStatus.ToString(), exception.Message);
            Assert.Equal(expectedErrors, exception.Error.Errors, new SingleErrorEqualityComparer());
        }

        public class DerivedBigQueryClient : BigQueryClient
        {
            private readonly BigqueryService _service = new DerivedBigQueryService();
            public override BigqueryService Service => _service;
        }

        public class DerivedBigQueryService : BigqueryService
        {
            public override string Name => "fake_service_name";
        }

        private void AssertErrorsEqual(List<BigQueryInsertRowErrors> expectedErrors, BigQueryInsertResults results)
        {
            // In xUnit 2.4.2, we were able to use Assert.Equal with a custom equality comparer.
            // That no longer appears to work in 2.5.0; it's unclear why at the moment.
            var actualErrors = results.Errors.ToList();
            Assert.Equal(expectedErrors.Count, actualErrors.Count);
            for (int i = 0; i < expectedErrors.Count; i++)
            {
                var expected = expectedErrors[i];
                var actual = actualErrors[i];
                Assert.Equal(expected.OriginalRowIndex, actual.OriginalRowIndex);
                Assert.Equal(expected.OriginalRow, actual.OriginalRow);
                Assert.Equal(expected, actual, new SingleErrorEqualityComparer());
            }
        }

        public class SingleErrorEqualityComparer : IEqualityComparer<SingleError>
        {
            public bool Equals(SingleError x, SingleError y) =>
                string.Equals(x?.ToString(), y?.ToString(), StringComparison.InvariantCulture);

            public int GetHashCode(SingleError obj) => throw new NotImplementedException();
        }
    }
}
