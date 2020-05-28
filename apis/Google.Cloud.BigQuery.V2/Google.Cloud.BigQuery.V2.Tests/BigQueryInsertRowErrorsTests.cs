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

using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Apis.Bigquery.v2.Data.TableDataInsertAllResponse;
using static Google.Cloud.BigQuery.V2.Tests.BigQueryInsertResultsTests;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryInsertRowErrorsTests
    {
        [Fact]
        public void Constructor_NullErrors()
        {
            Assert.Throws<ArgumentException>(() => new BigQueryInsertRowErrors(new BigQueryInsertRow(), null));
        }

        [Fact]
        public void Constructor_EmptyErrors()
        {
            Assert.Throws<ArgumentException>(() => new BigQueryInsertRowErrors(
                new BigQueryInsertRow(),
                new List<InsertErrorsData>()));
        }

        [Fact]
        public void Constructor_NullRow_NoErrorDetail()
        {
            List<InsertErrorsData> errors = new List<InsertErrorsData>
            {
                new InsertErrorsData { }
            };

            SingleError expected = new SingleError
            {
                Message = "Error in row unknown."
            };

            // This is allowed in case there's no information (index)
            // to associate errors to a row.
            BigQueryInsertRowErrors insertRowErrors = new BigQueryInsertRowErrors(null, errors);
            Assert.Single(insertRowErrors);
            Assert.Contains(expected, insertRowErrors, new SingleErrorEqualityComparer());
            Assert.Null(insertRowErrors.OriginalRow);
            Assert.Null(insertRowErrors.OriginalRowIndex);
        }

        [Fact]
        public void Constructor_NullRow_ErrorDetail()
        {
            List<InsertErrorsData> errors = new List<InsertErrorsData>
            {
                new InsertErrorsData
                {
                    Index = null,
                    Errors = new List<ErrorProto>
                    {
                        new ErrorProto
                        {
                            Reason = "Very bad reason",
                            Message = "A very bad error occurred"
                        }
                    }
                }
            };

            SingleError expected = new SingleError
            {
                Reason = "Very bad reason",
                Message = "Error in row unknown. A very bad error occurred"
            };

            // This is allowed in case there's no information (index)
            // to associate errors to a row.
            BigQueryInsertRowErrors insertRowErrors = new BigQueryInsertRowErrors(null, errors);
            Assert.Single(insertRowErrors);
            Assert.Contains(expected, insertRowErrors, new SingleErrorEqualityComparer());
            Assert.Null(insertRowErrors.OriginalRow);
            Assert.Null(insertRowErrors.OriginalRowIndex);
        }

        [Fact]
        public void OriginalRow()
        {
            List<InsertErrorsData> errors = new List<InsertErrorsData>
            {
                new InsertErrorsData
                {
                    Index = 1,
                    Errors = new List<ErrorProto>
                    {
                        new ErrorProto
                        {
                            Reason = "Reason 1",
                            Message = "A very bad error 1 occurred",
                            Location = "field_1"
                        },
                    }
                },
            };

            IList<SingleError> expected = new List<SingleError>
            {
                new SingleError
                {
                    Reason = "Reason 1",
                    Message = "Error in row 1. A very bad error 1 occurred",
                    Location = "field_1"
                },
            };

            BigQueryInsertRow row = new BigQueryInsertRow();

            BigQueryInsertRowErrors insertRowErrors = new BigQueryInsertRowErrors(row, errors);
            Assert.Equal(expected, insertRowErrors.ToList(), new SingleErrorEqualityComparer());
            Assert.Same(row, insertRowErrors.OriginalRow);
            Assert.Equal(1, insertRowErrors.OriginalRowIndex);
        }

        [Fact]
        public void GetEnumerator()
        {
            List<InsertErrorsData> errors = new List<InsertErrorsData>
            {
                new InsertErrorsData
                {
                    Index = 1,
                    Errors = new List<ErrorProto>
                    {
                        new ErrorProto
                        {
                            Reason = "Reason 1",
                            Message = "A very bad error 1 occurred",
                            Location = "field_1"
                        },
                        new ErrorProto
                        {
                            Reason = "Reason 2",
                            Location = "field_2"
                        }
                    }
                },
                new InsertErrorsData { },
                new InsertErrorsData
                {
                    Index = 1,
                    Errors = new List<ErrorProto>
                    {
                        new ErrorProto
                        {
                            Reason = "Reason 3",
                            Message = "A very bad error 3 occurred",
                            Location = "field_3"
                        }
                    }
                },
                null
            };

            IList<SingleError> expected = new List<SingleError>
            {
                new SingleError
                {
                    Reason = "Reason 1",
                    Message = "Error in row 1. A very bad error 1 occurred",
                    Location = "field_1"
                },
                new SingleError
                {
                    Reason = "Reason 2",
                    Message = "Error in row 1. ",
                    Location = "field_2"
                },
                new SingleError
                {
                    Reason = "Reason 3",
                    Message = "Error in row 1. A very bad error 3 occurred",
                    Location = "field_3"
                }
            };

            // This is allowed in case there's no information (index)
            // to associate errors to a row or the index obtained in the response is out of range (unlikely).
            BigQueryInsertRowErrors insertRowErrors = new BigQueryInsertRowErrors(null, errors);
            Assert.Equal(expected, insertRowErrors.ToList(), new SingleErrorEqualityComparer());
            Assert.Null(insertRowErrors.OriginalRow);
            Assert.Equal(1, insertRowErrors.OriginalRowIndex);
        }
    }
}
